// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Blood Pressure in Rabbits
    /// </summary>

    public class Rabbit
    {
        public readonly int κ;
        public readonly double BPchange;
        public readonly double Dose;
        public readonly string Run;
        public readonly string Treatment;
        public readonly string Animal;

        public Rabbit(int κ, double BPchange, double Dose, string Run, string Treatment, string Animal)
        {
            this.κ = κ;
            this.BPchange = BPchange;
            this.Dose = Dose;
            this.Run = Run;
            this.Treatment = Treatment;
            this.Animal = Animal;
        }

        public static IEnumerable<Rabbit> Data
        {
            get
            {
                yield return new Rabbit(1, 0.5, 6.25, "C1", "Control", "R1");
                yield return new Rabbit(2, 4.5, 12.5, "C1", "Control", "R1");
                yield return new Rabbit(3, 10, 25, "C1", "Control", "R1");
                yield return new Rabbit(4, 26, 50, "C1", "Control", "R1");
                yield return new Rabbit(5, 37, 100, "C1", "Control", "R1");
                yield return new Rabbit(6, 32, 200, "C1", "Control", "R1");
                yield return new Rabbit(7, 1, 6.25, "C2", "Control", "R2");
                yield return new Rabbit(8, 1.25, 12.5, "C2", "Control", "R2");
                yield return new Rabbit(9, 4, 25, "C2", "Control", "R2");
                yield return new Rabbit(10, 12, 50, "C2", "Control", "R2");
                yield return new Rabbit(11, 27, 100, "C2", "Control", "R2");
                yield return new Rabbit(12, 29, 200, "C2", "Control", "R2");
                yield return new Rabbit(13, 0.75, 6.25, "C3", "Control", "R3");
                yield return new Rabbit(14, 3, 12.5, "C3", "Control", "R3");
                yield return new Rabbit(15, 3, 25, "C3", "Control", "R3");
                yield return new Rabbit(16, 14, 50, "C3", "Control", "R3");
                yield return new Rabbit(17, 22, 100, "C3", "Control", "R3");
                yield return new Rabbit(18, 24, 200, "C3", "Control", "R3");
                yield return new Rabbit(19, 1.25, 6.25, "C4", "Control", "R4");
                yield return new Rabbit(20, 1.5, 12.5, "C4", "Control", "R4");
                yield return new Rabbit(21, 6, 25, "C4", "Control", "R4");
                yield return new Rabbit(22, 19, 50, "C4", "Control", "R4");
                yield return new Rabbit(23, 33, 100, "C4", "Control", "R4");
                yield return new Rabbit(24, 33, 200, "C4", "Control", "R4");
                yield return new Rabbit(25, 1.5, 6.25, "C5", "Control", "R5");
                yield return new Rabbit(26, 1.5, 12.5, "C5", "Control", "R5");
                yield return new Rabbit(27, 5, 25, "C5", "Control", "R5");
                yield return new Rabbit(28, 16, 50, "C5", "Control", "R5");
                yield return new Rabbit(29, 20, 100, "C5", "Control", "R5");
                yield return new Rabbit(30, 18, 200, "C5", "Control", "R5");
                yield return new Rabbit(31, 1.25, 6.25, "M1", "MDL", "R1");
                yield return new Rabbit(32, 0.75, 12.5, "M1", "MDL", "R1");
                yield return new Rabbit(33, 4, 25, "M1", "MDL", "R1");
                yield return new Rabbit(34, 9, 50, "M1", "MDL", "R1");
                yield return new Rabbit(35, 25, 100, "M1", "MDL", "R1");
                yield return new Rabbit(36, 37, 200, "M1", "MDL", "R1");
                yield return new Rabbit(37, 1.4, 6.25, "M2", "MDL", "R2");
                yield return new Rabbit(38, 1.7, 12.5, "M2", "MDL", "R2");
                yield return new Rabbit(39, 1, 25, "M2", "MDL", "R2");
                yield return new Rabbit(40, 2, 50, "M2", "MDL", "R2");
                yield return new Rabbit(41, 15, 100, "M2", "MDL", "R2");
                yield return new Rabbit(42, 28, 200, "M2", "MDL", "R2");
                yield return new Rabbit(43, 0.75, 6.25, "M3", "MDL", "R3");
                yield return new Rabbit(44, 2.3, 12.5, "M3", "MDL", "R3");
                yield return new Rabbit(45, 3, 25, "M3", "MDL", "R3");
                yield return new Rabbit(46, 5, 50, "M3", "MDL", "R3");
                yield return new Rabbit(47, 26, 100, "M3", "MDL", "R3");
                yield return new Rabbit(48, 25, 200, "M3", "MDL", "R3");
                yield return new Rabbit(49, 2.6, 6.25, "M4", "MDL", "R4");
                yield return new Rabbit(50, 1.2, 12.5, "M4", "MDL", "R4");
                yield return new Rabbit(51, 2, 25, "M4", "MDL", "R4");
                yield return new Rabbit(52, 3, 50, "M4", "MDL", "R4");
                yield return new Rabbit(53, 11, 100, "M4", "MDL", "R4");
                yield return new Rabbit(54, 22, 200, "M4", "MDL", "R4");
                yield return new Rabbit(55, 2.4, 6.25, "M5", "MDL", "R5");
                yield return new Rabbit(56, 2.5, 12.5, "M5", "MDL", "R5");
                yield return new Rabbit(57, 1.5, 25, "M5", "MDL", "R5");
                yield return new Rabbit(58, 2, 50, "M5", "MDL", "R5");
                yield return new Rabbit(59, 9, 100, "M5", "MDL", "R5");
                yield return new Rabbit(60, 19, 200, "M5", "MDL", "R5");
            }
        }
    }
}
