// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival from Malignant Melanoma
    /// </summary>

    public class Melanoma
    {
        public readonly int time;
        public readonly int status;
        public readonly int sex;
        public readonly int age;
        public readonly int year;
        public readonly double thickness;
        public readonly int ulcer;

        public Melanoma(int time, int status, int sex, int age, int year, double thickness, int ulcer)
        {
            this.time = time;
            this.status = status;
            this.sex = sex;
            this.age = age;
            this.year = year;
            this.thickness = thickness;
            this.ulcer = ulcer;
        }

        public static IEnumerable<Melanoma> Data
        {
            get
            {
                yield return new Melanoma(10, 3, 1, 76, 1972, 6.76, 1);
                yield return new Melanoma(30, 3, 1, 56, 1968, 0.65, 0);
                yield return new Melanoma(35, 2, 1, 41, 1977, 1.34, 0);
                yield return new Melanoma(99, 3, 0, 71, 1968, 2.9, 0);
                yield return new Melanoma(185, 1, 1, 52, 1965, 12.08, 1);
                yield return new Melanoma(204, 1, 1, 28, 1971, 4.84, 1);
                yield return new Melanoma(210, 1, 1, 77, 1972, 5.16, 1);
                yield return new Melanoma(232, 3, 0, 60, 1974, 3.22, 1);
                yield return new Melanoma(232, 1, 1, 49, 1968, 12.88, 1);
                yield return new Melanoma(279, 1, 0, 68, 1971, 7.41, 1);
                yield return new Melanoma(295, 1, 0, 53, 1969, 4.19, 1);
                yield return new Melanoma(355, 3, 0, 64, 1972, 0.16, 1);
                yield return new Melanoma(386, 1, 0, 68, 1965, 3.87, 1);
                yield return new Melanoma(426, 1, 1, 63, 1970, 4.84, 1);
                yield return new Melanoma(469, 1, 0, 14, 1969, 2.42, 1);
                yield return new Melanoma(493, 3, 1, 72, 1971, 12.56, 1);
                yield return new Melanoma(529, 1, 1, 46, 1971, 5.8, 1);
                yield return new Melanoma(621, 1, 1, 72, 1972, 7.06, 1);
                yield return new Melanoma(629, 1, 1, 95, 1968, 5.48, 1);
                yield return new Melanoma(659, 1, 1, 54, 1972, 7.73, 1);
                yield return new Melanoma(667, 1, 0, 89, 1968, 13.85, 1);
                yield return new Melanoma(718, 1, 1, 25, 1967, 2.34, 1);
                yield return new Melanoma(752, 1, 1, 37, 1973, 4.19, 1);
                yield return new Melanoma(779, 1, 1, 43, 1967, 4.04, 1);
                yield return new Melanoma(793, 1, 1, 68, 1970, 4.84, 1);
                yield return new Melanoma(817, 1, 0, 67, 1966, 0.32, 0);
                yield return new Melanoma(826, 3, 0, 86, 1965, 8.54, 1);
                yield return new Melanoma(833, 1, 0, 56, 1971, 2.58, 1);
                yield return new Melanoma(858, 1, 0, 16, 1967, 3.56, 0);
                yield return new Melanoma(869, 1, 0, 42, 1965, 3.54, 0);
                yield return new Melanoma(872, 1, 0, 65, 1968, 0.97, 0);
                yield return new Melanoma(967, 1, 1, 52, 1970, 4.83, 1);
                yield return new Melanoma(977, 1, 1, 58, 1967, 1.62, 1);
                yield return new Melanoma(982, 1, 0, 60, 1970, 6.44, 1);
                yield return new Melanoma(1041, 1, 1, 68, 1967, 14.66, 0);
                yield return new Melanoma(1055, 1, 0, 75, 1967, 2.58, 1);
                yield return new Melanoma(1062, 1, 1, 19, 1966, 3.87, 1);
                yield return new Melanoma(1075, 1, 1, 66, 1971, 3.54, 1);
                yield return new Melanoma(1156, 1, 0, 56, 1970, 1.34, 1);
                yield return new Melanoma(1228, 1, 1, 46, 1973, 2.24, 1);
                yield return new Melanoma(1252, 1, 0, 58, 1971, 3.87, 1);
                yield return new Melanoma(1271, 1, 0, 74, 1971, 3.54, 1);
                yield return new Melanoma(1312, 1, 0, 65, 1970, 17.42, 1);
                yield return new Melanoma(1427, 3, 1, 64, 1972, 1.29, 0);
                yield return new Melanoma(1435, 1, 1, 27, 1969, 3.22, 0);
                yield return new Melanoma(1499, 2, 1, 73, 1973, 1.29, 0);
                yield return new Melanoma(1506, 1, 1, 56, 1970, 4.51, 1);
                yield return new Melanoma(1508, 2, 1, 63, 1973, 8.38, 1);
                yield return new Melanoma(1510, 2, 0, 69, 1973, 1.94, 0);
                yield return new Melanoma(1512, 2, 0, 77, 1973, 0.16, 0);
                yield return new Melanoma(1516, 1, 1, 80, 1968, 2.58, 1);
                yield return new Melanoma(1525, 3, 0, 76, 1970, 1.29, 1);
                yield return new Melanoma(1542, 2, 0, 65, 1973, 0.16, 0);
                yield return new Melanoma(1548, 1, 0, 61, 1972, 1.62, 0);
                yield return new Melanoma(1557, 2, 0, 26, 1973, 1.29, 0);
                yield return new Melanoma(1560, 1, 0, 57, 1973, 2.1, 0);
                yield return new Melanoma(1563, 2, 0, 45, 1973, 0.32, 0);
                yield return new Melanoma(1584, 1, 1, 31, 1970, 0.81, 0);
                yield return new Melanoma(1605, 2, 0, 36, 1973, 1.13, 0);
                yield return new Melanoma(1621, 1, 0, 46, 1972, 5.16, 1);
                yield return new Melanoma(1627, 2, 0, 43, 1973, 1.62, 0);
                yield return new Melanoma(1634, 2, 0, 68, 1973, 1.37, 0);
                yield return new Melanoma(1641, 2, 1, 57, 1973, 0.24, 0);
                yield return new Melanoma(1641, 2, 0, 57, 1973, 0.81, 0);
                yield return new Melanoma(1648, 2, 0, 55, 1973, 1.29, 0);
                yield return new Melanoma(1652, 2, 0, 58, 1973, 1.29, 0);
                yield return new Melanoma(1654, 2, 1, 20, 1973, 0.97, 0);
                yield return new Melanoma(1654, 2, 0, 67, 1973, 1.13, 0);
                yield return new Melanoma(1667, 1, 0, 44, 1971, 5.8, 1);
                yield return new Melanoma(1678, 2, 0, 59, 1973, 1.29, 0);
                yield return new Melanoma(1685, 2, 0, 32, 1973, 0.48, 0);
                yield return new Melanoma(1690, 1, 1, 83, 1971, 1.62, 0);
                yield return new Melanoma(1710, 2, 0, 55, 1973, 2.26, 0);
                yield return new Melanoma(1710, 2, 1, 15, 1973, 0.58, 0);
                yield return new Melanoma(1726, 1, 0, 58, 1970, 0.97, 1);
                yield return new Melanoma(1745, 2, 0, 47, 1973, 2.58, 1);
                yield return new Melanoma(1762, 2, 0, 54, 1973, 0.81, 0);
                yield return new Melanoma(1779, 2, 1, 55, 1973, 3.54, 1);
                yield return new Melanoma(1787, 2, 1, 38, 1973, 0.97, 0);
                yield return new Melanoma(1787, 2, 0, 41, 1973, 1.78, 1);
                yield return new Melanoma(1793, 2, 0, 56, 1973, 1.94, 0);
                yield return new Melanoma(1804, 2, 0, 48, 1973, 1.29, 0);
                yield return new Melanoma(1812, 2, 1, 44, 1973, 3.22, 1);
                yield return new Melanoma(1836, 2, 0, 70, 1972, 1.53, 0);
                yield return new Melanoma(1839, 2, 0, 40, 1972, 1.29, 0);
                yield return new Melanoma(1839, 2, 1, 53, 1972, 1.62, 1);
                yield return new Melanoma(1854, 2, 0, 65, 1972, 1.62, 1);
                yield return new Melanoma(1856, 2, 1, 54, 1972, 0.32, 0);
                yield return new Melanoma(1860, 3, 1, 71, 1969, 4.84, 1);
                yield return new Melanoma(1864, 2, 0, 49, 1972, 1.29, 0);
                yield return new Melanoma(1899, 2, 0, 55, 1972, 0.97, 0);
                yield return new Melanoma(1914, 2, 0, 69, 1972, 3.06, 0);
                yield return new Melanoma(1919, 2, 1, 83, 1972, 3.54, 0);
                yield return new Melanoma(1920, 2, 1, 60, 1972, 1.62, 1);
                yield return new Melanoma(1927, 2, 1, 40, 1972, 2.58, 1);
                yield return new Melanoma(1933, 1, 0, 77, 1972, 1.94, 0);
                yield return new Melanoma(1942, 2, 0, 35, 1972, 0.81, 0);
                yield return new Melanoma(1955, 2, 0, 46, 1972, 7.73, 1);
                yield return new Melanoma(1956, 2, 0, 34, 1972, 0.97, 0);
                yield return new Melanoma(1958, 2, 0, 69, 1972, 12.88, 0);
                yield return new Melanoma(1963, 2, 0, 60, 1972, 2.58, 0);
                yield return new Melanoma(1970, 2, 1, 84, 1972, 4.09, 1);
                yield return new Melanoma(2005, 2, 0, 66, 1972, 0.64, 0);
                yield return new Melanoma(2007, 2, 1, 56, 1972, 0.97, 0);
                yield return new Melanoma(2011, 2, 0, 75, 1972, 3.22, 1);
                yield return new Melanoma(2024, 2, 0, 36, 1972, 1.62, 0);
                yield return new Melanoma(2028, 2, 1, 52, 1972, 3.87, 1);
                yield return new Melanoma(2038, 2, 0, 58, 1972, 0.32, 1);
                yield return new Melanoma(2056, 2, 0, 39, 1972, 0.32, 0);
                yield return new Melanoma(2059, 2, 1, 68, 1972, 3.22, 1);
                yield return new Melanoma(2061, 1, 1, 71, 1968, 2.26, 0);
                yield return new Melanoma(2062, 1, 0, 52, 1965, 3.06, 0);
                yield return new Melanoma(2075, 2, 1, 55, 1972, 2.58, 1);
                yield return new Melanoma(2085, 3, 0, 66, 1970, 0.65, 0);
                yield return new Melanoma(2102, 2, 1, 35, 1972, 1.13, 0);
                yield return new Melanoma(2103, 1, 1, 44, 1966, 0.81, 0);
                yield return new Melanoma(2104, 2, 0, 72, 1972, 0.97, 0);
                yield return new Melanoma(2108, 1, 0, 58, 1969, 1.76, 1);
                yield return new Melanoma(2112, 2, 0, 54, 1972, 1.94, 1);
                yield return new Melanoma(2150, 2, 0, 33, 1972, 0.65, 0);
                yield return new Melanoma(2156, 2, 0, 45, 1972, 0.97, 0);
                yield return new Melanoma(2165, 2, 1, 62, 1972, 5.64, 0);
                yield return new Melanoma(2209, 2, 0, 72, 1971, 9.66, 0);
                yield return new Melanoma(2227, 2, 0, 51, 1971, 0.1, 0);
                yield return new Melanoma(2227, 2, 1, 77, 1971, 5.48, 1);
                yield return new Melanoma(2256, 1, 0, 43, 1971, 2.26, 1);
                yield return new Melanoma(2264, 2, 0, 65, 1971, 4.83, 1);
                yield return new Melanoma(2339, 2, 0, 63, 1971, 0.97, 0);
                yield return new Melanoma(2361, 2, 1, 60, 1971, 0.97, 0);
                yield return new Melanoma(2387, 2, 0, 50, 1971, 5.16, 1);
                yield return new Melanoma(2388, 1, 1, 40, 1966, 0.81, 0);
                yield return new Melanoma(2403, 2, 0, 67, 1971, 2.9, 1);
                yield return new Melanoma(2426, 2, 0, 69, 1971, 3.87, 0);
                yield return new Melanoma(2426, 2, 0, 74, 1971, 1.94, 1);
                yield return new Melanoma(2431, 2, 0, 49, 1971, 0.16, 0);
                yield return new Melanoma(2460, 2, 0, 47, 1971, 0.64, 0);
                yield return new Melanoma(2467, 1, 0, 42, 1965, 2.26, 1);
                yield return new Melanoma(2492, 2, 0, 54, 1971, 1.45, 0);
                yield return new Melanoma(2493, 2, 1, 72, 1971, 4.82, 1);
                yield return new Melanoma(2521, 2, 0, 45, 1971, 1.29, 1);
                yield return new Melanoma(2542, 2, 1, 67, 1971, 7.89, 1);
                yield return new Melanoma(2559, 2, 0, 48, 1970, 0.81, 1);
                yield return new Melanoma(2565, 1, 1, 34, 1970, 3.54, 1);
                yield return new Melanoma(2570, 2, 0, 44, 1970, 1.29, 0);
                yield return new Melanoma(2660, 2, 0, 31, 1970, 0.64, 0);
                yield return new Melanoma(2666, 2, 0, 42, 1970, 3.22, 1);
                yield return new Melanoma(2676, 2, 0, 24, 1970, 1.45, 1);
                yield return new Melanoma(2738, 2, 0, 58, 1970, 0.48, 0);
                yield return new Melanoma(2782, 1, 1, 78, 1969, 1.94, 0);
                yield return new Melanoma(2787, 2, 1, 62, 1970, 0.16, 0);
                yield return new Melanoma(2984, 2, 1, 70, 1969, 0.16, 0);
                yield return new Melanoma(3032, 2, 0, 35, 1969, 1.29, 0);
                yield return new Melanoma(3040, 2, 0, 61, 1969, 1.94, 0);
                yield return new Melanoma(3042, 1, 0, 54, 1967, 3.54, 1);
                yield return new Melanoma(3067, 2, 0, 29, 1969, 0.81, 0);
                yield return new Melanoma(3079, 2, 1, 64, 1969, 0.65, 0);
                yield return new Melanoma(3101, 2, 1, 47, 1969, 7.09, 0);
                yield return new Melanoma(3144, 2, 1, 62, 1969, 0.16, 0);
                yield return new Melanoma(3152, 2, 0, 32, 1969, 1.62, 0);
                yield return new Melanoma(3154, 3, 1, 49, 1969, 1.62, 0);
                yield return new Melanoma(3180, 2, 0, 25, 1969, 1.29, 0);
                yield return new Melanoma(3182, 3, 1, 49, 1966, 6.12, 0);
                yield return new Melanoma(3185, 2, 0, 64, 1969, 0.48, 0);
                yield return new Melanoma(3199, 2, 0, 36, 1969, 0.64, 0);
                yield return new Melanoma(3228, 2, 0, 58, 1969, 3.22, 1);
                yield return new Melanoma(3229, 2, 0, 37, 1969, 1.94, 0);
                yield return new Melanoma(3278, 2, 1, 54, 1969, 2.58, 0);
                yield return new Melanoma(3297, 2, 0, 61, 1968, 2.58, 1);
                yield return new Melanoma(3328, 2, 1, 31, 1968, 0.81, 0);
                yield return new Melanoma(3330, 2, 1, 61, 1968, 0.81, 1);
                yield return new Melanoma(3338, 1, 0, 60, 1967, 3.22, 1);
                yield return new Melanoma(3383, 2, 0, 43, 1968, 0.32, 0);
                yield return new Melanoma(3384, 2, 0, 68, 1968, 3.22, 1);
                yield return new Melanoma(3385, 2, 0, 4, 1968, 2.74, 0);
                yield return new Melanoma(3388, 2, 1, 60, 1968, 4.84, 1);
                yield return new Melanoma(3402, 2, 1, 50, 1968, 1.62, 0);
                yield return new Melanoma(3441, 2, 0, 20, 1968, 0.65, 0);
                yield return new Melanoma(3458, 3, 0, 54, 1967, 1.45, 0);
                yield return new Melanoma(3459, 2, 0, 29, 1968, 0.65, 0);
                yield return new Melanoma(3459, 2, 1, 56, 1968, 1.29, 1);
                yield return new Melanoma(3476, 2, 0, 60, 1968, 1.62, 0);
                yield return new Melanoma(3523, 2, 0, 46, 1968, 3.54, 0);
                yield return new Melanoma(3667, 2, 0, 42, 1967, 3.22, 0);
                yield return new Melanoma(3695, 2, 0, 34, 1967, 0.65, 0);
                yield return new Melanoma(3695, 2, 0, 56, 1967, 1.03, 0);
                yield return new Melanoma(3776, 2, 1, 12, 1967, 7.09, 1);
                yield return new Melanoma(3776, 2, 0, 21, 1967, 1.29, 1);
                yield return new Melanoma(3830, 2, 1, 46, 1967, 0.65, 0);
                yield return new Melanoma(3856, 2, 0, 49, 1967, 1.78, 0);
                yield return new Melanoma(3872, 2, 0, 35, 1967, 12.24, 1);
                yield return new Melanoma(3909, 2, 1, 42, 1967, 8.06, 1);
                yield return new Melanoma(3968, 2, 0, 47, 1967, 0.81, 0);
                yield return new Melanoma(4001, 2, 0, 69, 1967, 2.1, 0);
                yield return new Melanoma(4103, 2, 0, 52, 1966, 3.87, 0);
                yield return new Melanoma(4119, 2, 1, 52, 1966, 0.65, 0);
                yield return new Melanoma(4124, 2, 0, 30, 1966, 1.94, 1);
                yield return new Melanoma(4207, 2, 1, 22, 1966, 0.65, 0);
                yield return new Melanoma(4310, 2, 1, 55, 1966, 2.1, 0);
                yield return new Melanoma(4390, 2, 0, 26, 1965, 1.94, 1);
                yield return new Melanoma(4479, 2, 0, 19, 1965, 1.13, 1);
                yield return new Melanoma(4492, 2, 1, 29, 1965, 7.06, 1);
                yield return new Melanoma(4668, 2, 0, 40, 1965, 6.12, 0);
                yield return new Melanoma(4688, 2, 0, 42, 1965, 0.48, 0);
                yield return new Melanoma(4926, 2, 0, 50, 1964, 2.26, 0);
                yield return new Melanoma(5565, 2, 0, 41, 1962, 2.9, 0);
            }
        }
    }
}
