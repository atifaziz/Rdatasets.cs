// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Approval Ratings of US Presidents
    /// </summary>

    public class presidents
    {
        public readonly int κ;
        public readonly double time;
        public readonly int? value;

        public presidents(int κ, double time, int? value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<presidents> Data
        {
            get
            {
                yield return new presidents(1, 1945, null);
                yield return new presidents(2, 1945.25, 87);
                yield return new presidents(3, 1945.5, 82);
                yield return new presidents(4, 1945.75, 75);
                yield return new presidents(5, 1946, 63);
                yield return new presidents(6, 1946.25, 50);
                yield return new presidents(7, 1946.5, 43);
                yield return new presidents(8, 1946.75, 32);
                yield return new presidents(9, 1947, 35);
                yield return new presidents(10, 1947.25, 60);
                yield return new presidents(11, 1947.5, 54);
                yield return new presidents(12, 1947.75, 55);
                yield return new presidents(13, 1948, 36);
                yield return new presidents(14, 1948.25, 39);
                yield return new presidents(15, 1948.5, null);
                yield return new presidents(16, 1948.75, null);
                yield return new presidents(17, 1949, 69);
                yield return new presidents(18, 1949.25, 57);
                yield return new presidents(19, 1949.5, 57);
                yield return new presidents(20, 1949.75, 51);
                yield return new presidents(21, 1950, 45);
                yield return new presidents(22, 1950.25, 37);
                yield return new presidents(23, 1950.5, 46);
                yield return new presidents(24, 1950.75, 39);
                yield return new presidents(25, 1951, 36);
                yield return new presidents(26, 1951.25, 24);
                yield return new presidents(27, 1951.5, 32);
                yield return new presidents(28, 1951.75, 23);
                yield return new presidents(29, 1952, 25);
                yield return new presidents(30, 1952.25, 32);
                yield return new presidents(31, 1952.5, null);
                yield return new presidents(32, 1952.75, 32);
                yield return new presidents(33, 1953, 59);
                yield return new presidents(34, 1953.25, 74);
                yield return new presidents(35, 1953.5, 75);
                yield return new presidents(36, 1953.75, 60);
                yield return new presidents(37, 1954, 71);
                yield return new presidents(38, 1954.25, 61);
                yield return new presidents(39, 1954.5, 71);
                yield return new presidents(40, 1954.75, 57);
                yield return new presidents(41, 1955, 71);
                yield return new presidents(42, 1955.25, 68);
                yield return new presidents(43, 1955.5, 79);
                yield return new presidents(44, 1955.75, 73);
                yield return new presidents(45, 1956, 76);
                yield return new presidents(46, 1956.25, 71);
                yield return new presidents(47, 1956.5, 67);
                yield return new presidents(48, 1956.75, 75);
                yield return new presidents(49, 1957, 79);
                yield return new presidents(50, 1957.25, 62);
                yield return new presidents(51, 1957.5, 63);
                yield return new presidents(52, 1957.75, 57);
                yield return new presidents(53, 1958, 60);
                yield return new presidents(54, 1958.25, 49);
                yield return new presidents(55, 1958.5, 48);
                yield return new presidents(56, 1958.75, 52);
                yield return new presidents(57, 1959, 57);
                yield return new presidents(58, 1959.25, 62);
                yield return new presidents(59, 1959.5, 61);
                yield return new presidents(60, 1959.75, 66);
                yield return new presidents(61, 1960, 71);
                yield return new presidents(62, 1960.25, 62);
                yield return new presidents(63, 1960.5, 61);
                yield return new presidents(64, 1960.75, 57);
                yield return new presidents(65, 1961, 72);
                yield return new presidents(66, 1961.25, 83);
                yield return new presidents(67, 1961.5, 71);
                yield return new presidents(68, 1961.75, 78);
                yield return new presidents(69, 1962, 79);
                yield return new presidents(70, 1962.25, 71);
                yield return new presidents(71, 1962.5, 62);
                yield return new presidents(72, 1962.75, 74);
                yield return new presidents(73, 1963, 76);
                yield return new presidents(74, 1963.25, 64);
                yield return new presidents(75, 1963.5, 62);
                yield return new presidents(76, 1963.75, 57);
                yield return new presidents(77, 1964, 80);
                yield return new presidents(78, 1964.25, 73);
                yield return new presidents(79, 1964.5, 69);
                yield return new presidents(80, 1964.75, 69);
                yield return new presidents(81, 1965, 71);
                yield return new presidents(82, 1965.25, 64);
                yield return new presidents(83, 1965.5, 69);
                yield return new presidents(84, 1965.75, 62);
                yield return new presidents(85, 1966, 63);
                yield return new presidents(86, 1966.25, 46);
                yield return new presidents(87, 1966.5, 56);
                yield return new presidents(88, 1966.75, 44);
                yield return new presidents(89, 1967, 44);
                yield return new presidents(90, 1967.25, 52);
                yield return new presidents(91, 1967.5, 38);
                yield return new presidents(92, 1967.75, 46);
                yield return new presidents(93, 1968, 36);
                yield return new presidents(94, 1968.25, 49);
                yield return new presidents(95, 1968.5, 35);
                yield return new presidents(96, 1968.75, 44);
                yield return new presidents(97, 1969, 59);
                yield return new presidents(98, 1969.25, 65);
                yield return new presidents(99, 1969.5, 65);
                yield return new presidents(100, 1969.75, 56);
                yield return new presidents(101, 1970, 66);
                yield return new presidents(102, 1970.25, 53);
                yield return new presidents(103, 1970.5, 61);
                yield return new presidents(104, 1970.75, 52);
                yield return new presidents(105, 1971, 51);
                yield return new presidents(106, 1971.25, 48);
                yield return new presidents(107, 1971.5, 54);
                yield return new presidents(108, 1971.75, 49);
                yield return new presidents(109, 1972, 49);
                yield return new presidents(110, 1972.25, 61);
                yield return new presidents(111, 1972.5, null);
                yield return new presidents(112, 1972.75, null);
                yield return new presidents(113, 1973, 68);
                yield return new presidents(114, 1973.25, 44);
                yield return new presidents(115, 1973.5, 40);
                yield return new presidents(116, 1973.75, 27);
                yield return new presidents(117, 1974, 28);
                yield return new presidents(118, 1974.25, 25);
                yield return new presidents(119, 1974.5, 24);
                yield return new presidents(120, 1974.75, 24);
            }
        }
    }
}
