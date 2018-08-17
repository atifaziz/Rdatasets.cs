// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Root weights of tomato plants exposed to 4 different treatments
    /// </summary>

    public class tomato
    {
        public readonly double weight;
        public readonly string trt;

        public tomato(double weight, string trt)
        {
            this.weight = weight;
            this.trt = trt;
        }

        public static IEnumerable<tomato> Data
        {
            get
            {
                yield return new tomato(1.5, "water only");
                yield return new tomato(1.9, "water only");
                yield return new tomato(1.3, "water only");
                yield return new tomato(1.5, "water only");
                yield return new tomato(2.4, "water only");
                yield return new tomato(1.5, "water only");
                yield return new tomato(1.5, "conc nutrient");
                yield return new tomato(1.2, "conc nutrient");
                yield return new tomato(1.2, "conc nutrient");
                yield return new tomato(2.1, "conc nutrient");
                yield return new tomato(2.9, "conc nutrient");
                yield return new tomato(1.6, "conc nutrient");
                yield return new tomato(1.9, "2-4-D + conc nutrient");
                yield return new tomato(1.6, "2-4-D + conc nutrient");
                yield return new tomato(0.8, "2-4-D + conc nutrient");
                yield return new tomato(1.15, "2-4-D + conc nutrient");
                yield return new tomato(0.9, "2-4-D + conc nutrient");
                yield return new tomato(1.6, "2-4-D + conc nutrient");
                yield return new tomato(1, "3x conc nutrient");
                yield return new tomato(1.2, "3x conc nutrient");
                yield return new tomato(1.3, "3x conc nutrient");
                yield return new tomato(0.9, "3x conc nutrient");
                yield return new tomato(0.7, "3x conc nutrient");
                yield return new tomato(0.8, "3x conc nutrient");
            }
        }
    }
}
