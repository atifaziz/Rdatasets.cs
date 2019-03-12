// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Crowd Baiting Behaviour and Suicides
    /// </summary>

    public class suicides
    {
        public readonly int κ;
        public readonly string Var1;
        public readonly string Var2;
        public readonly int Freq;

        public suicides(int κ, string Var1, string Var2, int Freq)
        {
            this.κ = κ;
            this.Var1 = Var1;
            this.Var2 = Var2;
            this.Freq = Freq;
        }

        public static IEnumerable<suicides> Data
        {
            get
            {
                yield return new suicides(1, "June--September", "Baiting", 8);
                yield return new suicides(2, "October--May", "Baiting", 2);
                yield return new suicides(3, "June--September", "Nonbaiting", 4);
                yield return new suicides(4, "October--May", "Nonbaiting", 7);
            }
        }
    }
}
