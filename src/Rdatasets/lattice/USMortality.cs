// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Mortality Rates in US by Cause and Gender
    /// </summary>

    public class USMortality
    {
        public readonly string Status;
        public readonly string Sex;
        public readonly string Cause;
        public readonly double Rate;
        public readonly double SE;

        public USMortality(string Status, string Sex, string Cause, double Rate, double SE)
        {
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
                yield return new USMortality("Urban", "Male", "Heart disease", 210.2, 0.2);
                yield return new USMortality("Rural", "Male", "Heart disease", 242.7, 0.6);
                yield return new USMortality("Urban", "Female", "Heart disease", 132.5, 0.2);
                yield return new USMortality("Rural", "Female", "Heart disease", 154.9, 0.4);
                yield return new USMortality("Urban", "Male", "Cancer", 195.9, 0.2);
                yield return new USMortality("Rural", "Male", "Cancer", 219.3, 0.5);
                yield return new USMortality("Urban", "Female", "Cancer", 140.2, 0.2);
                yield return new USMortality("Rural", "Female", "Cancer", 150.8, 0.4);
                yield return new USMortality("Urban", "Male", "Lower respiratory", 44.5, 0.1);
                yield return new USMortality("Rural", "Male", "Lower respiratory", 62.8, 0.3);
                yield return new USMortality("Urban", "Female", "Lower respiratory", 36.5, 0.1);
                yield return new USMortality("Rural", "Female", "Lower respiratory", 46.9, 0.2);
                yield return new USMortality("Urban", "Male", "Unintentional injuries", 49.6, 0.1);
                yield return new USMortality("Rural", "Male", "Unintentional injuries", 71.3, 0.3);
                yield return new USMortality("Urban", "Female", "Unintentional injuries", 24.7, 0.1);
                yield return new USMortality("Rural", "Female", "Unintentional injuries", 37.2, 0.2);
                yield return new USMortality("Urban", "Male", "Cerebrovascular diseases", 36.1, 0.1);
                yield return new USMortality("Rural", "Male", "Cerebrovascular diseases", 42.2, 0.2);
                yield return new USMortality("Urban", "Female", "Cerebrovascular diseases", 34.9, 0.1);
                yield return new USMortality("Rural", "Female", "Cerebrovascular diseases", 42.2, 0.2);
                yield return new USMortality("Urban", "Male", "Alzheimers", 19.4, 0.1);
                yield return new USMortality("Rural", "Male", "Alzheimers", 21.8, 0.2);
                yield return new USMortality("Urban", "Female", "Alzheimers", 25.5, 0.1);
                yield return new USMortality("Rural", "Female", "Alzheimers", 30.6, 0.2);
                yield return new USMortality("Urban", "Male", "Diabetes", 24.9, 0.1);
                yield return new USMortality("Rural", "Male", "Diabetes", 29.5, 0.2);
                yield return new USMortality("Urban", "Female", "Diabetes", 17.1, 0.1);
                yield return new USMortality("Rural", "Female", "Diabetes", 21.8, 0.2);
                yield return new USMortality("Urban", "Male", "Flu and pneumonia", 17.7, 0.1);
                yield return new USMortality("Rural", "Male", "Flu and pneumonia", 20.8, 0.2);
                yield return new USMortality("Urban", "Female", "Flu and pneumonia", 12.9, 0.1);
                yield return new USMortality("Rural", "Female", "Flu and pneumonia", 16.3, 0.1);
                yield return new USMortality("Urban", "Male", "Suicide", 19.2, 0.1);
                yield return new USMortality("Rural", "Male", "Suicide", 26.3, 0.2);
                yield return new USMortality("Urban", "Female", "Suicide", 5.3, 0);
                yield return new USMortality("Rural", "Female", "Suicide", 6.2, 0.1);
                yield return new USMortality("Urban", "Male", "Nephritis", 15.7, 0.1);
                yield return new USMortality("Rural", "Male", "Nephritis", 18.3, 0.2);
                yield return new USMortality("Urban", "Female", "Nephritis", 10.7, 0);
                yield return new USMortality("Rural", "Female", "Nephritis", 13.9, 0.1);
            }
        }
    }
}
