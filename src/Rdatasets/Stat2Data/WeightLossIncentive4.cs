// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WeightLossIncentive4
    /// </summary>

    public class WeightLossIncentive4
    {
        public readonly double WeightLoss;
        public readonly string Group;

        public WeightLossIncentive4(double WeightLoss, string Group)
        {
            this.WeightLoss = WeightLoss;
            this.Group = Group;
        }

        public static IEnumerable<WeightLossIncentive4> Data
        {
            get
            {
                yield return new WeightLossIncentive4(12.5, "Control");
                yield return new WeightLossIncentive4(12, "Control");
                yield return new WeightLossIncentive4(1, "Control");
                yield return new WeightLossIncentive4(-5, "Control");
                yield return new WeightLossIncentive4(3, "Control");
                yield return new WeightLossIncentive4(-5, "Control");
                yield return new WeightLossIncentive4(7.5, "Control");
                yield return new WeightLossIncentive4(-2.5, "Control");
                yield return new WeightLossIncentive4(20, "Control");
                yield return new WeightLossIncentive4(-1, "Control");
                yield return new WeightLossIncentive4(2, "Control");
                yield return new WeightLossIncentive4(4.5, "Control");
                yield return new WeightLossIncentive4(-2, "Control");
                yield return new WeightLossIncentive4(-17, "Control");
                yield return new WeightLossIncentive4(19, "Control");
                yield return new WeightLossIncentive4(-2, "Control");
                yield return new WeightLossIncentive4(12, "Control");
                yield return new WeightLossIncentive4(10.5, "Control");
                yield return new WeightLossIncentive4(5, "Control");
                yield return new WeightLossIncentive4(25.5, "Incentive");
                yield return new WeightLossIncentive4(24, "Incentive");
                yield return new WeightLossIncentive4(8, "Incentive");
                yield return new WeightLossIncentive4(15.5, "Incentive");
                yield return new WeightLossIncentive4(21, "Incentive");
                yield return new WeightLossIncentive4(4.5, "Incentive");
                yield return new WeightLossIncentive4(30, "Incentive");
                yield return new WeightLossIncentive4(7.5, "Incentive");
                yield return new WeightLossIncentive4(10, "Incentive");
                yield return new WeightLossIncentive4(18, "Incentive");
                yield return new WeightLossIncentive4(5, "Incentive");
                yield return new WeightLossIncentive4(-0.5, "Incentive");
                yield return new WeightLossIncentive4(27, "Incentive");
                yield return new WeightLossIncentive4(6, "Incentive");
                yield return new WeightLossIncentive4(25.5, "Incentive");
                yield return new WeightLossIncentive4(21, "Incentive");
                yield return new WeightLossIncentive4(18.5, "Incentive");
            }
        }
    }
}
