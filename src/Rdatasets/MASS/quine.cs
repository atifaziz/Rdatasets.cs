// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Absenteeism from School in Rural New South Wales
    /// </summary>

    public class quine
    {
        public readonly string Eth;
        public readonly string Sex;
        public readonly string Age;
        public readonly string Lrn;
        public readonly int Days;

        public quine(string Eth, string Sex, string Age, string Lrn, int Days)
        {
            this.Eth = Eth;
            this.Sex = Sex;
            this.Age = Age;
            this.Lrn = Lrn;
            this.Days = Days;
        }

        public static IEnumerable<quine> Data
        {
            get
            {
                yield return new quine("A", "M", "F0", "SL", 2);
                yield return new quine("A", "M", "F0", "SL", 11);
                yield return new quine("A", "M", "F0", "SL", 14);
                yield return new quine("A", "M", "F0", "AL", 5);
                yield return new quine("A", "M", "F0", "AL", 5);
                yield return new quine("A", "M", "F0", "AL", 13);
                yield return new quine("A", "M", "F0", "AL", 20);
                yield return new quine("A", "M", "F0", "AL", 22);
                yield return new quine("A", "M", "F1", "SL", 6);
                yield return new quine("A", "M", "F1", "SL", 6);
                yield return new quine("A", "M", "F1", "SL", 15);
                yield return new quine("A", "M", "F1", "AL", 7);
                yield return new quine("A", "M", "F1", "AL", 14);
                yield return new quine("A", "M", "F2", "SL", 6);
                yield return new quine("A", "M", "F2", "SL", 32);
                yield return new quine("A", "M", "F2", "SL", 53);
                yield return new quine("A", "M", "F2", "SL", 57);
                yield return new quine("A", "M", "F2", "AL", 14);
                yield return new quine("A", "M", "F2", "AL", 16);
                yield return new quine("A", "M", "F2", "AL", 16);
                yield return new quine("A", "M", "F2", "AL", 17);
                yield return new quine("A", "M", "F2", "AL", 40);
                yield return new quine("A", "M", "F2", "AL", 43);
                yield return new quine("A", "M", "F2", "AL", 46);
                yield return new quine("A", "M", "F3", "AL", 8);
                yield return new quine("A", "M", "F3", "AL", 23);
                yield return new quine("A", "M", "F3", "AL", 23);
                yield return new quine("A", "M", "F3", "AL", 28);
                yield return new quine("A", "M", "F3", "AL", 34);
                yield return new quine("A", "M", "F3", "AL", 36);
                yield return new quine("A", "M", "F3", "AL", 38);
                yield return new quine("A", "F", "F0", "SL", 3);
                yield return new quine("A", "F", "F0", "AL", 5);
                yield return new quine("A", "F", "F0", "AL", 11);
                yield return new quine("A", "F", "F0", "AL", 24);
                yield return new quine("A", "F", "F0", "AL", 45);
                yield return new quine("A", "F", "F1", "SL", 5);
                yield return new quine("A", "F", "F1", "SL", 6);
                yield return new quine("A", "F", "F1", "SL", 6);
                yield return new quine("A", "F", "F1", "SL", 9);
                yield return new quine("A", "F", "F1", "SL", 13);
                yield return new quine("A", "F", "F1", "SL", 23);
                yield return new quine("A", "F", "F1", "SL", 25);
                yield return new quine("A", "F", "F1", "SL", 32);
                yield return new quine("A", "F", "F1", "SL", 53);
                yield return new quine("A", "F", "F1", "SL", 54);
                yield return new quine("A", "F", "F1", "AL", 5);
                yield return new quine("A", "F", "F1", "AL", 5);
                yield return new quine("A", "F", "F1", "AL", 11);
                yield return new quine("A", "F", "F1", "AL", 17);
                yield return new quine("A", "F", "F1", "AL", 19);
                yield return new quine("A", "F", "F2", "SL", 8);
                yield return new quine("A", "F", "F2", "SL", 13);
                yield return new quine("A", "F", "F2", "SL", 14);
                yield return new quine("A", "F", "F2", "SL", 20);
                yield return new quine("A", "F", "F2", "SL", 47);
                yield return new quine("A", "F", "F2", "SL", 48);
                yield return new quine("A", "F", "F2", "SL", 60);
                yield return new quine("A", "F", "F2", "SL", 81);
                yield return new quine("A", "F", "F2", "AL", 2);
                yield return new quine("A", "F", "F3", "AL", 0);
                yield return new quine("A", "F", "F3", "AL", 2);
                yield return new quine("A", "F", "F3", "AL", 3);
                yield return new quine("A", "F", "F3", "AL", 5);
                yield return new quine("A", "F", "F3", "AL", 10);
                yield return new quine("A", "F", "F3", "AL", 14);
                yield return new quine("A", "F", "F3", "AL", 21);
                yield return new quine("A", "F", "F3", "AL", 36);
                yield return new quine("A", "F", "F3", "AL", 40);
                yield return new quine("N", "M", "F0", "SL", 6);
                yield return new quine("N", "M", "F0", "SL", 17);
                yield return new quine("N", "M", "F0", "SL", 67);
                yield return new quine("N", "M", "F0", "AL", 0);
                yield return new quine("N", "M", "F0", "AL", 0);
                yield return new quine("N", "M", "F0", "AL", 2);
                yield return new quine("N", "M", "F0", "AL", 7);
                yield return new quine("N", "M", "F0", "AL", 11);
                yield return new quine("N", "M", "F0", "AL", 12);
                yield return new quine("N", "M", "F1", "SL", 0);
                yield return new quine("N", "M", "F1", "SL", 0);
                yield return new quine("N", "M", "F1", "SL", 5);
                yield return new quine("N", "M", "F1", "SL", 5);
                yield return new quine("N", "M", "F1", "SL", 5);
                yield return new quine("N", "M", "F1", "SL", 11);
                yield return new quine("N", "M", "F1", "SL", 17);
                yield return new quine("N", "M", "F1", "AL", 3);
                yield return new quine("N", "M", "F1", "AL", 4);
                yield return new quine("N", "M", "F2", "SL", 22);
                yield return new quine("N", "M", "F2", "SL", 30);
                yield return new quine("N", "M", "F2", "SL", 36);
                yield return new quine("N", "M", "F2", "AL", 8);
                yield return new quine("N", "M", "F2", "AL", 0);
                yield return new quine("N", "M", "F2", "AL", 1);
                yield return new quine("N", "M", "F2", "AL", 5);
                yield return new quine("N", "M", "F2", "AL", 7);
                yield return new quine("N", "M", "F2", "AL", 16);
                yield return new quine("N", "M", "F2", "AL", 27);
                yield return new quine("N", "M", "F3", "AL", 0);
                yield return new quine("N", "M", "F3", "AL", 30);
                yield return new quine("N", "M", "F3", "AL", 10);
                yield return new quine("N", "M", "F3", "AL", 14);
                yield return new quine("N", "M", "F3", "AL", 27);
                yield return new quine("N", "M", "F3", "AL", 41);
                yield return new quine("N", "M", "F3", "AL", 69);
                yield return new quine("N", "F", "F0", "SL", 25);
                yield return new quine("N", "F", "F0", "AL", 10);
                yield return new quine("N", "F", "F0", "AL", 11);
                yield return new quine("N", "F", "F0", "AL", 20);
                yield return new quine("N", "F", "F0", "AL", 33);
                yield return new quine("N", "F", "F1", "SL", 5);
                yield return new quine("N", "F", "F1", "SL", 7);
                yield return new quine("N", "F", "F1", "SL", 0);
                yield return new quine("N", "F", "F1", "SL", 1);
                yield return new quine("N", "F", "F1", "SL", 5);
                yield return new quine("N", "F", "F1", "SL", 5);
                yield return new quine("N", "F", "F1", "SL", 5);
                yield return new quine("N", "F", "F1", "SL", 5);
                yield return new quine("N", "F", "F1", "SL", 7);
                yield return new quine("N", "F", "F1", "SL", 11);
                yield return new quine("N", "F", "F1", "SL", 15);
                yield return new quine("N", "F", "F1", "AL", 5);
                yield return new quine("N", "F", "F1", "AL", 14);
                yield return new quine("N", "F", "F1", "AL", 6);
                yield return new quine("N", "F", "F1", "AL", 6);
                yield return new quine("N", "F", "F1", "AL", 7);
                yield return new quine("N", "F", "F1", "AL", 28);
                yield return new quine("N", "F", "F2", "SL", 0);
                yield return new quine("N", "F", "F2", "SL", 5);
                yield return new quine("N", "F", "F2", "SL", 14);
                yield return new quine("N", "F", "F2", "SL", 2);
                yield return new quine("N", "F", "F2", "SL", 2);
                yield return new quine("N", "F", "F2", "SL", 3);
                yield return new quine("N", "F", "F2", "SL", 8);
                yield return new quine("N", "F", "F2", "SL", 10);
                yield return new quine("N", "F", "F2", "SL", 12);
                yield return new quine("N", "F", "F2", "AL", 1);
                yield return new quine("N", "F", "F3", "AL", 1);
                yield return new quine("N", "F", "F3", "AL", 9);
                yield return new quine("N", "F", "F3", "AL", 22);
                yield return new quine("N", "F", "F3", "AL", 3);
                yield return new quine("N", "F", "F3", "AL", 3);
                yield return new quine("N", "F", "F3", "AL", 5);
                yield return new quine("N", "F", "F3", "AL", 15);
                yield return new quine("N", "F", "F3", "AL", 18);
                yield return new quine("N", "F", "F3", "AL", 22);
                yield return new quine("N", "F", "F3", "AL", 37);
            }
        }
    }
}
