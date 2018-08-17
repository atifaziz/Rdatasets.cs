// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Hawkins, Bradu, Kass's Artificial Data
    /// </summary>

    public class hbk
    {
        public readonly double X1;
        public readonly double X2;
        public readonly double X3;
        public readonly double Y;

        public hbk(double X1, double X2, double X3, double Y)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.Y = Y;
        }

        public static IEnumerable<hbk> Data
        {
            get
            {
                yield return new hbk(10.1, 19.6, 28.3, 9.7);
                yield return new hbk(9.5, 20.5, 28.9, 10.1);
                yield return new hbk(10.7, 20.2, 31, 10.3);
                yield return new hbk(9.9, 21.5, 31.7, 9.5);
                yield return new hbk(10.3, 21.1, 31.1, 10);
                yield return new hbk(10.8, 20.4, 29.2, 10);
                yield return new hbk(10.5, 20.9, 29.1, 10.8);
                yield return new hbk(9.9, 19.6, 28.8, 10.3);
                yield return new hbk(9.7, 20.7, 31, 9.6);
                yield return new hbk(9.3, 19.7, 30.3, 9.9);
                yield return new hbk(11, 24, 35, -0.2);
                yield return new hbk(12, 23, 37, -0.4);
                yield return new hbk(12, 26, 34, 0.7);
                yield return new hbk(11, 34, 34, 0.1);
                yield return new hbk(3.4, 2.9, 2.1, -0.4);
                yield return new hbk(3.1, 2.2, 0.3, 0.6);
                yield return new hbk(0, 1.6, 0.2, -0.2);
                yield return new hbk(2.3, 1.6, 2, 0);
                yield return new hbk(0.8, 2.9, 1.6, 0.1);
                yield return new hbk(3.1, 3.4, 2.2, 0.4);
                yield return new hbk(2.6, 2.2, 1.9, 0.9);
                yield return new hbk(0.4, 3.2, 1.9, 0.3);
                yield return new hbk(2, 2.3, 0.8, -0.8);
                yield return new hbk(1.3, 2.3, 0.5, 0.7);
                yield return new hbk(1, 0, 0.4, -0.3);
                yield return new hbk(0.9, 3.3, 2.5, -0.8);
                yield return new hbk(3.3, 2.5, 2.9, -0.7);
                yield return new hbk(1.8, 0.8, 2, 0.3);
                yield return new hbk(1.2, 0.9, 0.8, 0.3);
                yield return new hbk(1.2, 0.7, 3.4, -0.3);
                yield return new hbk(3.1, 1.4, 1, 0);
                yield return new hbk(0.5, 2.4, 0.3, -0.4);
                yield return new hbk(1.5, 3.1, 1.5, -0.6);
                yield return new hbk(0.4, 0, 0.7, -0.7);
                yield return new hbk(3.1, 2.4, 3, 0.3);
                yield return new hbk(1.1, 2.2, 2.7, -1);
                yield return new hbk(0.1, 3, 2.6, -0.6);
                yield return new hbk(1.5, 1.2, 0.2, 0.9);
                yield return new hbk(2.1, 0, 1.2, -0.7);
                yield return new hbk(0.5, 2, 1.2, -0.5);
                yield return new hbk(3.4, 1.6, 2.9, -0.1);
                yield return new hbk(0.3, 1, 2.7, -0.7);
                yield return new hbk(0.1, 3.3, 0.9, 0.6);
                yield return new hbk(1.8, 0.5, 3.2, -0.7);
                yield return new hbk(1.9, 0.1, 0.6, -0.5);
                yield return new hbk(1.8, 0.5, 3, -0.4);
                yield return new hbk(3, 0.1, 0.8, -0.9);
                yield return new hbk(3.1, 1.6, 3, 0.1);
                yield return new hbk(3.1, 2.5, 1.9, 0.9);
                yield return new hbk(2.1, 2.8, 2.9, -0.4);
                yield return new hbk(2.3, 1.5, 0.4, 0.7);
                yield return new hbk(3.3, 0.6, 1.2, -0.5);
                yield return new hbk(0.3, 0.4, 3.3, 0.7);
                yield return new hbk(1.1, 3, 0.3, 0.7);
                yield return new hbk(0.5, 2.4, 0.9, 0);
                yield return new hbk(1.8, 3.2, 0.9, 0.1);
                yield return new hbk(1.8, 0.7, 0.7, 0.7);
                yield return new hbk(2.4, 3.4, 1.5, -0.1);
                yield return new hbk(1.6, 2.1, 3, -0.3);
                yield return new hbk(0.3, 1.5, 3.3, -0.9);
                yield return new hbk(0.4, 3.4, 3, -0.3);
                yield return new hbk(0.9, 0.1, 0.3, 0.6);
                yield return new hbk(1.1, 2.7, 0.2, -0.3);
                yield return new hbk(2.8, 3, 2.9, -0.5);
                yield return new hbk(2, 0.7, 2.7, 0.6);
                yield return new hbk(0.2, 1.8, 0.8, -0.9);
                yield return new hbk(1.6, 2, 1.2, -0.7);
                yield return new hbk(0.1, 0, 1.1, 0.6);
                yield return new hbk(2, 0.6, 0.3, 0.2);
                yield return new hbk(1, 2.2, 2.9, 0.7);
                yield return new hbk(2.2, 2.5, 2.3, 0.2);
                yield return new hbk(0.6, 2, 1.5, -0.2);
                yield return new hbk(0.3, 1.7, 2.2, 0.4);
                yield return new hbk(0, 2.2, 1.6, -0.9);
                yield return new hbk(0.3, 0.4, 2.6, 0.2);
            }
        }
    }
}
