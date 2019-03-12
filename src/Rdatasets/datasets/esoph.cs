// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Smoking, Alcohol and (O)esophageal Cancer
    /// </summary>

    public class esoph
    {
        public readonly int κ;
        public readonly string agegp;
        public readonly string alcgp;
        public readonly string tobgp;
        public readonly int ncases;
        public readonly int ncontrols;

        public esoph(int κ, string agegp, string alcgp, string tobgp, int ncases, int ncontrols)
        {
            this.κ = κ;
            this.agegp = agegp;
            this.alcgp = alcgp;
            this.tobgp = tobgp;
            this.ncases = ncases;
            this.ncontrols = ncontrols;
        }

        public static IEnumerable<esoph> Data
        {
            get
            {
                yield return new esoph(1, "25-34", "0-39g/day", "0-9g/day", 0, 40);
                yield return new esoph(2, "25-34", "0-39g/day", "10-19", 0, 10);
                yield return new esoph(3, "25-34", "0-39g/day", "20-29", 0, 6);
                yield return new esoph(4, "25-34", "0-39g/day", "30+", 0, 5);
                yield return new esoph(5, "25-34", "40-79", "0-9g/day", 0, 27);
                yield return new esoph(6, "25-34", "40-79", "10-19", 0, 7);
                yield return new esoph(7, "25-34", "40-79", "20-29", 0, 4);
                yield return new esoph(8, "25-34", "40-79", "30+", 0, 7);
                yield return new esoph(9, "25-34", "80-119", "0-9g/day", 0, 2);
                yield return new esoph(10, "25-34", "80-119", "10-19", 0, 1);
                yield return new esoph(11, "25-34", "80-119", "30+", 0, 2);
                yield return new esoph(12, "25-34", "120+", "0-9g/day", 0, 1);
                yield return new esoph(13, "25-34", "120+", "10-19", 1, 1);
                yield return new esoph(14, "25-34", "120+", "20-29", 0, 1);
                yield return new esoph(15, "25-34", "120+", "30+", 0, 2);
                yield return new esoph(16, "35-44", "0-39g/day", "0-9g/day", 0, 60);
                yield return new esoph(17, "35-44", "0-39g/day", "10-19", 1, 14);
                yield return new esoph(18, "35-44", "0-39g/day", "20-29", 0, 7);
                yield return new esoph(19, "35-44", "0-39g/day", "30+", 0, 8);
                yield return new esoph(20, "35-44", "40-79", "0-9g/day", 0, 35);
                yield return new esoph(21, "35-44", "40-79", "10-19", 3, 23);
                yield return new esoph(22, "35-44", "40-79", "20-29", 1, 14);
                yield return new esoph(23, "35-44", "40-79", "30+", 0, 8);
                yield return new esoph(24, "35-44", "80-119", "0-9g/day", 0, 11);
                yield return new esoph(25, "35-44", "80-119", "10-19", 0, 6);
                yield return new esoph(26, "35-44", "80-119", "20-29", 0, 2);
                yield return new esoph(27, "35-44", "80-119", "30+", 0, 1);
                yield return new esoph(28, "35-44", "120+", "0-9g/day", 2, 3);
                yield return new esoph(29, "35-44", "120+", "10-19", 0, 3);
                yield return new esoph(30, "35-44", "120+", "20-29", 2, 4);
                yield return new esoph(31, "45-54", "0-39g/day", "0-9g/day", 1, 46);
                yield return new esoph(32, "45-54", "0-39g/day", "10-19", 0, 18);
                yield return new esoph(33, "45-54", "0-39g/day", "20-29", 0, 10);
                yield return new esoph(34, "45-54", "0-39g/day", "30+", 0, 4);
                yield return new esoph(35, "45-54", "40-79", "0-9g/day", 6, 38);
                yield return new esoph(36, "45-54", "40-79", "10-19", 4, 21);
                yield return new esoph(37, "45-54", "40-79", "20-29", 5, 15);
                yield return new esoph(38, "45-54", "40-79", "30+", 5, 7);
                yield return new esoph(39, "45-54", "80-119", "0-9g/day", 3, 16);
                yield return new esoph(40, "45-54", "80-119", "10-19", 6, 14);
                yield return new esoph(41, "45-54", "80-119", "20-29", 1, 5);
                yield return new esoph(42, "45-54", "80-119", "30+", 2, 4);
                yield return new esoph(43, "45-54", "120+", "0-9g/day", 4, 4);
                yield return new esoph(44, "45-54", "120+", "10-19", 3, 4);
                yield return new esoph(45, "45-54", "120+", "20-29", 2, 3);
                yield return new esoph(46, "45-54", "120+", "30+", 4, 4);
                yield return new esoph(47, "55-64", "0-39g/day", "0-9g/day", 2, 49);
                yield return new esoph(48, "55-64", "0-39g/day", "10-19", 3, 22);
                yield return new esoph(49, "55-64", "0-39g/day", "20-29", 3, 12);
                yield return new esoph(50, "55-64", "0-39g/day", "30+", 4, 6);
                yield return new esoph(51, "55-64", "40-79", "0-9g/day", 9, 40);
                yield return new esoph(52, "55-64", "40-79", "10-19", 6, 21);
                yield return new esoph(53, "55-64", "40-79", "20-29", 4, 17);
                yield return new esoph(54, "55-64", "40-79", "30+", 3, 6);
                yield return new esoph(55, "55-64", "80-119", "0-9g/day", 9, 18);
                yield return new esoph(56, "55-64", "80-119", "10-19", 8, 15);
                yield return new esoph(57, "55-64", "80-119", "20-29", 3, 6);
                yield return new esoph(58, "55-64", "80-119", "30+", 4, 4);
                yield return new esoph(59, "55-64", "120+", "0-9g/day", 5, 10);
                yield return new esoph(60, "55-64", "120+", "10-19", 6, 7);
                yield return new esoph(61, "55-64", "120+", "20-29", 2, 3);
                yield return new esoph(62, "55-64", "120+", "30+", 5, 6);
                yield return new esoph(63, "65-74", "0-39g/day", "0-9g/day", 5, 48);
                yield return new esoph(64, "65-74", "0-39g/day", "10-19", 4, 14);
                yield return new esoph(65, "65-74", "0-39g/day", "20-29", 2, 7);
                yield return new esoph(66, "65-74", "0-39g/day", "30+", 0, 2);
                yield return new esoph(67, "65-74", "40-79", "0-9g/day", 17, 34);
                yield return new esoph(68, "65-74", "40-79", "10-19", 3, 10);
                yield return new esoph(69, "65-74", "40-79", "20-29", 5, 9);
                yield return new esoph(70, "65-74", "80-119", "0-9g/day", 6, 13);
                yield return new esoph(71, "65-74", "80-119", "10-19", 4, 12);
                yield return new esoph(72, "65-74", "80-119", "20-29", 2, 3);
                yield return new esoph(73, "65-74", "80-119", "30+", 1, 1);
                yield return new esoph(74, "65-74", "120+", "0-9g/day", 3, 4);
                yield return new esoph(75, "65-74", "120+", "10-19", 1, 2);
                yield return new esoph(76, "65-74", "120+", "20-29", 1, 1);
                yield return new esoph(77, "65-74", "120+", "30+", 1, 1);
                yield return new esoph(78, "75+", "0-39g/day", "0-9g/day", 1, 18);
                yield return new esoph(79, "75+", "0-39g/day", "10-19", 2, 6);
                yield return new esoph(80, "75+", "0-39g/day", "30+", 1, 3);
                yield return new esoph(81, "75+", "40-79", "0-9g/day", 2, 5);
                yield return new esoph(82, "75+", "40-79", "10-19", 1, 3);
                yield return new esoph(83, "75+", "40-79", "20-29", 0, 3);
                yield return new esoph(84, "75+", "40-79", "30+", 1, 1);
                yield return new esoph(85, "75+", "80-119", "0-9g/day", 1, 1);
                yield return new esoph(86, "75+", "80-119", "10-19", 1, 1);
                yield return new esoph(87, "75+", "120+", "0-9g/day", 2, 2);
                yield return new esoph(88, "75+", "120+", "10-19", 1, 1);
            }
        }
    }
}
