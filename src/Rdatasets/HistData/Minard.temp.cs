// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from Minard's famous graphic map of Napoleon's march on Moscow
    /// </summary>

    public class Minard_temp
    {
        public readonly int κ;
        public readonly double @long;
        public readonly int temp;
        public readonly int days;
        public readonly string date;

        public Minard_temp(int κ, double @long, int temp, int days, string date)
        {
            this.κ = κ;
            this.@long = @long;
            this.temp = temp;
            this.days = days;
            this.date = date;
        }

        public static IEnumerable<Minard_temp> Data
        {
            get
            {
                yield return new Minard_temp(1, 37.6, 0, 6, "Oct18");
                yield return new Minard_temp(2, 36, 0, 6, "Oct24");
                yield return new Minard_temp(3, 33.2, -9, 16, "Nov09");
                yield return new Minard_temp(4, 32, -21, 5, "Nov14");
                yield return new Minard_temp(5, 29.2, -11, 10, null);
                yield return new Minard_temp(6, 28.5, -20, 4, "Nov28");
                yield return new Minard_temp(7, 27.2, -24, 3, "Dec01");
                yield return new Minard_temp(8, 26.7, -30, 5, "Dec06");
                yield return new Minard_temp(9, 25.3, -26, 1, "Dec07");
            }
        }
    }
}
