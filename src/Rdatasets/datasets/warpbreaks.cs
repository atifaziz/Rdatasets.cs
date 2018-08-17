// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Number of Breaks in Yarn during Weaving
    /// </summary>

    public class warpbreaks
    {
        public readonly int breaks;
        public readonly string wool;
        public readonly string tension;

        public warpbreaks(int breaks, string wool, string tension)
        {
            this.breaks = breaks;
            this.wool = wool;
            this.tension = tension;
        }

        public static IEnumerable<warpbreaks> Data
        {
            get
            {
                yield return new warpbreaks(26, "A", "L");
                yield return new warpbreaks(30, "A", "L");
                yield return new warpbreaks(54, "A", "L");
                yield return new warpbreaks(25, "A", "L");
                yield return new warpbreaks(70, "A", "L");
                yield return new warpbreaks(52, "A", "L");
                yield return new warpbreaks(51, "A", "L");
                yield return new warpbreaks(26, "A", "L");
                yield return new warpbreaks(67, "A", "L");
                yield return new warpbreaks(18, "A", "M");
                yield return new warpbreaks(21, "A", "M");
                yield return new warpbreaks(29, "A", "M");
                yield return new warpbreaks(17, "A", "M");
                yield return new warpbreaks(12, "A", "M");
                yield return new warpbreaks(18, "A", "M");
                yield return new warpbreaks(35, "A", "M");
                yield return new warpbreaks(30, "A", "M");
                yield return new warpbreaks(36, "A", "M");
                yield return new warpbreaks(36, "A", "H");
                yield return new warpbreaks(21, "A", "H");
                yield return new warpbreaks(24, "A", "H");
                yield return new warpbreaks(18, "A", "H");
                yield return new warpbreaks(10, "A", "H");
                yield return new warpbreaks(43, "A", "H");
                yield return new warpbreaks(28, "A", "H");
                yield return new warpbreaks(15, "A", "H");
                yield return new warpbreaks(26, "A", "H");
                yield return new warpbreaks(27, "B", "L");
                yield return new warpbreaks(14, "B", "L");
                yield return new warpbreaks(29, "B", "L");
                yield return new warpbreaks(19, "B", "L");
                yield return new warpbreaks(29, "B", "L");
                yield return new warpbreaks(31, "B", "L");
                yield return new warpbreaks(41, "B", "L");
                yield return new warpbreaks(20, "B", "L");
                yield return new warpbreaks(44, "B", "L");
                yield return new warpbreaks(42, "B", "M");
                yield return new warpbreaks(26, "B", "M");
                yield return new warpbreaks(19, "B", "M");
                yield return new warpbreaks(16, "B", "M");
                yield return new warpbreaks(39, "B", "M");
                yield return new warpbreaks(28, "B", "M");
                yield return new warpbreaks(21, "B", "M");
                yield return new warpbreaks(39, "B", "M");
                yield return new warpbreaks(29, "B", "M");
                yield return new warpbreaks(20, "B", "H");
                yield return new warpbreaks(21, "B", "H");
                yield return new warpbreaks(24, "B", "H");
                yield return new warpbreaks(17, "B", "H");
                yield return new warpbreaks(13, "B", "H");
                yield return new warpbreaks(15, "B", "H");
                yield return new warpbreaks(15, "B", "H");
                yield return new warpbreaks(16, "B", "H");
                yield return new warpbreaks(28, "B", "H");
            }
        }
    }
}
