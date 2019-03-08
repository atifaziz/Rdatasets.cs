// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// International visitors to Australia
    /// </summary>

    public class austa
    {
        public readonly int time;
        public readonly double value;

        public austa(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<austa> Data
        {
            get
            {
                yield return new austa(1980, 0.82989428);
                yield return new austa(1981, 0.85951092);
                yield return new austa(1982, 0.87668916);
                yield return new austa(1983, 0.86670716);
                yield return new austa(1984, 0.932052);
                yield return new austa(1985, 1.04826364);
                yield return new austa(1986, 1.3111932);
                yield return new austa(1987, 1.63756228);
                yield return new austa(1988, 2.0641074);
                yield return new austa(1989, 1.91268276);
                yield return new austa(1990, 2.03544572);
                yield return new austa(1991, 2.17721128);
                yield return new austa(1992, 2.38968344);
                yield return new austa(1993, 2.75059208);
                yield return new austa(1994, 3.0906664);
                yield return new austa(1995, 3.42664028);
                yield return new austa(1996, 3.83064908);
                yield return new austa(1997, 3.97190864);
                yield return new austa(1998, 3.83160036);
                yield return new austa(1999, 4.143101);
                yield return new austa(2000, 4.566551);
                yield return new austa(2001, 4.47541);
                yield return new austa(2002, 4.462796);
                yield return new austa(2003, 4.384829);
                yield return new austa(2004, 4.796861);
                yield return new austa(2005, 5.015049);
                yield return new austa(2006, 5.063435);
                yield return new austa(2007, 5.145489);
                yield return new austa(2008, 5.099436);
                yield return new austa(2009, 5.088166);
                yield return new austa(2010, 5.353702);
                yield return new austa(2011, 5.343327);
                yield return new austa(2012, 5.589162);
                yield return new austa(2013, 5.904884);
                yield return new austa(2014, 6.357183);
                yield return new austa(2015, 6.858953);
            }
        }
    }
}
