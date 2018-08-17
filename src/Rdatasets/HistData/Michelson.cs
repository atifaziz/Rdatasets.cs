// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson's Determinations of the Velocity of Light
    /// </summary>

    public class Michelson
    {
        public readonly int velocity;

        public Michelson(int velocity)
        {
            this.velocity = velocity;
        }

        public static IEnumerable<Michelson> Data
        {
            get
            {
                yield return new Michelson(850);
                yield return new Michelson(740);
                yield return new Michelson(900);
                yield return new Michelson(1070);
                yield return new Michelson(930);
                yield return new Michelson(850);
                yield return new Michelson(950);
                yield return new Michelson(980);
                yield return new Michelson(980);
                yield return new Michelson(880);
                yield return new Michelson(1000);
                yield return new Michelson(980);
                yield return new Michelson(930);
                yield return new Michelson(650);
                yield return new Michelson(760);
                yield return new Michelson(810);
                yield return new Michelson(1000);
                yield return new Michelson(1000);
                yield return new Michelson(960);
                yield return new Michelson(960);
                yield return new Michelson(960);
                yield return new Michelson(940);
                yield return new Michelson(960);
                yield return new Michelson(940);
                yield return new Michelson(880);
                yield return new Michelson(800);
                yield return new Michelson(850);
                yield return new Michelson(880);
                yield return new Michelson(900);
                yield return new Michelson(840);
                yield return new Michelson(830);
                yield return new Michelson(790);
                yield return new Michelson(810);
                yield return new Michelson(880);
                yield return new Michelson(880);
                yield return new Michelson(830);
                yield return new Michelson(800);
                yield return new Michelson(790);
                yield return new Michelson(760);
                yield return new Michelson(800);
                yield return new Michelson(880);
                yield return new Michelson(880);
                yield return new Michelson(880);
                yield return new Michelson(860);
                yield return new Michelson(720);
                yield return new Michelson(720);
                yield return new Michelson(620);
                yield return new Michelson(860);
                yield return new Michelson(970);
                yield return new Michelson(950);
                yield return new Michelson(880);
                yield return new Michelson(910);
                yield return new Michelson(850);
                yield return new Michelson(870);
                yield return new Michelson(840);
                yield return new Michelson(840);
                yield return new Michelson(850);
                yield return new Michelson(840);
                yield return new Michelson(840);
                yield return new Michelson(840);
                yield return new Michelson(890);
                yield return new Michelson(810);
                yield return new Michelson(810);
                yield return new Michelson(820);
                yield return new Michelson(800);
                yield return new Michelson(770);
                yield return new Michelson(760);
                yield return new Michelson(740);
                yield return new Michelson(750);
                yield return new Michelson(760);
                yield return new Michelson(910);
                yield return new Michelson(920);
                yield return new Michelson(890);
                yield return new Michelson(860);
                yield return new Michelson(880);
                yield return new Michelson(720);
                yield return new Michelson(840);
                yield return new Michelson(850);
                yield return new Michelson(850);
                yield return new Michelson(780);
                yield return new Michelson(890);
                yield return new Michelson(840);
                yield return new Michelson(780);
                yield return new Michelson(810);
                yield return new Michelson(760);
                yield return new Michelson(810);
                yield return new Michelson(790);
                yield return new Michelson(810);
                yield return new Michelson(820);
                yield return new Michelson(850);
                yield return new Michelson(870);
                yield return new Michelson(870);
                yield return new Michelson(810);
                yield return new Michelson(740);
                yield return new Michelson(810);
                yield return new Michelson(940);
                yield return new Michelson(950);
                yield return new Michelson(800);
                yield return new Michelson(810);
                yield return new Michelson(870);
            }
        }
    }
}
