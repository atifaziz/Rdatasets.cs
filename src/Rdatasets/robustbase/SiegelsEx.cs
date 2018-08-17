// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Siegel's Exact Fit Example Data
    /// </summary>

    public class SiegelsEx
    {
        public readonly int x;
        public readonly int y;

        public SiegelsEx(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<SiegelsEx> Data
        {
            get
            {
                yield return new SiegelsEx(-4, 0);
                yield return new SiegelsEx(-3, 0);
                yield return new SiegelsEx(-2, 0);
                yield return new SiegelsEx(-1, 0);
                yield return new SiegelsEx(0, 0);
                yield return new SiegelsEx(1, 0);
                yield return new SiegelsEx(2, -5);
                yield return new SiegelsEx(3, 5);
                yield return new SiegelsEx(12, 1);
            }
        }
    }
}
