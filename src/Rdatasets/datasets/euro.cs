// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Conversion Rates of Euro Currencies
    /// </summary>

    public class euro
    {
        public readonly double dat;

        public euro(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<euro> Data
        {
            get
            {
                yield return new euro(13.7603);
                yield return new euro(40.3399);
                yield return new euro(1.95583);
                yield return new euro(166.386);
                yield return new euro(5.94573);
                yield return new euro(6.55957);
                yield return new euro(0.787564);
                yield return new euro(1936.27);
                yield return new euro(40.3399);
                yield return new euro(2.20371);
                yield return new euro(200.482);
            }
        }
    }
}
