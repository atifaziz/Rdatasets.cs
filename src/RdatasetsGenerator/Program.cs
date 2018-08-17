namespace RdatasetsGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using Dsv;
    using MoreLinq.Experimental;
    using static MoreLinq.Extensions.FoldExtension;
    using static MoreLinq.Extensions.IndexExtension;

    sealed class Program
    {
        sealed class ColumnType
        {
            public static readonly ColumnType Int = new ColumnType("int");
            public static readonly ColumnType NullableInt = Int.ToNullable();
            public static readonly ColumnType Double = new ColumnType("double");
            public static readonly ColumnType NullableDouble = Double.ToNullable();
            public static readonly ColumnType Boolean = new ColumnType("bool", s => s[0] == 'T' ? "true" : "false");
            public static readonly ColumnType NullableBoolean = Boolean.ToNullable();
            public static readonly ColumnType String = new ColumnType("string", s => "\"" + CSharpString.Encode(s) + "\"").ToNullable(string.Empty);

            public readonly string SourceName;
            readonly Func<string, string> _encoder;

            ColumnType(string sourceName, Func<string, string> encoder = null) =>
                (SourceName, _encoder) = (sourceName, encoder);

            public string Encode(string s) =>
                _encoder != null ? _encoder?.Invoke(s) : s;

            ColumnType ToNullable(string q = null) =>
                new ColumnType(SourceName + (q ?? "?"), s => s == "NA" ? "null" : _encoder(s));
        }

        static void Wain(string[] args)
        {
            var rootPath = args.FirstOrDefault() ?? throw new Exception("Missing path to the root of the Rdatasets repository.");
            var targetPath = args.ElementAtOrDefault(1) ?? Environment.CurrentDirectory;

            bool AnyNA(IEnumerable<string> ss) => ss.Any(s => s == "NA");

            string CSharpId(string s)
            {
                s = (CSharpKeyword.Is(s) ? "@" : null) + Regex.Replace(s, "[^a-zA-Z0-9_]", "_");
                return s[0] >= '0' && s[0] <= '9' ? "_" + s : s;
            }

            const NumberStyles intStyles = NumberStyles.Integer;
            const NumberStyles numberStyles = NumberStyles.Number
                                            & ~NumberStyles.AllowTrailingSign
                                            & ~NumberStyles.AllowThousands;

            var dss =
                from e in
                    File.ReadLines(Path.Combine(rootPath, "datasets.csv"))
                        .ParseCsv(hr => new
                        {
                            Package      = hr.GetFirstIndex("Package"      , StringComparison.OrdinalIgnoreCase),
                            Item         = hr.GetFirstIndex("Item"         , StringComparison.OrdinalIgnoreCase),
                            Title        = hr.GetFirstIndex("Title"        , StringComparison.OrdinalIgnoreCase),
                            Rows         = hr.GetFirstIndex("Rows"         , StringComparison.OrdinalIgnoreCase),
                            Cols         = hr.GetFirstIndex("Cols"         , StringComparison.OrdinalIgnoreCase),
                            HasLogical   = hr.GetFirstIndex("has_logical"  , StringComparison.OrdinalIgnoreCase),
                            HasBinary    = hr.GetFirstIndex("has_binary"   , StringComparison.OrdinalIgnoreCase),
                            HasNumeric   = hr.GetFirstIndex("has_numeric"  , StringComparison.OrdinalIgnoreCase),
                            HasCharacter = hr.GetFirstIndex("has_character", StringComparison.OrdinalIgnoreCase),
                            Csv          = hr.GetFirstIndex("CSV"          , StringComparison.OrdinalIgnoreCase),
                            Doc          = hr.GetFirstIndex("Doc"          , StringComparison.OrdinalIgnoreCase),
                        })
                select new
                {
                    RowNumber    = e.Row.LineNumber - 1,
                    Package      = e.Row[e.Header.Package],
                    Item         = e.Row[e.Header.Item],
                    Title        = e.Row[e.Header.Title],
                    Rows         = int.Parse(e.Row[e.Header.Rows], NumberStyles.None, CultureInfo.InvariantCulture),
                    Cols         = int.Parse(e.Row[e.Header.Cols], NumberStyles.None, CultureInfo.InvariantCulture),
                    HasLogical   = bool.Parse(e.Row[e.Header.HasLogical]),
                    HasBinary    = bool.Parse(e.Row[e.Header.HasBinary]),
                    HasNumeric   = bool.Parse(e.Row[e.Header.HasNumeric]),
                    HasCharacter = bool.Parse(e.Row[e.Header.HasCharacter]),
                    Csv          = e.Row[e.Header.Csv],
                    Doc          = e.Row[e.Header.Doc],
                }
                into e
                where e.Rows > 0
                join f in
                    from path in Directory.EnumerateFiles(Path.Combine(rootPath, "doc"), "*.rst", SearchOption.AllDirectories)
                    select
                        path.Split(Path.DirectorySeparatorChar)
                            .TakeLast(3)
                            .Fold((pkg, _, item) => new
                            {
                                Package = pkg,
                                Item = Path.GetFileNameWithoutExtension(item),
                                /*
                                Format =
                                    File.ReadLines(fp)
                                        .Select(e => new
                                        {
                                            Name = Regex.Match(e, @"(?<=^``)[^`]+(?=``)").Value,
                                            Line = e,
                                        })
                                        .Segment(e => e.Name.Length > 0)
                                        .Skip(1)
                                        .Select(ss => ss.TakeWhile(s => !string.IsNullOrWhiteSpace(s.Line))
                                                        .Index()
                                                        .Partition(e => e.Key == 0, (name, desc) => new
                                                        {
                                                            Name = name.Single().Value.Name,
                                                            Description = desc.Select(e => e.Value.Line.Trim())
                                                                              .ToDelimitedString(" "),
                                                        }))
                                        .ToArray(),
                                */
                                Format2 =
                                    from Match m in Regex.Matches(File.ReadAllText(path),
                                                                  @"^(?:``)?([a-zA-Z][a-zA-Z0-9.]*)(?:``)?\r?$\n( {4}.+\r?$\n)+",
                                                                  RegexOptions.Multiline)
                                    select new
                                    {
                                        Name = m.Groups[1].Value,
                                        Desc = string.Join(" ", from Capture c in m.Groups[2].Captures
                                                                select c.Value.Trim()),
                                    },
                            })
                    on new { e.Package, e.Item } equals new { f.Package, f.Item }
                    into j
                //where f.Cols != e.Format2.Count()
                let f = j.SingleOrDefault() // ?? throw new Exception($"{e.Package}/{e.Item} not found.")
                where f != null
                select new
                {
                    e.RowNumber,
                    e.Package,
                    e.Item,
                    e.Title,
                    e.Rows,
                    e.Cols,
                    Format = f.Format2.ToArray()
                }
                into e
                join f in
                    from path in Directory.EnumerateFiles(Path.Combine(rootPath, "csv"), "*.csv", SearchOption.AllDirectories)
                    select
                        path.Split(Path.DirectorySeparatorChar)
                            .TakeLast(2)
                            .Fold((pkg, item) => new
                            {
                                Package = pkg,
                                Item = Path.GetFileNameWithoutExtension(item),
                                Columns =
                                    File.ReadLines(path)
                                        .ParseCsv()
                                        .First()
                                        .Index()
                                        .SkipWhile(s => s.Value.Length == 0)
                                        .ToArray(),
                                Rows = File.ReadLines(path).ParseCsv(hr => hr).Memoize(),
                            })
                    on new { e.Package, e.Item } equals new { f.Package, f.Item }
                    into j
                let f = j.SingleOrDefault()
                where e.Cols == f.Columns.Length
                select new
                {
                    e.RowNumber,
                    e.Package,
                    e.Item,
                    ItemIdName = CSharpId(e.Item),
                    e.Title,
                    e.Format,
                    Columns = Enumerable.ToArray(
                        from c in f.Columns
                        let vs = from d in f.Rows select d.Row[c.Key]
                        select new
                        {
                            Name = c.Value,
                            IdName = CSharpId(c.Value) + (c.Value == e.Item ? "_" : null),
                            Index = c.Key,
                            Type = vs.All(v => v == "TRUE" || v == "FALSE")
                                 ? (AnyNA(vs) ? ColumnType.NullableBoolean : ColumnType.Boolean)
                                 : vs.All(v => int.TryParse(v, intStyles, CultureInfo.InvariantCulture, out _))
                                 ? (AnyNA(vs) ? ColumnType.NullableInt : ColumnType.Int)
                                 : vs.All(v => double.TryParse(v, numberStyles, CultureInfo.InvariantCulture, out _))
                                 ? (AnyNA(vs) ? ColumnType.NullableDouble : ColumnType.Double)
                                 : ColumnType.String
                        }),
                    f.Rows,
                };

            var utf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

            foreach (var ds in dss)
            {
                Console.WriteLine(ds.Package + "/" + ds.Item);

                var packagePath = Path.Combine(targetPath, ds.Package);
                Directory.CreateDirectory(packagePath);

                using (var stream = File.Create(Path.Combine(packagePath, ds.Item + ".cs")))
                using (var writer = new StreamWriter(stream, utf8))
                {
                    writer.WriteLine($@"// ReSharper disable All

namespace Rdatasets.{ds.Package}
{{
    using System.Collections.Generic;

    /// <summary>
    /// {ds.Title}
    /// </summary>

    public class {ds.ItemIdName}
    {{{
        string.Join(string.Empty,
            from c in ds.Columns
            select $@"
        public readonly {c.Type.SourceName} {c.IdName};")}

        public {ds.ItemIdName}({
            string.Join(", ", from c in ds.Columns
                              select c.Type.SourceName + " " + c.IdName)})
        {{{string.Join(string.Empty, from c in ds.Columns select $@"
            this.{c.IdName} = {c.IdName};")}
        }}

        public static IEnumerable<{ds.ItemIdName}> Data
        {{
            get
            {{{
                string.Join(string.Empty, from d in ds.Rows
                                          select $@"
                yield return new {ds.ItemIdName}({
                    string.Join(", ", from c in ds.Columns
                    select c.Type.Encode(d.Row[c.Index]))});")}
            }}
        }}
    }}
}}");
                }
            }
        }

        static class CSharpKeyword
        {
            static readonly HashSet<string> KeywordSet = new HashSet<string>(new[]
            {
                // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/

                "abstract", "as", "base", "bool",
                "break", "byte", "case", "catch",
                "char", "checked", "class", "const",
                "continue", "decimal", "default", "delegate",
                "do", "double", "else", "enum",
                "event", "explicit", "extern", "false",
                "finally", "fixed", "float", "for",
                "foreach", "goto", "if", "implicit",
                "in", "int", "interface", "internal",
                "is", "lock", "long", "namespace",
                "new", "null", "object", "operator",
                "out", "override", "params", "private",
                "protected", "public", "readonly", "ref",
                "return", "sbyte", "sealed", "short",
                "sizeof", "stackalloc", "static", "string",
                "struct", "switch", "this", "throw",
                "true", "try", "typeof", "uint",
                "ulong", "unchecked", "unsafe", "ushort",
                "using"/*, "using static"*/, "virtual", "void",
                "volatile", "while"
            });

            public static bool Is(string s) => KeywordSet.Contains(s);
        }

        static class CSharpString
        {
            // Credit: https://stackoverflow.com/a/41934438/6682

            static readonly char[] ToEscape = "\0\x1\x2\x3\x4\x5\x6\a\b\t\n\v\f\r\xe\xf\x10\x11\x12\x13\x14\x15\x16\x17\x18\x19\x1a\x1b\x1c\x1d\x1e\x1f\"\\".ToCharArray();
            static readonly string[] Literals =
            {
                @"\0", @"\x0001", @"\x0002", @"\x0003", @"\x0004", @"\x0005", @"\x0006",
                @"\a", @"\b", @"\t", @"\n", @"\v", @"\f", @"\r",
                @"\x000e", @"\x000f", @"\x0010", @"\x0011", @"\x0012",
                @"\x0013", @"\x0014", @"\x0015", @"\x0016", @"\x0017",
                @"\x0018", @"\x0019", @"\x001a", @"\x001b", @"\x001c",
                @"\x001d", @"\x001e", @"\x001f"
            };

            public static string Encode(string input)
            {
                var i = input.IndexOfAny(ToEscape);
                if (i < 0)
                    return input;

                var sb = new StringBuilder(input.Length + 5);
                var j = 0;
                do
                {
                    sb.Append(input, j, i - j);
                    var c = input[i];
                    if (c < 0x20)
                        sb.Append(Literals[c]);
                    else
                        sb.Append('\\').Append(c);
                }
                while ((i = input.IndexOfAny(ToEscape, j = ++i)) > 0);

                return sb.Append(input, j, input.Length - j).ToString();
            }
        }

        static int Main(string[] args)
        {
            try
            {
                Wain(args);
                return 0;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
                return 0xbad;
            }
        }
    }
}
