// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Anatomical Data from Domestic Cats
    /// </summary>

    public class cats
    {
        public readonly string Sex;
        public readonly double Bwt;
        public readonly double Hwt;

        public cats(string Sex, double Bwt, double Hwt)
        {
            this.Sex = Sex;
            this.Bwt = Bwt;
            this.Hwt = Hwt;
        }

        public static IEnumerable<cats> Data
        {
            get
            {
                yield return new cats("F", 2, 7);
                yield return new cats("F", 2, 7.4);
                yield return new cats("F", 2, 9.5);
                yield return new cats("F", 2.1, 7.2);
                yield return new cats("F", 2.1, 7.3);
                yield return new cats("F", 2.1, 7.6);
                yield return new cats("F", 2.1, 8.1);
                yield return new cats("F", 2.1, 8.2);
                yield return new cats("F", 2.1, 8.3);
                yield return new cats("F", 2.1, 8.5);
                yield return new cats("F", 2.1, 8.7);
                yield return new cats("F", 2.1, 9.8);
                yield return new cats("F", 2.2, 7.1);
                yield return new cats("F", 2.2, 8.7);
                yield return new cats("F", 2.2, 9.1);
                yield return new cats("F", 2.2, 9.7);
                yield return new cats("F", 2.2, 10.9);
                yield return new cats("F", 2.2, 11);
                yield return new cats("F", 2.3, 7.3);
                yield return new cats("F", 2.3, 7.9);
                yield return new cats("F", 2.3, 8.4);
                yield return new cats("F", 2.3, 9);
                yield return new cats("F", 2.3, 9);
                yield return new cats("F", 2.3, 9.5);
                yield return new cats("F", 2.3, 9.6);
                yield return new cats("F", 2.3, 9.7);
                yield return new cats("F", 2.3, 10.1);
                yield return new cats("F", 2.3, 10.1);
                yield return new cats("F", 2.3, 10.6);
                yield return new cats("F", 2.3, 11.2);
                yield return new cats("F", 2.4, 6.3);
                yield return new cats("F", 2.4, 8.7);
                yield return new cats("F", 2.4, 8.8);
                yield return new cats("F", 2.4, 10.2);
                yield return new cats("F", 2.5, 9);
                yield return new cats("F", 2.5, 10.9);
                yield return new cats("F", 2.6, 8.7);
                yield return new cats("F", 2.6, 10.1);
                yield return new cats("F", 2.6, 10.1);
                yield return new cats("F", 2.7, 8.5);
                yield return new cats("F", 2.7, 10.2);
                yield return new cats("F", 2.7, 10.8);
                yield return new cats("F", 2.9, 9.9);
                yield return new cats("F", 2.9, 10.1);
                yield return new cats("F", 2.9, 10.1);
                yield return new cats("F", 3, 10.6);
                yield return new cats("F", 3, 13);
                yield return new cats("M", 2, 6.5);
                yield return new cats("M", 2, 6.5);
                yield return new cats("M", 2.1, 10.1);
                yield return new cats("M", 2.2, 7.2);
                yield return new cats("M", 2.2, 7.6);
                yield return new cats("M", 2.2, 7.9);
                yield return new cats("M", 2.2, 8.5);
                yield return new cats("M", 2.2, 9.1);
                yield return new cats("M", 2.2, 9.6);
                yield return new cats("M", 2.2, 9.6);
                yield return new cats("M", 2.2, 10.7);
                yield return new cats("M", 2.3, 9.6);
                yield return new cats("M", 2.4, 7.3);
                yield return new cats("M", 2.4, 7.9);
                yield return new cats("M", 2.4, 7.9);
                yield return new cats("M", 2.4, 9.1);
                yield return new cats("M", 2.4, 9.3);
                yield return new cats("M", 2.5, 7.9);
                yield return new cats("M", 2.5, 8.6);
                yield return new cats("M", 2.5, 8.8);
                yield return new cats("M", 2.5, 8.8);
                yield return new cats("M", 2.5, 9.3);
                yield return new cats("M", 2.5, 11);
                yield return new cats("M", 2.5, 12.7);
                yield return new cats("M", 2.5, 12.7);
                yield return new cats("M", 2.6, 7.7);
                yield return new cats("M", 2.6, 8.3);
                yield return new cats("M", 2.6, 9.4);
                yield return new cats("M", 2.6, 9.4);
                yield return new cats("M", 2.6, 10.5);
                yield return new cats("M", 2.6, 11.5);
                yield return new cats("M", 2.7, 8);
                yield return new cats("M", 2.7, 9);
                yield return new cats("M", 2.7, 9.6);
                yield return new cats("M", 2.7, 9.6);
                yield return new cats("M", 2.7, 9.8);
                yield return new cats("M", 2.7, 10.4);
                yield return new cats("M", 2.7, 11.1);
                yield return new cats("M", 2.7, 12);
                yield return new cats("M", 2.7, 12.5);
                yield return new cats("M", 2.8, 9.1);
                yield return new cats("M", 2.8, 10);
                yield return new cats("M", 2.8, 10.2);
                yield return new cats("M", 2.8, 11.4);
                yield return new cats("M", 2.8, 12);
                yield return new cats("M", 2.8, 13.3);
                yield return new cats("M", 2.8, 13.5);
                yield return new cats("M", 2.9, 9.4);
                yield return new cats("M", 2.9, 10.1);
                yield return new cats("M", 2.9, 10.6);
                yield return new cats("M", 2.9, 11.3);
                yield return new cats("M", 2.9, 11.8);
                yield return new cats("M", 3, 10);
                yield return new cats("M", 3, 10.4);
                yield return new cats("M", 3, 10.6);
                yield return new cats("M", 3, 11.6);
                yield return new cats("M", 3, 12.2);
                yield return new cats("M", 3, 12.4);
                yield return new cats("M", 3, 12.7);
                yield return new cats("M", 3, 13.3);
                yield return new cats("M", 3, 13.8);
                yield return new cats("M", 3.1, 9.9);
                yield return new cats("M", 3.1, 11.5);
                yield return new cats("M", 3.1, 12.1);
                yield return new cats("M", 3.1, 12.5);
                yield return new cats("M", 3.1, 13);
                yield return new cats("M", 3.1, 14.3);
                yield return new cats("M", 3.2, 11.6);
                yield return new cats("M", 3.2, 11.9);
                yield return new cats("M", 3.2, 12.3);
                yield return new cats("M", 3.2, 13);
                yield return new cats("M", 3.2, 13.5);
                yield return new cats("M", 3.2, 13.6);
                yield return new cats("M", 3.3, 11.5);
                yield return new cats("M", 3.3, 12);
                yield return new cats("M", 3.3, 14.1);
                yield return new cats("M", 3.3, 14.9);
                yield return new cats("M", 3.3, 15.4);
                yield return new cats("M", 3.4, 11.2);
                yield return new cats("M", 3.4, 12.2);
                yield return new cats("M", 3.4, 12.4);
                yield return new cats("M", 3.4, 12.8);
                yield return new cats("M", 3.4, 14.4);
                yield return new cats("M", 3.5, 11.7);
                yield return new cats("M", 3.5, 12.9);
                yield return new cats("M", 3.5, 15.6);
                yield return new cats("M", 3.5, 15.7);
                yield return new cats("M", 3.5, 17.2);
                yield return new cats("M", 3.6, 11.8);
                yield return new cats("M", 3.6, 13.3);
                yield return new cats("M", 3.6, 14.8);
                yield return new cats("M", 3.6, 15);
                yield return new cats("M", 3.7, 11);
                yield return new cats("M", 3.8, 14.8);
                yield return new cats("M", 3.8, 16.8);
                yield return new cats("M", 3.9, 14.4);
                yield return new cats("M", 3.9, 20.5);
            }
        }
    }
}
