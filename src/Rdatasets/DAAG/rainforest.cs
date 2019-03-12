// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Rainforest Data
    /// </summary>

    public class rainforest
    {
        public readonly int κ;
        public readonly int dbh;
        public readonly int? wood;
        public readonly int? bark;
        public readonly int? root;
        public readonly double? rootsk;
        public readonly int? branch;
        public readonly string species;

        public rainforest(int κ, int dbh, int? wood, int? bark, int? root, double? rootsk, int? branch, string species)
        {
            this.κ = κ;
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
                yield return new rainforest(27, 6, null, null, 6, 0.3, null, "Acacia mabellae");
                yield return new rainforest(61, 23, 353, null, 135, 13, 35, "Acacia mabellae");
                yield return new rainforest(62, 20, 208, null, null, null, 41, "Acacia mabellae");
                yield return new rainforest(63, 23, 445, null, null, null, 50, "Acacia mabellae");
                yield return new rainforest(65, 24, 590, null, null, null, null, "Acacia mabellae");
                yield return new rainforest(80, 5, 14, null, 2, 2.4, null, "Acacia mabellae");
                yield return new rainforest(81, 5, 10, null, null, null, null, "Acacia mabellae");
                yield return new rainforest(82, 8, 31, null, null, null, null, "Acacia mabellae");
                yield return new rainforest(83, 10, 59, null, null, null, null, "Acacia mabellae");
                yield return new rainforest(84, 8, 30, null, 6, 1, 4, "Acacia mabellae");
                yield return new rainforest(95, 22, 320, null, 51, 17, 30, "Acacia mabellae");
                yield return new rainforest(96, 9, 20, null, 6, 1, 13, "Acacia mabellae");
                yield return new rainforest(97, 10, 29, null, null, null, 10, "Acacia mabellae");
                yield return new rainforest(98, 10, 35, null, 9, 2, 17, "Acacia mabellae");
                yield return new rainforest(99, 19, 203, null, 16, 11, 46, "Acacia mabellae");
                yield return new rainforest(100, 35, 1090, null, 66, 24, 92, "Acacia mabellae");
                yield return new rainforest(102, 6, 10, null, null, null, 11, "C. fraseri");
                yield return new rainforest(103, 4, 7, null, null, null, 6, "C. fraseri");
                yield return new rainforest(104, 4, 3, null, null, null, 5, "C. fraseri");
                yield return new rainforest(105, 6, 13, null, null, null, 5, "C. fraseri");
                yield return new rainforest(106, 5, 9, null, null, null, 8, "C. fraseri");
                yield return new rainforest(107, 8, 20, null, null, null, 9, "C. fraseri");
                yield return new rainforest(108, 6, 16, null, null, null, 6, "C. fraseri");
                yield return new rainforest(109, 5, 7, null, null, null, 8, "C. fraseri");
                yield return new rainforest(110, 7, 29, null, null, null, 14, "C. fraseri");
                yield return new rainforest(111, 5, 12, null, null, null, 8, "C. fraseri");
                yield return new rainforest(112, 7, 25, null, null, null, 16, "C. fraseri");
                yield return new rainforest(113, 6, 10, null, null, null, 9, "C. fraseri");
                yield return new rainforest(114, 25, 506, null, null, null, 45, "Acmena smithii");
                yield return new rainforest(115, 24, 508, null, null, null, 65, "Acmena smithii");
                yield return new rainforest(116, 31, 817, null, null, null, 95, "Acmena smithii");
                yield return new rainforest(117, 21, 274, null, null, null, 31, "Acmena smithii");
                yield return new rainforest(118, 16, 162, null, null, null, 25, "Acmena smithii");
                yield return new rainforest(119, 27, 540, null, null, null, 55, "Acmena smithii");
                yield return new rainforest(120, 19, 272, null, null, null, 52, "Acmena smithii");
                yield return new rainforest(121, 21, 293, null, null, null, null, "Acmena smithii");
                yield return new rainforest(122, 10, 77, null, null, null, null, "Acmena smithii");
                yield return new rainforest(123, 23, 408, null, null, null, null, "Acmena smithii");
                yield return new rainforest(124, 27, 550, 105, 44, 9, 59, "B. myrtifolia");
                yield return new rainforest(125, 26, 414, 78, 38, 13, 44, "B. myrtifolia");
                yield return new rainforest(126, 9, 42, 8, 5, 1.3, 7, "B. myrtifolia");
                yield return new rainforest(127, 12, 85, 13, 17, 2.2, 16, "B. myrtifolia");
                yield return new rainforest(128, 9, 35, null, null, null, 9, "B. myrtifolia");
                yield return new rainforest(129, 11, 60, null, null, null, 13, "B. myrtifolia");
                yield return new rainforest(130, 10, 60, null, null, null, 12, "B. myrtifolia");
                yield return new rainforest(131, 37, 1250, null, null, null, 76, "B. myrtifolia");
                yield return new rainforest(132, 37, 990, null, null, null, 90, "B. myrtifolia");
                yield return new rainforest(133, 20, 290, null, null, null, 36, "B. myrtifolia");
                yield return new rainforest(134, 56, 1500, null, null, null, null, "B. myrtifolia");
                yield return new rainforest(135, 9, 40, null, null, null, null, "Acmena smithii");
                yield return new rainforest(136, 17, 216, null, null, null, 40, "Acmena smithii");
                yield return new rainforest(137, 17, 208, null, null, null, null, "Acmena smithii");
                yield return new rainforest(138, 10, 50, null, null, null, null, "Acmena smithii");
                yield return new rainforest(139, 6, 18, null, null, null, null, "Acmena smithii");
                yield return new rainforest(140, 22, 382, null, null, null, null, "Acmena smithii");
                yield return new rainforest(141, 15, 161, null, null, null, null, "Acmena smithii");
                yield return new rainforest(142, 15, 140, null, null, null, null, "Acmena smithii");
                yield return new rainforest(143, 19, 280, null, null, null, null, "Acmena smithii");
                yield return new rainforest(144, 11, 84, null, null, null, null, "Acmena smithii");
                yield return new rainforest(145, 9, 50, null, null, null, null, "Acmena smithii");
                yield return new rainforest(146, 25, 510, null, null, null, 45, "Acmena smithii");
                yield return new rainforest(147, 22, 400, null, null, null, 35, "Acmena smithii");
                yield return new rainforest(148, 10, 70, null, null, null, null, "Acmena smithii");
                yield return new rainforest(149, 12, 115, null, null, null, null, "Acmena smithii");
                yield return new rainforest(150, 48, 1530, null, null, null, 120, "Acmena smithii");
            }
        }
    }
}
