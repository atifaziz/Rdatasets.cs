// ReSharper disable All

namespace Rdatasets.sandwich
{
    using System.Collections.Generic;

    /// <summary>
    /// US Expenditures for Public Schools
    /// </summary>

    public class PublicSchools
    {
        public readonly int? Expenditure;
        public readonly int Income;

        public PublicSchools(int? Expenditure, int Income)
        {
            this.Expenditure = Expenditure;
            this.Income = Income;
        }

        public static IEnumerable<PublicSchools> Data
        {
            get
            {
                yield return new PublicSchools(275, 6247);
                yield return new PublicSchools(821, 10851);
                yield return new PublicSchools(339, 7374);
                yield return new PublicSchools(275, 6183);
                yield return new PublicSchools(387, 8850);
                yield return new PublicSchools(452, 8001);
                yield return new PublicSchools(531, 8914);
                yield return new PublicSchools(424, 8604);
                yield return new PublicSchools(316, 7505);
                yield return new PublicSchools(265, 6700);
                yield return new PublicSchools(403, 8380);
                yield return new PublicSchools(304, 6813);
                yield return new PublicSchools(437, 8745);
                yield return new PublicSchools(345, 7696);
                yield return new PublicSchools(431, 7873);
                yield return new PublicSchools(355, 8001);
                yield return new PublicSchools(260, 6615);
                yield return new PublicSchools(316, 6640);
                yield return new PublicSchools(327, 6333);
                yield return new PublicSchools(427, 8306);
                yield return new PublicSchools(427, 8063);
                yield return new PublicSchools(466, 8442);
                yield return new PublicSchools(477, 7847);
                yield return new PublicSchools(259, 5736);
                yield return new PublicSchools(274, 7342);
                yield return new PublicSchools(433, 7051);
                yield return new PublicSchools(294, 7391);
                yield return new PublicSchools(359, 9032);
                yield return new PublicSchools(279, 7277);
                yield return new PublicSchools(423, 8818);
                yield return new PublicSchools(388, 6505);
                yield return new PublicSchools(447, 8267);
                yield return new PublicSchools(335, 6607);
                yield return new PublicSchools(311, 7478);
                yield return new PublicSchools(322, 7812);
                yield return new PublicSchools(320, 6951);
                yield return new PublicSchools(397, 7839);
                yield return new PublicSchools(412, 7733);
                yield return new PublicSchools(342, 7526);
                yield return new PublicSchools(315, 6242);
                yield return new PublicSchools(321, 6841);
                yield return new PublicSchools(268, 6489);
                yield return new PublicSchools(315, 7697);
                yield return new PublicSchools(417, 6622);
                yield return new PublicSchools(353, 6541);
                yield return new PublicSchools(356, 7624);
                yield return new PublicSchools(415, 8450);
                yield return new PublicSchools(428, 10022);
                yield return new PublicSchools(320, 6456);
                yield return new PublicSchools(null, 7597);
                yield return new PublicSchools(500, 9096);
            }
        }
    }
}
