// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Livestock (sheep) in Asia, 1961-2007.
    /// </summary>

    public class livestock
    {
        public readonly int time;
        public readonly double value;

        public livestock(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<livestock> Data
        {
            get
            {
                yield return new livestock(1961, 232.288994);
                yield return new livestock(1962, 229.536258);
                yield return new livestock(1963, 233.145936);
                yield return new livestock(1964, 243.763684);
                yield return new livestock(1965, 252.602916);
                yield return new livestock(1966, 259.677371);
                yield return new livestock(1967, 260.766892);
                yield return new livestock(1968, 269.784084);
                yield return new livestock(1969, 266.414974);
                yield return new livestock(1970, 263.917747);
                yield return new livestock(1971, 268.307222);
                yield return new livestock(1972, 260.662556);
                yield return new livestock(1973, 266.639419);
                yield return new livestock(1974, 277.515778);
                yield return new livestock(1975, 283.834045);
                yield return new livestock(1976, 290.309028);
                yield return new livestock(1977, 292.474198);
                yield return new livestock(1978, 300.830694);
                yield return new livestock(1979, 309.286657);
                yield return new livestock(1980, 318.331081);
                yield return new livestock(1981, 329.37239);
                yield return new livestock(1982, 338.883998);
                yield return new livestock(1983, 339.244126);
                yield return new livestock(1984, 328.600632);
                yield return new livestock(1985, 314.255385);
                yield return new livestock(1986, 314.459695);
                yield return new livestock(1987, 321.413779);
                yield return new livestock(1988, 329.789292);
                yield return new livestock(1989, 346.385165);
                yield return new livestock(1990, 352.297882);
                yield return new livestock(1991, 348.370515);
                yield return new livestock(1992, 417.562922);
                yield return new livestock(1993, 417.12357);
                yield return new livestock(1994, 417.749459);
                yield return new livestock(1995, 412.233904);
                yield return new livestock(1996, 411.946817);
                yield return new livestock(1997, 394.697075);
                yield return new livestock(1998, 401.49927);
                yield return new livestock(1999, 408.270468);
                yield return new livestock(2000, 414.2428);
                yield return new livestock(2001, 407.997978);
                yield return new livestock(2002, 403.460832);
                yield return new livestock(2003, 413.824928);
                yield return new livestock(2004, 428.104959);
                yield return new livestock(2005, 445.338742);
                yield return new livestock(2006, 452.994173);
                yield return new livestock(2007, 455.74017);
            }
        }
    }
}
