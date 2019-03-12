// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Arthritis Treatment Data
    /// </summary>

    public class Arthritis
    {
        public readonly int κ;
        public readonly int ID;
        public readonly string Treatment;
        public readonly string Sex;
        public readonly int Age;
        public readonly string Improved;

        public Arthritis(int κ, int ID, string Treatment, string Sex, int Age, string Improved)
        {
            this.κ = κ;
            this.ID = ID;
            this.Treatment = Treatment;
            this.Sex = Sex;
            this.Age = Age;
            this.Improved = Improved;
        }

        public static IEnumerable<Arthritis> Data
        {
            get
            {
                yield return new Arthritis(1, 57, "Treated", "Male", 27, "Some");
                yield return new Arthritis(2, 46, "Treated", "Male", 29, "None");
                yield return new Arthritis(3, 77, "Treated", "Male", 30, "None");
                yield return new Arthritis(4, 17, "Treated", "Male", 32, "Marked");
                yield return new Arthritis(5, 36, "Treated", "Male", 46, "Marked");
                yield return new Arthritis(6, 23, "Treated", "Male", 58, "Marked");
                yield return new Arthritis(7, 75, "Treated", "Male", 59, "None");
                yield return new Arthritis(8, 39, "Treated", "Male", 59, "Marked");
                yield return new Arthritis(9, 33, "Treated", "Male", 63, "None");
                yield return new Arthritis(10, 55, "Treated", "Male", 63, "None");
                yield return new Arthritis(11, 30, "Treated", "Male", 64, "None");
                yield return new Arthritis(12, 5, "Treated", "Male", 64, "Some");
                yield return new Arthritis(13, 63, "Treated", "Male", 69, "None");
                yield return new Arthritis(14, 83, "Treated", "Male", 70, "Marked");
                yield return new Arthritis(15, 66, "Treated", "Female", 23, "None");
                yield return new Arthritis(16, 40, "Treated", "Female", 32, "None");
                yield return new Arthritis(17, 6, "Treated", "Female", 37, "Some");
                yield return new Arthritis(18, 7, "Treated", "Female", 41, "None");
                yield return new Arthritis(19, 72, "Treated", "Female", 41, "Marked");
                yield return new Arthritis(20, 37, "Treated", "Female", 48, "None");
                yield return new Arthritis(21, 82, "Treated", "Female", 48, "Marked");
                yield return new Arthritis(22, 53, "Treated", "Female", 55, "Marked");
                yield return new Arthritis(23, 79, "Treated", "Female", 55, "Marked");
                yield return new Arthritis(24, 26, "Treated", "Female", 56, "Marked");
                yield return new Arthritis(25, 28, "Treated", "Female", 57, "Marked");
                yield return new Arthritis(26, 60, "Treated", "Female", 57, "Marked");
                yield return new Arthritis(27, 22, "Treated", "Female", 57, "Marked");
                yield return new Arthritis(28, 27, "Treated", "Female", 58, "None");
                yield return new Arthritis(29, 2, "Treated", "Female", 59, "Marked");
                yield return new Arthritis(30, 59, "Treated", "Female", 59, "Marked");
                yield return new Arthritis(31, 62, "Treated", "Female", 60, "Marked");
                yield return new Arthritis(32, 84, "Treated", "Female", 61, "Marked");
                yield return new Arthritis(33, 64, "Treated", "Female", 62, "Some");
                yield return new Arthritis(34, 34, "Treated", "Female", 62, "Marked");
                yield return new Arthritis(35, 58, "Treated", "Female", 66, "Marked");
                yield return new Arthritis(36, 13, "Treated", "Female", 67, "Marked");
                yield return new Arthritis(37, 61, "Treated", "Female", 68, "Some");
                yield return new Arthritis(38, 65, "Treated", "Female", 68, "Marked");
                yield return new Arthritis(39, 11, "Treated", "Female", 69, "None");
                yield return new Arthritis(40, 56, "Treated", "Female", 69, "Some");
                yield return new Arthritis(41, 43, "Treated", "Female", 70, "Some");
                yield return new Arthritis(42, 9, "Placebo", "Male", 37, "None");
                yield return new Arthritis(43, 14, "Placebo", "Male", 44, "None");
                yield return new Arthritis(44, 73, "Placebo", "Male", 50, "None");
                yield return new Arthritis(45, 74, "Placebo", "Male", 51, "None");
                yield return new Arthritis(46, 25, "Placebo", "Male", 52, "None");
                yield return new Arthritis(47, 18, "Placebo", "Male", 53, "None");
                yield return new Arthritis(48, 21, "Placebo", "Male", 59, "None");
                yield return new Arthritis(49, 52, "Placebo", "Male", 59, "None");
                yield return new Arthritis(50, 45, "Placebo", "Male", 62, "None");
                yield return new Arthritis(51, 41, "Placebo", "Male", 62, "None");
                yield return new Arthritis(52, 8, "Placebo", "Male", 63, "Marked");
                yield return new Arthritis(53, 80, "Placebo", "Female", 23, "None");
                yield return new Arthritis(54, 12, "Placebo", "Female", 30, "None");
                yield return new Arthritis(55, 29, "Placebo", "Female", 30, "None");
                yield return new Arthritis(56, 50, "Placebo", "Female", 31, "Some");
                yield return new Arthritis(57, 38, "Placebo", "Female", 32, "None");
                yield return new Arthritis(58, 35, "Placebo", "Female", 33, "Marked");
                yield return new Arthritis(59, 51, "Placebo", "Female", 37, "None");
                yield return new Arthritis(60, 54, "Placebo", "Female", 44, "None");
                yield return new Arthritis(61, 76, "Placebo", "Female", 45, "None");
                yield return new Arthritis(62, 16, "Placebo", "Female", 46, "None");
                yield return new Arthritis(63, 69, "Placebo", "Female", 48, "None");
                yield return new Arthritis(64, 31, "Placebo", "Female", 49, "None");
                yield return new Arthritis(65, 20, "Placebo", "Female", 51, "None");
                yield return new Arthritis(66, 68, "Placebo", "Female", 53, "None");
                yield return new Arthritis(67, 81, "Placebo", "Female", 54, "None");
                yield return new Arthritis(68, 4, "Placebo", "Female", 54, "None");
                yield return new Arthritis(69, 78, "Placebo", "Female", 54, "Marked");
                yield return new Arthritis(70, 70, "Placebo", "Female", 55, "Marked");
                yield return new Arthritis(71, 49, "Placebo", "Female", 57, "None");
                yield return new Arthritis(72, 10, "Placebo", "Female", 57, "Some");
                yield return new Arthritis(73, 47, "Placebo", "Female", 58, "Some");
                yield return new Arthritis(74, 44, "Placebo", "Female", 59, "Some");
                yield return new Arthritis(75, 24, "Placebo", "Female", 59, "Marked");
                yield return new Arthritis(76, 48, "Placebo", "Female", 61, "None");
                yield return new Arthritis(77, 19, "Placebo", "Female", 63, "Some");
                yield return new Arthritis(78, 3, "Placebo", "Female", 64, "None");
                yield return new Arthritis(79, 67, "Placebo", "Female", 65, "Marked");
                yield return new Arthritis(80, 32, "Placebo", "Female", 66, "None");
                yield return new Arthritis(81, 42, "Placebo", "Female", 66, "None");
                yield return new Arthritis(82, 15, "Placebo", "Female", 66, "Some");
                yield return new Arthritis(83, 71, "Placebo", "Female", 68, "Some");
                yield return new Arthritis(84, 1, "Placebo", "Female", 74, "Marked");
            }
        }
    }
}
