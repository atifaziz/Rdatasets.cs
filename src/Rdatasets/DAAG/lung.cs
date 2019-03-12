// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Cape Fur Seal Lung Measurements
    /// </summary>

    public class lung
    {
        public readonly int κ;
        public readonly double? dat;

        public lung(int κ, double? dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<lung> Data
        {
            get
            {
                yield return new lung(1, 605);
                yield return new lung(2, 436);
                yield return new lung(3, 380);
                yield return new lung(4, 493.9);
                yield return new lung(5, null);
                yield return new lung(6, 550);
                yield return new lung(7, 470);
                yield return new lung(8, 592.5);
                yield return new lung(9, 605);
                yield return new lung(10, 799.9);
                yield return new lung(11, 995);
                yield return new lung(12, 785);
                yield return new lung(13, 910);
                yield return new lung(14, 1115);
                yield return new lung(15, 1142.6);
                yield return new lung(16, 1465);
                yield return new lung(17, 1250);
                yield return new lung(18, 1580);
                yield return new lung(19, 2000);
                yield return new lung(20, 1474.4);
                yield return new lung(21, null);
                yield return new lung(22, 1220);
                yield return new lung(23, 1790);
                yield return new lung(24, 1510);
                yield return new lung(25, null);
                yield return new lung(26, null);
                yield return new lung(27, 2735);
                yield return new lung(28, null);
                yield return new lung(29, 2380);
                yield return new lung(30, null);
            }
        }
    }
}
