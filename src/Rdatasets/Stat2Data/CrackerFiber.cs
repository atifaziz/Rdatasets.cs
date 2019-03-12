// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cracker Fiber in Diets
    /// </summary>

    public class CrackerFiber
    {
        public readonly int κ;
        public readonly string Subj;
        public readonly string Fiber;
        public readonly double Calories;

        public CrackerFiber(int κ, string Subj, string Fiber, double Calories)
        {
            this.κ = κ;
            this.Subj = Subj;
            this.Fiber = Fiber;
            this.Calories = Calories;
        }

        public static IEnumerable<CrackerFiber> Data
        {
            get
            {
                yield return new CrackerFiber(1, "A", "control", 2353.21);
                yield return new CrackerFiber(2, "B", "control", 2591.12);
                yield return new CrackerFiber(3, "C", "control", 1772.84);
                yield return new CrackerFiber(4, "D", "control", 2452.73);
                yield return new CrackerFiber(5, "E", "control", 1927.68);
                yield return new CrackerFiber(6, "F", "control", 1635.28);
                yield return new CrackerFiber(7, "G", "control", 2667.14);
                yield return new CrackerFiber(8, "H", "control", 2220.22);
                yield return new CrackerFiber(9, "I", "control", 1888.29);
                yield return new CrackerFiber(10, "J", "control", 2359.9);
                yield return new CrackerFiber(11, "K", "control", 1902.75);
                yield return new CrackerFiber(12, "L", "control", 2125.39);
                yield return new CrackerFiber(13, "A", "gum", 2026.91);
                yield return new CrackerFiber(14, "B", "gum", 2331.19);
                yield return new CrackerFiber(15, "C", "gum", 2012.36);
                yield return new CrackerFiber(16, "D", "gum", 2558.61);
                yield return new CrackerFiber(17, "E", "gum", 1944.48);
                yield return new CrackerFiber(18, "F", "gum", 1871.95);
                yield return new CrackerFiber(19, "G", "gum", 2245.03);
                yield return new CrackerFiber(20, "H", "gum", 2002.73);
                yield return new CrackerFiber(21, "I", "gum", 1804.27);
                yield return new CrackerFiber(22, "J", "gum", 2433.46);
                yield return new CrackerFiber(23, "K", "gum", 1681.86);
                yield return new CrackerFiber(24, "L", "gum", 2166.77);
                yield return new CrackerFiber(25, "A", "combo", 2254.75);
                yield return new CrackerFiber(26, "B", "combo", 2153.36);
                yield return new CrackerFiber(27, "C", "combo", 1956.18);
                yield return new CrackerFiber(28, "D", "combo", 2025.97);
                yield return new CrackerFiber(29, "E", "combo", 2190.1);
                yield return new CrackerFiber(30, "F", "combo", 1693.35);
                yield return new CrackerFiber(31, "G", "combo", 2436.79);
                yield return new CrackerFiber(32, "H", "combo", 1844.77);
                yield return new CrackerFiber(33, "I", "combo", 2121.97);
                yield return new CrackerFiber(34, "J", "combo", 2292.46);
                yield return new CrackerFiber(35, "K", "combo", 2137.12);
                yield return new CrackerFiber(36, "L", "combo", 2203.07);
                yield return new CrackerFiber(37, "A", "bran", 2047.42);
                yield return new CrackerFiber(38, "B", "bran", 2547.77);
                yield return new CrackerFiber(39, "C", "bran", 1752.63);
                yield return new CrackerFiber(40, "D", "bran", 1669.12);
                yield return new CrackerFiber(41, "E", "bran", 2207.37);
                yield return new CrackerFiber(42, "F", "bran", 1707.34);
                yield return new CrackerFiber(43, "G", "bran", 2766.86);
                yield return new CrackerFiber(44, "H", "bran", 2279.82);
                yield return new CrackerFiber(45, "I", "bran", 2293.27);
                yield return new CrackerFiber(46, "J", "bran", 2357.4);
                yield return new CrackerFiber(47, "K", "bran", 2003.16);
                yield return new CrackerFiber(48, "L", "bran", 2287.52);
            }
        }
    }
}
