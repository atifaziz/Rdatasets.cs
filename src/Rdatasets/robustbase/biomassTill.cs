// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Biomass Tillage Data
    /// </summary>

    public class biomassTill
    {
        public readonly int κ;
        public readonly string Tillage;
        public readonly double DVS;
        public readonly double Biomass;
        public readonly double Biom_2;

        public biomassTill(int κ, string Tillage, double DVS, double Biomass, double Biom_2)
        {
            this.κ = κ;
            this.Tillage = Tillage;
            this.DVS = DVS;
            this.Biomass = Biomass;
            this.Biom_2 = Biom_2;
        }

        public static IEnumerable<biomassTill> Data
        {
            get
            {
                yield return new biomassTill(1, "CA-", 0.490388663, 0.541232722, 108.2465444);
                yield return new biomassTill(2, "CA-", 0.490388663, 1.309001308, 261.8002616);
                yield return new biomassTill(3, "CA-", 0.490388663, 7.030325777, 7.030325777);
                yield return new biomassTill(4, "CA-", 0.490388663, 2.030325782, 2.030325782);
                yield return new biomassTill(5, "CA-", 0.748889201, 5.910564821, 5.910564821);
                yield return new biomassTill(6, "CA-", 0.748889201, 68.21821819, 68.21821819);
                yield return new biomassTill(7, "CA-", 0.748889201, 26.64710167, 26.64710167);
                yield return new biomassTill(8, "CA-", 1, 50.63560902, 50.63560902);
                yield return new biomassTill(9, "CA-", 1, 37.7156002, 37.7156002);
                yield return new biomassTill(10, "CA-", 1, 116.087252, 116.087252);
                yield return new biomassTill(11, "CA-", 1, 52.87128042, 52.87128042);
                yield return new biomassTill(12, "CA-", 1.388068561, 48.2025909, 48.2025909);
                yield return new biomassTill(13, "CA-", 1.388068561, 100.7209132, 100.7209132);
                yield return new biomassTill(14, "CA-", 1.388068561, 158.3894974, 158.3894974);
                yield return new biomassTill(15, "CA-", 1.388068561, 168.0453182, 168.0453182);
                yield return new biomassTill(16, "CA-", 2, 103.7269983, 103.7269983);
                yield return new biomassTill(17, "CA-", 2, 284.4575343, 284.4575343);
                yield return new biomassTill(18, "CA-", 2, 431.9106036, 431.9106036);
                yield return new biomassTill(19, "CA-", 2, 152.5598327, 152.5598327);
                yield return new biomassTill(20, "CA+", 0.490388663, 1.007136946, 1.007136946);
                yield return new biomassTill(21, "CA+", 0.490388663, 0.908506547, 0.908506547);
                yield return new biomassTill(22, "CA+", 0.490388663, 1.560349414, 1.560349414);
                yield return new biomassTill(23, "CA+", 0.490388663, 11.22219442, 11.22219442);
                yield return new biomassTill(24, "CA+", 0.748889201, 12.08564335, 12.08564335);
                yield return new biomassTill(25, "CA+", 0.748889201, 17.34921198, 17.34921198);
                yield return new biomassTill(26, "CA+", 0.748889201, 11.27468616, 11.27468616);
                yield return new biomassTill(27, "CA+", 0.748889201, 63.9362974, 63.9362974);
                yield return new biomassTill(28, "CA+", 1, 74.42755264, 74.42755264);
                yield return new biomassTill(29, "CA+", 1, 48.94600488, 48.94600488);
                yield return new biomassTill(30, "CA+", 1, 101.5051511, 101.5051511);
                yield return new biomassTill(31, "CA+", 1, 147.7895951, 147.7895951);
                yield return new biomassTill(32, "CA+", 1.388068561, 39.62375842, 39.62375842);
                yield return new biomassTill(33, "CA+", 1.388068561, 85.26909271, 85.26909271);
                yield return new biomassTill(34, "CA+", 1.388068561, 174.621236, 174.621236);
                yield return new biomassTill(35, "CA+", 1.388068561, 323.9773106, 323.9773106);
                yield return new biomassTill(36, "CA+", 2, 231.4165129, 231.4165129);
                yield return new biomassTill(37, "CA+", 2, 200.848896, 200.848896);
                yield return new biomassTill(38, "CA+", 2, 579.6046045, 5.796046045);
                yield return new biomassTill(39, "CT", 0.490388663, 3.62862863, 3.62862863);
                yield return new biomassTill(40, "CT", 0.490388663, 16.14279114, 16.14279114);
                yield return new biomassTill(41, "CT", 0.490388663, 3.47331343, 3.47331343);
                yield return new biomassTill(42, "CT", 0.490388663, 1.965557791, 1.965557791);
                yield return new biomassTill(43, "CT", 0.748889201, 74.80437429, 74.80437429);
                yield return new biomassTill(44, "CT", 0.748889201, 61.80823679, 61.80823679);
                yield return new biomassTill(45, "CT", 0.748889201, 21.84160905, 21.84160905);
                yield return new biomassTill(46, "CT", 0.748889201, 31.41491005, 31.41491005);
                yield return new biomassTill(47, "CT", 1, 187.806893, 187.806893);
                yield return new biomassTill(48, "CT", 1, 114.2407517, 114.2407517);
                yield return new biomassTill(49, "CT", 1, 54.87900692, 54.87900692);
                yield return new biomassTill(50, "CT", 1, 42.79522241, 42.79522241);
                yield return new biomassTill(51, "CT", 1.388068561, 246.4736243, 246.4736243);
                yield return new biomassTill(52, "CT", 1.388068561, 345.5412829, 345.5412829);
                yield return new biomassTill(53, "CT", 1.388068561, 128.1885083, 128.1885083);
                yield return new biomassTill(54, "CT", 1.388068561, 270.4160471, 270.4160471);
                yield return new biomassTill(55, "CT", 2, 513.6421369, 513.6421369);
                yield return new biomassTill(56, "CT", 2, 361.9505493, 361.9505493);
                yield return new biomassTill(57, "CT", 2, 295.0319506, 295.0319506);
                yield return new biomassTill(58, "CT", 2, 317.4047834, 317.4047834);
            }
        }
    }
}
