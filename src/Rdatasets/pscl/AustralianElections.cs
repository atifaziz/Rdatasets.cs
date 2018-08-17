// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// elections to Australian House of Representatives, 1949-2016
    /// </summary>

    public class AustralianElections
    {
        public readonly string date;
        public readonly int Seats;
        public readonly int Uncontested;
        public readonly int ALPSeats;
        public readonly int LPSeats;
        public readonly int NPSeats;
        public readonly int OtherSeats;
        public readonly double ALP;
        public readonly double ALP2PP;
        public readonly double LP;
        public readonly double NP;
        public readonly double DLP;
        public readonly double Dem;
        public readonly string Green;
        public readonly double Hanson;
        public readonly double Com;
        public readonly double AP;
        public readonly double Informal;
        public readonly double Turnout;

        public AustralianElections(string date, int Seats, int Uncontested, int ALPSeats, int LPSeats, int NPSeats, int OtherSeats, double ALP, double ALP2PP, double LP, double NP, double DLP, double Dem, string Green, double Hanson, double Com, double AP, double Informal, double Turnout)
        {
            this.date = date;
            this.Seats = Seats;
            this.Uncontested = Uncontested;
            this.ALPSeats = ALPSeats;
            this.LPSeats = LPSeats;
            this.NPSeats = NPSeats;
            this.OtherSeats = OtherSeats;
            this.ALP = ALP;
            this.ALP2PP = ALP2PP;
            this.LP = LP;
            this.NP = NP;
            this.DLP = DLP;
            this.Dem = Dem;
            this.Green = Green;
            this.Hanson = Hanson;
            this.Com = Com;
            this.AP = AP;
            this.Informal = Informal;
            this.Turnout = Turnout;
        }

        public static IEnumerable<AustralianElections> Data
        {
            get
            {
                yield return new AustralianElections("1949-12-10", 121, 0, 47, 55, 19, 0, 45.98, 49, 39.39, 10.87, 0, 0, null, 0, 0, 0, 1.99, 95.97);
                yield return new AustralianElections("1951-04-28", 121, 3, 52, 52, 17, 0, 47.63, 49.3, 40.62, 9.72, 0, 0, null, 0, 1, 0, 1.9, 96);
                yield return new AustralianElections("1954-05-29", 122, 7, 57, 47, 17, 0, 50.03, 50.7, 38.31, 8.52, 0, 0, null, 0, 1.2, 0, 1.35, 96.09);
                yield return new AustralianElections("1955-12-10", 122, 10, 47, 57, 18, 0, 44.63, 45.8, 39.73, 7.9, 5.17, 0, null, 0, 1.2, 0, 2.88, 95);
                yield return new AustralianElections("1958-11-22", 122, 0, 45, 58, 19, 0, 42.81, 45.9, 37.23, 9.32, 9.41, 0, null, 0, 0, 0, 2.87, 95.48);
                yield return new AustralianElections("1961-12-09", 122, 0, 60, 45, 17, 0, 47.9, 50.5, 33.58, 8.51, 8.71, 0, null, 0, 0, 0, 2.57, 95.27);
                yield return new AustralianElections("1963-11-30", 122, 0, 50, 52, 20, 0, 45.47, 47.4, 37.09, 8.94, 7.44, 0, null, 0, 0, 0, 1.82, 95.73);
                yield return new AustralianElections("1966-11-26", 124, 0, 41, 61, 21, 1, 39.98, 43.1, 40.14, 9.84, 7.31, 0, null, 0, 0, 0, 3.1, 95.13);
                yield return new AustralianElections("1969-10-25", 125, 0, 59, 46, 20, 0, 46.95, 50.2, 34.77, 8.56, 6.02, 0, null, 0, 0, 0.88, 2.54, 94.97);
                yield return new AustralianElections("1972-12-02", 125, 0, 67, 38, 20, 0, 49.59, 52.7, 32.04, 9.44, 5.25, 0, null, 0, 0, 2.42, 2.17, 95.38);
                yield return new AustralianElections("1974-05-18", 127, 0, 66, 40, 21, 0, 49.3, 51.7, 34.95, 9.96, 1.42, 0, null, 0, 0, 2.33, 1.92, 95.42);
                yield return new AustralianElections("1975-12-13", 127, 0, 36, 68, 23, 0, 42.84, 44.3, 41.8, 11.25, 1.32, 0, null, 0, 0, 0.43, 1.89, 95.39);
                yield return new AustralianElections("1977-12-10", 124, 0, 38, 67, 19, 0, 39.65, 45.4, 38.09, 10.01, 1.4, 9.38, null, 0, 0, 0, 2.52, 95.08);
                yield return new AustralianElections("1980-10-18", 125, 0, 51, 54, 20, 0, 45.15, 49.6, 37.43, 8.97, 0.3, 6.57, null, 0, 0, 0, 2.45, 94.35);
                yield return new AustralianElections("1983-03-05", 125, 0, 75, 33, 17, 0, 49.48, 53.2, 34.36, 9.21, 0.2, 5.03, null, 0, 0, 0, 2.09, 94.64);
                yield return new AustralianElections("1984-12-01", 148, 0, 82, 45, 21, 0, 47.55, 51.8, 34.38, 10.63, 0.6, 5.45, null, 0, 0, 0, 6.78, 94.19);
                yield return new AustralianElections("1987-07-11", 148, 0, 86, 43, 19, 0, 45.83, 50.8, 34.55, 11.52, 0, 6.03, null, 0, 0, 0, 4.94, 93.84);
                yield return new AustralianElections("1990-03-24", 148, 0, 78, 55, 14, 1, 39.44, 49.9, 35.04, 8.42, 0, 11.26, null, 0, 0, 0, 3.19, 95.31);
                yield return new AustralianElections("1993-03-13", 147, 0, 80, 49, 16, 2, 44.92, 51.4, 37.1, 7.17, 0, 3.75, null, 0, 0, 0, 2.97, 95.75);
                yield return new AustralianElections("1996-03-02", 148, 0, 49, 76, 18, 5, 38.75, 46.4, 39.04, 8.21, 0, 6.76, "1.74", 0, 0, 0, 3.2, 95.77);
                yield return new AustralianElections("1998-10-03", 148, 0, 67, 64, 16, 1, 40.1, 51, 33.89, 5.6, 0, 5.13, "2.14", 8.43, 0, 0, 3.78, 94.99);
                yield return new AustralianElections("2001-11-10", 150, 0, 65, 69, 14, 3, 37.84, 49, 37.08, 5.93, 0, 5.41, "4.96", 4.34, 0, 0, 4.81, 95.39);
                yield return new AustralianElections("2004-10-09", 150, 0, 60, 75, 12, 3, 37.64, 47.26, 40.47, 5.89, 0, 1.24, "7.19", 0, 0, 0, 5.18, 94.32);
                yield return new AustralianElections("2007-11-24", 150, 0, 83, 55, 10, 2, 43.38, 52.7, 36.6, 5.49, 0.05, 0.72, "7.79", 0.26, 0, 0, 3.95, 94.76);
                yield return new AustralianElections("2010-08-21", 150, 0, 72, 66, 7, 5, 37.99, 50.12, 39.89, 3.73, 0.04, 0.18, "11.76", 0, 0, 0, 5.55, 93.22);
                yield return new AustralianElections("2013-09-07", 150, 0, 55, 81, 9, 5, 33.38, 46.51, 41.26, 4.29, 0.28, 0.03, "8.65", 0, 0, 0, 5.91, 93.23);
                yield return new AustralianElections("2016-07-02", 150, 0, 69, 66, 10, 5, 34.73, 49.64, 37.43, 4.61, 0.02, 0, "10.23", 1.29, 0, 0, 5.05, 91.01);
            }
        }
    }
}
