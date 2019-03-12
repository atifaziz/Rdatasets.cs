// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Canadian Interprovincial Migration Data
    /// </summary>

    public class Migration
    {
        public readonly int κ;
        public readonly string source;
        public readonly string destination;
        public readonly int migrants;
        public readonly int distance;
        public readonly int pops66;
        public readonly int pops71;
        public readonly int popd66;
        public readonly int popd71;

        public Migration(int κ, string source, string destination, int migrants, int distance, int pops66, int pops71, int popd66, int popd71)
        {
            this.κ = κ;
            this.source = source;
            this.destination = destination;
            this.migrants = migrants;
            this.distance = distance;
            this.pops66 = pops66;
            this.pops71 = pops71;
            this.popd66 = popd66;
            this.popd71 = popd71;
        }

        public static IEnumerable<Migration> Data
        {
            get
            {
                yield return new Migration(1, "PEI", "NFLD", 255, 924, 108535, 111641, 493396, 522104);
                yield return new Migration(2, "NS", "NFLD", 2380, 952, 756039, 788960, 493396, 522104);
                yield return new Migration(3, "NB", "NFLD", 1140, 1119, 616788, 534557, 493396, 522104);
                yield return new Migration(4, "QUE", "NFLD", 2145, 1641, 5780845, 6027764, 493396, 522104);
                yield return new Migration(5, "ONT", "NFLD", 6295, 1996, 6960870, 7703106, 493396, 522104);
                yield return new Migration(6, "MAN", "NFLD", 215, 3159, 963066, 988247, 493396, 522104);
                yield return new Migration(7, "SASK", "NFLD", 185, 3542, 955344, 926242, 493396, 522104);
                yield return new Migration(8, "ALTA", "NFLD", 425, 4059, 1463203, 1627874, 493396, 522104);
                yield return new Migration(9, "BC", "NFLD", 425, 4838, 1873674, 2184621, 493396, 522104);
                yield return new Migration(10, "NFLD", "PEI", 340, 924, 493396, 522104, 108535, 111641);
                yield return new Migration(11, "NS", "PEI", 1975, 164, 756039, 788960, 108535, 111641);
                yield return new Migration(12, "NB", "PEI", 1310, 252, 616788, 534557, 108535, 111641);
                yield return new Migration(13, "QUE", "PEI", 755, 774, 5780845, 6027764, 108535, 111641);
                yield return new Migration(14, "ONT", "PEI", 3060, 1129, 6960870, 7703106, 108535, 111641);
                yield return new Migration(15, "MAN", "PEI", 400, 2293, 963066, 988247, 108535, 111641);
                yield return new Migration(16, "SASK", "PEI", 95, 2675, 955344, 926242, 108535, 111641);
                yield return new Migration(17, "ALTA", "PEI", 185, 3192, 1463203, 1627874, 108535, 111641);
                yield return new Migration(18, "BC", "PEI", 330, 3972, 1873674, 2184621, 108535, 111641);
                yield return new Migration(19, "NFLD", "NS", 3340, 952, 493396, 522104, 756039, 788960);
                yield return new Migration(20, "PEI", "NS", 2185, 164, 108535, 111641, 756039, 788960);
                yield return new Migration(21, "NB", "NS", 8310, 310, 616788, 534557, 756039, 788960);
                yield return new Migration(22, "QUE", "NS", 6090, 832, 5780845, 6027764, 756039, 788960);
                yield return new Migration(23, "ONT", "NS", 18805, 1187, 6960870, 7703106, 756039, 788960);
                yield return new Migration(24, "MAN", "NS", 1825, 2351, 963066, 988247, 756039, 788960);
                yield return new Migration(25, "SASK", "NS", 840, 2733, 955344, 926242, 756039, 788960);
                yield return new Migration(26, "ALTA", "NS", 2000, 3250, 1463203, 1627874, 756039, 788960);
                yield return new Migration(27, "BC", "NS", 2490, 4029, 1873674, 2184621, 756039, 788960);
                yield return new Migration(28, "NFLD", "NB", 1740, 1119, 493396, 522104, 616788, 534557);
                yield return new Migration(29, "PEI", "NB", 1335, 252, 108535, 111641, 616788, 534557);
                yield return new Migration(30, "NS", "NB", 7635, 310, 756039, 788960, 616788, 534557);
                yield return new Migration(31, "QUE", "NB", 9315, 522, 5780845, 6027764, 616788, 534557);
                yield return new Migration(32, "ONT", "NB", 12455, 877, 6960870, 7703106, 616788, 534557);
                yield return new Migration(33, "MAN", "NB", 1405, 2041, 963066, 988247, 616788, 534557);
                yield return new Migration(34, "SASK", "NB", 480, 2423, 955344, 926242, 616788, 534557);
                yield return new Migration(35, "ALTA", "NB", 1130, 2940, 1463203, 1627874, 616788, 534557);
                yield return new Migration(36, "BC", "NB", 1195, 3719, 1873674, 2184621, 616788, 534557);
                yield return new Migration(37, "NFLD", "QUE", 2235, 1641, 493396, 522104, 5780845, 6027764);
                yield return new Migration(38, "PEI", "QUE", 635, 774, 108535, 111641, 5780845, 6027764);
                yield return new Migration(39, "NS", "QUE", 4350, 832, 756039, 788960, 5780845, 6027764);
                yield return new Migration(40, "NB", "QUE", 7905, 522, 616788, 534557, 5780845, 6027764);
                yield return new Migration(41, "ONT", "QUE", 48370, 355, 6960870, 7703106, 5780845, 6027764);
                yield return new Migration(42, "MAN", "QUE", 4630, 1519, 963066, 988247, 5780845, 6027764);
                yield return new Migration(43, "SASK", "QUE", 1515, 1901, 955344, 926242, 5780845, 6027764);
                yield return new Migration(44, "ALTA", "QUE", 3305, 2418, 1463203, 1627874, 5780845, 6027764);
                yield return new Migration(45, "BC", "QUE", 4740, 3197, 1873674, 2184621, 5780845, 6027764);
                yield return new Migration(46, "NFLD", "ONT", 17860, 1996, 493396, 522104, 6960870, 7703106);
                yield return new Migration(47, "PEI", "ONT", 3570, 1129, 108535, 111641, 6960870, 7703106);
                yield return new Migration(48, "NS", "ONT", 25730, 1187, 756039, 788960, 6960870, 7703106);
                yield return new Migration(49, "NB", "ONT", 18550, 877, 616788, 534557, 6960870, 7703106);
                yield return new Migration(50, "QUE", "ONT", 99430, 355, 5780845, 6027764, 6960870, 7703106);
                yield return new Migration(51, "MAN", "ONT", 23785, 1380, 963066, 988247, 6960870, 7703106);
                yield return new Migration(52, "SASK", "ONT", 11805, 1763, 955344, 926242, 6960870, 7703106);
                yield return new Migration(53, "ALTA", "ONT", 17655, 2281, 1463203, 1627874, 6960870, 7703106);
                yield return new Migration(54, "BC", "ONT", 21205, 3059, 1873674, 2184621, 6960870, 7703106);
                yield return new Migration(55, "NFLD", "MAN", 680, 3159, 493396, 522104, 963066, 988247);
                yield return new Migration(56, "PEI", "MAN", 265, 2293, 108535, 111641, 963066, 988247);
                yield return new Migration(57, "NS", "MAN", 1655, 2351, 756039, 788960, 963066, 988247);
                yield return new Migration(58, "NB", "MAN", 1355, 2041, 616788, 534557, 963066, 988247);
                yield return new Migration(59, "QUE", "MAN", 4330, 1519, 5780845, 6027764, 963066, 988247);
                yield return new Migration(60, "ONT", "MAN", 18245, 1380, 6960870, 7703106, 963066, 988247);
                yield return new Migration(61, "SASK", "MAN", 16365, 382, 955344, 926242, 963066, 988247);
                yield return new Migration(62, "ALTA", "MAN", 7190, 899, 1463203, 1627874, 963066, 988247);
                yield return new Migration(63, "BC", "MAN", 6310, 1679, 1873674, 2184621, 963066, 988247);
                yield return new Migration(64, "NFLD", "SASK", 280, 3542, 493396, 522104, 955344, 926242);
                yield return new Migration(65, "PEI", "SASK", 125, 2675, 108535, 111641, 955344, 926242);
                yield return new Migration(66, "NS", "SASK", 620, 2733, 756039, 788960, 955344, 926242);
                yield return new Migration(67, "NB", "SASK", 495, 2423, 616788, 534557, 955344, 926242);
                yield return new Migration(68, "QUE", "SASK", 1570, 1901, 5780845, 6027764, 955344, 926242);
                yield return new Migration(69, "ONT", "SASK", 6845, 1763, 6960870, 7703106, 955344, 926242);
                yield return new Migration(70, "MAN", "SASK", 9425, 382, 963066, 988247, 955344, 926242);
                yield return new Migration(71, "ALTA", "SASK", 10580, 517, 1463203, 1627874, 955344, 926242);
                yield return new Migration(72, "BC", "SASK", 6090, 1297, 1873674, 2184621, 955344, 926242);
                yield return new Migration(73, "NFLD", "ALTA", 805, 4059, 493396, 522104, 1463203, 1627874);
                yield return new Migration(74, "PEI", "ALTA", 505, 3192, 108535, 111641, 1463203, 1627874);
                yield return new Migration(75, "NS", "ALTA", 3300, 3250, 756039, 788960, 1463203, 1627874);
                yield return new Migration(76, "NB", "ALTA", 2150, 2940, 616788, 534557, 1463203, 1627874);
                yield return new Migration(77, "QUE", "ALTA", 7750, 2418, 5780845, 6027764, 1463203, 1627874);
                yield return new Migration(78, "ONT", "ALTA", 23550, 2281, 6960870, 7703106, 1463203, 1627874);
                yield return new Migration(79, "MAN", "ALTA", 17410, 899, 963066, 988247, 1463203, 1627874);
                yield return new Migration(80, "SASK", "ALTA", 41910, 517, 955344, 926242, 1463203, 1627874);
                yield return new Migration(81, "BC", "ALTA", 27765, 987, 1873674, 2184621, 1463203, 1627874);
                yield return new Migration(82, "NFLD", "BC", 1455, 4838, 493396, 522104, 1873674, 2184621);
                yield return new Migration(83, "PEI", "BC", 600, 3972, 108535, 111641, 1873674, 2184621);
                yield return new Migration(84, "NS", "BC", 6075, 4029, 756039, 788960, 1873674, 2184621);
                yield return new Migration(85, "NB", "BC", 3115, 3719, 616788, 534557, 1873674, 2184621);
                yield return new Migration(86, "QUE", "BC", 16740, 3197, 5780845, 6027764, 1873674, 2184621);
                yield return new Migration(87, "ONT", "BC", 47395, 3059, 6960870, 7703106, 1873674, 2184621);
                yield return new Migration(88, "MAN", "BC", 26910, 1679, 963066, 988247, 1873674, 2184621);
                yield return new Migration(89, "SASK", "BC", 29920, 1297, 955344, 926242, 1873674, 2184621);
                yield return new Migration(90, "ALTA", "BC", 58915, 987, 1463203, 1627874, 1873674, 2184621);
            }
        }
    }
}
