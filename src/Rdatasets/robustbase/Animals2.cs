// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Brain and Body Weights for 65 Species of Land Animals
    /// </summary>

    public class Animals2
    {
        public readonly double body;
        public readonly double brain;

        public Animals2(double body, double brain)
        {
            this.body = body;
            this.brain = brain;
        }

        public static IEnumerable<Animals2> Data
        {
            get
            {
                yield return new Animals2(1.35, 8.1);
                yield return new Animals2(465, 423);
                yield return new Animals2(36.33, 119.5);
                yield return new Animals2(27.66, 115);
                yield return new Animals2(1.04, 5.5);
                yield return new Animals2(11700, 50);
                yield return new Animals2(2547, 4603);
                yield return new Animals2(187.1, 419);
                yield return new Animals2(521, 655);
                yield return new Animals2(10, 115);
                yield return new Animals2(3.3, 25.6);
                yield return new Animals2(529, 680);
                yield return new Animals2(207, 406);
                yield return new Animals2(62, 1320);
                yield return new Animals2(6654, 5712);
                yield return new Animals2(9400, 70);
                yield return new Animals2(6.8, 179);
                yield return new Animals2(35, 56);
                yield return new Animals2(0.12, 1);
                yield return new Animals2(0.023, 0.4);
                yield return new Animals2(2.5, 12.1);
                yield return new Animals2(55.5, 175);
                yield return new Animals2(100, 157);
                yield return new Animals2(52.16, 440);
                yield return new Animals2(0.28, 1.9);
                yield return new Animals2(87000, 154.5);
                yield return new Animals2(0.122, 3);
                yield return new Animals2(192, 180);
                yield return new Animals2(3.385, 44.5);
                yield return new Animals2(0.48, 15.5);
                yield return new Animals2(14.83, 98.2);
                yield return new Animals2(4.19, 58);
                yield return new Animals2(0.425, 6.4);
                yield return new Animals2(0.101, 4);
                yield return new Animals2(0.92, 5.7);
                yield return new Animals2(1, 6.6);
                yield return new Animals2(0.005, 0.14);
                yield return new Animals2(0.06, 1);
                yield return new Animals2(3.5, 10.8);
                yield return new Animals2(2, 12.3);
                yield return new Animals2(1.7, 6.3);
                yield return new Animals2(0.023, 0.3);
                yield return new Animals2(0.785, 3.5);
                yield return new Animals2(0.2, 5);
                yield return new Animals2(1.41, 17.5);
                yield return new Animals2(85, 325);
                yield return new Animals2(0.75, 12.3);
                yield return new Animals2(3.5, 3.9);
                yield return new Animals2(4.05, 17);
                yield return new Animals2(0.01, 0.25);
                yield return new Animals2(1.4, 12.5);
                yield return new Animals2(250, 490);
                yield return new Animals2(10.55, 179.5);
                yield return new Animals2(0.55, 2.4);
                yield return new Animals2(60, 81);
                yield return new Animals2(3.6, 21);
                yield return new Animals2(4.288, 39.2);
                yield return new Animals2(0.075, 1.2);
                yield return new Animals2(0.048, 0.33);
                yield return new Animals2(3, 25);
                yield return new Animals2(160, 169);
                yield return new Animals2(0.9, 2.6);
                yield return new Animals2(1.62, 11.4);
                yield return new Animals2(0.104, 2.5);
                yield return new Animals2(4.235, 50.4);
            }
        }
    }
}
