// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Air Transport Passengers Australia
    /// </summary>

    public class ausair
    {
        public readonly int time;
        public readonly double value;

        public ausair(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<ausair> Data
        {
            get
            {
                yield return new ausair(1970, 7.3187);
                yield return new ausair(1971, 7.3266);
                yield return new ausair(1972, 7.7956);
                yield return new ausair(1973, 9.3846);
                yield return new ausair(1974, 10.6647);
                yield return new ausair(1975, 11.0551);
                yield return new ausair(1976, 10.8643);
                yield return new ausair(1977, 11.3065);
                yield return new ausair(1978, 12.1223);
                yield return new ausair(1979, 13.0225);
                yield return new ausair(1980, 13.6488);
                yield return new ausair(1981, 13.2195);
                yield return new ausair(1982, 13.1879);
                yield return new ausair(1983, 12.6015);
                yield return new ausair(1984, 13.2368);
                yield return new ausair(1985, 14.4121);
                yield return new ausair(1986, 15.4973);
                yield return new ausair(1987, 16.8802);
                yield return new ausair(1988, 18.8163);
                yield return new ausair(1989, 15.1143);
                yield return new ausair(1990, 17.5534);
                yield return new ausair(1991, 21.8601);
                yield return new ausair(1992, 23.8866);
                yield return new ausair(1993, 26.9293);
                yield return new ausair(1994, 26.8885);
                yield return new ausair(1995, 28.8314);
                yield return new ausair(1996, 30.0751);
                yield return new ausair(1997, 30.9535);
                yield return new ausair(1998, 30.1857);
                yield return new ausair(1999, 31.5797);
                yield return new ausair(2000, 32.577569);
                yield return new ausair(2001, 33.477398);
                yield return new ausair(2002, 39.021581);
                yield return new ausair(2003, 41.386432);
                yield return new ausair(2004, 41.596552);
                yield return new ausair(2005, 44.657324);
                yield return new ausair(2006, 46.951775);
                yield return new ausair(2007, 48.728837);
                yield return new ausair(2008, 51.488427);
                yield return new ausair(2009, 50.026967);
                yield return new ausair(2010, 60.640913);
                yield return new ausair(2011, 63.3603103378);
                yield return new ausair(2012, 66.355274);
                yield return new ausair(2013, 68.197955);
                yield return new ausair(2014, 68.1232376693);
                yield return new ausair(2015, 69.7793454797);
                yield return new ausair(2016, 72.597700806);
            }
        }
    }
}
