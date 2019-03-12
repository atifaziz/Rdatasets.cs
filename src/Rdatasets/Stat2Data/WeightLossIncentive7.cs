// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WeightLossIncentive7
    /// </summary>

    public class WeightLossIncentive7
    {
        public readonly int κ;
        public readonly string Group;
        public readonly double Month7Loss;

        public WeightLossIncentive7(int κ, string Group, double Month7Loss)
        {
            this.κ = κ;
            this.Group = Group;
            this.Month7Loss = Month7Loss;
        }

        public static IEnumerable<WeightLossIncentive7> Data
        {
            get
            {
                yield return new WeightLossIncentive7(1, "Control", -2);
                yield return new WeightLossIncentive7(2, "Control", 7);
                yield return new WeightLossIncentive7(3, "Control", 19.5);
                yield return new WeightLossIncentive7(4, "Control", -0.5);
                yield return new WeightLossIncentive7(5, "Control", -1.5);
                yield return new WeightLossIncentive7(6, "Control", -10);
                yield return new WeightLossIncentive7(7, "Control", 0.5);
                yield return new WeightLossIncentive7(8, "Control", 5);
                yield return new WeightLossIncentive7(9, "Control", 8.5);
                yield return new WeightLossIncentive7(10, "Control", 18);
                yield return new WeightLossIncentive7(11, "Control", 16);
                yield return new WeightLossIncentive7(12, "Control", -9);
                yield return new WeightLossIncentive7(13, "Control", 4.5);
                yield return new WeightLossIncentive7(14, "Control", 23.5);
                yield return new WeightLossIncentive7(15, "Control", 5.5);
                yield return new WeightLossIncentive7(16, "Control", 6.5);
                yield return new WeightLossIncentive7(17, "Control", -9.5);
                yield return new WeightLossIncentive7(18, "Control", 1.5);
                yield return new WeightLossIncentive7(19, "Incentive", 11.5);
                yield return new WeightLossIncentive7(20, "Incentive", 20);
                yield return new WeightLossIncentive7(21, "Incentive", -22);
                yield return new WeightLossIncentive7(22, "Incentive", 2);
                yield return new WeightLossIncentive7(23, "Incentive", 7.5);
                yield return new WeightLossIncentive7(24, "Incentive", 16.5);
                yield return new WeightLossIncentive7(25, "Incentive", 19);
                yield return new WeightLossIncentive7(26, "Incentive", 18);
                yield return new WeightLossIncentive7(27, "Incentive", -1);
                yield return new WeightLossIncentive7(28, "Incentive", 5.5);
                yield return new WeightLossIncentive7(29, "Incentive", 24.5);
                yield return new WeightLossIncentive7(30, "Incentive", 9.5);
                yield return new WeightLossIncentive7(31, "Incentive", 10);
                yield return new WeightLossIncentive7(32, "Incentive", -8.5);
                yield return new WeightLossIncentive7(33, "Incentive", 4.5);
            }
        }
    }
}
