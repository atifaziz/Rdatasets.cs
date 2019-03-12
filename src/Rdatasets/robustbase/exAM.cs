// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Example Data of Antille and May - for Simple Regression
    /// </summary>

    public class exAM
    {
        public readonly int κ;
        public readonly int x;
        public readonly int y;

        public exAM(int κ, int x, int y)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<exAM> Data
        {
            get
            {
                yield return new exAM(1, 3, 2);
                yield return new exAM(2, 4, 4);
                yield return new exAM(3, 5, 6);
                yield return new exAM(4, 7, 7);
                yield return new exAM(5, 7, 8);
                yield return new exAM(6, 5, 8);
                yield return new exAM(7, 4, 8);
                yield return new exAM(8, 5, 9);
                yield return new exAM(9, 6, 11);
                yield return new exAM(10, 8, 13);
                yield return new exAM(11, 8, 15);
                yield return new exAM(12, 14, 6);
            }
        }
    }
}
