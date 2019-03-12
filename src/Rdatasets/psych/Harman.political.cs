// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Five data sets from Harman (1967). 9 cognitive variables from Holzinger and 8 emotional variables from Burt
    /// </summary>

    public class Harman_political
    {
        public readonly string κ;
        public readonly double Lewis;
        public readonly double Roosevelt;
        public readonly double Party_Voting;
        public readonly double Median_Rental;
        public readonly double Homeownership;
        public readonly double Unemployment;
        public readonly double Mobility;
        public readonly double Education;

        public Harman_political(string κ, double Lewis, double Roosevelt, double Party_Voting, double Median_Rental, double Homeownership, double Unemployment, double Mobility, double Education)
        {
            this.κ = κ;
            this.Lewis = Lewis;
            this.Roosevelt = Roosevelt;
            this.Party_Voting = Party_Voting;
            this.Median_Rental = Median_Rental;
            this.Homeownership = Homeownership;
            this.Unemployment = Unemployment;
            this.Mobility = Mobility;
            this.Education = Education;
        }

        public static IEnumerable<Harman_political> Data
        {
            get
            {
                yield return new Harman_political("Lewis", 1, 0.84, 0.62, -0.53, 0.03, 0.57, -0.33, -0.63);
                yield return new Harman_political("Roosevelt", 0.84, 1, 0.84, -0.68, -0.05, 0.76, -0.35, -0.73);
                yield return new Harman_political("Party Voting", 0.62, 0.84, 1, -0.76, 0.08, 0.81, -0.51, -0.81);
                yield return new Harman_political("Median Rental", -0.53, -0.68, -0.76, 1, -0.25, -0.8, 0.62, 0.88);
                yield return new Harman_political("Homeownership", 0.03, -0.05, 0.08, -0.25, 1, 0.25, -0.72, -0.36);
                yield return new Harman_political("Unemployment", 0.57, 0.76, 0.81, -0.8, 0.25, 1, -0.58, -0.84);
                yield return new Harman_political("Mobility", -0.33, -0.35, -0.51, 0.62, -0.72, -0.58, 1, 0.68);
                yield return new Harman_political("Education", -0.63, -0.73, -0.81, 0.88, -0.36, -0.84, 0.68, 1);
            }
        }
    }
}
