// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// International Tourists to Australia: Total visitor nights.
    /// </summary>

    public class austourists
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public austourists(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<austourists> Data
        {
            get
            {
                yield return new austourists(1, 1999, 30.052513);
                yield return new austourists(2, 1999.25, 19.148496);
                yield return new austourists(3, 1999.5, 25.317692);
                yield return new austourists(4, 1999.75, 27.591437);
                yield return new austourists(5, 2000, 32.076456);
                yield return new austourists(6, 2000.25, 23.487961);
                yield return new austourists(7, 2000.5, 28.47594);
                yield return new austourists(8, 2000.75, 35.123753);
                yield return new austourists(9, 2001, 36.838485);
                yield return new austourists(10, 2001.25, 25.007017);
                yield return new austourists(11, 2001.5, 30.72223);
                yield return new austourists(12, 2001.75, 28.693759);
                yield return new austourists(13, 2002, 36.640986);
                yield return new austourists(14, 2002.25, 23.824609);
                yield return new austourists(15, 2002.5, 29.311683);
                yield return new austourists(16, 2002.75, 31.770309);
                yield return new austourists(17, 2003, 35.177877);
                yield return new austourists(18, 2003.25, 19.775244);
                yield return new austourists(19, 2003.5, 29.60175);
                yield return new austourists(20, 2003.75, 34.538842);
                yield return new austourists(21, 2004, 41.273599);
                yield return new austourists(22, 2004.25, 26.655862);
                yield return new austourists(23, 2004.5, 28.279859);
                yield return new austourists(24, 2004.75, 35.191153);
                yield return new austourists(25, 2005, 42.2056638559382);
                yield return new austourists(26, 2005.25, 24.6491713296294);
                yield return new austourists(27, 2005.5, 32.6673351386246);
                yield return new austourists(28, 2005.75, 37.2573540134764);
                yield return new austourists(29, 2006, 45.2424602720635);
                yield return new austourists(30, 2006.25, 29.3504812742718);
                yield return new austourists(31, 2006.5, 36.3442072775119);
                yield return new austourists(32, 2006.75, 41.7820813647366);
                yield return new austourists(33, 2007, 49.2765984345619);
                yield return new austourists(34, 2007.25, 31.2754013898459);
                yield return new austourists(35, 2007.5, 37.8506254947152);
                yield return new austourists(36, 2007.75, 38.83704413019);
                yield return new austourists(37, 2008, 51.236900336137);
                yield return new austourists(38, 2008.25, 31.8385516171558);
                yield return new austourists(39, 2008.5, 41.3234212576972);
                yield return new austourists(40, 2008.75, 42.7990033724349);
                yield return new austourists(41, 2009, 55.708358364385);
                yield return new austourists(42, 2009.25, 33.4071449171312);
                yield return new austourists(43, 2009.5, 42.3166379718116);
                yield return new austourists(44, 2009.75, 45.1571225674731);
                yield return new austourists(45, 2010, 59.5760799633937);
                yield return new austourists(46, 2010.25, 34.8373301595328);
                yield return new austourists(47, 2010.5, 44.8416807241332);
                yield return new austourists(48, 2010.75, 46.971249602779);
                yield return new austourists(49, 2011, 60.0190309438716);
                yield return new austourists(50, 2011.25, 38.3711785132276);
                yield return new austourists(51, 2011.5, 46.9758641283558);
                yield return new austourists(52, 2011.75, 50.7337964560878);
                yield return new austourists(53, 2012, 61.6468731860574);
                yield return new austourists(54, 2012.25, 39.2995693656296);
                yield return new austourists(55, 2012.5, 52.6712090814052);
                yield return new austourists(56, 2012.75, 54.3323168946667);
                yield return new austourists(57, 2013, 66.834358381339);
                yield return new austourists(58, 2013.25, 40.8711884667851);
                yield return new austourists(59, 2013.5, 51.8285357927739);
                yield return new austourists(60, 2013.75, 57.4919099342262);
                yield return new austourists(61, 2014, 65.2514698518726);
                yield return new austourists(62, 2014.25, 43.0612082202828);
                yield return new austourists(63, 2014.5, 54.7607571288007);
                yield return new austourists(64, 2014.75, 59.8344749355003);
                yield return new austourists(65, 2015, 73.2570274672009);
                yield return new austourists(66, 2015.25, 47.6966237298);
                yield return new austourists(67, 2015.5, 61.0977680206996);
                yield return new austourists(68, 2015.75, 66.0557612187001);
            }
        }
    }
}
