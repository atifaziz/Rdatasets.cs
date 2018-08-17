// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Olives
    /// </summary>

    public class Olives
    {
        public readonly int SampleNumber;
        public readonly int Group;
        public readonly int Day;
        public readonly double Fenthion;
        public readonly double FenthionSulphoxide;
        public readonly double FenthionSulphone;
        public readonly int Time;

        public Olives(int SampleNumber, int Group, int Day, double Fenthion, double FenthionSulphoxide, double FenthionSulphone, int Time)
        {
            this.SampleNumber = SampleNumber;
            this.Group = Group;
            this.Day = Day;
            this.Fenthion = Fenthion;
            this.FenthionSulphoxide = FenthionSulphoxide;
            this.FenthionSulphone = FenthionSulphone;
            this.Time = Time;
        }

        public static IEnumerable<Olives> Data
        {
            get
            {
                yield return new Olives(1, 1, 0, 2.02, 0, 1.66, 0);
                yield return new Olives(2, 1, 0, 2.05, 0, 1.83, 0);
                yield return new Olives(3, 1, 0, 1.98, 0, 1.48, 0);
                yield return new Olives(4, 2, 0, 2.01, 0, 1.58, 0);
                yield return new Olives(5, 2, 0, 1.87, 0, 1.54, 0);
                yield return new Olives(6, 2, 0, 1.92, 0, 1.5, 0);
                yield return new Olives(1, 1, 281, 1.48, 0.61, 1.4, 3);
                yield return new Olives(2, 1, 281, 1.36, 0.7, 1.54, 3);
                yield return new Olives(3, 1, 281, 1.39, 0.78, 1.59, 3);
                yield return new Olives(4, 2, 281, 1.23, 0.94, 1.63, 3);
                yield return new Olives(5, 2, 281, 1.31, 0.8, 1.61, 3);
                yield return new Olives(6, 2, 281, 1.14, 0.99, 1.54, 3);
                yield return new Olives(1, 1, 365, 1.15, 0.8, 1.72, 4);
                yield return new Olives(2, 1, 365, 1.13, 0.78, 1.61, 4);
                yield return new Olives(3, 1, 365, 1.1, 0.88, 1.52, 4);
                yield return new Olives(4, 2, 365, 1.08, 0.92, 1.55, 4);
                yield return new Olives(5, 2, 365, 0.71, 1.27, 1.67, 4);
                yield return new Olives(6, 2, 365, 0.9, 1.05, 1.79, 4);
            }
        }
    }
}
