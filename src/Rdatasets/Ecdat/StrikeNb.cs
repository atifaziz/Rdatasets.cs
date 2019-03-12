// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Number of Strikes in Us Manufacturing
    /// </summary>

    public class StrikeNb
    {
        public readonly int κ;
        public readonly int strikes;
        public readonly string output;
        public readonly int time;

        public StrikeNb(int κ, int strikes, string output, int time)
        {
            this.κ = κ;
            this.strikes = strikes;
            this.output = output;
            this.time = time;
        }

        public static IEnumerable<StrikeNb> Data
        {
            get
            {
                yield return new StrikeNb(1, 5, "0.01517", 1);
                yield return new StrikeNb(2, 4, "0.00997", 2);
                yield return new StrikeNb(3, 6, "0.0117", 3);
                yield return new StrikeNb(4, 16, "0.00473", 4);
                yield return new StrikeNb(5, 5, "0.01277", 5);
                yield return new StrikeNb(6, 8, "0.01138", 6);
                yield return new StrikeNb(7, 8, "0.00424", 7);
                yield return new StrikeNb(8, 9, "-0.00687", 8);
                yield return new StrikeNb(9, 10, "-0.00023", 9);
                yield return new StrikeNb(10, 10, "0.00791", 10);
                yield return new StrikeNb(11, 7, "0.02538", 11);
                yield return new StrikeNb(12, 1, "0.02939", 12);
                yield return new StrikeNb(13, 6, "0.03927", 13);
                yield return new StrikeNb(14, 5, "0.0371", 14);
                yield return new StrikeNb(15, 6, "0.04186", 15);
                yield return new StrikeNb(16, 5, "0.03156", 16);
                yield return new StrikeNb(17, 13, "0.0218", 17);
                yield return new StrikeNb(18, 6, "0.0229", 18);
                yield return new StrikeNb(19, 10, "0.02057", 19);
                yield return new StrikeNb(20, 13, "0.02191", 20);
                yield return new StrikeNb(21, 4, "0.02094", 21);
                yield return new StrikeNb(22, 8, "0.02171", 22);
                yield return new StrikeNb(23, 5, "0.01298", 23);
                yield return new StrikeNb(24, 0, "0.00515", 24);
                yield return new StrikeNb(25, 2, "-0.00268", 25);
                yield return new StrikeNb(26, 2, "-0.00987", 26);
                yield return new StrikeNb(27, 2, "-0.01491", 27);
                yield return new StrikeNb(28, 8, "-0.02361", 28);
                yield return new StrikeNb(29, 4, "-0.03252", 29);
                yield return new StrikeNb(30, 11, "-0.03957", 30);
                yield return new StrikeNb(31, 4, "-0.04163", 31);
                yield return new StrikeNb(32, 8, "-0.05107", 32);
                yield return new StrikeNb(33, 9, "-0.06215", 33);
                yield return new StrikeNb(34, 9, "-0.08626", 34);
                yield return new StrikeNb(35, 4, "-0.09308", 35);
                yield return new StrikeNb(36, 0, "-0.07042", 36);
                yield return new StrikeNb(37, 9, "-0.04777", 37);
                yield return new StrikeNb(38, 8, "-0.05161", 38);
                yield return new StrikeNb(39, 5, "-0.05473", 39);
                yield return new StrikeNb(40, 5, "-0.05417", 40);
                yield return new StrikeNb(41, 10, "-0.05196", 41);
                yield return new StrikeNb(42, 3, "-0.05467", 42);
                yield return new StrikeNb(43, 5, "-0.06169", 43);
                yield return new StrikeNb(44, 4, "-0.06945", 44);
                yield return new StrikeNb(45, 6, "-0.05824", 45);
                yield return new StrikeNb(46, 6, "-0.04592", 46);
                yield return new StrikeNb(47, 5, "-0.0461", 47);
                yield return new StrikeNb(48, 1, "-0.03983", 48);
                yield return new StrikeNb(49, 2, "-0.01353", 49);
                yield return new StrikeNb(50, 2, "-0.00784", 50);
                yield return new StrikeNb(51, 2, "-0.00354", 51);
                yield return new StrikeNb(52, 2, "0.01303", 52);
                yield return new StrikeNb(53, 4, "0.00513", 53);
                yield return new StrikeNb(54, 3, "0.00535", 54);
                yield return new StrikeNb(55, 2, "-0.00426", 55);
                yield return new StrikeNb(56, 3, "0.01355", 56);
                yield return new StrikeNb(57, 1, "0.02125", 57);
                yield return new StrikeNb(58, 2, "0.03531", 58);
                yield return new StrikeNb(59, 0, "0.04591", 59);
                yield return new StrikeNb(60, 1, "0.0565", 60);
                yield return new StrikeNb(61, 1, "0.06344", 61);
                yield return new StrikeNb(62, 1, "0.07687", 62);
                yield return new StrikeNb(63, 1, "0.07902", 63);
                yield return new StrikeNb(64, 5, "0.07602", 64);
                yield return new StrikeNb(65, 7, "0.07744", 65);
                yield return new StrikeNb(66, 2, "0.07427", 66);
                yield return new StrikeNb(67, 9, "0.07816", 67);
                yield return new StrikeNb(68, 3, "0.07036", 68);
                yield return new StrikeNb(69, 6, "0.07217", 69);
                yield return new StrikeNb(70, 9, "0.07773", 70);
                yield return new StrikeNb(71, 3, "0.08554", 71);
                yield return new StrikeNb(72, 3, "0.07418", 72);
                yield return new StrikeNb(73, 5, "0.07053", 73);
                yield return new StrikeNb(74, 9, "0.06554", 74);
                yield return new StrikeNb(75, 10, "0.06753", 75);
                yield return new StrikeNb(76, 9, "0.06072", 76);
                yield return new StrikeNb(77, 15, "0.06508", 77);
                yield return new StrikeNb(78, 18, "0.0645", 78);
                yield return new StrikeNb(79, 13, "0.06319", 79);
                yield return new StrikeNb(80, 10, "0.05579", 80);
                yield return new StrikeNb(81, 9, "0.05197", 81);
                yield return new StrikeNb(82, 7, "0.03458", 82);
                yield return new StrikeNb(83, 7, "-0.00225", 83);
                yield return new StrikeNb(84, 0, "-0.04998", 84);
                yield return new StrikeNb(85, 3, "-0.09771", 85);
                yield return new StrikeNb(86, 3, "-0.12124", 86);
                yield return new StrikeNb(87, 4, "-0.13996", 87);
                yield return new StrikeNb(88, 2, "-0.1259", 88);
                yield return new StrikeNb(89, 1, "-0.12224", 89);
                yield return new StrikeNb(90, 2, "-0.10443", 90);
                yield return new StrikeNb(91, 2, "-0.08656", 91);
                yield return new StrikeNb(92, 3, "-0.06279", 92);
                yield return new StrikeNb(93, 0, "-0.06034", 93);
                yield return new StrikeNb(94, 5, "-0.0579", 94);
                yield return new StrikeNb(95, 5, "-0.04919", 95);
                yield return new StrikeNb(96, 1, "-0.04494", 96);
                yield return new StrikeNb(97, 1, "-0.027", 97);
                yield return new StrikeNb(98, 1, "-0.00601", 98);
                yield return new StrikeNb(99, 1, "-0.00693", 99);
                yield return new StrikeNb(100, 8, "-0.00528", 100);
                yield return new StrikeNb(101, 5, "-0.00155", 101);
                yield return new StrikeNb(102, 9, "-0.007", 102);
                yield return new StrikeNb(103, 6, "-0.00157", 103);
                yield return new StrikeNb(104, 3, "0.00134", 104);
                yield return new StrikeNb(105, 4, "-0.1281", 105);
                yield return new StrikeNb(106, 6, "-0.01538", 106);
                yield return new StrikeNb(107, 2, "-0.00703", 107);
                yield return new StrikeNb(108, 3, "-3e-05", 108);
            }
        }
    }
}
