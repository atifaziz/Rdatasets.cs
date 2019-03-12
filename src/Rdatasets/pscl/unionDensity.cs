// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// cross national rates of trade union density
    /// </summary>

    public class unionDensity
    {
        public readonly string κ;
        public readonly double union;
        public readonly double left;
        public readonly double size;
        public readonly double concen;

        public unionDensity(string κ, double union, double left, double size, double concen)
        {
            this.κ = κ;
            this.union = union;
            this.left = left;
            this.size = size;
            this.concen = concen;
        }

        public static IEnumerable<unionDensity> Data
        {
            get
            {
                yield return new unionDensity("Sweden", 82.4, 111.84, 8.27664912542186, 1.55);
                yield return new unionDensity("Israel", 80, 73.17, 6.90475076996184, 1.71);
                yield return new unionDensity("Iceland", 74.3, 17.25, 4.39444915467244, 2.06);
                yield return new unionDensity("Finland", 73.3, 59.33, 7.61775957660851, 1.56);
                yield return new unionDensity("Belgium", 71.9, 43.25, 8.11611843160937, 1.52);
                yield return new unionDensity("Denmark", 69.8, 90.24, 7.70751219460034, 1.52);
                yield return new unionDensity("Ireland", 68.1, 0, 6.78671695060508, 1.75);
                yield return new unionDensity("Austria", 65.6, 48.67, 7.81156848934518, 1.53);
                yield return new unionDensity("NZ", 59.4, 60, 6.95654544315157, 1.64);
                yield return new unionDensity("Norway", 58.9, 83.08, 7.41276401742656, 1.58);
                yield return new unionDensity("Australia", 51.4, 33.74, 8.60079877527103, 1.37);
                yield return new unionDensity("Italy", 50.6, 0, 9.66896702819858, 0.86);
                yield return new unionDensity("UK", 48, 43.67, 10.156461713809, 1.13);
                yield return new unionDensity("Germany", 39.6, 35.33, 10.043379921188, 0.92);
                yield return new unionDensity("Netherlands", 37.7, 31.5, 8.41383067842108, 1.25);
                yield return new unionDensity("Switzerland", 35.4, 11.87, 7.80791662892641, 1.68);
                yield return new unionDensity("Canada", 31.2, 0, 9.26065318584977, 1.35);
                yield return new unionDensity("Japan", 31, 1.92, 10.5948832000573, 1.11);
                yield return new unionDensity("France", 28.2, 8.67, 9.8440559687667, 0.95);
                yield return new unionDensity("USA", 24.5, 0, 11.4392681604813, 1);
            }
        }
    }
}
