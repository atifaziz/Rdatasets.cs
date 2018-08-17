// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cracker Fiber in Diets
    /// </summary>

    public class CrackerFiber
    {
        public readonly string Subj;
        public readonly string Fiber;
        public readonly double Calories;

        public CrackerFiber(string Subj, string Fiber, double Calories)
        {
            this.Subj = Subj;
            this.Fiber = Fiber;
            this.Calories = Calories;
        }

        public static IEnumerable<CrackerFiber> Data
        {
            get
            {
                yield return new CrackerFiber("A", "control", 2353.21);
                yield return new CrackerFiber("B", "control", 2591.12);
                yield return new CrackerFiber("C", "control", 1772.84);
                yield return new CrackerFiber("D", "control", 2452.73);
                yield return new CrackerFiber("E", "control", 1927.68);
                yield return new CrackerFiber("F", "control", 1635.28);
                yield return new CrackerFiber("G", "control", 2667.14);
                yield return new CrackerFiber("H", "control", 2220.22);
                yield return new CrackerFiber("I", "control", 1888.29);
                yield return new CrackerFiber("J", "control", 2359.9);
                yield return new CrackerFiber("K", "control", 1902.75);
                yield return new CrackerFiber("L", "control", 2125.39);
                yield return new CrackerFiber("A", "gum", 2026.91);
                yield return new CrackerFiber("B", "gum", 2331.19);
                yield return new CrackerFiber("C", "gum", 2012.36);
                yield return new CrackerFiber("D", "gum", 2558.61);
                yield return new CrackerFiber("E", "gum", 1944.48);
                yield return new CrackerFiber("F", "gum", 1871.95);
                yield return new CrackerFiber("G", "gum", 2245.03);
                yield return new CrackerFiber("H", "gum", 2002.73);
                yield return new CrackerFiber("I", "gum", 1804.27);
                yield return new CrackerFiber("J", "gum", 2433.46);
                yield return new CrackerFiber("K", "gum", 1681.86);
                yield return new CrackerFiber("L", "gum", 2166.77);
                yield return new CrackerFiber("A", "combo", 2254.75);
                yield return new CrackerFiber("B", "combo", 2153.36);
                yield return new CrackerFiber("C", "combo", 1956.18);
                yield return new CrackerFiber("D", "combo", 2025.97);
                yield return new CrackerFiber("E", "combo", 2190.1);
                yield return new CrackerFiber("F", "combo", 1693.35);
                yield return new CrackerFiber("G", "combo", 2436.79);
                yield return new CrackerFiber("H", "combo", 1844.77);
                yield return new CrackerFiber("I", "combo", 2121.97);
                yield return new CrackerFiber("J", "combo", 2292.46);
                yield return new CrackerFiber("K", "combo", 2137.12);
                yield return new CrackerFiber("L", "combo", 2203.07);
                yield return new CrackerFiber("A", "bran", 2047.42);
                yield return new CrackerFiber("B", "bran", 2547.77);
                yield return new CrackerFiber("C", "bran", 1752.63);
                yield return new CrackerFiber("D", "bran", 1669.12);
                yield return new CrackerFiber("E", "bran", 2207.37);
                yield return new CrackerFiber("F", "bran", 1707.34);
                yield return new CrackerFiber("G", "bran", 2766.86);
                yield return new CrackerFiber("H", "bran", 2279.82);
                yield return new CrackerFiber("I", "bran", 2293.27);
                yield return new CrackerFiber("J", "bran", 2357.4);
                yield return new CrackerFiber("K", "bran", 2003.16);
                yield return new CrackerFiber("L", "bran", 2287.52);
            }
        }
    }
}
