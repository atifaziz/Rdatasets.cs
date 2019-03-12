// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Darwin's Wild Mignonette Data
    /// </summary>

    public class mignonette
    {
        public readonly int κ;
        public readonly double cross;
        public readonly double self;

        public mignonette(int κ, double cross, double self)
        {
            this.κ = κ;
            this.cross = cross;
            this.self = self;
        }

        public static IEnumerable<mignonette> Data
        {
            get
            {
                yield return new mignonette(1, 21, 12.875);
                yield return new mignonette(2, 14.25, 16);
                yield return new mignonette(3, 19.125, 11.875);
                yield return new mignonette(4, 7, 15.25);
                yield return new mignonette(5, 15.125, 19.125);
                yield return new mignonette(6, 20.5, 12.5);
                yield return new mignonette(7, 17.375, 16.25);
                yield return new mignonette(8, 23.875, 16.25);
                yield return new mignonette(9, 17.125, 13.375);
                yield return new mignonette(10, 20.75, 13.625);
                yield return new mignonette(11, 16.125, 14.5);
                yield return new mignonette(12, 17.75, 19.5);
                yield return new mignonette(13, 16.25, 20.875);
                yield return new mignonette(14, 10, 7.875);
                yield return new mignonette(15, 10, 17.75);
                yield return new mignonette(16, 22.125, 9);
                yield return new mignonette(17, 19, 11.5);
                yield return new mignonette(18, 18.875, 11);
                yield return new mignonette(19, 16.5, 16);
                yield return new mignonette(20, 19.25, 16.375);
                yield return new mignonette(21, 25.25, 14.75);
                yield return new mignonette(22, 22, 16);
                yield return new mignonette(23, 8.75, 14.375);
                yield return new mignonette(24, 14.25, 14.25);
            }
        }
    }
}
