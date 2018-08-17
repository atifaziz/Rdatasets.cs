// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Perch
    /// </summary>

    public class Perch
    {
        public readonly int Obs;
        public readonly double Weight;
        public readonly double Length;
        public readonly double Width;

        public Perch(int Obs, double Weight, double Length, double Width)
        {
            this.Obs = Obs;
            this.Weight = Weight;
            this.Length = Length;
            this.Width = Width;
        }

        public static IEnumerable<Perch> Data
        {
            get
            {
                yield return new Perch(104, 5.9, 8.8, 1.4);
                yield return new Perch(105, 32, 14.7, 2);
                yield return new Perch(106, 40, 16, 2.4);
                yield return new Perch(107, 51.5, 17.2, 2.6);
                yield return new Perch(108, 70, 18.5, 2.9);
                yield return new Perch(109, 100, 19.2, 3.3);
                yield return new Perch(110, 78, 19.4, 3.1);
                yield return new Perch(111, 80, 20.2, 3.1);
                yield return new Perch(112, 85, 20.8, 3);
                yield return new Perch(113, 85, 21, 2.8);
                yield return new Perch(114, 110, 22.5, 3.6);
                yield return new Perch(115, 115, 22.5, 3.3);
                yield return new Perch(116, 125, 22.5, 3.7);
                yield return new Perch(117, 130, 22.8, 3.5);
                yield return new Perch(118, 120, 23.5, 3.4);
                yield return new Perch(119, 120, 23.5, 3.5);
                yield return new Perch(120, 130, 23.5, 3.5);
                yield return new Perch(121, 135, 23.5, 3.5);
                yield return new Perch(122, 110, 23.5, 4);
                yield return new Perch(123, 130, 24, 3.6);
                yield return new Perch(124, 150, 24, 3.6);
                yield return new Perch(125, 145, 24.2, 3.6);
                yield return new Perch(126, 150, 24.5, 3.6);
                yield return new Perch(127, 170, 25, 3.7);
                yield return new Perch(128, 225, 25.5, 3.7);
                yield return new Perch(129, 145, 25.5, 3.8);
                yield return new Perch(130, 188, 26.2, 4.2);
                yield return new Perch(131, 180, 26.5, 3.7);
                yield return new Perch(132, 197, 27, 4.2);
                yield return new Perch(133, 218, 28, 4.1);
                yield return new Perch(134, 300, 28.7, 5.1);
                yield return new Perch(135, 260, 28.9, 4.3);
                yield return new Perch(136, 265, 28.9, 4.3);
                yield return new Perch(137, 250, 28.9, 4.6);
                yield return new Perch(138, 250, 29.4, 4.2);
                yield return new Perch(139, 300, 30.1, 4.6);
                yield return new Perch(140, 320, 31.6, 4.8);
                yield return new Perch(141, 514, 34, 6);
                yield return new Perch(142, 556, 36.5, 6.4);
                yield return new Perch(143, 840, 37.3, 7.8);
                yield return new Perch(144, 685, 39, 6.9);
                yield return new Perch(145, 700, 38.3, 6.7);
                yield return new Perch(146, 700, 39.4, 6.3);
                yield return new Perch(147, 690, 39.3, 6.4);
                yield return new Perch(148, 900, 41.4, 7.5);
                yield return new Perch(149, 650, 41.4, 6);
                yield return new Perch(150, 820, 41.3, 7.4);
                yield return new Perch(151, 850, 42.3, 7.1);
                yield return new Perch(152, 900, 42.5, 7.2);
                yield return new Perch(153, 1015, 42.4, 7.5);
                yield return new Perch(154, 820, 42.5, 6.6);
                yield return new Perch(155, 1100, 44.6, 6.9);
                yield return new Perch(156, 1000, 45.2, 7.3);
                yield return new Perch(157, 1100, 45.5, 7.4);
                yield return new Perch(158, 1000, 46, 8.1);
                yield return new Perch(159, 1000, 46.6, 7.6);
            }
        }
    }
}
