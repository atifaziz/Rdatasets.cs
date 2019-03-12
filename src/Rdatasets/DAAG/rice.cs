// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Genetically Modified and Wild Type Rice Data
    /// </summary>

    public class rice
    {
        public readonly int κ;
        public readonly int PlantNo;
        public readonly int Block;
        public readonly int RootDryMass;
        public readonly int ShootDryMass;
        public readonly string trt;
        public readonly string fert;
        public readonly string variety;

        public rice(int κ, int PlantNo, int Block, int RootDryMass, int ShootDryMass, string trt, string fert, string variety)
        {
            this.κ = κ;
            this.PlantNo = PlantNo;
            this.Block = Block;
            this.RootDryMass = RootDryMass;
            this.ShootDryMass = ShootDryMass;
            this.trt = trt;
            this.fert = fert;
            this.variety = variety;
        }

        public static IEnumerable<rice> Data
        {
            get
            {
                yield return new rice(1, 1, 1, 56, 132, "F10", "F10", "wt");
                yield return new rice(2, 2, 1, 66, 120, "F10", "F10", "wt");
                yield return new rice(3, 3, 1, 40, 108, "F10", "F10", "wt");
                yield return new rice(4, 4, 1, 43, 134, "F10", "F10", "wt");
                yield return new rice(5, 5, 1, 55, 119, "F10", "F10", "wt");
                yield return new rice(6, 6, 1, 66, 125, "F10", "F10", "wt");
                yield return new rice(7, 7, 2, 41, 98, "F10", "F10", "wt");
                yield return new rice(8, 8, 2, 67, 122, "F10", "F10", "wt");
                yield return new rice(9, 9, 2, 40, 114, "F10", "F10", "wt");
                yield return new rice(10, 10, 2, 35, 82, "F10", "F10", "wt");
                yield return new rice(11, 11, 2, 44, 37, "F10", "F10", "wt");
                yield return new rice(12, 12, 2, 41, 109, "F10", "F10", "wt");
                yield return new rice(13, 1, 1, 12, 45, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(14, 2, 1, 20, 60, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(15, 3, 1, 21, 87, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(16, 4, 1, 15, 57, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(17, 5, 1, 5, 26, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(18, 6, 1, 18, 78, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(19, 7, 2, 18, 45, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(20, 8, 2, 7, 40, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(21, 9, 2, 9, 44, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(22, 10, 2, 6, 32, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(23, 11, 2, 13, 55, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(24, 12, 2, 7, 34, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(25, 1, 1, 12, 71, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(26, 2, 1, 18, 78, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(27, 3, 1, 17, 87, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(28, 4, 1, 23, 80, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(29, 5, 1, 21, 92, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(30, 6, 1, 23, 129, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(31, 7, 2, 14, 48, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(32, 8, 2, 14, 60, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(33, 9, 2, 12, 46, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(34, 10, 2, 23, 74, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(35, 11, 2, 11, 51, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(36, 12, 2, 20, 64, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(37, 1, 1, 6, 8, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(38, 2, 1, 4, 6, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(39, 3, 1, 4, 3, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(40, 4, 1, 7, 1, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(41, 5, 1, 5, 7, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(42, 6, 1, 6, 5, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(43, 7, 2, 6, 10, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(44, 8, 2, 5, 17, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(45, 9, 2, 7, 3, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(46, 10, 2, 3, 5, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(47, 11, 2, 12, 15, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(48, 12, 2, 7, 8, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(49, 1, 1, 4, 22, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(50, 2, 1, 10, 36, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(51, 3, 1, 9, 54, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(52, 4, 1, 10, 53, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(53, 5, 1, 8, 42, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(54, 6, 1, 9, 30, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(55, 7, 2, 1, 35, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(56, 8, 2, 12, 59, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(57, 9, 2, 8, 38, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(58, 10, 2, 17, 70, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(59, 11, 2, 8, 59, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(60, 12, 2, 14, 61, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(61, 1, 1, 19, 75, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(62, 2, 1, 18, 75, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(63, 3, 1, 21, 96, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(64, 4, 1, 7, 59, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(65, 5, 1, 17, 96, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(66, 6, 1, 18, 100, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(67, 7, 2, 16, 75, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(68, 8, 2, 11, 68, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(69, 9, 2, 6, 35, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(70, 10, 2, 11, 53, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(71, 11, 2, 7, 47, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(72, 12, 2, 15, 79, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
            }
        }
    }
}
