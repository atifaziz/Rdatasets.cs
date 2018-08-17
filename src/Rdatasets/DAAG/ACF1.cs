// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Aberrant Crypt Foci in Rat Colons
    /// </summary>

    public class ACF1
    {
        public readonly int count;
        public readonly int endtime;

        public ACF1(int count, int endtime)
        {
            this.count = count;
            this.endtime = endtime;
        }

        public static IEnumerable<ACF1> Data
        {
            get
            {
                yield return new ACF1(1, 6);
                yield return new ACF1(3, 6);
                yield return new ACF1(5, 6);
                yield return new ACF1(1, 6);
                yield return new ACF1(2, 6);
                yield return new ACF1(1, 6);
                yield return new ACF1(1, 6);
                yield return new ACF1(3, 12);
                yield return new ACF1(1, 12);
                yield return new ACF1(2, 12);
                yield return new ACF1(6, 12);
                yield return new ACF1(0, 12);
                yield return new ACF1(0, 12);
                yield return new ACF1(4, 12);
                yield return new ACF1(1, 12);
                yield return new ACF1(10, 18);
                yield return new ACF1(6, 18);
                yield return new ACF1(6, 18);
                yield return new ACF1(7, 18);
                yield return new ACF1(5, 18);
                yield return new ACF1(7, 18);
                yield return new ACF1(6, 18);
            }
        }
    }
}
