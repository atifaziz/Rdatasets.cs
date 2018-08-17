// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Rainforest Data
    /// </summary>

    public class rainforest
    {
        public readonly int dbh;
        public readonly string wood;
        public readonly string bark;
        public readonly string root;
        public readonly string rootsk;
        public readonly string branch;
        public readonly string species;

        public rainforest(int dbh, string wood, string bark, string root, string rootsk, string branch, string species)
        {
            this.dbh = dbh;
            this.wood = wood;
            this.bark = bark;
            this.root = root;
            this.rootsk = rootsk;
            this.branch = branch;
            this.species = species;
        }

        public static IEnumerable<rainforest> Data
        {
            get
            {
                yield return new rainforest(6, null, null, "6", "0.3", null, "Acacia mabellae");
                yield return new rainforest(23, "353", null, "135", "13", "35", "Acacia mabellae");
                yield return new rainforest(20, "208", null, null, null, "41", "Acacia mabellae");
                yield return new rainforest(23, "445", null, null, null, "50", "Acacia mabellae");
                yield return new rainforest(24, "590", null, null, null, null, "Acacia mabellae");
                yield return new rainforest(5, "14", null, "2", "2.4", null, "Acacia mabellae");
                yield return new rainforest(5, "10", null, null, null, null, "Acacia mabellae");
                yield return new rainforest(8, "31", null, null, null, null, "Acacia mabellae");
                yield return new rainforest(10, "59", null, null, null, null, "Acacia mabellae");
                yield return new rainforest(8, "30", null, "6", "1", "4", "Acacia mabellae");
                yield return new rainforest(22, "320", null, "51", "17", "30", "Acacia mabellae");
                yield return new rainforest(9, "20", null, "6", "1", "13", "Acacia mabellae");
                yield return new rainforest(10, "29", null, null, null, "10", "Acacia mabellae");
                yield return new rainforest(10, "35", null, "9", "2", "17", "Acacia mabellae");
                yield return new rainforest(19, "203", null, "16", "11", "46", "Acacia mabellae");
                yield return new rainforest(35, "1090", null, "66", "24", "92", "Acacia mabellae");
                yield return new rainforest(6, "10", null, null, null, "11", "C. fraseri");
                yield return new rainforest(4, "7", null, null, null, "6", "C. fraseri");
                yield return new rainforest(4, "3", null, null, null, "5", "C. fraseri");
                yield return new rainforest(6, "13", null, null, null, "5", "C. fraseri");
                yield return new rainforest(5, "9", null, null, null, "8", "C. fraseri");
                yield return new rainforest(8, "20", null, null, null, "9", "C. fraseri");
                yield return new rainforest(6, "16", null, null, null, "6", "C. fraseri");
                yield return new rainforest(5, "7", null, null, null, "8", "C. fraseri");
                yield return new rainforest(7, "29", null, null, null, "14", "C. fraseri");
                yield return new rainforest(5, "12", null, null, null, "8", "C. fraseri");
                yield return new rainforest(7, "25", null, null, null, "16", "C. fraseri");
                yield return new rainforest(6, "10", null, null, null, "9", "C. fraseri");
                yield return new rainforest(25, "506", null, null, null, "45", "Acmena smithii");
                yield return new rainforest(24, "508", null, null, null, "65", "Acmena smithii");
                yield return new rainforest(31, "817", null, null, null, "95", "Acmena smithii");
                yield return new rainforest(21, "274", null, null, null, "31", "Acmena smithii");
                yield return new rainforest(16, "162", null, null, null, "25", "Acmena smithii");
                yield return new rainforest(27, "540", null, null, null, "55", "Acmena smithii");
                yield return new rainforest(19, "272", null, null, null, "52", "Acmena smithii");
                yield return new rainforest(21, "293", null, null, null, null, "Acmena smithii");
                yield return new rainforest(10, "77", null, null, null, null, "Acmena smithii");
                yield return new rainforest(23, "408", null, null, null, null, "Acmena smithii");
                yield return new rainforest(27, "550", "105", "44", "9", "59", "B. myrtifolia");
                yield return new rainforest(26, "414", "78", "38", "13", "44", "B. myrtifolia");
                yield return new rainforest(9, "42", "8", "5", "1.3", "7", "B. myrtifolia");
                yield return new rainforest(12, "85", "13", "17", "2.2", "16", "B. myrtifolia");
                yield return new rainforest(9, "35", null, null, null, "9", "B. myrtifolia");
                yield return new rainforest(11, "60", null, null, null, "13", "B. myrtifolia");
                yield return new rainforest(10, "60", null, null, null, "12", "B. myrtifolia");
                yield return new rainforest(37, "1250", null, null, null, "76", "B. myrtifolia");
                yield return new rainforest(37, "990", null, null, null, "90", "B. myrtifolia");
                yield return new rainforest(20, "290", null, null, null, "36", "B. myrtifolia");
                yield return new rainforest(56, "1500", null, null, null, null, "B. myrtifolia");
                yield return new rainforest(9, "40", null, null, null, null, "Acmena smithii");
                yield return new rainforest(17, "216", null, null, null, "40", "Acmena smithii");
                yield return new rainforest(17, "208", null, null, null, null, "Acmena smithii");
                yield return new rainforest(10, "50", null, null, null, null, "Acmena smithii");
                yield return new rainforest(6, "18", null, null, null, null, "Acmena smithii");
                yield return new rainforest(22, "382", null, null, null, null, "Acmena smithii");
                yield return new rainforest(15, "161", null, null, null, null, "Acmena smithii");
                yield return new rainforest(15, "140", null, null, null, null, "Acmena smithii");
                yield return new rainforest(19, "280", null, null, null, null, "Acmena smithii");
                yield return new rainforest(11, "84", null, null, null, null, "Acmena smithii");
                yield return new rainforest(9, "50", null, null, null, null, "Acmena smithii");
                yield return new rainforest(25, "510", null, null, null, "45", "Acmena smithii");
                yield return new rainforest(22, "400", null, null, null, "35", "Acmena smithii");
                yield return new rainforest(10, "70", null, null, null, null, "Acmena smithii");
                yield return new rainforest(12, "115", null, null, null, null, "Acmena smithii");
                yield return new rainforest(48, "1530", null, null, null, "120", "Acmena smithii");
            }
        }
    }
}
