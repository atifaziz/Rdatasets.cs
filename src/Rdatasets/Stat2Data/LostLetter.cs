// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LostLetter
    /// </summary>

    public class LostLetter
    {
        public readonly int κ;
        public readonly string Location;
        public readonly string Address;
        public readonly int Returned;
        public readonly int DesMoines;
        public readonly int GrinnellTown;
        public readonly int GrinellCampus;
        public readonly int Peaceworks;
        public readonly int Confederacy;

        public LostLetter(int κ, string Location, string Address, int Returned, int DesMoines, int GrinnellTown, int GrinellCampus, int Peaceworks, int Confederacy)
        {
            this.κ = κ;
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
                yield return new LostLetter(1, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(2, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(3, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(4, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(5, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(6, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(7, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(8, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(9, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(10, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(11, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(12, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(13, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(14, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(15, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(16, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(17, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(18, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(19, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(20, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(21, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(22, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(23, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(24, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(25, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(26, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(27, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(28, "DesMoines", "Peaceworks", 1, 1, 0, 0, 1, 0);
                yield return new LostLetter(29, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(30, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(31, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(32, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(33, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(34, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(35, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(36, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(37, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(38, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(39, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(40, "DesMoines", "Peaceworks", 0, 1, 0, 0, 1, 0);
                yield return new LostLetter(41, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(42, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(43, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(44, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(45, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(46, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(47, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(48, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(49, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(50, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(51, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(52, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(53, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(54, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(55, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(56, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(57, "DesMoines", "Confederacy", 1, 1, 0, 0, 0, 1);
                yield return new LostLetter(58, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(59, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(60, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(61, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(62, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(63, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(64, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(65, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(66, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(67, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(68, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(69, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(70, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(71, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(72, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(73, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(74, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(75, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(76, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(77, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(78, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(79, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(80, "DesMoines", "Confederacy", 0, 1, 0, 0, 0, 1);
                yield return new LostLetter(81, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(82, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(83, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(84, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(85, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(86, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(87, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(88, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(89, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(90, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(91, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(92, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(93, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(94, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(95, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(96, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(97, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(98, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(99, "GrinnellTown", "Peaceworks", 1, 0, 1, 0, 1, 0);
                yield return new LostLetter(100, "GrinnellTown", "Peaceworks", 0, 0, 1, 0, 1, 0);
                yield return new LostLetter(101, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(102, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(103, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(104, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(105, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(106, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(107, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(108, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(109, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(110, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(111, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(112, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(113, "GrinnellTown", "Confederacy", 1, 0, 1, 0, 0, 1);
                yield return new LostLetter(114, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(115, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(116, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(117, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(118, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(119, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(120, "GrinnellTown", "Confederacy", 0, 0, 1, 0, 0, 1);
                yield return new LostLetter(121, "GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter(122, "GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter(123, "GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter(124, "GrinnellCampus", "Peaceworks", 1, 0, 0, 1, 1, 0);
                yield return new LostLetter(125, "GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter(126, "GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter(127, "GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter(128, "GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter(129, "GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter(130, "GrinnellCampus", "Peaceworks", 0, 0, 0, 1, 1, 0);
                yield return new LostLetter(131, "GrinnellCampus", "Confederacy", 1, 0, 0, 1, 0, 1);
                yield return new LostLetter(132, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(133, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(134, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(135, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(136, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(137, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(138, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(139, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
                yield return new LostLetter(140, "GrinnellCampus", "Confederacy", 0, 0, 0, 1, 0, 1);
            }
        }
    }
}
