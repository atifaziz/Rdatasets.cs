// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Truck Accidents Data
    /// </summary>

    public class Trucks
    {
        public readonly int Freq;
        public readonly string period;
        public readonly string collision;
        public readonly string parked;
        public readonly string light;

        public Trucks(int Freq, string period, string collision, string parked, string light)
        {
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
                yield return new Trucks(712, "before", "back", "yes", "daylight");
                yield return new Trucks(613, "after", "back", "yes", "daylight");
                yield return new Trucks(192, "before", "forward", "yes", "daylight");
                yield return new Trucks(179, "after", "forward", "yes", "daylight");
                yield return new Trucks(2557, "before", "back", "no", "daylight");
                yield return new Trucks(2373, "after", "back", "no", "daylight");
                yield return new Trucks(10749, "before", "forward", "no", "daylight");
                yield return new Trucks(9768, "after", "forward", "no", "daylight");
                yield return new Trucks(634, "before", "back", "yes", "night, illuminate");
                yield return new Trucks(411, "after", "back", "yes", "night, illuminate");
                yield return new Trucks(95, "before", "forward", "yes", "night, illuminate");
                yield return new Trucks(55, "after", "forward", "yes", "night, illuminate");
                yield return new Trucks(325, "before", "back", "no", "night, illuminate");
                yield return new Trucks(283, "after", "back", "no", "night, illuminate");
                yield return new Trucks(1256, "before", "forward", "no", "night, illuminate");
                yield return new Trucks(987, "after", "forward", "no", "night, illuminate");
                yield return new Trucks(345, "before", "back", "yes", "night, dark");
                yield return new Trucks(179, "after", "back", "yes", "night, dark");
                yield return new Trucks(46, "before", "forward", "yes", "night, dark");
                yield return new Trucks(39, "after", "forward", "yes", "night, dark");
                yield return new Trucks(579, "before", "back", "no", "night, dark");
                yield return new Trucks(494, "after", "back", "no", "night, dark");
                yield return new Trucks(1018, "before", "forward", "no", "night, dark");
                yield return new Trucks(885, "after", "forward", "no", "night, dark");
            }
        }
    }
}
