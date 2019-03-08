// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Glyphosate and metsulfuron-methyl tested on algae.
    /// </summary>

    public class glymet
    {
        public readonly double dose;
        public readonly int pct;
        public readonly double rgr;

        public glymet(double dose, int pct, double rgr)
        {
            this.dose = dose;
            this.pct = pct;
            this.rgr = rgr;
        }

        public static IEnumerable<glymet> Data
        {
            get
            {
                yield return new glymet(0, 999, 1.688328136);
                yield return new glymet(0, 999, 1.691424121);
                yield return new glymet(0, 999, 1.43678232);
                yield return new glymet(0, 999, 1.458885366);
                yield return new glymet(0, 999, 1.576368011);
                yield return new glymet(5937.5, 100, 1.769820466);
                yield return new glymet(5937.5, 100, 1.557766737);
                yield return new glymet(11875, 100, 1.703619848);
                yield return new glymet(11875, 100, 1.511319863);
                yield return new glymet(23750, 100, 1.609437912);
                yield return new glymet(23750, 100, 1.589026915);
                yield return new glymet(47500, 100, 1.383445351);
                yield return new glymet(47500, 100, 1.329175266);
                yield return new glymet(95000, 100, 1.170902903);
                yield return new glymet(95000, 100, 0.943534825);
                yield return new glymet(190000, 100, 0.467154619);
                yield return new glymet(190000, 100, 0.484700279);
                yield return new glymet(380000, 100, 0.39422868);
                yield return new glymet(380000, 100, 0.293893332);
                yield return new glymet(760000, 100, 0.091160778);
                yield return new glymet(760000, 100, 0.168236118);
                yield return new glymet(5937.5, 83, 1.595238175);
                yield return new glymet(5937.5, 83, 1.554530479);
                yield return new glymet(11875, 83, 1.748253781);
                yield return new glymet(11875, 83, 1.497866137);
                yield return new glymet(23750, 83, 1.755772719);
                yield return new glymet(47500, 83, 1.550046144);
                yield return new glymet(47500, 83, 1.326620982);
                yield return new glymet(95000, 83, 1.319528665);
                yield return new glymet(95000, 83, 1.125645899);
                yield return new glymet(190000, 83, 0.564232626);
                yield return new glymet(190000, 83, 0.592811833);
                yield return new glymet(380000, 83, 0.549306144);
                yield return new glymet(380000, 83, 0.265314126);
                yield return new glymet(760000, 83, 0.04765509);
                yield return new glymet(760000, 83, 0.04765509);
                yield return new glymet(5937.5, 67, 1.746736329);
                yield return new glymet(5937.5, 67, 1.565568455);
                yield return new glymet(11875, 67, 1.543769911);
                yield return new glymet(11875, 67, 1.366684005);
                yield return new glymet(23750, 67, 1.43678232);
                yield return new glymet(23750, 67, 1.40770436);
                yield return new glymet(47500, 67, 1.350680606);
                yield return new glymet(47500, 67, 1.16119386);
                yield return new glymet(95000, 67, 1.058127757);
                yield return new glymet(95000, 67, 0.895879735);
                yield return new glymet(190000, 67, 0.980829253);
                yield return new glymet(190000, 67, 0.745827438);
                yield return new glymet(380000, 67, 0.446908938);
                yield return new glymet(380000, 67, 0.490414627);
                yield return new glymet(760000, 67, 0.1627112);
                yield return new glymet(760000, 67, 0.1627112);
                yield return new glymet(5937.5, 50, 1.764648692);
                yield return new glymet(5937.5, 50, 1.586939229);
                yield return new glymet(11875, 50, 1.620427366);
                yield return new glymet(11875, 50, 1.386294361);
                yield return new glymet(23750, 50, 1.357347372);
                yield return new glymet(23750, 50, 1.363926414);
                yield return new glymet(47500, 50, 1.365014554);
                yield return new glymet(47500, 50, 1.47221949);
                yield return new glymet(95000, 50, 0.987040513);
                yield return new glymet(95000, 50, 0.895879735);
                yield return new glymet(190000, 50, 0.632833187);
                yield return new glymet(190000, 50, 0.60651132);
                yield return new glymet(380000, 50, 0.42364893);
                yield return new glymet(380000, 50, 0.510825624);
                yield return new glymet(760000, 50, 0.083527042);
                yield return new glymet(760000, 50, 0.155077464);
                yield return new glymet(5937.5, 33, 1.727632301);
                yield return new glymet(5937.5, 33, 1.51694202);
                yield return new glymet(11875, 33, 1.697254197);
                yield return new glymet(11875, 33, 1.51506685);
                yield return new glymet(23750, 33, 1.260637147);
                yield return new glymet(23750, 33, 1.432685228);
                yield return new glymet(47500, 33, 1.386294361);
                yield return new glymet(47500, 33, 1.301344843);
                yield return new glymet(95000, 33, 1.0551066);
                yield return new glymet(95000, 33, 0.916290732);
                yield return new glymet(190000, 33, 0.549306144);
                yield return new glymet(190000, 33, 0.490414627);
                yield return new glymet(380000, 33, 0.34657359);
                yield return new glymet(380000, 33, 0.293893332);
                yield return new glymet(760000, 33, 0.100335348);
                yield return new glymet(760000, 33, 0.18386239);
                yield return new glymet(5937.5, 17, 1.491576746);
                yield return new glymet(5937.5, 17, 1.624217314);
                yield return new glymet(11875, 17, 1.692195132);
                yield return new glymet(11875, 17, 1.345621541);
                yield return new glymet(23750, 17, 1.119023286);
                yield return new glymet(23750, 17, 1.412916618);
                yield return new glymet(47500, 17, 1.397877891);
                yield return new glymet(47500, 17, 1.354025101);
                yield return new glymet(95000, 17, 1.151292546);
                yield return new glymet(95000, 17, 1.086111638);
                yield return new glymet(190000, 17, 0.679061742);
                yield return new glymet(190000, 17, 0.679061742);
                yield return new glymet(380000, 17, 0.505800456);
                yield return new glymet(380000, 17, 0.505800456);
                yield return new glymet(760000, 17, 0.31430433);
                yield return new glymet(760000, 17, 0.279807894);
                yield return new glymet(11875, 0, 1.151292546);
                yield return new glymet(23750, 0, 1.116796111);
                yield return new glymet(23750, 0, 1.193871451);
                yield return new glymet(47500, 0, 1.374436098);
                yield return new glymet(47500, 0, 1.08452685);
                yield return new glymet(95000, 0, 1.070033082);
                yield return new glymet(95000, 0, 0.895879735);
                yield return new glymet(190000, 0, 0.640466923);
                yield return new glymet(190000, 0, 0.565701056);
                yield return new glymet(380000, 0, 0.594792033);
                yield return new glymet(380000, 0, 0.572566152);
                yield return new glymet(760000, 0, 0.273271853);
                yield return new glymet(760000, 0, 0.246238243);
            }
        }
    }
}
