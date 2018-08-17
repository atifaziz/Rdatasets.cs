// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Velocities for 82 Galaxies
    /// </summary>

    public class galaxies
    {
        public readonly int dat;

        public galaxies(int dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<galaxies> Data
        {
            get
            {
                yield return new galaxies(9172);
                yield return new galaxies(9350);
                yield return new galaxies(9483);
                yield return new galaxies(9558);
                yield return new galaxies(9775);
                yield return new galaxies(10227);
                yield return new galaxies(10406);
                yield return new galaxies(16084);
                yield return new galaxies(16170);
                yield return new galaxies(18419);
                yield return new galaxies(18552);
                yield return new galaxies(18600);
                yield return new galaxies(18927);
                yield return new galaxies(19052);
                yield return new galaxies(19070);
                yield return new galaxies(19330);
                yield return new galaxies(19343);
                yield return new galaxies(19349);
                yield return new galaxies(19440);
                yield return new galaxies(19473);
                yield return new galaxies(19529);
                yield return new galaxies(19541);
                yield return new galaxies(19547);
                yield return new galaxies(19663);
                yield return new galaxies(19846);
                yield return new galaxies(19856);
                yield return new galaxies(19863);
                yield return new galaxies(19914);
                yield return new galaxies(19918);
                yield return new galaxies(19973);
                yield return new galaxies(19989);
                yield return new galaxies(20166);
                yield return new galaxies(20175);
                yield return new galaxies(20179);
                yield return new galaxies(20196);
                yield return new galaxies(20215);
                yield return new galaxies(20221);
                yield return new galaxies(20415);
                yield return new galaxies(20629);
                yield return new galaxies(20795);
                yield return new galaxies(20821);
                yield return new galaxies(20846);
                yield return new galaxies(20875);
                yield return new galaxies(20986);
                yield return new galaxies(21137);
                yield return new galaxies(21492);
                yield return new galaxies(21701);
                yield return new galaxies(21814);
                yield return new galaxies(21921);
                yield return new galaxies(21960);
                yield return new galaxies(22185);
                yield return new galaxies(22209);
                yield return new galaxies(22242);
                yield return new galaxies(22249);
                yield return new galaxies(22314);
                yield return new galaxies(22374);
                yield return new galaxies(22495);
                yield return new galaxies(22746);
                yield return new galaxies(22747);
                yield return new galaxies(22888);
                yield return new galaxies(22914);
                yield return new galaxies(23206);
                yield return new galaxies(23241);
                yield return new galaxies(23263);
                yield return new galaxies(23484);
                yield return new galaxies(23538);
                yield return new galaxies(23542);
                yield return new galaxies(23666);
                yield return new galaxies(23706);
                yield return new galaxies(23711);
                yield return new galaxies(24129);
                yield return new galaxies(24285);
                yield return new galaxies(24289);
                yield return new galaxies(24366);
                yield return new galaxies(24717);
                yield return new galaxies(24990);
                yield return new galaxies(25633);
                yield return new galaxies(26690);
                yield return new galaxies(26995);
                yield return new galaxies(32065);
                yield return new galaxies(32789);
                yield return new galaxies(34279);
            }
        }
    }
}
