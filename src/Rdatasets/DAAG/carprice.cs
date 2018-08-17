// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// US Car Price Data
    /// </summary>

    public class carprice
    {
        public readonly string Type;
        public readonly double Min_Price;
        public readonly double Price;
        public readonly double Max_Price;
        public readonly double Range_Price;
        public readonly double RoughRange;
        public readonly double gpm100;
        public readonly int MPG_city;
        public readonly int MPG_highway;

        public carprice(string Type, double Min_Price, double Price, double Max_Price, double Range_Price, double RoughRange, double gpm100, int MPG_city, int MPG_highway)
        {
            this.Type = Type;
            this.Min_Price = Min_Price;
            this.Price = Price;
            this.Max_Price = Max_Price;
            this.Range_Price = Range_Price;
            this.RoughRange = RoughRange;
            this.gpm100 = gpm100;
            this.MPG_city = MPG_city;
            this.MPG_highway = MPG_highway;
        }

        public static IEnumerable<carprice> Data
        {
            get
            {
                yield return new carprice("Midsize", 14.2, 15.7, 17.3, 3.1, 3.09, 3.8, 22, 31);
                yield return new carprice("Large", 19.9, 20.8, 21.7, 1.8, 1.79, 4.2, 19, 28);
                yield return new carprice("Large", 22.6, 23.7, 24.9, 2.3, 2.31, 4.9, 16, 25);
                yield return new carprice("Midsize", 26.3, 26.3, 26.3, 0, -0.01, 4.3, 19, 27);
                yield return new carprice("Large", 33, 34.7, 36.3, 3.3, 3.3, 4.9, 16, 25);
                yield return new carprice("Midsize", 37.5, 40.1, 42.7, 5.2, 5.18, 4.9, 16, 25);
                yield return new carprice("Compact", 8.5, 13.4, 18.3, 9.8, 9.8, 3.3, 25, 36);
                yield return new carprice("Compact", 11.4, 11.4, 11.4, 0, -0.01, 3.4, 25, 34);
                yield return new carprice("Sporty", 13.4, 15.1, 16.8, 3.4, 3.38, 4.2, 19, 28);
                yield return new carprice("Midsize", 13.4, 15.9, 18.4, 5, 5.01, 4, 21, 29);
                yield return new carprice("Van", 14.7, 16.3, 18, 3.3, 3.31, 4.9, 18, 23);
                yield return new carprice("Van", 14.7, 16.6, 18.6, 3.9, 3.9, 5.7, 15, 20);
                yield return new carprice("Large", 18, 18.8, 19.6, 1.6, 1.6, 4.7, 17, 26);
                yield return new carprice("Sporty", 34.6, 38, 41.5, 6.9, 6.88, 4.8, 17, 25);
                yield return new carprice("Large", 18.4, 18.4, 18.4, 0, -0.01, 4.2, 20, 28);
                yield return new carprice("Compact", 14.5, 15.8, 17.1, 2.6, 2.59, 3.9, 23, 28);
                yield return new carprice("Large", 29.5, 29.5, 29.5, 0, 0.02, 4.3, 20, 26);
                yield return new carprice("Small", 7.9, 9.2, 10.6, 2.7, 2.68, 3.2, 29, 33);
                yield return new carprice("Small", 8.4, 11.3, 14.2, 5.8, 5.8, 3.8, 23, 29);
                yield return new carprice("Compact", 11.9, 13.3, 14.7, 2.8, 2.81, 4.1, 22, 27);
                yield return new carprice("Van", 13.6, 19, 24.4, 10.8, 10.77, 5.3, 17, 21);
                yield return new carprice("Midsize", 14.8, 15.6, 16.4, 1.6, 1.6, 4.2, 21, 27);
                yield return new carprice("Sporty", 18.5, 25.8, 33.1, 14.6, 14.6, 4.8, 18, 24);
                yield return new carprice("Small", 7.9, 12.2, 16.5, 8.6, 8.6, 3.2, 29, 33);
                yield return new carprice("Large", 17.5, 19.3, 21.2, 3.7, 3.69, 4.2, 20, 28);
                yield return new carprice("Small", 6.9, 7.4, 7.9, 1, 1, 3.1, 31, 33);
                yield return new carprice("Small", 8.4, 10.1, 11.9, 3.5, 3.49, 3.8, 23, 30);
                yield return new carprice("Compact", 10.4, 11.3, 12.2, 1.8, 1.82, 4.1, 22, 27);
                yield return new carprice("Sporty", 10.8, 15.9, 21, 10.2, 10.21, 3.9, 22, 29);
                yield return new carprice("Sporty", 12.8, 14, 15.2, 2.4, 2.4, 3.7, 24, 30);
                yield return new carprice("Van", 14.5, 19.9, 25.3, 10.8, 10.82, 5.7, 15, 20);
                yield return new carprice("Midsize", 15.6, 20.2, 24.8, 9.2, 9.21, 3.9, 21, 30);
                yield return new carprice("Large", 20.1, 20.9, 21.7, 1.6, 1.59, 4.5, 18, 26);
                yield return new carprice("Midsize", 33.3, 34.3, 35.3, 2, 1.99, 4.7, 17, 26);
                yield return new carprice("Large", 34.4, 36.1, 37.8, 3.4, 3.42, 4.5, 18, 26);
                yield return new carprice("Sporty", 13.3, 14.1, 15, 1.7, 1.71, 4.1, 23, 26);
                yield return new carprice("Midsize", 14.9, 14.9, 14.9, 0, -0.02, 4.4, 19, 26);
                yield return new carprice("Compact", 13, 13.5, 14, 1, 0.99, 3.6, 24, 31);
                yield return new carprice("Midsize", 14.2, 16.3, 18.4, 4.2, 4.19, 3.7, 23, 31);
                yield return new carprice("Van", 19.5, 19.5, 19.5, 0, 0, 4.9, 18, 23);
                yield return new carprice("Large", 19.5, 20.7, 21.9, 2.4, 2.41, 4.2, 19, 28);
                yield return new carprice("Sporty", 11.4, 14.4, 17.4, 6, 6.01, 3.8, 23, 30);
                yield return new carprice("Small", 8.2, 9, 9.9, 1.7, 1.69, 2.8, 31, 41);
                yield return new carprice("Compact", 9.4, 11.1, 12.8, 3.4, 3.39, 3.7, 23, 31);
                yield return new carprice("Sporty", 14, 17.7, 21.4, 7.4, 7.4, 4.2, 19, 28);
                yield return new carprice("Midsize", 15.4, 18.5, 21.6, 6.2, 6.19, 4.3, 19, 27);
                yield return new carprice("Large", 19.4, 24.4, 29.4, 10, 10, 4.2, 19, 28);
                yield return new carprice("Small", 9.2, 11.1, 12.9, 3.7, 3.7, 3, 28, 38);
            }
        }
    }
}
