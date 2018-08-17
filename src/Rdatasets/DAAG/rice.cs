// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Genetically Modified and Wild Type Rice Data
    /// </summary>

    public class rice
    {
        public readonly int PlantNo;
        public readonly int Block;
        public readonly int RootDryMass;
        public readonly int ShootDryMass;
        public readonly string trt;
        public readonly string fert;
        public readonly string variety;

        public rice(int PlantNo, int Block, int RootDryMass, int ShootDryMass, string trt, string fert, string variety)
        {
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
                yield return new rice(1, 1, 56, 132, "F10", "F10", "wt");
                yield return new rice(2, 1, 66, 120, "F10", "F10", "wt");
                yield return new rice(3, 1, 40, 108, "F10", "F10", "wt");
                yield return new rice(4, 1, 43, 134, "F10", "F10", "wt");
                yield return new rice(5, 1, 55, 119, "F10", "F10", "wt");
                yield return new rice(6, 1, 66, 125, "F10", "F10", "wt");
                yield return new rice(7, 2, 41, 98, "F10", "F10", "wt");
                yield return new rice(8, 2, 67, 122, "F10", "F10", "wt");
                yield return new rice(9, 2, 40, 114, "F10", "F10", "wt");
                yield return new rice(10, 2, 35, 82, "F10", "F10", "wt");
                yield return new rice(11, 2, 44, 37, "F10", "F10", "wt");
                yield return new rice(12, 2, 41, 109, "F10", "F10", "wt");
                yield return new rice(1, 1, 12, 45, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(2, 1, 20, 60, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(3, 1, 21, 87, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(4, 1, 15, 57, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(5, 1, 5, 26, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(6, 1, 18, 78, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(7, 2, 18, 45, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(8, 2, 7, 40, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(9, 2, 9, 44, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(10, 2, 6, 32, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(11, 2, 13, 55, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(12, 2, 7, 34, "NH4Cl", "NH4Cl", "wt");
                yield return new rice(1, 1, 12, 71, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(2, 1, 18, 78, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(3, 1, 17, 87, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(4, 1, 23, 80, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(5, 1, 21, 92, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(6, 1, 23, 129, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(7, 2, 14, 48, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(8, 2, 14, 60, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(9, 2, 12, 46, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(10, 2, 23, 74, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(11, 2, 11, 51, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(12, 2, 20, 64, "NH4NO3", "NH4NO3", "wt");
                yield return new rice(1, 1, 6, 8, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(2, 1, 4, 6, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(3, 1, 4, 3, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(4, 1, 7, 1, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(5, 1, 5, 7, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(6, 1, 6, 5, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(7, 2, 6, 10, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(8, 2, 5, 17, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(9, 2, 7, 3, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(10, 2, 3, 5, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(11, 2, 12, 15, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(12, 2, 7, 8, "F10 +ANU843", "F10", "ANU843");
                yield return new rice(1, 1, 4, 22, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(2, 1, 10, 36, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(3, 1, 9, 54, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(4, 1, 10, 53, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(5, 1, 8, 42, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(6, 1, 9, 30, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(7, 2, 1, 35, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(8, 2, 12, 59, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(9, 2, 8, 38, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(10, 2, 17, 70, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(11, 2, 8, 59, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(12, 2, 14, 61, "NH4Cl +ANU843", "NH4Cl", "ANU843");
                yield return new rice(1, 1, 19, 75, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(2, 1, 18, 75, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(3, 1, 21, 96, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(4, 1, 7, 59, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(5, 1, 17, 96, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(6, 1, 18, 100, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(7, 2, 16, 75, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(8, 2, 11, 68, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(9, 2, 6, 35, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(10, 2, 11, 53, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(11, 2, 7, 47, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
                yield return new rice(12, 2, 15, 79, "NH4NO3 +ANU843", "NH4NO3", "ANU843");
            }
        }
    }
}
