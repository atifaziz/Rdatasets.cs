// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Jurors
    /// </summary>

    public class Jurors
    {
        public readonly int κ;
        public readonly int Period;
        public readonly double PctReport;
        public readonly int Year;
        public readonly int I2000;

        public Jurors(int κ, int Period, double PctReport, int Year, int I2000)
        {
            this.κ = κ;
            this.Period = Period;
            this.PctReport = PctReport;
            this.Year = Year;
            this.I2000 = I2000;
        }

        public static IEnumerable<Jurors> Data
        {
            get
            {
                yield return new Jurors(1, 1, 83.3, 1998, 0);
                yield return new Jurors(2, 2, 83.6, 1998, 0);
                yield return new Jurors(3, 3, 70.5, 1998, 0);
                yield return new Jurors(4, 4, 70.7, 1998, 0);
                yield return new Jurors(5, 5, 80.5, 1998, 0);
                yield return new Jurors(6, 6, 81.6, 1998, 0);
                yield return new Jurors(7, 7, 65.3, 1998, 0);
                yield return new Jurors(8, 8, 61.3, 1998, 0);
                yield return new Jurors(9, 9, 62.7, 1998, 0);
                yield return new Jurors(10, 10, 67.8, 1998, 0);
                yield return new Jurors(11, 11, 65, 1998, 0);
                yield return new Jurors(12, 12, 64.1, 1998, 0);
                yield return new Jurors(13, 13, 64.7, 1998, 0);
                yield return new Jurors(14, 14, 65.4, 1998, 0);
                yield return new Jurors(15, 15, 65, 1998, 0);
                yield return new Jurors(16, 16, 62.3, 1998, 0);
                yield return new Jurors(17, 17, 62.5, 1998, 0);
                yield return new Jurors(18, 18, 65.5, 1998, 0);
                yield return new Jurors(19, 19, 63.5, 1998, 0);
                yield return new Jurors(20, 20, 75, 1998, 0);
                yield return new Jurors(21, 21, 67.9, 1998, 0);
                yield return new Jurors(22, 22, 62, 1998, 0);
                yield return new Jurors(23, 23, 71, 1998, 0);
                yield return new Jurors(24, 24, 62.1, 1998, 0);
                yield return new Jurors(25, 25, 58.5, 1998, 0);
                yield return new Jurors(26, 26, 50.7, 1998, 0);
                yield return new Jurors(27, 1, 92.6, 2000, 1);
                yield return new Jurors(28, 2, 81.1, 2000, 1);
                yield return new Jurors(29, 3, 92.5, 2000, 1);
                yield return new Jurors(30, 4, 97, 2000, 1);
                yield return new Jurors(31, 5, 97, 2000, 1);
                yield return new Jurors(32, 6, 83.3, 2000, 1);
                yield return new Jurors(33, 7, 94.6, 2000, 1);
                yield return new Jurors(34, 8, 88.1, 2000, 1);
                yield return new Jurors(35, 9, 90.9, 2000, 1);
                yield return new Jurors(36, 10, 87.1, 2000, 1);
                yield return new Jurors(37, 11, 85.4, 2000, 1);
                yield return new Jurors(38, 12, 86.6, 2000, 1);
                yield return new Jurors(39, 13, 88.3, 2000, 1);
                yield return new Jurors(40, 14, 94.4, 2000, 1);
                yield return new Jurors(41, 15, 88.5, 2000, 1);
                yield return new Jurors(42, 16, 95.5, 2000, 1);
                yield return new Jurors(43, 17, 65.9, 2000, 1);
                yield return new Jurors(44, 18, 87.5, 2000, 1);
                yield return new Jurors(45, 19, 80.2, 2000, 1);
                yield return new Jurors(46, 20, 94.7, 2000, 1);
                yield return new Jurors(47, 21, 76.6, 2000, 1);
                yield return new Jurors(48, 22, 75.8, 2000, 1);
                yield return new Jurors(49, 23, 76.5, 2000, 1);
                yield return new Jurors(50, 24, 80.6, 2000, 1);
                yield return new Jurors(51, 25, 71.8, 2000, 1);
                yield return new Jurors(52, 26, 63.7, 2000, 1);
            }
        }
    }
}
