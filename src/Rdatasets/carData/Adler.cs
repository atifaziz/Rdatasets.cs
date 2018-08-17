// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Experimenter Expectations
    /// </summary>

    public class Adler
    {
        public readonly string instruction;
        public readonly string expectation;
        public readonly int rating;

        public Adler(string instruction, string expectation, int rating)
        {
            this.instruction = instruction;
            this.expectation = expectation;
            this.rating = rating;
        }

        public static IEnumerable<Adler> Data
        {
            get
            {
                yield return new Adler("good", "high", 25);
                yield return new Adler("good", "high", 0);
                yield return new Adler("good", "high", -16);
                yield return new Adler("good", "high", 5);
                yield return new Adler("good", "high", 11);
                yield return new Adler("good", "high", -6);
                yield return new Adler("good", "high", 42);
                yield return new Adler("good", "high", -2);
                yield return new Adler("good", "high", -13);
                yield return new Adler("good", "high", 14);
                yield return new Adler("good", "high", 4);
                yield return new Adler("good", "high", -22);
                yield return new Adler("good", "high", 19);
                yield return new Adler("good", "high", 6);
                yield return new Adler("good", "high", -6);
                yield return new Adler("good", "high", 9);
                yield return new Adler("good", "high", 13);
                yield return new Adler("good", "high", -3);
                yield return new Adler("good", "low", -25);
                yield return new Adler("good", "low", -23);
                yield return new Adler("good", "low", -28);
                yield return new Adler("good", "low", -22);
                yield return new Adler("good", "low", -22);
                yield return new Adler("good", "low", -10);
                yield return new Adler("good", "low", -20);
                yield return new Adler("good", "low", -24);
                yield return new Adler("good", "low", -24);
                yield return new Adler("good", "low", -22);
                yield return new Adler("good", "low", -23);
                yield return new Adler("good", "low", -19);
                yield return new Adler("good", "low", -2);
                yield return new Adler("good", "low", 12);
                yield return new Adler("good", "low", -8);
                yield return new Adler("good", "low", -17);
                yield return new Adler("good", "low", -30);
                yield return new Adler("good", "low", -22);
                yield return new Adler("scientific", "high", -19);
                yield return new Adler("scientific", "high", -24);
                yield return new Adler("scientific", "high", -4);
                yield return new Adler("scientific", "high", -24);
                yield return new Adler("scientific", "high", 0);
                yield return new Adler("scientific", "high", -4);
                yield return new Adler("scientific", "high", 5);
                yield return new Adler("scientific", "high", -1);
                yield return new Adler("scientific", "high", -9);
                yield return new Adler("scientific", "high", -5);
                yield return new Adler("scientific", "high", -6);
                yield return new Adler("scientific", "high", 4);
                yield return new Adler("scientific", "high", -13);
                yield return new Adler("scientific", "high", -1);
                yield return new Adler("scientific", "high", -3);
                yield return new Adler("scientific", "high", -11);
                yield return new Adler("scientific", "high", -6);
                yield return new Adler("scientific", "high", -4);
                yield return new Adler("scientific", "low", 6);
                yield return new Adler("scientific", "low", -5);
                yield return new Adler("scientific", "low", 14);
                yield return new Adler("scientific", "low", -11);
                yield return new Adler("scientific", "low", 14);
                yield return new Adler("scientific", "low", -5);
                yield return new Adler("scientific", "low", -22);
                yield return new Adler("scientific", "low", 7);
                yield return new Adler("scientific", "low", 14);
                yield return new Adler("scientific", "low", 15);
                yield return new Adler("scientific", "low", -6);
                yield return new Adler("scientific", "low", 9);
                yield return new Adler("scientific", "low", -5);
                yield return new Adler("scientific", "low", -5);
                yield return new Adler("scientific", "low", -9);
                yield return new Adler("scientific", "low", 3);
                yield return new Adler("scientific", "low", -5);
                yield return new Adler("scientific", "low", 6);
                yield return new Adler("none", "high", -26);
                yield return new Adler("none", "high", -1);
                yield return new Adler("none", "high", 22);
                yield return new Adler("none", "high", 3);
                yield return new Adler("none", "high", -26);
                yield return new Adler("none", "high", 4);
                yield return new Adler("none", "high", -21);
                yield return new Adler("none", "high", -19);
                yield return new Adler("none", "high", -12);
                yield return new Adler("none", "high", 9);
                yield return new Adler("none", "high", -9);
                yield return new Adler("none", "high", -27);
                yield return new Adler("none", "high", -10);
                yield return new Adler("none", "high", -37);
                yield return new Adler("none", "high", 0);
                yield return new Adler("none", "high", -10);
                yield return new Adler("none", "high", -6);
                yield return new Adler("none", "high", -11);
                yield return new Adler("none", "low", -12);
                yield return new Adler("none", "low", -4);
                yield return new Adler("none", "low", 13);
                yield return new Adler("none", "low", -27);
                yield return new Adler("none", "low", -7);
                yield return new Adler("none", "low", -20);
                yield return new Adler("none", "low", -4);
                yield return new Adler("none", "low", -10);
                yield return new Adler("none", "low", -3);
                yield return new Adler("none", "low", -11);
                yield return new Adler("none", "low", 2);
                yield return new Adler("none", "low", -9);
                yield return new Adler("none", "low", 20);
                yield return new Adler("none", "low", 9);
                yield return new Adler("none", "low", -8);
                yield return new Adler("none", "low", 8);
                yield return new Adler("none", "low", -6);
                yield return new Adler("none", "low", 6);
            }
        }
    }
}
