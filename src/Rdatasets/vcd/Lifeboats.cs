// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Lifeboats on the Titanic
    /// </summary>

    public class Lifeboats
    {
        public readonly int κ;
        public readonly string launch;
        public readonly string side;
        public readonly string boat;
        public readonly int crew;
        public readonly int men;
        public readonly int women;
        public readonly int total;
        public readonly int cap;

        public Lifeboats(int κ, string launch, string side, string boat, int crew, int men, int women, int total, int cap)
        {
            this.κ = κ;
            this.launch = launch;
            this.side = side;
            this.boat = boat;
            this.crew = crew;
            this.men = men;
            this.women = women;
            this.total = total;
            this.cap = cap;
        }

        public static IEnumerable<Lifeboats> Data
        {
            get
            {
                yield return new Lifeboats(1, "1912-04-15 00:45:00", "Port", "7", 3, 4, 20, 27, 65);
                yield return new Lifeboats(2, "1912-04-15 00:55:00", "Port", "5", 5, 6, 30, 41, 65);
                yield return new Lifeboats(3, "1912-04-15 01:00:00", "Port", "3", 15, 10, 25, 50, 65);
                yield return new Lifeboats(4, "1912-04-15 01:10:00", "Port", "1", 7, 3, 2, 12, 40);
                yield return new Lifeboats(5, "1912-04-15 01:20:00", "Port", "9", 8, 6, 42, 56, 65);
                yield return new Lifeboats(6, "1912-04-15 01:25:00", "Port", "11", 9, 1, 60, 70, 65);
                yield return new Lifeboats(7, "1912-04-15 01:35:00", "Port", "13", 5, 0, 59, 64, 65);
                yield return new Lifeboats(8, "1912-04-15 01:35:00", "Port", "15", 13, 4, 53, 70, 65);
                yield return new Lifeboats(9, "1912-04-15 01:40:00", "Port", "C", 5, 2, 64, 71, 47);
                yield return new Lifeboats(10, "1912-04-15 00:55:00", "Starboard", "6", 2, 2, 24, 28, 65);
                yield return new Lifeboats(11, "1912-04-15 01:10:00", "Starboard", "8", 4, 0, 35, 39, 65);
                yield return new Lifeboats(12, "1912-04-15 01:20:00", "Starboard", "10", 5, 0, 50, 55, 65);
                yield return new Lifeboats(13, "1912-04-15 01:25:00", "Starboard", "12", 2, 0, 40, 42, 65);
                yield return new Lifeboats(14, "1912-04-15 01:30:00", "Starboard", "14", 8, 2, 53, 63, 65);
                yield return new Lifeboats(15, "1912-04-15 01:35:00", "Starboard", "16", 6, 0, 50, 56, 65);
                yield return new Lifeboats(16, "1912-04-15 01:45:00", "Starboard", "2", 4, 1, 21, 26, 40);
                yield return new Lifeboats(17, "1912-04-15 01:55:00", "Starboard", "4", 4, 0, 36, 40, 65);
                yield return new Lifeboats(18, "1912-04-15 02:05:00", "Starboard", "D", 2, 2, 40, 44, 47);
            }
        }
    }
}
