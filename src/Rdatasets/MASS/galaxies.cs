// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Velocities for 82 Galaxies
    /// </summary>

    public class galaxies
    {
        public readonly int κ;
        public readonly int dat;

        public galaxies(int κ, int dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<galaxies> Data
        {
            get
            {
                yield return new galaxies(1, 9172);
                yield return new galaxies(2, 9350);
                yield return new galaxies(3, 9483);
                yield return new galaxies(4, 9558);
                yield return new galaxies(5, 9775);
                yield return new galaxies(6, 10227);
                yield return new galaxies(7, 10406);
                yield return new galaxies(8, 16084);
                yield return new galaxies(9, 16170);
                yield return new galaxies(10, 18419);
                yield return new galaxies(11, 18552);
                yield return new galaxies(12, 18600);
                yield return new galaxies(13, 18927);
                yield return new galaxies(14, 19052);
                yield return new galaxies(15, 19070);
                yield return new galaxies(16, 19330);
                yield return new galaxies(17, 19343);
                yield return new galaxies(18, 19349);
                yield return new galaxies(19, 19440);
                yield return new galaxies(20, 19473);
                yield return new galaxies(21, 19529);
                yield return new galaxies(22, 19541);
                yield return new galaxies(23, 19547);
                yield return new galaxies(24, 19663);
                yield return new galaxies(25, 19846);
                yield return new galaxies(26, 19856);
                yield return new galaxies(27, 19863);
                yield return new galaxies(28, 19914);
                yield return new galaxies(29, 19918);
                yield return new galaxies(30, 19973);
                yield return new galaxies(31, 19989);
                yield return new galaxies(32, 20166);
                yield return new galaxies(33, 20175);
                yield return new galaxies(34, 20179);
                yield return new galaxies(35, 20196);
                yield return new galaxies(36, 20215);
                yield return new galaxies(37, 20221);
                yield return new galaxies(38, 20415);
                yield return new galaxies(39, 20629);
                yield return new galaxies(40, 20795);
                yield return new galaxies(41, 20821);
                yield return new galaxies(42, 20846);
                yield return new galaxies(43, 20875);
                yield return new galaxies(44, 20986);
                yield return new galaxies(45, 21137);
                yield return new galaxies(46, 21492);
                yield return new galaxies(47, 21701);
                yield return new galaxies(48, 21814);
                yield return new galaxies(49, 21921);
                yield return new galaxies(50, 21960);
                yield return new galaxies(51, 22185);
                yield return new galaxies(52, 22209);
                yield return new galaxies(53, 22242);
                yield return new galaxies(54, 22249);
                yield return new galaxies(55, 22314);
                yield return new galaxies(56, 22374);
                yield return new galaxies(57, 22495);
                yield return new galaxies(58, 22746);
                yield return new galaxies(59, 22747);
                yield return new galaxies(60, 22888);
                yield return new galaxies(61, 22914);
                yield return new galaxies(62, 23206);
                yield return new galaxies(63, 23241);
                yield return new galaxies(64, 23263);
                yield return new galaxies(65, 23484);
                yield return new galaxies(66, 23538);
                yield return new galaxies(67, 23542);
                yield return new galaxies(68, 23666);
                yield return new galaxies(69, 23706);
                yield return new galaxies(70, 23711);
                yield return new galaxies(71, 24129);
                yield return new galaxies(72, 24285);
                yield return new galaxies(73, 24289);
                yield return new galaxies(74, 24366);
                yield return new galaxies(75, 24717);
                yield return new galaxies(76, 24990);
                yield return new galaxies(77, 25633);
                yield return new galaxies(78, 26690);
                yield return new galaxies(79, 26995);
                yield return new galaxies(80, 32065);
                yield return new galaxies(81, 32789);
                yield return new galaxies(82, 34279);
            }
        }
    }
}
