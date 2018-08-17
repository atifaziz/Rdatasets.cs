// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson Speed of Light Data
    /// </summary>

    public class morley
    {
        public readonly int Expt;
        public readonly int Run;
        public readonly int Speed;

        public morley(int Expt, int Run, int Speed)
        {
            this.Expt = Expt;
            this.Run = Run;
            this.Speed = Speed;
        }

        public static IEnumerable<morley> Data
        {
            get
            {
                yield return new morley(1, 1, 850);
                yield return new morley(1, 2, 740);
                yield return new morley(1, 3, 900);
                yield return new morley(1, 4, 1070);
                yield return new morley(1, 5, 930);
                yield return new morley(1, 6, 850);
                yield return new morley(1, 7, 950);
                yield return new morley(1, 8, 980);
                yield return new morley(1, 9, 980);
                yield return new morley(1, 10, 880);
                yield return new morley(1, 11, 1000);
                yield return new morley(1, 12, 980);
                yield return new morley(1, 13, 930);
                yield return new morley(1, 14, 650);
                yield return new morley(1, 15, 760);
                yield return new morley(1, 16, 810);
                yield return new morley(1, 17, 1000);
                yield return new morley(1, 18, 1000);
                yield return new morley(1, 19, 960);
                yield return new morley(1, 20, 960);
                yield return new morley(2, 1, 960);
                yield return new morley(2, 2, 940);
                yield return new morley(2, 3, 960);
                yield return new morley(2, 4, 940);
                yield return new morley(2, 5, 880);
                yield return new morley(2, 6, 800);
                yield return new morley(2, 7, 850);
                yield return new morley(2, 8, 880);
                yield return new morley(2, 9, 900);
                yield return new morley(2, 10, 840);
                yield return new morley(2, 11, 830);
                yield return new morley(2, 12, 790);
                yield return new morley(2, 13, 810);
                yield return new morley(2, 14, 880);
                yield return new morley(2, 15, 880);
                yield return new morley(2, 16, 830);
                yield return new morley(2, 17, 800);
                yield return new morley(2, 18, 790);
                yield return new morley(2, 19, 760);
                yield return new morley(2, 20, 800);
                yield return new morley(3, 1, 880);
                yield return new morley(3, 2, 880);
                yield return new morley(3, 3, 880);
                yield return new morley(3, 4, 860);
                yield return new morley(3, 5, 720);
                yield return new morley(3, 6, 720);
                yield return new morley(3, 7, 620);
                yield return new morley(3, 8, 860);
                yield return new morley(3, 9, 970);
                yield return new morley(3, 10, 950);
                yield return new morley(3, 11, 880);
                yield return new morley(3, 12, 910);
                yield return new morley(3, 13, 850);
                yield return new morley(3, 14, 870);
                yield return new morley(3, 15, 840);
                yield return new morley(3, 16, 840);
                yield return new morley(3, 17, 850);
                yield return new morley(3, 18, 840);
                yield return new morley(3, 19, 840);
                yield return new morley(3, 20, 840);
                yield return new morley(4, 1, 890);
                yield return new morley(4, 2, 810);
                yield return new morley(4, 3, 810);
                yield return new morley(4, 4, 820);
                yield return new morley(4, 5, 800);
                yield return new morley(4, 6, 770);
                yield return new morley(4, 7, 760);
                yield return new morley(4, 8, 740);
                yield return new morley(4, 9, 750);
                yield return new morley(4, 10, 760);
                yield return new morley(4, 11, 910);
                yield return new morley(4, 12, 920);
                yield return new morley(4, 13, 890);
                yield return new morley(4, 14, 860);
                yield return new morley(4, 15, 880);
                yield return new morley(4, 16, 720);
                yield return new morley(4, 17, 840);
                yield return new morley(4, 18, 850);
                yield return new morley(4, 19, 850);
                yield return new morley(4, 20, 780);
                yield return new morley(5, 1, 890);
                yield return new morley(5, 2, 840);
                yield return new morley(5, 3, 780);
                yield return new morley(5, 4, 810);
                yield return new morley(5, 5, 760);
                yield return new morley(5, 6, 810);
                yield return new morley(5, 7, 790);
                yield return new morley(5, 8, 810);
                yield return new morley(5, 9, 820);
                yield return new morley(5, 10, 850);
                yield return new morley(5, 11, 870);
                yield return new morley(5, 12, 870);
                yield return new morley(5, 13, 810);
                yield return new morley(5, 14, 740);
                yield return new morley(5, 15, 810);
                yield return new morley(5, 16, 940);
                yield return new morley(5, 17, 950);
                yield return new morley(5, 18, 800);
                yield return new morley(5, 19, 810);
                yield return new morley(5, 20, 870);
            }
        }
    }
}
