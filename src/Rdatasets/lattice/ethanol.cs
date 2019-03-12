// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Engine exhaust fumes from burning ethanol
    /// </summary>

    public class ethanol
    {
        public readonly int κ;
        public readonly double NOx;
        public readonly double C;
        public readonly double E;

        public ethanol(int κ, double NOx, double C, double E)
        {
            this.κ = κ;
            this.NOx = NOx;
            this.C = C;
            this.E = E;
        }

        public static IEnumerable<ethanol> Data
        {
            get
            {
                yield return new ethanol(1, 3.741, 12, 0.907);
                yield return new ethanol(2, 2.295, 12, 0.761);
                yield return new ethanol(3, 1.498, 12, 1.108);
                yield return new ethanol(4, 2.881, 12, 1.016);
                yield return new ethanol(5, 0.76, 12, 1.189);
                yield return new ethanol(6, 3.12, 9, 1.001);
                yield return new ethanol(7, 0.638, 9, 1.231);
                yield return new ethanol(8, 1.17, 9, 1.123);
                yield return new ethanol(9, 2.358, 12, 1.042);
                yield return new ethanol(10, 0.606, 12, 1.215);
                yield return new ethanol(11, 3.669, 12, 0.93);
                yield return new ethanol(12, 1, 12, 1.152);
                yield return new ethanol(13, 0.981, 15, 1.138);
                yield return new ethanol(14, 1.192, 18, 0.601);
                yield return new ethanol(15, 0.926, 7.5, 0.696);
                yield return new ethanol(16, 1.59, 12, 0.686);
                yield return new ethanol(17, 1.806, 12, 1.072);
                yield return new ethanol(18, 1.962, 15, 1.074);
                yield return new ethanol(19, 4.028, 15, 0.934);
                yield return new ethanol(20, 3.148, 9, 0.808);
                yield return new ethanol(21, 1.836, 9, 1.071);
                yield return new ethanol(22, 2.845, 7.5, 1.009);
                yield return new ethanol(23, 1.013, 7.5, 1.142);
                yield return new ethanol(24, 0.414, 18, 1.229);
                yield return new ethanol(25, 0.812, 18, 1.175);
                yield return new ethanol(26, 0.374, 15, 0.568);
                yield return new ethanol(27, 3.623, 15, 0.977);
                yield return new ethanol(28, 1.869, 7.5, 0.767);
                yield return new ethanol(29, 2.836, 7.5, 1.006);
                yield return new ethanol(30, 3.567, 9, 0.893);
                yield return new ethanol(31, 0.866, 15, 1.152);
                yield return new ethanol(32, 1.369, 15, 0.693);
                yield return new ethanol(33, 0.542, 15, 1.232);
                yield return new ethanol(34, 2.739, 15, 1.036);
                yield return new ethanol(35, 1.2, 15, 1.125);
                yield return new ethanol(36, 1.719, 9, 1.081);
                yield return new ethanol(37, 3.423, 9, 0.868);
                yield return new ethanol(38, 1.634, 7.5, 0.762);
                yield return new ethanol(39, 1.021, 7.5, 1.144);
                yield return new ethanol(40, 2.157, 7.5, 1.045);
                yield return new ethanol(41, 3.361, 18, 0.797);
                yield return new ethanol(42, 1.39, 18, 1.115);
                yield return new ethanol(43, 1.947, 18, 1.07);
                yield return new ethanol(44, 0.962, 18, 1.219);
                yield return new ethanol(45, 0.571, 9, 0.637);
                yield return new ethanol(46, 2.219, 9, 0.733);
                yield return new ethanol(47, 1.419, 9, 0.715);
                yield return new ethanol(48, 3.519, 9, 0.872);
                yield return new ethanol(49, 1.732, 7.5, 0.765);
                yield return new ethanol(50, 3.206, 7.5, 0.878);
                yield return new ethanol(51, 2.471, 7.5, 0.811);
                yield return new ethanol(52, 1.777, 15, 0.676);
                yield return new ethanol(53, 2.571, 18, 1.045);
                yield return new ethanol(54, 3.952, 18, 0.968);
                yield return new ethanol(55, 3.931, 15, 0.846);
                yield return new ethanol(56, 1.587, 15, 0.684);
                yield return new ethanol(57, 1.397, 7.5, 0.729);
                yield return new ethanol(58, 3.536, 7.5, 0.911);
                yield return new ethanol(59, 2.202, 7.5, 0.808);
                yield return new ethanol(60, 0.756, 7.5, 1.168);
                yield return new ethanol(61, 1.62, 7.5, 0.749);
                yield return new ethanol(62, 3.656, 7.5, 0.892);
                yield return new ethanol(63, 2.964, 7.5, 1.002);
                yield return new ethanol(64, 3.76, 18, 0.812);
                yield return new ethanol(65, 0.672, 18, 1.23);
                yield return new ethanol(66, 3.677, 18, 0.804);
                yield return new ethanol(67, 3.517, 12, 0.813);
                yield return new ethanol(68, 3.29, 12, 1.002);
                yield return new ethanol(69, 1.139, 9, 0.696);
                yield return new ethanol(70, 0.727, 9, 1.199);
                yield return new ethanol(71, 2.581, 9, 1.03);
                yield return new ethanol(72, 0.923, 15, 0.602);
                yield return new ethanol(73, 1.527, 15, 0.694);
                yield return new ethanol(74, 3.388, 15, 0.816);
                yield return new ethanol(75, 2.085, 15, 1.037);
                yield return new ethanol(76, 0.966, 15, 1.181);
                yield return new ethanol(77, 3.488, 7.5, 0.899);
                yield return new ethanol(78, 0.754, 7.5, 1.227);
                yield return new ethanol(79, 0.797, 9, 1.18);
                yield return new ethanol(80, 2.064, 7.5, 0.795);
                yield return new ethanol(81, 3.732, 18, 0.99);
                yield return new ethanol(82, 0.586, 18, 1.201);
                yield return new ethanol(83, 0.561, 7.5, 0.629);
                yield return new ethanol(84, 0.563, 9, 0.608);
                yield return new ethanol(85, 0.678, 12, 0.584);
                yield return new ethanol(86, 0.37, 15, 0.562);
                yield return new ethanol(87, 0.53, 18, 0.535);
                yield return new ethanol(88, 1.9, 18, 0.655);
            }
        }
    }
}
