// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly Airline Passenger Numbers 1949-1960
    /// </summary>

    public class AirPassengers
    {
        public readonly double time;
        public readonly int value;

        public AirPassengers(double time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<AirPassengers> Data
        {
            get
            {
                yield return new AirPassengers(1949, 112);
                yield return new AirPassengers(1949.08333333333, 118);
                yield return new AirPassengers(1949.16666666667, 132);
                yield return new AirPassengers(1949.25, 129);
                yield return new AirPassengers(1949.33333333333, 121);
                yield return new AirPassengers(1949.41666666667, 135);
                yield return new AirPassengers(1949.5, 148);
                yield return new AirPassengers(1949.58333333333, 148);
                yield return new AirPassengers(1949.66666666667, 136);
                yield return new AirPassengers(1949.75, 119);
                yield return new AirPassengers(1949.83333333333, 104);
                yield return new AirPassengers(1949.91666666667, 118);
                yield return new AirPassengers(1950, 115);
                yield return new AirPassengers(1950.08333333333, 126);
                yield return new AirPassengers(1950.16666666667, 141);
                yield return new AirPassengers(1950.25, 135);
                yield return new AirPassengers(1950.33333333333, 125);
                yield return new AirPassengers(1950.41666666667, 149);
                yield return new AirPassengers(1950.5, 170);
                yield return new AirPassengers(1950.58333333333, 170);
                yield return new AirPassengers(1950.66666666667, 158);
                yield return new AirPassengers(1950.75, 133);
                yield return new AirPassengers(1950.83333333333, 114);
                yield return new AirPassengers(1950.91666666667, 140);
                yield return new AirPassengers(1951, 145);
                yield return new AirPassengers(1951.08333333333, 150);
                yield return new AirPassengers(1951.16666666667, 178);
                yield return new AirPassengers(1951.25, 163);
                yield return new AirPassengers(1951.33333333333, 172);
                yield return new AirPassengers(1951.41666666667, 178);
                yield return new AirPassengers(1951.5, 199);
                yield return new AirPassengers(1951.58333333333, 199);
                yield return new AirPassengers(1951.66666666667, 184);
                yield return new AirPassengers(1951.75, 162);
                yield return new AirPassengers(1951.83333333333, 146);
                yield return new AirPassengers(1951.91666666667, 166);
                yield return new AirPassengers(1952, 171);
                yield return new AirPassengers(1952.08333333333, 180);
                yield return new AirPassengers(1952.16666666667, 193);
                yield return new AirPassengers(1952.25, 181);
                yield return new AirPassengers(1952.33333333333, 183);
                yield return new AirPassengers(1952.41666666667, 218);
                yield return new AirPassengers(1952.5, 230);
                yield return new AirPassengers(1952.58333333333, 242);
                yield return new AirPassengers(1952.66666666667, 209);
                yield return new AirPassengers(1952.75, 191);
                yield return new AirPassengers(1952.83333333333, 172);
                yield return new AirPassengers(1952.91666666667, 194);
                yield return new AirPassengers(1953, 196);
                yield return new AirPassengers(1953.08333333333, 196);
                yield return new AirPassengers(1953.16666666667, 236);
                yield return new AirPassengers(1953.25, 235);
                yield return new AirPassengers(1953.33333333333, 229);
                yield return new AirPassengers(1953.41666666667, 243);
                yield return new AirPassengers(1953.5, 264);
                yield return new AirPassengers(1953.58333333333, 272);
                yield return new AirPassengers(1953.66666666667, 237);
                yield return new AirPassengers(1953.75, 211);
                yield return new AirPassengers(1953.83333333333, 180);
                yield return new AirPassengers(1953.91666666667, 201);
                yield return new AirPassengers(1954, 204);
                yield return new AirPassengers(1954.08333333333, 188);
                yield return new AirPassengers(1954.16666666667, 235);
                yield return new AirPassengers(1954.25, 227);
                yield return new AirPassengers(1954.33333333333, 234);
                yield return new AirPassengers(1954.41666666667, 264);
                yield return new AirPassengers(1954.5, 302);
                yield return new AirPassengers(1954.58333333333, 293);
                yield return new AirPassengers(1954.66666666667, 259);
                yield return new AirPassengers(1954.75, 229);
                yield return new AirPassengers(1954.83333333333, 203);
                yield return new AirPassengers(1954.91666666667, 229);
                yield return new AirPassengers(1955, 242);
                yield return new AirPassengers(1955.08333333334, 233);
                yield return new AirPassengers(1955.16666666667, 267);
                yield return new AirPassengers(1955.25, 269);
                yield return new AirPassengers(1955.33333333334, 270);
                yield return new AirPassengers(1955.41666666667, 315);
                yield return new AirPassengers(1955.5, 364);
                yield return new AirPassengers(1955.58333333334, 347);
                yield return new AirPassengers(1955.66666666667, 312);
                yield return new AirPassengers(1955.75, 274);
                yield return new AirPassengers(1955.83333333334, 237);
                yield return new AirPassengers(1955.91666666667, 278);
                yield return new AirPassengers(1956, 284);
                yield return new AirPassengers(1956.08333333334, 277);
                yield return new AirPassengers(1956.16666666667, 317);
                yield return new AirPassengers(1956.25, 313);
                yield return new AirPassengers(1956.33333333334, 318);
                yield return new AirPassengers(1956.41666666667, 374);
                yield return new AirPassengers(1956.5, 413);
                yield return new AirPassengers(1956.58333333334, 405);
                yield return new AirPassengers(1956.66666666667, 355);
                yield return new AirPassengers(1956.75, 306);
                yield return new AirPassengers(1956.83333333334, 271);
                yield return new AirPassengers(1956.91666666667, 306);
                yield return new AirPassengers(1957, 315);
                yield return new AirPassengers(1957.08333333334, 301);
                yield return new AirPassengers(1957.16666666667, 356);
                yield return new AirPassengers(1957.25, 348);
                yield return new AirPassengers(1957.33333333334, 355);
                yield return new AirPassengers(1957.41666666667, 422);
                yield return new AirPassengers(1957.5, 465);
                yield return new AirPassengers(1957.58333333334, 467);
                yield return new AirPassengers(1957.66666666667, 404);
                yield return new AirPassengers(1957.75, 347);
                yield return new AirPassengers(1957.83333333334, 305);
                yield return new AirPassengers(1957.91666666667, 336);
                yield return new AirPassengers(1958, 340);
                yield return new AirPassengers(1958.08333333334, 318);
                yield return new AirPassengers(1958.16666666667, 362);
                yield return new AirPassengers(1958.25, 348);
                yield return new AirPassengers(1958.33333333334, 363);
                yield return new AirPassengers(1958.41666666667, 435);
                yield return new AirPassengers(1958.5, 491);
                yield return new AirPassengers(1958.58333333334, 505);
                yield return new AirPassengers(1958.66666666667, 404);
                yield return new AirPassengers(1958.75, 359);
                yield return new AirPassengers(1958.83333333334, 310);
                yield return new AirPassengers(1958.91666666667, 337);
                yield return new AirPassengers(1959, 360);
                yield return new AirPassengers(1959.08333333334, 342);
                yield return new AirPassengers(1959.16666666667, 406);
                yield return new AirPassengers(1959.25, 396);
                yield return new AirPassengers(1959.33333333334, 420);
                yield return new AirPassengers(1959.41666666667, 472);
                yield return new AirPassengers(1959.5, 548);
                yield return new AirPassengers(1959.58333333334, 559);
                yield return new AirPassengers(1959.66666666667, 463);
                yield return new AirPassengers(1959.75, 407);
                yield return new AirPassengers(1959.83333333334, 362);
                yield return new AirPassengers(1959.91666666667, 405);
                yield return new AirPassengers(1960, 417);
                yield return new AirPassengers(1960.08333333334, 391);
                yield return new AirPassengers(1960.16666666667, 419);
                yield return new AirPassengers(1960.25, 461);
                yield return new AirPassengers(1960.33333333334, 472);
                yield return new AirPassengers(1960.41666666667, 535);
                yield return new AirPassengers(1960.5, 622);
                yield return new AirPassengers(1960.58333333334, 606);
                yield return new AirPassengers(1960.66666666667, 508);
                yield return new AirPassengers(1960.75, 461);
                yield return new AirPassengers(1960.83333333334, 390);
                yield return new AirPassengers(1960.91666666667, 432);
            }
        }
    }
}
