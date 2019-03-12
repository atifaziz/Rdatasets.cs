// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// Absentee and Machine Ballots in Pennsylvania State Senate Races
    /// </summary>

    public class absentee
    {
        public readonly int κ;
        public readonly int year;
        public readonly int district;
        public readonly int absdem;
        public readonly int absrep;
        public readonly int machdem;
        public readonly int machrep;
        public readonly int dabs;
        public readonly int dmach;

        public absentee(int κ, int year, int district, int absdem, int absrep, int machdem, int machrep, int dabs, int dmach)
        {
            this.κ = κ;
            this.year = year;
            this.district = district;
            this.absdem = absdem;
            this.absrep = absrep;
            this.machdem = machdem;
            this.machrep = machrep;
            this.dabs = dabs;
            this.dmach = dmach;
        }

        public static IEnumerable<absentee> Data
        {
            get
            {
                yield return new absentee(1, 82, 2, 551, 205, 47767, 21340, 346, 26427);
                yield return new absentee(2, 82, 4, 594, 312, 44437, 28533, 282, 15904);
                yield return new absentee(3, 82, 8, 338, 115, 55662, 13214, 223, 42448);
                yield return new absentee(4, 84, 1, 1357, 764, 58327, 38883, 593, 19444);
                yield return new absentee(5, 84, 3, 716, 144, 78270, 6473, 572, 71797);
                yield return new absentee(6, 84, 5, 1207, 1436, 54812, 55829, -229, -1017);
                yield return new absentee(7, 84, 7, 929, 258, 77136, 13730, 671, 63406);
                yield return new absentee(8, 86, 2, 609, 316, 39034, 23363, 293, 15671);
                yield return new absentee(9, 86, 4, 666, 306, 52817, 16541, 360, 36276);
                yield return new absentee(10, 86, 8, 477, 171, 48315, 11605, 306, 36710);
                yield return new absentee(11, 88, 1, 1101, 700, 56362, 34514, 401, 21848);
                yield return new absentee(12, 88, 3, 448, 70, 69801, 3939, 378, 65862);
                yield return new absentee(13, 88, 5, 781, 1610, 43527, 56721, -829, -13194);
                yield return new absentee(14, 88, 7, 644, 250, 68702, 12602, 394, 56100);
                yield return new absentee(15, 90, 2, 660, 509, 27543, 26843, 151, 700);
                yield return new absentee(16, 90, 4, 482, 831, 39193, 27664, -349, 11529);
                yield return new absentee(17, 90, 8, 308, 148, 34598, 8551, 160, 26047);
                yield return new absentee(18, 92, 1, 1923, 594, 65943, 21518, 1329, 44425);
                yield return new absentee(19, 92, 3, 695, 327, 58480, 12968, 368, 45512);
                yield return new absentee(20, 92, 5, 841, 1275, 41267, 46967, -434, -5700);
                yield return new absentee(21, 92, 7, 814, 423, 65516, 14310, 391, 51206);
                yield return new absentee(22, 93, 2, 1396, 371, 19127, 19691, 1025, -564);
            }
        }
    }
}
