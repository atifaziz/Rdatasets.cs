// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Approval Ratings of US Presidents
    /// </summary>

    public class presidents
    {
        public readonly double time;
        public readonly string value;

        public presidents(double time, string value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<presidents> Data
        {
            get
            {
                yield return new presidents(1945, null);
                yield return new presidents(1945.25, "87");
                yield return new presidents(1945.5, "82");
                yield return new presidents(1945.75, "75");
                yield return new presidents(1946, "63");
                yield return new presidents(1946.25, "50");
                yield return new presidents(1946.5, "43");
                yield return new presidents(1946.75, "32");
                yield return new presidents(1947, "35");
                yield return new presidents(1947.25, "60");
                yield return new presidents(1947.5, "54");
                yield return new presidents(1947.75, "55");
                yield return new presidents(1948, "36");
                yield return new presidents(1948.25, "39");
                yield return new presidents(1948.5, null);
                yield return new presidents(1948.75, null);
                yield return new presidents(1949, "69");
                yield return new presidents(1949.25, "57");
                yield return new presidents(1949.5, "57");
                yield return new presidents(1949.75, "51");
                yield return new presidents(1950, "45");
                yield return new presidents(1950.25, "37");
                yield return new presidents(1950.5, "46");
                yield return new presidents(1950.75, "39");
                yield return new presidents(1951, "36");
                yield return new presidents(1951.25, "24");
                yield return new presidents(1951.5, "32");
                yield return new presidents(1951.75, "23");
                yield return new presidents(1952, "25");
                yield return new presidents(1952.25, "32");
                yield return new presidents(1952.5, null);
                yield return new presidents(1952.75, "32");
                yield return new presidents(1953, "59");
                yield return new presidents(1953.25, "74");
                yield return new presidents(1953.5, "75");
                yield return new presidents(1953.75, "60");
                yield return new presidents(1954, "71");
                yield return new presidents(1954.25, "61");
                yield return new presidents(1954.5, "71");
                yield return new presidents(1954.75, "57");
                yield return new presidents(1955, "71");
                yield return new presidents(1955.25, "68");
                yield return new presidents(1955.5, "79");
                yield return new presidents(1955.75, "73");
                yield return new presidents(1956, "76");
                yield return new presidents(1956.25, "71");
                yield return new presidents(1956.5, "67");
                yield return new presidents(1956.75, "75");
                yield return new presidents(1957, "79");
                yield return new presidents(1957.25, "62");
                yield return new presidents(1957.5, "63");
                yield return new presidents(1957.75, "57");
                yield return new presidents(1958, "60");
                yield return new presidents(1958.25, "49");
                yield return new presidents(1958.5, "48");
                yield return new presidents(1958.75, "52");
                yield return new presidents(1959, "57");
                yield return new presidents(1959.25, "62");
                yield return new presidents(1959.5, "61");
                yield return new presidents(1959.75, "66");
                yield return new presidents(1960, "71");
                yield return new presidents(1960.25, "62");
                yield return new presidents(1960.5, "61");
                yield return new presidents(1960.75, "57");
                yield return new presidents(1961, "72");
                yield return new presidents(1961.25, "83");
                yield return new presidents(1961.5, "71");
                yield return new presidents(1961.75, "78");
                yield return new presidents(1962, "79");
                yield return new presidents(1962.25, "71");
                yield return new presidents(1962.5, "62");
                yield return new presidents(1962.75, "74");
                yield return new presidents(1963, "76");
                yield return new presidents(1963.25, "64");
                yield return new presidents(1963.5, "62");
                yield return new presidents(1963.75, "57");
                yield return new presidents(1964, "80");
                yield return new presidents(1964.25, "73");
                yield return new presidents(1964.5, "69");
                yield return new presidents(1964.75, "69");
                yield return new presidents(1965, "71");
                yield return new presidents(1965.25, "64");
                yield return new presidents(1965.5, "69");
                yield return new presidents(1965.75, "62");
                yield return new presidents(1966, "63");
                yield return new presidents(1966.25, "46");
                yield return new presidents(1966.5, "56");
                yield return new presidents(1966.75, "44");
                yield return new presidents(1967, "44");
                yield return new presidents(1967.25, "52");
                yield return new presidents(1967.5, "38");
                yield return new presidents(1967.75, "46");
                yield return new presidents(1968, "36");
                yield return new presidents(1968.25, "49");
                yield return new presidents(1968.5, "35");
                yield return new presidents(1968.75, "44");
                yield return new presidents(1969, "59");
                yield return new presidents(1969.25, "65");
                yield return new presidents(1969.5, "65");
                yield return new presidents(1969.75, "56");
                yield return new presidents(1970, "66");
                yield return new presidents(1970.25, "53");
                yield return new presidents(1970.5, "61");
                yield return new presidents(1970.75, "52");
                yield return new presidents(1971, "51");
                yield return new presidents(1971.25, "48");
                yield return new presidents(1971.5, "54");
                yield return new presidents(1971.75, "49");
                yield return new presidents(1972, "49");
                yield return new presidents(1972.25, "61");
                yield return new presidents(1972.5, null);
                yield return new presidents(1972.75, null);
                yield return new presidents(1973, "68");
                yield return new presidents(1973.25, "44");
                yield return new presidents(1973.5, "40");
                yield return new presidents(1973.75, "27");
                yield return new presidents(1974, "28");
                yield return new presidents(1974.25, "25");
                yield return new presidents(1974.5, "24");
                yield return new presidents(1974.75, "24");
            }
        }
    }
}
