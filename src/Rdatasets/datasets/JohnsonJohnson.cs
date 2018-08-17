// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Earnings per Johnson & Johnson Share
    /// </summary>

    public class JohnsonJohnson
    {
        public readonly double time;
        public readonly double value;

        public JohnsonJohnson(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<JohnsonJohnson> Data
        {
            get
            {
                yield return new JohnsonJohnson(1960, 0.71);
                yield return new JohnsonJohnson(1960.25, 0.63);
                yield return new JohnsonJohnson(1960.5, 0.85);
                yield return new JohnsonJohnson(1960.75, 0.44);
                yield return new JohnsonJohnson(1961, 0.61);
                yield return new JohnsonJohnson(1961.25, 0.69);
                yield return new JohnsonJohnson(1961.5, 0.92);
                yield return new JohnsonJohnson(1961.75, 0.55);
                yield return new JohnsonJohnson(1962, 0.72);
                yield return new JohnsonJohnson(1962.25, 0.77);
                yield return new JohnsonJohnson(1962.5, 0.92);
                yield return new JohnsonJohnson(1962.75, 0.6);
                yield return new JohnsonJohnson(1963, 0.83);
                yield return new JohnsonJohnson(1963.25, 0.8);
                yield return new JohnsonJohnson(1963.5, 1);
                yield return new JohnsonJohnson(1963.75, 0.77);
                yield return new JohnsonJohnson(1964, 0.92);
                yield return new JohnsonJohnson(1964.25, 1);
                yield return new JohnsonJohnson(1964.5, 1.24);
                yield return new JohnsonJohnson(1964.75, 1);
                yield return new JohnsonJohnson(1965, 1.16);
                yield return new JohnsonJohnson(1965.25, 1.3);
                yield return new JohnsonJohnson(1965.5, 1.45);
                yield return new JohnsonJohnson(1965.75, 1.25);
                yield return new JohnsonJohnson(1966, 1.26);
                yield return new JohnsonJohnson(1966.25, 1.38);
                yield return new JohnsonJohnson(1966.5, 1.86);
                yield return new JohnsonJohnson(1966.75, 1.56);
                yield return new JohnsonJohnson(1967, 1.53);
                yield return new JohnsonJohnson(1967.25, 1.59);
                yield return new JohnsonJohnson(1967.5, 1.83);
                yield return new JohnsonJohnson(1967.75, 1.86);
                yield return new JohnsonJohnson(1968, 1.53);
                yield return new JohnsonJohnson(1968.25, 2.07);
                yield return new JohnsonJohnson(1968.5, 2.34);
                yield return new JohnsonJohnson(1968.75, 2.25);
                yield return new JohnsonJohnson(1969, 2.16);
                yield return new JohnsonJohnson(1969.25, 2.43);
                yield return new JohnsonJohnson(1969.5, 2.7);
                yield return new JohnsonJohnson(1969.75, 2.25);
                yield return new JohnsonJohnson(1970, 2.79);
                yield return new JohnsonJohnson(1970.25, 3.42);
                yield return new JohnsonJohnson(1970.5, 3.69);
                yield return new JohnsonJohnson(1970.75, 3.6);
                yield return new JohnsonJohnson(1971, 3.6);
                yield return new JohnsonJohnson(1971.25, 4.32);
                yield return new JohnsonJohnson(1971.5, 4.32);
                yield return new JohnsonJohnson(1971.75, 4.05);
                yield return new JohnsonJohnson(1972, 4.86);
                yield return new JohnsonJohnson(1972.25, 5.04);
                yield return new JohnsonJohnson(1972.5, 5.04);
                yield return new JohnsonJohnson(1972.75, 4.41);
                yield return new JohnsonJohnson(1973, 5.58);
                yield return new JohnsonJohnson(1973.25, 5.85);
                yield return new JohnsonJohnson(1973.5, 6.57);
                yield return new JohnsonJohnson(1973.75, 5.31);
                yield return new JohnsonJohnson(1974, 6.03);
                yield return new JohnsonJohnson(1974.25, 6.39);
                yield return new JohnsonJohnson(1974.5, 6.93);
                yield return new JohnsonJohnson(1974.75, 5.85);
                yield return new JohnsonJohnson(1975, 6.93);
                yield return new JohnsonJohnson(1975.25, 7.74);
                yield return new JohnsonJohnson(1975.5, 7.83);
                yield return new JohnsonJohnson(1975.75, 6.12);
                yield return new JohnsonJohnson(1976, 7.74);
                yield return new JohnsonJohnson(1976.25, 8.91);
                yield return new JohnsonJohnson(1976.5, 8.28);
                yield return new JohnsonJohnson(1976.75, 6.84);
                yield return new JohnsonJohnson(1977, 9.54);
                yield return new JohnsonJohnson(1977.25, 10.26);
                yield return new JohnsonJohnson(1977.5, 9.54);
                yield return new JohnsonJohnson(1977.75, 8.73);
                yield return new JohnsonJohnson(1978, 11.88);
                yield return new JohnsonJohnson(1978.25, 12.06);
                yield return new JohnsonJohnson(1978.5, 12.15);
                yield return new JohnsonJohnson(1978.75, 8.91);
                yield return new JohnsonJohnson(1979, 14.04);
                yield return new JohnsonJohnson(1979.25, 12.96);
                yield return new JohnsonJohnson(1979.5, 14.85);
                yield return new JohnsonJohnson(1979.75, 9.99);
                yield return new JohnsonJohnson(1980, 16.2);
                yield return new JohnsonJohnson(1980.25, 14.67);
                yield return new JohnsonJohnson(1980.5, 16.02);
                yield return new JohnsonJohnson(1980.75, 11.61);
            }
        }
    }
}
