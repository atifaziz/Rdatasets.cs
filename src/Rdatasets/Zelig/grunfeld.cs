// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Simulation Data for model Seemingly Unrelated Regression (sur) that corresponds to method SUR of systemfit
    /// </summary>

    public class grunfeld
    {
        public readonly int Year;
        public readonly double Ige;
        public readonly double Fge;
        public readonly double Cge;
        public readonly double Iw;
        public readonly double Fw;
        public readonly double Cw;

        public grunfeld(int Year, double Ige, double Fge, double Cge, double Iw, double Fw, double Cw)
        {
            this.Year = Year;
            this.Ige = Ige;
            this.Fge = Fge;
            this.Cge = Cge;
            this.Iw = Iw;
            this.Fw = Fw;
            this.Cw = Cw;
        }

        public static IEnumerable<grunfeld> Data
        {
            get
            {
                yield return new grunfeld(1935, 33.1, 1170.6, 97.8, 12.93, 191.5, 1.8);
                yield return new grunfeld(1936, 45, 2015.8, 104.4, 25.9, 516, 0.8);
                yield return new grunfeld(1937, 77.2, 2803.3, 118, 35.05, 729, 7.4);
                yield return new grunfeld(1938, 44.6, 2039.7, 156.2, 22.89, 560.4, 18.1);
                yield return new grunfeld(1939, 48.1, 2256.2, 172.6, 18.84, 519.9, 23.5);
                yield return new grunfeld(1940, 74.4, 2132.2, 186.6, 28.57, 628.5, 26.5);
                yield return new grunfeld(1941, 113, 1834.1, 220.9, 48.51, 537.1, 36.2);
                yield return new grunfeld(1942, 91.9, 1588, 287.8, 43.34, 561.2, 60.8);
                yield return new grunfeld(1943, 61.3, 1749.4, 319.9, 37.02, 617.2, 84.4);
                yield return new grunfeld(1944, 56.8, 1687.2, 321.3, 37.81, 626.7, 91.2);
                yield return new grunfeld(1945, 93.6, 2007.7, 319.6, 39.27, 737.2, 92.4);
                yield return new grunfeld(1946, 159.9, 2208.3, 346, 53.46, 760.5, 86);
                yield return new grunfeld(1947, 147.2, 1656.7, 456.4, 55.56, 581.4, 111.1);
                yield return new grunfeld(1947, 146.3, 1604.4, 543.4, 49.56, 662.3, 130.6);
                yield return new grunfeld(1949, 98.3, 1431.8, 618.3, 32.04, 583.8, 141.8);
                yield return new grunfeld(1950, 93.5, 1610.5, 647.4, 32.24, 635.2, 136.7);
                yield return new grunfeld(1951, 135.2, 1819.4, 671.3, 54.38, 723.8, 129.7);
                yield return new grunfeld(1952, 157.3, 2079.7, 726.1, 71.78, 864.1, 145.5);
                yield return new grunfeld(1953, 179.5, 2371.6, 800.3, 90.08, 1193.5, 174.8);
                yield return new grunfeld(1954, 189.6, 2759.9, 888.9, 68.6, 1188.9, 213.5);
            }
        }
    }
}
