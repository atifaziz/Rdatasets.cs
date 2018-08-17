// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// FruitFlies
    /// </summary>

    public class FruitFlies
    {
        public readonly int ID;
        public readonly int Partners;
        public readonly int Type;
        public readonly int Longevity;
        public readonly double Thorax;
        public readonly int Sleep;
        public readonly string Treatment;

        public FruitFlies(int ID, int Partners, int Type, int Longevity, double Thorax, int Sleep, string Treatment)
        {
            this.ID = ID;
            this.Partners = Partners;
            this.Type = Type;
            this.Longevity = Longevity;
            this.Thorax = Thorax;
            this.Sleep = Sleep;
            this.Treatment = Treatment;
        }

        public static IEnumerable<FruitFlies> Data
        {
            get
            {
                yield return new FruitFlies(1, 8, 0, 35, 0.64, 22, "8 pregnant");
                yield return new FruitFlies(2, 8, 0, 37, 0.68, 9, "8 pregnant");
                yield return new FruitFlies(3, 8, 0, 49, 0.68, 49, "8 pregnant");
                yield return new FruitFlies(4, 8, 0, 46, 0.72, 1, "8 pregnant");
                yield return new FruitFlies(5, 8, 0, 63, 0.72, 23, "8 pregnant");
                yield return new FruitFlies(6, 8, 0, 39, 0.76, 83, "8 pregnant");
                yield return new FruitFlies(7, 8, 0, 46, 0.76, 23, "8 pregnant");
                yield return new FruitFlies(8, 8, 0, 56, 0.76, 15, "8 pregnant");
                yield return new FruitFlies(9, 8, 0, 63, 0.76, 9, "8 pregnant");
                yield return new FruitFlies(10, 8, 0, 65, 0.76, 81, "8 pregnant");
                yield return new FruitFlies(11, 8, 0, 56, 0.8, 12, "8 pregnant");
                yield return new FruitFlies(12, 8, 0, 65, 0.8, 15, "8 pregnant");
                yield return new FruitFlies(13, 8, 0, 70, 0.8, 37, "8 pregnant");
                yield return new FruitFlies(14, 8, 0, 63, 0.84, 24, "8 pregnant");
                yield return new FruitFlies(15, 8, 0, 65, 0.84, 26, "8 pregnant");
                yield return new FruitFlies(16, 8, 0, 70, 0.84, 17, "8 pregnant");
                yield return new FruitFlies(17, 8, 0, 77, 0.84, 14, "8 pregnant");
                yield return new FruitFlies(18, 8, 0, 81, 0.84, 14, "8 pregnant");
                yield return new FruitFlies(19, 8, 0, 86, 0.84, 6, "8 pregnant");
                yield return new FruitFlies(20, 8, 0, 70, 0.88, 25, "8 pregnant");
                yield return new FruitFlies(21, 8, 0, 70, 0.88, 18, "8 pregnant");
                yield return new FruitFlies(22, 8, 0, 77, 0.92, 26, "8 pregnant");
                yield return new FruitFlies(23, 8, 0, 77, 0.92, 24, "8 pregnant");
                yield return new FruitFlies(24, 8, 0, 81, 0.92, 29, "8 pregnant");
                yield return new FruitFlies(25, 8, 0, 77, 0.94, 27, "8 pregnant");
                yield return new FruitFlies(1, 0, 9, 40, 0.64, 18, "none");
                yield return new FruitFlies(2, 0, 9, 37, 0.7, 6, "none");
                yield return new FruitFlies(3, 0, 9, 44, 0.72, 19, "none");
                yield return new FruitFlies(4, 0, 9, 47, 0.72, 7, "none");
                yield return new FruitFlies(5, 0, 9, 47, 0.72, 16, "none");
                yield return new FruitFlies(6, 0, 9, 47, 0.76, 13, "none");
                yield return new FruitFlies(7, 0, 9, 68, 0.78, 35, "none");
                yield return new FruitFlies(8, 0, 9, 47, 0.8, 2, "none");
                yield return new FruitFlies(9, 0, 9, 54, 0.84, 35, "none");
                yield return new FruitFlies(10, 0, 9, 61, 0.84, 6, "none");
                yield return new FruitFlies(11, 0, 9, 71, 0.84, 15, "none");
                yield return new FruitFlies(12, 0, 9, 75, 0.84, 14, "none");
                yield return new FruitFlies(13, 0, 9, 89, 0.84, 18, "none");
                yield return new FruitFlies(14, 0, 9, 58, 0.88, 50, "none");
                yield return new FruitFlies(15, 0, 9, 59, 0.88, 25, "none");
                yield return new FruitFlies(16, 0, 9, 62, 0.88, 10, "none");
                yield return new FruitFlies(17, 0, 9, 79, 0.88, 33, "none");
                yield return new FruitFlies(18, 0, 9, 96, 0.88, 43, "none");
                yield return new FruitFlies(19, 0, 9, 58, 0.92, 35, "none");
                yield return new FruitFlies(20, 0, 9, 62, 0.92, 17, "none");
                yield return new FruitFlies(21, 0, 9, 70, 0.92, 27, "none");
                yield return new FruitFlies(22, 0, 9, 72, 0.92, 22, "none");
                yield return new FruitFlies(23, 0, 9, 75, 0.92, 16, "none");
                yield return new FruitFlies(24, 0, 9, 96, 0.92, 20, "none");
                yield return new FruitFlies(25, 0, 9, 75, 0.94, 37, "none");
                yield return new FruitFlies(1, 1, 0, 46, 0.64, 23, "1 pregnant");
                yield return new FruitFlies(2, 1, 0, 42, 0.68, 4, "1 pregnant");
                yield return new FruitFlies(3, 1, 0, 65, 0.72, 20, "1 pregnant");
                yield return new FruitFlies(4, 1, 0, 46, 0.76, 42, "1 pregnant");
                yield return new FruitFlies(5, 1, 0, 58, 0.76, 9, "1 pregnant");
                yield return new FruitFlies(6, 1, 0, 42, 0.8, 32, "1 pregnant");
                yield return new FruitFlies(7, 1, 0, 48, 0.8, 66, "1 pregnant");
                yield return new FruitFlies(8, 1, 0, 58, 0.8, 28, "1 pregnant");
                yield return new FruitFlies(9, 1, 0, 50, 0.82, 10, "1 pregnant");
                yield return new FruitFlies(10, 1, 0, 80, 0.82, 4, "1 pregnant");
                yield return new FruitFlies(11, 1, 0, 63, 0.84, 12, "1 pregnant");
                yield return new FruitFlies(12, 1, 0, 65, 0.84, 17, "1 pregnant");
                yield return new FruitFlies(13, 1, 0, 70, 0.84, 12, "1 pregnant");
                yield return new FruitFlies(14, 1, 0, 70, 0.84, 23, "1 pregnant");
                yield return new FruitFlies(15, 1, 0, 72, 0.84, 40, "1 pregnant");
                yield return new FruitFlies(16, 1, 0, 97, 0.84, 18, "1 pregnant");
                yield return new FruitFlies(17, 1, 0, 46, 0.88, 10, "1 pregnant");
                yield return new FruitFlies(18, 1, 0, 56, 0.88, 38, "1 pregnant");
                yield return new FruitFlies(19, 1, 0, 70, 0.88, 7, "1 pregnant");
                yield return new FruitFlies(20, 1, 0, 70, 0.88, 23, "1 pregnant");
                yield return new FruitFlies(21, 1, 0, 72, 0.88, 36, "1 pregnant");
                yield return new FruitFlies(22, 1, 0, 76, 0.88, 9, "1 pregnant");
                yield return new FruitFlies(23, 1, 0, 90, 0.88, 21, "1 pregnant");
                yield return new FruitFlies(24, 1, 0, 76, 0.92, 62, "1 pregnant");
                yield return new FruitFlies(25, 1, 0, 92, 0.92, 36, "1 pregnant");
                yield return new FruitFlies(1, 1, 1, 21, 0.68, 23, "1 virgin");
                yield return new FruitFlies(2, 1, 1, 40, 0.68, 62, "1 virgin");
                yield return new FruitFlies(3, 1, 1, 44, 0.72, 28, "1 virgin");
                yield return new FruitFlies(4, 1, 1, 54, 0.76, 18, "1 virgin");
                yield return new FruitFlies(5, 1, 1, 36, 0.78, 10, "1 virgin");
                yield return new FruitFlies(6, 1, 1, 40, 0.8, 28, "1 virgin");
                yield return new FruitFlies(7, 1, 1, 56, 0.8, 22, "1 virgin");
                yield return new FruitFlies(8, 1, 1, 60, 0.8, 29, "1 virgin");
                yield return new FruitFlies(9, 1, 1, 48, 0.84, 15, "1 virgin");
                yield return new FruitFlies(10, 1, 1, 53, 0.84, 73, "1 virgin");
                yield return new FruitFlies(11, 1, 1, 60, 0.84, 10, "1 virgin");
                yield return new FruitFlies(12, 1, 1, 60, 0.84, 5, "1 virgin");
                yield return new FruitFlies(13, 1, 1, 65, 0.84, 13, "1 virgin");
                yield return new FruitFlies(14, 1, 1, 68, 0.84, 27, "1 virgin");
                yield return new FruitFlies(15, 1, 1, 60, 0.88, 20, "1 virgin");
                yield return new FruitFlies(16, 1, 1, 81, 0.88, 21, "1 virgin");
                yield return new FruitFlies(17, 1, 1, 81, 0.88, 12, "1 virgin");
                yield return new FruitFlies(18, 1, 1, 48, 0.9, 49, "1 virgin");
                yield return new FruitFlies(19, 1, 1, 48, 0.9, 17, "1 virgin");
                yield return new FruitFlies(20, 1, 1, 56, 0.9, 22, "1 virgin");
                yield return new FruitFlies(21, 1, 1, 68, 0.9, 71, "1 virgin");
                yield return new FruitFlies(22, 1, 1, 75, 0.9, 17, "1 virgin");
                yield return new FruitFlies(23, 1, 1, 81, 0.9, 10, "1 virgin");
                yield return new FruitFlies(24, 1, 1, 48, 0.92, 24, "1 virgin");
                yield return new FruitFlies(25, 1, 1, 68, 0.92, 18, "1 virgin");
                yield return new FruitFlies(1, 8, 1, 16, 0.64, 34, "8 virgin");
                yield return new FruitFlies(2, 8, 1, 19, 0.64, 6, "8 virgin");
                yield return new FruitFlies(3, 8, 1, 19, 0.68, 4, "8 virgin");
                yield return new FruitFlies(4, 8, 1, 32, 0.72, 22, "8 virgin");
                yield return new FruitFlies(5, 8, 1, 33, 0.72, 28, "8 virgin");
                yield return new FruitFlies(6, 8, 1, 33, 0.74, 31, "8 virgin");
                yield return new FruitFlies(7, 8, 1, 30, 0.76, 16, "8 virgin");
                yield return new FruitFlies(8, 8, 1, 42, 0.76, 27, "8 virgin");
                yield return new FruitFlies(9, 8, 1, 42, 0.76, 8, "8 virgin");
                yield return new FruitFlies(10, 8, 1, 33, 0.78, 32, "8 virgin");
                yield return new FruitFlies(11, 8, 1, 26, 0.8, 20, "8 virgin");
                yield return new FruitFlies(12, 8, 1, 30, 0.8, 35, "8 virgin");
                yield return new FruitFlies(13, 8, 1, 40, 0.82, 12, "8 virgin");
                yield return new FruitFlies(14, 8, 1, 54, 0.82, 14, "8 virgin");
                yield return new FruitFlies(15, 8, 1, 34, 0.84, 17, "8 virgin");
                yield return new FruitFlies(16, 8, 1, 34, 0.84, 29, "8 virgin");
                yield return new FruitFlies(17, 8, 1, 47, 0.84, 31, "8 virgin");
                yield return new FruitFlies(18, 8, 1, 47, 0.84, 6, "8 virgin");
                yield return new FruitFlies(19, 8, 1, 42, 0.88, 30, "8 virgin");
                yield return new FruitFlies(20, 8, 1, 47, 0.88, 27, "8 virgin");
                yield return new FruitFlies(21, 8, 1, 54, 0.88, 40, "8 virgin");
                yield return new FruitFlies(22, 8, 1, 54, 0.88, 19, "8 virgin");
                yield return new FruitFlies(23, 8, 1, 56, 0.88, 8, "8 virgin");
                yield return new FruitFlies(24, 8, 1, 60, 0.88, 8, "8 virgin");
                yield return new FruitFlies(25, 8, 1, 44, 0.92, 15, "8 virgin");
            }
        }
    }
}
