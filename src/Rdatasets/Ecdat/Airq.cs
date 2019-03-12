// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Air Quality for Californian Metropolitan Areas
    /// </summary>

    public class Airq
    {
        public readonly int κ;
        public readonly int airq;
        public readonly double vala;
        public readonly double rain;
        public readonly string coas;
        public readonly double dens;
        public readonly int medi;

        public Airq(int κ, int airq, double vala, double rain, string coas, double dens, int medi)
        {
            this.κ = κ;
            this.airq = airq;
            this.vala = vala;
            this.rain = rain;
            this.coas = coas;
            this.dens = dens;
            this.medi = medi;
        }

        public static IEnumerable<Airq> Data
        {
            get
            {
                yield return new Airq(1, 104, 2734.4, 12.63, "yes", 1815.86, 4397);
                yield return new Airq(2, 85, 2479.2, 47.14, "yes", 804.86, 5667);
                yield return new Airq(3, 127, 4845, 42.77, "yes", 1907.86, 15817);
                yield return new Airq(4, 145, 19733.8, 33.18, "no", 1876.08, 32698);
                yield return new Airq(5, 84, 4093.6, 34.55, "yes", 340.93, 6250);
                yield return new Airq(6, 135, 1849.8, 14.81, "no", 335.52, 4705);
                yield return new Airq(7, 88, 4179.4, 45.94, "yes", 315.78, 7165);
                yield return new Airq(8, 118, 2525.3, 39.25, "no", 360.39, 4472);
                yield return new Airq(9, 74, 1899.2, 42.36, "yes", 12957.5, 2658);
                yield return new Airq(10, 104, 15257.1, 12.63, "yes", 1728.19, 33885);
                yield return new Airq(11, 64, 1219, 59.76, "yes", 620.96, 5160);
                yield return new Airq(12, 75, 992.9, 53.9, "yes", 529.62, 3738);
                yield return new Airq(13, 131, 15120.8, 42.37, "yes", 5397.47, 59460);
                yield return new Airq(14, 129, 9189.9, 42.48, "yes", 1356.04, 19224);
                yield return new Airq(15, 84, 1596.9, 37.18, "yes", 276.44, 3944);
                yield return new Airq(16, 165, 4157.3, 36.14, "yes", 787.47, 9281);
                yield return new Airq(17, 80, 1185.2, 12.63, "yes", 318.63, 5012);
                yield return new Airq(18, 59, 3817.7, 18.69, "yes", 1255.04, 15710);
                yield return new Airq(19, 110, 1686.2, 35.35, "no", 750.28, 2509);
                yield return new Airq(20, 120, 1322, 35.08, "yes", 325.36, 2627);
                yield return new Airq(21, 118, 3476.2, 43.05, "yes", 916.78, 8019);
                yield return new Airq(22, 120, 1123.8, 68.13, "yes", 271.59, 2425);
                yield return new Airq(23, 120, 1151.6, 35.35, "no", 645.83, 1364);
                yield return new Airq(24, 59, 2896.3, 18.69, "yes", 819.23, 4155);
                yield return new Airq(25, 74, 5608.6, 42.36, "yes", 2649.07, 8947);
                yield return new Airq(26, 124, 3700, 29.51, "no", 9642.86, 5952);
                yield return new Airq(27, 69, 1395.5, 42.92, "yes", 1105.55, 4146);
                yield return new Airq(28, 118, 3022.8, 41.32, "no", 910.79, 3207);
                yield return new Airq(29, 129, 1515.4, 31.22, "no", 379.58, 853);
                yield return new Airq(30, 129, 1878.9, 30.95, "no", 455.92, 853);
            }
        }
    }
}
