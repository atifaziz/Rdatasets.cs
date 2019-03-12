// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Plant Species Traits Data
    /// </summary>

    public class plantTraits
    {
        public readonly string κ;
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

        public plantTraits(string κ, double? pdias, double? longindex, int durflow, int height, int begflow, int? mycor, int? vegaer, int? vegsout, int autopoll, int insects, int wind, int lign, int piq, int? ros, int? semiros, int? leafy, int suman, int winan, int monocarp, int polycarp, int? seasaes, int? seashiv, int? seasver, int? everalw, int? everparti, int? elaio, int? endozoo, int? epizoo, int? aquat, int? windgl, int? unsp)
        {
            this.κ = κ;
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
                yield return new plantTraits("Aceca", 96.84, 0, 2, 7, 5, 2, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Aceps", 110.72, 0, 3, 8, 4, 2, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Agrca", 0.06, 0.666666667, 3, 2, 6, 2, 0, 1, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Agrst", 0.08, 0.488888889, 2, 2, 7, 1, 2, 0, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Ajure", 1.48, 0.476190476, 3, 2, 5, 2, 2, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Allpe", 2.33, 0.5, 3, 5, 4, 0, 0, 0, 3, 3, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Anaar", 0.38, 0.904761905, 3, 2, 6, 2, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Anene", 2.55, 0.066666667, 3, 2, 3, 2, 0, 2, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Angsy", 1.48, 0.210526316, 3, 3, 7, 2, 0, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0);
                yield return new plantTraits("Antod", 0.52, 0.369565217, 3, 2, 4, 2, 0, 0, 2, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Arrel", 3.29, 0.206896552, 4, 5, 6, 1, 0, 1, 1, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Artvu", 0.13, 0.8, 5, 5, 7, 2, 0, 0, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Aruma", 268.45, 0, 3, 3, 4, 2, 0, 1, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Betsp", 0.1, null, 2, 8, 4, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Brasy", 4.16, 0.222222222, 3, 3, 6, 2, 0, 1, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Brost", 7.92, 0, 3, 3, 5, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Brydi", 14.6, null, 3, 5, 6, null, 0, 0, 0, 4, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Calse", 31.28, 0.555555556, 4, 5, 6, 2, 0, 1, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Calvu", 0.04, 0.827586207, 2, 4, 8, 2, 0, 0, 0, 3, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Carbe", 63.8, 0, 2, 8, 4, null, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Cardi", 0.8, null, 2, 3, 5, null, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Cheal", null, 0.930555556, 4, 5, 7, 1, 0, 0, 0, 0, 3, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Chema", 0.83, 1, 6, 4, 4, 1, 0, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Cirar", 1.41, 0.520833333, 3, 4, 7, 2, 0, 2, 0, 4, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Cirlu", 1.97, 0, 3, 2, 6, 2, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Cirvu", 2.37, 0.388888889, 4, 5, 7, 1, 0, 0, 0, 3, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Conmj", 2.4, 0.5, 2, 1, 5, 2, 0, 1, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Corav", 1042, 0, 4, 6, 1, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Cordi", null, 1, 4, 2, 6, null, 0, 0, 3, 0, 0, 0, 0, null, null, null, 1, 0, 0, 0, 1, 0, 0, 0, 0, null, null, null, null, null, null);
                yield return new plantTraits("Corsa", 169.4, 0, 2, 5, 5, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Crala", 525, 0, 2, 7, 5, null, 0, 0, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Cramo", 280, 0, 2, 7, 5, 2, 0, 0, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Cucba", null, null, 3, 4, 7, null, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Cytsc", 7.78, 0.5, 2, 5, 5, 2, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1);
                yield return new plantTraits("Dacgl", 0.99, 0.425531915, 3, 3, 5, 2, 0, 0, 1, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Dapla", 103.4, null, 2, 4, 3, null, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Dauca", 1.09, 0.722222222, 4, 2, 6, 2, 0, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Desfl", 0.68, 0.157894737, 2, 2, 6, 2, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Diaar", 0.27, null, 3, 2, 6, null, 0, 0, 3, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, null, null, null, null, null, null, null, null, null, null, null);
                yield return new plantTraits("Digpu", 0.07, 0.8, 4, 4, 6, 1, 0, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Elyca", 4.13, 0.5, 1, 4, 7, 2, 0, 0, 2, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Epipa", null, 0.166666667, 4, 3, 6, 2, 1, 0, 3, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Eupam", 4.6, 1, 3, 4, 4, null, 0, 1, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Evoeu", null, 0, 2, 6, 5, 2, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0);
                yield return new plantTraits("Fagsy", 254.01, 0, 2, 8, 4, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Fraal", 493.6, 0, 5, 5, 5, null, 0, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Fraan", 77.4, 0.111111111, 1, 8, 5, null, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Frasp", 77.41, 0.111111111, 2, 8, 4, 2, 0, 0, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Frave", null, 0.411764706, 3, 2, 4, 2, 2, 0, 1, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0);
                yield return new plantTraits("Galap", 8.34, 0.310344828, 3, 5, 6, 1, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Galmo", 0.53, 0.214285714, 4, 3, 5, null, 0, 1, 2, 3, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Gerro", 1.6, 0.363636364, 5, 3, 5, 1, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Geuur", 2.45, 0.2, 4, 3, 5, 2, 0, 0, 3, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Glehe", 0.68, 0.3, 3, 2, 3, 1, 2, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Hedhe", 256.17, 0, 3, 8, 9, 2, 2, 0, 0, 4, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Holla", 0.39, 0.603174603, 2, 3, 6, 2, 0, 0, 2, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Holmo", 0.33, 0, 2, 2, 6, 2, 0, 2, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Hyahi", null, null, 1, 2, 5, null, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Hyano", 5.84, 0, 2, 2, 4, 2, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Hyppe", 0.1, 0.8125, 3, 3, 6, 2, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Ileaq", 140, 0, 2, 7, 5, 2, 0, 0, 0, 4, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Junco", 0.02, 0.615384615, 3, 4, 5, null, 0, 0, 2, 1, 3, 0, 0, null, null, null, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Junef", 0.01, 0.865671642, 3, 5, 6, null, 0, 1, 2, 1, 3, 0, 0, null, null, null, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Lacse", 0.64, 0.875, 4, 4, 7, null, 0, 0, 3, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Lapco", 1.04, 0.928571429, 3, 3, 7, 2, 0, 0, 3, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Launo", null, null, 3, 5, 3, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Leuvu", 0.38, 0.522727273, 4, 3, 6, 2, 0, 0, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Ligvu", 179.39, 0, 2, 6, 6, 2, 0, 0, 2, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Linre", null, null, 4, 3, 5, null, 0, 2, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, null, null, null, null, null, null);
                yield return new plantTraits("Lonpe", null, 0, 4, 6, 6, 2, 0, 0, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Luzmu", null, 0.5, 2, 1, 4, null, 0, 0, 0, 2, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Malsy", null, null, 2, 6, 5, 2, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Medlu", 1.99, 0.741935484, 7, 2, 5, 2, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Melof", null, null, 2, 3, 7, null, 0, 0, 2, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Melpr", null, 0, 3, 3, 5, null, 0, 0, 3, 3, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Melun", 3.73, 0, 2, 4, 5, 0, 0, 1, 0, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Meran", 2.5, 0.769230769, 6, 2, 5, null, 0, 0, 0, 0, 4, 0, 0, null, null, null, 1, 1, 0, 0, null, null, null, null, null, null, null, null, null, null, null);
                yield return new plantTraits("Milef", 1.08, 0.25, 2, 3, 5, 1, 0, 0, 2, 0, 3, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Molca", 0.81, 0.470588235, 3, 4, 6, 2, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Paprh", 0.11, 0.866666667, 3, 2, 5, 0, 0, 0, 0, 4, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Plama", 0.26, 0.78125, 5, 2, 6, 2, 0, 0, 3, 0, 3, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Poaan", 0.3, 0.888888889, 12, 2, 3, 2, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Poane", 0.2, 0.2, 3, 4, 6, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Poapr", 0.3, 0.584615385, 3, 2, 5, 1, 0, 1, 2, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Poatr", 0.17, 0.823529412, 1, 2, 6, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Polav", null, 0.8125, 5, 4, 7, 1, 0, 0, 3, 2, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Polin", null, null, 3, 3, 9, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Polmu", 527.4, 0, 2, 3, 5, null, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Poptr", null, 0, 2, 8, 2, 2, 0, 2, 0, 0, 4, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Potre", 0.28, 0.444444444, 4, 2, 6, 2, 2, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Potst", 0.58, 0.666666667, 4, 1, 2, 2, 2, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Privu", 1.22, 1, 2, 2, 3, 2, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Pruav", null, 0, 2, 8, 4, 2, 0, 0, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Pruce", null, null, 3, 7, 3, null, null, null, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Prula", null, null, 2, 7, 5, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Prusi", 1684.3, 0, 3, 6, 3, 1, 0, 2, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Pteaq", null, null, 3, 5, 8, 2, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Pyrsp", null, null, 2, 8, 4, null, 0, 0, 0, 4, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Queil", null, null, 2, 8, 5, null, null, null, 0, 0, 3, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Ranac", 1.74, 0.393939394, 5, 2, 5, 2, 1, 0, 0, 4, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Ranre", 1.82, 0.723684211, 3, 2, 5, 2, 2, 0, 1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new plantTraits("Robps", null, 1, 3, 8, 5, null, 0, 2, 0, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Rosar", 1.275, null, 2, 5, 6, null, 0, 0, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, null, null, null, null, null, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Rosca", null, 0, 3, 5, 5, 2, 0, 0, 3, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Rubca", null, 0, 5, 4, 6, 2, 2, 0, 3, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Rubfr", null, 0.444444444, 4, 6, 6, 2, 0, 2, 1, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Rubpe", null, null, 2, 5, 6, null, 0, 1, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Rumac", 1.5, 0.480769231, 2, 2, 5, 0, 0, 1, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Rumco", 1.42, 0.5, 2, 4, 5, 0, 0, 0, 2, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0);
                yield return new plantTraits("Rumcr", 2.93, 0.764705882, 3, 3, 6, 1, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Rumsa", 1.42, 0.75, 3, 4, 6, null, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Rusac", null, 0, 4, 4, 1, null, 0, 1, 0, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Samni", 89.23, 0.5, 2, 7, 6, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Scrno", 0.09, 0.9, 4, 3, 6, 1, 0, 2, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Soldu", null, 0.5, 4, 4, 6, 2, 0, 1, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Sonol", 0.4, 0.789473684, 6, 4, 6, 2, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Sordo", null, null, 2, 8, 5, null, 0, 0, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Sorto", 400, null, 2, 8, 5, null, 0, 0, 0, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Stasy", 1.55, 0.4, 3, 3, 6, 2, 0, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Steho", 3.11, 0, 3, 3, 4, 0, 2, 0, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Steme", 0.48, 0.802631579, 12, 2, 3, 0, 0, 0, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Symsp", null, null, 2, 5, 7, null, 0, 1, 1, 3, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, null, null, null, null, null, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Tamco", null, 0, 3, 5, 5, 2, 0, 1, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Tarsp", 0.61, 0.472222222, 8, 3, 3, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Taxba", null, null, 2, 8, 3, 2, 1, 1, 0, 0, 3, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new plantTraits("Teusc", 0.76, 0.5, 3, 3, 7, 2, 1, 2, 1, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Trire", null, 0.6, 7, 1, 6, 2, 2, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Ulemi", 5.9, null, 4, 5, 7, null, 0, 0, 0, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1);
                yield return new plantTraits("Ulmsp", 9, 0, 2, 8, 2, 2, 0, 1, 0, 1, 3, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new plantTraits("Urtdi", 0.19, 0.795918367, 5, 5, 6, 0, 0, 2, 0, 1, 3, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0);
                yield return new plantTraits("Verch", 0.22, 0.4, 3, 2, 4, 1, 0, 2, 2, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Vicsa", 39.44, 0.45, 3, 5, 5, 2, 0, 0, 3, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Vicse", 21.4, 0.111111111, 4, 4, 5, 2, 0, 2, 2, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new plantTraits("Vinmi", null, null, 2, 2, 3, null, 2, 0, 0, 4, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, null, null, null, null, null, null);
                yield return new plantTraits("Viohi", 3, 0.333333333, 2, 2, 4, 2, 0, 0, 2, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
                yield return new plantTraits("Viore", 4, 0.5, 2, 1, 4, null, 0, 0, 2, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0);
            }
        }
    }
}
