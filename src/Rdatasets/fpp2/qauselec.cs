// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Australian Electricity production
    /// </summary>

    public class qauselec
    {
        public readonly double time;
        public readonly double value;

        public qauselec(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<qauselec> Data
        {
            get
            {
                yield return new qauselec(1956, 3.923);
                yield return new qauselec(1956.25, 4.436);
                yield return new qauselec(1956.5, 4.806);
                yield return new qauselec(1956.75, 4.418);
                yield return new qauselec(1957, 4.339);
                yield return new qauselec(1957.25, 4.811);
                yield return new qauselec(1957.5, 5.259);
                yield return new qauselec(1957.75, 4.735);
                yield return new qauselec(1958, 4.608);
                yield return new qauselec(1958.25, 5.196);
                yield return new qauselec(1958.5, 5.609);
                yield return new qauselec(1958.75, 4.977);
                yield return new qauselec(1959, 4.883);
                yield return new qauselec(1959.25, 5.744);
                yield return new qauselec(1959.5, 6.035);
                yield return new qauselec(1959.75, 5.514);
                yield return new qauselec(1960, 5.387);
                yield return new qauselec(1960.25, 6.211);
                yield return new qauselec(1960.5, 6.659);
                yield return new qauselec(1960.75, 5.983);
                yield return new qauselec(1961, 5.709);
                yield return new qauselec(1961.25, 6.458);
                yield return new qauselec(1961.5, 6.875);
                yield return new qauselec(1961.75, 6.162);
                yield return new qauselec(1962, 6.098);
                yield return new qauselec(1962.25, 7.075);
                yield return new qauselec(1962.5, 7.595);
                yield return new qauselec(1962.75, 6.891);
                yield return new qauselec(1963, 6.707);
                yield return new qauselec(1963.25, 7.874);
                yield return new qauselec(1963.5, 8.555);
                yield return new qauselec(1963.75, 7.503);
                yield return new qauselec(1964, 7.469);
                yield return new qauselec(1964.25, 8.829);
                yield return new qauselec(1964.5, 9.513);
                yield return new qauselec(1964.75, 8.415);
                yield return new qauselec(1965, 8.17);
                yield return new qauselec(1965.25, 9.503);
                yield return new qauselec(1965.5, 10.306);
                yield return new qauselec(1965.75, 9.077);
                yield return new qauselec(1966, 8.65);
                yield return new qauselec(1966.25, 10.18);
                yield return new qauselec(1966.5, 11.234);
                yield return new qauselec(1966.75, 9.836);
                yield return new qauselec(1967, 9.49);
                yield return new qauselec(1967.25, 10.991);
                yield return new qauselec(1967.5, 12.17);
                yield return new qauselec(1967.75, 10.47);
                yield return new qauselec(1968, 10.087);
                yield return new qauselec(1968.25, 11.858);
                yield return new qauselec(1968.5, 13.198);
                yield return new qauselec(1968.75, 11.413);
                yield return new qauselec(1969, 11.136);
                yield return new qauselec(1969.25, 13.04);
                yield return new qauselec(1969.5, 14.248);
                yield return new qauselec(1969.75, 12.759);
                yield return new qauselec(1970, 12.328);
                yield return new qauselec(1970.25, 14.493);
                yield return new qauselec(1970.5, 15.664);
                yield return new qauselec(1970.75, 13.781);
                yield return new qauselec(1971, 13.299);
                yield return new qauselec(1971.25, 15.23);
                yield return new qauselec(1971.5, 16.667);
                yield return new qauselec(1971.75, 14.484);
                yield return new qauselec(1972, 13.838);
                yield return new qauselec(1972.25, 15.919);
                yield return new qauselec(1972.5, 17.149);
                yield return new qauselec(1972.75, 15.564);
                yield return new qauselec(1973, 15.024);
                yield return new qauselec(1973.25, 17.064);
                yield return new qauselec(1973.5, 18.512);
                yield return new qauselec(1973.75, 16.467);
                yield return new qauselec(1974, 16.249);
                yield return new qauselec(1974.25, 18.515);
                yield return new qauselec(1974.5, 20.377);
                yield return new qauselec(1974.75, 17.681);
                yield return new qauselec(1975, 16.692);
                yield return new qauselec(1975.25, 19.184);
                yield return new qauselec(1975.5, 20.078);
                yield return new qauselec(1975.75, 18.26);
                yield return new qauselec(1976, 18.023);
                yield return new qauselec(1976.25, 20.234);
                yield return new qauselec(1976.5, 22.272);
                yield return new qauselec(1976.75, 19.684);
                yield return new qauselec(1977, 19.031);
                yield return new qauselec(1977.25, 21.545);
                yield return new qauselec(1977.5, 23.27);
                yield return new qauselec(1977.75, 20.107);
                yield return new qauselec(1978, 20.084);
                yield return new qauselec(1978.25, 22.634);
                yield return new qauselec(1978.5, 24.494);
                yield return new qauselec(1978.75, 21.396);
                yield return new qauselec(1979, 21.323);
                yield return new qauselec(1979.25, 23.644);
                yield return new qauselec(1979.5, 25.994);
                yield return new qauselec(1979.75, 22.802);
                yield return new qauselec(1980, 22.604);
                yield return new qauselec(1980.25, 24.51);
                yield return new qauselec(1980.5, 26.69);
                yield return new qauselec(1980.75, 24.132);
                yield return new qauselec(1981, 23.639);
                yield return new qauselec(1981.25, 26.32);
                yield return new qauselec(1981.5, 28.345);
                yield return new qauselec(1981.75, 24.89);
                yield return new qauselec(1982, 24.675);
                yield return new qauselec(1982.25, 27.122);
                yield return new qauselec(1982.5, 28.59);
                yield return new qauselec(1982.75, 25.371);
                yield return new qauselec(1983, 24.687);
                yield return new qauselec(1983.25, 27.285);
                yield return new qauselec(1983.5, 29.29);
                yield return new qauselec(1983.75, 26.684);
                yield return new qauselec(1984, 26.641);
                yield return new qauselec(1984.25, 29.042);
                yield return new qauselec(1984.5, 31.856);
                yield return new qauselec(1984.75, 28.343);
                yield return new qauselec(1985, 28.982);
                yield return new qauselec(1985.25, 30.838);
                yield return new qauselec(1985.5, 33.165);
                yield return new qauselec(1985.75, 29.648);
                yield return new qauselec(1986, 29.506);
                yield return new qauselec(1986.25, 32.002);
                yield return new qauselec(1986.5, 34.375);
                yield return new qauselec(1986.75, 31.046);
                yield return new qauselec(1987, 31.015);
                yield return new qauselec(1987.25, 33.685);
                yield return new qauselec(1987.5, 35.85);
                yield return new qauselec(1987.75, 33.211);
                yield return new qauselec(1988, 33.142);
                yield return new qauselec(1988.25, 34.664);
                yield return new qauselec(1988.5, 37.154);
                yield return new qauselec(1988.75, 35.303);
                yield return new qauselec(1989, 36.905);
                yield return new qauselec(1989.25, 37.333);
                yield return new qauselec(1989.5, 40.413);
                yield return new qauselec(1989.75, 36.579);
                yield return new qauselec(1990, 37.016);
                yield return new qauselec(1990.25, 39.103);
                yield return new qauselec(1990.5, 41.067);
                yield return new qauselec(1990.75, 37.653);
                yield return new qauselec(1991, 37.554);
                yield return new qauselec(1991.25, 38.752);
                yield return new qauselec(1991.5, 41.424);
                yield return new qauselec(1991.75, 38.101);
                yield return new qauselec(1992, 38.332);
                yield return new qauselec(1992.25, 39.774);
                yield return new qauselec(1992.5, 42.246);
                yield return new qauselec(1992.75, 38.498);
                yield return new qauselec(1993, 39.46);
                yield return new qauselec(1993.25, 41.356);
                yield return new qauselec(1993.5, 42.949);
                yield return new qauselec(1993.75, 40.974);
                yield return new qauselec(1994, 40.162);
                yield return new qauselec(1994.25, 41.199);
                yield return new qauselec(1994.5, 44.095);
                yield return new qauselec(1994.75, 41.745);
                yield return new qauselec(1995, 41.768);
                yield return new qauselec(1995.25, 43.686);
                yield return new qauselec(1995.5, 46.022);
                yield return new qauselec(1995.75, 42.8);
                yield return new qauselec(1996, 43.661);
                yield return new qauselec(1996.25, 44.707);
                yield return new qauselec(1996.5, 46.326);
                yield return new qauselec(1996.75, 43.346);
                yield return new qauselec(1997, 43.938);
                yield return new qauselec(1997.25, 45.828);
                yield return new qauselec(1997.5, 48.448);
                yield return new qauselec(1997.75, 46.096);
                yield return new qauselec(1998, 46.198);
                yield return new qauselec(1998.25, 47.237);
                yield return new qauselec(1998.5, 49.041);
                yield return new qauselec(1998.75, 46.192);
                yield return new qauselec(1999, 48.089);
                yield return new qauselec(1999.25, 48.227);
                yield return new qauselec(1999.5, 49.784);
                yield return new qauselec(1999.75, 47.588);
                yield return new qauselec(2000, 49.32);
                yield return new qauselec(2000.25, 50.67);
                yield return new qauselec(2000.5, 52.623);
                yield return new qauselec(2000.75, 49.35);
                yield return new qauselec(2001, 51.658);
                yield return new qauselec(2001.25, 51.103);
                yield return new qauselec(2001.5, 52.226);
                yield return new qauselec(2001.75, 50.778);
                yield return new qauselec(2002, 50.639);
                yield return new qauselec(2002.25, 51.486);
                yield return new qauselec(2002.5, 53.299);
                yield return new qauselec(2002.75, 51.646);
                yield return new qauselec(2003, 51.415);
                yield return new qauselec(2003.25, 51.379);
                yield return new qauselec(2003.5, 54.808);
                yield return new qauselec(2003.75, 52.453);
                yield return new qauselec(2004, 54.561);
                yield return new qauselec(2004.25, 54.644);
                yield return new qauselec(2004.5, 55.915);
                yield return new qauselec(2004.75, 52.85);
                yield return new qauselec(2005, 55.035);
                yield return new qauselec(2005.25, 55.117);
                yield return new qauselec(2005.5, 56.043);
                yield return new qauselec(2005.75, 54.992);
                yield return new qauselec(2006, 57.112);
                yield return new qauselec(2006.25, 57.157);
                yield return new qauselec(2006.5, 58.4);
                yield return new qauselec(2006.75, 56.249);
                yield return new qauselec(2007, 56.244);
                yield return new qauselec(2007.25, 55.036);
                yield return new qauselec(2007.5, 59.806);
                yield return new qauselec(2007.75, 56.411);
                yield return new qauselec(2008, 59.118);
                yield return new qauselec(2008.25, 56.66);
                yield return new qauselec(2008.5, 64.067);
                yield return new qauselec(2008.75, 59.045);
                yield return new qauselec(2009, 58.368);
                yield return new qauselec(2009.25, 57.471);
                yield return new qauselec(2009.5, 58.394);
                yield return new qauselec(2009.75, 57.336);
                yield return new qauselec(2010, 58.309);
                yield return new qauselec(2010.25, 58.041);
            }
        }
    }
}
