// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Accelerated Testing of Tyre Rubber
    /// </summary>

    public class Rubber
    {
        public readonly int loss;
        public readonly int hard;
        public readonly int tens;

        public Rubber(int loss, int hard, int tens)
        {
            this.loss = loss;
            this.hard = hard;
            this.tens = tens;
        }

        public static IEnumerable<Rubber> Data
        {
            get
            {
                yield return new Rubber(372, 45, 162);
                yield return new Rubber(206, 55, 233);
                yield return new Rubber(175, 61, 232);
                yield return new Rubber(154, 66, 231);
                yield return new Rubber(136, 71, 231);
                yield return new Rubber(112, 71, 237);
                yield return new Rubber(55, 81, 224);
                yield return new Rubber(45, 86, 219);
                yield return new Rubber(221, 53, 203);
                yield return new Rubber(166, 60, 189);
                yield return new Rubber(164, 64, 210);
                yield return new Rubber(113, 68, 210);
                yield return new Rubber(82, 79, 196);
                yield return new Rubber(32, 81, 180);
                yield return new Rubber(228, 56, 200);
                yield return new Rubber(196, 68, 173);
                yield return new Rubber(128, 75, 188);
                yield return new Rubber(97, 83, 161);
                yield return new Rubber(64, 88, 119);
                yield return new Rubber(249, 59, 161);
                yield return new Rubber(219, 71, 151);
                yield return new Rubber(186, 80, 165);
                yield return new Rubber(155, 82, 151);
                yield return new Rubber(114, 89, 128);
                yield return new Rubber(341, 51, 161);
                yield return new Rubber(340, 59, 146);
                yield return new Rubber(283, 65, 148);
                yield return new Rubber(267, 74, 144);
                yield return new Rubber(215, 81, 134);
                yield return new Rubber(148, 86, 127);
            }
        }
    }
}
