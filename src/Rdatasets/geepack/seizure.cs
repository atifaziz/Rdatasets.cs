// ReSharper disable All

namespace Rdatasets.geepack
{
    using System.Collections.Generic;

    /// <summary>
    /// Epiliptic Seizures
    /// </summary>

    public class seizure
    {
        public readonly int κ;
        public readonly int y1;
        public readonly int y2;
        public readonly int y3;
        public readonly int y4;
        public readonly int trt;
        public readonly int @base;
        public readonly int age;

        public seizure(int κ, int y1, int y2, int y3, int y4, int trt, int @base, int age)
        {
            this.κ = κ;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            this.trt = trt;
            this.@base = @base;
            this.age = age;
        }

        public static IEnumerable<seizure> Data
        {
            get
            {
                yield return new seizure(1, 5, 3, 3, 3, 0, 11, 31);
                yield return new seizure(2, 3, 5, 3, 3, 0, 11, 30);
                yield return new seizure(3, 2, 4, 0, 5, 0, 6, 25);
                yield return new seizure(4, 4, 4, 1, 4, 0, 8, 36);
                yield return new seizure(5, 7, 18, 9, 21, 0, 66, 22);
                yield return new seizure(6, 5, 2, 8, 7, 0, 27, 29);
                yield return new seizure(7, 6, 4, 0, 2, 0, 12, 31);
                yield return new seizure(8, 40, 20, 23, 12, 0, 52, 42);
                yield return new seizure(9, 5, 6, 6, 5, 0, 23, 37);
                yield return new seizure(10, 14, 13, 6, 0, 0, 10, 28);
                yield return new seizure(11, 26, 12, 6, 22, 0, 52, 36);
                yield return new seizure(12, 12, 6, 8, 5, 0, 33, 24);
                yield return new seizure(13, 4, 4, 6, 2, 0, 18, 23);
                yield return new seizure(14, 7, 9, 12, 14, 0, 42, 36);
                yield return new seizure(15, 16, 24, 10, 9, 0, 87, 26);
                yield return new seizure(16, 11, 0, 0, 5, 0, 50, 26);
                yield return new seizure(17, 0, 0, 3, 3, 0, 18, 28);
                yield return new seizure(18, 37, 29, 28, 29, 0, 111, 31);
                yield return new seizure(19, 3, 5, 2, 5, 0, 18, 32);
                yield return new seizure(20, 3, 0, 6, 7, 0, 20, 21);
                yield return new seizure(21, 3, 4, 3, 4, 0, 12, 29);
                yield return new seizure(22, 3, 4, 3, 4, 0, 9, 21);
                yield return new seizure(23, 2, 3, 3, 5, 0, 17, 32);
                yield return new seizure(24, 8, 12, 2, 8, 0, 28, 25);
                yield return new seizure(25, 18, 24, 76, 25, 0, 55, 30);
                yield return new seizure(26, 2, 1, 2, 1, 0, 9, 40);
                yield return new seizure(27, 3, 1, 4, 2, 0, 10, 19);
                yield return new seizure(28, 13, 15, 13, 12, 0, 47, 22);
                yield return new seizure(29, 11, 14, 9, 8, 1, 76, 18);
                yield return new seizure(30, 8, 7, 9, 4, 1, 38, 32);
                yield return new seizure(31, 0, 4, 3, 0, 1, 19, 20);
                yield return new seizure(32, 3, 6, 1, 3, 1, 10, 20);
                yield return new seizure(33, 2, 6, 7, 4, 1, 19, 18);
                yield return new seizure(34, 4, 3, 1, 3, 1, 24, 24);
                yield return new seizure(35, 22, 17, 19, 16, 1, 31, 30);
                yield return new seizure(36, 5, 4, 7, 4, 1, 14, 35);
                yield return new seizure(37, 2, 4, 0, 4, 1, 11, 57);
                yield return new seizure(38, 3, 7, 7, 7, 1, 67, 20);
                yield return new seizure(39, 4, 18, 2, 5, 1, 41, 22);
                yield return new seizure(40, 2, 1, 1, 0, 1, 7, 28);
                yield return new seizure(41, 0, 2, 4, 0, 1, 22, 23);
                yield return new seizure(42, 5, 4, 0, 3, 1, 13, 40);
                yield return new seizure(43, 11, 14, 25, 15, 1, 46, 43);
                yield return new seizure(44, 10, 5, 3, 8, 1, 36, 21);
                yield return new seizure(45, 19, 7, 6, 7, 1, 38, 35);
                yield return new seizure(46, 1, 1, 2, 4, 1, 7, 25);
                yield return new seizure(47, 6, 10, 8, 8, 1, 36, 26);
                yield return new seizure(48, 2, 1, 0, 0, 1, 11, 25);
                yield return new seizure(49, 102, 65, 72, 63, 1, 151, 22);
                yield return new seizure(50, 4, 3, 2, 4, 1, 22, 32);
                yield return new seizure(51, 8, 6, 5, 7, 1, 42, 25);
                yield return new seizure(52, 1, 3, 1, 5, 1, 32, 35);
                yield return new seizure(53, 18, 11, 28, 13, 1, 56, 21);
                yield return new seizure(54, 6, 3, 4, 0, 1, 24, 41);
                yield return new seizure(55, 3, 5, 4, 3, 1, 16, 32);
                yield return new seizure(56, 1, 23, 19, 8, 1, 22, 26);
                yield return new seizure(57, 2, 3, 0, 1, 1, 25, 21);
                yield return new seizure(58, 0, 0, 0, 0, 1, 13, 36);
                yield return new seizure(59, 1, 4, 3, 2, 1, 12, 37);
            }
        }
    }
}
