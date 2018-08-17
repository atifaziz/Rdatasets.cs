// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Prevention of Gastointestinal Damages
    /// </summary>

    public class Lanza
    {
        public readonly string study;
        public readonly string treatment;
        public readonly int classification;

        public Lanza(string study, string treatment, int classification)
        {
            this.study = study;
            this.treatment = treatment;
            this.classification = classification;
        }

        public static IEnumerable<Lanza> Data
        {
            get
            {
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 1);
                yield return new Lanza("I", "Misoprostol", 2);
                yield return new Lanza("I", "Misoprostol", 2);
                yield return new Lanza("I", "Misoprostol", 3);
                yield return new Lanza("I", "Misoprostol", 3);
                yield return new Lanza("I", "Misoprostol", 3);
                yield return new Lanza("I", "Misoprostol", 3);
                yield return new Lanza("I", "Misoprostol", 4);
                yield return new Lanza("I", "Misoprostol", 4);
                yield return new Lanza("I", "Placebo", 1);
                yield return new Lanza("I", "Placebo", 1);
                yield return new Lanza("I", "Placebo", 2);
                yield return new Lanza("I", "Placebo", 2);
                yield return new Lanza("I", "Placebo", 3);
                yield return new Lanza("I", "Placebo", 3);
                yield return new Lanza("I", "Placebo", 3);
                yield return new Lanza("I", "Placebo", 3);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 4);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("I", "Placebo", 5);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 1);
                yield return new Lanza("II", "Misoprostol", 2);
                yield return new Lanza("II", "Misoprostol", 2);
                yield return new Lanza("II", "Misoprostol", 2);
                yield return new Lanza("II", "Misoprostol", 2);
                yield return new Lanza("II", "Misoprostol", 3);
                yield return new Lanza("II", "Misoprostol", 3);
                yield return new Lanza("II", "Misoprostol", 3);
                yield return new Lanza("II", "Misoprostol", 3);
                yield return new Lanza("II", "Misoprostol", 3);
                yield return new Lanza("II", "Misoprostol", 3);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 1);
                yield return new Lanza("II", "Placebo", 2);
                yield return new Lanza("II", "Placebo", 2);
                yield return new Lanza("II", "Placebo", 2);
                yield return new Lanza("II", "Placebo", 2);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 3);
                yield return new Lanza("II", "Placebo", 4);
                yield return new Lanza("II", "Placebo", 4);
                yield return new Lanza("II", "Placebo", 4);
                yield return new Lanza("II", "Placebo", 4);
                yield return new Lanza("II", "Placebo", 5);
                yield return new Lanza("II", "Placebo", 5);
                yield return new Lanza("II", "Placebo", 5);
                yield return new Lanza("II", "Placebo", 5);
                yield return new Lanza("II", "Placebo", 5);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 1);
                yield return new Lanza("III", "Misoprostol", 2);
                yield return new Lanza("III", "Misoprostol", 2);
                yield return new Lanza("III", "Misoprostol", 2);
                yield return new Lanza("III", "Misoprostol", 2);
                yield return new Lanza("III", "Misoprostol", 3);
                yield return new Lanza("III", "Misoprostol", 3);
                yield return new Lanza("III", "Misoprostol", 3);
                yield return new Lanza("III", "Misoprostol", 4);
                yield return new Lanza("III", "Misoprostol", 5);
                yield return new Lanza("III", "Misoprostol", 5);
                yield return new Lanza("III", "Placebo", 2);
                yield return new Lanza("III", "Placebo", 2);
                yield return new Lanza("III", "Placebo", 3);
                yield return new Lanza("III", "Placebo", 3);
                yield return new Lanza("III", "Placebo", 3);
                yield return new Lanza("III", "Placebo", 3);
                yield return new Lanza("III", "Placebo", 3);
                yield return new Lanza("III", "Placebo", 4);
                yield return new Lanza("III", "Placebo", 4);
                yield return new Lanza("III", "Placebo", 4);
                yield return new Lanza("III", "Placebo", 4);
                yield return new Lanza("III", "Placebo", 4);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("III", "Placebo", 5);
                yield return new Lanza("IV", "Misoprostol", 1);
                yield return new Lanza("IV", "Misoprostol", 2);
                yield return new Lanza("IV", "Misoprostol", 2);
                yield return new Lanza("IV", "Misoprostol", 2);
                yield return new Lanza("IV", "Misoprostol", 2);
                yield return new Lanza("IV", "Misoprostol", 3);
                yield return new Lanza("IV", "Misoprostol", 3);
                yield return new Lanza("IV", "Misoprostol", 3);
                yield return new Lanza("IV", "Misoprostol", 3);
                yield return new Lanza("IV", "Misoprostol", 3);
                yield return new Lanza("IV", "Placebo", 4);
                yield return new Lanza("IV", "Placebo", 4);
                yield return new Lanza("IV", "Placebo", 4);
                yield return new Lanza("IV", "Placebo", 4);
                yield return new Lanza("IV", "Placebo", 5);
                yield return new Lanza("IV", "Placebo", 5);
                yield return new Lanza("IV", "Placebo", 5);
                yield return new Lanza("IV", "Placebo", 5);
                yield return new Lanza("IV", "Placebo", 5);
                yield return new Lanza("IV", "Placebo", 5);
            }
        }
    }
}
