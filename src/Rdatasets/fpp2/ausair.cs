// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Air Transport Passengers Australia
    /// </summary>

    public class ausair
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public ausair(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<ausair> Data
        {
            get
            {
                yield return new ausair(1, 1970, 7.3187);
                yield return new ausair(2, 1971, 7.3266);
                yield return new ausair(3, 1972, 7.7956);
                yield return new ausair(4, 1973, 9.3846);
                yield return new ausair(5, 1974, 10.6647);
                yield return new ausair(6, 1975, 11.0551);
                yield return new ausair(7, 1976, 10.8643);
                yield return new ausair(8, 1977, 11.3065);
                yield return new ausair(9, 1978, 12.1223);
                yield return new ausair(10, 1979, 13.0225);
                yield return new ausair(11, 1980, 13.6488);
                yield return new ausair(12, 1981, 13.2195);
                yield return new ausair(13, 1982, 13.1879);
                yield return new ausair(14, 1983, 12.6015);
                yield return new ausair(15, 1984, 13.2368);
                yield return new ausair(16, 1985, 14.4121);
                yield return new ausair(17, 1986, 15.4973);
                yield return new ausair(18, 1987, 16.8802);
                yield return new ausair(19, 1988, 18.8163);
                yield return new ausair(20, 1989, 15.1143);
                yield return new ausair(21, 1990, 17.5534);
                yield return new ausair(22, 1991, 21.8601);
                yield return new ausair(23, 1992, 23.8866);
                yield return new ausair(24, 1993, 26.9293);
                yield return new ausair(25, 1994, 26.8885);
                yield return new ausair(26, 1995, 28.8314);
                yield return new ausair(27, 1996, 30.0751);
                yield return new ausair(28, 1997, 30.9535);
                yield return new ausair(29, 1998, 30.1857);
                yield return new ausair(30, 1999, 31.5797);
                yield return new ausair(31, 2000, 32.577569);
                yield return new ausair(32, 2001, 33.477398);
                yield return new ausair(33, 2002, 39.021581);
                yield return new ausair(34, 2003, 41.386432);
                yield return new ausair(35, 2004, 41.596552);
                yield return new ausair(36, 2005, 44.657324);
                yield return new ausair(37, 2006, 46.951775);
                yield return new ausair(38, 2007, 48.728837);
                yield return new ausair(39, 2008, 51.488427);
                yield return new ausair(40, 2009, 50.026967);
                yield return new ausair(41, 2010, 60.640913);
                yield return new ausair(42, 2011, 63.3603103378);
                yield return new ausair(43, 2012, 66.355274);
                yield return new ausair(44, 2013, 68.197955);
                yield return new ausair(45, 2014, 68.1232376693);
                yield return new ausair(46, 2015, 69.7793454797);
                yield return new ausair(47, 2016, 72.597700806);
            }
        }
    }
}
