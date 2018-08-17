// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Challenger O-rings Data
    /// </summary>

    public class orings
    {
        public readonly int Temperature;
        public readonly int Erosion;
        public readonly int Blowby;
        public readonly int Total;

        public orings(int Temperature, int Erosion, int Blowby, int Total)
        {
            this.Temperature = Temperature;
            this.Erosion = Erosion;
            this.Blowby = Blowby;
            this.Total = Total;
        }

        public static IEnumerable<orings> Data
        {
            get
            {
                yield return new orings(53, 3, 2, 5);
                yield return new orings(57, 1, 0, 1);
                yield return new orings(58, 1, 0, 1);
                yield return new orings(63, 1, 0, 1);
                yield return new orings(66, 0, 0, 0);
                yield return new orings(67, 0, 0, 0);
                yield return new orings(67, 0, 0, 0);
                yield return new orings(67, 0, 0, 0);
                yield return new orings(68, 0, 0, 0);
                yield return new orings(69, 0, 0, 0);
                yield return new orings(70, 1, 0, 1);
                yield return new orings(70, 0, 0, 0);
                yield return new orings(70, 1, 0, 1);
                yield return new orings(70, 0, 0, 0);
                yield return new orings(72, 0, 0, 0);
                yield return new orings(73, 0, 0, 0);
                yield return new orings(75, 0, 0, 0);
                yield return new orings(75, 0, 2, 1);
                yield return new orings(76, 0, 0, 0);
                yield return new orings(76, 0, 0, 0);
                yield return new orings(78, 0, 0, 0);
                yield return new orings(79, 0, 0, 0);
                yield return new orings(81, 0, 0, 0);
            }
        }
    }
}
