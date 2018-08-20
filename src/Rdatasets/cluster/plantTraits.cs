// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Plant Species Traits Data
    /// </summary>

    public class plantTraits
    {
        public readonly double? pdias;
        public readonly double? longindex;
        public readonly int durflow;
        public readonly int height;
        public readonly int begflow;
        public readonly int? mycor;
        public readonly int? vegaer;
        public readonly int? vegsout;
        public readonly int autopoll;
        public readonly int insects;
        public readonly int wind;
        public readonly int lign;
        public readonly int piq;
        public readonly int? ros;
        public readonly int? semiros;
        public readonly int? leafy;
        public readonly int suman;
        public readonly int winan;
        public readonly int monocarp;
        public readonly int polycarp;
        public readonly int? seasaes;
        public readonly int? seashiv;
        public readonly int? seasver;
        public readonly int? everalw;
        public readonly int? everparti;
        public readonly int? elaio;
        public readonly int? endozoo;
        public readonly int? epizoo;
        public readonly int? aquat;
        public readonly int? windgl;
        public readonly int? unsp;

        public plantTraits(double? pdias, double? longindex, int durflow, int height, int begflow, int? mycor, int? vegaer, int? vegsout, int autopoll, int insects, int wind, int lign, int piq, int? ros, int? semiros, int? leafy, int suman, int winan, int monocarp, int polycarp, int? seasaes, int? seashiv, int? seasver, int? everalw, int? everparti, int? elaio, int? endozoo, int? epizoo, int? aquat, int? windgl, int? unsp)
        {
            this.pdias = pdias;
            this.longindex = longindex;
            this.durflow = durflow;
            this.height = height;
            this.begflow = begflow;
            this.mycor = mycor;
            this.vegaer = vegaer;
            this.vegsout = vegsout;
            this.autopoll = autopoll;
            this.insects = insects;
            this.wind = wind;
            this.lign = lign;
            this.piq = piq;
            this.ros = ros;
            this.semiros = semiros;
            this.leafy = leafy;
            this.suman = suman;
            this.winan = winan;
            this.monocarp = monocarp;
            this.polycarp = polycarp;
            this.seasaes = seasaes;
            this.seashiv = seashiv;
            this.seasver = seasver;
            this.everalw = everalw;
            this.everparti = everparti;
            this.elaio = elaio;
            this.endozoo = endozoo;
            this.epizoo = epizoo;
            this.aquat = aquat;
            this.windgl = windgl;
            this.unsp = unsp;
        }

        public static IEnumerable<plantTraits> Data
        {
            get
            {
                yield return new plantTraits(96.84, 0, 2, 7, 5, 2, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(110.72, 0, 3, 8, 4, 2, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(0.06, 0.666666667, 3, 2, 6, 2, 0, 1, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.08, 0.488888889, 2, 2, 7, 1, 2, 0, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(1.48, 0.476190476, 3, 2, 5, 2, 2, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(2.33, 0.5, 3, 5, 4, 0, 0, 0, 3, 3, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.38, 0.904761905, 3, 2, 6, 2, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(2.55, 0.066666667, 3, 2, 3, 2, 0, 2, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(1.48, 0.210526316, 3, 3, 7, 2, 0, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0);
                yield return new plantTraits(0.52, 0.369565217, 3, 2, 4, 2, 0, 0, 2, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(3.29, 0.206896552, 4, 5, 6, 1, 0, 1, 1, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.13, 0.8, 5, 5, 7, 2, 0, 0, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(268.45, 0, 3, 3, 4, 2, 0, 1, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.1, null, 2, 8, 4, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(4.16, 0.222222222, 3, 3, 6, 2, 0, 1, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(7.92, 0, 3, 3, 5, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(14.6, null, 3, 5, 6, null, 0, 0, 0, 4, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(31.28, 0.555555556, 4, 5, 6, 2, 0, 1, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(0.04, 0.827586207, 2, 4, 8, 2, 0, 0, 0, 3, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(63.8, 0, 2, 8, 4, null, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(0.8, null, 2, 3, 5, null, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, 0.930555556, 4, 5, 7, 1, 0, 0, 0, 0, 3, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.83, 1, 6, 4, 4, 1, 0, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(1.41, 0.520833333, 3, 4, 7, 2, 0, 2, 0, 4, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(1.97, 0, 3, 2, 6, 2, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(2.37, 0.388888889, 4, 5, 7, 1, 0, 0, 0, 3, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(2.4, 0.5, 2, 1, 5, 2, 0, 1, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(1042, 0, 4, 6, 1, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 1, 4, 2, 6, null, 0, 0, 3, 0, 0, 0, 0, null, null, null, 1, 0, 0, 0, 1, 0, 0, 0, 0, null, null, null, null, null, null);
                yield return new plantTraits(169.4, 0, 2, 5, 5, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(525, 0, 2, 7, 5, null, 0, 0, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(280, 0, 2, 7, 5, 2, 0, 0, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 3, 4, 7, null, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(7.78, 0.5, 2, 5, 5, 2, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.99, 0.425531915, 3, 3, 5, 2, 0, 0, 1, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(103.4, null, 2, 4, 3, null, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(1.09, 0.722222222, 4, 2, 6, 2, 0, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.68, 0.157894737, 2, 2, 6, 2, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.27, null, 3, 2, 6, null, 0, 0, 3, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, null, null, null, null, null, null, null, null, null, null, null);
                yield return new plantTraits(0.07, 0.8, 4, 4, 6, 1, 0, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(4.13, 0.5, 1, 4, 7, 2, 0, 0, 2, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(null, 0.166666667, 4, 3, 6, 2, 1, 0, 3, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(4.6, 1, 3, 4, 4, null, 0, 1, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(null, 0, 2, 6, 5, 2, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0);
                yield return new plantTraits(254.01, 0, 2, 8, 4, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(493.6, 0, 5, 5, 5, null, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(77.4, 0.111111111, 1, 8, 5, null, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(77.41, 0.111111111, 2, 8, 4, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(null, 0.411764706, 3, 2, 4, 2, 2, 0, 1, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0);
                yield return new plantTraits(8.34, 0.310344828, 3, 5, 6, 1, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.53, 0.214285714, 4, 3, 5, null, 0, 1, 2, 3, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(1.6, 0.363636364, 5, 3, 5, 1, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(2.45, 0.2, 4, 3, 5, 2, 0, 0, 3, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.68, 0.3, 3, 2, 3, 1, 2, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(256.17, 0, 3, 8, 9, 2, 2, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.39, 0.603174603, 2, 3, 6, 2, 0, 0, 2, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.33, 0, 2, 2, 6, 2, 0, 2, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(null, null, 1, 2, 5, null, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(5.84, 0, 2, 2, 4, 2, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.1, 0.8125, 3, 3, 6, 2, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(140, 0, 2, 7, 5, 2, 0, 0, 0, 4, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.02, 0.615384615, 3, 4, 5, null, 0, 0, 2, 1, 3, 0, 0, null, null, null, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.01, 0.865671642, 3, 5, 6, null, 0, 1, 2, 1, 3, 0, 0, null, null, null, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.64, 0.875, 4, 4, 7, null, 0, 0, 3, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(1.04, 0.928571429, 3, 3, 7, 2, 0, 0, 3, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, null, 3, 5, 3, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.38, 0.522727273, 4, 3, 6, 2, 0, 0, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(179.39, 0, 2, 6, 6, 2, 0, 0, 2, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 4, 3, 5, null, 0, 2, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, null, null, null, null, null, null);
                yield return new plantTraits(null, 0, 4, 6, 6, 2, 0, 0, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 0.5, 2, 1, 4, null, 0, 0, 0, 2, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 2, 6, 5, 2, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(1.99, 0.741935484, 7, 2, 5, 2, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, null, 2, 3, 7, null, 0, 0, 2, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, 0, 3, 3, 5, null, 0, 0, 3, 3, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(3.73, 0, 2, 4, 5, 0, 0, 1, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(2.5, 0.769230769, 6, 2, 5, null, 0, 0, 0, 0, 4, 0, 0, null, null, null, 1, 1, 0, 0, null, null, null, null, null, null, null, null, null, null, null);
                yield return new plantTraits(1.08, 0.25, 2, 3, 5, 1, 0, 0, 2, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.81, 0.470588235, 3, 4, 6, 2, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.11, 0.866666667, 3, 2, 5, 0, 0, 0, 0, 4, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(0.26, 0.78125, 5, 2, 6, 2, 0, 0, 3, 0, 3, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.3, 0.888888889, 12, 2, 3, 2, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.2, 0.2, 3, 4, 6, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.3, 0.584615385, 3, 2, 5, 1, 0, 1, 2, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.17, 0.823529412, 1, 2, 6, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, 0.8125, 5, 4, 7, 1, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, null, 3, 3, 9, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(527.4, 0, 2, 3, 5, null, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 0, 2, 8, 2, 2, 0, 2, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(0.28, 0.444444444, 4, 2, 6, 2, 2, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.58, 0.666666667, 4, 1, 2, 2, 2, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(1.22, 1, 2, 2, 3, 2, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(null, 0, 2, 8, 4, 2, 0, 0, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 3, 7, 3, null, null, null, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 2, 7, 5, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(1684.3, 0, 3, 6, 3, 1, 0, 2, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 3, 5, 8, 2, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(null, null, 2, 8, 4, null, 0, 0, 0, 4, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 2, 8, 5, null, null, null, 0, 0, 3, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(1.74, 0.393939394, 5, 2, 5, 2, 1, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(1.82, 0.723684211, 3, 2, 5, 2, 2, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new plantTraits(null, 1, 3, 8, 5, null, 0, 2, 0, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(1.275, null, 2, 5, 6, null, 0, 0, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, null, null, null, null, null, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 0, 3, 5, 5, 2, 0, 0, 3, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 0, 5, 4, 6, 2, 2, 0, 3, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 0.444444444, 4, 6, 6, 2, 0, 2, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, null, 2, 5, 6, null, 0, 1, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(1.5, 0.480769231, 2, 2, 5, 0, 0, 1, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(1.42, 0.5, 2, 4, 5, 0, 0, 0, 2, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0);
                yield return new plantTraits(2.93, 0.764705882, 3, 3, 6, 1, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(1.42, 0.75, 3, 4, 6, null, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, 0, 4, 4, 1, null, 0, 1, 0, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(89.23, 0.5, 2, 7, 6, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.09, 0.9, 4, 3, 6, 1, 0, 2, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(null, 0.5, 4, 4, 6, 2, 0, 1, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.4, 0.789473684, 6, 4, 6, 2, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(null, null, 2, 8, 5, null, 0, 0, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(400, null, 2, 8, 5, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(1.55, 0.4, 3, 3, 6, 2, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(3.11, 0, 3, 3, 4, 0, 2, 0, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(0.48, 0.802631579, 12, 2, 3, 0, 0, 0, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, null, 2, 5, 7, null, 0, 1, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, null, null, null, null, null, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(null, 0, 3, 5, 5, 2, 0, 1, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.61, 0.472222222, 8, 3, 3, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(null, null, 2, 8, 3, 2, 1, 1, 0, 0, 3, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits(0.76, 0.5, 3, 3, 7, 2, 1, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, 0.6, 7, 1, 6, 2, 2, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(5.9, null, 4, 5, 7, null, 0, 0, 0, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1);
                yield return new plantTraits(9, 0, 2, 8, 2, 2, 0, 1, 0, 1, 3, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits(0.19, 0.795918367, 5, 5, 6, 0, 0, 2, 0, 1, 3, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits(0.22, 0.4, 3, 2, 4, 1, 0, 2, 2, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(39.44, 0.45, 3, 5, 5, 2, 0, 0, 3, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(21.4, 0.111111111, 4, 4, 5, 2, 0, 2, 2, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits(null, null, 2, 2, 3, null, 2, 0, 0, 4, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, null, null, null, null, null, null);
                yield return new plantTraits(3, 0.333333333, 2, 2, 4, 2, 0, 0, 2, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits(4, 0.5, 2, 1, 4, null, 0, 0, 2, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
            }
        }
    }
}
