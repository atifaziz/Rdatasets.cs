// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of erythromycin on mixed sewage microorganisms
    /// </summary>

    public class etmotc
    {
        public readonly int κ;
        public readonly int cell;
        public readonly double dose1;
        public readonly int pct1;
        public readonly double rgr1;

        public etmotc(int κ, int cell, double dose1, int pct1, double rgr1)
        {
            this.κ = κ;
            this.cell = cell;
            this.dose1 = dose1;
            this.pct1 = pct1;
            this.rgr1 = rgr1;
        }

        public static IEnumerable<etmotc> Data
        {
            get
            {
                yield return new etmotc(1, 1, 0, 999, 0.649297642);
                yield return new etmotc(2, 2, 0, 999, 0.652652542);
                yield return new etmotc(3, 3, 0, 999, 0.649703292);
                yield return new etmotc(4, 4, 0, 999, 0.648224628);
                yield return new etmotc(5, 5, 0, 999, 0.646023399);
                yield return new etmotc(6, 6, 0, 999, 0.645883477);
                yield return new etmotc(7, 7, 0, 999, 0.649254387);
                yield return new etmotc(8, 8, 0, 999, 0.643761281);
                yield return new etmotc(9, 9, 0.36072, 100, 0.644775871);
                yield return new etmotc(10, 10, 0.9018, 100, 0.622680536);
                yield return new etmotc(11, 11, 2.7054, 100, 0.562994526);
                yield return new etmotc(12, 12, 5.4108, 100, 0.496809531);
                yield return new etmotc(13, 13, 14.4288, 100, 0.417300758);
                yield return new etmotc(14, 14, 36.072, 100, 0.343175157);
                yield return new etmotc(15, 15, 90.18, 100, 0.270650266);
                yield return new etmotc(16, 16, 0.36072, 83, 0.64561251);
                yield return new etmotc(17, 17, 0.9018, 83, 0.60819605);
                yield return new etmotc(18, 18, 2.7054, 83, 0.551168891);
                yield return new etmotc(19, 19, 5.4108, 83, 0.454957447);
                yield return new etmotc(20, 20, 14.4288, 83, 0.331034831);
                yield return new etmotc(21, 21, 36.072, 83, 0.2568863);
                yield return new etmotc(22, 22, 90.18, 83, 0.169403797);
                yield return new etmotc(23, 23, 0.36072, 67, 0.629871061);
                yield return new etmotc(24, 24, 0.9018, 67, 0.598206601);
                yield return new etmotc(25, 25, 2.7054, 67, 0.522495303);
                yield return new etmotc(26, 26, 5.4108, 67, 0.418652629);
                yield return new etmotc(27, 27, 14.4288, 67, 0.312536568);
                yield return new etmotc(28, 28, 36.072, 67, 0.239606959);
                yield return new etmotc(29, 29, 90.18, 67, 0.152782307);
                yield return new etmotc(30, 30, 0.36072, 50, 0.628230467);
                yield return new etmotc(31, 31, 0.9018, 50, 0.58922191);
                yield return new etmotc(32, 32, 2.7054, 50, 0.502034798);
                yield return new etmotc(33, 33, 5.4108, 50, 0.411539999);
                yield return new etmotc(34, 34, 14.4288, 50, 0.309073345);
                yield return new etmotc(35, 35, 36.072, 50, 0.226016527);
                yield return new etmotc(36, 36, 90.18, 50, 0.141772737);
                yield return new etmotc(37, 37, 0.36072, 33, 0.624691684);
                yield return new etmotc(38, 38, 0.9018, 33, 0.582774171);
                yield return new etmotc(39, 39, 2.7054, 33, 0.485264568);
                yield return new etmotc(40, 40, 5.4108, 33, 0.406735375);
                yield return new etmotc(41, 41, 14.4288, 33, 0.307989108);
                yield return new etmotc(42, 42, 36.072, 33, 0.221437798);
                yield return new etmotc(43, 43, 90.18, 33, 0.135348941);
                yield return new etmotc(44, 44, 0.36072, 17, 0.627370334);
                yield return new etmotc(45, 45, 0.9018, 17, 0.582208167);
                yield return new etmotc(46, 46, 2.7054, 17, 0.474243095);
                yield return new etmotc(47, 47, 5.4108, 17, 0.398464454);
                yield return new etmotc(48, 48, 14.4288, 17, 0.305464928);
                yield return new etmotc(49, 49, 36.072, 17, 0.189824592);
                yield return new etmotc(50, 50, 90.18, 17, 0.128521745);
                yield return new etmotc(51, 51, 0.36072, 0, 0.625723143);
                yield return new etmotc(52, 52, 0.9018, 0, 0.582926514);
                yield return new etmotc(53, 53, 2.7054, 0, 0.459269324);
                yield return new etmotc(54, 54, 5.4108, 0, 0.396610153);
                yield return new etmotc(55, 55, 14.4288, 0, 0.314611249);
                yield return new etmotc(56, 56, 36.072, 0, 0.200608825);
                yield return new etmotc(57, 57, 90.18, 0, 0.120232055);
            }
        }
    }
}
