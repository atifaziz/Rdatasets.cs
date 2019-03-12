// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WeightLossIncentive4
    /// </summary>

    public class WeightLossIncentive4
    {
        public readonly int κ;
        public readonly double WeightLoss;
        public readonly string Group;

        public WeightLossIncentive4(int κ, double WeightLoss, string Group)
        {
            this.κ = κ;
            this.WeightLoss = WeightLoss;
            this.Group = Group;
        }

        public static IEnumerable<WeightLossIncentive4> Data
        {
            get
            {
                yield return new WeightLossIncentive4(1, 12.5, "Control");
                yield return new WeightLossIncentive4(2, 12, "Control");
                yield return new WeightLossIncentive4(3, 1, "Control");
                yield return new WeightLossIncentive4(4, -5, "Control");
                yield return new WeightLossIncentive4(5, 3, "Control");
                yield return new WeightLossIncentive4(6, -5, "Control");
                yield return new WeightLossIncentive4(7, 7.5, "Control");
                yield return new WeightLossIncentive4(8, -2.5, "Control");
                yield return new WeightLossIncentive4(9, 20, "Control");
                yield return new WeightLossIncentive4(10, -1, "Control");
                yield return new WeightLossIncentive4(11, 2, "Control");
                yield return new WeightLossIncentive4(12, 4.5, "Control");
                yield return new WeightLossIncentive4(13, -2, "Control");
                yield return new WeightLossIncentive4(14, -17, "Control");
                yield return new WeightLossIncentive4(15, 19, "Control");
                yield return new WeightLossIncentive4(16, -2, "Control");
                yield return new WeightLossIncentive4(17, 12, "Control");
                yield return new WeightLossIncentive4(18, 10.5, "Control");
                yield return new WeightLossIncentive4(19, 5, "Control");
                yield return new WeightLossIncentive4(20, 25.5, "Incentive");
                yield return new WeightLossIncentive4(21, 24, "Incentive");
                yield return new WeightLossIncentive4(22, 8, "Incentive");
                yield return new WeightLossIncentive4(23, 15.5, "Incentive");
                yield return new WeightLossIncentive4(24, 21, "Incentive");
                yield return new WeightLossIncentive4(25, 4.5, "Incentive");
                yield return new WeightLossIncentive4(26, 30, "Incentive");
                yield return new WeightLossIncentive4(27, 7.5, "Incentive");
                yield return new WeightLossIncentive4(28, 10, "Incentive");
                yield return new WeightLossIncentive4(29, 18, "Incentive");
                yield return new WeightLossIncentive4(30, 5, "Incentive");
                yield return new WeightLossIncentive4(31, -0.5, "Incentive");
                yield return new WeightLossIncentive4(32, 27, "Incentive");
                yield return new WeightLossIncentive4(33, 6, "Incentive");
                yield return new WeightLossIncentive4(34, 25.5, "Incentive");
                yield return new WeightLossIncentive4(35, 21, "Incentive");
                yield return new WeightLossIncentive4(36, 18.5, "Incentive");
            }
        }
    }
}
