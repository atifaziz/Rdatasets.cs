// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Smoking, Alcohol and (O)esophageal Cancer
    /// </summary>

    public class esoph
    {
        public readonly string agegp;
        public readonly string alcgp;
        public readonly string tobgp;
        public readonly int ncases;
        public readonly int ncontrols;

        public esoph(string agegp, string alcgp, string tobgp, int ncases, int ncontrols)
        {
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
                yield return new esoph("25-34", "0-39g/day", "0-9g/day", 0, 40);
                yield return new esoph("25-34", "0-39g/day", "10-19", 0, 10);
                yield return new esoph("25-34", "0-39g/day", "20-29", 0, 6);
                yield return new esoph("25-34", "0-39g/day", "30+", 0, 5);
                yield return new esoph("25-34", "40-79", "0-9g/day", 0, 27);
                yield return new esoph("25-34", "40-79", "10-19", 0, 7);
                yield return new esoph("25-34", "40-79", "20-29", 0, 4);
                yield return new esoph("25-34", "40-79", "30+", 0, 7);
                yield return new esoph("25-34", "80-119", "0-9g/day", 0, 2);
                yield return new esoph("25-34", "80-119", "10-19", 0, 1);
                yield return new esoph("25-34", "80-119", "30+", 0, 2);
                yield return new esoph("25-34", "120+", "0-9g/day", 0, 1);
                yield return new esoph("25-34", "120+", "10-19", 1, 1);
                yield return new esoph("25-34", "120+", "20-29", 0, 1);
                yield return new esoph("25-34", "120+", "30+", 0, 2);
                yield return new esoph("35-44", "0-39g/day", "0-9g/day", 0, 60);
                yield return new esoph("35-44", "0-39g/day", "10-19", 1, 14);
                yield return new esoph("35-44", "0-39g/day", "20-29", 0, 7);
                yield return new esoph("35-44", "0-39g/day", "30+", 0, 8);
                yield return new esoph("35-44", "40-79", "0-9g/day", 0, 35);
                yield return new esoph("35-44", "40-79", "10-19", 3, 23);
                yield return new esoph("35-44", "40-79", "20-29", 1, 14);
                yield return new esoph("35-44", "40-79", "30+", 0, 8);
                yield return new esoph("35-44", "80-119", "0-9g/day", 0, 11);
                yield return new esoph("35-44", "80-119", "10-19", 0, 6);
                yield return new esoph("35-44", "80-119", "20-29", 0, 2);
                yield return new esoph("35-44", "80-119", "30+", 0, 1);
                yield return new esoph("35-44", "120+", "0-9g/day", 2, 3);
                yield return new esoph("35-44", "120+", "10-19", 0, 3);
                yield return new esoph("35-44", "120+", "20-29", 2, 4);
                yield return new esoph("45-54", "0-39g/day", "0-9g/day", 1, 46);
                yield return new esoph("45-54", "0-39g/day", "10-19", 0, 18);
                yield return new esoph("45-54", "0-39g/day", "20-29", 0, 10);
                yield return new esoph("45-54", "0-39g/day", "30+", 0, 4);
                yield return new esoph("45-54", "40-79", "0-9g/day", 6, 38);
                yield return new esoph("45-54", "40-79", "10-19", 4, 21);
                yield return new esoph("45-54", "40-79", "20-29", 5, 15);
                yield return new esoph("45-54", "40-79", "30+", 5, 7);
                yield return new esoph("45-54", "80-119", "0-9g/day", 3, 16);
                yield return new esoph("45-54", "80-119", "10-19", 6, 14);
                yield return new esoph("45-54", "80-119", "20-29", 1, 5);
                yield return new esoph("45-54", "80-119", "30+", 2, 4);
                yield return new esoph("45-54", "120+", "0-9g/day", 4, 4);
                yield return new esoph("45-54", "120+", "10-19", 3, 4);
                yield return new esoph("45-54", "120+", "20-29", 2, 3);
                yield return new esoph("45-54", "120+", "30+", 4, 4);
                yield return new esoph("55-64", "0-39g/day", "0-9g/day", 2, 49);
                yield return new esoph("55-64", "0-39g/day", "10-19", 3, 22);
                yield return new esoph("55-64", "0-39g/day", "20-29", 3, 12);
                yield return new esoph("55-64", "0-39g/day", "30+", 4, 6);
                yield return new esoph("55-64", "40-79", "0-9g/day", 9, 40);
                yield return new esoph("55-64", "40-79", "10-19", 6, 21);
                yield return new esoph("55-64", "40-79", "20-29", 4, 17);
                yield return new esoph("55-64", "40-79", "30+", 3, 6);
                yield return new esoph("55-64", "80-119", "0-9g/day", 9, 18);
                yield return new esoph("55-64", "80-119", "10-19", 8, 15);
                yield return new esoph("55-64", "80-119", "20-29", 3, 6);
                yield return new esoph("55-64", "80-119", "30+", 4, 4);
                yield return new esoph("55-64", "120+", "0-9g/day", 5, 10);
                yield return new esoph("55-64", "120+", "10-19", 6, 7);
                yield return new esoph("55-64", "120+", "20-29", 2, 3);
                yield return new esoph("55-64", "120+", "30+", 5, 6);
                yield return new esoph("65-74", "0-39g/day", "0-9g/day", 5, 48);
                yield return new esoph("65-74", "0-39g/day", "10-19", 4, 14);
                yield return new esoph("65-74", "0-39g/day", "20-29", 2, 7);
                yield return new esoph("65-74", "0-39g/day", "30+", 0, 2);
                yield return new esoph("65-74", "40-79", "0-9g/day", 17, 34);
                yield return new esoph("65-74", "40-79", "10-19", 3, 10);
                yield return new esoph("65-74", "40-79", "20-29", 5, 9);
                yield return new esoph("65-74", "80-119", "0-9g/day", 6, 13);
                yield return new esoph("65-74", "80-119", "10-19", 4, 12);
                yield return new esoph("65-74", "80-119", "20-29", 2, 3);
                yield return new esoph("65-74", "80-119", "30+", 1, 1);
                yield return new esoph("65-74", "120+", "0-9g/day", 3, 4);
                yield return new esoph("65-74", "120+", "10-19", 1, 2);
                yield return new esoph("65-74", "120+", "20-29", 1, 1);
                yield return new esoph("65-74", "120+", "30+", 1, 1);
                yield return new esoph("75+", "0-39g/day", "0-9g/day", 1, 18);
                yield return new esoph("75+", "0-39g/day", "10-19", 2, 6);
                yield return new esoph("75+", "0-39g/day", "30+", 1, 3);
                yield return new esoph("75+", "40-79", "0-9g/day", 2, 5);
                yield return new esoph("75+", "40-79", "10-19", 1, 3);
                yield return new esoph("75+", "40-79", "20-29", 0, 3);
                yield return new esoph("75+", "40-79", "30+", 1, 1);
                yield return new esoph("75+", "80-119", "0-9g/day", 1, 1);
                yield return new esoph("75+", "80-119", "10-19", 1, 1);
                yield return new esoph("75+", "120+", "0-9g/day", 2, 2);
                yield return new esoph("75+", "120+", "10-19", 1, 1);
            }
        }
    }
}
