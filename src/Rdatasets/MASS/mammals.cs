// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Brain and Body Weights for 62 Species of Land Mammals
    /// </summary>

    public class mammals
    {
        public readonly double body;
        public readonly double brain;

        public mammals(double body, double brain)
        {
            this.body = body;
            this.brain = brain;
        }

        public static IEnumerable<mammals> Data
        {
            get
            {
                yield return new mammals(3.385, 44.5);
                yield return new mammals(0.48, 15.5);
                yield return new mammals(1.35, 8.1);
                yield return new mammals(465, 423);
                yield return new mammals(36.33, 119.5);
                yield return new mammals(27.66, 115);
                yield return new mammals(14.83, 98.2);
                yield return new mammals(1.04, 5.5);
                yield return new mammals(4.19, 58);
                yield return new mammals(0.425, 6.4);
                yield return new mammals(0.101, 4);
                yield return new mammals(0.92, 5.7);
                yield return new mammals(1, 6.6);
                yield return new mammals(0.005, 0.14);
                yield return new mammals(0.06, 1);
                yield return new mammals(3.5, 10.8);
                yield return new mammals(2, 12.3);
                yield return new mammals(1.7, 6.3);
                yield return new mammals(2547, 4603);
                yield return new mammals(0.023, 0.3);
                yield return new mammals(187.1, 419);
                yield return new mammals(521, 655);
                yield return new mammals(0.785, 3.5);
                yield return new mammals(10, 115);
                yield return new mammals(3.3, 25.6);
                yield return new mammals(0.2, 5);
                yield return new mammals(1.41, 17.5);
                yield return new mammals(529, 680);
                yield return new mammals(207, 406);
                yield return new mammals(85, 325);
                yield return new mammals(0.75, 12.3);
                yield return new mammals(62, 1320);
                yield return new mammals(6654, 5712);
                yield return new mammals(3.5, 3.9);
                yield return new mammals(6.8, 179);
                yield return new mammals(35, 56);
                yield return new mammals(4.05, 17);
                yield return new mammals(0.12, 1);
                yield return new mammals(0.023, 0.4);
                yield return new mammals(0.01, 0.25);
                yield return new mammals(1.4, 12.5);
                yield return new mammals(250, 490);
                yield return new mammals(2.5, 12.1);
                yield return new mammals(55.5, 175);
                yield return new mammals(100, 157);
                yield return new mammals(52.16, 440);
                yield return new mammals(10.55, 179.5);
                yield return new mammals(0.55, 2.4);
                yield return new mammals(60, 81);
                yield return new mammals(3.6, 21);
                yield return new mammals(4.288, 39.2);
                yield return new mammals(0.28, 1.9);
                yield return new mammals(0.075, 1.2);
                yield return new mammals(0.122, 3);
                yield return new mammals(0.048, 0.33);
                yield return new mammals(192, 180);
                yield return new mammals(3, 25);
                yield return new mammals(160, 169);
                yield return new mammals(0.9, 2.6);
                yield return new mammals(1.62, 11.4);
                yield return new mammals(0.104, 2.5);
                yield return new mammals(4.235, 50.4);
            }
        }
    }
}
