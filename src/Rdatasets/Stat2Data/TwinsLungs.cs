// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// TwinsLungs
    /// </summary>

    public class TwinsLungs
    {
        public readonly string Pair;
        public readonly string Environ;
        public readonly double Percent;

        public TwinsLungs(string Pair, string Environ, double Percent)
        {
            this.Pair = Pair;
            this.Environ = Environ;
            this.Percent = Percent;
        }

        public static IEnumerable<TwinsLungs> Data
        {
            get
            {
                yield return new TwinsLungs("A", "Rural", 10.1);
                yield return new TwinsLungs("B", "Rural", 51.8);
                yield return new TwinsLungs("C", "Rural", 33.5);
                yield return new TwinsLungs("D", "Rural", 32.8);
                yield return new TwinsLungs("E", "Rural", 69);
                yield return new TwinsLungs("F", "Rural", 38.8);
                yield return new TwinsLungs("G", "Rural", 54.6);
                yield return new TwinsLungs("A", "Urban", 28.1);
                yield return new TwinsLungs("B", "Urban", 36.2);
                yield return new TwinsLungs("C", "Urban", 40.7);
                yield return new TwinsLungs("D", "Urban", 38.8);
                yield return new TwinsLungs("E", "Urban", 71);
                yield return new TwinsLungs("F", "Urban", 47);
                yield return new TwinsLungs("G", "Urban", 57);
            }
        }
    }
}
