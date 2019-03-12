// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// N. L. Prater's Petrol Refinery Data
    /// </summary>

    public class petrol
    {
        public readonly int κ;
        public readonly string No;
        public readonly double SG;
        public readonly double VP;
        public readonly int V10;
        public readonly int EP;
        public readonly double Y;

        public petrol(int κ, string No, double SG, double VP, int V10, int EP, double Y)
        {
            this.κ = κ;
            this.No = No;
            this.SG = SG;
            this.VP = VP;
            this.V10 = V10;
            this.EP = EP;
            this.Y = Y;
        }

        public static IEnumerable<petrol> Data
        {
            get
            {
                yield return new petrol(1, "A", 50.8, 8.6, 190, 205, 12.2);
                yield return new petrol(2, "A", 50.8, 8.6, 190, 275, 22.3);
                yield return new petrol(3, "A", 50.8, 8.6, 190, 345, 34.7);
                yield return new petrol(4, "A", 50.8, 8.6, 190, 407, 45.7);
                yield return new petrol(5, "B", 40.8, 3.5, 210, 218, 8);
                yield return new petrol(6, "B", 40.8, 3.5, 210, 273, 13.1);
                yield return new petrol(7, "B", 40.8, 3.5, 210, 347, 26.6);
                yield return new petrol(8, "C", 40, 6.1, 217, 212, 7.4);
                yield return new petrol(9, "C", 40, 6.1, 217, 272, 18.2);
                yield return new petrol(10, "C", 40, 6.1, 217, 340, 30.4);
                yield return new petrol(11, "D", 38.4, 6.1, 220, 235, 6.9);
                yield return new petrol(12, "D", 38.4, 6.1, 220, 300, 15.2);
                yield return new petrol(13, "D", 38.4, 6.1, 220, 365, 26);
                yield return new petrol(14, "D", 38.4, 6.1, 220, 410, 33.6);
                yield return new petrol(15, "E", 40.3, 4.8, 231, 307, 14.4);
                yield return new petrol(16, "E", 40.3, 4.8, 231, 367, 26.8);
                yield return new petrol(17, "E", 40.3, 4.8, 231, 395, 34.9);
                yield return new petrol(18, "F", 32.2, 5.2, 236, 267, 10);
                yield return new petrol(19, "F", 32.2, 5.2, 236, 360, 24.8);
                yield return new petrol(20, "F", 32.2, 5.2, 236, 402, 31.7);
                yield return new petrol(21, "G", 41.3, 1.8, 267, 235, 2.8);
                yield return new petrol(22, "G", 41.3, 1.8, 267, 275, 6.4);
                yield return new petrol(23, "G", 41.3, 1.8, 267, 358, 16.1);
                yield return new petrol(24, "G", 41.3, 1.8, 267, 416, 27.8);
                yield return new petrol(25, "H", 38.1, 1.2, 274, 285, 5);
                yield return new petrol(26, "H", 38.1, 1.2, 274, 365, 17.6);
                yield return new petrol(27, "H", 38.1, 1.2, 274, 444, 32.1);
                yield return new petrol(28, "I", 32.2, 2.4, 284, 351, 14);
                yield return new petrol(29, "I", 32.2, 2.4, 284, 424, 23.2);
                yield return new petrol(30, "J", 31.8, 0.2, 316, 365, 8.5);
                yield return new petrol(31, "J", 31.8, 0.2, 316, 379, 14.7);
                yield return new petrol(32, "J", 31.8, 0.2, 316, 428, 18);
            }
        }
    }
}
