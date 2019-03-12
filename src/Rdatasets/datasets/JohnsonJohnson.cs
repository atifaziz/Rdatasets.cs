// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Earnings per Johnson & Johnson Share
    /// </summary>

    public class JohnsonJohnson
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public JohnsonJohnson(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<JohnsonJohnson> Data
        {
            get
            {
                yield return new JohnsonJohnson(1, 1960, 0.71);
                yield return new JohnsonJohnson(2, 1960.25, 0.63);
                yield return new JohnsonJohnson(3, 1960.5, 0.85);
                yield return new JohnsonJohnson(4, 1960.75, 0.44);
                yield return new JohnsonJohnson(5, 1961, 0.61);
                yield return new JohnsonJohnson(6, 1961.25, 0.69);
                yield return new JohnsonJohnson(7, 1961.5, 0.92);
                yield return new JohnsonJohnson(8, 1961.75, 0.55);
                yield return new JohnsonJohnson(9, 1962, 0.72);
                yield return new JohnsonJohnson(10, 1962.25, 0.77);
                yield return new JohnsonJohnson(11, 1962.5, 0.92);
                yield return new JohnsonJohnson(12, 1962.75, 0.6);
                yield return new JohnsonJohnson(13, 1963, 0.83);
                yield return new JohnsonJohnson(14, 1963.25, 0.8);
                yield return new JohnsonJohnson(15, 1963.5, 1);
                yield return new JohnsonJohnson(16, 1963.75, 0.77);
                yield return new JohnsonJohnson(17, 1964, 0.92);
                yield return new JohnsonJohnson(18, 1964.25, 1);
                yield return new JohnsonJohnson(19, 1964.5, 1.24);
                yield return new JohnsonJohnson(20, 1964.75, 1);
                yield return new JohnsonJohnson(21, 1965, 1.16);
                yield return new JohnsonJohnson(22, 1965.25, 1.3);
                yield return new JohnsonJohnson(23, 1965.5, 1.45);
                yield return new JohnsonJohnson(24, 1965.75, 1.25);
                yield return new JohnsonJohnson(25, 1966, 1.26);
                yield return new JohnsonJohnson(26, 1966.25, 1.38);
                yield return new JohnsonJohnson(27, 1966.5, 1.86);
                yield return new JohnsonJohnson(28, 1966.75, 1.56);
                yield return new JohnsonJohnson(29, 1967, 1.53);
                yield return new JohnsonJohnson(30, 1967.25, 1.59);
                yield return new JohnsonJohnson(31, 1967.5, 1.83);
                yield return new JohnsonJohnson(32, 1967.75, 1.86);
                yield return new JohnsonJohnson(33, 1968, 1.53);
                yield return new JohnsonJohnson(34, 1968.25, 2.07);
                yield return new JohnsonJohnson(35, 1968.5, 2.34);
                yield return new JohnsonJohnson(36, 1968.75, 2.25);
                yield return new JohnsonJohnson(37, 1969, 2.16);
                yield return new JohnsonJohnson(38, 1969.25, 2.43);
                yield return new JohnsonJohnson(39, 1969.5, 2.7);
                yield return new JohnsonJohnson(40, 1969.75, 2.25);
                yield return new JohnsonJohnson(41, 1970, 2.79);
                yield return new JohnsonJohnson(42, 1970.25, 3.42);
                yield return new JohnsonJohnson(43, 1970.5, 3.69);
                yield return new JohnsonJohnson(44, 1970.75, 3.6);
                yield return new JohnsonJohnson(45, 1971, 3.6);
                yield return new JohnsonJohnson(46, 1971.25, 4.32);
                yield return new JohnsonJohnson(47, 1971.5, 4.32);
                yield return new JohnsonJohnson(48, 1971.75, 4.05);
                yield return new JohnsonJohnson(49, 1972, 4.86);
                yield return new JohnsonJohnson(50, 1972.25, 5.04);
                yield return new JohnsonJohnson(51, 1972.5, 5.04);
                yield return new JohnsonJohnson(52, 1972.75, 4.41);
                yield return new JohnsonJohnson(53, 1973, 5.58);
                yield return new JohnsonJohnson(54, 1973.25, 5.85);
                yield return new JohnsonJohnson(55, 1973.5, 6.57);
                yield return new JohnsonJohnson(56, 1973.75, 5.31);
                yield return new JohnsonJohnson(57, 1974, 6.03);
                yield return new JohnsonJohnson(58, 1974.25, 6.39);
                yield return new JohnsonJohnson(59, 1974.5, 6.93);
                yield return new JohnsonJohnson(60, 1974.75, 5.85);
                yield return new JohnsonJohnson(61, 1975, 6.93);
                yield return new JohnsonJohnson(62, 1975.25, 7.74);
                yield return new JohnsonJohnson(63, 1975.5, 7.83);
                yield return new JohnsonJohnson(64, 1975.75, 6.12);
                yield return new JohnsonJohnson(65, 1976, 7.74);
                yield return new JohnsonJohnson(66, 1976.25, 8.91);
                yield return new JohnsonJohnson(67, 1976.5, 8.28);
                yield return new JohnsonJohnson(68, 1976.75, 6.84);
                yield return new JohnsonJohnson(69, 1977, 9.54);
                yield return new JohnsonJohnson(70, 1977.25, 10.26);
                yield return new JohnsonJohnson(71, 1977.5, 9.54);
                yield return new JohnsonJohnson(72, 1977.75, 8.73);
                yield return new JohnsonJohnson(73, 1978, 11.88);
                yield return new JohnsonJohnson(74, 1978.25, 12.06);
                yield return new JohnsonJohnson(75, 1978.5, 12.15);
                yield return new JohnsonJohnson(76, 1978.75, 8.91);
                yield return new JohnsonJohnson(77, 1979, 14.04);
                yield return new JohnsonJohnson(78, 1979.25, 12.96);
                yield return new JohnsonJohnson(79, 1979.5, 14.85);
                yield return new JohnsonJohnson(80, 1979.75, 9.99);
                yield return new JohnsonJohnson(81, 1980, 16.2);
                yield return new JohnsonJohnson(82, 1980.25, 14.67);
                yield return new JohnsonJohnson(83, 1980.5, 16.02);
                yield return new JohnsonJohnson(84, 1980.75, 11.61);
            }
        }
    }
}
