// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Flower Characteristics
    /// </summary>

    public class flower
    {
        public readonly int V1;
        public readonly int V2;
        public readonly int V3;
        public readonly int V4;
        public readonly int V5;
        public readonly int V6;
        public readonly int V7;
        public readonly int V8;

        public flower(int V1, int V2, int V3, int V4, int V5, int V6, int V7, int V8)
        {
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
            this.V6 = V6;
            this.V7 = V7;
            this.V8 = V8;
        }

        public static IEnumerable<flower> Data
        {
            get
            {
                yield return new flower(0, 1, 1, 4, 3, 15, 25, 15);
                yield return new flower(1, 0, 0, 2, 1, 3, 150, 50);
                yield return new flower(0, 1, 0, 3, 3, 1, 150, 50);
                yield return new flower(0, 0, 1, 4, 2, 16, 125, 50);
                yield return new flower(0, 1, 0, 5, 2, 2, 20, 15);
                yield return new flower(0, 1, 0, 4, 3, 12, 50, 40);
                yield return new flower(0, 0, 0, 4, 3, 13, 40, 20);
                yield return new flower(0, 0, 1, 2, 2, 7, 100, 15);
                yield return new flower(1, 1, 0, 3, 1, 4, 25, 15);
                yield return new flower(1, 1, 0, 5, 2, 14, 100, 60);
                yield return new flower(1, 1, 1, 5, 3, 8, 45, 10);
                yield return new flower(1, 1, 1, 1, 2, 9, 90, 25);
                yield return new flower(1, 1, 0, 1, 2, 6, 20, 10);
                yield return new flower(1, 1, 1, 4, 2, 11, 80, 30);
                yield return new flower(1, 0, 0, 3, 2, 10, 40, 20);
                yield return new flower(1, 0, 0, 4, 2, 18, 200, 60);
                yield return new flower(1, 0, 0, 2, 2, 17, 150, 60);
                yield return new flower(0, 0, 1, 2, 1, 5, 25, 10);
            }
        }
    }
}
