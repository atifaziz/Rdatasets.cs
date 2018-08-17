// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cloud Seeding
    /// </summary>

    public class CloudSeeding
    {
        public readonly string Seeded;
        public readonly string Season;
        public readonly double TE;
        public readonly double TW;
        public readonly double NC;
        public readonly double SC;
        public readonly double NWC;

        public CloudSeeding(string Seeded, string Season, double TE, double TW, double NC, double SC, double NWC)
        {
            this.Seeded = Seeded;
            this.Season = Season;
            this.TE = TE;
            this.TW = TW;
            this.NC = NC;
            this.SC = SC;
            this.NWC = NWC;
        }

        public static IEnumerable<CloudSeeding> Data
        {
            get
            {
                yield return new CloudSeeding("S", "Winter", 0.81, 0.86, 2.39, 0.36, 2.06);
                yield return new CloudSeeding("U", "Winter", 1.44, 2.01, 2.96, 1.27, 4.05);
                yield return new CloudSeeding("S", "Winter", 2.48, 4.61, 4.16, 2.16, 6);
                yield return new CloudSeeding("U", "Winter", 0.84, 2.39, 2.76, 0.87, 4.17);
                yield return new CloudSeeding("U", "Winter", 0.37, 1.37, 1.08, 0.85, 3.45);
                yield return new CloudSeeding("S", "Winter", 0.37, 0.84, 0.26, 0.47, 0.9);
                yield return new CloudSeeding("S", "Winter", 0.42, 1.23, 0.13, 0.59, 0.91);
                yield return new CloudSeeding("U", "Winter", 0.64, 0.43, 1.5, 0.24, 1.15);
                yield return new CloudSeeding("U", "Winter", 0.3, 0.69, 1.03, 0.22, 1.88);
                yield return new CloudSeeding("S", "Winter", 0.88, 1.32, 1.87, 0.58, 2.97);
                yield return new CloudSeeding("U", "Winter", 0.76, 1.25, 1.85, 1.36, 2.17);
                yield return new CloudSeeding("S", "Winter", 1.25, 1, 2.04, 0.71, 2.22);
                yield return new CloudSeeding("U", "Winter", 1.08, 0.99, 1.44, 1, 1.64);
                yield return new CloudSeeding("S", "Winter", 1.11, 0.8, 1.46, 1.48, 0.4);
                yield return new CloudSeeding("U", "Winter", 0.74, 1.36, 2.22, 0.61, 2.68);
                yield return new CloudSeeding("S", "Winter", 1.09, 3.56, 0.07, 2.26, 2.08);
                yield return new CloudSeeding("S", "Winter", 0.79, 1.43, 1.62, 1.16, 2.87);
                yield return new CloudSeeding("U", "Winter", 4.06, 6.71, 4.34, 3.29, 6.4);
                yield return new CloudSeeding("U", "Winter", 0.4, 0.64, 1.03, 0.58, 1.77);
                yield return new CloudSeeding("S", "Winter", 0.76, 1.83, 1.5, 0.41, 2.56);
                yield return new CloudSeeding("S", "Winter", 0.24, 0.61, 0.05, 0.38, 0.9);
                yield return new CloudSeeding("U", "Winter", 2.36, 1.15, 1.84, 1.73, 2.33);
                yield return new CloudSeeding("S", "Winter", 2.35, 4.29, 4.24, 1.67, 5.48);
                yield return new CloudSeeding("U", "Winter", 2.23, 4.3, 1.99, 1.9, 3.67);
                yield return new CloudSeeding("U", "Winter", 1.16, 3.06, 2.44, 1.52, 4.01);
                yield return new CloudSeeding("S", "Winter", 1.63, 3.31, 2.21, 2.36, 3.25);
                yield return new CloudSeeding("S", "Winter", 1.08, 3.17, 0.8, 2.25, 2.79);
                yield return new CloudSeeding("U", "Winter", 6, 6.15, 9.42, 3.6, 7.84);
            }
        }
    }
}
