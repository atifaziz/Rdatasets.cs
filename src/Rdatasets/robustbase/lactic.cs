// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Lactic Acid Concentration Measurement Data
    /// </summary>

    public class lactic
    {
        public readonly int κ;
        public readonly int X;
        public readonly double Y;

        public lactic(int κ, int X, double Y)
        {
            this.κ = κ;
            this.X = X;
            this.Y = Y;
        }

        public static IEnumerable<lactic> Data
        {
            get
            {
                yield return new lactic(1, 1, 1.1);
                yield return new lactic(2, 1, 0.7);
                yield return new lactic(3, 1, 1.8);
                yield return new lactic(4, 1, 0.4);
                yield return new lactic(5, 3, 3);
                yield return new lactic(6, 3, 1.4);
                yield return new lactic(7, 3, 4.9);
                yield return new lactic(8, 3, 4.4);
                yield return new lactic(9, 3, 4.5);
                yield return new lactic(10, 5, 7.3);
                yield return new lactic(11, 5, 8.2);
                yield return new lactic(12, 5, 6.2);
                yield return new lactic(13, 10, 12);
                yield return new lactic(14, 10, 13.1);
                yield return new lactic(15, 10, 12.6);
                yield return new lactic(16, 10, 13.2);
                yield return new lactic(17, 15, 18.7);
                yield return new lactic(18, 15, 19.7);
                yield return new lactic(19, 15, 17.4);
                yield return new lactic(20, 15, 17.1);
            }
        }
    }
}
