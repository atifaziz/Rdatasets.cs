// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// The 1907 Romanian Peasant Rebellion
    /// </summary>

    public class Chirot
    {
        public readonly int κ;
        public readonly double intensity;
        public readonly double commerce;
        public readonly double tradition;
        public readonly double midpeasant;
        public readonly double inequality;

        public Chirot(int κ, double intensity, double commerce, double tradition, double midpeasant, double inequality)
        {
            this.κ = κ;
            this.intensity = intensity;
            this.commerce = commerce;
            this.tradition = tradition;
            this.midpeasant = midpeasant;
            this.inequality = inequality;
        }

        public static IEnumerable<Chirot> Data
        {
            get
            {
                yield return new Chirot(1, -1.39, 13.8, 86.2, 6.2, 0.6);
                yield return new Chirot(2, 0.65, 20.4, 86.7, 2.9, 0.72);
                yield return new Chirot(3, 1.89, 27.6, 79.3, 16.9, 0.66);
                yield return new Chirot(4, -0.15, 18.6, 90.1, 3.4, 0.74);
                yield return new Chirot(5, -0.86, 17.2, 84.5, 9, 0.7);
                yield return new Chirot(6, 0.11, 21.5, 81.5, 5.2, 0.6);
                yield return new Chirot(7, -0.51, 11.6, 82.6, 5.1, 0.52);
                yield return new Chirot(8, -0.86, 20.4, 82.4, 6.3, 0.64);
                yield return new Chirot(9, -0.24, 19.5, 87.5, 4.8, 0.68);
                yield return new Chirot(10, -0.77, 8.9, 85.6, 9.5, 0.58);
                yield return new Chirot(11, -0.24, 25.8, 82.2, 10.9, 0.68);
                yield return new Chirot(12, -1.57, 24.1, 83.5, 8.4, 0.74);
                yield return new Chirot(13, -0.51, 22, 88.3, 6.2, 0.7);
                yield return new Chirot(14, -1.57, 24.2, 84.9, 6.1, 0.62);
                yield return new Chirot(15, -0.51, 30.6, 76.1, 1.3, 0.76);
                yield return new Chirot(16, -1.13, 33.9, 85.5, 5.8, 0.7);
                yield return new Chirot(17, -1.22, 28.6, 84.2, 2.9, 0.58);
                yield return new Chirot(18, -1.22, 36.5, 78.1, 4.3, 0.72);
                yield return new Chirot(19, -0.86, 40.9, 84.4, 2.3, 0.64);
                yield return new Chirot(20, -1.39, 6.8, 76.3, 3.6, 0.58);
                yield return new Chirot(21, 2.81, 41.9, 89.7, 6.6, 0.66);
                yield return new Chirot(22, -1.04, 25.4, 83.2, 2.5, 0.68);
                yield return new Chirot(23, 1.57, 30.5, 80.2, 4.1, 0.76);
                yield return new Chirot(24, 4.32, 48.2, 91, 4.2, 0.7);
                yield return new Chirot(25, 3.79, 46, 90.5, 3.7, 0.68);
                yield return new Chirot(26, 3.79, 45.1, 85.5, 5.1, 0.64);
                yield return new Chirot(27, -1.75, 12.5, 83.8, 7.2, 0.5);
                yield return new Chirot(28, 0.82, 39.3, 85.6, 4.9, 0.6);
                yield return new Chirot(29, 2.59, 47.7, 87.6, 5.2, 0.58);
                yield return new Chirot(30, -0.86, 15.2, 87.3, 10.8, 0.42);
                yield return new Chirot(31, -1.84, 11.7, 82.3, 81.7, 0.42);
                yield return new Chirot(32, -1.84, 25.6, 80.1, 68.4, 0.26);
            }
        }
    }
}
