// ReSharper disable All

namespace Rdatasets.ggplot2
{
    using System.Collections.Generic;

    /// <summary>
    /// Terms of 11 presidents from Eisenhower to Obama
    /// </summary>

    public class presidential
    {
        public readonly string name;
        public readonly string start;
        public readonly string end;
        public readonly string party;

        public presidential(string name, string start, string end, string party)
        {
            this.name = name;
            this.start = start;
            this.end = end;
            this.party = party;
        }

        public static IEnumerable<presidential> Data
        {
            get
            {
                yield return new presidential("Eisenhower", "1953-01-20", "1961-01-20", "Republican");
                yield return new presidential("Kennedy", "1961-01-20", "1963-11-22", "Democratic");
                yield return new presidential("Johnson", "1963-11-22", "1969-01-20", "Democratic");
                yield return new presidential("Nixon", "1969-01-20", "1974-08-09", "Republican");
                yield return new presidential("Ford", "1974-08-09", "1977-01-20", "Republican");
                yield return new presidential("Carter", "1977-01-20", "1981-01-20", "Democratic");
                yield return new presidential("Reagan", "1981-01-20", "1989-01-20", "Republican");
                yield return new presidential("Bush", "1989-01-20", "1993-01-20", "Republican");
                yield return new presidential("Clinton", "1993-01-20", "2001-01-20", "Democratic");
                yield return new presidential("Bush", "2001-01-20", "2009-01-20", "Republican");
                yield return new presidential("Obama", "2009-01-20", "2017-01-20", "Democratic");
            }
        }
    }
}
