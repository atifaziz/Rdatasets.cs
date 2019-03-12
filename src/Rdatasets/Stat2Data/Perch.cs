// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Perch
    /// </summary>

    public class Perch
    {
        public readonly int κ;
        public readonly int Obs;
        public readonly double Weight;
        public readonly double Length;
        public readonly double Width;

        public Perch(int κ, int Obs, double Weight, double Length, double Width)
        {
            this.κ = κ;
            this.Obs = Obs;
            this.Weight = Weight;
            this.Length = Length;
            this.Width = Width;
        }

        public static IEnumerable<Perch> Data
        {
            get
            {
                yield return new Perch(1, 104, 5.9, 8.8, 1.4);
                yield return new Perch(2, 105, 32, 14.7, 2);
                yield return new Perch(3, 106, 40, 16, 2.4);
                yield return new Perch(4, 107, 51.5, 17.2, 2.6);
                yield return new Perch(5, 108, 70, 18.5, 2.9);
                yield return new Perch(6, 109, 100, 19.2, 3.3);
                yield return new Perch(7, 110, 78, 19.4, 3.1);
                yield return new Perch(8, 111, 80, 20.2, 3.1);
                yield return new Perch(9, 112, 85, 20.8, 3);
                yield return new Perch(10, 113, 85, 21, 2.8);
                yield return new Perch(11, 114, 110, 22.5, 3.6);
                yield return new Perch(12, 115, 115, 22.5, 3.3);
                yield return new Perch(13, 116, 125, 22.5, 3.7);
                yield return new Perch(14, 117, 130, 22.8, 3.5);
                yield return new Perch(15, 118, 120, 23.5, 3.4);
                yield return new Perch(16, 119, 120, 23.5, 3.5);
                yield return new Perch(17, 120, 130, 23.5, 3.5);
                yield return new Perch(18, 121, 135, 23.5, 3.5);
                yield return new Perch(19, 122, 110, 23.5, 4);
                yield return new Perch(20, 123, 130, 24, 3.6);
                yield return new Perch(21, 124, 150, 24, 3.6);
                yield return new Perch(22, 125, 145, 24.2, 3.6);
                yield return new Perch(23, 126, 150, 24.5, 3.6);
                yield return new Perch(24, 127, 170, 25, 3.7);
                yield return new Perch(25, 128, 225, 25.5, 3.7);
                yield return new Perch(26, 129, 145, 25.5, 3.8);
                yield return new Perch(27, 130, 188, 26.2, 4.2);
                yield return new Perch(28, 131, 180, 26.5, 3.7);
                yield return new Perch(29, 132, 197, 27, 4.2);
                yield return new Perch(30, 133, 218, 28, 4.1);
                yield return new Perch(31, 134, 300, 28.7, 5.1);
                yield return new Perch(32, 135, 260, 28.9, 4.3);
                yield return new Perch(33, 136, 265, 28.9, 4.3);
                yield return new Perch(34, 137, 250, 28.9, 4.6);
                yield return new Perch(35, 138, 250, 29.4, 4.2);
                yield return new Perch(36, 139, 300, 30.1, 4.6);
                yield return new Perch(37, 140, 320, 31.6, 4.8);
                yield return new Perch(38, 141, 514, 34, 6);
                yield return new Perch(39, 142, 556, 36.5, 6.4);
                yield return new Perch(40, 143, 840, 37.3, 7.8);
                yield return new Perch(41, 144, 685, 39, 6.9);
                yield return new Perch(42, 145, 700, 38.3, 6.7);
                yield return new Perch(43, 146, 700, 39.4, 6.3);
                yield return new Perch(44, 147, 690, 39.3, 6.4);
                yield return new Perch(45, 148, 900, 41.4, 7.5);
                yield return new Perch(46, 149, 650, 41.4, 6);
                yield return new Perch(47, 150, 820, 41.3, 7.4);
                yield return new Perch(48, 151, 850, 42.3, 7.1);
                yield return new Perch(49, 152, 900, 42.5, 7.2);
                yield return new Perch(50, 153, 1015, 42.4, 7.5);
                yield return new Perch(51, 154, 820, 42.5, 6.6);
                yield return new Perch(52, 155, 1100, 44.6, 6.9);
                yield return new Perch(53, 156, 1000, 45.2, 7.3);
                yield return new Perch(54, 157, 1100, 45.5, 7.4);
                yield return new Perch(55, 158, 1000, 46, 8.1);
                yield return new Perch(56, 159, 1000, 46.6, 7.6);
            }
        }
    }
}
