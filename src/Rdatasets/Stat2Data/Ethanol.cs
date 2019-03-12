// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Ethanol
    /// </summary>

    public class Ethanol
    {
        public readonly int κ;
        public readonly string Sugar;
        public readonly int O2Conc;
        public readonly int Ethanol_;

        public Ethanol(int κ, string Sugar, int O2Conc, int Ethanol_)
        {
            this.κ = κ;
            this.Sugar = Sugar;
            this.O2Conc = O2Conc;
            this.Ethanol_ = Ethanol_;
        }

        public static IEnumerable<Ethanol> Data
        {
            get
            {
                yield return new Ethanol(1, "Glucose", 0, 59);
                yield return new Ethanol(2, "Glucose", 0, 30);
                yield return new Ethanol(3, "Glucose", 46, 44);
                yield return new Ethanol(4, "Glucose", 46, 18);
                yield return new Ethanol(5, "Glucose", 92, 22);
                yield return new Ethanol(6, "Glucose", 92, 23);
                yield return new Ethanol(7, "Glucose", 138, 12);
                yield return new Ethanol(8, "Glucose", 138, 13);
                yield return new Ethanol(9, "Galactose", 0, 25);
                yield return new Ethanol(10, "Galactose", 0, 3);
                yield return new Ethanol(11, "Galactose", 46, 13);
                yield return new Ethanol(12, "Galactose", 46, 2);
                yield return new Ethanol(13, "Galactose", 92, 7);
                yield return new Ethanol(14, "Galactose", 92, 0);
                yield return new Ethanol(15, "Galactose", 138, 0);
                yield return new Ethanol(16, "Galactose", 138, 1);
            }
        }
    }
}
