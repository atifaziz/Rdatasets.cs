// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Steam Usage Data (Excerpt)
    /// </summary>

    public class steamUse
    {
        public readonly double Steam;
        public readonly double fattyAcid;
        public readonly double glycerine;
        public readonly double wind;
        public readonly int days;
        public readonly int op_days;
        public readonly int freeze_d;
        public readonly double temperature;
        public readonly int startups;

        public steamUse(double Steam, double fattyAcid, double glycerine, double wind, int days, int op_days, int freeze_d, double temperature, int startups)
        {
            this.Steam = Steam;
            this.fattyAcid = fattyAcid;
            this.glycerine = glycerine;
            this.wind = wind;
            this.days = days;
            this.op_days = op_days;
            this.freeze_d = freeze_d;
            this.temperature = temperature;
            this.startups = startups;
        }

        public static IEnumerable<steamUse> Data
        {
            get
            {
                yield return new steamUse(10.98, 5.2, 0.61, 7.4, 31, 20, 22, 35.3, 4);
                yield return new steamUse(11.13, 5.12, 0.64, 8, 29, 20, 25, 29.7, 5);
                yield return new steamUse(12.51, 6.19, 0.78, 7.4, 31, 23, 17, 30.8, 4);
                yield return new steamUse(8.4, 3.89, 0.49, 7.5, 30, 20, 22, 58.8, 4);
                yield return new steamUse(9.27, 6.28, 0.84, 5.5, 31, 21, 0, 61.4, 5);
                yield return new steamUse(8.73, 5.76, 0.74, 8.9, 30, 22, 0, 71.3, 4);
                yield return new steamUse(6.36, 3.45, 0.42, 4.1, 31, 11, 0, 74.4, 2);
                yield return new steamUse(8.5, 6.57, 0.87, 4.1, 31, 23, 0, 76.7, 5);
                yield return new steamUse(7.82, 5.69, 0.75, 4.1, 30, 21, 0, 70.7, 4);
                yield return new steamUse(9.14, 6.14, 0.76, 4.5, 31, 20, 0, 57.5, 5);
                yield return new steamUse(8.24, 4.84, 0.65, 10.3, 30, 20, 11, 46.4, 4);
                yield return new steamUse(12.19, 4.88, 0.62, 6.9, 31, 21, 12, 28.9, 4);
                yield return new steamUse(11.88, 6.03, 0.79, 6.6, 31, 21, 25, 28.1, 5);
                yield return new steamUse(9.57, 4.55, 0.6, 7.3, 28, 19, 18, 39.1, 5);
                yield return new steamUse(10.94, 5.71, 0.7, 8.1, 31, 23, 5, 46.8, 4);
                yield return new steamUse(9.58, 5.67, 0.74, 8.4, 30, 20, 7, 48.5, 4);
                yield return new steamUse(10.09, 6.72, 0.85, 6.1, 31, 22, 0, 59.3, 6);
                yield return new steamUse(8.11, 4.95, 0.67, 4.9, 30, 22, 0, 70, 4);
                yield return new steamUse(6.83, 4.62, 0.45, 4.6, 31, 11, 0, 70, 3);
                yield return new steamUse(8.88, 6.6, 0.95, 3.7, 31, 23, 0, 74.5, 4);
                yield return new steamUse(7.68, 5.01, 0.64, 4.7, 30, 20, 0, 72.1, 4);
                yield return new steamUse(8.47, 5.68, 0.75, 5.3, 31, 21, 1, 58.1, 6);
                yield return new steamUse(8.86, 5.28, 0.7, 6.2, 30, 20, 14, 44.6, 4);
                yield return new steamUse(10.36, 5.36, 0.67, 6.8, 31, 20, 22, 33.4, 4);
                yield return new steamUse(11.08, 5.87, 0.7, 7.5, 31, 22, 28, 28.6, 5);
            }
        }
    }
}
