// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson's Speed of Light Data
    /// </summary>

    public class michelson
    {
        public readonly int Speed;
        public readonly int Run;
        public readonly int Expt;

        public michelson(int Speed, int Run, int Expt)
        {
            this.Speed = Speed;
            this.Run = Run;
            this.Expt = Expt;
        }

        public static IEnumerable<michelson> Data
        {
            get
            {
                yield return new michelson(850, 1, 1);
                yield return new michelson(740, 2, 1);
                yield return new michelson(900, 3, 1);
                yield return new michelson(1070, 4, 1);
                yield return new michelson(930, 5, 1);
                yield return new michelson(850, 6, 1);
                yield return new michelson(950, 7, 1);
                yield return new michelson(980, 8, 1);
                yield return new michelson(980, 9, 1);
                yield return new michelson(880, 10, 1);
                yield return new michelson(1000, 11, 1);
                yield return new michelson(980, 12, 1);
                yield return new michelson(930, 13, 1);
                yield return new michelson(650, 14, 1);
                yield return new michelson(760, 15, 1);
                yield return new michelson(810, 16, 1);
                yield return new michelson(1000, 17, 1);
                yield return new michelson(1000, 18, 1);
                yield return new michelson(960, 19, 1);
                yield return new michelson(960, 20, 1);
                yield return new michelson(960, 1, 2);
                yield return new michelson(940, 2, 2);
                yield return new michelson(960, 3, 2);
                yield return new michelson(940, 4, 2);
                yield return new michelson(880, 5, 2);
                yield return new michelson(800, 6, 2);
                yield return new michelson(850, 7, 2);
                yield return new michelson(880, 8, 2);
                yield return new michelson(900, 9, 2);
                yield return new michelson(840, 10, 2);
                yield return new michelson(830, 11, 2);
                yield return new michelson(790, 12, 2);
                yield return new michelson(810, 13, 2);
                yield return new michelson(880, 14, 2);
                yield return new michelson(880, 15, 2);
                yield return new michelson(830, 16, 2);
                yield return new michelson(800, 17, 2);
                yield return new michelson(790, 18, 2);
                yield return new michelson(760, 19, 2);
                yield return new michelson(800, 20, 2);
                yield return new michelson(880, 1, 3);
                yield return new michelson(880, 2, 3);
                yield return new michelson(880, 3, 3);
                yield return new michelson(860, 4, 3);
                yield return new michelson(720, 5, 3);
                yield return new michelson(720, 6, 3);
                yield return new michelson(620, 7, 3);
                yield return new michelson(860, 8, 3);
                yield return new michelson(970, 9, 3);
                yield return new michelson(950, 10, 3);
                yield return new michelson(880, 11, 3);
                yield return new michelson(910, 12, 3);
                yield return new michelson(850, 13, 3);
                yield return new michelson(870, 14, 3);
                yield return new michelson(840, 15, 3);
                yield return new michelson(840, 16, 3);
                yield return new michelson(850, 17, 3);
                yield return new michelson(840, 18, 3);
                yield return new michelson(840, 19, 3);
                yield return new michelson(840, 20, 3);
                yield return new michelson(890, 1, 4);
                yield return new michelson(810, 2, 4);
                yield return new michelson(810, 3, 4);
                yield return new michelson(820, 4, 4);
                yield return new michelson(800, 5, 4);
                yield return new michelson(770, 6, 4);
                yield return new michelson(760, 7, 4);
                yield return new michelson(740, 8, 4);
                yield return new michelson(750, 9, 4);
                yield return new michelson(760, 10, 4);
                yield return new michelson(910, 11, 4);
                yield return new michelson(920, 12, 4);
                yield return new michelson(890, 13, 4);
                yield return new michelson(860, 14, 4);
                yield return new michelson(880, 15, 4);
                yield return new michelson(720, 16, 4);
                yield return new michelson(840, 17, 4);
                yield return new michelson(850, 18, 4);
                yield return new michelson(850, 19, 4);
                yield return new michelson(780, 20, 4);
                yield return new michelson(890, 1, 5);
                yield return new michelson(840, 2, 5);
                yield return new michelson(780, 3, 5);
                yield return new michelson(810, 4, 5);
                yield return new michelson(760, 5, 5);
                yield return new michelson(810, 6, 5);
                yield return new michelson(790, 7, 5);
                yield return new michelson(810, 8, 5);
                yield return new michelson(820, 9, 5);
                yield return new michelson(850, 10, 5);
                yield return new michelson(870, 11, 5);
                yield return new michelson(870, 12, 5);
                yield return new michelson(810, 13, 5);
                yield return new michelson(740, 14, 5);
                yield return new michelson(810, 15, 5);
                yield return new michelson(940, 16, 5);
                yield return new michelson(950, 17, 5);
                yield return new michelson(800, 18, 5);
                yield return new michelson(810, 19, 5);
                yield return new michelson(870, 20, 5);
            }
        }
    }
}
