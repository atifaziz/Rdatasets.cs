// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Snail Mortality Data
    /// </summary>

    public class snails
    {
        public readonly int κ;
        public readonly string Species;
        public readonly int Exposure;
        public readonly double Rel_Hum;
        public readonly int Temp;
        public readonly int Deaths;
        public readonly int N;

        public snails(int κ, string Species, int Exposure, double Rel_Hum, int Temp, int Deaths, int N)
        {
            this.κ = κ;
            this.Species = Species;
            this.Exposure = Exposure;
            this.Rel_Hum = Rel_Hum;
            this.Temp = Temp;
            this.Deaths = Deaths;
            this.N = N;
        }

        public static IEnumerable<snails> Data
        {
            get
            {
                yield return new snails(1, "A", 1, 60, 10, 0, 20);
                yield return new snails(2, "A", 1, 60, 15, 0, 20);
                yield return new snails(3, "A", 1, 60, 20, 0, 20);
                yield return new snails(4, "A", 1, 65.8, 10, 0, 20);
                yield return new snails(5, "A", 1, 65.8, 15, 0, 20);
                yield return new snails(6, "A", 1, 65.8, 20, 0, 20);
                yield return new snails(7, "A", 1, 70.5, 10, 0, 20);
                yield return new snails(8, "A", 1, 70.5, 15, 0, 20);
                yield return new snails(9, "A", 1, 70.5, 20, 0, 20);
                yield return new snails(10, "A", 1, 75.8, 10, 0, 20);
                yield return new snails(11, "A", 1, 75.8, 15, 0, 20);
                yield return new snails(12, "A", 1, 75.8, 20, 0, 20);
                yield return new snails(13, "A", 2, 60, 10, 0, 20);
                yield return new snails(14, "A", 2, 60, 15, 1, 20);
                yield return new snails(15, "A", 2, 60, 20, 1, 20);
                yield return new snails(16, "A", 2, 65.8, 10, 0, 20);
                yield return new snails(17, "A", 2, 65.8, 15, 1, 20);
                yield return new snails(18, "A", 2, 65.8, 20, 0, 20);
                yield return new snails(19, "A", 2, 70.5, 10, 0, 20);
                yield return new snails(20, "A", 2, 70.5, 15, 0, 20);
                yield return new snails(21, "A", 2, 70.5, 20, 0, 20);
                yield return new snails(22, "A", 2, 75.8, 10, 0, 20);
                yield return new snails(23, "A", 2, 75.8, 15, 0, 20);
                yield return new snails(24, "A", 2, 75.8, 20, 0, 20);
                yield return new snails(25, "A", 3, 60, 10, 1, 20);
                yield return new snails(26, "A", 3, 60, 15, 4, 20);
                yield return new snails(27, "A", 3, 60, 20, 5, 20);
                yield return new snails(28, "A", 3, 65.8, 10, 0, 20);
                yield return new snails(29, "A", 3, 65.8, 15, 2, 20);
                yield return new snails(30, "A", 3, 65.8, 20, 4, 20);
                yield return new snails(31, "A", 3, 70.5, 10, 0, 20);
                yield return new snails(32, "A", 3, 70.5, 15, 2, 20);
                yield return new snails(33, "A", 3, 70.5, 20, 3, 20);
                yield return new snails(34, "A", 3, 75.8, 10, 0, 20);
                yield return new snails(35, "A", 3, 75.8, 15, 1, 20);
                yield return new snails(36, "A", 3, 75.8, 20, 2, 20);
                yield return new snails(37, "A", 4, 60, 10, 7, 20);
                yield return new snails(38, "A", 4, 60, 15, 7, 20);
                yield return new snails(39, "A", 4, 60, 20, 7, 20);
                yield return new snails(40, "A", 4, 65.8, 10, 4, 20);
                yield return new snails(41, "A", 4, 65.8, 15, 4, 20);
                yield return new snails(42, "A", 4, 65.8, 20, 7, 20);
                yield return new snails(43, "A", 4, 70.5, 10, 3, 20);
                yield return new snails(44, "A", 4, 70.5, 15, 3, 20);
                yield return new snails(45, "A", 4, 70.5, 20, 5, 20);
                yield return new snails(46, "A", 4, 75.8, 10, 2, 20);
                yield return new snails(47, "A", 4, 75.8, 15, 3, 20);
                yield return new snails(48, "A", 4, 75.8, 20, 3, 20);
                yield return new snails(49, "B", 1, 60, 10, 0, 20);
                yield return new snails(50, "B", 1, 60, 15, 0, 20);
                yield return new snails(51, "B", 1, 60, 20, 0, 20);
                yield return new snails(52, "B", 1, 65.8, 10, 0, 20);
                yield return new snails(53, "B", 1, 65.8, 15, 0, 20);
                yield return new snails(54, "B", 1, 65.8, 20, 0, 20);
                yield return new snails(55, "B", 1, 70.5, 10, 0, 20);
                yield return new snails(56, "B", 1, 70.5, 15, 0, 20);
                yield return new snails(57, "B", 1, 70.5, 20, 0, 20);
                yield return new snails(58, "B", 1, 75.8, 10, 0, 20);
                yield return new snails(59, "B", 1, 75.8, 15, 0, 20);
                yield return new snails(60, "B", 1, 75.8, 20, 0, 20);
                yield return new snails(61, "B", 2, 60, 10, 0, 20);
                yield return new snails(62, "B", 2, 60, 15, 3, 20);
                yield return new snails(63, "B", 2, 60, 20, 2, 20);
                yield return new snails(64, "B", 2, 65.8, 10, 0, 20);
                yield return new snails(65, "B", 2, 65.8, 15, 2, 20);
                yield return new snails(66, "B", 2, 65.8, 20, 1, 20);
                yield return new snails(67, "B", 2, 70.5, 10, 0, 20);
                yield return new snails(68, "B", 2, 70.5, 15, 0, 20);
                yield return new snails(69, "B", 2, 70.5, 20, 1, 20);
                yield return new snails(70, "B", 2, 75.8, 10, 1, 20);
                yield return new snails(71, "B", 2, 75.8, 15, 0, 20);
                yield return new snails(72, "B", 2, 75.8, 20, 1, 20);
                yield return new snails(73, "B", 3, 60, 10, 7, 20);
                yield return new snails(74, "B", 3, 60, 15, 11, 20);
                yield return new snails(75, "B", 3, 60, 20, 11, 20);
                yield return new snails(76, "B", 3, 65.8, 10, 4, 20);
                yield return new snails(77, "B", 3, 65.8, 15, 5, 20);
                yield return new snails(78, "B", 3, 65.8, 20, 9, 20);
                yield return new snails(79, "B", 3, 70.5, 10, 2, 20);
                yield return new snails(80, "B", 3, 70.5, 15, 4, 20);
                yield return new snails(81, "B", 3, 70.5, 20, 6, 20);
                yield return new snails(82, "B", 3, 75.8, 10, 2, 20);
                yield return new snails(83, "B", 3, 75.8, 15, 3, 20);
                yield return new snails(84, "B", 3, 75.8, 20, 5, 20);
                yield return new snails(85, "B", 4, 60, 10, 12, 20);
                yield return new snails(86, "B", 4, 60, 15, 14, 20);
                yield return new snails(87, "B", 4, 60, 20, 16, 20);
                yield return new snails(88, "B", 4, 65.8, 10, 10, 20);
                yield return new snails(89, "B", 4, 65.8, 15, 12, 20);
                yield return new snails(90, "B", 4, 65.8, 20, 12, 20);
                yield return new snails(91, "B", 4, 70.5, 10, 5, 20);
                yield return new snails(92, "B", 4, 70.5, 15, 7, 20);
                yield return new snails(93, "B", 4, 70.5, 20, 9, 20);
                yield return new snails(94, "B", 4, 75.8, 10, 4, 20);
                yield return new snails(95, "B", 4, 75.8, 15, 5, 20);
                yield return new snails(96, "B", 4, 75.8, 20, 7, 20);
            }
        }
    }
}
