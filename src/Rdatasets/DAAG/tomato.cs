// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Root weights of tomato plants exposed to 4 different treatments
    /// </summary>

    public class tomato
    {
        public readonly int κ;
        public readonly double weight;
        public readonly string trt;

        public tomato(int κ, double weight, string trt)
        {
            this.κ = κ;
            this.weight = weight;
            this.trt = trt;
        }

        public static IEnumerable<tomato> Data
        {
            get
            {
                yield return new tomato(1, 1.5, "water only");
                yield return new tomato(2, 1.9, "water only");
                yield return new tomato(3, 1.3, "water only");
                yield return new tomato(4, 1.5, "water only");
                yield return new tomato(5, 2.4, "water only");
                yield return new tomato(6, 1.5, "water only");
                yield return new tomato(7, 1.5, "conc nutrient");
                yield return new tomato(8, 1.2, "conc nutrient");
                yield return new tomato(9, 1.2, "conc nutrient");
                yield return new tomato(10, 2.1, "conc nutrient");
                yield return new tomato(11, 2.9, "conc nutrient");
                yield return new tomato(12, 1.6, "conc nutrient");
                yield return new tomato(13, 1.9, "2-4-D + conc nutrient");
                yield return new tomato(14, 1.6, "2-4-D + conc nutrient");
                yield return new tomato(15, 0.8, "2-4-D + conc nutrient");
                yield return new tomato(16, 1.15, "2-4-D + conc nutrient");
                yield return new tomato(17, 0.9, "2-4-D + conc nutrient");
                yield return new tomato(18, 1.6, "2-4-D + conc nutrient");
                yield return new tomato(19, 1, "3x conc nutrient");
                yield return new tomato(20, 1.2, "3x conc nutrient");
                yield return new tomato(21, 1.3, "3x conc nutrient");
                yield return new tomato(22, 0.9, "3x conc nutrient");
                yield return new tomato(23, 0.7, "3x conc nutrient");
                yield return new tomato(24, 0.8, "3x conc nutrient");
            }
        }
    }
}
