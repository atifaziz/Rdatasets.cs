// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WeightLossIncentive
    /// </summary>

    public class WeightLossIncentive
    {
        public readonly int κ;
        public readonly double? WeightLoss;
        public readonly string Group;
        public readonly double? Month7Loss;

        public WeightLossIncentive(int κ, double? WeightLoss, string Group, double? Month7Loss)
        {
            this.κ = κ;
            this.WeightLoss = WeightLoss;
            this.Group = Group;
            this.Month7Loss = Month7Loss;
        }

        public static IEnumerable<WeightLossIncentive> Data
        {
            get
            {
                yield return new WeightLossIncentive(1, 12.5, "Control", -2);
                yield return new WeightLossIncentive(2, 12, "Control", 7);
                yield return new WeightLossIncentive(3, 1, "Control", 19.5);
                yield return new WeightLossIncentive(4, -5, "Control", -0.5);
                yield return new WeightLossIncentive(5, 3, "Control", -1.5);
                yield return new WeightLossIncentive(6, -5, "Control", -10);
                yield return new WeightLossIncentive(7, 7.5, "Control", 0.5);
                yield return new WeightLossIncentive(8, -2.5, "Control", 5);
                yield return new WeightLossIncentive(9, 20, "Control", 8.5);
                yield return new WeightLossIncentive(10, -1, "Control", 18);
                yield return new WeightLossIncentive(11, 2, "Control", 16);
                yield return new WeightLossIncentive(12, 4.5, "Control", -9);
                yield return new WeightLossIncentive(13, -2, "Control", 4.5);
                yield return new WeightLossIncentive(14, -17, "Control", 23.5);
                yield return new WeightLossIncentive(15, 19, "Control", 5.5);
                yield return new WeightLossIncentive(16, -2, "Control", 6.5);
                yield return new WeightLossIncentive(17, 12, "Control", -9.5);
                yield return new WeightLossIncentive(18, 10.5, "Control", 1.5);
                yield return new WeightLossIncentive(19, 5, "Control", null);
                yield return new WeightLossIncentive(20, 25.5, "Incentive", null);
                yield return new WeightLossIncentive(21, 24, "Incentive", 11.5);
                yield return new WeightLossIncentive(22, 8, "Incentive", 20);
                yield return new WeightLossIncentive(23, null, "Incentive", null);
                yield return new WeightLossIncentive(24, 15.5, "Incentive", null);
                yield return new WeightLossIncentive(25, null, "Incentive", -22);
                yield return new WeightLossIncentive(26, 21, "Incentive", 2);
                yield return new WeightLossIncentive(27, 4.5, "Incentive", 7.5);
                yield return new WeightLossIncentive(28, 30, "Incentive", 16.5);
                yield return new WeightLossIncentive(29, 7.5, "Incentive", 19);
                yield return new WeightLossIncentive(30, 10, "Incentive", 18);
                yield return new WeightLossIncentive(31, 18, "Incentive", -1);
                yield return new WeightLossIncentive(32, 5, "Incentive", 5.5);
                yield return new WeightLossIncentive(33, -0.5, "Incentive", 24.5);
                yield return new WeightLossIncentive(34, 27, "Incentive", 9.5);
                yield return new WeightLossIncentive(35, 6, "Incentive", 10);
                yield return new WeightLossIncentive(36, 25.5, "Incentive", -8.5);
                yield return new WeightLossIncentive(37, 21, "Incentive", 4.5);
                yield return new WeightLossIncentive(38, 18.5, "Incentive", null);
            }
        }
    }
}
