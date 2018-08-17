// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Lactic Acid Concentration Measurement Data
    /// </summary>

    public class lactic
    {
        public readonly int X;
        public readonly double Y;

        public lactic(int X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static IEnumerable<lactic> Data
        {
            get
            {
                yield return new lactic(1, 1.1);
                yield return new lactic(1, 0.7);
                yield return new lactic(1, 1.8);
                yield return new lactic(1, 0.4);
                yield return new lactic(3, 3);
                yield return new lactic(3, 1.4);
                yield return new lactic(3, 4.9);
                yield return new lactic(3, 4.4);
                yield return new lactic(3, 4.5);
                yield return new lactic(5, 7.3);
                yield return new lactic(5, 8.2);
                yield return new lactic(5, 6.2);
                yield return new lactic(10, 12);
                yield return new lactic(10, 13.1);
                yield return new lactic(10, 12.6);
                yield return new lactic(10, 13.2);
                yield return new lactic(15, 18.7);
                yield return new lactic(15, 19.7);
                yield return new lactic(15, 17.4);
                yield return new lactic(15, 17.1);
            }
        }
    }
}
