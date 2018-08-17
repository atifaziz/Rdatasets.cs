// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Yields from a Barley Field Trial
    /// </summary>

    public class immer
    {
        public readonly string Loc;
        public readonly string Var;
        public readonly double Y1;
        public readonly double Y2;

        public immer(string Loc, string Var, double Y1, double Y2)
        {
            this.Loc = Loc;
            this.Var = Var;
            this.Y1 = Y1;
            this.Y2 = Y2;
        }

        public static IEnumerable<immer> Data
        {
            get
            {
                yield return new immer("UF", "M", 81, 80.7);
                yield return new immer("UF", "S", 105.4, 82.3);
                yield return new immer("UF", "V", 119.7, 80.4);
                yield return new immer("UF", "T", 109.7, 87.2);
                yield return new immer("UF", "P", 98.3, 84.2);
                yield return new immer("W", "M", 146.6, 100.4);
                yield return new immer("W", "S", 142, 115.5);
                yield return new immer("W", "V", 150.7, 112.2);
                yield return new immer("W", "T", 191.5, 147.7);
                yield return new immer("W", "P", 145.7, 108.1);
                yield return new immer("M", "M", 82.3, 103.1);
                yield return new immer("M", "S", 77.3, 105.1);
                yield return new immer("M", "V", 78.4, 116.5);
                yield return new immer("M", "T", 131.3, 139.9);
                yield return new immer("M", "P", 89.6, 129.6);
                yield return new immer("C", "M", 119.8, 98.9);
                yield return new immer("C", "S", 121.4, 61.9);
                yield return new immer("C", "V", 124, 96.2);
                yield return new immer("C", "T", 140.8, 125.5);
                yield return new immer("C", "P", 124.8, 75.7);
                yield return new immer("GR", "M", 98.9, 66.4);
                yield return new immer("GR", "S", 89, 49.9);
                yield return new immer("GR", "V", 69.1, 96.7);
                yield return new immer("GR", "T", 89.3, 61.9);
                yield return new immer("GR", "P", 104.1, 80.3);
                yield return new immer("D", "M", 86.9, 67.7);
                yield return new immer("D", "S", 77.1, 66.7);
                yield return new immer("D", "V", 78.9, 67.4);
                yield return new immer("D", "T", 101.8, 91.8);
                yield return new immer("D", "P", 96, 94.1);
            }
        }
    }
}
