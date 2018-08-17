// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Cape Fur Seal Lung Measurements
    /// </summary>

    public class lung
    {
        public readonly string dat;

        public lung(string dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<lung> Data
        {
            get
            {
                yield return new lung("605");
                yield return new lung("436");
                yield return new lung("380");
                yield return new lung("493.9");
                yield return new lung(null);
                yield return new lung("550");
                yield return new lung("470");
                yield return new lung("592.5");
                yield return new lung("605");
                yield return new lung("799.9");
                yield return new lung("995");
                yield return new lung("785");
                yield return new lung("910");
                yield return new lung("1115");
                yield return new lung("1142.6");
                yield return new lung("1465");
                yield return new lung("1250");
                yield return new lung("1580");
                yield return new lung("2000");
                yield return new lung("1474.4");
                yield return new lung(null);
                yield return new lung("1220");
                yield return new lung("1790");
                yield return new lung("1510");
                yield return new lung(null);
                yield return new lung(null);
                yield return new lung("2735");
                yield return new lung(null);
                yield return new lung("2380");
                yield return new lung(null);
            }
        }
    }
}
