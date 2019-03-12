// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Truck Accidents Data
    /// </summary>

    public class Trucks
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string period;
        public readonly string collision;
        public readonly string parked;
        public readonly string light;

        public Trucks(int κ, int Freq, string period, string collision, string parked, string light)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.period = period;
            this.collision = collision;
            this.parked = parked;
            this.light = light;
        }

        public static IEnumerable<Trucks> Data
        {
            get
            {
                yield return new Trucks(1, 712, "before", "back", "yes", "daylight");
                yield return new Trucks(2, 613, "after", "back", "yes", "daylight");
                yield return new Trucks(3, 192, "before", "forward", "yes", "daylight");
                yield return new Trucks(4, 179, "after", "forward", "yes", "daylight");
                yield return new Trucks(5, 2557, "before", "back", "no", "daylight");
                yield return new Trucks(6, 2373, "after", "back", "no", "daylight");
                yield return new Trucks(7, 10749, "before", "forward", "no", "daylight");
                yield return new Trucks(8, 9768, "after", "forward", "no", "daylight");
                yield return new Trucks(9, 634, "before", "back", "yes", "night, illuminate");
                yield return new Trucks(10, 411, "after", "back", "yes", "night, illuminate");
                yield return new Trucks(11, 95, "before", "forward", "yes", "night, illuminate");
                yield return new Trucks(12, 55, "after", "forward", "yes", "night, illuminate");
                yield return new Trucks(13, 325, "before", "back", "no", "night, illuminate");
                yield return new Trucks(14, 283, "after", "back", "no", "night, illuminate");
                yield return new Trucks(15, 1256, "before", "forward", "no", "night, illuminate");
                yield return new Trucks(16, 987, "after", "forward", "no", "night, illuminate");
                yield return new Trucks(17, 345, "before", "back", "yes", "night, dark");
                yield return new Trucks(18, 179, "after", "back", "yes", "night, dark");
                yield return new Trucks(19, 46, "before", "forward", "yes", "night, dark");
                yield return new Trucks(20, 39, "after", "forward", "yes", "night, dark");
                yield return new Trucks(21, 579, "before", "back", "no", "night, dark");
                yield return new Trucks(22, 494, "after", "back", "no", "night, dark");
                yield return new Trucks(23, 1018, "before", "forward", "no", "night, dark");
                yield return new Trucks(24, 885, "after", "forward", "no", "night, dark");
            }
        }
    }
}
