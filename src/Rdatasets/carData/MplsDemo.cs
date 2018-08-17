// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Minneapolis Demographic Data 2015, by Neighborhood
    /// </summary>

    public class MplsDemo
    {
        public readonly string neighborhood;
        public readonly int population;
        public readonly double white;
        public readonly double black;
        public readonly double foreignBorn;
        public readonly int hhIncome;
        public readonly double poverty;
        public readonly double collegeGrad;

        public MplsDemo(string neighborhood, int population, double white, double black, double foreignBorn, int hhIncome, double poverty, double collegeGrad)
        {
            this.neighborhood = neighborhood;
            this.population = population;
            this.white = white;
            this.black = black;
            this.foreignBorn = foreignBorn;
            this.hhIncome = hhIncome;
            this.poverty = poverty;
            this.collegeGrad = collegeGrad;
        }

        public static IEnumerable<MplsDemo> Data
        {
            get
            {
                yield return new MplsDemo("Cedar Riverside", 8247, 0.353, 0.464, 0.408, 18892, 0.06, 0.258);
                yield return new MplsDemo("Phillips West", 5184, 0.199, 0.538, 0.318, 18404, 0.042, 0.211);
                yield return new MplsDemo("Downtown West", 7141, 0.561, 0.211, 0.203, 67086, 0.057, 0.551);
                yield return new MplsDemo("Downtown East", 1674, 0.543, 0.221, 0.221, 70669, 0.071, 0.577);
                yield return new MplsDemo("Shingle Creek", 3249, 0.407, 0.259, 0.14, 59414, 0.11, 0.247);
                yield return new MplsDemo("Ventura Village", 6150, 0.214, 0.424, 0.329, 17469, 0.048, 0.173);
                yield return new MplsDemo("Sumner - Glenwood", 1676, 0.087, 0.656, 0.292, 18854, 0.074, 0.165);
                yield return new MplsDemo("Lind - Bohanon", 5420, 0.417, 0.251, 0.172, 43438, 0.089, 0.196);
                yield return new MplsDemo("Victory", 4525, 0.622, 0.25, 0.055, 57148, 0.066, 0.345);
                yield return new MplsDemo("Webber - Camden", 5109, 0.394, 0.383, 0.11, 37030, 0.053, 0.203);
                yield return new MplsDemo("Bottineau", 1573, 0.615, 0.217, 0.17, 50900, 0.085, 0.328);
                yield return new MplsDemo("Howe", 6816, 0.789, 0.095, 0.051, 63492, 0.037, 0.496);
                yield return new MplsDemo("Bryant", 3178, 0.305, 0.248, 0.261, 50964, 0.114, 0.254);
                yield return new MplsDemo("Hiawatha", 5780, 0.836, 0.046, 0.056, 65925, 0.045, 0.537);
                yield return new MplsDemo("Windom", 4876, 0.718, 0.091, 0.107, 78095, 0.05, 0.543);
                yield return new MplsDemo("Ericsson", 3302, 0.881, 0.03, 0.048, 78750, 0.06, 0.59);
                yield return new MplsDemo("Field", 2498, 0.748, 0.133, 0.064, 100598, 0.044, 0.655);
                yield return new MplsDemo("Wenonah", 4423, 0.604, 0.122, 0.136, 54321, 0.065, 0.427);
                yield return new MplsDemo("Page", 1875, 0.881, 0.059, 0.039, 114750, 0.043, 0.749);
                yield return new MplsDemo("Steven's Square - Loring Heights", 3897, 0.624, 0.196, 0.133, 24783, 0.053, 0.512);
                yield return new MplsDemo("Minnehaha", 4208, 0.788, 0.067, 0.073, 64145, 0.067, 0.5);
                yield return new MplsDemo("Prospect Park - East River Road", 7705, 0.707, 0.066, 0.168, 36186, 0.039, 0.698);
                yield return new MplsDemo("Keewaydin", 3292, 0.817, 0.049, 0.101, 83116, 0.087, 0.54);
                yield return new MplsDemo("University of Minnesota", 5678, 0.669, 0.099, 0.183, 20492, 0.049, 0.461);
                yield return new MplsDemo("Jordan", 8177, 0.183, 0.453, 0.155, 36156, 0.051, 0.142);
                yield return new MplsDemo("Fulton", 6138, 0.902, 0.029, 0.04, 118465, 0.032, 0.776);
                yield return new MplsDemo("Hawthorne", 4609, 0.186, 0.456, 0.167, 21936, 0.062, 0.151);
                yield return new MplsDemo("Folwell", 5023, 0.285, 0.403, 0.116, 40442, 0.103, 0.181);
                yield return new MplsDemo("Willard - Hay", 9074, 0.215, 0.516, 0.141, 44733, 0.048, 0.269);
                yield return new MplsDemo("Lynnhurst", 5934, 0.889, 0.024, 0.045, 118202, 0.031, 0.763);
                yield return new MplsDemo("Bancroft", 3542, 0.623, 0.14, 0.132, 57456, 0.053, 0.443);
                yield return new MplsDemo("Harrison", 3443, 0.31, 0.427, 0.163, 32013, 0.115, 0.25);
                yield return new MplsDemo("Holland", 5016, 0.472, 0.193, 0.262, 45343, 0.057, 0.233);
                yield return new MplsDemo("Loring Park", 8262, 0.697, 0.135, 0.172, 37438, 0.06, 0.623);
                yield return new MplsDemo("Linden Hills", 8097, 0.845, 0.054, 0.089, 93909, 0.051, 0.718);
                yield return new MplsDemo("Diamond Lake", 5620, 0.754, 0.063, 0.092, 73668, 0.05, 0.531);
                yield return new MplsDemo("Standish", 6815, 0.703, 0.061, 0.089, 63693, 0.048, 0.448);
                yield return new MplsDemo("Cooper", 3744, 0.817, 0.03, 0.092, 72774, 0.069, 0.614);
                yield return new MplsDemo("Tangletown", 4436, 0.822, 0.063, 0.054, 100158, 0.051, 0.68);
                yield return new MplsDemo("North Loop", 4681, 0.747, 0.15, 0.151, 104457, 0.079, 0.745);
                yield return new MplsDemo("Hale", 3150, 0.896, 0.031, 0.029, 94280, 0.064, 0.672);
                yield return new MplsDemo("Seward", 7436, 0.536, 0.355, 0.299, 32554, 0.048, 0.451);
                yield return new MplsDemo("Longfellow", 4704, 0.63, 0.151, 0.097, 49378, 0.057, 0.39);
                yield return new MplsDemo("East Phillips", 4661, 0.153, 0.28, 0.385, 35224, 0.104, 0.216);
                yield return new MplsDemo("Lowry Hill East", 6357, 0.76, 0.105, 0.145, 49868, 0.066, 0.569);
                yield return new MplsDemo("ECCO", 2608, 0.88, 0.004, 0.061, 72568, 0.085, 0.774);
                yield return new MplsDemo("CARAG", 5737, 0.899, 0.011, 0.05, 50696, 0.049, 0.603);
                yield return new MplsDemo("Cleveland", 2895, 0.515, 0.296, 0.047, 49744, 0.09, 0.372);
                yield return new MplsDemo("Audubon Park", 5073, 0.769, 0.038, 0.119, 69056, 0.053, 0.44);
                yield return new MplsDemo("Regina", 2344, 0.58, 0.225, 0.096, 83077, 0.083, 0.537);
                yield return new MplsDemo("East Harriet", 3648, 0.879, 0.014, 0.053, 83266, 0.042, 0.654);
                yield return new MplsDemo("Northrop", 4511, 0.822, 0.088, 0.047, 75428, 0.049, 0.608);
                yield return new MplsDemo("Sheridan", 2874, 0.669, 0.153, 0.177, 43524, 0.065, 0.332);
                yield return new MplsDemo("Logan Park", 2139, 0.691, 0.064, 0.15, 50987, 0.1, 0.378);
                yield return new MplsDemo("Windom Park", 5548, 0.799, 0.064, 0.098, 60922, 0.058, 0.499);
                yield return new MplsDemo("King Field", 7686, 0.81, 0.044, 0.069, 74606, 0.037, 0.64);
                yield return new MplsDemo("Morris Park", 2914, 0.769, 0.1, 0.042, 62045, 0.074, 0.37);
                yield return new MplsDemo("Central", 8618, 0.249, 0.222, 0.326, 42856, 0.053, 0.264);
                yield return new MplsDemo("Mid - City Industrial", 240, 0.631, 0.158, 0.189, 38875, 0.067, 0.568);
                yield return new MplsDemo("Midtown Phillips", 4949, 0.246, 0.297, 0.36, 46055, 0.135, 0.236);
                yield return new MplsDemo("West Calhoun", 1976, 0.854, 0.033, 0.09, 72500, 0.075, 0.683);
                yield return new MplsDemo("Bryn - Mawr", 2791, 0.83, 0.055, 0.053, 101250, 0.05, 0.746);
                yield return new MplsDemo("Powderhorn Park", 9175, 0.461, 0.131, 0.206, 50432, 0.043, 0.374);
                yield return new MplsDemo("Northeast Park", 670, 0.611, 0.122, 0.151, 50208, 0.089, 0.394);
                yield return new MplsDemo("Corcoran", 4339, 0.497, 0.136, 0.151, 54722, 0.071, 0.329);
                yield return new MplsDemo("St. Anthony West", 2511, 0.763, 0.057, 0.121, 67191, 0.057, 0.582);
                yield return new MplsDemo("St. Anthony East", 2142, 0.589, 0.193, 0.197, 30245, 0.076, 0.356);
                yield return new MplsDemo("Kenny", 3548, 0.852, 0.008, 0.077, 103903, 0.048, 0.628);
                yield return new MplsDemo("Armatage", 4864, 0.827, 0.018, 0.085, 99818, 0.05, 0.622);
                yield return new MplsDemo("Beltrami", 1243, 0.611, 0.122, 0.151, 50208, 0.089, 0.394);
                yield return new MplsDemo("Cedar - Isles - Dean", 2984, 0.881, 0.02, 0.086, 118750, 0.089, 0.758);
                yield return new MplsDemo("Kenwood", 1512, 0.881, 0.02, 0.086, 118750, 0.089, 0.758);
                yield return new MplsDemo("Lowry Hill", 3860, 0.856, 0.03, 0.081, 75645, 0.08, 0.837);
                yield return new MplsDemo("East Isles", 3261, 0.899, 0.005, 0.087, 82145, 0.071, 0.79);
                yield return new MplsDemo("Elliot Park", 6749, 0.571, 0.315, 0.196, 31531, 0.047, 0.354);
                yield return new MplsDemo("Waite Park", 5362, 0.855, 0.017, 0.087, 73477, 0.055, 0.463);
                yield return new MplsDemo("Nicollet Island - East Bank", 1393, 0.782, 0.031, 0.138, 83520, 0.076, 0.734);
                yield return new MplsDemo("Marcy Holmes", 10496, 0.735, 0.058, 0.174, 27104, 0.042, 0.587);
                yield return new MplsDemo("Como", 16022, 0.791, 0.075, 0.076, 67600, 0.037, 0.549);
                yield return new MplsDemo("McKinley", 3198, 0.22, 0.416, 0.161, 42556, 0.101, 0.122);
                yield return new MplsDemo("Whittier", 14604, 0.549, 0.187, 0.215, 35855, 0.038, 0.399);
                yield return new MplsDemo("Lyndale", 7441, 0.515, 0.226, 0.285, 38441, 0.083, 0.39);
                yield return new MplsDemo("Columbia Park", 1699, 0.751, 0.067, 0.13, 66545, 0.058, 0.418);
                yield return new MplsDemo("Marshall Terrace", 1587, 0.687, 0.122, 0.118, 43913, 0.063, 0.409);
            }
        }
    }
}
