// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly Excess Returns
    /// </summary>

    public class acme
    {
        public readonly int κ;
        public readonly string month;
        public readonly double market;
        public readonly double acme_;

        public acme(int κ, string month, double market, double acme_)
        {
            this.κ = κ;
            this.month = month;
            this.market = market;
            this.acme_ = acme_;
        }

        public static IEnumerable<acme> Data
        {
            get
            {
                yield return new acme(1, "1/86", -0.061134, 0.03016);
                yield return new acme(2, "2/86", 0.00822, -0.165457);
                yield return new acme(3, "3/86", -0.007381, 0.080137);
                yield return new acme(4, "4/86", -0.067561, -0.109917);
                yield return new acme(5, "5/86", -0.006238, -0.114853);
                yield return new acme(6, "6/86", -0.044251, -0.099254);
                yield return new acme(7, "7/86", -0.11207, -0.226846);
                yield return new acme(8, "8/86", 0.030226, 0.073445);
                yield return new acme(9, "9/86", -0.129556, -0.143064);
                yield return new acme(10, "10/86", 0.001319, 0.034776);
                yield return new acme(11, "11/86", -0.033679, -0.063375);
                yield return new acme(12, "12/86", -0.072795, -0.058735);
                yield return new acme(13, "1/87", 0.073396, 0.050214);
                yield return new acme(14, "2/87", -0.011618, 0.111165);
                yield return new acme(15, "3/87", -0.026852, -0.127492);
                yield return new acme(16, "4/87", -0.040356, 0.054522);
                yield return new acme(17, "5/87", -0.047539, -0.072918);
                yield return new acme(18, "6/87", -0.001732, -0.058979);
                yield return new acme(19, "7/87", -0.008899, 0.236147);
                yield return new acme(20, "8/87", -0.020837, -0.094778);
                yield return new acme(21, "9/87", -0.084811, -0.135669);
                yield return new acme(22, "10/87", -0.262077, -0.284796);
                yield return new acme(23, "11/87", -0.110167, -0.171494);
                yield return new acme(24, "12/87", 0.034955, 0.242616);
                yield return new acme(25, "1/88", 0.012688, -0.063518);
                yield return new acme(26, "2/88", -0.00217, -0.117677);
                yield return new acme(27, "3/88", -0.073462, 0.201674);
                yield return new acme(28, "4/88", -0.043419, -0.147728);
                yield return new acme(29, "5/88", -0.05473, -0.170885);
                yield return new acme(30, "6/88", -0.011755, -0.014893);
                yield return new acme(31, "7/88", -0.061718, -0.110515);
                yield return new acme(32, "8/88", -0.10171, -0.168769);
                yield return new acme(33, "9/88", -0.032705, -0.135585);
                yield return new acme(34, "10/88", -0.045334, -0.084077);
                yield return new acme(35, "11/88", -0.079288, -0.16455);
                yield return new acme(36, "12/88", -0.036233, 0.150269);
                yield return new acme(37, "1/89", -0.011494, -0.015672);
                yield return new acme(38, "2/89", -0.093729, -0.03786);
                yield return new acme(39, "3/89", -0.065215, -0.074712);
                yield return new acme(40, "4/89", -0.037113, -0.10853);
                yield return new acme(41, "5/89", -0.044399, -0.036769);
                yield return new acme(42, "6/89", -0.084412, 0.023912);
                yield return new acme(43, "7/89", 0.003444, -0.07843);
                yield return new acme(44, "8/89", -0.05676, -0.132199);
                yield return new acme(45, "9/89", -0.07897, -0.110141);
                yield return new acme(46, "10/89", -0.105367, -0.126302);
                yield return new acme(47, "11/89", -0.038634, -0.09573);
                yield return new acme(48, "12/89", -0.043261, 0.06574);
                yield return new acme(49, "1/90", -0.139773, -0.120056);
                yield return new acme(50, "2/90", -0.059094, -0.085205);
                yield return new acme(51, "3/90", -0.057736, -0.130433);
                yield return new acme(52, "4/90", -0.102524, -0.116728);
                yield return new acme(53, "5/90", 0.023881, -0.078039);
                yield return new acme(54, "6/90", -0.079116, -0.170322);
                yield return new acme(55, "7/90", -0.078965, -0.077727);
                yield return new acme(56, "8/90", -0.161359, -0.277035);
                yield return new acme(57, "9/90", -0.119376, -0.207595);
                yield return new acme(58, "10/90", -0.076008, -0.070515);
                yield return new acme(59, "11/90", -0.006444, -0.046274);
                yield return new acme(60, "12/90", -0.026401, -0.190834);
            }
        }
    }
}
