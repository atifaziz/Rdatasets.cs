// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual oil production in Saudi Arabia
    /// </summary>

    public class oil
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public oil(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<oil> Data
        {
            get
            {
                yield return new oil(1, 1965, 111.009134615);
                yield return new oil(2, 1966, 130.828434066);
                yield return new oil(3, 1967, 141.287087912);
                yield return new oil(4, 1968, 154.227774725);
                yield return new oil(5, 1969, 162.740865385);
                yield return new oil(6, 1970, 192.166483516);
                yield return new oil(7, 1971, 240.799725275);
                yield return new oil(8, 1972, 304.21739011);
                yield return new oil(9, 1973, 384.004567308);
                yield return new oil(10, 1974, 429.662156593);
                yield return new oil(11, 1975, 359.316929945);
                yield return new oil(12, 1976, 437.251854396);
                yield return new oil(13, 1977, 468.400789835);
                yield return new oil(14, 1978, 424.435336538);
                yield return new oil(15, 1979, 487.979429945);
                yield return new oil(16, 1980, 509.828447802);
                yield return new oil(17, 1981, 506.347252747);
                yield return new oil(18, 1982, 340.184237416);
                yield return new oil(19, 1983, 240.258921039);
                yield return new oil(20, 1984, 219.032787575);
                yield return new oil(21, 1985, 172.07466324);
                yield return new oil(22, 1986, 252.590092166);
                yield return new oil(23, 1987, 221.07107741);
                yield return new oil(24, 1988, 276.518773485);
                yield return new oil(25, 1989, 271.147951746);
                yield return new oil(26, 1990, 342.618600452);
                yield return new oil(27, 1991, 428.355835697);
                yield return new oil(28, 1992, 442.39455335);
                yield return new oil(29, 1993, 432.785148219);
                yield return new oil(30, 1994, 437.249718628);
                yield return new oil(31, 1995, 437.209159929);
                yield return new oil(32, 1996, 445.364098092);
                yield return new oil(33, 1997, 453.195010427);
                yield return new oil(34, 1998, 454.409641012);
                yield return new oil(35, 1999, 422.378905779);
                yield return new oil(36, 2000, 456.037121728);
                yield return new oil(37, 2001, 440.386604674);
                yield return new oil(38, 2002, 425.194372519);
                yield return new oil(39, 2003, 486.20517351);
                yield return new oil(40, 2004, 500.429086073);
                yield return new oil(41, 2005, 521.27590917);
                yield return new oil(42, 2006, 508.947617045);
                yield return new oil(43, 2007, 488.888857729);
                yield return new oil(44, 2008, 509.870574978);
                yield return new oil(45, 2009, 456.722912348);
                yield return new oil(46, 2010, 473.816602915);
                yield return new oil(47, 2011, 525.950870565);
                yield return new oil(48, 2012, 549.833807597);
                yield return new oil(49, 2013, 542.340469826);
            }
        }
    }
}
