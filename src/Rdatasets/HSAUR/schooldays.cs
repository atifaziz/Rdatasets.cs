// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Days not Spent at School
    /// </summary>

    public class schooldays
    {
        public readonly int κ;
        public readonly string race;
        public readonly string sex;
        public readonly string school;
        public readonly string learner;
        public readonly int absent;

        public schooldays(int κ, string race, string sex, string school, string learner, int absent)
        {
            this.κ = κ;
            this.race = race;
            this.sex = sex;
            this.school = school;
            this.learner = learner;
            this.absent = absent;
        }

        public static IEnumerable<schooldays> Data
        {
            get
            {
                yield return new schooldays(1, "aboriginal", "male", "F0", "slow", 2);
                yield return new schooldays(2, "aboriginal", "male", "F0", "slow", 11);
                yield return new schooldays(3, "aboriginal", "male", "F0", "slow", 14);
                yield return new schooldays(4, "aboriginal", "male", "F0", "average", 5);
                yield return new schooldays(5, "aboriginal", "male", "F0", "average", 5);
                yield return new schooldays(6, "aboriginal", "male", "F0", "average", 13);
                yield return new schooldays(7, "aboriginal", "male", "F0", "average", 20);
                yield return new schooldays(8, "aboriginal", "male", "F0", "average", 22);
                yield return new schooldays(9, "aboriginal", "male", "F1", "slow", 6);
                yield return new schooldays(10, "aboriginal", "male", "F1", "slow", 6);
                yield return new schooldays(11, "aboriginal", "male", "F1", "slow", 15);
                yield return new schooldays(12, "aboriginal", "male", "F1", "average", 7);
                yield return new schooldays(13, "aboriginal", "male", "F1", "average", 14);
                yield return new schooldays(14, "aboriginal", "male", "F2", "slow", 6);
                yield return new schooldays(15, "aboriginal", "male", "F2", "slow", 32);
                yield return new schooldays(16, "aboriginal", "male", "F2", "slow", 53);
                yield return new schooldays(17, "aboriginal", "male", "F2", "slow", 57);
                yield return new schooldays(18, "aboriginal", "male", "F2", "average", 14);
                yield return new schooldays(19, "aboriginal", "male", "F2", "average", 16);
                yield return new schooldays(20, "aboriginal", "male", "F2", "average", 16);
                yield return new schooldays(21, "aboriginal", "male", "F2", "average", 17);
                yield return new schooldays(22, "aboriginal", "male", "F2", "average", 40);
                yield return new schooldays(23, "aboriginal", "male", "F2", "average", 43);
                yield return new schooldays(24, "aboriginal", "male", "F2", "average", 46);
                yield return new schooldays(25, "aboriginal", "male", "F3", "slow", 12);
                yield return new schooldays(26, "aboriginal", "male", "F3", "slow", 15);
                yield return new schooldays(27, "aboriginal", "male", "F3", "average", 8);
                yield return new schooldays(28, "aboriginal", "male", "F3", "average", 23);
                yield return new schooldays(29, "aboriginal", "male", "F3", "average", 23);
                yield return new schooldays(30, "aboriginal", "male", "F3", "average", 28);
                yield return new schooldays(31, "aboriginal", "male", "F3", "average", 34);
                yield return new schooldays(32, "aboriginal", "male", "F3", "average", 36);
                yield return new schooldays(33, "aboriginal", "male", "F3", "average", 38);
                yield return new schooldays(34, "aboriginal", "female", "F0", "slow", 3);
                yield return new schooldays(35, "aboriginal", "female", "F0", "average", 5);
                yield return new schooldays(36, "aboriginal", "female", "F0", "average", 11);
                yield return new schooldays(37, "aboriginal", "female", "F0", "average", 24);
                yield return new schooldays(38, "aboriginal", "female", "F0", "average", 45);
                yield return new schooldays(39, "aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays(40, "aboriginal", "female", "F1", "slow", 6);
                yield return new schooldays(41, "aboriginal", "female", "F1", "slow", 6);
                yield return new schooldays(42, "aboriginal", "female", "F1", "slow", 9);
                yield return new schooldays(43, "aboriginal", "female", "F1", "slow", 13);
                yield return new schooldays(44, "aboriginal", "female", "F1", "slow", 23);
                yield return new schooldays(45, "aboriginal", "female", "F1", "slow", 25);
                yield return new schooldays(46, "aboriginal", "female", "F1", "slow", 32);
                yield return new schooldays(47, "aboriginal", "female", "F1", "slow", 53);
                yield return new schooldays(48, "aboriginal", "female", "F1", "slow", 54);
                yield return new schooldays(49, "aboriginal", "female", "F1", "average", 5);
                yield return new schooldays(50, "aboriginal", "female", "F1", "average", 5);
                yield return new schooldays(51, "aboriginal", "female", "F1", "average", 11);
                yield return new schooldays(52, "aboriginal", "female", "F1", "average", 17);
                yield return new schooldays(53, "aboriginal", "female", "F1", "average", 19);
                yield return new schooldays(54, "aboriginal", "female", "F2", "slow", 8);
                yield return new schooldays(55, "aboriginal", "female", "F2", "slow", 13);
                yield return new schooldays(56, "aboriginal", "female", "F2", "slow", 14);
                yield return new schooldays(57, "aboriginal", "female", "F2", "slow", 20);
                yield return new schooldays(58, "aboriginal", "female", "F2", "slow", 47);
                yield return new schooldays(59, "aboriginal", "female", "F2", "slow", 48);
                yield return new schooldays(60, "aboriginal", "female", "F2", "slow", 60);
                yield return new schooldays(61, "aboriginal", "female", "F2", "slow", 81);
                yield return new schooldays(62, "aboriginal", "female", "F2", "average", 2);
                yield return new schooldays(63, "aboriginal", "female", "F3", "slow", 5);
                yield return new schooldays(64, "aboriginal", "female", "F3", "slow", 9);
                yield return new schooldays(65, "aboriginal", "female", "F3", "slow", 7);
                yield return new schooldays(66, "aboriginal", "female", "F3", "average", 0);
                yield return new schooldays(67, "aboriginal", "female", "F3", "average", 2);
                yield return new schooldays(68, "aboriginal", "female", "F3", "average", 3);
                yield return new schooldays(69, "aboriginal", "female", "F3", "average", 5);
                yield return new schooldays(70, "aboriginal", "female", "F3", "average", 10);
                yield return new schooldays(71, "aboriginal", "female", "F3", "average", 14);
                yield return new schooldays(72, "aboriginal", "female", "F3", "average", 21);
                yield return new schooldays(73, "aboriginal", "female", "F3", "average", 36);
                yield return new schooldays(74, "aboriginal", "female", "F3", "average", 40);
                yield return new schooldays(75, "non-aboriginal", "male", "F0", "slow", 6);
                yield return new schooldays(76, "non-aboriginal", "male", "F0", "slow", 17);
                yield return new schooldays(77, "non-aboriginal", "male", "F0", "slow", 67);
                yield return new schooldays(78, "non-aboriginal", "male", "F0", "average", 0);
                yield return new schooldays(79, "non-aboriginal", "male", "F0", "average", 0);
                yield return new schooldays(80, "non-aboriginal", "male", "F0", "average", 2);
                yield return new schooldays(81, "non-aboriginal", "male", "F0", "average", 7);
                yield return new schooldays(82, "non-aboriginal", "male", "F0", "average", 11);
                yield return new schooldays(83, "non-aboriginal", "male", "F0", "average", 12);
                yield return new schooldays(84, "non-aboriginal", "male", "F1", "slow", 0);
                yield return new schooldays(85, "non-aboriginal", "male", "F1", "slow", 0);
                yield return new schooldays(86, "non-aboriginal", "male", "F1", "slow", 5);
                yield return new schooldays(87, "non-aboriginal", "male", "F1", "slow", 5);
                yield return new schooldays(88, "non-aboriginal", "male", "F1", "slow", 5);
                yield return new schooldays(89, "non-aboriginal", "male", "F1", "slow", 11);
                yield return new schooldays(90, "non-aboriginal", "male", "F1", "slow", 17);
                yield return new schooldays(91, "non-aboriginal", "male", "F1", "average", 3);
                yield return new schooldays(92, "non-aboriginal", "male", "F1", "average", 3);
                yield return new schooldays(93, "non-aboriginal", "male", "F2", "slow", 22);
                yield return new schooldays(94, "non-aboriginal", "male", "F1", "average", 30);
                yield return new schooldays(95, "non-aboriginal", "male", "F1", "average", 36);
                yield return new schooldays(96, "non-aboriginal", "male", "F2", "average", 8);
                yield return new schooldays(97, "non-aboriginal", "male", "F2", "average", 0);
                yield return new schooldays(98, "non-aboriginal", "male", "F2", "average", 1);
                yield return new schooldays(99, "non-aboriginal", "male", "F2", "average", 5);
                yield return new schooldays(100, "non-aboriginal", "male", "F2", "average", 7);
                yield return new schooldays(101, "non-aboriginal", "male", "F2", "average", 16);
                yield return new schooldays(102, "non-aboriginal", "male", "F2", "average", 27);
                yield return new schooldays(103, "non-aboriginal", "male", "F3", "slow", 12);
                yield return new schooldays(104, "non-aboriginal", "male", "F3", "slow", 15);
                yield return new schooldays(105, "non-aboriginal", "male", "F3", "average", 0);
                yield return new schooldays(106, "non-aboriginal", "male", "F3", "average", 30);
                yield return new schooldays(107, "non-aboriginal", "male", "F3", "average", 10);
                yield return new schooldays(108, "non-aboriginal", "male", "F3", "average", 14);
                yield return new schooldays(109, "non-aboriginal", "male", "F3", "average", 27);
                yield return new schooldays(110, "non-aboriginal", "male", "F3", "average", 41);
                yield return new schooldays(111, "non-aboriginal", "male", "F3", "average", 69);
                yield return new schooldays(112, "non-aboriginal", "female", "F0", "slow", 25);
                yield return new schooldays(113, "non-aboriginal", "female", "F0", "average", 10);
                yield return new schooldays(114, "non-aboriginal", "female", "F0", "average", 11);
                yield return new schooldays(115, "non-aboriginal", "female", "F0", "average", 20);
                yield return new schooldays(116, "non-aboriginal", "female", "F0", "average", 33);
                yield return new schooldays(117, "non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays(118, "non-aboriginal", "female", "F1", "slow", 7);
                yield return new schooldays(119, "non-aboriginal", "female", "F1", "slow", 0);
                yield return new schooldays(120, "non-aboriginal", "female", "F1", "slow", 1);
                yield return new schooldays(121, "non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays(122, "non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays(123, "non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays(124, "non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays(125, "non-aboriginal", "female", "F1", "slow", 7);
                yield return new schooldays(126, "non-aboriginal", "female", "F1", "slow", 11);
                yield return new schooldays(127, "non-aboriginal", "female", "F1", "slow", 15);
                yield return new schooldays(128, "non-aboriginal", "female", "F1", "average", 5);
                yield return new schooldays(129, "non-aboriginal", "female", "F1", "average", 14);
                yield return new schooldays(130, "non-aboriginal", "female", "F1", "average", 6);
                yield return new schooldays(131, "non-aboriginal", "female", "F1", "average", 6);
                yield return new schooldays(132, "non-aboriginal", "female", "F1", "average", 7);
                yield return new schooldays(133, "non-aboriginal", "female", "F1", "average", 28);
                yield return new schooldays(134, "non-aboriginal", "female", "F2", "slow", 0);
                yield return new schooldays(135, "non-aboriginal", "female", "F2", "slow", 5);
                yield return new schooldays(136, "non-aboriginal", "female", "F2", "slow", 14);
                yield return new schooldays(137, "non-aboriginal", "female", "F2", "slow", 2);
                yield return new schooldays(138, "non-aboriginal", "female", "F2", "slow", 2);
                yield return new schooldays(139, "non-aboriginal", "female", "F2", "slow", 3);
                yield return new schooldays(140, "non-aboriginal", "female", "F2", "slow", 8);
                yield return new schooldays(141, "non-aboriginal", "female", "F2", "slow", 10);
                yield return new schooldays(142, "non-aboriginal", "female", "F2", "slow", 12);
                yield return new schooldays(143, "non-aboriginal", "female", "F2", "average", 1);
                yield return new schooldays(144, "non-aboriginal", "female", "F3", "slow", 8);
                yield return new schooldays(145, "non-aboriginal", "female", "F3", "average", 1);
                yield return new schooldays(146, "non-aboriginal", "female", "F3", "average", 9);
                yield return new schooldays(147, "non-aboriginal", "female", "F3", "average", 22);
                yield return new schooldays(148, "non-aboriginal", "female", "F3", "average", 3);
                yield return new schooldays(149, "non-aboriginal", "female", "F3", "average", 3);
                yield return new schooldays(150, "non-aboriginal", "female", "F3", "average", 5);
                yield return new schooldays(151, "non-aboriginal", "female", "F3", "average", 15);
                yield return new schooldays(152, "non-aboriginal", "female", "F3", "average", 18);
                yield return new schooldays(153, "non-aboriginal", "female", "F3", "average", 22);
                yield return new schooldays(154, "non-aboriginal", "female", "F3", "average", 37);
            }
        }
    }
}
