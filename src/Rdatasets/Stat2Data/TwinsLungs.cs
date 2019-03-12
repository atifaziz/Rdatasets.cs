// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// TwinsLungs
    /// </summary>

    public class TwinsLungs
    {
        public readonly int κ;
        public readonly string Pair;
        public readonly string Environ;
        public readonly double Percent;

        public TwinsLungs(int κ, string Pair, string Environ, double Percent)
        {
            this.κ = κ;
            this.Pair = Pair;
            this.Environ = Environ;
            this.Percent = Percent;
        }

        public static IEnumerable<TwinsLungs> Data
        {
            get
            {
                yield return new TwinsLungs(1, "A", "Rural", 10.1);
                yield return new TwinsLungs(2, "B", "Rural", 51.8);
                yield return new TwinsLungs(3, "C", "Rural", 33.5);
                yield return new TwinsLungs(4, "D", "Rural", 32.8);
                yield return new TwinsLungs(5, "E", "Rural", 69);
                yield return new TwinsLungs(6, "F", "Rural", 38.8);
                yield return new TwinsLungs(7, "G", "Rural", 54.6);
                yield return new TwinsLungs(8, "A", "Urban", 28.1);
                yield return new TwinsLungs(9, "B", "Urban", 36.2);
                yield return new TwinsLungs(10, "C", "Urban", 40.7);
                yield return new TwinsLungs(11, "D", "Urban", 38.8);
                yield return new TwinsLungs(12, "E", "Urban", 71);
                yield return new TwinsLungs(13, "F", "Urban", 47);
                yield return new TwinsLungs(14, "G", "Urban", 57);
            }
        }
    }
}
