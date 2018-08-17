// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Political
    /// </summary>

    public class Political
    {
        public readonly int Year;
        public readonly int Sex;
        public readonly int Vote;
        public readonly int Paper;
        public readonly int Edit;
        public readonly int TV;
        public readonly int Ethics;
        public readonly int Inform;
        public readonly string Participate;

        public Political(int Year, int Sex, int Vote, int Paper, int Edit, int TV, int Ethics, int Inform, string Participate)
        {
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
                yield return new Political(1, 1, 1, 3, 1, 0, 2, 2, "0");
                yield return new Political(4, 1, 3, 1, 1, 3, 2, 2, "1");
                yield return new Political(2, 0, 3, 4, 1, 3, 2, 3, "1");
                yield return new Political(3, 1, 3, 3, 1, 0, 3, 2, "1");
                yield return new Political(1, 1, 3, 2, 0, 0, 2, 3, "1");
                yield return new Political(2, 1, 2, 3, 1, 3, 2, 4, "0");
                yield return new Political(1, 0, 2, 4, 1, 0, 4, 4, "0");
                yield return new Political(3, 1, 3, 2, 1, 1, 2, 3, "1");
                yield return new Political(4, 0, 3, 3, 1, 0, 4, 3, "1");
                yield return new Political(4, 1, 3, 3, 0, 4, 3, 3, "1");
                yield return new Political(3, 0, 3, 4, 1, 0, 4, 3, "1");
                yield return new Political(4, 1, 3, 2, 0, 2, 2, 3, "1");
                yield return new Political(1, 1, 1, 2, 0, 3, 2, 2, "0");
                yield return new Political(1, 0, 3, 3, 0, 4, 3, 3, "1");
                yield return new Political(3, 1, 0, 1, 1, 3, 3, 3, null);
                yield return new Political(1, 1, 2, 1, 1, 0, 3, 2, "0");
                yield return new Political(1, 1, 2, 1, 0, 2, 3, 2, "0");
                yield return new Political(2, 1, 3, 3, 0, 2, 2, 3, "1");
                yield return new Political(2, 0, 1, 3, 1, 4, 3, 5, "0");
                yield return new Political(1, 1, 3, 1, 0, 2, 2, 2, "1");
                yield return new Political(4, 1, 3, 2, 0, 2, 2, 3, "1");
                yield return new Political(3, 1, 2, 3, 0, 0, 2, 3, "0");
                yield return new Political(1, 0, 3, 2, 1, 0, 3, 4, "1");
                yield return new Political(1, 1, 1, 2, 1, 0, 3, 2, "0");
                yield return new Political(2, 1, 3, 1, 0, 0, 3, 2, "1");
                yield return new Political(2, 0, 3, 4, 1, 3, 3, 5, "1");
                yield return new Political(2, 1, 3, 3, 0, 0, 4, 2, "1");
                yield return new Political(4, 0, 1, 0, 0, 4, 2, 1, "0");
                yield return new Political(4, 1, 3, 3, 1, 3, 2, 3, "1");
                yield return new Political(2, 0, 1, 4, 1, 3, 4, 4, "0");
                yield return new Political(3, 0, 1, 0, 0, 2, 5, 3, "0");
                yield return new Political(3, 0, 2, 4, 1, 4, 2, 4, "0");
                yield return new Political(3, 0, 1, 3, 1, 0, 2, 3, "0");
                yield return new Political(4, 0, 3, 3, 1, 2, 4, 4, "1");
                yield return new Political(1, 1, 2, 0, 0, 0, 2, 2, "0");
                yield return new Political(2, 1, 3, 4, 1, 0, 2, 3, "1");
                yield return new Political(2, 0, 3, 3, 1, 3, 5, 3, "1");
                yield return new Political(2, 0, 1, 3, 1, 0, 2, 2, "0");
                yield return new Political(2, 0, 3, 4, 1, 3, 3, 5, "1");
                yield return new Political(2, 0, 3, 3, 1, 3, 3, 3, "1");
                yield return new Political(3, 0, 1, 4, 1, 0, 4, 3, "0");
                yield return new Political(3, 0, 3, 3, 1, 0, 4, 3, "1");
                yield return new Political(1, 0, 0, 2, 0, 1, 4, 2, null);
                yield return new Political(3, 0, 0, 4, 1, 4, 3, 5, null);
                yield return new Political(1, 0, 3, 4, 1, 0, 3, 3, "1");
                yield return new Political(4, 1, 3, 1, 0, 3, 2, 4, "1");
                yield return new Political(2, 1, 3, 2, 0, 3, 2, 3, "1");
                yield return new Political(1, 0, 1, 0, 0, 0, 5, 1, "0");
                yield return new Political(1, 0, 1, 3, 0, 3, 4, 3, "0");
                yield return new Political(4, 0, 3, 3, 1, 3, 4, 3, "1");
                yield return new Political(3, 1, 3, 4, 1, 1, 2, 4, "1");
                yield return new Political(2, 0, 0, 3, 0, 3, 3, 3, null);
                yield return new Political(4, 0, 1, 4, 1, 4, 2, 3, "0");
                yield return new Political(2, 0, 2, 4, 1, 0, 3, 3, "0");
                yield return new Political(1, 1, 3, 2, 0, 0, 2, 3, "1");
                yield return new Political(2, 1, 3, 3, 0, 3, 2, 3, "1");
                yield return new Political(1, 0, 3, 3, 0, 0, 2, 3, "1");
                yield return new Political(3, 1, 3, 3, 0, 4, 3, 4, "1");
                yield return new Political(2, 0, 1, 4, 0, 3, 3, 4, "0");
            }
        }
    }
}
