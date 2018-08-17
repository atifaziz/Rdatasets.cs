// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Ethanol
    /// </summary>

    public class Ethanol
    {
        public readonly string Sugar;
        public readonly int O2Conc;
        public readonly int Ethanol_;

        public Ethanol(string Sugar, int O2Conc, int Ethanol_)
        {
            this.Sugar = Sugar;
            this.O2Conc = O2Conc;
            this.Ethanol_ = Ethanol_;
        }

        public static IEnumerable<Ethanol> Data
        {
            get
            {
                yield return new Ethanol("Glucose", 0, 59);
                yield return new Ethanol("Glucose", 0, 30);
                yield return new Ethanol("Glucose", 46, 44);
                yield return new Ethanol("Glucose", 46, 18);
                yield return new Ethanol("Glucose", 92, 22);
                yield return new Ethanol("Glucose", 92, 23);
                yield return new Ethanol("Glucose", 138, 12);
                yield return new Ethanol("Glucose", 138, 13);
                yield return new Ethanol("Galactose", 0, 25);
                yield return new Ethanol("Galactose", 0, 3);
                yield return new Ethanol("Galactose", 46, 13);
                yield return new Ethanol("Galactose", 46, 2);
                yield return new Ethanol("Galactose", 92, 7);
                yield return new Ethanol("Galactose", 92, 0);
                yield return new Ethanol("Galactose", 138, 0);
                yield return new Ethanol("Galactose", 138, 1);
            }
        }
    }
}
