// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Data set testing causal direction in presumed media influence
    /// </summary>

    public class Tal_Or
    {
        public readonly int cond;
        public readonly double pmi;
        public readonly int import;
        public readonly double reaction;
        public readonly int gender;
        public readonly double age;

        public Tal_Or(int cond, double pmi, int import, double reaction, int gender, double age)
        {
            this.cond = cond;
            this.pmi = pmi;
            this.import = import;
            this.reaction = reaction;
            this.gender = gender;
            this.age = age;
        }

        public static IEnumerable<Tal_Or> Data
        {
            get
            {
                yield return new Tal_Or(1, 7, 6, 5.25, 1, 51);
                yield return new Tal_Or(0, 6, 1, 1.25, 1, 40);
                yield return new Tal_Or(1, 5.5, 6, 5, 1, 26);
                yield return new Tal_Or(0, 6.5, 6, 2.75, 2, 21);
                yield return new Tal_Or(0, 6, 5, 2.5, 1, 27);
                yield return new Tal_Or(0, 5.5, 1, 1.25, 1, 25);
                yield return new Tal_Or(0, 3.5, 1, 1.5, 2, 23);
                yield return new Tal_Or(1, 6, 6, 4.75, 1, 25);
                yield return new Tal_Or(0, 4.5, 6, 4.25, 1, 22);
                yield return new Tal_Or(0, 7, 6, 6.25, 1, 24);
                yield return new Tal_Or(1, 1, 3, 1.25, 2, 22);
                yield return new Tal_Or(0, 6, 3, 2.75, 2, 21);
                yield return new Tal_Or(1, 5, 4, 3.75, 2, 23);
                yield return new Tal_Or(0, 7, 7, 5, 2, 21);
                yield return new Tal_Or(1, 7, 1, 4, 2, 22);
                yield return new Tal_Or(1, 7, 6, 5, 2, 23);
                yield return new Tal_Or(0, 4.5, 3, 3.5, 2, 23);
                yield return new Tal_Or(0, 3.5, 3, 2.25, 2, 23);
                yield return new Tal_Or(1, 7, 2, 4.5, 2, 22);
                yield return new Tal_Or(0, 7, 4, 5.75, 1, 23);
                yield return new Tal_Or(1, 4.5, 4, 2.75, 2, 22);
                yield return new Tal_Or(1, 6, 6, 3.75, 2, 19.5);
                yield return new Tal_Or(1, 6, 7, 2.75, 1, 61);
                yield return new Tal_Or(1, 4, 4, 4, 1, 25);
                yield return new Tal_Or(1, 7, 5, 5, 2, 23);
                yield return new Tal_Or(0, 4, 4, 2, 1, 60);
                yield return new Tal_Or(1, 6.5, 6, 4, 2, 22);
                yield return new Tal_Or(0, 6, 5, 1.75, 2, 23);
                yield return new Tal_Or(1, 6.5, 5, 3.5, 2, 22);
                yield return new Tal_Or(0, 6, 7, 4.75, 1, 23);
                yield return new Tal_Or(0, 4, 4, 4, 2, 25);
                yield return new Tal_Or(1, 7, 1, 3, 2, 22);
                yield return new Tal_Or(0, 6, 4, 5.75, 2, 23);
                yield return new Tal_Or(0, 7, 5, 2.75, 2, 22);
                yield return new Tal_Or(1, 6.5, 5, 3.25, 1, 25);
                yield return new Tal_Or(0, 5.5, 4, 5.5, 2, 24);
                yield return new Tal_Or(1, 6, 4, 3.25, 1, 24);
                yield return new Tal_Or(0, 2, 2, 1.25, 1, 29);
                yield return new Tal_Or(1, 4.5, 2, 2, 1, 24);
                yield return new Tal_Or(0, 4, 3, 2.5, 1, 18);
                yield return new Tal_Or(0, 7, 3, 3, 1, 23);
                yield return new Tal_Or(0, 6, 4, 5.75, 2, 21);
                yield return new Tal_Or(1, 7, 2, 1.5, 1, 24);
                yield return new Tal_Or(0, 5, 5, 4, 2, 26);
                yield return new Tal_Or(1, 7, 3, 1.25, 1, 24);
                yield return new Tal_Or(1, 7, 7, 3.25, 1, 22);
                yield return new Tal_Or(0, 5, 4, 3.75, 2, 21);
                yield return new Tal_Or(0, 6, 4, 2.75, 1, 26);
                yield return new Tal_Or(0, 5.5, 4, 3, 1, 24);
                yield return new Tal_Or(1, 7, 4, 6, 1, 27);
                yield return new Tal_Or(0, 3.5, 6, 3.25, 1, 26);
                yield return new Tal_Or(1, 7, 2, 2.75, 1, 24);
                yield return new Tal_Or(0, 6, 5, 5, 1, 24);
                yield return new Tal_Or(0, 3.5, 4, 1.5, 2, 26);
                yield return new Tal_Or(1, 7, 7, 7, 1, 24);
                yield return new Tal_Or(1, 5, 1, 5, 1, 22);
                yield return new Tal_Or(1, 1.5, 2, 1.75, 1, 23);
                yield return new Tal_Or(0, 6.5, 2, 2.25, 2, 24);
                yield return new Tal_Or(1, 6, 5, 3.5, 2, 24);
                yield return new Tal_Or(0, 7, 1, 3.5, 1, 25);
                yield return new Tal_Or(0, 7, 5, 6.75, 2, 23);
                yield return new Tal_Or(1, 6, 5, 4.25, 2, 23);
                yield return new Tal_Or(1, 6, 5, 4, 2, 23);
                yield return new Tal_Or(0, 4, 3, 2.25, 2, 24);
                yield return new Tal_Or(0, 3.5, 2, 3, 2, 18);
                yield return new Tal_Or(0, 6, 4, 5.5, 2, 23);
                yield return new Tal_Or(1, 6, 5, 1.75, 1, 25);
                yield return new Tal_Or(1, 6, 3, 4.5, 2, 24);
                yield return new Tal_Or(0, 5, 6, 4.25, 2, 23);
                yield return new Tal_Or(0, 3, 4, 1.5, 2, 23);
                yield return new Tal_Or(1, 7, 4, 2, 2, 24);
                yield return new Tal_Or(0, 6, 2, 1.5, 2, 22);
                yield return new Tal_Or(1, 5, 4, 3.25, 1, 24);
                yield return new Tal_Or(0, 5, 5, 1, 2, 25);
                yield return new Tal_Or(1, 5.5, 2, 1.5, 2, 22);
                yield return new Tal_Or(0, 5.5, 5, 1, 2, 22);
                yield return new Tal_Or(0, 6, 6, 2.5, 2, 23);
                yield return new Tal_Or(0, 2.5, 2, 1, 1, 25);
                yield return new Tal_Or(1, 4.5, 4, 3, 2, 23);
                yield return new Tal_Or(0, 5, 4, 2.5, 2, 23);
                yield return new Tal_Or(0, 6, 2, 1, 1, 24);
                yield return new Tal_Or(1, 5, 5, 3.75, 1, 21);
                yield return new Tal_Or(1, 7, 7, 1.75, 2, 23);
                yield return new Tal_Or(1, 5, 3, 2.75, 2, 21);
                yield return new Tal_Or(1, 4.5, 5, 5.25, 1, 23);
                yield return new Tal_Or(1, 6.5, 6, 5.25, 2, 19);
                yield return new Tal_Or(1, 7, 6, 5, 1, 25);
                yield return new Tal_Or(0, 6, 5, 5, 2, 23);
                yield return new Tal_Or(1, 5, 7, 5, 2, 22);
                yield return new Tal_Or(1, 7, 6, 6.5, 2, 19);
                yield return new Tal_Or(0, 5.5, 5, 3, 2, 23);
                yield return new Tal_Or(1, 6, 4, 2.75, 2, 24);
                yield return new Tal_Or(1, 6, 5, 4.25, 1, 32);
                yield return new Tal_Or(1, 7, 6, 7, 2, 27);
                yield return new Tal_Or(1, 4, 7, 5.75, 2, 25);
                yield return new Tal_Or(1, 6.5, 5, 3, 2, 24);
                yield return new Tal_Or(1, 5, 4, 4.5, 2, 23);
                yield return new Tal_Or(0, 7, 3, 4.25, 2, 28);
                yield return new Tal_Or(0, 7, 4, 4.5, 2, 24);
                yield return new Tal_Or(0, 5, 3, 3.75, 2, 24);
                yield return new Tal_Or(0, 7, 1, 4.75, 2, 24);
                yield return new Tal_Or(0, 7, 4, 2.5, 2, 25);
                yield return new Tal_Or(0, 5, 3, 1, 2, 24);
                yield return new Tal_Or(0, 6, 5, 6, 2, 25);
                yield return new Tal_Or(0, 5, 6, 2, 2, 24);
                yield return new Tal_Or(0, 6.5, 6, 5, 2, 24);
                yield return new Tal_Or(1, 7, 7, 5, 2, 24);
                yield return new Tal_Or(1, 6.5, 7, 4.25, 2, 25);
                yield return new Tal_Or(1, 6, 3, 2, 1, 28);
                yield return new Tal_Or(1, 5, 6, 3.5, 2, 24);
                yield return new Tal_Or(1, 5.5, 1, 1.75, 2, 26);
                yield return new Tal_Or(1, 5.5, 6, 3.5, 2, 27);
                yield return new Tal_Or(1, 5, 4, 2.25, 2, 25);
                yield return new Tal_Or(1, 7, 5, 5.5, 1, 25);
                yield return new Tal_Or(0, 1.5, 1, 1, 2, 26);
                yield return new Tal_Or(0, 6, 3, 3, 2, 25);
                yield return new Tal_Or(0, 5.5, 5, 2.25, 2, 25);
                yield return new Tal_Or(0, 6.5, 6, 4.75, 1, 25);
                yield return new Tal_Or(0, 4.5, 3, 2.25, 2, 26);
                yield return new Tal_Or(0, 3.5, 1, 1.5, 2, 22);
                yield return new Tal_Or(0, 6, 6, 5.75, 2, 24);
                yield return new Tal_Or(0, 6.5, 2, 5.25, 2, 23);
                yield return new Tal_Or(0, 5.5, 6, 3, 2, 24);
            }
        }
    }
}
