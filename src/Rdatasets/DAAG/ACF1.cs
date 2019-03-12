// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Aberrant Crypt Foci in Rat Colons
    /// </summary>

    public class ACF1
    {
        public readonly int κ;
        public readonly int count;
        public readonly int endtime;

        public ACF1(int κ, int count, int endtime)
        {
            this.κ = κ;
            this.count = count;
            this.endtime = endtime;
        }

        public static IEnumerable<ACF1> Data
        {
            get
            {
                yield return new ACF1(1, 1, 6);
                yield return new ACF1(2, 3, 6);
                yield return new ACF1(3, 5, 6);
                yield return new ACF1(4, 1, 6);
                yield return new ACF1(5, 2, 6);
                yield return new ACF1(6, 1, 6);
                yield return new ACF1(7, 1, 6);
                yield return new ACF1(8, 3, 12);
                yield return new ACF1(9, 1, 12);
                yield return new ACF1(10, 2, 12);
                yield return new ACF1(11, 6, 12);
                yield return new ACF1(12, 0, 12);
                yield return new ACF1(13, 0, 12);
                yield return new ACF1(14, 4, 12);
                yield return new ACF1(15, 1, 12);
                yield return new ACF1(16, 10, 18);
                yield return new ACF1(17, 6, 18);
                yield return new ACF1(18, 6, 18);
                yield return new ACF1(19, 7, 18);
                yield return new ACF1(20, 5, 18);
                yield return new ACF1(21, 7, 18);
                yield return new ACF1(22, 6, 18);
            }
        }
    }
}
