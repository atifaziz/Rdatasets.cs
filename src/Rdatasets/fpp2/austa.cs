// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// International visitors to Australia
    /// </summary>

    public class austa
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public austa(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<austa> Data
        {
            get
            {
                yield return new austa(1, 1980, 0.82989428);
                yield return new austa(2, 1981, 0.85951092);
                yield return new austa(3, 1982, 0.87668916);
                yield return new austa(4, 1983, 0.86670716);
                yield return new austa(5, 1984, 0.932052);
                yield return new austa(6, 1985, 1.04826364);
                yield return new austa(7, 1986, 1.3111932);
                yield return new austa(8, 1987, 1.63756228);
                yield return new austa(9, 1988, 2.0641074);
                yield return new austa(10, 1989, 1.91268276);
                yield return new austa(11, 1990, 2.03544572);
                yield return new austa(12, 1991, 2.17721128);
                yield return new austa(13, 1992, 2.38968344);
                yield return new austa(14, 1993, 2.75059208);
                yield return new austa(15, 1994, 3.0906664);
                yield return new austa(16, 1995, 3.42664028);
                yield return new austa(17, 1996, 3.83064908);
                yield return new austa(18, 1997, 3.97190864);
                yield return new austa(19, 1998, 3.83160036);
                yield return new austa(20, 1999, 4.143101);
                yield return new austa(21, 2000, 4.566551);
                yield return new austa(22, 2001, 4.47541);
                yield return new austa(23, 2002, 4.462796);
                yield return new austa(24, 2003, 4.384829);
                yield return new austa(25, 2004, 4.796861);
                yield return new austa(26, 2005, 5.015049);
                yield return new austa(27, 2006, 5.063435);
                yield return new austa(28, 2007, 5.145489);
                yield return new austa(29, 2008, 5.099436);
                yield return new austa(30, 2009, 5.088166);
                yield return new austa(31, 2010, 5.353702);
                yield return new austa(32, 2011, 5.343327);
                yield return new austa(33, 2012, 5.589162);
                yield return new austa(34, 2013, 5.904884);
                yield return new austa(35, 2014, 6.357183);
                yield return new austa(36, 2015, 6.858953);
            }
        }
    }
}
