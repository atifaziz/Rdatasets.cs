// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Australian Gas Production
    /// </summary>

    public class qgas
    {
        public readonly double time;
        public readonly double value;

        public qgas(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<qgas> Data
        {
            get
            {
                yield return new qgas(1956, 5.149);
                yield return new qgas(1956.25, 6.372);
                yield return new qgas(1956.5, 7.068);
                yield return new qgas(1956.75, 5.908);
                yield return new qgas(1957, 5.359);
                yield return new qgas(1957.25, 6.531);
                yield return new qgas(1957.5, 7.365);
                yield return new qgas(1957.75, 5.982);
                yield return new qgas(1958, 5.244);
                yield return new qgas(1958.25, 6.785);
                yield return new qgas(1958.5, 7.576);
                yield return new qgas(1958.75, 6.036);
                yield return new qgas(1959, 5.317);
                yield return new qgas(1959.25, 6.889);
                yield return new qgas(1959.5, 7.702);
                yield return new qgas(1959.75, 6.247);
                yield return new qgas(1960, 5.582);
                yield return new qgas(1960.25, 7.534);
                yield return new qgas(1960.5, 8.388);
                yield return new qgas(1960.75, 6.605);
                yield return new qgas(1961, 5.592);
                yield return new qgas(1961.25, 7.428);
                yield return new qgas(1961.5, 8.377);
                yield return new qgas(1961.75, 6.426);
                yield return new qgas(1962, 5.73);
                yield return new qgas(1962.25, 7.66);
                yield return new qgas(1962.5, 8.494);
                yield return new qgas(1962.75, 6.647);
                yield return new qgas(1963, 5.899);
                yield return new qgas(1963.25, 7.891);
                yield return new qgas(1963.5, 8.905);
                yield return new qgas(1963.75, 6.721);
                yield return new qgas(1964, 5.983);
                yield return new qgas(1964.25, 8.135);
                yield return new qgas(1964.5, 8.958);
                yield return new qgas(1964.75, 6.922);
                yield return new qgas(1965, 6.088);
                yield return new qgas(1965.25, 8.377);
                yield return new qgas(1965.5, 9.116);
                yield return new qgas(1965.75, 6.911);
                yield return new qgas(1966, 6.067);
                yield return new qgas(1966.25, 8.494);
                yield return new qgas(1966.5, 9.717);
                yield return new qgas(1966.75, 7.28);
                yield return new qgas(1967, 6.236);
                yield return new qgas(1967.25, 8.599);
                yield return new qgas(1967.5, 10.15);
                yield return new qgas(1967.75, 7.258);
                yield return new qgas(1968, 6.193);
                yield return new qgas(1968.25, 9.263);
                yield return new qgas(1968.5, 10.784);
                yield return new qgas(1968.75, 7.902);
                yield return new qgas(1969, 6.615);
                yield return new qgas(1969.25, 9.654);
                yield return new qgas(1969.5, 13.262);
                yield return new qgas(1969.75, 10.646);
                yield return new qgas(1970, 12.439);
                yield return new qgas(1970.25, 17.789);
                yield return new qgas(1970.5, 22.958);
                yield return new qgas(1970.75, 19.656);
                yield return new qgas(1971, 18.696);
                yield return new qgas(1971.25, 24.244);
                yield return new qgas(1971.5, 28.065);
                yield return new qgas(1971.75, 23.768);
                yield return new qgas(1972, 24.083);
                yield return new qgas(1972.25, 33.855);
                yield return new qgas(1972.5, 39.663);
                yield return new qgas(1972.75, 34.572);
                yield return new qgas(1973, 34.459);
                yield return new qgas(1973.25, 40.881);
                yield return new qgas(1973.5, 47.617);
                yield return new qgas(1973.75, 39.426);
                yield return new qgas(1974, 37.674);
                yield return new qgas(1974.25, 47.976);
                yield return new qgas(1974.5, 51.563);
                yield return new qgas(1974.75, 42.66);
                yield return new qgas(1975, 39.177);
                yield return new qgas(1975.25, 49.424);
                yield return new qgas(1975.5, 55.003);
                yield return new qgas(1975.75, 46.824);
                yield return new qgas(1976, 44.225);
                yield return new qgas(1976.25, 57.572);
                yield return new qgas(1976.5, 65.088);
                yield return new qgas(1976.75, 53.76);
                yield return new qgas(1977, 49.312);
                yield return new qgas(1977.25, 63.723);
                yield return new qgas(1977.5, 74.308);
                yield return new qgas(1977.75, 57.734);
                yield return new qgas(1978, 55.753);
                yield return new qgas(1978.25, 70.994);
                yield return new qgas(1978.5, 77.7);
                yield return new qgas(1978.75, 65.012);
                yield return new qgas(1979, 58.554);
                yield return new qgas(1979.25, 74.172);
                yield return new qgas(1979.5, 87.601);
                yield return new qgas(1979.75, 71.143);
                yield return new qgas(1980, 68.305);
                yield return new qgas(1980.25, 91.494);
                yield return new qgas(1980.5, 103.355);
                yield return new qgas(1980.75, 82.828);
                yield return new qgas(1981, 87.838);
                yield return new qgas(1981.25, 109.885);
                yield return new qgas(1981.5, 119.783);
                yield return new qgas(1981.75, 100.887);
                yield return new qgas(1982, 92.566);
                yield return new qgas(1982.25, 116.031);
                yield return new qgas(1982.5, 126.61);
                yield return new qgas(1982.75, 97.691);
                yield return new qgas(1983, 91.901);
                yield return new qgas(1983.25, 118.398);
                yield return new qgas(1983.5, 123.589);
                yield return new qgas(1983.75, 104.15);
                yield return new qgas(1984, 97.129);
                yield return new qgas(1984.25, 116.333);
                yield return new qgas(1984.5, 130.379);
                yield return new qgas(1984.75, 111.173);
                yield return new qgas(1985, 102.607);
                yield return new qgas(1985.25, 119.591);
                yield return new qgas(1985.5, 131.551);
                yield return new qgas(1985.75, 107.312);
                yield return new qgas(1986, 98.451);
                yield return new qgas(1986.25, 126.824);
                yield return new qgas(1986.5, 136.76);
                yield return new qgas(1986.75, 112.228);
                yield return new qgas(1987, 106.125);
                yield return new qgas(1987.25, 129.905);
                yield return new qgas(1987.5, 158.412);
                yield return new qgas(1987.75, 123.315);
                yield return new qgas(1988, 115.582);
                yield return new qgas(1988.25, 136.809);
                yield return new qgas(1988.5, 157.408);
                yield return new qgas(1988.75, 125.375);
                yield return new qgas(1989, 116.596);
                yield return new qgas(1989.25, 149.075);
                yield return new qgas(1989.5, 175.104);
                yield return new qgas(1989.75, 139.375);
                yield return new qgas(1990, 124.901);
                yield return new qgas(1990.25, 151.83);
                yield return new qgas(1990.5, 160.848);
                yield return new qgas(1990.75, 122.942);
                yield return new qgas(1991, 111.133);
                yield return new qgas(1991.25, 141.27);
                yield return new qgas(1991.5, 159.795);
                yield return new qgas(1991.75, 125.346);
                yield return new qgas(1992, 117.445);
                yield return new qgas(1992.25, 150.854);
                yield return new qgas(1992.5, 174.431);
                yield return new qgas(1992.75, 129.196);
                yield return new qgas(1993, 106.065);
                yield return new qgas(1993.25, 149.055);
                yield return new qgas(1993.5, 162.808);
                yield return new qgas(1993.75, 138.06);
                yield return new qgas(1994, 127.348);
                yield return new qgas(1994.25, 158.957);
                yield return new qgas(1994.5, 184.13);
                yield return new qgas(1994.75, 141.995);
                yield return new qgas(1995, 129.358);
                yield return new qgas(1995.25, 167.376);
                yield return new qgas(1995.5, 181);
                yield return new qgas(1995.75, 145);
                yield return new qgas(1996, 133);
                yield return new qgas(1996.25, 162);
                yield return new qgas(1996.5, 184);
                yield return new qgas(1996.75, 146);
                yield return new qgas(1997, 135);
                yield return new qgas(1997.25, 171);
                yield return new qgas(1997.5, 183);
                yield return new qgas(1997.75, 151);
                yield return new qgas(1998, 141);
                yield return new qgas(1998.25, 174);
                yield return new qgas(1998.5, 191);
                yield return new qgas(1998.75, 157);
                yield return new qgas(1999, 145);
                yield return new qgas(1999.25, 182);
                yield return new qgas(1999.5, 198);
                yield return new qgas(1999.75, 165);
                yield return new qgas(2000, 164);
                yield return new qgas(2000.25, 199);
                yield return new qgas(2000.5, 213);
                yield return new qgas(2000.75, 173);
                yield return new qgas(2001, 177);
                yield return new qgas(2001.25, 205);
                yield return new qgas(2001.5, 218);
                yield return new qgas(2001.75, 185);
                yield return new qgas(2002, 166);
                yield return new qgas(2002.25, 204);
                yield return new qgas(2002.5, 228);
                yield return new qgas(2002.75, 186);
                yield return new qgas(2003, 172);
                yield return new qgas(2003.25, 204);
                yield return new qgas(2003.5, 232);
                yield return new qgas(2003.75, 188);
                yield return new qgas(2004, 173);
                yield return new qgas(2004.25, 215);
                yield return new qgas(2004.5, 227);
                yield return new qgas(2004.75, 190);
                yield return new qgas(2005, 170);
                yield return new qgas(2005.25, 206);
                yield return new qgas(2005.5, 221);
                yield return new qgas(2005.75, 180);
                yield return new qgas(2006, 171);
                yield return new qgas(2006.25, 224);
                yield return new qgas(2006.5, 233);
                yield return new qgas(2006.75, 192);
                yield return new qgas(2007, 187);
                yield return new qgas(2007.25, 234);
                yield return new qgas(2007.5, 245);
                yield return new qgas(2007.75, 205);
                yield return new qgas(2008, 194);
                yield return new qgas(2008.25, 229);
                yield return new qgas(2008.5, 249);
                yield return new qgas(2008.75, 203);
                yield return new qgas(2009, 196);
                yield return new qgas(2009.25, 238);
                yield return new qgas(2009.5, 252);
                yield return new qgas(2009.75, 210);
                yield return new qgas(2010, 205);
                yield return new qgas(2010.25, 236);
            }
        }
    }
}
