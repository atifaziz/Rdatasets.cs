// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LostLetter
    /// </summary>

    public class LostLetter
    {
        public readonly string Location;
        public readonly string Address;
        public readonly int Returned;
        public readonly int DesMoines;
        public readonly int GrinnellTown;
        public readonly int GrinellCampus;
        public readonly int Peaceworks;
        public readonly int Confederacy;

        public LostLetter(string Location, string Address, int Returned, int DesMoines, int GrinnellTown, int GrinellCampus, int Peaceworks, int Confederacy)
        {
            this.Location = Location;
            this.Address = Address;
            this.Returned = Returned;
            this.DesMoines = DesMoines;
            this.GrinnellTown = GrinnellTown;
            this.GrinellCampus = GrinellCampus;
            this.Peaceworks = Peaceworks;
            this.Confederacy = Confederacy;
        }

        public static IEnumerable<LostLetter> Data
        {
            get
            {
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Peaceworks", 0, 0, 1, 0, 1, 0);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 1, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter("GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
            }
        }
    }
}
