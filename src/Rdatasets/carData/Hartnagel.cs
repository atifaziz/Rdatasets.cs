// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Canadian Crime-Rates Time Series
    /// </summary>

    public class Hartnagel
    {
        public readonly int year;
        public readonly int tfr;
        public readonly int partic;
        public readonly double degrees;
        public readonly double fconvict;
        public readonly string ftheft;
        public readonly double mconvict;
        public readonly string mtheft;

        public Hartnagel(int year, int tfr, int partic, double degrees, double fconvict, string ftheft, double mconvict, string mtheft)
        {
            this.year = year;
            this.tfr = tfr;
            this.partic = partic;
            this.degrees = degrees;
            this.fconvict = fconvict;
            this.ftheft = ftheft;
            this.mconvict = mconvict;
            this.mtheft = mtheft;
        }

        public static IEnumerable<Hartnagel> Data
        {
            get
            {
                yield return new Hartnagel(1931, 3200, 234, 12.4, 77.1, null, 778.7, null);
                yield return new Hartnagel(1932, 3084, 234, 12.9, 92.9, null, 745.7, null);
                yield return new Hartnagel(1933, 2864, 235, 13.9, 98.3, null, 768.3, null);
                yield return new Hartnagel(1934, 2803, 237, 13.6, 88.1, null, 733.6, null);
                yield return new Hartnagel(1935, 2755, 238, 13.2, 79.4, "20.4", 765.7, "247.1");
                yield return new Hartnagel(1936, 2696, 240, 13.2, 91, "22.1", 816.5, "254.9");
                yield return new Hartnagel(1937, 2646, 241, 12.2, 100.4, "22.4", 821.8, "272.4");
                yield return new Hartnagel(1938, 2701, 242, 12.6, 108.9, "21.8", 956.8, "285.8");
                yield return new Hartnagel(1939, 2654, 244, 12.3, 123.6, "21.1", 1035.7, "292.2");
                yield return new Hartnagel(1940, 2766, 245, 12, 157.3, "21.4", 951.6, "256");
                yield return new Hartnagel(1941, 2832, 246, 11.7, 154.3, "25.3", 850.9, "205.8");
                yield return new Hartnagel(1942, 2964, 268, 11.2, 143.9, "27.1", 769.7, "188");
                yield return new Hartnagel(1943, 3041, 333, 11.5, 147.5, "29", 811.2, "205.8");
                yield return new Hartnagel(1944, 3010, 335, 11.1, 97.3, "24.2", 865.4, "207.9");
                yield return new Hartnagel(1945, 3018, 331, 12.5, 76.6, "24.7", 866.8, "197.8");
                yield return new Hartnagel(1946, 3374, 253, 15, 72.8, "20.5", 968, "195.9");
                yield return new Hartnagel(1947, 3545, 243, 17.6, 68.9, "20.7", 894, "198.9");
                yield return new Hartnagel(1948, 3441, 241, 21.2, 66.7, "22.8", 830.8, "198.6");
                yield return new Hartnagel(1949, 3456, 242, 22.7, 55, "18.5", 811.2, "216.1");
                yield return new Hartnagel(1950, 3455, 237, 21.4, 55, "19.3", 775.4, "212");
                yield return new Hartnagel(1951, 3503, 242, 20.7, 55, "20", 739.8, "208");
                yield return new Hartnagel(1952, 3641, 240, 19.5, 54.7, "19.4", 740.3, "199.3");
                yield return new Hartnagel(1953, 3721, 233, 36.6, 47.9, "16.1", 725.1, "176.4");
                yield return new Hartnagel(1954, 3828, 232, 18.1, 49, "16.5", 739.9, "166.8");
                yield return new Hartnagel(1955, 3831, 236, 17.7, 44.4, "15.2", 663.8, "179.7");
                yield return new Hartnagel(1956, 3858, 245, 18.7, 40.2, "15.3", 633.7, "198.8");
                yield return new Hartnagel(1957, 3925, 256, 20.8, 43.8, "17.1", 716.5, "262.5");
                yield return new Hartnagel(1958, 3880, 261, 22.7, 49.5, "21.2", 761, "263.4");
                yield return new Hartnagel(1959, 3935, 265, 24.6, 50.4, "22.3", 665.3, "253.6");
                yield return new Hartnagel(1960, 3895, 278, 28.5, 59.6, "28.5", 742.6, "280.9");
                yield return new Hartnagel(1961, 3840, 291, 31.3, 72.4, "34.4", 789.8, "290.9");
                yield return new Hartnagel(1962, 3756, 290, 38, 70.6, "36", 776.8, "274.7");
                yield return new Hartnagel(1963, 3669, 290, 42, 82, "43.8", 842.2, "296.9");
                yield return new Hartnagel(1964, 3502, 307, 48.5, 89.5, "49.7", 799.1, "281.3");
                yield return new Hartnagel(1965, 3145, 313, 59.2, 101.3, "58.6", 763, "264.2");
                yield return new Hartnagel(1966, 2812, 325, 69.7, 116.7, "71.4", 804.6, "286.6");
                yield return new Hartnagel(1967, 2586, 339, 80.4, 115.2, "70.6", 781.1, "272");
                yield return new Hartnagel(1968, 2441, 338, 90.4, 122.9, "73", 849.7, "274.7");
            }
        }
    }
}
