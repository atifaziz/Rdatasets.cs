// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// Data on 38 individuals using a kidney dialysis machine
    /// </summary>

    public class kidrecurr
    {
        public readonly int patient;
        public readonly int time1;
        public readonly int infect1;
        public readonly int time2;
        public readonly int infect2;
        public readonly double age;
        public readonly int gender;
        public readonly int gn;
        public readonly int an;
        public readonly int pkd;

        public kidrecurr(int patient, int time1, int infect1, int time2, int infect2, double age, int gender, int gn, int an, int pkd)
        {
            this.patient = patient;
            this.time1 = time1;
            this.infect1 = infect1;
            this.time2 = time2;
            this.infect2 = infect2;
            this.age = age;
            this.gender = gender;
            this.gn = gn;
            this.an = an;
            this.pkd = pkd;
        }

        public static IEnumerable<kidrecurr> Data
        {
            get
            {
                yield return new kidrecurr(1, 16, 1, 8, 1, 28, 0, 0, 0, 0);
                yield return new kidrecurr(2, 13, 0, 23, 1, 48, 1, 1, 0, 0);
                yield return new kidrecurr(3, 22, 1, 28, 1, 32, 0, 0, 0, 0);
                yield return new kidrecurr(4, 318, 1, 447, 1, 31.5, 1, 0, 0, 0);
                yield return new kidrecurr(5, 30, 1, 12, 1, 10, 0, 0, 0, 0);
                yield return new kidrecurr(6, 24, 1, 245, 1, 16.5, 1, 0, 0, 0);
                yield return new kidrecurr(7, 9, 1, 7, 1, 51, 0, 1, 0, 0);
                yield return new kidrecurr(8, 30, 1, 511, 1, 55.5, 1, 1, 0, 0);
                yield return new kidrecurr(9, 53, 1, 196, 1, 69, 1, 0, 1, 0);
                yield return new kidrecurr(10, 154, 1, 15, 1, 51.5, 0, 1, 0, 0);
                yield return new kidrecurr(11, 7, 1, 33, 1, 44, 1, 0, 1, 0);
                yield return new kidrecurr(12, 141, 1, 8, 0, 34, 1, 0, 0, 0);
                yield return new kidrecurr(13, 38, 1, 96, 1, 35, 1, 0, 1, 0);
                yield return new kidrecurr(14, 70, 0, 149, 0, 42, 1, 0, 1, 0);
                yield return new kidrecurr(15, 536, 1, 25, 0, 17, 1, 0, 0, 0);
                yield return new kidrecurr(16, 4, 0, 17, 1, 60, 0, 0, 1, 0);
                yield return new kidrecurr(17, 185, 1, 177, 1, 60, 1, 0, 0, 0);
                yield return new kidrecurr(18, 114, 1, 292, 1, 43.5, 1, 0, 0, 0);
                yield return new kidrecurr(19, 159, 0, 22, 0, 53, 1, 1, 0, 0);
                yield return new kidrecurr(20, 108, 0, 15, 1, 44, 1, 0, 0, 0);
                yield return new kidrecurr(21, 562, 1, 152, 1, 46.5, 0, 0, 0, 1);
                yield return new kidrecurr(22, 24, 0, 402, 1, 30, 1, 0, 0, 0);
                yield return new kidrecurr(23, 66, 1, 13, 1, 62.5, 1, 0, 1, 0);
                yield return new kidrecurr(24, 39, 1, 46, 0, 42.5, 1, 0, 1, 0);
                yield return new kidrecurr(25, 40, 1, 12, 1, 43, 0, 0, 1, 0);
                yield return new kidrecurr(26, 113, 0, 201, 1, 57.5, 1, 0, 1, 0);
                yield return new kidrecurr(27, 132, 1, 156, 1, 10, 1, 1, 0, 0);
                yield return new kidrecurr(28, 34, 1, 30, 1, 52, 1, 0, 1, 0);
                yield return new kidrecurr(29, 2, 1, 25, 1, 53, 0, 1, 0, 0);
                yield return new kidrecurr(30, 26, 1, 130, 1, 54, 1, 1, 0, 0);
                yield return new kidrecurr(31, 27, 1, 58, 1, 56, 1, 0, 1, 0);
                yield return new kidrecurr(32, 5, 0, 43, 1, 50.5, 1, 0, 1, 0);
                yield return new kidrecurr(33, 152, 1, 30, 1, 57, 1, 0, 0, 1);
                yield return new kidrecurr(34, 190, 1, 5, 0, 44.5, 1, 1, 0, 0);
                yield return new kidrecurr(35, 119, 1, 8, 1, 22, 1, 0, 0, 0);
                yield return new kidrecurr(36, 54, 0, 16, 0, 42, 1, 0, 0, 0);
                yield return new kidrecurr(37, 6, 0, 78, 1, 52, 1, 0, 0, 1);
                yield return new kidrecurr(38, 8, 0, 63, 1, 60, 0, 0, 0, 1);
            }
        }
    }
}
