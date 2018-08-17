// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Brain and Body Weights for 28 Species
    /// </summary>

    public class Animals
    {
        public readonly double body;
        public readonly double brain;

        public Animals(double body, double brain)
        {
            this.body = body;
            this.brain = brain;
        }

        public static IEnumerable<Animals> Data
        {
            get
            {
                yield return new Animals(1.35, 8.1);
                yield return new Animals(465, 423);
                yield return new Animals(36.33, 119.5);
                yield return new Animals(27.66, 115);
                yield return new Animals(1.04, 5.5);
                yield return new Animals(11700, 50);
                yield return new Animals(2547, 4603);
                yield return new Animals(187.1, 419);
                yield return new Animals(521, 655);
                yield return new Animals(10, 115);
                yield return new Animals(3.3, 25.6);
                yield return new Animals(529, 680);
                yield return new Animals(207, 406);
                yield return new Animals(62, 1320);
                yield return new Animals(6654, 5712);
                yield return new Animals(9400, 70);
                yield return new Animals(6.8, 179);
                yield return new Animals(35, 56);
                yield return new Animals(0.12, 1);
                yield return new Animals(0.023, 0.4);
                yield return new Animals(2.5, 12.1);
                yield return new Animals(55.5, 175);
                yield return new Animals(100, 157);
                yield return new Animals(52.16, 440);
                yield return new Animals(0.28, 1.9);
                yield return new Animals(87000, 154.5);
                yield return new Animals(0.122, 3);
                yield return new Animals(192, 180);
            }
        }
    }
}
