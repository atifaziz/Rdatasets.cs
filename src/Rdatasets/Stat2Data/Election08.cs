// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Election08
    /// </summary>

    public class Election08
    {
        public readonly string State;
        public readonly string Abr;
        public readonly int Income;
        public readonly double HS;
        public readonly double BA;
        public readonly int Dem_Rep;
        public readonly int ObamaWin;

        public Election08(string State, string Abr, int Income, double HS, double BA, int Dem_Rep, int ObamaWin)
        {
            this.State = State;
            this.Abr = Abr;
            this.Income = Income;
            this.HS = HS;
            this.BA = BA;
            this.Dem_Rep = Dem_Rep;
            this.ObamaWin = ObamaWin;
        }

        public static IEnumerable<Election08> Data
        {
            get
            {
                yield return new Election08("Alabama ", "AL", 32404, 80.4, 21.4, -1, 0);
                yield return new Election08("Alaska ", "AK", 40352, 90.5, 26, -11, 0);
                yield return new Election08("Arizona ", "AZ", 33029, 83.5, 25.3, 0, 0);
                yield return new Election08("Arkansas ", "AR", 30060, 81.1, 19.3, 12, 0);
                yield return new Election08("California ", "CA", 41571, 80.2, 29.5, 19, 1);
                yield return new Election08("Colorado ", "CO", 41042, 88.9, 35, 11, 1);
                yield return new Election08("Connecticut ", "CT", 54117, 88, 34.7, 26, 1);
                yield return new Election08("Delaware ", "DE", 40608, 87.4, 26.1, 23, 1);
                yield return new Election08("District of Columbia", "DC", 61092, 85.7, 47.5, 75, 1);
                yield return new Election08("Florida ", "FL", 38444, 84.9, 25.8, 9, 1);
                yield return new Election08("Georgia ", "GA", 33457, 82.9, 27.1, 4, 0);
                yield return new Election08("Hawaii ", "HI", 39239, 89.4, 29.2, 34, 1);
                yield return new Election08("Idaho ", "ID", 31197, 88.4, 24.5, -15, 0);
                yield return new Election08("Illinois ", "IL", 40322, 85.7, 29.5, 24, 1);
                yield return new Election08("Indiana ", "IN", 33616, 85.8, 22.1, 9, 1);
                yield return new Election08("Iowa ", "IA", 35023, 89.6, 24.3, 18, 1);
                yield return new Election08("Kansas ", "KS", 36768, 89.1, 28.8, -2, 0);
                yield return new Election08("Kentucky ", "KY", 31111, 80.1, 20, 13, 0);
                yield return new Election08("Louisiana ", "LA", 34756, 79.9, 20.4, 9, 0);
                yield return new Election08("Maine ", "ME", 33722, 89.4, 26.7, 19, 1);
                yield return new Election08("Maryland ", "MD", 46021, 87.4, 35.2, 26, 1);
                yield return new Election08("Massachusetts ", "MA", 49082, 88.4, 37.9, 34, 1);
                yield return new Election08("Michigan ", "MI", 35086, 87.4, 24.7, 17, 1);
                yield return new Election08("Minnesota ", "MN", 41034, 91, 31, 15, 1);
                yield return new Election08("Mississippi ", "MS", 28845, 78.5, 18.9, 1, 0);
                yield return new Election08("Missouri ", "MO", 34389, 85.6, 24.5, 11, 0);
                yield return new Election08("Montana ", "MT", 32458, 90, 27, 4, 0);
                yield return new Election08("Nebraska ", "NE", 36471, 89.6, 27.5, -7, 0);
                yield return new Election08("Nevada ", "NV", 40480, 83.7, 21.8, 11, 1);
                yield return new Election08("New Hampshire ", "NH", 41512, 90.5, 32.5, 13, 1);
                yield return new Election08("New Jersey ", "NJ", 49194, 87, 33.9, 19, 1);
                yield return new Election08("New Mexico ", "NM", 31474, 82.3, 24.8, 14, 1);
                yield return new Election08("New York ", "NY", 47385, 84.1, 31.7, 27, 1);
                yield return new Election08("North Carolina ", "NC", 33636, 83, 25.6, 11, 1);
                yield return new Election08("North Dakota ", "ND", 34846, 89, 25.7, 1, 0);
                yield return new Election08("Ohio ", "OH", 34874, 87.1, 24.1, 18, 1);
                yield return new Election08("Oklahoma ", "OK", 34153, 84.8, 22.8, 6, 0);
                yield return new Election08("Oregon ", "OR", 34784, 88, 28.3, 17, 1);
                yield return new Election08("Pennsylvania ", "PA", 38788, 86.8, 25.8, 16, 1);
                yield return new Election08("Rhode Island ", "RI", 39463, 83, 29.8, 37, 1);
                yield return new Election08("South Carolina ", "SC", 31013, 82.1, 23.5, 0, 0);
                yield return new Election08("South Dakota ", "SD", 33905, 88.2, 25, 1, 0);
                yield return new Election08("Tennessee ", "TN", 33280, 81.4, 21.8, 5, 0);
                yield return new Election08("Texas ", "TX", 37187, 79.1, 25.2, 2, 0);
                yield return new Election08("Utah ", "UT", 31189, 90.2, 28.7, -23, 0);
                yield return new Election08("Vermont ", "VT", 36670, 90.3, 33.6, 33, 1);
                yield return new Election08("Virginia ", "VA", 41347, 85.9, 33.6, 9, 1);
                yield return new Election08("Washington ", "WA", 40414, 89.3, 30.3, 17, 1);
                yield return new Election08("West Virginia ", "WV", 29537, 81.2, 17.3, 19, 0);
                yield return new Election08("Wisconsin ", "WI", 36047, 89, 25.4, 18, 1);
                yield return new Election08("Wyoming ", "WY", 43226, 91.2, 23.4, -20, 0);
            }
        }
    }
}
