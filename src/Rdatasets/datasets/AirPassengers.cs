// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly Airline Passenger Numbers 1949-1960
    /// </summary>

    public class AirPassengers
    {
        public readonly int κ;
        public readonly double time;
        public readonly int value;

        public AirPassengers(int κ, double time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<AirPassengers> Data
        {
            get
            {
                yield return new AirPassengers(1, 1949, 112);
                yield return new AirPassengers(2, 1949.08333333333, 118);
                yield return new AirPassengers(3, 1949.16666666667, 132);
                yield return new AirPassengers(4, 1949.25, 129);
                yield return new AirPassengers(5, 1949.33333333333, 121);
                yield return new AirPassengers(6, 1949.41666666667, 135);
                yield return new AirPassengers(7, 1949.5, 148);
                yield return new AirPassengers(8, 1949.58333333333, 148);
                yield return new AirPassengers(9, 1949.66666666667, 136);
                yield return new AirPassengers(10, 1949.75, 119);
                yield return new AirPassengers(11, 1949.83333333333, 104);
                yield return new AirPassengers(12, 1949.91666666667, 118);
                yield return new AirPassengers(13, 1950, 115);
                yield return new AirPassengers(14, 1950.08333333333, 126);
                yield return new AirPassengers(15, 1950.16666666667, 141);
                yield return new AirPassengers(16, 1950.25, 135);
                yield return new AirPassengers(17, 1950.33333333333, 125);
                yield return new AirPassengers(18, 1950.41666666667, 149);
                yield return new AirPassengers(19, 1950.5, 170);
                yield return new AirPassengers(20, 1950.58333333333, 170);
                yield return new AirPassengers(21, 1950.66666666667, 158);
                yield return new AirPassengers(22, 1950.75, 133);
                yield return new AirPassengers(23, 1950.83333333333, 114);
                yield return new AirPassengers(24, 1950.91666666667, 140);
                yield return new AirPassengers(25, 1951, 145);
                yield return new AirPassengers(26, 1951.08333333333, 150);
                yield return new AirPassengers(27, 1951.16666666667, 178);
                yield return new AirPassengers(28, 1951.25, 163);
                yield return new AirPassengers(29, 1951.33333333333, 172);
                yield return new AirPassengers(30, 1951.41666666667, 178);
                yield return new AirPassengers(31, 1951.5, 199);
                yield return new AirPassengers(32, 1951.58333333333, 199);
                yield return new AirPassengers(33, 1951.66666666667, 184);
                yield return new AirPassengers(34, 1951.75, 162);
                yield return new AirPassengers(35, 1951.83333333333, 146);
                yield return new AirPassengers(36, 1951.91666666667, 166);
                yield return new AirPassengers(37, 1952, 171);
                yield return new AirPassengers(38, 1952.08333333333, 180);
                yield return new AirPassengers(39, 1952.16666666667, 193);
                yield return new AirPassengers(40, 1952.25, 181);
                yield return new AirPassengers(41, 1952.33333333333, 183);
                yield return new AirPassengers(42, 1952.41666666667, 218);
                yield return new AirPassengers(43, 1952.5, 230);
                yield return new AirPassengers(44, 1952.58333333333, 242);
                yield return new AirPassengers(45, 1952.66666666667, 209);
                yield return new AirPassengers(46, 1952.75, 191);
                yield return new AirPassengers(47, 1952.83333333333, 172);
                yield return new AirPassengers(48, 1952.91666666667, 194);
                yield return new AirPassengers(49, 1953, 196);
                yield return new AirPassengers(50, 1953.08333333333, 196);
                yield return new AirPassengers(51, 1953.16666666667, 236);
                yield return new AirPassengers(52, 1953.25, 235);
                yield return new AirPassengers(53, 1953.33333333333, 229);
                yield return new AirPassengers(54, 1953.41666666667, 243);
                yield return new AirPassengers(55, 1953.5, 264);
                yield return new AirPassengers(56, 1953.58333333333, 272);
                yield return new AirPassengers(57, 1953.66666666667, 237);
                yield return new AirPassengers(58, 1953.75, 211);
                yield return new AirPassengers(59, 1953.83333333333, 180);
                yield return new AirPassengers(60, 1953.91666666667, 201);
                yield return new AirPassengers(61, 1954, 204);
                yield return new AirPassengers(62, 1954.08333333333, 188);
                yield return new AirPassengers(63, 1954.16666666667, 235);
                yield return new AirPassengers(64, 1954.25, 227);
                yield return new AirPassengers(65, 1954.33333333333, 234);
                yield return new AirPassengers(66, 1954.41666666667, 264);
                yield return new AirPassengers(67, 1954.5, 302);
                yield return new AirPassengers(68, 1954.58333333333, 293);
                yield return new AirPassengers(69, 1954.66666666667, 259);
                yield return new AirPassengers(70, 1954.75, 229);
                yield return new AirPassengers(71, 1954.83333333333, 203);
                yield return new AirPassengers(72, 1954.91666666667, 229);
                yield return new AirPassengers(73, 1955, 242);
                yield return new AirPassengers(74, 1955.08333333334, 233);
                yield return new AirPassengers(75, 1955.16666666667, 267);
                yield return new AirPassengers(76, 1955.25, 269);
                yield return new AirPassengers(77, 1955.33333333334, 270);
                yield return new AirPassengers(78, 1955.41666666667, 315);
                yield return new AirPassengers(79, 1955.5, 364);
                yield return new AirPassengers(80, 1955.58333333334, 347);
                yield return new AirPassengers(81, 1955.66666666667, 312);
                yield return new AirPassengers(82, 1955.75, 274);
                yield return new AirPassengers(83, 1955.83333333334, 237);
                yield return new AirPassengers(84, 1955.91666666667, 278);
                yield return new AirPassengers(85, 1956, 284);
                yield return new AirPassengers(86, 1956.08333333334, 277);
                yield return new AirPassengers(87, 1956.16666666667, 317);
                yield return new AirPassengers(88, 1956.25, 313);
                yield return new AirPassengers(89, 1956.33333333334, 318);
                yield return new AirPassengers(90, 1956.41666666667, 374);
                yield return new AirPassengers(91, 1956.5, 413);
                yield return new AirPassengers(92, 1956.58333333334, 405);
                yield return new AirPassengers(93, 1956.66666666667, 355);
                yield return new AirPassengers(94, 1956.75, 306);
                yield return new AirPassengers(95, 1956.83333333334, 271);
                yield return new AirPassengers(96, 1956.91666666667, 306);
                yield return new AirPassengers(97, 1957, 315);
                yield return new AirPassengers(98, 1957.08333333334, 301);
                yield return new AirPassengers(99, 1957.16666666667, 356);
                yield return new AirPassengers(100, 1957.25, 348);
                yield return new AirPassengers(101, 1957.33333333334, 355);
                yield return new AirPassengers(102, 1957.41666666667, 422);
                yield return new AirPassengers(103, 1957.5, 465);
                yield return new AirPassengers(104, 1957.58333333334, 467);
                yield return new AirPassengers(105, 1957.66666666667, 404);
                yield return new AirPassengers(106, 1957.75, 347);
                yield return new AirPassengers(107, 1957.83333333334, 305);
                yield return new AirPassengers(108, 1957.91666666667, 336);
                yield return new AirPassengers(109, 1958, 340);
                yield return new AirPassengers(110, 1958.08333333334, 318);
                yield return new AirPassengers(111, 1958.16666666667, 362);
                yield return new AirPassengers(112, 1958.25, 348);
                yield return new AirPassengers(113, 1958.33333333334, 363);
                yield return new AirPassengers(114, 1958.41666666667, 435);
                yield return new AirPassengers(115, 1958.5, 491);
                yield return new AirPassengers(116, 1958.58333333334, 505);
                yield return new AirPassengers(117, 1958.66666666667, 404);
                yield return new AirPassengers(118, 1958.75, 359);
                yield return new AirPassengers(119, 1958.83333333334, 310);
                yield return new AirPassengers(120, 1958.91666666667, 337);
                yield return new AirPassengers(121, 1959, 360);
                yield return new AirPassengers(122, 1959.08333333334, 342);
                yield return new AirPassengers(123, 1959.16666666667, 406);
                yield return new AirPassengers(124, 1959.25, 396);
                yield return new AirPassengers(125, 1959.33333333334, 420);
                yield return new AirPassengers(126, 1959.41666666667, 472);
                yield return new AirPassengers(127, 1959.5, 548);
                yield return new AirPassengers(128, 1959.58333333334, 559);
                yield return new AirPassengers(129, 1959.66666666667, 463);
                yield return new AirPassengers(130, 1959.75, 407);
                yield return new AirPassengers(131, 1959.83333333334, 362);
                yield return new AirPassengers(132, 1959.91666666667, 405);
                yield return new AirPassengers(133, 1960, 417);
                yield return new AirPassengers(134, 1960.08333333334, 391);
                yield return new AirPassengers(135, 1960.16666666667, 419);
                yield return new AirPassengers(136, 1960.25, 461);
                yield return new AirPassengers(137, 1960.33333333334, 472);
                yield return new AirPassengers(138, 1960.41666666667, 535);
                yield return new AirPassengers(139, 1960.5, 622);
                yield return new AirPassengers(140, 1960.58333333334, 606);
                yield return new AirPassengers(141, 1960.66666666667, 508);
                yield return new AirPassengers(142, 1960.75, 461);
                yield return new AirPassengers(143, 1960.83333333334, 390);
                yield return new AirPassengers(144, 1960.91666666667, 432);
            }
        }
    }
}
