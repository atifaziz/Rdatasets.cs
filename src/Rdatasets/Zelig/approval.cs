// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// U.S. Presidential Approval Data
    /// </summary>

    public class approval
    {
        public readonly int month;
        public readonly int year;
        public readonly double approve;
        public readonly double disapprove;
        public readonly double unsure;
        public readonly int sept_oct_2001;
        public readonly int iraq_war;
        public readonly double avg_price;

        public approval(int month, int year, double approve, double disapprove, double unsure, int sept_oct_2001, int iraq_war, double avg_price)
        {
            this.month = month;
            this.year = year;
            this.approve = approve;
            this.disapprove = disapprove;
            this.unsure = unsure;
            this.sept_oct_2001 = sept_oct_2001;
            this.iraq_war = iraq_war;
            this.avg_price = avg_price;
        }

        public static IEnumerable<approval> Data
        {
            get
            {
                yield return new approval(2, 2001, 58.67, 23.67, 17.67, 0, 0, 144.975);
                yield return new approval(3, 2001, 58, 26.67, 15.33, 0, 0, 140.925);
                yield return new approval(4, 2001, 60.5, 29.5, 10, 0, 0, 155.16);
                yield return new approval(5, 2001, 55, 33.33, 11.67, 0, 0, 170.175);
                yield return new approval(6, 2001, 54, 34, 12, 0, 0, 161.625);
                yield return new approval(7, 2001, 56.5, 34, 9.5, 0, 0, 142.06);
                yield return new approval(8, 2001, 56, 35, 9, 0, 0, 142.075);
                yield return new approval(9, 2001, 75.67, 18.33, 6, 1, 0, 152.15);
                yield return new approval(10, 2001, 88, 9, 3, 1, 0, 131.54);
                yield return new approval(11, 2001, 87, 8.67, 4.33, 0, 0, 117.05);
                yield return new approval(12, 2001, 86, 10.5, 3.5, 0, 0, 108.6);
                yield return new approval(1, 2002, 83.67, 12.67, 3.67, 0, 0, 110.725);
                yield return new approval(2, 2002, 82, 14, 4, 0, 0, 111.375);
                yield return new approval(3, 2002, 79.25, 15.75, 5, 0, 0, 124.925);
                yield return new approval(4, 2002, 76.25, 19, 4.75, 0, 0, 139.7);
                yield return new approval(5, 2002, 76.33, 17.67, 6, 0, 0, 139.175);
                yield return new approval(6, 2002, 73.4, 20.2, 6.4, 0, 0, 138.225);
                yield return new approval(7, 2002, 70.5, 23.5, 6, 0, 0, 139.7);
                yield return new approval(8, 2002, 66.5, 27, 6.5, 0, 0, 139.575);
                yield return new approval(9, 2002, 67.2, 28.2, 4.6, 0, 0, 139.96);
                yield return new approval(10, 2002, 64.75, 29, 6.25, 0, 0, 144.525);
                yield return new approval(11, 2002, 66.33, 27, 6.67, 0, 0, 141.9);
                yield return new approval(12, 2002, 62.75, 31.5, 5.75, 0, 0, 138.58);
                yield return new approval(1, 2003, 60.17, 35, 4.83, 0, 0, 145.75);
                yield return new approval(2, 2003, 58.75, 35.75, 5.5, 0, 0, 161.3);
                yield return new approval(3, 2003, 65.2, 30.6, 4.2, 0, 1, 169.3);
                yield return new approval(4, 2003, 70, 25.75, 4.25, 0, 1, 158.9);
                yield return new approval(5, 2003, 66.33, 30, 3.67, 0, 1, 149.725);
                yield return new approval(6, 2003, 62, 34.33, 3.67, 0, 0, 149.28);
                yield return new approval(7, 2003, 59.67, 36.67, 3.67, 0, 0, 151.25);
                yield return new approval(8, 2003, 59.5, 36.5, 4, 0, 0, 162.025);
                yield return new approval(9, 2003, 51, 45, 4, 0, 0, 167.88);
                yield return new approval(10, 2003, 54.67, 41.33, 4, 0, 0, 156.35);
                yield return new approval(11, 2003, 51.67, 45, 3.33, 0, 0, 151.2);
                yield return new approval(12, 2003, 58.5, 38.25, 3.25, 0, 0, 147.88);
                yield return new approval(1, 2004, 55.25, 41.25, 3.5, 0, 0, 157.175);
                yield return new approval(2, 2004, 51.33, 45.33, 3.33, 0, 0, 164.75);
                yield return new approval(3, 2004, 50.67, 46.33, 3, 0, 0, 173.6);
                yield return new approval(4, 2004, 52, 45, 3, 0, 0, 179.775);
                yield return new approval(5, 2004, 47.33, 49.33, 3.33, 0, 0, 198.34);
                yield return new approval(6, 2004, 48.5, 49, 2.5, 0, 0, 196.925);
                yield return new approval(7, 2004, 47.75, 48.5, 3.75, 0, 0, 191.125);
                yield return new approval(8, 2004, 50, 46.5, 3.5, 0, 0, 187.8);
                yield return new approval(9, 2004, 52.67, 45, 2.33, 0, 0, 186.975);
                yield return new approval(10, 2004, 49.17, 47.67, 3.17, 0, 0, 199.95);
                yield return new approval(11, 2004, 54, 43, 3, 0, 0, 197.94);
                yield return new approval(12, 2004, 51, 45, 4, 0, 0, 184.1);
                yield return new approval(1, 2005, 51.67, 44.67, 3.67, 0, 0, 183.08);
                yield return new approval(2, 2005, 52.25, 44.5, 3.25, 0, 0, 191);
                yield return new approval(3, 2005, 49.67, 45.67, 4.67, 0, 0, 207.925);
                yield return new approval(4, 2005, 48.5, 47.75, 3.75, 0, 0, 224.25);
                yield return new approval(5, 2005, 48, 47.33, 4.67, 0, 0, 216.12);
                yield return new approval(6, 2005, 46.25, 51, 2.75, 0, 0, 215.55);
                yield return new approval(7, 2005, 47.33, 49, 3.67, 0, 0, 229);
                yield return new approval(8, 2005, 43.75, 52.5, 3.75, 0, 0, 248.62);
                yield return new approval(9, 2005, 44, 52.75, 3.25, 0, 0, 290.325);
                yield return new approval(10, 2005, 40.75, 56.25, 3, 0, 0, 271.68);
                yield return new approval(11, 2005, 38.33, 57.33, 4.33, 0, 0, 225.675);
                yield return new approval(12, 2005, 42.25, 54, 3.75, 0, 0, 218.5);
                yield return new approval(1, 2006, 43, 53.67, 3.67, 0, 0, 231.56);
                yield return new approval(2, 2006, 39.67, 57, 3.33, 0, 0, 228);
                yield return new approval(3, 2006, 36.5, 59.5, 4.5, 0, 0, 242.475);
                yield return new approval(4, 2006, 35.67, 60.67, 3.67, 0, 0, 274.2);
                yield return new approval(5, 2006, 37, 57.67, 5, 0, 0, 290.68);
                yield return new approval(6, 2006, 40, 55, 5, 0, 0, 288.45);
            }
        }
    }
}
