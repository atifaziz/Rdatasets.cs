// ReSharper disable All

namespace Rdatasets.forecast
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly production of woollen yarn in Australia
    /// </summary>

    public class woolyrnq
    {
        public readonly double time;
        public readonly int value;

        public woolyrnq(double time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<woolyrnq> Data
        {
            get
            {
                yield return new woolyrnq(1965, 6172);
                yield return new woolyrnq(1965.25, 6709);
                yield return new woolyrnq(1965.5, 6633);
                yield return new woolyrnq(1965.75, 6660);
                yield return new woolyrnq(1966, 6786);
                yield return new woolyrnq(1966.25, 6800);
                yield return new woolyrnq(1966.5, 6730);
                yield return new woolyrnq(1966.75, 6765);
                yield return new woolyrnq(1967, 6720);
                yield return new woolyrnq(1967.25, 7133);
                yield return new woolyrnq(1967.5, 6946);
                yield return new woolyrnq(1967.75, 7095);
                yield return new woolyrnq(1968, 7047);
                yield return new woolyrnq(1968.25, 6757);
                yield return new woolyrnq(1968.5, 6915);
                yield return new woolyrnq(1968.75, 6921);
                yield return new woolyrnq(1969, 7064);
                yield return new woolyrnq(1969.25, 7206);
                yield return new woolyrnq(1969.5, 7190);
                yield return new woolyrnq(1969.75, 7402);
                yield return new woolyrnq(1970, 7819);
                yield return new woolyrnq(1970.25, 7300);
                yield return new woolyrnq(1970.5, 7105);
                yield return new woolyrnq(1970.75, 7259);
                yield return new woolyrnq(1971, 7001);
                yield return new woolyrnq(1971.25, 7475);
                yield return new woolyrnq(1971.5, 6840);
                yield return new woolyrnq(1971.75, 7061);
                yield return new woolyrnq(1972, 5845);
                yield return new woolyrnq(1972.25, 7529);
                yield return new woolyrnq(1972.5, 7819);
                yield return new woolyrnq(1972.75, 6943);
                yield return new woolyrnq(1973, 5714);
                yield return new woolyrnq(1973.25, 6556);
                yield return new woolyrnq(1973.5, 7045);
                yield return new woolyrnq(1973.75, 5947);
                yield return new woolyrnq(1974, 5463);
                yield return new woolyrnq(1974.25, 6127);
                yield return new woolyrnq(1974.5, 5540);
                yield return new woolyrnq(1974.75, 4235);
                yield return new woolyrnq(1975, 3324);
                yield return new woolyrnq(1975.25, 4793);
                yield return new woolyrnq(1975.5, 5906);
                yield return new woolyrnq(1975.75, 5834);
                yield return new woolyrnq(1976, 5240);
                yield return new woolyrnq(1976.25, 5458);
                yield return new woolyrnq(1976.5, 5505);
                yield return new woolyrnq(1976.75, 5002);
                yield return new woolyrnq(1977, 3999);
                yield return new woolyrnq(1977.25, 4826);
                yield return new woolyrnq(1977.5, 5318);
                yield return new woolyrnq(1977.75, 4681);
                yield return new woolyrnq(1978, 4442);
                yield return new woolyrnq(1978.25, 5305);
                yield return new woolyrnq(1978.5, 5466);
                yield return new woolyrnq(1978.75, 4995);
                yield return new woolyrnq(1979, 4573);
                yield return new woolyrnq(1979.25, 5081);
                yield return new woolyrnq(1979.5, 5696);
                yield return new woolyrnq(1979.75, 5079);
                yield return new woolyrnq(1980, 4373);
                yield return new woolyrnq(1980.25, 4986);
                yield return new woolyrnq(1980.5, 5341);
                yield return new woolyrnq(1980.75, 4800);
                yield return new woolyrnq(1981, 4161);
                yield return new woolyrnq(1981.25, 5007);
                yield return new woolyrnq(1981.5, 5464);
                yield return new woolyrnq(1981.75, 5127);
                yield return new woolyrnq(1982, 4240);
                yield return new woolyrnq(1982.25, 5338);
                yield return new woolyrnq(1982.5, 5129);
                yield return new woolyrnq(1982.75, 4437);
                yield return new woolyrnq(1983, 3642);
                yield return new woolyrnq(1983.25, 4602);
                yield return new woolyrnq(1983.5, 5524);
                yield return new woolyrnq(1983.75, 4895);
                yield return new woolyrnq(1984, 4380);
                yield return new woolyrnq(1984.25, 5186);
                yield return new woolyrnq(1984.5, 6080);
                yield return new woolyrnq(1984.75, 5588);
                yield return new woolyrnq(1985, 5009);
                yield return new woolyrnq(1985.25, 5663);
                yield return new woolyrnq(1985.5, 6540);
                yield return new woolyrnq(1985.75, 6262);
                yield return new woolyrnq(1986, 5169);
                yield return new woolyrnq(1986.25, 5819);
                yield return new woolyrnq(1986.5, 6339);
                yield return new woolyrnq(1986.75, 5981);
                yield return new woolyrnq(1987, 4766);
                yield return new woolyrnq(1987.25, 5976);
                yield return new woolyrnq(1987.5, 6590);
                yield return new woolyrnq(1987.75, 5590);
                yield return new woolyrnq(1988, 5135);
                yield return new woolyrnq(1988.25, 5762);
                yield return new woolyrnq(1988.5, 6077);
                yield return new woolyrnq(1988.75, 5882);
                yield return new woolyrnq(1989, 4247);
                yield return new woolyrnq(1989.25, 5264);
                yield return new woolyrnq(1989.5, 5146);
                yield return new woolyrnq(1989.75, 4868);
                yield return new woolyrnq(1990, 4329);
                yield return new woolyrnq(1990.25, 4869);
                yield return new woolyrnq(1990.5, 5127);
                yield return new woolyrnq(1990.75, 4868);
                yield return new woolyrnq(1991, 3827);
                yield return new woolyrnq(1991.25, 4987);
                yield return new woolyrnq(1991.5, 5222);
                yield return new woolyrnq(1991.75, 4928);
                yield return new woolyrnq(1992, 3930);
                yield return new woolyrnq(1992.25, 4469);
                yield return new woolyrnq(1992.5, 4954);
                yield return new woolyrnq(1992.75, 4752);
                yield return new woolyrnq(1993, 3888);
                yield return new woolyrnq(1993.25, 4588);
                yield return new woolyrnq(1993.5, 5309);
                yield return new woolyrnq(1993.75, 4732);
                yield return new woolyrnq(1994, 4837);
                yield return new woolyrnq(1994.25, 6135);
                yield return new woolyrnq(1994.5, 6396);
            }
        }
    }
}
