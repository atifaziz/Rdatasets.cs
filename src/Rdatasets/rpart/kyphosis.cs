// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Data on Children who have had Corrective Spinal Surgery
    /// </summary>

    public class kyphosis
    {
        public readonly int κ;
        public readonly string Kyphosis;
        public readonly int Age;
        public readonly int Number;
        public readonly int Start;

        public kyphosis(int κ, string Kyphosis, int Age, int Number, int Start)
        {
            this.κ = κ;
            this.Kyphosis = Kyphosis;
            this.Age = Age;
            this.Number = Number;
            this.Start = Start;
        }

        public static IEnumerable<kyphosis> Data
        {
            get
            {
                yield return new kyphosis(1, "absent", 71, 3, 5);
                yield return new kyphosis(2, "absent", 158, 3, 14);
                yield return new kyphosis(3, "present", 128, 4, 5);
                yield return new kyphosis(4, "absent", 2, 5, 1);
                yield return new kyphosis(5, "absent", 1, 4, 15);
                yield return new kyphosis(6, "absent", 1, 2, 16);
                yield return new kyphosis(7, "absent", 61, 2, 17);
                yield return new kyphosis(8, "absent", 37, 3, 16);
                yield return new kyphosis(9, "absent", 113, 2, 16);
                yield return new kyphosis(10, "present", 59, 6, 12);
                yield return new kyphosis(11, "present", 82, 5, 14);
                yield return new kyphosis(12, "absent", 148, 3, 16);
                yield return new kyphosis(13, "absent", 18, 5, 2);
                yield return new kyphosis(14, "absent", 1, 4, 12);
                yield return new kyphosis(15, "absent", 168, 3, 18);
                yield return new kyphosis(16, "absent", 1, 3, 16);
                yield return new kyphosis(17, "absent", 78, 6, 15);
                yield return new kyphosis(18, "absent", 175, 5, 13);
                yield return new kyphosis(19, "absent", 80, 5, 16);
                yield return new kyphosis(20, "absent", 27, 4, 9);
                yield return new kyphosis(21, "absent", 22, 2, 16);
                yield return new kyphosis(22, "present", 105, 6, 5);
                yield return new kyphosis(23, "present", 96, 3, 12);
                yield return new kyphosis(24, "absent", 131, 2, 3);
                yield return new kyphosis(25, "present", 15, 7, 2);
                yield return new kyphosis(26, "absent", 9, 5, 13);
                yield return new kyphosis(27, "absent", 8, 3, 6);
                yield return new kyphosis(28, "absent", 100, 3, 14);
                yield return new kyphosis(29, "absent", 4, 3, 16);
                yield return new kyphosis(30, "absent", 151, 2, 16);
                yield return new kyphosis(31, "absent", 31, 3, 16);
                yield return new kyphosis(32, "absent", 125, 2, 11);
                yield return new kyphosis(33, "absent", 130, 5, 13);
                yield return new kyphosis(34, "absent", 112, 3, 16);
                yield return new kyphosis(35, "absent", 140, 5, 11);
                yield return new kyphosis(36, "absent", 93, 3, 16);
                yield return new kyphosis(37, "absent", 1, 3, 9);
                yield return new kyphosis(38, "present", 52, 5, 6);
                yield return new kyphosis(39, "absent", 20, 6, 9);
                yield return new kyphosis(40, "present", 91, 5, 12);
                yield return new kyphosis(41, "present", 73, 5, 1);
                yield return new kyphosis(42, "absent", 35, 3, 13);
                yield return new kyphosis(43, "absent", 143, 9, 3);
                yield return new kyphosis(44, "absent", 61, 4, 1);
                yield return new kyphosis(45, "absent", 97, 3, 16);
                yield return new kyphosis(46, "present", 139, 3, 10);
                yield return new kyphosis(47, "absent", 136, 4, 15);
                yield return new kyphosis(48, "absent", 131, 5, 13);
                yield return new kyphosis(49, "present", 121, 3, 3);
                yield return new kyphosis(50, "absent", 177, 2, 14);
                yield return new kyphosis(51, "absent", 68, 5, 10);
                yield return new kyphosis(52, "absent", 9, 2, 17);
                yield return new kyphosis(53, "present", 139, 10, 6);
                yield return new kyphosis(54, "absent", 2, 2, 17);
                yield return new kyphosis(55, "absent", 140, 4, 15);
                yield return new kyphosis(56, "absent", 72, 5, 15);
                yield return new kyphosis(57, "absent", 2, 3, 13);
                yield return new kyphosis(58, "present", 120, 5, 8);
                yield return new kyphosis(59, "absent", 51, 7, 9);
                yield return new kyphosis(60, "absent", 102, 3, 13);
                yield return new kyphosis(61, "present", 130, 4, 1);
                yield return new kyphosis(62, "present", 114, 7, 8);
                yield return new kyphosis(63, "absent", 81, 4, 1);
                yield return new kyphosis(64, "absent", 118, 3, 16);
                yield return new kyphosis(65, "absent", 118, 4, 16);
                yield return new kyphosis(66, "absent", 17, 4, 10);
                yield return new kyphosis(67, "absent", 195, 2, 17);
                yield return new kyphosis(68, "absent", 159, 4, 13);
                yield return new kyphosis(69, "absent", 18, 4, 11);
                yield return new kyphosis(70, "absent", 15, 5, 16);
                yield return new kyphosis(71, "absent", 158, 5, 14);
                yield return new kyphosis(72, "absent", 127, 4, 12);
                yield return new kyphosis(73, "absent", 87, 4, 16);
                yield return new kyphosis(74, "absent", 206, 4, 10);
                yield return new kyphosis(75, "absent", 11, 3, 15);
                yield return new kyphosis(76, "absent", 178, 4, 15);
                yield return new kyphosis(77, "present", 157, 3, 13);
                yield return new kyphosis(78, "absent", 26, 7, 13);
                yield return new kyphosis(79, "absent", 120, 2, 13);
                yield return new kyphosis(80, "present", 42, 7, 6);
                yield return new kyphosis(81, "absent", 36, 4, 13);
            }
        }
    }
}
