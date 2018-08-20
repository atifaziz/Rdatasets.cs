// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WeightLossIncentive
    /// </summary>

    public class WeightLossIncentive
    {
        public readonly double? WeightLoss;
        public readonly string Group;
        public readonly double? Month7Loss;

        public WeightLossIncentive(double? WeightLoss, string Group, double? Month7Loss)
        {
            this.WeightLoss = WeightLoss;
            this.Group = Group;
            this.Month7Loss = Month7Loss;
        }

        public static IEnumerable<WeightLossIncentive> Data
        {
            get
            {
                yield return new WeightLossIncentive(12.5, "Control", -2);
                yield return new WeightLossIncentive(12, "Control", 7);
                yield return new WeightLossIncentive(1, "Control", 19.5);
                yield return new WeightLossIncentive(-5, "Control", -0.5);
                yield return new WeightLossIncentive(3, "Control", -1.5);
                yield return new WeightLossIncentive(-5, "Control", -10);
                yield return new WeightLossIncentive(7.5, "Control", 0.5);
                yield return new WeightLossIncentive(-2.5, "Control", 5);
                yield return new WeightLossIncentive(20, "Control", 8.5);
                yield return new WeightLossIncentive(-1, "Control", 18);
                yield return new WeightLossIncentive(2, "Control", 16);
                yield return new WeightLossIncentive(4.5, "Control", -9);
                yield return new WeightLossIncentive(-2, "Control", 4.5);
                yield return new WeightLossIncentive(-17, "Control", 23.5);
                yield return new WeightLossIncentive(19, "Control", 5.5);
                yield return new WeightLossIncentive(-2, "Control", 6.5);
                yield return new WeightLossIncentive(12, "Control", -9.5);
                yield return new WeightLossIncentive(10.5, "Control", 1.5);
                yield return new WeightLossIncentive(5, "Control", null);
                yield return new WeightLossIncentive(25.5, "Incentive", null);
                yield return new WeightLossIncentive(24, "Incentive", 11.5);
                yield return new WeightLossIncentive(8, "Incentive", 20);
                yield return new WeightLossIncentive(null, "Incentive", null);
                yield return new WeightLossIncentive(15.5, "Incentive", null);
                yield return new WeightLossIncentive(null, "Incentive", -22);
                yield return new WeightLossIncentive(21, "Incentive", 2);
                yield return new WeightLossIncentive(4.5, "Incentive", 7.5);
                yield return new WeightLossIncentive(30, "Incentive", 16.5);
                yield return new WeightLossIncentive(7.5, "Incentive", 19);
                yield return new WeightLossIncentive(10, "Incentive", 18);
                yield return new WeightLossIncentive(18, "Incentive", -1);
                yield return new WeightLossIncentive(5, "Incentive", 5.5);
                yield return new WeightLossIncentive(-0.5, "Incentive", 24.5);
                yield return new WeightLossIncentive(27, "Incentive", 9.5);
                yield return new WeightLossIncentive(6, "Incentive", 10);
                yield return new WeightLossIncentive(25.5, "Incentive", -8.5);
                yield return new WeightLossIncentive(21, "Incentive", 4.5);
                yield return new WeightLossIncentive(18.5, "Incentive", null);
            }
        }
    }
}
