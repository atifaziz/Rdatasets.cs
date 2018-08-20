// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Social Support Data
    /// </summary>

    public class socsupport
    {
        public readonly string gender;
        public readonly string age;
        public readonly string country;
        public readonly string marital;
        public readonly string livewith;
        public readonly string employment;
        public readonly string firstyr;
        public readonly string enrolment;
        public readonly int emotional;
        public readonly int? emotionalsat;
        public readonly int? tangible;
        public readonly int? tangiblesat;
        public readonly int affect;
        public readonly int affectsat;
        public readonly int psi;
        public readonly int psisat;
        public readonly int? esupport;
        public readonly int? psupport;
        public readonly int? supsources;
        public readonly int BDI;

        public socsupport(string gender, string age, string country, string marital, string livewith, string employment, string firstyr, string enrolment, int emotional, int? emotionalsat, int? tangible, int? tangiblesat, int affect, int affectsat, int psi, int psisat, int? esupport, int? psupport, int? supsources, int BDI)
        {
            this.gender = gender;
            this.age = age;
            this.country = country;
            this.marital = marital;
            this.livewith = livewith;
            this.employment = employment;
            this.firstyr = firstyr;
            this.enrolment = enrolment;
            this.emotional = emotional;
            this.emotionalsat = emotionalsat;
            this.tangible = tangible;
            this.tangiblesat = tangiblesat;
            this.affect = affect;
            this.affectsat = affectsat;
            this.psi = psi;
            this.psisat = psisat;
            this.esupport = esupport;
            this.psupport = psupport;
            this.supsources = supsources;
            this.BDI = BDI;
        }

        public static IEnumerable<socsupport> Data
        {
            get
            {
                yield return new socsupport("male", "21-24", "australia", "other", "partner", "employed part-time", "other", "full-time", 22, 23, 17, 18, 15, 15, 12, 13, 13, 11, 13, 5);
                yield return new socsupport("female", "21-24", "australia", "single", "partner", "parental support", "other", "full-time", 21, 20, 12, 10, 10, 6, 9, 6, 12, 7, 10, 8);
                yield return new socsupport("male", "21-24", "australia", "single", "residences", "employed part-time", "other", "full-time", 21, 18, 16, 16, 15, 15, 13, 12, 14, 13, 14, 16);
                yield return new socsupport("male", "18-20", "australia", "single", "parents", "employed part-time", "first year", "full-time", 19, 19, 20, 17, 11, 11, 13, 12, 15, 15, 15, 0);
                yield return new socsupport("female", "21-24", "australia", "single", "friends", "employed part-time", "other", "full-time", 16, 19, 11, 15, 6, 10, 11, 12, 9, 7, 9, 9);
                yield return new socsupport("female", "21-24", "australia", "single", "friends", "govt assistance", "other", "full-time", 20, 17, 16, 15, 12, 14, 12, 11, 13, 12, 13, 0);
                yield return new socsupport("female", "25-30", "australia", "married", "partner", "employed part-time", "other", "full-time", 20, 23, 20, 20, 14, 15, 15, 15, 15, 10, 13, 1);
                yield return new socsupport("female", "25-30", "australia", "married", "partner", "employed part-time", "other", "part-time", 20, 20, 16, 16, 12, 12, 12, 12, 13, 11, 11, 14);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "other", "full-time", 24, 25, 20, 20, 15, 15, 12, 15, 16, null, null, 12);
                yield return new socsupport("male", "40+", "australia", "other", "alone", "employed part-time", "other", "full-time", 13, 18, 6, 14, 6, 12, 6, 11, 10, 8, 9, 20);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "employed part-time", "other", "full-time", 20, 18, 13, 13, 13, 14, 11, 12, 12, 8, 14, 13);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "employed part-time", "other", "full-time", 19, 19, 14, 16, 14, 12, 10, 8, 8, 6, 5, 34);
                yield return new socsupport("female", "21-24", "australia", "single", "other", "employed part-time", "other", "full-time", 25, 25, 20, 20, 15, 15, 15, 15, 16, 10, 12, 8);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "govt assistance", "other", "full-time", 21, 19, 13, 11, 9, 7, 9, 8, 14, 10, 10, 15);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "govt assistance", "other", "full-time", 20, 20, 14, 15, 15, 15, 13, 13, 11, 10, 8, 0);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "employed part-time", "other", "full-time", 22, 22, 20, 20, 14, 14, 12, 14, 17, 14, 14, 6);
                yield return new socsupport("female", "25-30", "australia", "other", "partner", "employed fulltime", "other", "full-time", 20, 20, 15, 16, 13, 13, 12, 12, 14, 9, 12, 6);
                yield return new socsupport("female", "40+", "australia", "other", "partner", "other", "other", "part-time", 20, 20, 9, 12, 12, 12, 12, 12, 14, 5, 10, 0);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "other", "other", "full-time", 16, 19, 20, 20, 10, 11, 9, 10, null, null, null, 8);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "parental support", "other", "full-time", 20, 20, 20, 20, 12, 14, 13, 14, 13, 11, 11, 0);
                yield return new socsupport("male", "18-20", "australia", "single", "residences", "parental support", "first year", "full-time", 17, 20, 14, 14, 10, 12, 13, 12, 13, 11, 11, 11);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "parental support", "first year", "full-time", 21, 18, 11, 12, 9, 9, 12, 12, 15, 9, 11, 21);
                yield return new socsupport("female", "31-40", "other", "married", "partner", "other", "other", "full-time", 25, 25, 16, 17, 15, 15, 15, 15, 14, 12, 14, 9);
                yield return new socsupport("female", "40+", "australia", "married", "partner", "employed fulltime", "other", "part-time", 22, 22, 20, 20, 14, 14, 12, 12, 12, 10, 10, 0);
                yield return new socsupport("female", "25-30", "other", "other", "parents", "employed part-time", "other", "full-time", 25, 25, 20, 20, 15, 15, 15, 15, 15, 16, 14, 6);
                yield return new socsupport("female", "18-20", "australia", "single", "friends", "employed part-time", "other", "full-time", 22, 20, 17, 20, 13, 13, 13, 14, 13, 11, 10, 3);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "other", "full-time", 20, 23, 16, 18, 13, 13, 12, 12, 14, 15, 11, 16);
                yield return new socsupport("female", "40+", "other", "married", "partner", "other", "other", "full-time", 21, 23, 14, 17, 15, 15, 14, 15, 13, 7, 7, 1);
                yield return new socsupport("female", "18-20", "australia", "single", "friends", "employed part-time", "other", "full-time", 21, 22, 20, 19, 12, 12, 13, 13, 16, 15, 14, 20);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "govt assistance", "other", "full-time", 11, 15, 7, 8, 7, 7, 8, 10, 8, 9, 9, 9);
                yield return new socsupport("male", "18-20", "australia", "single", "parents", "employed part-time", "other", "full-time", 15, 13, 19, 19, 11, 9, 11, 10, 14, 10, 9, 9);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "govt assistance", "other", "full-time", 14, 16, 13, 13, 4, 7, 8, 14, 13, 6, 8, 21);
                yield return new socsupport("male", "21-24", "australia", "single", "parents", "employed part-time", "other", "full-time", 20, 19, 20, 19, 10, 7, 12, 12, 13, 12, 12, 2);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "parental support", "first year", "full-time", 23, 22, 20, 20, 15, 15, 15, 15, 15, 13, 14, 2);
                yield return new socsupport("male", "18-20", "australia", "single", "parents", "other", "first year", "full-time", 21, 20, 20, 19, 15, 15, 14, 15, 17, 15, 13, 7);
                yield return new socsupport("male", "18-20", "australia", "single", "residences", "govt assistance", "first year", "full-time", 6, 8, 4, 8, 3, 3, 5, 6, 6, 4, 5, 46);
                yield return new socsupport("male", "18-20", "australia", "single", "parents", "employed part-time", "first year", "full-time", 19, 20, 20, 20, 14, 14, 15, 15, 16, 15, 15, 9);
                yield return new socsupport("female", "21-24", "australia", "single", "residences", "parental support", "other", "full-time", 17, 17, 12, 14, 8, 14, 11, 14, 10, 15, 15, 11);
                yield return new socsupport("male", "31-40", "australia", "single", "alone", "other", "other", "part-time", 25, 25, 17, 20, 12, 13, 10, 12, 10, 10, 9, 15);
                yield return new socsupport("male", "21-24", "australia", "single", "parents", "employed part-time", "other", "full-time", 20, 19, 15, 18, 15, 14, 14, 12, 13, 9, 11, 8);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "other", "full-time", 21, 20, 17, 15, 15, 15, 11, 12, 15, 10, 10, 7);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "employed part-time", "other", "full-time", 19, 19, 14, 14, 8, 9, 12, 12, 14, 8, 10, 11);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "parental support", "other", "full-time", 23, 19, 20, 19, 15, 13, 11, 11, 14, 14, 11, 7);
                yield return new socsupport("male", "31-40", "australia", "married", "partner", "other", "other", "part-time", 17, 19, 16, 16, 12, 12, 12, 12, 9, 6, 7, 1);
                yield return new socsupport("male", "31-40", "australia", "other", "partner", "other", "other", "full-time", 19, 21, 18, 18, 14, 15, 12, 12, 9, 5, 8, 2);
                yield return new socsupport("male", "21-24", "australia", "single", "parents", "other", "other", "part-time", 18, 24, 17, 20, 10, 13, 15, 15, 11, 10, 10, 0);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "employed part-time", "other", "full-time", 25, 25, 20, 20, 15, 15, 15, 15, 16, 13, 13, 7);
                yield return new socsupport("male", "21-24", "other", "single", "parents", "employed part-time", "other", "full-time", 20, 20, 20, 20, 15, 15, 15, 15, 14, 20, 16, 10);
                yield return new socsupport("female", "21-24", "australia", "other", "partner", "employed part-time", "other", "full-time", 20, 20, 12, 13, 13, 15, 10, 12, 11, 7, 10, 0);
                yield return new socsupport("female", "25-30", "australia", "other", "partner", "employed part-time", "other", "full-time", 21, 20, 14, 16, 14, 13, 11, 12, 17, 10, 12, 5);
                yield return new socsupport("male", "18-20", "australia", "single", "residences", "other", "first year", "full-time", 17, 19, 4, null, 10, 15, 10, 12, 8, 4, 6, 0);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "other", "part-time", 19, 19, 20, 16, 13, 12, 12, 12, 12, 8, 10, 17);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "govt assistance", "first year", "full-time", 20, 20, 20, 20, 13, 13, 15, 15, 19, 17, 14, 6);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "parental support", "first year", "full-time", 23, 24, 20, 20, 14, 15, 11, 11, 12, 8, 12, 19);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "parental support", "first year", "full-time", 12, 13, null, null, 9, 9, 9, 8, 11, 5, 8, 11);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "other", "first year", "full-time", 20, 20, 20, 20, 15, 15, 10, 12, 15, 8, 11, 9);
                yield return new socsupport("female", "18-20", "australia", "single", "friends", "govt assistance", "first year", "full-time", 17, 19, 19, 19, 14, 14, 12, 12, 11, 13, 13, 22);
                yield return new socsupport("female", "21-24", "other", "married", "partner", "govt assistance", "other", "full-time", 25, 25, 20, 20, 15, 15, 15, 15, 14, 14, 12, 13);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "employed part-time", "other", "part-time", 16, 17, 19, 18, 10, 10, 7, 8, 12, 8, 7, 32);
                yield return new socsupport("female", "21-24", "other", "single", "parents", "other", "other", "full-time", 19, 19, 19, 18, 12, 12, 12, 12, 13, 12, 12, 13);
                yield return new socsupport("female", "18-20", "other", "single", "parents", "other", "other", "full-time", 24, 23, 19, 18, 15, 15, 14, 14, 16, 14, 14, 11);
                yield return new socsupport("male", "18-20", "australia", "single", "parents", "parental support", "first year", "full-time", 10, 16, 19, 19, 6, 5, 6, 5, 9, 8, 11, 16);
                yield return new socsupport("female", "18-20", "other", "single", "residences", "parental support", "first year", "full-time", 15, 18, 16, 16, 9, 11, 11, 11, 9, 8, 8, 7);
                yield return new socsupport("female", "21-24", "australia", "married", "partner", "employed part-time", "other", "full-time", 19, 19, 20, 20, 14, 14, 15, 15, 16, 12, 14, 7);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "employed part-time", "other", "part-time", 20, 21, 19, 20, 14, 14, 13, 13, 15, 12, 10, 10);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "employed part-time", "other", "full-time", 12, 12, 19, 16, 7, 5, 8, 6, 12, 10, 8, 23);
                yield return new socsupport("male", "18-20", "australia", "single", "parents", "employed part-time", "first year", "part-time", 13, null, 15, null, 8, 8, 12, 13, 13, 13, 11, 14);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "govt assistance", "other", "full-time", 21, 22, 8, 12, 6, 10, 11, 13, 12, 10, 11, 48);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "parental support", "other", "", 16, 17, 20, 20, 15, 15, 10, 11, 8, 13, 10, 12);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "other", "full-time", 19, 20, 18, 19, 11, 9, 15, 15, 14, 14, 11, 5);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "other", "full-time", 24, 25, 15, 19, 15, 15, 14, 15, 14, 12, 14, 6);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "parental support", "first year", "full-time", 20, 20, 18, 17, 14, 13, 14, 13, 13, 10, 9, 21);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "govt assistance", "first year", "full-time", 13, 13, 15, 15, 10, 13, 8, 8, 10, 8, 8, 28);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "first year", "full-time", 18, 17, 20, 18, 11, 11, 11, 12, 11, 10, 9, 14);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "first year", "full-time", 16, 20, 14, 15, 8, 10, 7, 10, 8, 11, 7, 7);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "employed part-time", "first year", "part-time", 25, 24, 20, 20, 6, 6, 15, 15, 16, 16, 14, 4);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "parental support", "first year", "full-time", 20, 20, 17, 17, 11, 12, 14, 13, 18, 11, 9, 8);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "parental support", "other", "part-time", 16, 19, 10, 13, 10, 11, 10, 12, 10, 5, 8, 4);
                yield return new socsupport("male", "18-20", "australia", "single", "residences", "other", "other", "", 21, 21, 11, 13, 10, 11, 12, 12, 12, 10, 11, 12);
                yield return new socsupport("female", "21-24", "australia", "single", "other", "employed part-time", "other", "full-time", 18, 19, 20, 16, 12, 12, 11, 11, 13, 12, 12, 2);
                yield return new socsupport("female", "31-40", "australia", "married", "partner", "employed part-time", "other", "full-time", 18, 16, 18, 18, 10, 9, 6, 6, 9, 4, 8, 28);
                yield return new socsupport("female", "21-24", "australia", "single", "partner", "other", "other", "full-time", 25, 25, 18, 20, 15, 15, 13, 13, 14, 14, 13, 2);
                yield return new socsupport("male", "25-30", "australia", "single", "parents", "govt assistance", "other", "full-time", 16, 20, 8, 16, 10, 12, 10, 12, 12, 5, 11, 3);
                yield return new socsupport("female", "21-24", "australia", "single", "parents", "parental support", "other", "", 24, 24, 18, 19, 15, 15, 14, 15, 11, 8, 10, 6);
                yield return new socsupport("male", "31-40", "australia", "other", "other", "employed part-time", "other", "full-time", 18, 15, 20, 16, 10, 10, 10, 10, 10, 6, 9, 12);
                yield return new socsupport("female", "21-24", "australia", "other", "partner", "govt assistance", "other", "full-time", 21, 25, 17, 17, 15, 15, 11, 13, 13, 10, 10, 11);
                yield return new socsupport("female", "21-24", "australia", "single", "residences", "employed part-time", "other", "full-time", 20, 20, 20, 20, 13, 13, 15, 14, 16, 17, 16, 3);
                yield return new socsupport("female", "21-24", "other", "single", "residences", "parental support", "other", "full-time", 22, 23, 18, 18, 15, 15, 12, 13, 10, 8, 9, 2);
                yield return new socsupport("male", "21-24", "australia", "single", "friends", "parental support", "other", "full-time", 14, 16, 18, 18, 10, 10, 11, 11, 10, 11, 11, 7);
                yield return new socsupport("female", "18-20", "australia", "single", "parents", "parental support", "first year", "", 23, 21, 18, 17, 14, 14, 12, 12, 13, 9, 9, 21);
                yield return new socsupport("female", "18-20", "australia", "single", "residences", "employed part-time", "first year", "full-time", 21, 22, 20, 20, 15, 15, 15, 15, 15, 13, 11, 8);
                yield return new socsupport("female", "21-24", "australia", "single", "friends", "employed part-time", "other", "full-time", 19, 20, 11, 12, 12, 12, 11, 11, 14, 9, 11, 11);
                yield return new socsupport("male", "18-20", "australia", "single", "partner", "govt assistance", "other", "full-time", 13, 18, 13, 16, 15, 15, 12, 12, 12, 7, 10, 10);
                yield return new socsupport("female", "21-24", "australia", "single", "partner", "employed part-time", "other", "full-time", 17, 18, 17, 17, 15, 14, 14, 14, 14, 9, 11, 8);
                yield return new socsupport("female", "21-24", "other", "single", "partner", "employed part-time", "other", "full-time", 22, 22, 20, 17, 14, 14, 12, 11, 12, 11, 10, 38);
            }
        }
    }
}
