// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Pedometer
    /// </summary>

    public class Pedometer
    {
        public readonly int Steps;
        public readonly int Moderate;
        public readonly int Min;
        public readonly int kcal;
        public readonly double Mile;
        public readonly string Rain;
        public readonly string Day;
        public readonly string DayType;

        public Pedometer(int Steps, int Moderate, int Min, int kcal, double Mile, string Rain, string Day, string DayType)
        {
            this.Steps = Steps;
            this.Moderate = Moderate;
            this.Min = Min;
            this.kcal = kcal;
            this.Mile = Mile;
            this.Rain = Rain;
            this.Day = Day;
            this.DayType = DayType;
        }

        public static IEnumerable<Pedometer> Data
        {
            get
            {
                yield return new Pedometer(7537, 1918, 17, 117, 4.2, "shine", "T", "Weekday");
                yield return new Pedometer(10008, 5573, 48, 274, 5.6, "rain", "W", "Weekday");
                yield return new Pedometer(6912, 3309, 29, 166, 3.9, "rain", "R", "Weekday");
                yield return new Pedometer(7552, 3826, 33, 186, 4.3, "rain", "F", "Weekday");
                yield return new Pedometer(6789, 2306, 20, 135, 3.8, "rain", "W", "Weekday");
                yield return new Pedometer(4219, 1941, 17, 90, 2.3, "rain", "M", "Weekday");
                yield return new Pedometer(9260, 6095, 54, 280, 5.2, "rain", "W", "Weekday");
                yield return new Pedometer(5519, 3183, 27, 154, 3.1, "rain", "F", "Weekday");
                yield return new Pedometer(4465, 1603, 14, 82, 2.5, "rain", "M", "Weekday");
                yield return new Pedometer(8057, 5242, 47, 237, 4.5, "rain", "W", "Weekday");
                yield return new Pedometer(6095, 2797, 24, 136, 3.4, "rain", "T", "Weekday");
                yield return new Pedometer(5260, 1531, 13, 84, 2.9, "rain", "W", "Weekday");
                yield return new Pedometer(5613, 1487, 13, 90, 2.9, "rain", "R", "Weekday");
                yield return new Pedometer(8754, 5127, 44, 251, 4.9, "rain", "F", "Weekday");
                yield return new Pedometer(5993, 2660, 22, 144, 3.4, "shine", "M", "Weekday");
                yield return new Pedometer(4515, 386, 3, 42, 2.5, "shine", "T", "Weekday");
                yield return new Pedometer(6534, 1933, 18, 108, 3.7, "shine", "W", "Weekday");
                yield return new Pedometer(4442, 1368, 12, 75, 2.5, "shine", "R", "Weekday");
                yield return new Pedometer(4498, 1110, 10, 71, 2.4, "shine", "F", "Weekday");
                yield return new Pedometer(4863, 1161, 11, 71, 2.7, "shine", "M", "Weekday");
                yield return new Pedometer(3256, 536, 5, 35, 1.8, "rain", "W", "Weekday");
                yield return new Pedometer(3892, 784, 7, 54, 2.2, "shine", "R", "Weekday");
                yield return new Pedometer(4363, 873, 8, 53, 2.4, "shine", "F", "Weekday");
                yield return new Pedometer(7749, 4177, 35, 209, 4.4, "rain", "M", "Weekday");
                yield return new Pedometer(4469, 698, 6, 52, 2.5, "shine", "T", "Weekday");
                yield return new Pedometer(4521, 940, 8, 56, 2.5, "shine", "W", "Weekday");
                yield return new Pedometer(4208, 613, 5, 41, 2.3, "shine", "R", "Weekday");
                yield return new Pedometer(3353, 842, 7, 47, 1.8, "shine", "F", "Weekday");
                yield return new Pedometer(6925, 4086, 35, 195, 3.9, "rain", "M", "Weekday");
                yield return new Pedometer(6217, 3345, 29, 160, 3.5, "rain", "T", "Weekday");
                yield return new Pedometer(6282, 3362, 29, 164, 3.5, "rain", "W", "Weekday");
                yield return new Pedometer(3384, 205, 2, 22, 1.9, "shine", "R", "Weekday");
                yield return new Pedometer(4038, 387, 3, 33, 2.2, "shine", "F", "Weekday");
                yield return new Pedometer(3620, 1320, 11, 69, 2, "rain", "U", "Weekend");
                yield return new Pedometer(3942, 1050, 9, 61, 2.2, "rain", "M", "Weekday");
                yield return new Pedometer(6091, 4104, 35, 192, 3.4, "rain", "T", "Weekday");
                yield return new Pedometer(6245, 3259, 28, 168, 3.5, "rain", "W", "Weekday");
                yield return new Pedometer(6744, 3728, 32, 183, 3.8, "cold", "R", "Weekday");
                yield return new Pedometer(6563, 2821, 24, 151, 3.7, "cold", "F", "Weekday");
                yield return new Pedometer(5621, 1418, 11, 99, 2.7, "cold", "S", "Weekend");
                yield return new Pedometer(7127, 2011, 17, 116, 4, "rain", "U", "Weekend");
                yield return new Pedometer(5736, 1972, 18, 110, 3.2, "cold", "M", "Weekday");
                yield return new Pedometer(7279, 4149, 35, 214, 4.1, "cold", "T", "Weekday");
                yield return new Pedometer(10634, 6283, 54, 305, 5.3, "cold", "W", "Weekday");
                yield return new Pedometer(9793, 6404, 54, 317, 5.5, "cold", "R", "Weekday");
                yield return new Pedometer(6566, 3878, 33, 193, 3.7, "cold", "F", "Weekday");
                yield return new Pedometer(4058, 277, 2, 34, 2.3, "cold", "S", "Weekend");
                yield return new Pedometer(3347, 773, 6, 52, 1.9, "cold", "U", "Weekend");
                yield return new Pedometer(7546, 3879, 34, 195, 4.2, "cold", "M", "Weekday");
                yield return new Pedometer(7219, 4178, 36, 205, 4.1, "cold", "T", "Weekday");
                yield return new Pedometer(7805, 4621, 41, 223, 4.4, "cold", "W", "Weekday");
                yield return new Pedometer(5762, 3562, 30, 176, 3.2, "cold", "F", "Weekday");
                yield return new Pedometer(5707, 2716, 23, 142, 3.2, "cold", "S", "Weekend");
                yield return new Pedometer(2232, 348, 3, 22, 1.2, "cold", "U", "Weekend");
                yield return new Pedometer(7071, 4262, 36, 214, 4, "cold", "M", "Weekday");
                yield return new Pedometer(7443, 4625, 39, 227, 4.2, "cold", "T", "Weekday");
                yield return new Pedometer(5423, 2681, 24, 132, 3, "cold", "W", "Weekday");
                yield return new Pedometer(8305, 4801, 42, 237, 4.7, "cold", "R", "Weekday");
                yield return new Pedometer(2978, 700, 6, 42, 1.6, "cold", "F", "Weekday");
                yield return new Pedometer(2966, 35, 0, 13, 1.6, "cold", "S", "Weekend");
                yield return new Pedometer(4727, 1263, 10, 82, 2.6, "cold", "U", "Weekend");
                yield return new Pedometer(2501, 386, 3, 23, 1.4, "cold", "M", "Weekday");
                yield return new Pedometer(2703, 329, 3, 20, 1.5, "cold", "T", "Weekday");
                yield return new Pedometer(2635, 425, 4, 25, 1.4, "cold", "W", "Weekday");
                yield return new Pedometer(1996, 100, 1, 10, 1.1, "cold", "R", "Weekday");
                yield return new Pedometer(4142, 1641, 13, 94, 2.3, "cold", "F", "Weekday");
                yield return new Pedometer(4057, 1301, 11, 72, 2.3, "cold", "S", "Weekend");
                yield return new Pedometer(4287, 679, 6, 42, 2.4, "cold", "U", "Weekend");
            }
        }
    }
}
