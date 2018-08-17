// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Five data sets from Harman (1967). 9 cognitive variables from Holzinger and 8 emotional variables from Burt
    /// </summary>

    public class Harman_8
    {
        public readonly double Height;
        public readonly double Arm_span;
        public readonly double Forearm;
        public readonly double Leg_length;
        public readonly double Weight;
        public readonly double Hips;
        public readonly double Chest_girth;
        public readonly double Chest_width;

        public Harman_8(double Height, double Arm_span, double Forearm, double Leg_length, double Weight, double Hips, double Chest_girth, double Chest_width)
        {
            this.Height = Height;
            this.Arm_span = Arm_span;
            this.Forearm = Forearm;
            this.Leg_length = Leg_length;
            this.Weight = Weight;
            this.Hips = Hips;
            this.Chest_girth = Chest_girth;
            this.Chest_width = Chest_width;
        }

        public static IEnumerable<Harman_8> Data
        {
            get
            {
                yield return new Harman_8(1, 0.846, 0.805, 0.859, 0.473, 0.398, 0.301, 0.382);
                yield return new Harman_8(0.846, 1, 0.881, 0.826, 0.376, 0.326, 0.277, 0.415);
                yield return new Harman_8(0.805, 0.881, 1, 0.801, 0.38, 0.319, 0.237, 0.345);
                yield return new Harman_8(0.859, 0.826, 0.801, 1, 0.436, 0.329, 0.327, 0.365);
                yield return new Harman_8(0.473, 0.376, 0.38, 0.436, 1, 0.762, 0.73, 0.629);
                yield return new Harman_8(0.398, 0.326, 0.319, 0.329, 0.762, 1, 0.583, 0.577);
                yield return new Harman_8(0.301, 0.277, 0.237, 0.327, 0.73, 0.583, 1, 0.539);
                yield return new Harman_8(0.382, 0.415, 0.345, 0.365, 0.629, 0.577, 0.539, 1);
            }
        }
    }
}
