// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Siegel's Exact Fit Example Data
    /// </summary>

    public class SiegelsEx
    {
        public readonly int κ;
        public readonly int x;
        public readonly int y;

        public SiegelsEx(int κ, int x, int y)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<SiegelsEx> Data
        {
            get
            {
                yield return new SiegelsEx(1, -4, 0);
                yield return new SiegelsEx(2, -3, 0);
                yield return new SiegelsEx(3, -2, 0);
                yield return new SiegelsEx(4, -1, 0);
                yield return new SiegelsEx(5, 0, 0);
                yield return new SiegelsEx(6, 1, 0);
                yield return new SiegelsEx(7, 2, -5);
                yield return new SiegelsEx(8, 3, 5);
                yield return new SiegelsEx(9, 12, 1);
            }
        }
    }
}
