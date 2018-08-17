// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Girth, Height and Volume for Black Cherry Trees
    /// </summary>

    public class trees
    {
        public readonly double Girth;
        public readonly int Height;
        public readonly double Volume;

        public trees(double Girth, int Height, double Volume)
        {
            this.Girth = Girth;
            this.Height = Height;
            this.Volume = Volume;
        }

        public static IEnumerable<trees> Data
        {
            get
            {
                yield return new trees(8.3, 70, 10.3);
                yield return new trees(8.6, 65, 10.3);
                yield return new trees(8.8, 63, 10.2);
                yield return new trees(10.5, 72, 16.4);
                yield return new trees(10.7, 81, 18.8);
                yield return new trees(10.8, 83, 19.7);
                yield return new trees(11, 66, 15.6);
                yield return new trees(11, 75, 18.2);
                yield return new trees(11.1, 80, 22.6);
                yield return new trees(11.2, 75, 19.9);
                yield return new trees(11.3, 79, 24.2);
                yield return new trees(11.4, 76, 21);
                yield return new trees(11.4, 76, 21.4);
                yield return new trees(11.7, 69, 21.3);
                yield return new trees(12, 75, 19.1);
                yield return new trees(12.9, 74, 22.2);
                yield return new trees(12.9, 85, 33.8);
                yield return new trees(13.3, 86, 27.4);
                yield return new trees(13.7, 71, 25.7);
                yield return new trees(13.8, 64, 24.9);
                yield return new trees(14, 78, 34.5);
                yield return new trees(14.2, 80, 31.7);
                yield return new trees(14.5, 74, 36.3);
                yield return new trees(16, 72, 38.3);
                yield return new trees(16.3, 77, 42.6);
                yield return new trees(17.3, 81, 55.4);
                yield return new trees(17.5, 82, 55.7);
                yield return new trees(17.9, 80, 58.3);
                yield return new trees(18, 80, 51.5);
                yield return new trees(18, 80, 51);
                yield return new trees(20.6, 87, 77);
            }
        }
    }
}
