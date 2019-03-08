// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual female murder rate (per 100,000 standard population) in the USA. 1950-2004.
    /// </summary>

    public class wmurders
    {
        public readonly int time;
        public readonly double value;

        public wmurders(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<wmurders> Data
        {
            get
            {
                yield return new wmurders(1950, 2.429415);
                yield return new wmurders(1951, 2.363364);
                yield return new wmurders(1952, 2.374305);
                yield return new wmurders(1953, 2.29552);
                yield return new wmurders(1954, 2.329716);
                yield return new wmurders(1955, 2.233017);
                yield return new wmurders(1956, 2.378179);
                yield return new wmurders(1957, 2.322671);
                yield return new wmurders(1958, 2.416556);
                yield return new wmurders(1959, 2.498199);
                yield return new wmurders(1960, 2.579453);
                yield return new wmurders(1961, 2.58084);
                yield return new wmurders(1962, 2.629293);
                yield return new wmurders(1963, 2.581853);
                yield return new wmurders(1964, 2.72094);
                yield return new wmurders(1965, 2.844774);
                yield return new wmurders(1966, 3.144862);
                yield return new wmurders(1967, 3.433044);
                yield return new wmurders(1968, 3.358418);
                yield return new wmurders(1969, 3.46262);
                yield return new wmurders(1970, 3.647342);
                yield return new wmurders(1971, 3.99108);
                yield return new wmurders(1972, 3.925702);
                yield return new wmurders(1973, 4.490962);
                yield return new wmurders(1974, 4.491541);
                yield return new wmurders(1975, 4.396567);
                yield return new wmurders(1976, 3.984491);
                yield return new wmurders(1977, 4.115111);
                yield return new wmurders(1978, 4.018538);
                yield return new wmurders(1979, 4.201107);
                yield return new wmurders(1980, 4.367459);
                yield return new wmurders(1981, 4.228103);
                yield return new wmurders(1982, 4.145889);
                yield return new wmurders(1983, 3.786691);
                yield return new wmurders(1984, 3.827373);
                yield return new wmurders(1985, 3.820376);
                yield return new wmurders(1986, 4.025134);
                yield return new wmurders(1987, 4.07013);
                yield return new wmurders(1988, 4.10592);
                yield return new wmurders(1989, 4.039027);
                yield return new wmurders(1990, 4.113978);
                yield return new wmurders(1991, 4.41067);
                yield return new wmurders(1992, 4.110586);
                yield return new wmurders(1993, 4.3577);
                yield return new wmurders(1994, 3.95904);
                yield return new wmurders(1995, 3.882907);
                yield return new wmurders(1996, 3.524803);
                yield return new wmurders(1997, 3.249564);
                yield return new wmurders(1998, 3.139884);
                yield return new wmurders(1999, 3.034263);
                yield return new wmurders(2000, 2.805041);
                yield return new wmurders(2001, 3.304467);
                yield return new wmurders(2002, 2.797697);
                yield return new wmurders(2003, 2.662227);
                yield return new wmurders(2004, 2.589383);
            }
        }
    }
}
