// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Polio Field Trials Data
    /// </summary>

    public class PolioTrials
    {
        public readonly string Experiment;
        public readonly string Group;
        public readonly int Population;
        public readonly int Paralytic;
        public readonly int NonParalytic;
        public readonly int FalseReports;

        public PolioTrials(string Experiment, string Group, int Population, int Paralytic, int NonParalytic, int FalseReports)
        {
            this.Experiment = Experiment;
            this.Group = Group;
            this.Population = Population;
            this.Paralytic = Paralytic;
            this.NonParalytic = NonParalytic;
            this.FalseReports = FalseReports;
        }

        public static IEnumerable<PolioTrials> Data
        {
            get
            {
                yield return new PolioTrials("RandomizedControl", "Vaccinated", 200745, 33, 24, 25);
                yield return new PolioTrials("RandomizedControl", "Placebo", 201229, 115, 27, 20);
                yield return new PolioTrials("RandomizedControl", "NotInoculated", 338778, 121, 36, 25);
                yield return new PolioTrials("RandomizedControl", "IncompleteVaccinations", 8484, 1, 1, 0);
                yield return new PolioTrials("ObservedControl", "Vaccinated", 221998, 38, 18, 20);
                yield return new PolioTrials("ObservedControl", "Controls", 725173, 330, 61, 48);
                yield return new PolioTrials("ObservedControl", "Grade2NotInoculated", 123605, 43, 11, 12);
                yield return new PolioTrials("ObservedControl", "IncompleteVaccinations", 9904, 4, 0, 0);
            }
        }
    }
}
