// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Blood pressure versus Salt; inter-population data
    /// </summary>

    public class intersalt
    {
        public readonly double b;
        public readonly double bp;
        public readonly double na;
        public readonly string country;

        public intersalt(double b, double bp, double na, string country)
        {
            this.b = b;
            this.bp = bp;
            this.na = na;
            this.country = country;
        }

        public static IEnumerable<intersalt> Data
        {
            get
            {
                yield return new intersalt(0.512, 72, 149.3, "Argentina");
                yield return new intersalt(0.226, 78.2, 133, "Belgium");
                yield return new intersalt(0.316, 73.9, 142.6, "Belgium");
                yield return new intersalt(0.042, 61.7, 5.8, "Brazil");
                yield return new intersalt(0.086, 61.4, 0.2, "Brazil");
                yield return new intersalt(0.265, 73.4, 148.9, "Canada");
                yield return new intersalt(0.384, 79.2, 184.3, "Canada");
                yield return new intersalt(0.501, 66.6, 194.1, "Colombia");
                yield return new intersalt(0.352, 82.1, 135.6, "Denmark");
                yield return new intersalt(0.443, 75, 138.7, "East Germany");
                yield return new intersalt(0.508, 77.5, 164.1, "Finland");
                yield return new intersalt(0.465, 77.4, 144.4, "Finland");
                yield return new intersalt(0.308, 79.2, 189.7, "Hungary");
                yield return new intersalt(0.28, 71.7, 135.1, "Iceland");
                yield return new intersalt(0.497, 70.7, 194.4, "India");
                yield return new intersalt(0.383, 73.9, 153.2, "India");
                yield return new intersalt(0.436, 79.6, 175.9, "Italy");
                yield return new intersalt(0.439, 69.9, 169.9, "Italy");
                yield return new intersalt(0.37, 76, 170, "Italy");
                yield return new intersalt(0.321, 72.9, 162.6, "Italy");
                yield return new intersalt(0.446, 68.4, 167.1, "Japan");
                yield return new intersalt(0.254, 67.2, 171.2, "Japan");
                yield return new intersalt(0.497, 73.5, 201.2, "Japan");
                yield return new intersalt(0.134, 67.9, 51.3, "Kenya");
                yield return new intersalt(0.309, 77.2, 165.6, "Malta");
                yield return new intersalt(0.215, 72.6, 134.6, "Mexico");
                yield return new intersalt(0.301, 79.7, 146.4, "Netherlands");
                yield return new intersalt(0.047, 62.9, 26.8, "PNG");
                yield return new intersalt(0.501, 66.1, 196.4, "PRC");
                yield return new intersalt(0.465, 67.4, 158.1, "PRC");
                yield return new intersalt(0.399, 70.2, 242.1, "PRC");
                yield return new intersalt(0.369, 75.7, 191.8, "Poland");
                yield return new intersalt(0.302, 77.9, 174.6, "Poland");
                yield return new intersalt(0.679, 78.2, 175.4, "Portugal");
                yield return new intersalt(0.303, 71.4, 201.4, "South Korea");
                yield return new intersalt(0.411, 72.1, 161.8, "SovietUnion");
                yield return new intersalt(0.47, 72.7, 165.4, "Spain");
                yield return new intersalt(0.49, 68, 175.2, "Spain");
                yield return new intersalt(0.367, 75.2, 136.2, "Taiwan");
                yield return new intersalt(0.34, 75.5, 108.3, "Trinidad");
                yield return new intersalt(0.29, 73.1, 149.9, "UK");
                yield return new intersalt(0.32, 71.2, 150, "UK");
                yield return new intersalt(0.442, 72.4, 151.8, "UK");
                yield return new intersalt(0.265, 70, 133.8, "US");
                yield return new intersalt(0.294, 78.5, 95.9, "USBlack");
                yield return new intersalt(0.27, 72.4, 125.9, "US");
                yield return new intersalt(0.434, 73.2, 130.3, "Hawaii");
                yield return new intersalt(0.295, 81.4, 136.6, "USBlack");
                yield return new intersalt(0.204, 76.2, 133.4, "US");
                yield return new intersalt(0.3, 74.7, 162, "West Germany");
                yield return new intersalt(0.303, 73.1, 172, "West Germany");
                yield return new intersalt(0.36, 75.6, 129.7, "Zimbabwe");
            }
        }
    }
}
