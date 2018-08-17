// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Variation in penicillin testing
    /// </summary>

    public class Penicillin
    {
        public readonly int diameter;
        public readonly string plate;
        public readonly string sample;

        public Penicillin(int diameter, string plate, string sample)
        {
            this.diameter = diameter;
            this.plate = plate;
            this.sample = sample;
        }

        public static IEnumerable<Penicillin> Data
        {
            get
            {
                yield return new Penicillin(27, "a", "A");
                yield return new Penicillin(23, "a", "B");
                yield return new Penicillin(26, "a", "C");
                yield return new Penicillin(23, "a", "D");
                yield return new Penicillin(23, "a", "E");
                yield return new Penicillin(21, "a", "F");
                yield return new Penicillin(27, "b", "A");
                yield return new Penicillin(23, "b", "B");
                yield return new Penicillin(26, "b", "C");
                yield return new Penicillin(23, "b", "D");
                yield return new Penicillin(23, "b", "E");
                yield return new Penicillin(21, "b", "F");
                yield return new Penicillin(25, "c", "A");
                yield return new Penicillin(21, "c", "B");
                yield return new Penicillin(25, "c", "C");
                yield return new Penicillin(24, "c", "D");
                yield return new Penicillin(24, "c", "E");
                yield return new Penicillin(20, "c", "F");
                yield return new Penicillin(26, "d", "A");
                yield return new Penicillin(23, "d", "B");
                yield return new Penicillin(25, "d", "C");
                yield return new Penicillin(23, "d", "D");
                yield return new Penicillin(23, "d", "E");
                yield return new Penicillin(20, "d", "F");
                yield return new Penicillin(25, "e", "A");
                yield return new Penicillin(22, "e", "B");
                yield return new Penicillin(26, "e", "C");
                yield return new Penicillin(22, "e", "D");
                yield return new Penicillin(23, "e", "E");
                yield return new Penicillin(20, "e", "F");
                yield return new Penicillin(24, "f", "A");
                yield return new Penicillin(22, "f", "B");
                yield return new Penicillin(25, "f", "C");
                yield return new Penicillin(23, "f", "D");
                yield return new Penicillin(22, "f", "E");
                yield return new Penicillin(19, "f", "F");
                yield return new Penicillin(24, "g", "A");
                yield return new Penicillin(20, "g", "B");
                yield return new Penicillin(23, "g", "C");
                yield return new Penicillin(21, "g", "D");
                yield return new Penicillin(22, "g", "E");
                yield return new Penicillin(19, "g", "F");
                yield return new Penicillin(26, "h", "A");
                yield return new Penicillin(22, "h", "B");
                yield return new Penicillin(26, "h", "C");
                yield return new Penicillin(24, "h", "D");
                yield return new Penicillin(24, "h", "E");
                yield return new Penicillin(21, "h", "F");
                yield return new Penicillin(24, "i", "A");
                yield return new Penicillin(21, "i", "B");
                yield return new Penicillin(24, "i", "C");
                yield return new Penicillin(22, "i", "D");
                yield return new Penicillin(22, "i", "E");
                yield return new Penicillin(20, "i", "F");
                yield return new Penicillin(24, "j", "A");
                yield return new Penicillin(21, "j", "B");
                yield return new Penicillin(24, "j", "C");
                yield return new Penicillin(23, "j", "D");
                yield return new Penicillin(22, "j", "E");
                yield return new Penicillin(19, "j", "F");
                yield return new Penicillin(26, "k", "A");
                yield return new Penicillin(23, "k", "B");
                yield return new Penicillin(26, "k", "C");
                yield return new Penicillin(24, "k", "D");
                yield return new Penicillin(24, "k", "E");
                yield return new Penicillin(21, "k", "F");
                yield return new Penicillin(25, "l", "A");
                yield return new Penicillin(22, "l", "B");
                yield return new Penicillin(26, "l", "C");
                yield return new Penicillin(24, "l", "D");
                yield return new Penicillin(24, "l", "E");
                yield return new Penicillin(20, "l", "F");
                yield return new Penicillin(26, "m", "A");
                yield return new Penicillin(24, "m", "B");
                yield return new Penicillin(26, "m", "C");
                yield return new Penicillin(24, "m", "D");
                yield return new Penicillin(25, "m", "E");
                yield return new Penicillin(22, "m", "F");
                yield return new Penicillin(26, "n", "A");
                yield return new Penicillin(23, "n", "B");
                yield return new Penicillin(26, "n", "C");
                yield return new Penicillin(23, "n", "D");
                yield return new Penicillin(23, "n", "E");
                yield return new Penicillin(20, "n", "F");
                yield return new Penicillin(26, "o", "A");
                yield return new Penicillin(23, "o", "B");
                yield return new Penicillin(25, "o", "C");
                yield return new Penicillin(24, "o", "D");
                yield return new Penicillin(24, "o", "E");
                yield return new Penicillin(22, "o", "F");
                yield return new Penicillin(25, "p", "A");
                yield return new Penicillin(22, "p", "B");
                yield return new Penicillin(25, "p", "C");
                yield return new Penicillin(23, "p", "D");
                yield return new Penicillin(23, "p", "E");
                yield return new Penicillin(20, "p", "F");
                yield return new Penicillin(25, "q", "A");
                yield return new Penicillin(21, "q", "B");
                yield return new Penicillin(24, "q", "C");
                yield return new Penicillin(23, "q", "D");
                yield return new Penicillin(23, "q", "E");
                yield return new Penicillin(20, "q", "F");
                yield return new Penicillin(25, "r", "A");
                yield return new Penicillin(22, "r", "B");
                yield return new Penicillin(24, "r", "C");
                yield return new Penicillin(23, "r", "D");
                yield return new Penicillin(23, "r", "E");
                yield return new Penicillin(19, "r", "F");
                yield return new Penicillin(24, "s", "A");
                yield return new Penicillin(21, "s", "B");
                yield return new Penicillin(23, "s", "C");
                yield return new Penicillin(21, "s", "D");
                yield return new Penicillin(21, "s", "E");
                yield return new Penicillin(19, "s", "F");
                yield return new Penicillin(26, "t", "A");
                yield return new Penicillin(23, "t", "B");
                yield return new Penicillin(26, "t", "C");
                yield return new Penicillin(24, "t", "D");
                yield return new Penicillin(24, "t", "E");
                yield return new Penicillin(21, "t", "F");
                yield return new Penicillin(25, "u", "A");
                yield return new Penicillin(21, "u", "B");
                yield return new Penicillin(24, "u", "C");
                yield return new Penicillin(22, "u", "D");
                yield return new Penicillin(22, "u", "E");
                yield return new Penicillin(18, "u", "F");
                yield return new Penicillin(25, "v", "A");
                yield return new Penicillin(22, "v", "B");
                yield return new Penicillin(25, "v", "C");
                yield return new Penicillin(22, "v", "D");
                yield return new Penicillin(22, "v", "E");
                yield return new Penicillin(20, "v", "F");
                yield return new Penicillin(24, "w", "A");
                yield return new Penicillin(21, "w", "B");
                yield return new Penicillin(24, "w", "C");
                yield return new Penicillin(22, "w", "D");
                yield return new Penicillin(24, "w", "E");
                yield return new Penicillin(19, "w", "F");
                yield return new Penicillin(24, "x", "A");
                yield return new Penicillin(21, "x", "B");
                yield return new Penicillin(24, "x", "C");
                yield return new Penicillin(22, "x", "D");
                yield return new Penicillin(21, "x", "E");
                yield return new Penicillin(18, "x", "F");
            }
        }
    }
}
