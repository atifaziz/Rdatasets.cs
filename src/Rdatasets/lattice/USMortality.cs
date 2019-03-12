// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Mortality Rates in US by Cause and Gender
    /// </summary>

    public class USMortality
    {
        public readonly int κ;
        public readonly string Status;
        public readonly string Sex;
        public readonly string Cause;
        public readonly double Rate;
        public readonly double SE;

        public USMortality(int κ, string Status, string Sex, string Cause, double Rate, double SE)
        {
            this.κ = κ;
            this.Status = Status;
            this.Sex = Sex;
            this.Cause = Cause;
            this.Rate = Rate;
            this.SE = SE;
        }

        public static IEnumerable<USMortality> Data
        {
            get
            {
                yield return new USMortality(1, "Urban", "Male", "Heart disease", 210.2, 0.2);
                yield return new USMortality(2, "Rural", "Male", "Heart disease", 242.7, 0.6);
                yield return new USMortality(3, "Urban", "Female", "Heart disease", 132.5, 0.2);
                yield return new USMortality(4, "Rural", "Female", "Heart disease", 154.9, 0.4);
                yield return new USMortality(53, "Urban", "Male", "Cancer", 195.9, 0.2);
                yield return new USMortality(54, "Rural", "Male", "Cancer", 219.3, 0.5);
                yield return new USMortality(55, "Urban", "Female", "Cancer", 140.2, 0.2);
                yield return new USMortality(56, "Rural", "Female", "Cancer", 150.8, 0.4);
                yield return new USMortality(105, "Urban", "Male", "Lower respiratory", 44.5, 0.1);
                yield return new USMortality(106, "Rural", "Male", "Lower respiratory", 62.8, 0.3);
                yield return new USMortality(107, "Urban", "Female", "Lower respiratory", 36.5, 0.1);
                yield return new USMortality(108, "Rural", "Female", "Lower respiratory", 46.9, 0.2);
                yield return new USMortality(157, "Urban", "Male", "Unintentional injuries", 49.6, 0.1);
                yield return new USMortality(158, "Rural", "Male", "Unintentional injuries", 71.3, 0.3);
                yield return new USMortality(159, "Urban", "Female", "Unintentional injuries", 24.7, 0.1);
                yield return new USMortality(160, "Rural", "Female", "Unintentional injuries", 37.2, 0.2);
                yield return new USMortality(209, "Urban", "Male", "Cerebrovascular diseases", 36.1, 0.1);
                yield return new USMortality(210, "Rural", "Male", "Cerebrovascular diseases", 42.2, 0.2);
                yield return new USMortality(211, "Urban", "Female", "Cerebrovascular diseases", 34.9, 0.1);
                yield return new USMortality(212, "Rural", "Female", "Cerebrovascular diseases", 42.2, 0.2);
                yield return new USMortality(261, "Urban", "Male", "Alzheimers", 19.4, 0.1);
                yield return new USMortality(262, "Rural", "Male", "Alzheimers", 21.8, 0.2);
                yield return new USMortality(263, "Urban", "Female", "Alzheimers", 25.5, 0.1);
                yield return new USMortality(264, "Rural", "Female", "Alzheimers", 30.6, 0.2);
                yield return new USMortality(313, "Urban", "Male", "Diabetes", 24.9, 0.1);
                yield return new USMortality(314, "Rural", "Male", "Diabetes", 29.5, 0.2);
                yield return new USMortality(315, "Urban", "Female", "Diabetes", 17.1, 0.1);
                yield return new USMortality(316, "Rural", "Female", "Diabetes", 21.8, 0.2);
                yield return new USMortality(365, "Urban", "Male", "Flu and pneumonia", 17.7, 0.1);
                yield return new USMortality(366, "Rural", "Male", "Flu and pneumonia", 20.8, 0.2);
                yield return new USMortality(367, "Urban", "Female", "Flu and pneumonia", 12.9, 0.1);
                yield return new USMortality(368, "Rural", "Female", "Flu and pneumonia", 16.3, 0.1);
                yield return new USMortality(417, "Urban", "Male", "Suicide", 19.2, 0.1);
                yield return new USMortality(418, "Rural", "Male", "Suicide", 26.3, 0.2);
                yield return new USMortality(419, "Urban", "Female", "Suicide", 5.3, 0);
                yield return new USMortality(420, "Rural", "Female", "Suicide", 6.2, 0.1);
                yield return new USMortality(469, "Urban", "Male", "Nephritis", 15.7, 0.1);
                yield return new USMortality(470, "Rural", "Male", "Nephritis", 18.3, 0.2);
                yield return new USMortality(471, "Urban", "Female", "Nephritis", 10.7, 0);
                yield return new USMortality(472, "Rural", "Female", "Nephritis", 13.9, 0.1);
            }
        }
    }
}
