// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Interest Rate, GDP and Inflation
    /// </summary>

    public class Tbrate
    {
        public readonly double r;
        public readonly double y;
        public readonly double pi;

        public Tbrate(double r, double y, double pi)
        {
            this.r = r;
            this.y = y;
            this.pi = pi;
        }

        public static IEnumerable<Tbrate> Data
        {
            get
            {
                yield return new Tbrate(0.51, 11.53832, 0.5);
                yield return new Tbrate(0.51, 11.53832, 4.06);
                yield return new Tbrate(0.55, 11.56103, 5.5);
                yield return new Tbrate(0.623, 11.601046, 9.85);
                yield return new Tbrate(0.693, 11.619265, 14);
                yield return new Tbrate(0.75, 11.601156, 11.67);
                yield return new Tbrate(0.803, 11.5962, 8);
                yield return new Tbrate(0.913, 11.597634, 3.26);
                yield return new Tbrate(0.907, 11.648575, 3.39);
                yield return new Tbrate(1.013, 11.675044, -2.93);
                yield return new Tbrate(1.11, 11.688122, -2.58);
                yield return new Tbrate(1.233, 11.721824, -1.07);
                yield return new Tbrate(1.44, 11.719907, 0.08);
                yield return new Tbrate(1.597, 11.733474, 0.71);
                yield return new Tbrate(1.823, 11.728875, 2.01);
                yield return new Tbrate(1.903, 11.746637, 1.26);
                yield return new Tbrate(1.74, 11.703083, 0.98);
                yield return new Tbrate(1.583, 11.711186, 1.65);
                yield return new Tbrate(1.303, 11.725615, 0.81);
                yield return new Tbrate(1.237, 11.744672, -0.65);
                yield return new Tbrate(1.007, 11.773596, 0.99);
                yield return new Tbrate(1.277, 11.800627, -0.62);
                yield return new Tbrate(1.6, 11.825076, -0.8);
                yield return new Tbrate(2.33, 11.847997, -0.38);
                yield return new Tbrate(2.563, 11.875177, 1.46);
                yield return new Tbrate(2.767, 11.886033, 2.53);
                yield return new Tbrate(2.847, 11.893442, 5.3);
                yield return new Tbrate(3.433, 11.924426, 3.79);
                yield return new Tbrate(3.723, 11.919883, 3.18);
                yield return new Tbrate(3.763, 11.918177, 3.76);
                yield return new Tbrate(3.907, 11.925247, 1.58);
                yield return new Tbrate(3.717, 11.914998, 0.46);
                yield return new Tbrate(2.99, 11.914891, 5.29);
                yield return new Tbrate(1.66, 11.936466, 4.15);
                yield return new Tbrate(1.54, 11.949631, -1.18);
                yield return new Tbrate(2.98, 11.962624, 1.17);
                yield return new Tbrate(3.733, 11.963848, 1.8);
                yield return new Tbrate(4.883, 11.974544, 1.22);
                yield return new Tbrate(5.593, 11.985376, 0.4);
                yield return new Tbrate(5.01, 11.994759, 2.35);
                yield return new Tbrate(4.457, 12.014525, -0.44);
                yield return new Tbrate(3.047, 11.995105, 1.87);
                yield return new Tbrate(2.567, 12.010252, 0.86);
                yield return new Tbrate(3.227, 12.013555, 1.17);
                yield return new Tbrate(3.153, 12.005595, -0.04);
                yield return new Tbrate(3.09, 12.033123, 0.09);
                yield return new Tbrate(2.503, 12.050518, 0.27);
                yield return new Tbrate(2.59, 12.066765, 1.57);
                yield return new Tbrate(3.093, 12.094784, 1.3);
                yield return new Tbrate(3.64, 12.095901, 2.17);
                yield return new Tbrate(5.217, 12.111014, 1.64);
                yield return new Tbrate(4.1, 12.128759, 1.49);
                yield return new Tbrate(3.71, 12.135221, 2.27);
                yield return new Tbrate(3.38, 12.147511, 2.36);
                yield return new Tbrate(3.56, 12.15745, 2.66);
                yield return new Tbrate(3.64, 12.192156, 2.01);
                yield return new Tbrate(3.817, 12.210881, 0.61);
                yield return new Tbrate(3.657, 12.214973, 1.17);
                yield return new Tbrate(3.737, 12.229945, 1.52);
                yield return new Tbrate(3.76, 12.23536, 2.64);
                yield return new Tbrate(3.737, 12.265605, 1.04);
                yield return new Tbrate(3.817, 12.275319, 3.41);
                yield return new Tbrate(4.063, 12.289917, 2.05);
                yield return new Tbrate(4.253, 12.315411, 3.24);
                yield return new Tbrate(4.72, 12.338048, 4.92);
                yield return new Tbrate(5.083, 12.351557, 5.35);
                yield return new Tbrate(5.06, 12.354337, 1.6);
                yield return new Tbrate(5.13, 12.365535, 4.4);
                yield return new Tbrate(4.57, 12.363401, 3.57);
                yield return new Tbrate(4.147, 12.383281, 4.6);
                yield return new Tbrate(4.367, 12.387627, 4.76);
                yield return new Tbrate(5.263, 12.390708, 3.92);
                yield return new Tbrate(6.47, 12.40085, 5.43);
                yield return new Tbrate(6.873, 12.426027, 4.51);
                yield return new Tbrate(5.897, 12.44334, 2.83);
                yield return new Tbrate(5.74, 12.462605, 3.64);
                yield return new Tbrate(6.43, 12.469882, 3.4);
                yield return new Tbrate(6.813, 12.475306, 6.54);
                yield return new Tbrate(7.62, 12.488601, 3.06);
                yield return new Tbrate(7.723, 12.508279, 4.33);
                yield return new Tbrate(7.607, 12.50671, 5.22);
                yield return new Tbrate(6.407, 12.501634, 2.4);
                yield return new Tbrate(5.63, 12.518867, 0.37);
                yield return new Tbrate(4.827, 12.517667, 1.53);
                yield return new Tbrate(4.133, 12.526546, 1.51);
                yield return new Tbrate(3.087, 12.557096, 4.43);
                yield return new Tbrate(3.797, 12.58663, 3.48);
                yield return new Tbrate(3.45, 12.597141, 4.03);
                yield return new Tbrate(3.427, 12.593944, 3.7);
                yield return new Tbrate(3.637, 12.620867, 3.99);
                yield return new Tbrate(3.507, 12.624678, 5.6);
                yield return new Tbrate(3.613, 12.651527, 3.92);
                yield return new Tbrate(4, 12.681971, 5.37);
                yield return new Tbrate(5.07, 12.690977, 7.98);
                yield return new Tbrate(6.03, 12.694358, 9.48);
                yield return new Tbrate(6.45, 12.721265, 7.41);
                yield return new Tbrate(6.223, 12.731168, 9.53);
                yield return new Tbrate(8.017, 12.736936, 12.1);
                yield return new Tbrate(9.013, 12.742964, 11.03);
                yield return new Tbrate(7.883, 12.75014, 13.76);
                yield return new Tbrate(6.427, 12.749083, 8.86);
                yield return new Tbrate(6.8, 12.758428, 7.75);
                yield return new Tbrate(7.793, 12.773192, 9.88);
                yield return new Tbrate(8.443, 12.783001, 7.14);
                yield return new Tbrate(8.777, 12.805601, 7.64);
                yield return new Tbrate(8.967, 12.828153, 5.57);
                yield return new Tbrate(9.037, 12.835012, 5.6);
                yield return new Tbrate(8.787, 12.834191, 5.54);
                yield return new Tbrate(7.787, 12.85066, 8.13);
                yield return new Tbrate(7.293, 12.854411, 8.63);
                yield return new Tbrate(7.123, 12.860801, 7.87);
                yield return new Tbrate(7.207, 12.87915, 7.01);
                yield return new Tbrate(7.333, 12.888765, 7.17);
                yield return new Tbrate(8.183, 12.903222, 5.58);
                yield return new Tbrate(8.74, 12.909992, 8.33);
                yield return new Tbrate(10.08, 12.921891, 9.15);
                yield return new Tbrate(10.83, 12.933438, 7.48);
                yield return new Tbrate(10.833, 12.939123, 8.65);
                yield return new Tbrate(11.267, 12.949133, 8.03);
                yield return new Tbrate(13.367, 12.954257, 8.8);
                yield return new Tbrate(13.817, 12.956979, 9.58);
                yield return new Tbrate(13.01, 12.955487, 10.12);
                yield return new Tbrate(10.313, 12.950958, 10.35);
                yield return new Tbrate(13.583, 12.971475, 11.32);
                yield return new Tbrate(16.76, 12.991562, 11.95);
                yield return new Tbrate(18.12, 13.00421, 8.74);
                yield return new Tbrate(19.94, 12.995257, 11.45);
                yield return new Tbrate(16.29, 12.988174, 9.24);
                yield return new Tbrate(14.633, 12.976607, 9.72);
                yield return new Tbrate(15.42, 12.964268, 10.28);
                yield return new Tbrate(14.42, 12.957715, 9.29);
                yield return new Tbrate(10.837, 12.949713, 8.11);
                yield return new Tbrate(9.38, 12.966551, 3.27);
                yield return new Tbrate(9.193, 12.988805, 5.23);
                yield return new Tbrate(9.283, 13.004741, 5.26);
                yield return new Tbrate(9.437, 13.012388, 5.22);
                yield return new Tbrate(9.943, 13.028747, 3.7);
                yield return new Tbrate(11.19, 13.051537, 2.12);
                yield return new Tbrate(12.367, 13.062749, 2.7);
                yield return new Tbrate(10.89, 13.074173, 4);
                yield return new Tbrate(10.39, 13.086662, 4.68);
                yield return new Tbrate(9.61, 13.090096, 3.3);
                yield return new Tbrate(9.033, 13.102291, 3.19);
                yield return new Tbrate(8.797, 13.124553, 3.47);
                yield return new Tbrate(10.69, 13.130252, 5.25);
                yield return new Tbrate(8.69, 13.132456, 2.38);
                yield return new Tbrate(8.313, 13.137654, 3.24);
                yield return new Tbrate(8.27, 13.13415, 4.97);
                yield return new Tbrate(7.343, 13.154164, 4.36);
                yield return new Tbrate(7.96, 13.163267, 3.71);
                yield return new Tbrate(8.9, 13.183285, 2.8);
                yield return new Tbrate(8.473, 13.196506, 4.25);
                yield return new Tbrate(8.39, 13.209201, 2.68);
                yield return new Tbrate(8.947, 13.22307, 4.45);
                yield return new Tbrate(9.717, 13.226298, 4.16);
                yield return new Tbrate(10.61, 13.233425, 4.97);
                yield return new Tbrate(11.523, 13.243986, 3.04);
                yield return new Tbrate(12.187, 13.245388, 7.06);
                yield return new Tbrate(12.14, 13.248968, 5.28);
                yield return new Tbrate(12.213, 13.250475, 2.57);
                yield return new Tbrate(12.73, 13.253932, 4.13);
                yield return new Tbrate(13.54, 13.249588, 3.69);
                yield return new Tbrate(12.907, 13.244546, 4.77);
                yield return new Tbrate(12.043, 13.231211, 5.35);
                yield return new Tbrate(10.157, 13.218808, 9.54);
                yield return new Tbrate(9.001, 13.22699, 1.65);
                yield return new Tbrate(8.562, 13.22989, 2.41);
                yield return new Tbrate(7.601, 13.231533, -2);
                yield return new Tbrate(7.218, 13.231957, 1.78);
                yield return new Tbrate(6.304, 13.234377, 1.95);
                yield return new Tbrate(5.251, 13.235035, 2.29);
                yield return new Tbrate(7.262, 13.236427, 2.34);
                yield return new Tbrate(6.051, 13.246116, 0.83);
                yield return new Tbrate(4.98, 13.254016, 1.98);
                yield return new Tbrate(4.468, 13.258019, 1.46);
                yield return new Tbrate(4.208, 13.267364, 1.9);
                yield return new Tbrate(3.946, 13.277958, -1.45);
                yield return new Tbrate(6.154, 13.288935, 0.52);
                yield return new Tbrate(5.666, 13.302823, 1.48);
                yield return new Tbrate(5.901, 13.315091, 1.69);
                yield return new Tbrate(7.884, 13.319127, 1.37);
                yield return new Tbrate(7.454, 13.31662, 2.51);
                yield return new Tbrate(6.54, 13.319567, 1.69);
                yield return new Tbrate(6.049, 13.321889, 0.05);
                yield return new Tbrate(5.215, 13.325324, 0.46);
                yield return new Tbrate(4.777, 13.328877, 2.22);
                yield return new Tbrate(4.216, 13.337101, 1.4);
                yield return new Tbrate(3.028, 13.344239, 1.81);
            }
        }
    }
}
