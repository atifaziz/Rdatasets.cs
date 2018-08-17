// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Air Quality Data
    /// </summary>

    public class airmay
    {
        public readonly string X1;
        public readonly double X2;
        public readonly int X3;
        public readonly string Y;

        public airmay(string X1, double X2, int X3, string Y)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.Y = Y;
        }

        public static IEnumerable<airmay> Data
        {
            get
            {
                yield return new airmay("190", 7.4, 67, "41");
                yield return new airmay("118", 8, 72, "36");
                yield return new airmay("149", 12.6, 74, "12");
                yield return new airmay("313", 11.5, 62, "18");
                yield return new airmay(null, 14.3, 56, null);
                yield return new airmay(null, 14.9, 66, "28");
                yield return new airmay("299", 8.6, 65, "23");
                yield return new airmay("99", 13.8, 59, "19");
                yield return new airmay("19", 20.1, 61, "8");
                yield return new airmay("194", 8.6, 69, null);
                yield return new airmay(null, 6.9, 74, "7");
                yield return new airmay("256", 9.7, 69, "16");
                yield return new airmay("290", 9.2, 66, "11");
                yield return new airmay("274", 10.9, 68, "14");
                yield return new airmay("65", 13.2, 58, "18");
                yield return new airmay("334", 11.5, 64, "14");
                yield return new airmay("307", 12, 66, "34");
                yield return new airmay("78", 18.4, 57, "6");
                yield return new airmay("322", 11.5, 68, "30");
                yield return new airmay("44", 9.7, 62, "11");
                yield return new airmay("8", 9.7, 59, "1");
                yield return new airmay("320", 16.6, 73, "11");
                yield return new airmay("25", 9.7, 61, "4");
                yield return new airmay("92", 12, 61, "32");
                yield return new airmay("66", 16.6, 57, null);
                yield return new airmay("266", 14.9, 58, null);
                yield return new airmay(null, 8, 57, null);
                yield return new airmay("13", 12, 67, "23");
                yield return new airmay("252", 14.9, 81, "45");
                yield return new airmay("223", 5.7, 79, "115");
                yield return new airmay("279", 7.4, 76, "37");
            }
        }
    }
}
