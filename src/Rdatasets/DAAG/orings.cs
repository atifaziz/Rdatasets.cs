// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Challenger O-rings Data
    /// </summary>

    public class orings
    {
        public readonly int κ;
        public readonly int Temperature;
        public readonly int Erosion;
        public readonly int Blowby;
        public readonly int Total;

        public orings(int κ, int Temperature, int Erosion, int Blowby, int Total)
        {
            this.κ = κ;
            this.Temperature = Temperature;
            this.Erosion = Erosion;
            this.Blowby = Blowby;
            this.Total = Total;
        }

        public static IEnumerable<orings> Data
        {
            get
            {
                yield return new orings(1, 53, 3, 2, 5);
                yield return new orings(2, 57, 1, 0, 1);
                yield return new orings(3, 58, 1, 0, 1);
                yield return new orings(4, 63, 1, 0, 1);
                yield return new orings(5, 66, 0, 0, 0);
                yield return new orings(6, 67, 0, 0, 0);
                yield return new orings(7, 67, 0, 0, 0);
                yield return new orings(8, 67, 0, 0, 0);
                yield return new orings(9, 68, 0, 0, 0);
                yield return new orings(10, 69, 0, 0, 0);
                yield return new orings(11, 70, 1, 0, 1);
                yield return new orings(12, 70, 0, 0, 0);
                yield return new orings(13, 70, 1, 0, 1);
                yield return new orings(14, 70, 0, 0, 0);
                yield return new orings(15, 72, 0, 0, 0);
                yield return new orings(16, 73, 0, 0, 0);
                yield return new orings(17, 75, 0, 0, 0);
                yield return new orings(18, 75, 0, 2, 1);
                yield return new orings(19, 76, 0, 0, 0);
                yield return new orings(20, 76, 0, 0, 0);
                yield return new orings(21, 78, 0, 0, 0);
                yield return new orings(22, 79, 0, 0, 0);
                yield return new orings(23, 81, 0, 0, 0);
            }
        }
    }
}
