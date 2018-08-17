// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Chemical Composition of Pottery
    /// </summary>

    public class Pottery
    {
        public readonly string Site;
        public readonly double Al;
        public readonly double Fe;
        public readonly double Mg;
        public readonly double Ca;
        public readonly double Na;

        public Pottery(string Site, double Al, double Fe, double Mg, double Ca, double Na)
        {
            this.Site = Site;
            this.Al = Al;
            this.Fe = Fe;
            this.Mg = Mg;
            this.Ca = Ca;
            this.Na = Na;
        }

        public static IEnumerable<Pottery> Data
        {
            get
            {
                yield return new Pottery("Llanedyrn", 14.4, 7, 4.3, 0.15, 0.51);
                yield return new Pottery("Llanedyrn", 13.8, 7.08, 3.43, 0.12, 0.17);
                yield return new Pottery("Llanedyrn", 14.6, 7.09, 3.88, 0.13, 0.2);
                yield return new Pottery("Llanedyrn", 11.5, 6.37, 5.64, 0.16, 0.14);
                yield return new Pottery("Llanedyrn", 13.8, 7.06, 5.34, 0.2, 0.2);
                yield return new Pottery("Llanedyrn", 10.9, 6.26, 3.47, 0.17, 0.22);
                yield return new Pottery("Llanedyrn", 10.1, 4.26, 4.26, 0.2, 0.18);
                yield return new Pottery("Llanedyrn", 11.6, 5.78, 5.91, 0.18, 0.16);
                yield return new Pottery("Llanedyrn", 11.1, 5.49, 4.52, 0.29, 0.3);
                yield return new Pottery("Llanedyrn", 13.4, 6.92, 7.23, 0.28, 0.2);
                yield return new Pottery("Llanedyrn", 12.4, 6.13, 5.69, 0.22, 0.54);
                yield return new Pottery("Llanedyrn", 13.1, 6.64, 5.51, 0.31, 0.24);
                yield return new Pottery("Llanedyrn", 12.7, 6.69, 4.45, 0.2, 0.22);
                yield return new Pottery("Llanedyrn", 12.5, 6.44, 3.94, 0.22, 0.23);
                yield return new Pottery("Caldicot", 11.8, 5.44, 3.94, 0.3, 0.04);
                yield return new Pottery("Caldicot", 11.6, 5.39, 3.77, 0.29, 0.06);
                yield return new Pottery("IsleThorns", 18.3, 1.28, 0.67, 0.03, 0.03);
                yield return new Pottery("IsleThorns", 15.8, 2.39, 0.63, 0.01, 0.04);
                yield return new Pottery("IsleThorns", 18, 1.5, 0.67, 0.01, 0.06);
                yield return new Pottery("IsleThorns", 18, 1.88, 0.68, 0.01, 0.04);
                yield return new Pottery("IsleThorns", 20.8, 1.51, 0.72, 0.07, 0.1);
                yield return new Pottery("AshleyRails", 17.7, 1.12, 0.56, 0.06, 0.06);
                yield return new Pottery("AshleyRails", 18.3, 1.14, 0.67, 0.06, 0.05);
                yield return new Pottery("AshleyRails", 16.7, 0.92, 0.53, 0.01, 0.05);
                yield return new Pottery("AshleyRails", 14.8, 2.74, 0.67, 0.03, 0.05);
                yield return new Pottery("AshleyRails", 19.1, 1.64, 0.6, 0.1, 0.03);
            }
        }
    }
}
