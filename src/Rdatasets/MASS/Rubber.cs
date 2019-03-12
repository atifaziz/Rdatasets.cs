// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Accelerated Testing of Tyre Rubber
    /// </summary>

    public class Rubber
    {
        public readonly int κ;
        public readonly int loss;
        public readonly int hard;
        public readonly int tens;

        public Rubber(int κ, int loss, int hard, int tens)
        {
            this.κ = κ;
            this.loss = loss;
            this.hard = hard;
            this.tens = tens;
        }

        public static IEnumerable<Rubber> Data
        {
            get
            {
                yield return new Rubber(1, 372, 45, 162);
                yield return new Rubber(2, 206, 55, 233);
                yield return new Rubber(3, 175, 61, 232);
                yield return new Rubber(4, 154, 66, 231);
                yield return new Rubber(5, 136, 71, 231);
                yield return new Rubber(6, 112, 71, 237);
                yield return new Rubber(7, 55, 81, 224);
                yield return new Rubber(8, 45, 86, 219);
                yield return new Rubber(9, 221, 53, 203);
                yield return new Rubber(10, 166, 60, 189);
                yield return new Rubber(11, 164, 64, 210);
                yield return new Rubber(12, 113, 68, 210);
                yield return new Rubber(13, 82, 79, 196);
                yield return new Rubber(14, 32, 81, 180);
                yield return new Rubber(15, 228, 56, 200);
                yield return new Rubber(16, 196, 68, 173);
                yield return new Rubber(17, 128, 75, 188);
                yield return new Rubber(18, 97, 83, 161);
                yield return new Rubber(19, 64, 88, 119);
                yield return new Rubber(20, 249, 59, 161);
                yield return new Rubber(21, 219, 71, 151);
                yield return new Rubber(22, 186, 80, 165);
                yield return new Rubber(23, 155, 82, 151);
                yield return new Rubber(24, 114, 89, 128);
                yield return new Rubber(25, 341, 51, 161);
                yield return new Rubber(26, 340, 59, 146);
                yield return new Rubber(27, 283, 65, 148);
                yield return new Rubber(28, 267, 74, 144);
                yield return new Rubber(29, 215, 81, 134);
                yield return new Rubber(30, 148, 86, 127);
            }
        }
    }
}
