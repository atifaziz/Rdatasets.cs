// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Moths Data
    /// </summary>

    public class moths
    {
        public readonly int meters;
        public readonly int A;
        public readonly int P;
        public readonly string habitat;

        public moths(int meters, int A, int P, string habitat)
        {
            this.meters = meters;
            this.A = A;
            this.P = P;
            this.habitat = habitat;
        }

        public static IEnumerable<moths> Data
        {
            get
            {
                yield return new moths(25, 9, 8, "NWsoak");
                yield return new moths(37, 3, 20, "SWsoak");
                yield return new moths(109, 7, 9, "Lowerside");
                yield return new moths(10, 0, 2, "Lowerside");
                yield return new moths(133, 9, 1, "Upperside");
                yield return new moths(26, 3, 18, "Disturbed");
                yield return new moths(4, 0, 5, "Disturbed");
                yield return new moths(3, 0, 5, "Disturbed");
                yield return new moths(3, 0, 2, "Disturbed");
                yield return new moths(27, 39, 5, "NWsoak");
                yield return new moths(16, 7, 16, "SWsoak");
                yield return new moths(6, 12, 0, "Lowerside");
                yield return new moths(17, 6, 0, "Lowerside");
                yield return new moths(3, 2, 0, "Lowerside");
                yield return new moths(5, 1, 0, "Lowerside");
                yield return new moths(163, 5, 1, "Upperside");
                yield return new moths(10, 2, 4, "NEsoak");
                yield return new moths(5, 2, 0, "Disturbed");
                yield return new moths(13, 23, 6, "NWsoak");
                yield return new moths(63, 10, 12, "SWsoak");
                yield return new moths(4, 5, 0, "Lowerside");
                yield return new moths(4, 6, 5, "Lowerside");
                yield return new moths(33, 2, 1, "Lowerside");
                yield return new moths(241, 4, 1, "Upperside");
                yield return new moths(18, 2, 0, "NEsoak");
                yield return new moths(2, 3, 1, "Disturbed");
                yield return new moths(182, 4, 2, "Upperside");
                yield return new moths(48, 3, 3, "NEsoak");
                yield return new moths(20, 3, 4, "SEsoak");
                yield return new moths(3, 1, 0, "SEsoak");
                yield return new moths(36, 3, 1, "SEsoak");
                yield return new moths(233, 6, 3, "Upperside");
                yield return new moths(44, 1, 1, "NEsoak");
                yield return new moths(35, 9, 0, "SEsoak");
                yield return new moths(8, 10, 0, "SEsoak");
                yield return new moths(55, 2, 0, "SEsoak");
                yield return new moths(6, 0, 2, "Disturbed");
                yield return new moths(90, 6, 2, "NEsoak");
                yield return new moths(44, 0, 4, "NEsoak");
                yield return new moths(21, 0, 4, "Bank");
                yield return new moths(36, 9, 1, "SEsoak");
            }
        }
    }
}
