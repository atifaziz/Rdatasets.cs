// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WalkingBabies
    /// </summary>

    public class WalkingBabies
    {
        public readonly int κ;
        public readonly string Group;
        public readonly double Age;

        public WalkingBabies(int κ, string Group, double Age)
        {
            this.κ = κ;
            this.Group = Group;
            this.Age = Age;
        }

        public static IEnumerable<WalkingBabies> Data
        {
            get
            {
                yield return new WalkingBabies(1, "special exercises", 9);
                yield return new WalkingBabies(2, "special exercises", 9.5);
                yield return new WalkingBabies(3, "special exercises", 9.75);
                yield return new WalkingBabies(4, "special exercises", 10);
                yield return new WalkingBabies(5, "special exercises", 13);
                yield return new WalkingBabies(6, "special exercises", 9.5);
                yield return new WalkingBabies(7, "exercise control", 11);
                yield return new WalkingBabies(8, "exercise control", 10);
                yield return new WalkingBabies(9, "exercise control", 10);
                yield return new WalkingBabies(10, "exercise control", 11.8);
                yield return new WalkingBabies(11, "exercise control", 10.5);
                yield return new WalkingBabies(12, "exercise control", 15);
                yield return new WalkingBabies(13, "weekly report", 11);
                yield return new WalkingBabies(14, "weekly report", 12);
                yield return new WalkingBabies(15, "weekly report", 9);
                yield return new WalkingBabies(16, "weekly report", 11.5);
                yield return new WalkingBabies(17, "weekly report", 13.3);
                yield return new WalkingBabies(18, "weekly report", 13);
                yield return new WalkingBabies(19, "final report", 13.3);
                yield return new WalkingBabies(20, "final report", 11.5);
                yield return new WalkingBabies(21, "final report", 12);
                yield return new WalkingBabies(22, "final report", 13.5);
                yield return new WalkingBabies(23, "final report", 11.5);
                yield return new WalkingBabies(24, "final report", 12.36);
            }
        }
    }
}
