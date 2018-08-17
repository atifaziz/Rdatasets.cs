// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WeightLossIncentive7
    /// </summary>

    public class WeightLossIncentive7
    {
        public readonly string Group;
        public readonly double Month7Loss;

        public WeightLossIncentive7(string Group, double Month7Loss)
        {
            this.Group = Group;
            this.Month7Loss = Month7Loss;
        }

        public static IEnumerable<WeightLossIncentive7> Data
        {
            get
            {
                yield return new WeightLossIncentive7("Control", -2);
                yield return new WeightLossIncentive7("Control", 7);
                yield return new WeightLossIncentive7("Control", 19.5);
                yield return new WeightLossIncentive7("Control", -0.5);
                yield return new WeightLossIncentive7("Control", -1.5);
                yield return new WeightLossIncentive7("Control", -10);
                yield return new WeightLossIncentive7("Control", 0.5);
                yield return new WeightLossIncentive7("Control", 5);
                yield return new WeightLossIncentive7("Control", 8.5);
                yield return new WeightLossIncentive7("Control", 18);
                yield return new WeightLossIncentive7("Control", 16);
                yield return new WeightLossIncentive7("Control", -9);
                yield return new WeightLossIncentive7("Control", 4.5);
                yield return new WeightLossIncentive7("Control", 23.5);
                yield return new WeightLossIncentive7("Control", 5.5);
                yield return new WeightLossIncentive7("Control", 6.5);
                yield return new WeightLossIncentive7("Control", -9.5);
                yield return new WeightLossIncentive7("Control", 1.5);
                yield return new WeightLossIncentive7("Incentive", 11.5);
                yield return new WeightLossIncentive7("Incentive", 20);
                yield return new WeightLossIncentive7("Incentive", -22);
                yield return new WeightLossIncentive7("Incentive", 2);
                yield return new WeightLossIncentive7("Incentive", 7.5);
                yield return new WeightLossIncentive7("Incentive", 16.5);
                yield return new WeightLossIncentive7("Incentive", 19);
                yield return new WeightLossIncentive7("Incentive", 18);
                yield return new WeightLossIncentive7("Incentive", -1);
                yield return new WeightLossIncentive7("Incentive", 5.5);
                yield return new WeightLossIncentive7("Incentive", 24.5);
                yield return new WeightLossIncentive7("Incentive", 9.5);
                yield return new WeightLossIncentive7("Incentive", 10);
                yield return new WeightLossIncentive7("Incentive", -8.5);
                yield return new WeightLossIncentive7("Incentive", 4.5);
            }
        }
    }
}
