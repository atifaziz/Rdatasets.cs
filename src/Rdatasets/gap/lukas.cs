// ReSharper disable All

namespace Rdatasets.gap
{
    using System.Collections.Generic;

    /// <summary>
    /// An example pedigree
    /// </summary>

    public class lukas
    {
        public readonly int id;
        public readonly int father;
        public readonly int mother;
        public readonly string sex;

        public lukas(int id, int father, int mother, string sex)
        {
            this.id = id;
            this.father = father;
            this.mother = mother;
            this.sex = sex;
        }

        public static IEnumerable<lukas> Data
        {
            get
            {
                yield return new lukas(2, 0, 0, "F");
                yield return new lukas(88, 0, 0, "F");
                yield return new lukas(8, 0, 0, "F");
                yield return new lukas(10, 0, 0, "F");
                yield return new lukas(20, 0, 0, "F");
                yield return new lukas(22, 0, 0, "F");
                yield return new lukas(24, 0, 0, "F");
                yield return new lukas(26, 0, 0, "F");
                yield return new lukas(18, 0, 0, "F");
                yield return new lukas(34, 0, 0, "F");
                yield return new lukas(12, 0, 0, "F");
                yield return new lukas(50, 0, 0, "F");
                yield return new lukas(56, 0, 0, "F");
                yield return new lukas(64, 0, 0, "F");
                yield return new lukas(66, 0, 0, "F");
                yield return new lukas(68, 0, 0, "F");
                yield return new lukas(70, 0, 0, "F");
                yield return new lukas(72, 0, 0, "F");
                yield return new lukas(1, 0, 0, "M");
                yield return new lukas(4, 0, 0, "M");
                yield return new lukas(6, 0, 0, "M");
                yield return new lukas(99, 0, 0, "M");
                yield return new lukas(28, 0, 0, "M");
                yield return new lukas(30, 0, 0, "M");
                yield return new lukas(36, 0, 0, "M");
                yield return new lukas(38, 0, 0, "M");
                yield return new lukas(40, 0, 0, "M");
                yield return new lukas(42, 0, 0, "M");
                yield return new lukas(44, 0, 0, "M");
                yield return new lukas(46, 0, 0, "M");
                yield return new lukas(52, 0, 0, "M");
                yield return new lukas(54, 0, 0, "M");
                yield return new lukas(48, 0, 0, "M");
                yield return new lukas(78, 0, 0, "M");
                yield return new lukas(60, 0, 0, "M");
                yield return new lukas(62, 0, 0, "M");
                yield return new lukas(80, 0, 0, "M");
                yield return new lukas(82, 0, 0, "M");
                yield return new lukas(3, 1, 2, "F");
                yield return new lukas(5, 4, 3, "F");
                yield return new lukas(7, 4, 3, "M");
                yield return new lukas(9, 4, 3, "M");
                yield return new lukas(11, 6, 5, "M");
                yield return new lukas(13, 6, 5, "M");
                yield return new lukas(15, 6, 5, "F");
                yield return new lukas(14, 99, 88, "F");
                yield return new lukas(16, 99, 88, "M");
                yield return new lukas(17, 7, 8, "M");
                yield return new lukas(19, 9, 10, "M");
                yield return new lukas(21, 19, 20, "M");
                yield return new lukas(23, 21, 22, "M");
                yield return new lukas(25, 23, 24, "M");
                yield return new lukas(27, 25, 26, "F");
                yield return new lukas(29, 28, 27, "F");
                yield return new lukas(31, 30, 29, "F");
                yield return new lukas(33, 17, 18, "M");
                yield return new lukas(35, 33, 34, "F");
                yield return new lukas(37, 36, 35, "F");
                yield return new lukas(39, 38, 37, "F");
                yield return new lukas(41, 40, 39, "F");
                yield return new lukas(43, 42, 41, "F");
                yield return new lukas(45, 44, 43, "F");
                yield return new lukas(47, 46, 45, "F");
                yield return new lukas(49, 11, 12, "M");
                yield return new lukas(51, 49, 50, "F");
                yield return new lukas(53, 52, 51, "F");
                yield return new lukas(55, 54, 53, "M");
                yield return new lukas(57, 55, 56, "M");
                yield return new lukas(73, 57, 58, "M");
                yield return new lukas(74, 32, 31, "F");
                yield return new lukas(75, 73, 74, "M");
                yield return new lukas(76, 48, 47, "F");
                yield return new lukas(77, 75, 76, "F");
                yield return new lukas(79, 78, 77, "F");
                yield return new lukas(59, 13, 14, "F");
                yield return new lukas(61, 60, 59, "F");
                yield return new lukas(63, 62, 61, "M");
                yield return new lukas(65, 63, 64, "M");
                yield return new lukas(32, 65, 66, "M");
                yield return new lukas(67, 16, 15, "M");
                yield return new lukas(69, 67, 68, "M");
                yield return new lukas(71, 69, 70, "M");
                yield return new lukas(58, 71, 72, "F");
                yield return new lukas(81, 80, 79, "F");
                yield return new lukas(83, 82, 81, "M");
            }
        }
    }
}
