// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// CancerSurvival
    /// </summary>

    public class CancerSurvival
    {
        public readonly int Survival;
        public readonly string Organ;

        public CancerSurvival(int Survival, string Organ)
        {
            this.Survival = Survival;
            this.Organ = Organ;
        }

        public static IEnumerable<CancerSurvival> Data
        {
            get
            {
                yield return new CancerSurvival(124, "Stomach");
                yield return new CancerSurvival(42, "Stomach");
                yield return new CancerSurvival(25, "Stomach");
                yield return new CancerSurvival(45, "Stomach");
                yield return new CancerSurvival(412, "Stomach");
                yield return new CancerSurvival(51, "Stomach");
                yield return new CancerSurvival(1112, "Stomach");
                yield return new CancerSurvival(46, "Stomach");
                yield return new CancerSurvival(103, "Stomach");
                yield return new CancerSurvival(876, "Stomach");
                yield return new CancerSurvival(146, "Stomach");
                yield return new CancerSurvival(340, "Stomach");
                yield return new CancerSurvival(396, "Stomach");
                yield return new CancerSurvival(81, "Bronchus");
                yield return new CancerSurvival(461, "Bronchus");
                yield return new CancerSurvival(20, "Bronchus");
                yield return new CancerSurvival(450, "Bronchus");
                yield return new CancerSurvival(246, "Bronchus");
                yield return new CancerSurvival(166, "Bronchus");
                yield return new CancerSurvival(63, "Bronchus");
                yield return new CancerSurvival(64, "Bronchus");
                yield return new CancerSurvival(155, "Bronchus");
                yield return new CancerSurvival(859, "Bronchus");
                yield return new CancerSurvival(151, "Bronchus");
                yield return new CancerSurvival(166, "Bronchus");
                yield return new CancerSurvival(37, "Bronchus");
                yield return new CancerSurvival(223, "Bronchus");
                yield return new CancerSurvival(138, "Bronchus");
                yield return new CancerSurvival(72, "Bronchus");
                yield return new CancerSurvival(245, "Bronchus");
                yield return new CancerSurvival(248, "Colon");
                yield return new CancerSurvival(377, "Colon");
                yield return new CancerSurvival(189, "Colon");
                yield return new CancerSurvival(1843, "Colon");
                yield return new CancerSurvival(180, "Colon");
                yield return new CancerSurvival(537, "Colon");
                yield return new CancerSurvival(519, "Colon");
                yield return new CancerSurvival(455, "Colon");
                yield return new CancerSurvival(406, "Colon");
                yield return new CancerSurvival(365, "Colon");
                yield return new CancerSurvival(942, "Colon");
                yield return new CancerSurvival(776, "Colon");
                yield return new CancerSurvival(372, "Colon");
                yield return new CancerSurvival(163, "Colon");
                yield return new CancerSurvival(101, "Colon");
                yield return new CancerSurvival(20, "Colon");
                yield return new CancerSurvival(283, "Colon");
                yield return new CancerSurvival(1234, "Ovary");
                yield return new CancerSurvival(89, "Ovary");
                yield return new CancerSurvival(201, "Ovary");
                yield return new CancerSurvival(356, "Ovary");
                yield return new CancerSurvival(2970, "Ovary");
                yield return new CancerSurvival(456, "Ovary");
                yield return new CancerSurvival(1235, "Breast");
                yield return new CancerSurvival(24, "Breast");
                yield return new CancerSurvival(1581, "Breast");
                yield return new CancerSurvival(1166, "Breast");
                yield return new CancerSurvival(40, "Breast");
                yield return new CancerSurvival(727, "Breast");
                yield return new CancerSurvival(3808, "Breast");
                yield return new CancerSurvival(791, "Breast");
                yield return new CancerSurvival(1804, "Breast");
                yield return new CancerSurvival(3460, "Breast");
                yield return new CancerSurvival(719, "Breast");
            }
        }
    }
}
