// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Blood Pressure in Rabbits
    /// </summary>

    public class Rabbit
    {
        public readonly double BPchange;
        public readonly double Dose;
        public readonly string Run;
        public readonly string Treatment;
        public readonly string Animal;

        public Rabbit(double BPchange, double Dose, string Run, string Treatment, string Animal)
        {
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
                yield return new Rabbit(0.5, 6.25, "C1", "Control", "R1");
                yield return new Rabbit(4.5, 12.5, "C1", "Control", "R1");
                yield return new Rabbit(10, 25, "C1", "Control", "R1");
                yield return new Rabbit(26, 50, "C1", "Control", "R1");
                yield return new Rabbit(37, 100, "C1", "Control", "R1");
                yield return new Rabbit(32, 200, "C1", "Control", "R1");
                yield return new Rabbit(1, 6.25, "C2", "Control", "R2");
                yield return new Rabbit(1.25, 12.5, "C2", "Control", "R2");
                yield return new Rabbit(4, 25, "C2", "Control", "R2");
                yield return new Rabbit(12, 50, "C2", "Control", "R2");
                yield return new Rabbit(27, 100, "C2", "Control", "R2");
                yield return new Rabbit(29, 200, "C2", "Control", "R2");
                yield return new Rabbit(0.75, 6.25, "C3", "Control", "R3");
                yield return new Rabbit(3, 12.5, "C3", "Control", "R3");
                yield return new Rabbit(3, 25, "C3", "Control", "R3");
                yield return new Rabbit(14, 50, "C3", "Control", "R3");
                yield return new Rabbit(22, 100, "C3", "Control", "R3");
                yield return new Rabbit(24, 200, "C3", "Control", "R3");
                yield return new Rabbit(1.25, 6.25, "C4", "Control", "R4");
                yield return new Rabbit(1.5, 12.5, "C4", "Control", "R4");
                yield return new Rabbit(6, 25, "C4", "Control", "R4");
                yield return new Rabbit(19, 50, "C4", "Control", "R4");
                yield return new Rabbit(33, 100, "C4", "Control", "R4");
                yield return new Rabbit(33, 200, "C4", "Control", "R4");
                yield return new Rabbit(1.5, 6.25, "C5", "Control", "R5");
                yield return new Rabbit(1.5, 12.5, "C5", "Control", "R5");
                yield return new Rabbit(5, 25, "C5", "Control", "R5");
                yield return new Rabbit(16, 50, "C5", "Control", "R5");
                yield return new Rabbit(20, 100, "C5", "Control", "R5");
                yield return new Rabbit(18, 200, "C5", "Control", "R5");
                yield return new Rabbit(1.25, 6.25, "M1", "MDL", "R1");
                yield return new Rabbit(0.75, 12.5, "M1", "MDL", "R1");
                yield return new Rabbit(4, 25, "M1", "MDL", "R1");
                yield return new Rabbit(9, 50, "M1", "MDL", "R1");
                yield return new Rabbit(25, 100, "M1", "MDL", "R1");
                yield return new Rabbit(37, 200, "M1", "MDL", "R1");
                yield return new Rabbit(1.4, 6.25, "M2", "MDL", "R2");
                yield return new Rabbit(1.7, 12.5, "M2", "MDL", "R2");
                yield return new Rabbit(1, 25, "M2", "MDL", "R2");
                yield return new Rabbit(2, 50, "M2", "MDL", "R2");
                yield return new Rabbit(15, 100, "M2", "MDL", "R2");
                yield return new Rabbit(28, 200, "M2", "MDL", "R2");
                yield return new Rabbit(0.75, 6.25, "M3", "MDL", "R3");
                yield return new Rabbit(2.3, 12.5, "M3", "MDL", "R3");
                yield return new Rabbit(3, 25, "M3", "MDL", "R3");
                yield return new Rabbit(5, 50, "M3", "MDL", "R3");
                yield return new Rabbit(26, 100, "M3", "MDL", "R3");
                yield return new Rabbit(25, 200, "M3", "MDL", "R3");
                yield return new Rabbit(2.6, 6.25, "M4", "MDL", "R4");
                yield return new Rabbit(1.2, 12.5, "M4", "MDL", "R4");
                yield return new Rabbit(2, 25, "M4", "MDL", "R4");
                yield return new Rabbit(3, 50, "M4", "MDL", "R4");
                yield return new Rabbit(11, 100, "M4", "MDL", "R4");
                yield return new Rabbit(22, 200, "M4", "MDL", "R4");
                yield return new Rabbit(2.4, 6.25, "M5", "MDL", "R5");
                yield return new Rabbit(2.5, 12.5, "M5", "MDL", "R5");
                yield return new Rabbit(1.5, 25, "M5", "MDL", "R5");
                yield return new Rabbit(2, 50, "M5", "MDL", "R5");
                yield return new Rabbit(9, 100, "M5", "MDL", "R5");
                yield return new Rabbit(19, 200, "M5", "MDL", "R5");
            }
        }
    }
}
