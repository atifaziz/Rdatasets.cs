// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Darwin's Wild Mignonette Data
    /// </summary>

    public class mignonette
    {
        public readonly double cross;
        public readonly double self;

        public mignonette(double cross, double self)
        {
            this.cross = cross;
            this.self = self;
        }

        public static IEnumerable<mignonette> Data
        {
            get
            {
                yield return new mignonette(21, 12.875);
                yield return new mignonette(14.25, 16);
                yield return new mignonette(19.125, 11.875);
                yield return new mignonette(7, 15.25);
                yield return new mignonette(15.125, 19.125);
                yield return new mignonette(20.5, 12.5);
                yield return new mignonette(17.375, 16.25);
                yield return new mignonette(23.875, 16.25);
                yield return new mignonette(17.125, 13.375);
                yield return new mignonette(20.75, 13.625);
                yield return new mignonette(16.125, 14.5);
                yield return new mignonette(17.75, 19.5);
                yield return new mignonette(16.25, 20.875);
                yield return new mignonette(10, 7.875);
                yield return new mignonette(10, 17.75);
                yield return new mignonette(22.125, 9);
                yield return new mignonette(19, 11.5);
                yield return new mignonette(18.875, 11);
                yield return new mignonette(16.5, 16);
                yield return new mignonette(19.25, 16.375);
                yield return new mignonette(25.25, 14.75);
                yield return new mignonette(22, 16);
                yield return new mignonette(8.75, 14.375);
                yield return new mignonette(14.25, 14.25);
            }
        }
    }
}
