// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Mouse Litters
    /// </summary>

    public class litters
    {
        public readonly int κ;
        public readonly int lsize;
        public readonly double bodywt;
        public readonly double brainwt;

        public litters(int κ, int lsize, double bodywt, double brainwt)
        {
            this.κ = κ;
            this.lsize = lsize;
            this.bodywt = bodywt;
            this.brainwt = brainwt;
        }

        public static IEnumerable<litters> Data
        {
            get
            {
                yield return new litters(1, 3, 9.447, 0.444);
                yield return new litters(2, 3, 9.78, 0.436);
                yield return new litters(3, 4, 9.155, 0.417);
                yield return new litters(4, 4, 9.613, 0.429);
                yield return new litters(5, 5, 8.85, 0.425);
                yield return new litters(6, 5, 9.61, 0.434);
                yield return new litters(7, 6, 8.298, 0.404);
                yield return new litters(8, 6, 8.543, 0.439);
                yield return new litters(9, 7, 7.4, 0.409);
                yield return new litters(10, 7, 8.335, 0.429);
                yield return new litters(11, 8, 7.04, 0.414);
                yield return new litters(12, 8, 7.253, 0.409);
                yield return new litters(13, 9, 6.6, 0.387);
                yield return new litters(14, 9, 7.26, 0.433);
                yield return new litters(15, 10, 6.305, 0.41);
                yield return new litters(16, 10, 6.655, 0.405);
                yield return new litters(17, 11, 7.183, 0.435);
                yield return new litters(18, 11, 6.133, 0.407);
                yield return new litters(19, 12, 5.45, 0.368);
                yield return new litters(20, 12, 6.05, 0.401);
            }
        }
    }
}
