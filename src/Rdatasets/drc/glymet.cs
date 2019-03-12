// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Glyphosate and metsulfuron-methyl tested on algae.
    /// </summary>

    public class glymet
    {
        public readonly int κ;
        public readonly double dose;
        public readonly int pct;
        public readonly double rgr;

        public glymet(int κ, double dose, int pct, double rgr)
        {
            this.κ = κ;
            this.dose = dose;
            this.pct = pct;
            this.rgr = rgr;
        }

        public static IEnumerable<glymet> Data
        {
            get
            {
                yield return new glymet(6, 0, 999, 1.688328136);
                yield return new glymet(7, 0, 999, 1.691424121);
                yield return new glymet(8, 0, 999, 1.43678232);
                yield return new glymet(9, 0, 999, 1.458885366);
                yield return new glymet(10, 0, 999, 1.576368011);
                yield return new glymet(11, 5937.5, 100, 1.769820466);
                yield return new glymet(12, 5937.5, 100, 1.557766737);
                yield return new glymet(13, 11875, 100, 1.703619848);
                yield return new glymet(14, 11875, 100, 1.511319863);
                yield return new glymet(15, 23750, 100, 1.609437912);
                yield return new glymet(16, 23750, 100, 1.589026915);
                yield return new glymet(17, 47500, 100, 1.383445351);
                yield return new glymet(18, 47500, 100, 1.329175266);
                yield return new glymet(19, 95000, 100, 1.170902903);
                yield return new glymet(20, 95000, 100, 0.943534825);
                yield return new glymet(21, 190000, 100, 0.467154619);
                yield return new glymet(22, 190000, 100, 0.484700279);
                yield return new glymet(23, 380000, 100, 0.39422868);
                yield return new glymet(24, 380000, 100, 0.293893332);
                yield return new glymet(25, 760000, 100, 0.091160778);
                yield return new glymet(26, 760000, 100, 0.168236118);
                yield return new glymet(27, 5937.5, 83, 1.595238175);
                yield return new glymet(28, 5937.5, 83, 1.554530479);
                yield return new glymet(29, 11875, 83, 1.748253781);
                yield return new glymet(30, 11875, 83, 1.497866137);
                yield return new glymet(31, 23750, 83, 1.755772719);
                yield return new glymet(32, 47500, 83, 1.550046144);
                yield return new glymet(33, 47500, 83, 1.326620982);
                yield return new glymet(34, 95000, 83, 1.319528665);
                yield return new glymet(35, 95000, 83, 1.125645899);
                yield return new glymet(36, 190000, 83, 0.564232626);
                yield return new glymet(37, 190000, 83, 0.592811833);
                yield return new glymet(38, 380000, 83, 0.549306144);
                yield return new glymet(39, 380000, 83, 0.265314126);
                yield return new glymet(40, 760000, 83, 0.04765509);
                yield return new glymet(41, 760000, 83, 0.04765509);
                yield return new glymet(42, 5937.5, 67, 1.746736329);
                yield return new glymet(43, 5937.5, 67, 1.565568455);
                yield return new glymet(44, 11875, 67, 1.543769911);
                yield return new glymet(45, 11875, 67, 1.366684005);
                yield return new glymet(46, 23750, 67, 1.43678232);
                yield return new glymet(47, 23750, 67, 1.40770436);
                yield return new glymet(48, 47500, 67, 1.350680606);
                yield return new glymet(49, 47500, 67, 1.16119386);
                yield return new glymet(50, 95000, 67, 1.058127757);
                yield return new glymet(51, 95000, 67, 0.895879735);
                yield return new glymet(52, 190000, 67, 0.980829253);
                yield return new glymet(53, 190000, 67, 0.745827438);
                yield return new glymet(54, 380000, 67, 0.446908938);
                yield return new glymet(55, 380000, 67, 0.490414627);
                yield return new glymet(56, 760000, 67, 0.1627112);
                yield return new glymet(57, 760000, 67, 0.1627112);
                yield return new glymet(58, 5937.5, 50, 1.764648692);
                yield return new glymet(59, 5937.5, 50, 1.586939229);
                yield return new glymet(60, 11875, 50, 1.620427366);
                yield return new glymet(61, 11875, 50, 1.386294361);
                yield return new glymet(62, 23750, 50, 1.357347372);
                yield return new glymet(63, 23750, 50, 1.363926414);
                yield return new glymet(64, 47500, 50, 1.365014554);
                yield return new glymet(65, 47500, 50, 1.47221949);
                yield return new glymet(66, 95000, 50, 0.987040513);
                yield return new glymet(67, 95000, 50, 0.895879735);
                yield return new glymet(68, 190000, 50, 0.632833187);
                yield return new glymet(69, 190000, 50, 0.60651132);
                yield return new glymet(70, 380000, 50, 0.42364893);
                yield return new glymet(71, 380000, 50, 0.510825624);
                yield return new glymet(72, 760000, 50, 0.083527042);
                yield return new glymet(73, 760000, 50, 0.155077464);
                yield return new glymet(74, 5937.5, 33, 1.727632301);
                yield return new glymet(75, 5937.5, 33, 1.51694202);
                yield return new glymet(76, 11875, 33, 1.697254197);
                yield return new glymet(77, 11875, 33, 1.51506685);
                yield return new glymet(78, 23750, 33, 1.260637147);
                yield return new glymet(79, 23750, 33, 1.432685228);
                yield return new glymet(80, 47500, 33, 1.386294361);
                yield return new glymet(81, 47500, 33, 1.301344843);
                yield return new glymet(82, 95000, 33, 1.0551066);
                yield return new glymet(83, 95000, 33, 0.916290732);
                yield return new glymet(84, 190000, 33, 0.549306144);
                yield return new glymet(85, 190000, 33, 0.490414627);
                yield return new glymet(86, 380000, 33, 0.34657359);
                yield return new glymet(87, 380000, 33, 0.293893332);
                yield return new glymet(88, 760000, 33, 0.100335348);
                yield return new glymet(89, 760000, 33, 0.18386239);
                yield return new glymet(90, 5937.5, 17, 1.491576746);
                yield return new glymet(91, 5937.5, 17, 1.624217314);
                yield return new glymet(92, 11875, 17, 1.692195132);
                yield return new glymet(93, 11875, 17, 1.345621541);
                yield return new glymet(94, 23750, 17, 1.119023286);
                yield return new glymet(95, 23750, 17, 1.412916618);
                yield return new glymet(96, 47500, 17, 1.397877891);
                yield return new glymet(97, 47500, 17, 1.354025101);
                yield return new glymet(98, 95000, 17, 1.151292546);
                yield return new glymet(99, 95000, 17, 1.086111638);
                yield return new glymet(100, 190000, 17, 0.679061742);
                yield return new glymet(101, 190000, 17, 0.679061742);
                yield return new glymet(102, 380000, 17, 0.505800456);
                yield return new glymet(103, 380000, 17, 0.505800456);
                yield return new glymet(104, 760000, 17, 0.31430433);
                yield return new glymet(105, 760000, 17, 0.279807894);
                yield return new glymet(106, 11875, 0, 1.151292546);
                yield return new glymet(107, 23750, 0, 1.116796111);
                yield return new glymet(108, 23750, 0, 1.193871451);
                yield return new glymet(109, 47500, 0, 1.374436098);
                yield return new glymet(110, 47500, 0, 1.08452685);
                yield return new glymet(111, 95000, 0, 1.070033082);
                yield return new glymet(112, 95000, 0, 0.895879735);
                yield return new glymet(113, 190000, 0, 0.640466923);
                yield return new glymet(114, 190000, 0, 0.565701056);
                yield return new glymet(115, 380000, 0, 0.594792033);
                yield return new glymet(116, 380000, 0, 0.572566152);
                yield return new glymet(117, 760000, 0, 0.273271853);
                yield return new glymet(118, 760000, 0, 0.246238243);
            }
        }
    }
}
