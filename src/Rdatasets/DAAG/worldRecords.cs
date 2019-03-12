// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Record times for track and road races, at August 9th 2006
    /// </summary>

    public class worldRecords
    {
        public readonly int κ;
        public readonly double Distance;
        public readonly string roadORtrack;
        public readonly string Place;
        public readonly double Time;
        public readonly string Date;

        public worldRecords(int κ, double Distance, string roadORtrack, string Place, double Time, string Date)
        {
            this.κ = κ;
            this.Distance = Distance;
            this.roadORtrack = roadORtrack;
            this.Place = Place;
            this.Time = Time;
            this.Date = Date;
        }

        public static IEnumerable<worldRecords> Data
        {
            get
            {
                yield return new worldRecords(1, 0.1, "track", "Athens", 0.162833333333333, "2005-06-14");
                yield return new worldRecords(2, 0.15, "track", "Cassino", 0.246666666666667, "1983-05-22");
                yield return new worldRecords(3, 0.2, "track", "Atlanta", 0.322, "1996-08-01");
                yield return new worldRecords(4, 0.3, "track", "Pretoria", 0.514166666666667, "2000-03-24");
                yield return new worldRecords(5, 0.4, "track", "Seville", 0.719666666666667, "1999-08-26");
                yield return new worldRecords(6, 0.5, "track", "Busto Arsizio", 1.00133333333333, "1984-05-26");
                yield return new worldRecords(7, 0.6, "track", "Santa Monica", 1.2135, "1986-05-24");
                yield return new worldRecords(8, 0.8, "track", "Cologne", 1.68516666666667, "1997-08-24");
                yield return new worldRecords(9, 1, "track", "Rieti", 2.19933333333333, "1999-09-05");
                yield return new worldRecords(10, 1.5, "track", "Rome", 3.43333333333333, "1998-07-14");
                yield return new worldRecords(11, 1.609, "track", "Rome", 3.71883333333333, "1999-07-07");
                yield return new worldRecords(12, 2, "track", "Berlin", 4.7465, "1999-09-07");
                yield return new worldRecords(13, 3, "track", "Rieti", 7.3445, "1996-09-01");
                yield return new worldRecords(14, 3.218, "track", "Hechtel", 7.97683333333333, "1997-07-19");
                yield return new worldRecords(15, 5, "track", "Hengelo", 12.6225, "2004-05-31");
                yield return new worldRecords(16, 10, "track", "Brussels", 26.2921666666667, "2005-08-26");
                yield return new worldRecords(17, 15, "track", "La Fleche", 42.5666666666667, "1991-03-30");
                yield return new worldRecords(18, 20, "track", "La Fleche", 56.9266666666667, "1991-03-30");
                yield return new worldRecords(19, 25, "track", "Christchurch", 73.93, "1981-03-22");
                yield return new worldRecords(20, 30, "track", "Christchurch", 89.3133333333333, "1981-03-22");
                yield return new worldRecords(21, 50, "track", "Timperley", 168.1, "1980-06-07");
                yield return new worldRecords(22, 64.36, "track", "London", 228.583333333333, "1982-10-16");
                yield return new worldRecords(23, 100, "track", "London", 370.333333333333, "1978-10-28");
                yield return new worldRecords(24, 160.9, "track", "London", 688.05, "2002-10-20");
                yield return new worldRecords(25, 5, "road", "Carlsbad", 13, "2000-03-26");
                yield return new worldRecords(26, 6.436, "road", "Groningen", 17.1666666666667, "2005-10-09");
                yield return new worldRecords(27, 8, "road", "Dublin", 22.0333333333333, "1993-05-02");
                yield return new worldRecords(28, 8.045, "road", "New Orleans", 22.0833333333333, "1993-03-20");
                yield return new worldRecords(29, 10, "road", "Doha", 27.0333333333333, "2002-12-11");
                yield return new worldRecords(30, 12, "road", "Evansville", 33.5166666666667, "1997-05-10");
                yield return new worldRecords(31, 15, "road", "Tilburg", 41.3666666666667, "2005-09-04");
                yield return new worldRecords(32, 16.09, "road", "Tilburg", 44.4, "2005-09-04");
                yield return new worldRecords(33, 20, "road", "Phoenix-Tempe", 55.8, "2006-01-15");
                yield return new worldRecords(34, 25, "road", "Alphen aan den Rijn", 71.6166666666667, "2006-03-12");
                yield return new worldRecords(35, 30, "road", "Kumamoto", 88, "2005-02-27");
                yield return new worldRecords(36, 32.18, "road", "Chicago", 95.3666666666667, "1985-10-20");
                yield return new worldRecords(37, 50, "road", "Claremont-Kirstenbosch", 163.633333333333, "1988-04-12");
                yield return new worldRecords(38, 100, "road", "Lake Saroma", 373.55, "1998-06-21");
                yield return new worldRecords(39, 160.9, "road", "New York", 706.616666666667, "1984-05-08");
                yield return new worldRecords(40, 290.221, "road", "Basle", 1440, "1998-05-03");
            }
        }
    }
}
