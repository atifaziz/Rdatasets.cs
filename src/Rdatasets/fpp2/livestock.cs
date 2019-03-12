// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Livestock (sheep) in Asia, 1961-2007.
    /// </summary>

    public class livestock
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public livestock(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<livestock> Data
        {
            get
            {
                yield return new livestock(1, 1961, 232.288994);
                yield return new livestock(2, 1962, 229.536258);
                yield return new livestock(3, 1963, 233.145936);
                yield return new livestock(4, 1964, 243.763684);
                yield return new livestock(5, 1965, 252.602916);
                yield return new livestock(6, 1966, 259.677371);
                yield return new livestock(7, 1967, 260.766892);
                yield return new livestock(8, 1968, 269.784084);
                yield return new livestock(9, 1969, 266.414974);
                yield return new livestock(10, 1970, 263.917747);
                yield return new livestock(11, 1971, 268.307222);
                yield return new livestock(12, 1972, 260.662556);
                yield return new livestock(13, 1973, 266.639419);
                yield return new livestock(14, 1974, 277.515778);
                yield return new livestock(15, 1975, 283.834045);
                yield return new livestock(16, 1976, 290.309028);
                yield return new livestock(17, 1977, 292.474198);
                yield return new livestock(18, 1978, 300.830694);
                yield return new livestock(19, 1979, 309.286657);
                yield return new livestock(20, 1980, 318.331081);
                yield return new livestock(21, 1981, 329.37239);
                yield return new livestock(22, 1982, 338.883998);
                yield return new livestock(23, 1983, 339.244126);
                yield return new livestock(24, 1984, 328.600632);
                yield return new livestock(25, 1985, 314.255385);
                yield return new livestock(26, 1986, 314.459695);
                yield return new livestock(27, 1987, 321.413779);
                yield return new livestock(28, 1988, 329.789292);
                yield return new livestock(29, 1989, 346.385165);
                yield return new livestock(30, 1990, 352.297882);
                yield return new livestock(31, 1991, 348.370515);
                yield return new livestock(32, 1992, 417.562922);
                yield return new livestock(33, 1993, 417.12357);
                yield return new livestock(34, 1994, 417.749459);
                yield return new livestock(35, 1995, 412.233904);
                yield return new livestock(36, 1996, 411.946817);
                yield return new livestock(37, 1997, 394.697075);
                yield return new livestock(38, 1998, 401.49927);
                yield return new livestock(39, 1999, 408.270468);
                yield return new livestock(40, 2000, 414.2428);
                yield return new livestock(41, 2001, 407.997978);
                yield return new livestock(42, 2002, 403.460832);
                yield return new livestock(43, 2003, 413.824928);
                yield return new livestock(44, 2004, 428.104959);
                yield return new livestock(45, 2005, 445.338742);
                yield return new livestock(46, 2006, 452.994173);
                yield return new livestock(47, 2007, 455.74017);
            }
        }
    }
}
