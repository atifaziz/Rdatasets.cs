// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Conversion Rates of Euro Currencies
    /// </summary>

    public class euro
    {
        public readonly string κ;
        public readonly double dat;

        public euro(string κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<euro> Data
        {
            get
            {
                yield return new euro("ATS", 13.7603);
                yield return new euro("BEF", 40.3399);
                yield return new euro("DEM", 1.95583);
                yield return new euro("ESP", 166.386);
                yield return new euro("FIM", 5.94573);
                yield return new euro("FRF", 6.55957);
                yield return new euro("IEP", 0.787564);
                yield return new euro("ITL", 1936.27);
                yield return new euro("LUF", 40.3399);
                yield return new euro("NLG", 2.20371);
                yield return new euro("PTE", 200.482);
            }
        }
    }
}
