// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Germination of common chickweed (_Stellaria media_)
    /// </summary>

    public class chickweed
    {
        public readonly double start;
        public readonly string end;
        public readonly int count;

        public chickweed(double start, string end, int count)
        {
            this.start = start;
            this.end = end;
            this.count = count;
        }

        public static IEnumerable<chickweed> Data
        {
            get
            {
                yield return new chickweed(0, "12", 0);
                yield return new chickweed(12, "22", 0);
                yield return new chickweed(22, "30", 0);
                yield return new chickweed(30, "36", 0);
                yield return new chickweed(36, "46", 0);
                yield return new chickweed(46, "54", 0);
                yield return new chickweed(54, "60", 0);
                yield return new chickweed(60, "71", 0);
                yield return new chickweed(71, "78", 0);
                yield return new chickweed(78, "84", 0);
                yield return new chickweed(84, "95", 0);
                yield return new chickweed(95, "103", 0);
                yield return new chickweed(103, "109", 0);
                yield return new chickweed(109, "120", 0);
                yield return new chickweed(120, "129", 0);
                yield return new chickweed(129, "133", 0);
                yield return new chickweed(133, "143", 2);
                yield return new chickweed(143, "151", 0);
                yield return new chickweed(151, "158.5", 0);
                yield return new chickweed(158.5, "169.5", 0);
                yield return new chickweed(169.5, "176.5", 0);
                yield return new chickweed(176.5, "182.5", 3);
                yield return new chickweed(182.5, "192.5", 10);
                yield return new chickweed(192.5, "200.5", 11);
                yield return new chickweed(200.5, "206.5", 6);
                yield return new chickweed(206.5, "216.5", 5);
                yield return new chickweed(216.5, "224.5", 2);
                yield return new chickweed(224.5, "230.5", 0);
                yield return new chickweed(230.5, "241.5", 0);
                yield return new chickweed(241.5, "249.5", 0);
                yield return new chickweed(249.5, "254.5", 0);
                yield return new chickweed(254.5, "266.5", 0);
                yield return new chickweed(266.5, "276.5", 1);
                yield return new chickweed(276.5, "281.5", 0);
                yield return new chickweed(281.5, "Inf", 160);
            }
        }
    }
}
