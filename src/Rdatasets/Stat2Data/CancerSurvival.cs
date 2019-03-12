// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// CancerSurvival
    /// </summary>

    public class CancerSurvival
    {
        public readonly int κ;
        public readonly int Survival;
        public readonly string Organ;

        public CancerSurvival(int κ, int Survival, string Organ)
        {
            this.κ = κ;
            this.Survival = Survival;
            this.Organ = Organ;
        }

        public static IEnumerable<CancerSurvival> Data
        {
            get
            {
                yield return new CancerSurvival(1, 124, "Stomach");
                yield return new CancerSurvival(2, 42, "Stomach");
                yield return new CancerSurvival(3, 25, "Stomach");
                yield return new CancerSurvival(4, 45, "Stomach");
                yield return new CancerSurvival(5, 412, "Stomach");
                yield return new CancerSurvival(6, 51, "Stomach");
                yield return new CancerSurvival(7, 1112, "Stomach");
                yield return new CancerSurvival(8, 46, "Stomach");
                yield return new CancerSurvival(9, 103, "Stomach");
                yield return new CancerSurvival(10, 876, "Stomach");
                yield return new CancerSurvival(11, 146, "Stomach");
                yield return new CancerSurvival(12, 340, "Stomach");
                yield return new CancerSurvival(13, 396, "Stomach");
                yield return new CancerSurvival(14, 81, "Bronchus");
                yield return new CancerSurvival(15, 461, "Bronchus");
                yield return new CancerSurvival(16, 20, "Bronchus");
                yield return new CancerSurvival(17, 450, "Bronchus");
                yield return new CancerSurvival(18, 246, "Bronchus");
                yield return new CancerSurvival(19, 166, "Bronchus");
                yield return new CancerSurvival(20, 63, "Bronchus");
                yield return new CancerSurvival(21, 64, "Bronchus");
                yield return new CancerSurvival(22, 155, "Bronchus");
                yield return new CancerSurvival(23, 859, "Bronchus");
                yield return new CancerSurvival(24, 151, "Bronchus");
                yield return new CancerSurvival(25, 166, "Bronchus");
                yield return new CancerSurvival(26, 37, "Bronchus");
                yield return new CancerSurvival(27, 223, "Bronchus");
                yield return new CancerSurvival(28, 138, "Bronchus");
                yield return new CancerSurvival(29, 72, "Bronchus");
                yield return new CancerSurvival(30, 245, "Bronchus");
                yield return new CancerSurvival(31, 248, "Colon");
                yield return new CancerSurvival(32, 377, "Colon");
                yield return new CancerSurvival(33, 189, "Colon");
                yield return new CancerSurvival(34, 1843, "Colon");
                yield return new CancerSurvival(35, 180, "Colon");
                yield return new CancerSurvival(36, 537, "Colon");
                yield return new CancerSurvival(37, 519, "Colon");
                yield return new CancerSurvival(38, 455, "Colon");
                yield return new CancerSurvival(39, 406, "Colon");
                yield return new CancerSurvival(40, 365, "Colon");
                yield return new CancerSurvival(41, 942, "Colon");
                yield return new CancerSurvival(42, 776, "Colon");
                yield return new CancerSurvival(43, 372, "Colon");
                yield return new CancerSurvival(44, 163, "Colon");
                yield return new CancerSurvival(45, 101, "Colon");
                yield return new CancerSurvival(46, 20, "Colon");
                yield return new CancerSurvival(47, 283, "Colon");
                yield return new CancerSurvival(48, 1234, "Ovary");
                yield return new CancerSurvival(49, 89, "Ovary");
                yield return new CancerSurvival(50, 201, "Ovary");
                yield return new CancerSurvival(51, 356, "Ovary");
                yield return new CancerSurvival(52, 2970, "Ovary");
                yield return new CancerSurvival(53, 456, "Ovary");
                yield return new CancerSurvival(54, 1235, "Breast");
                yield return new CancerSurvival(55, 24, "Breast");
                yield return new CancerSurvival(56, 1581, "Breast");
                yield return new CancerSurvival(57, 1166, "Breast");
                yield return new CancerSurvival(58, 40, "Breast");
                yield return new CancerSurvival(59, 727, "Breast");
                yield return new CancerSurvival(60, 3808, "Breast");
                yield return new CancerSurvival(61, 791, "Breast");
                yield return new CancerSurvival(62, 1804, "Breast");
                yield return new CancerSurvival(63, 3460, "Breast");
                yield return new CancerSurvival(64, 719, "Breast");
            }
        }
    }
}
