// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WalkingBabies
    /// </summary>

    public class WalkingBabies
    {
        public readonly string Group;
        public readonly double Age;

        public WalkingBabies(string Group, double Age)
        {
            this.Group = Group;
            this.Age = Age;
        }

        public static IEnumerable<WalkingBabies> Data
        {
            get
            {
                yield return new WalkingBabies("special exercises", 9);
                yield return new WalkingBabies("special exercises", 9.5);
                yield return new WalkingBabies("special exercises", 9.75);
                yield return new WalkingBabies("special exercises", 10);
                yield return new WalkingBabies("special exercises", 13);
                yield return new WalkingBabies("special exercises", 9.5);
                yield return new WalkingBabies("exercise control", 11);
                yield return new WalkingBabies("exercise control", 10);
                yield return new WalkingBabies("exercise control", 10);
                yield return new WalkingBabies("exercise control", 11.8);
                yield return new WalkingBabies("exercise control", 10.5);
                yield return new WalkingBabies("exercise control", 15);
                yield return new WalkingBabies("weekly report", 11);
                yield return new WalkingBabies("weekly report", 12);
                yield return new WalkingBabies("weekly report", 9);
                yield return new WalkingBabies("weekly report", 11.5);
                yield return new WalkingBabies("weekly report", 13.3);
                yield return new WalkingBabies("weekly report", 13);
                yield return new WalkingBabies("final report", 13.3);
                yield return new WalkingBabies("final report", 11.5);
                yield return new WalkingBabies("final report", 12);
                yield return new WalkingBabies("final report", 13.5);
                yield return new WalkingBabies("final report", 11.5);
                yield return new WalkingBabies("final report", 12.36);
            }
        }
    }
}
