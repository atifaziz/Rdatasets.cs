// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Germination of common chickweed (_Stellaria media_)
    /// </summary>

    public class chickweed
    {
        public readonly int κ;
        public readonly double start;
        public readonly string end;
        public readonly int count;

        public chickweed(int κ, double start, string end, int count)
        {
            this.κ = κ;
            this.start = start;
            this.end = end;
            this.count = count;
        }

        public static IEnumerable<chickweed> Data
        {
            get
            {
                yield return new chickweed(1, 0, "12", 0);
                yield return new chickweed(2, 12, "22", 0);
                yield return new chickweed(3, 22, "30", 0);
                yield return new chickweed(4, 30, "36", 0);
                yield return new chickweed(5, 36, "46", 0);
                yield return new chickweed(6, 46, "54", 0);
                yield return new chickweed(7, 54, "60", 0);
                yield return new chickweed(8, 60, "71", 0);
                yield return new chickweed(9, 71, "78", 0);
                yield return new chickweed(10, 78, "84", 0);
                yield return new chickweed(11, 84, "95", 0);
                yield return new chickweed(12, 95, "103", 0);
                yield return new chickweed(13, 103, "109", 0);
                yield return new chickweed(14, 109, "120", 0);
                yield return new chickweed(15, 120, "129", 0);
                yield return new chickweed(16, 129, "133", 0);
                yield return new chickweed(17, 133, "143", 2);
                yield return new chickweed(18, 143, "151", 0);
                yield return new chickweed(19, 151, "158.5", 0);
                yield return new chickweed(20, 158.5, "169.5", 0);
                yield return new chickweed(21, 169.5, "176.5", 0);
                yield return new chickweed(22, 176.5, "182.5", 3);
                yield return new chickweed(23, 182.5, "192.5", 10);
                yield return new chickweed(24, 192.5, "200.5", 11);
                yield return new chickweed(25, 200.5, "206.5", 6);
                yield return new chickweed(26, 206.5, "216.5", 5);
                yield return new chickweed(27, 216.5, "224.5", 2);
                yield return new chickweed(28, 224.5, "230.5", 0);
                yield return new chickweed(29, 230.5, "241.5", 0);
                yield return new chickweed(30, 241.5, "249.5", 0);
                yield return new chickweed(31, 249.5, "254.5", 0);
                yield return new chickweed(32, 254.5, "266.5", 0);
                yield return new chickweed(33, 266.5, "276.5", 1);
                yield return new chickweed(34, 276.5, "281.5", 0);
                yield return new chickweed(35, 281.5, "Inf", 160);
            }
        }
    }
}
