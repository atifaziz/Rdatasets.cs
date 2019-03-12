// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson Speed of Light Data
    /// </summary>

    public class morley
    {
        public readonly int κ;
        public readonly int Expt;
        public readonly int Run;
        public readonly int Speed;

        public morley(int κ, int Expt, int Run, int Speed)
        {
            this.κ = κ;
            this.Expt = Expt;
            this.Run = Run;
            this.Speed = Speed;
        }

        public static IEnumerable<morley> Data
        {
            get
            {
                yield return new morley(001, 1, 1, 850);
                yield return new morley(002, 1, 2, 740);
                yield return new morley(003, 1, 3, 900);
                yield return new morley(004, 1, 4, 1070);
                yield return new morley(005, 1, 5, 930);
                yield return new morley(006, 1, 6, 850);
                yield return new morley(007, 1, 7, 950);
                yield return new morley(008, 1, 8, 980);
                yield return new morley(009, 1, 9, 980);
                yield return new morley(010, 1, 10, 880);
                yield return new morley(011, 1, 11, 1000);
                yield return new morley(012, 1, 12, 980);
                yield return new morley(013, 1, 13, 930);
                yield return new morley(014, 1, 14, 650);
                yield return new morley(015, 1, 15, 760);
                yield return new morley(016, 1, 16, 810);
                yield return new morley(017, 1, 17, 1000);
                yield return new morley(018, 1, 18, 1000);
                yield return new morley(019, 1, 19, 960);
                yield return new morley(020, 1, 20, 960);
                yield return new morley(021, 2, 1, 960);
                yield return new morley(022, 2, 2, 940);
                yield return new morley(023, 2, 3, 960);
                yield return new morley(024, 2, 4, 940);
                yield return new morley(025, 2, 5, 880);
                yield return new morley(026, 2, 6, 800);
                yield return new morley(027, 2, 7, 850);
                yield return new morley(028, 2, 8, 880);
                yield return new morley(029, 2, 9, 900);
                yield return new morley(030, 2, 10, 840);
                yield return new morley(031, 2, 11, 830);
                yield return new morley(032, 2, 12, 790);
                yield return new morley(033, 2, 13, 810);
                yield return new morley(034, 2, 14, 880);
                yield return new morley(035, 2, 15, 880);
                yield return new morley(036, 2, 16, 830);
                yield return new morley(037, 2, 17, 800);
                yield return new morley(038, 2, 18, 790);
                yield return new morley(039, 2, 19, 760);
                yield return new morley(040, 2, 20, 800);
                yield return new morley(041, 3, 1, 880);
                yield return new morley(042, 3, 2, 880);
                yield return new morley(043, 3, 3, 880);
                yield return new morley(044, 3, 4, 860);
                yield return new morley(045, 3, 5, 720);
                yield return new morley(046, 3, 6, 720);
                yield return new morley(047, 3, 7, 620);
                yield return new morley(048, 3, 8, 860);
                yield return new morley(049, 3, 9, 970);
                yield return new morley(050, 3, 10, 950);
                yield return new morley(051, 3, 11, 880);
                yield return new morley(052, 3, 12, 910);
                yield return new morley(053, 3, 13, 850);
                yield return new morley(054, 3, 14, 870);
                yield return new morley(055, 3, 15, 840);
                yield return new morley(056, 3, 16, 840);
                yield return new morley(057, 3, 17, 850);
                yield return new morley(058, 3, 18, 840);
                yield return new morley(059, 3, 19, 840);
                yield return new morley(060, 3, 20, 840);
                yield return new morley(061, 4, 1, 890);
                yield return new morley(062, 4, 2, 810);
                yield return new morley(063, 4, 3, 810);
                yield return new morley(064, 4, 4, 820);
                yield return new morley(065, 4, 5, 800);
                yield return new morley(066, 4, 6, 770);
                yield return new morley(067, 4, 7, 760);
                yield return new morley(068, 4, 8, 740);
                yield return new morley(069, 4, 9, 750);
                yield return new morley(070, 4, 10, 760);
                yield return new morley(071, 4, 11, 910);
                yield return new morley(072, 4, 12, 920);
                yield return new morley(073, 4, 13, 890);
                yield return new morley(074, 4, 14, 860);
                yield return new morley(075, 4, 15, 880);
                yield return new morley(076, 4, 16, 720);
                yield return new morley(077, 4, 17, 840);
                yield return new morley(078, 4, 18, 850);
                yield return new morley(079, 4, 19, 850);
                yield return new morley(080, 4, 20, 780);
                yield return new morley(081, 5, 1, 890);
                yield return new morley(082, 5, 2, 840);
                yield return new morley(083, 5, 3, 780);
                yield return new morley(084, 5, 4, 810);
                yield return new morley(085, 5, 5, 760);
                yield return new morley(086, 5, 6, 810);
                yield return new morley(087, 5, 7, 790);
                yield return new morley(088, 5, 8, 810);
                yield return new morley(089, 5, 9, 820);
                yield return new morley(090, 5, 10, 850);
                yield return new morley(091, 5, 11, 870);
                yield return new morley(092, 5, 12, 870);
                yield return new morley(093, 5, 13, 810);
                yield return new morley(094, 5, 14, 740);
                yield return new morley(095, 5, 15, 810);
                yield return new morley(096, 5, 16, 940);
                yield return new morley(097, 5, 17, 950);
                yield return new morley(098, 5, 18, 800);
                yield return new morley(099, 5, 19, 810);
                yield return new morley(100, 5, 20, 870);
            }
        }
    }
}
