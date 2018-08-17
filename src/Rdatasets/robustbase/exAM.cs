// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Example Data of Antille and May - for Simple Regression
    /// </summary>

    public class exAM
    {
        public readonly int x;
        public readonly int y;

        public exAM(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<exAM> Data
        {
            get
            {
                yield return new exAM(3, 2);
                yield return new exAM(4, 4);
                yield return new exAM(5, 6);
                yield return new exAM(7, 7);
                yield return new exAM(7, 8);
                yield return new exAM(5, 8);
                yield return new exAM(4, 8);
                yield return new exAM(5, 9);
                yield return new exAM(6, 11);
                yield return new exAM(8, 13);
                yield return new exAM(8, 15);
                yield return new exAM(14, 6);
            }
        }
    }
}
