// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Motor Trend Car Road Tests
    /// </summary>

    public class mtcars
    {
        public readonly double mpg;
        public readonly int cyl;
        public readonly double disp;
        public readonly int hp;
        public readonly double drat;
        public readonly double wt;
        public readonly double qsec;
        public readonly int vs;
        public readonly int am;
        public readonly int gear;
        public readonly int carb;

        public mtcars(double mpg, int cyl, double disp, int hp, double drat, double wt, double qsec, int vs, int am, int gear, int carb)
        {
            this.mpg = mpg;
            this.cyl = cyl;
            this.disp = disp;
            this.hp = hp;
            this.drat = drat;
            this.wt = wt;
            this.qsec = qsec;
            this.vs = vs;
            this.am = am;
            this.gear = gear;
            this.carb = carb;
        }

        public static IEnumerable<mtcars> Data
        {
            get
            {
                yield return new mtcars(21, 6, 160, 110, 3.9, 2.62, 16.46, 0, 1, 4, 4);
                yield return new mtcars(21, 6, 160, 110, 3.9, 2.875, 17.02, 0, 1, 4, 4);
                yield return new mtcars(22.8, 4, 108, 93, 3.85, 2.32, 18.61, 1, 1, 4, 1);
                yield return new mtcars(21.4, 6, 258, 110, 3.08, 3.215, 19.44, 1, 0, 3, 1);
                yield return new mtcars(18.7, 8, 360, 175, 3.15, 3.44, 17.02, 0, 0, 3, 2);
                yield return new mtcars(18.1, 6, 225, 105, 2.76, 3.46, 20.22, 1, 0, 3, 1);
                yield return new mtcars(14.3, 8, 360, 245, 3.21, 3.57, 15.84, 0, 0, 3, 4);
                yield return new mtcars(24.4, 4, 146.7, 62, 3.69, 3.19, 20, 1, 0, 4, 2);
                yield return new mtcars(22.8, 4, 140.8, 95, 3.92, 3.15, 22.9, 1, 0, 4, 2);
                yield return new mtcars(19.2, 6, 167.6, 123, 3.92, 3.44, 18.3, 1, 0, 4, 4);
                yield return new mtcars(17.8, 6, 167.6, 123, 3.92, 3.44, 18.9, 1, 0, 4, 4);
                yield return new mtcars(16.4, 8, 275.8, 180, 3.07, 4.07, 17.4, 0, 0, 3, 3);
                yield return new mtcars(17.3, 8, 275.8, 180, 3.07, 3.73, 17.6, 0, 0, 3, 3);
                yield return new mtcars(15.2, 8, 275.8, 180, 3.07, 3.78, 18, 0, 0, 3, 3);
                yield return new mtcars(10.4, 8, 472, 205, 2.93, 5.25, 17.98, 0, 0, 3, 4);
                yield return new mtcars(10.4, 8, 460, 215, 3, 5.424, 17.82, 0, 0, 3, 4);
                yield return new mtcars(14.7, 8, 440, 230, 3.23, 5.345, 17.42, 0, 0, 3, 4);
                yield return new mtcars(32.4, 4, 78.7, 66, 4.08, 2.2, 19.47, 1, 1, 4, 1);
                yield return new mtcars(30.4, 4, 75.7, 52, 4.93, 1.615, 18.52, 1, 1, 4, 2);
                yield return new mtcars(33.9, 4, 71.1, 65, 4.22, 1.835, 19.9, 1, 1, 4, 1);
                yield return new mtcars(21.5, 4, 120.1, 97, 3.7, 2.465, 20.01, 1, 0, 3, 1);
                yield return new mtcars(15.5, 8, 318, 150, 2.76, 3.52, 16.87, 0, 0, 3, 2);
                yield return new mtcars(15.2, 8, 304, 150, 3.15, 3.435, 17.3, 0, 0, 3, 2);
                yield return new mtcars(13.3, 8, 350, 245, 3.73, 3.84, 15.41, 0, 0, 3, 4);
                yield return new mtcars(19.2, 8, 400, 175, 3.08, 3.845, 17.05, 0, 0, 3, 2);
                yield return new mtcars(27.3, 4, 79, 66, 4.08, 1.935, 18.9, 1, 1, 4, 1);
                yield return new mtcars(26, 4, 120.3, 91, 4.43, 2.14, 16.7, 0, 1, 5, 2);
                yield return new mtcars(30.4, 4, 95.1, 113, 3.77, 1.513, 16.9, 1, 1, 5, 2);
                yield return new mtcars(15.8, 8, 351, 264, 4.22, 3.17, 14.5, 0, 1, 5, 4);
                yield return new mtcars(19.7, 6, 145, 175, 3.62, 2.77, 15.5, 0, 1, 5, 6);
                yield return new mtcars(15, 8, 301, 335, 3.54, 3.57, 14.6, 0, 1, 5, 8);
                yield return new mtcars(21.4, 4, 121, 109, 4.11, 2.78, 18.6, 1, 1, 4, 2);
            }
        }
    }
}
