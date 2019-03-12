// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Number of Breaks in Yarn during Weaving
    /// </summary>

    public class warpbreaks
    {
        public readonly int κ;
        public readonly int breaks;
        public readonly string wool;
        public readonly string tension;

        public warpbreaks(int κ, int breaks, string wool, string tension)
        {
            this.κ = κ;
            this.breaks = breaks;
            this.wool = wool;
            this.tension = tension;
        }

        public static IEnumerable<warpbreaks> Data
        {
            get
            {
                yield return new warpbreaks(1, 26, "A", "L");
                yield return new warpbreaks(2, 30, "A", "L");
                yield return new warpbreaks(3, 54, "A", "L");
                yield return new warpbreaks(4, 25, "A", "L");
                yield return new warpbreaks(5, 70, "A", "L");
                yield return new warpbreaks(6, 52, "A", "L");
                yield return new warpbreaks(7, 51, "A", "L");
                yield return new warpbreaks(8, 26, "A", "L");
                yield return new warpbreaks(9, 67, "A", "L");
                yield return new warpbreaks(10, 18, "A", "M");
                yield return new warpbreaks(11, 21, "A", "M");
                yield return new warpbreaks(12, 29, "A", "M");
                yield return new warpbreaks(13, 17, "A", "M");
                yield return new warpbreaks(14, 12, "A", "M");
                yield return new warpbreaks(15, 18, "A", "M");
                yield return new warpbreaks(16, 35, "A", "M");
                yield return new warpbreaks(17, 30, "A", "M");
                yield return new warpbreaks(18, 36, "A", "M");
                yield return new warpbreaks(19, 36, "A", "H");
                yield return new warpbreaks(20, 21, "A", "H");
                yield return new warpbreaks(21, 24, "A", "H");
                yield return new warpbreaks(22, 18, "A", "H");
                yield return new warpbreaks(23, 10, "A", "H");
                yield return new warpbreaks(24, 43, "A", "H");
                yield return new warpbreaks(25, 28, "A", "H");
                yield return new warpbreaks(26, 15, "A", "H");
                yield return new warpbreaks(27, 26, "A", "H");
                yield return new warpbreaks(28, 27, "B", "L");
                yield return new warpbreaks(29, 14, "B", "L");
                yield return new warpbreaks(30, 29, "B", "L");
                yield return new warpbreaks(31, 19, "B", "L");
                yield return new warpbreaks(32, 29, "B", "L");
                yield return new warpbreaks(33, 31, "B", "L");
                yield return new warpbreaks(34, 41, "B", "L");
                yield return new warpbreaks(35, 20, "B", "L");
                yield return new warpbreaks(36, 44, "B", "L");
                yield return new warpbreaks(37, 42, "B", "M");
                yield return new warpbreaks(38, 26, "B", "M");
                yield return new warpbreaks(39, 19, "B", "M");
                yield return new warpbreaks(40, 16, "B", "M");
                yield return new warpbreaks(41, 39, "B", "M");
                yield return new warpbreaks(42, 28, "B", "M");
                yield return new warpbreaks(43, 21, "B", "M");
                yield return new warpbreaks(44, 39, "B", "M");
                yield return new warpbreaks(45, 29, "B", "M");
                yield return new warpbreaks(46, 20, "B", "H");
                yield return new warpbreaks(47, 21, "B", "H");
                yield return new warpbreaks(48, 24, "B", "H");
                yield return new warpbreaks(49, 17, "B", "H");
                yield return new warpbreaks(50, 13, "B", "H");
                yield return new warpbreaks(51, 15, "B", "H");
                yield return new warpbreaks(52, 15, "B", "H");
                yield return new warpbreaks(53, 16, "B", "H");
                yield return new warpbreaks(54, 28, "B", "H");
            }
        }
    }
}
