// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Sparrows
    /// </summary>

    public class Sparrows
    {
        public readonly int κ;
        public readonly string Treatment;
        public readonly double Weight;
        public readonly double WingLength;

        public Sparrows(int κ, string Treatment, double Weight, double WingLength)
        {
            this.κ = κ;
            this.Treatment = Treatment;
            this.Weight = Weight;
            this.WingLength = WingLength;
        }

        public static IEnumerable<Sparrows> Data
        {
            get
            {
                yield return new Sparrows(1, "control", 14.9, 29);
                yield return new Sparrows(2, "control", 15, 31);
                yield return new Sparrows(3, "control", 14.3, 25);
                yield return new Sparrows(4, "control", 17, 29);
                yield return new Sparrows(5, "control", 16, 30);
                yield return new Sparrows(6, "control", 16.2, 31.5);
                yield return new Sparrows(7, "control", 12.4, 23.5);
                yield return new Sparrows(8, "control", 14.6, 26);
                yield return new Sparrows(9, "control", 12.2, 25.5);
                yield return new Sparrows(10, "control", 13, 27);
                yield return new Sparrows(11, "control", 12.9, 29.5);
                yield return new Sparrows(12, "control", 13.2, 27.5);
                yield return new Sparrows(13, "control", 13.6, 29.5);
                yield return new Sparrows(14, "control", 16.2, 31);
                yield return new Sparrows(15, "control", 15, 29.5);
                yield return new Sparrows(16, "control", 17.5, 30.5);
                yield return new Sparrows(17, "control", 14.8, 26.5);
                yield return new Sparrows(18, "control", 15.7, 28);
                yield return new Sparrows(19, "control", 15.5, 29);
                yield return new Sparrows(20, "control", 14.4, 23);
                yield return new Sparrows(21, "control", 16, 24);
                yield return new Sparrows(22, "control", 13.5, 23);
                yield return new Sparrows(23, "control", 13.2, 24.5);
                yield return new Sparrows(24, "control", 15.6, 31);
                yield return new Sparrows(25, "control", 15.1, 31);
                yield return new Sparrows(26, "control", 16.6, 30);
                yield return new Sparrows(27, "control", 10.1, 23);
                yield return new Sparrows(28, "control", 13.1, 25.5);
                yield return new Sparrows(29, "control", 15.1, 29);
                yield return new Sparrows(30, "control", 14.2, 29.5);
                yield return new Sparrows(31, "control", 13.3, 28.5);
                yield return new Sparrows(32, "control", 12.2, 26);
                yield return new Sparrows(33, "control", 13.4, 29.5);
                yield return new Sparrows(34, "control", 12.4, 26);
                yield return new Sparrows(35, "control", 14.3, 28);
                yield return new Sparrows(36, "control", 15.9, 32.5);
                yield return new Sparrows(37, "control", 12.8, 26.5);
                yield return new Sparrows(38, "control", 11.9, 24);
                yield return new Sparrows(39, "control", 12.2, 18);
                yield return new Sparrows(40, "control", 14.8, 27);
                yield return new Sparrows(41, "control", 14.9, 26.5);
                yield return new Sparrows(42, "control", 10.2, 23);
                yield return new Sparrows(43, "control", 18.5, 32);
                yield return new Sparrows(44, "control", 7.6, 15);
                yield return new Sparrows(45, "control", 5.3, 16);
                yield return new Sparrows(46, "enlarged", 14.2, 28.5);
                yield return new Sparrows(47, "enlarged", 14.4, 29);
                yield return new Sparrows(48, "enlarged", 13.4, 32.5);
                yield return new Sparrows(49, "enlarged", 11.3, 26);
                yield return new Sparrows(50, "enlarged", 13.2, 29.5);
                yield return new Sparrows(51, "enlarged", 12.2, 26);
                yield return new Sparrows(52, "enlarged", 14.4, 30.5);
                yield return new Sparrows(53, "enlarged", 13.4, 27.5);
                yield return new Sparrows(54, "enlarged", 13.1, 30.5);
                yield return new Sparrows(55, "enlarged", 13.9, 28.5);
                yield return new Sparrows(56, "enlarged", 13.5, 29.5);
                yield return new Sparrows(57, "enlarged", 15, 30);
                yield return new Sparrows(58, "enlarged", 11.8, 26);
                yield return new Sparrows(59, "enlarged", 12, 24);
                yield return new Sparrows(60, "enlarged", 9.5, 24);
                yield return new Sparrows(61, "enlarged", 14, 25.5);
                yield return new Sparrows(62, "enlarged", 10, 24);
                yield return new Sparrows(63, "enlarged", 13.7, 27.5);
                yield return new Sparrows(64, "enlarged", 15.3, 30);
                yield return new Sparrows(65, "enlarged", 17.3, 32);
                yield return new Sparrows(66, "enlarged", 14.4, 31.5);
                yield return new Sparrows(67, "enlarged", 15.8, 30.5);
                yield return new Sparrows(68, "enlarged", 17.1, 32);
                yield return new Sparrows(69, "enlarged", 10.7, 19.5);
                yield return new Sparrows(70, "enlarged", 12.1, 19.5);
                yield return new Sparrows(71, "enlarged", 12.7, 20);
                yield return new Sparrows(72, "enlarged", 13.2, 20);
                yield return new Sparrows(73, "enlarged", 13.6, 19.5);
                yield return new Sparrows(74, "enlarged", 9.4, 20);
                yield return new Sparrows(75, "enlarged", 15.9, 29.5);
                yield return new Sparrows(76, "enlarged", 12.7, 26.5);
                yield return new Sparrows(77, "enlarged", 13.6, 26.5);
                yield return new Sparrows(78, "enlarged", 15.1, 28.5);
                yield return new Sparrows(79, "enlarged", 15.3, 30.5);
                yield return new Sparrows(80, "enlarged", 14.2, 30);
                yield return new Sparrows(81, "enlarged", 8.3, 18.5);
                yield return new Sparrows(82, "enlarged", 15.5, 31);
                yield return new Sparrows(83, "enlarged", 15.6, 30);
                yield return new Sparrows(84, "enlarged", 15.4, 29);
                yield return new Sparrows(85, "enlarged", 14.9, 28.5);
                yield return new Sparrows(86, "enlarged", 13.5, 26);
                yield return new Sparrows(87, "enlarged", 15.8, 28);
                yield return new Sparrows(88, "enlarged", 13.7, 29);
                yield return new Sparrows(89, "enlarged", 15.4, 29.5);
                yield return new Sparrows(90, "enlarged", 8.7, 21);
                yield return new Sparrows(91, "reduced", 16, 30);
                yield return new Sparrows(92, "reduced", 15.8, 31);
                yield return new Sparrows(93, "reduced", 16.6, 31);
                yield return new Sparrows(94, "reduced", 17.2, 32.5);
                yield return new Sparrows(95, "reduced", 16.8, 29.5);
                yield return new Sparrows(96, "reduced", 16.7, 30.5);
                yield return new Sparrows(97, "reduced", 16.2, 28.5);
                yield return new Sparrows(98, "reduced", 17.1, 29);
                yield return new Sparrows(99, "reduced", 13, 24);
                yield return new Sparrows(100, "reduced", 13.4, 24.5);
                yield return new Sparrows(101, "reduced", 13.3, 22.5);
                yield return new Sparrows(102, "reduced", 15.5, 27.5);
                yield return new Sparrows(103, "reduced", 16.4, 27.5);
                yield return new Sparrows(104, "reduced", 15.4, 29.5);
                yield return new Sparrows(105, "reduced", 16.1, 29);
                yield return new Sparrows(106, "reduced", 16.8, 30.5);
                yield return new Sparrows(107, "reduced", 15.7, 29);
                yield return new Sparrows(108, "reduced", 15.8, 27.5);
                yield return new Sparrows(109, "reduced", 17, 32);
                yield return new Sparrows(110, "reduced", 16.8, 34);
                yield return new Sparrows(111, "reduced", 15.5, 29.5);
                yield return new Sparrows(112, "reduced", 12.6, 25);
                yield return new Sparrows(113, "reduced", 14.3, 26);
                yield return new Sparrows(114, "reduced", 12.5, 26);
                yield return new Sparrows(115, "reduced", 16.7, 29);
                yield return new Sparrows(116, "reduced", 15.6, 28);
            }
        }
    }
}
