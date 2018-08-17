// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Crowd Baiting Behaviour and Suicides
    /// </summary>

    public class suicides
    {
        public readonly string Var1;
        public readonly string Var2;
        public readonly int Freq;

        public suicides(string Var1, string Var2, int Freq)
        {
            this.Var1 = Var1;
            this.Var2 = Var2;
            this.Freq = Freq;
        }

        public static IEnumerable<suicides> Data
        {
            get
            {
                yield return new suicides("June--September", "Baiting", 8);
                yield return new suicides("October--May", "Baiting", 2);
                yield return new suicides("June--September", "Nonbaiting", 4);
                yield return new suicides("October--May", "Nonbaiting", 7);
            }
        }
    }
}
