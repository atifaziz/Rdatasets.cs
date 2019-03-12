// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Political
    /// </summary>

    public class Political
    {
        public readonly int κ;
        public readonly int Year;
        public readonly int Sex;
        public readonly int Vote;
        public readonly int Paper;
        public readonly int Edit;
        public readonly int TV;
        public readonly int Ethics;
        public readonly int Inform;
        public readonly int? Participate;

        public Political(int κ, int Year, int Sex, int Vote, int Paper, int Edit, int TV, int Ethics, int Inform, int? Participate)
        {
            this.κ = κ;
            this.Year = Year;
            this.Sex = Sex;
            this.Vote = Vote;
            this.Paper = Paper;
            this.Edit = Edit;
            this.TV = TV;
            this.Ethics = Ethics;
            this.Inform = Inform;
            this.Participate = Participate;
        }

        public static IEnumerable<Political> Data
        {
            get
            {
                yield return new Political(1, 1, 1, 1, 3, 1, 0, 2, 2, 0);
                yield return new Political(2, 4, 1, 3, 1, 1, 3, 2, 2, 1);
                yield return new Political(3, 2, 0, 3, 4, 1, 3, 2, 3, 1);
                yield return new Political(4, 3, 1, 3, 3, 1, 0, 3, 2, 1);
                yield return new Political(5, 1, 1, 3, 2, 0, 0, 2, 3, 1);
                yield return new Political(6, 2, 1, 2, 3, 1, 3, 2, 4, 0);
                yield return new Political(7, 1, 0, 2, 4, 1, 0, 4, 4, 0);
                yield return new Political(8, 3, 1, 3, 2, 1, 1, 2, 3, 1);
                yield return new Political(9, 4, 0, 3, 3, 1, 0, 4, 3, 1);
                yield return new Political(10, 4, 1, 3, 3, 0, 4, 3, 3, 1);
                yield return new Political(11, 3, 0, 3, 4, 1, 0, 4, 3, 1);
                yield return new Political(12, 4, 1, 3, 2, 0, 2, 2, 3, 1);
                yield return new Political(13, 1, 1, 1, 2, 0, 3, 2, 2, 0);
                yield return new Political(14, 1, 0, 3, 3, 0, 4, 3, 3, 1);
                yield return new Political(15, 3, 1, 0, 1, 1, 3, 3, 3, null);
                yield return new Political(16, 1, 1, 2, 1, 1, 0, 3, 2, 0);
                yield return new Political(17, 1, 1, 2, 1, 0, 2, 3, 2, 0);
                yield return new Political(18, 2, 1, 3, 3, 0, 2, 2, 3, 1);
                yield return new Political(19, 2, 0, 1, 3, 1, 4, 3, 5, 0);
                yield return new Political(20, 1, 1, 3, 1, 0, 2, 2, 2, 1);
                yield return new Political(21, 4, 1, 3, 2, 0, 2, 2, 3, 1);
                yield return new Political(22, 3, 1, 2, 3, 0, 0, 2, 3, 0);
                yield return new Political(23, 1, 0, 3, 2, 1, 0, 3, 4, 1);
                yield return new Political(24, 1, 1, 1, 2, 1, 0, 3, 2, 0);
                yield return new Political(25, 2, 1, 3, 1, 0, 0, 3, 2, 1);
                yield return new Political(26, 2, 0, 3, 4, 1, 3, 3, 5, 1);
                yield return new Political(27, 2, 1, 3, 3, 0, 0, 4, 2, 1);
                yield return new Political(28, 4, 0, 1, 0, 0, 4, 2, 1, 0);
                yield return new Political(29, 4, 1, 3, 3, 1, 3, 2, 3, 1);
                yield return new Political(30, 2, 0, 1, 4, 1, 3, 4, 4, 0);
                yield return new Political(31, 3, 0, 1, 0, 0, 2, 5, 3, 0);
                yield return new Political(32, 3, 0, 2, 4, 1, 4, 2, 4, 0);
                yield return new Political(33, 3, 0, 1, 3, 1, 0, 2, 3, 0);
                yield return new Political(34, 4, 0, 3, 3, 1, 2, 4, 4, 1);
                yield return new Political(35, 1, 1, 2, 0, 0, 0, 2, 2, 0);
                yield return new Political(36, 2, 1, 3, 4, 1, 0, 2, 3, 1);
                yield return new Political(37, 2, 0, 3, 3, 1, 3, 5, 3, 1);
                yield return new Political(38, 2, 0, 1, 3, 1, 0, 2, 2, 0);
                yield return new Political(39, 2, 0, 3, 4, 1, 3, 3, 5, 1);
                yield return new Political(40, 2, 0, 3, 3, 1, 3, 3, 3, 1);
                yield return new Political(41, 3, 0, 1, 4, 1, 0, 4, 3, 0);
                yield return new Political(42, 3, 0, 3, 3, 1, 0, 4, 3, 1);
                yield return new Political(43, 1, 0, 0, 2, 0, 1, 4, 2, null);
                yield return new Political(44, 3, 0, 0, 4, 1, 4, 3, 5, null);
                yield return new Political(45, 1, 0, 3, 4, 1, 0, 3, 3, 1);
                yield return new Political(46, 4, 1, 3, 1, 0, 3, 2, 4, 1);
                yield return new Political(47, 2, 1, 3, 2, 0, 3, 2, 3, 1);
                yield return new Political(48, 1, 0, 1, 0, 0, 0, 5, 1, 0);
                yield return new Political(49, 1, 0, 1, 3, 0, 3, 4, 3, 0);
                yield return new Political(50, 4, 0, 3, 3, 1, 3, 4, 3, 1);
                yield return new Political(51, 3, 1, 3, 4, 1, 1, 2, 4, 1);
                yield return new Political(52, 2, 0, 0, 3, 0, 3, 3, 3, null);
                yield return new Political(53, 4, 0, 1, 4, 1, 4, 2, 3, 0);
                yield return new Political(54, 2, 0, 2, 4, 1, 0, 3, 3, 0);
                yield return new Political(55, 1, 1, 3, 2, 0, 0, 2, 3, 1);
                yield return new Political(56, 2, 1, 3, 3, 0, 3, 2, 3, 1);
                yield return new Political(57, 1, 0, 3, 3, 0, 0, 2, 3, 1);
                yield return new Political(58, 3, 1, 3, 3, 0, 4, 3, 4, 1);
                yield return new Political(59, 2, 0, 1, 4, 0, 3, 3, 4, 0);
            }
        }
    }
}
