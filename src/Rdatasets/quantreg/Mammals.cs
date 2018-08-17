// ReSharper disable All

namespace Rdatasets.quantreg
{
    using System.Collections.Generic;

    /// <summary>
    /// Garland(1983) Data on Running Speed of Mammals
    /// </summary>

    public class Mammals
    {
        public readonly double weight;
        public readonly double speed;
        public readonly bool hoppers;
        public readonly bool specials;

        public Mammals(double weight, double speed, bool hoppers, bool specials)
        {
            this.weight = weight;
            this.speed = speed;
            this.hoppers = hoppers;
            this.specials = specials;
        }

        public static IEnumerable<Mammals> Data
        {
            get
            {
                yield return new Mammals(6000, 35, false, false);
                yield return new Mammals(4000, 26, false, false);
                yield return new Mammals(3000, 25, false, false);
                yield return new Mammals(1400, 45, false, false);
                yield return new Mammals(400, 70, false, false);
                yield return new Mammals(350, 70, false, false);
                yield return new Mammals(300, 64, false, false);
                yield return new Mammals(260, 70, false, false);
                yield return new Mammals(250, 40, false, false);
                yield return new Mammals(3800, 25, false, true);
                yield return new Mammals(1000, 60, false, false);
                yield return new Mammals(900, 70, false, false);
                yield return new Mammals(900, 56, false, false);
                yield return new Mammals(800, 29, false, false);
                yield return new Mammals(750, 57, false, false);
                yield return new Mammals(500, 32, false, false);
                yield return new Mammals(450, 56, false, false);
                yield return new Mammals(300, 72, false, false);
                yield return new Mammals(300, 90, false, false);
                yield return new Mammals(250, 80, false, false);
                yield return new Mammals(250, 56, false, false);
                yield return new Mammals(170, 80, false, false);
                yield return new Mammals(150, 48, false, false);
                yield return new Mammals(130, 70, false, false);
                yield return new Mammals(120, 80, false, false);
                yield return new Mammals(120, 61, false, false);
                yield return new Mammals(110, 33, false, false);
                yield return new Mammals(100, 64, false, false);
                yield return new Mammals(85, 55, false, false);
                yield return new Mammals(80, 65, false, false);
                yield return new Mammals(72, 56, false, false);
                yield return new Mammals(70, 45, false, false);
                yield return new Mammals(65, 60, false, false);
                yield return new Mammals(62, 81, false, false);
                yield return new Mammals(50, 100, false, false);
                yield return new Mammals(50, 60, false, false);
                yield return new Mammals(50, 40, false, false);
                yield return new Mammals(50, 47, false, false);
                yield return new Mammals(37, 105, false, false);
                yield return new Mammals(35, 80, false, false);
                yield return new Mammals(34, 97, false, false);
                yield return new Mammals(30, 97, false, false);
                yield return new Mammals(30, 80, false, false);
                yield return new Mammals(30, 45, false, false);
                yield return new Mammals(20, 81, false, false);
                yield return new Mammals(400, 40, false, false);
                yield return new Mammals(300, 48, false, false);
                yield return new Mammals(230, 56, false, false);
                yield return new Mammals(150, 59, false, false);
                yield return new Mammals(135, 48, false, false);
                yield return new Mammals(65, 65, false, false);
                yield return new Mammals(60, 60, false, false);
                yield return new Mammals(55, 110, false, false);
                yield return new Mammals(45, 50, false, false);
                yield return new Mammals(40, 64, false, false);
                yield return new Mammals(25, 67, false, false);
                yield return new Mammals(20, 70, false, false);
                yield return new Mammals(16, 65, false, false);
                yield return new Mammals(12, 24, false, true);
                yield return new Mammals(11, 30, false, true);
                yield return new Mammals(10, 56, false, false);
                yield return new Mammals(7, 60, false, false);
                yield return new Mammals(6, 72, false, false);
                yield return new Mammals(5, 64, false, false);
                yield return new Mammals(5, 27, false, true);
                yield return new Mammals(3, 16, false, true);
                yield return new Mammals(127, 32, false, false);
                yield return new Mammals(70, 40, false, true);
                yield return new Mammals(13, 37, false, true);
                yield return new Mammals(9, 3.2, false, true);
                yield return new Mammals(4, 16, false, false);
                yield return new Mammals(0.6, 36, false, false);
                yield return new Mammals(0.6, 20, false, false);
                yield return new Mammals(0.55, 27, false, false);
                yield return new Mammals(0.5, 18, false, false);
                yield return new Mammals(0.4, 20, false, false);
                yield return new Mammals(0.3, 13, false, false);
                yield return new Mammals(0.25, 9.7, false, false);
                yield return new Mammals(0.22, 15, false, false);
                yield return new Mammals(0.11, 9, false, false);
                yield return new Mammals(0.1, 17, false, false);
                yield return new Mammals(0.056, 21, true, false);
                yield return new Mammals(0.05, 11, false, false);
                yield return new Mammals(0.045, 16, false, false);
                yield return new Mammals(0.035, 32, true, false);
                yield return new Mammals(0.035, 14, true, false);
                yield return new Mammals(0.03, 6.8, false, false);
                yield return new Mammals(0.03, 9.1, false, false);
                yield return new Mammals(0.025, 11, false, false);
                yield return new Mammals(0.025, 8.6, false, false);
                yield return new Mammals(0.018, 8.9, false, false);
                yield return new Mammals(0.016, 13, false, false);
                yield return new Mammals(0.1, 4, false, false);
                yield return new Mammals(0.1, 2.4, false, false);
                yield return new Mammals(0.016, 3.6, false, false);
                yield return new Mammals(4.6, 64, true, false);
                yield return new Mammals(4.4, 72, true, false);
                yield return new Mammals(4, 72, true, false);
                yield return new Mammals(3.5, 56, true, false);
                yield return new Mammals(2, 64, true, false);
                yield return new Mammals(1.9, 56, true, false);
                yield return new Mammals(1.5, 50, true, false);
                yield return new Mammals(1.5, 40, true, false);
                yield return new Mammals(50, 65, false, false);
                yield return new Mammals(5, 7.4, false, true);
                yield return new Mammals(0.024, 13, false, false);
                yield return new Mammals(4, 1.6, false, true);
            }
        }
    }
}
