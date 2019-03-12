// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Data set testing causal direction in presumed media influence
    /// </summary>

    public class Tal_Or
    {
        public readonly int κ;
        public readonly int cond;
        public readonly double pmi;
        public readonly int import;
        public readonly double reaction;
        public readonly int gender;
        public readonly double age;

        public Tal_Or(int κ, int cond, double pmi, int import, double reaction, int gender, double age)
        {
            this.κ = κ;
            this.cond = cond;
            this.pmi = pmi;
            this.import = import;
            this.reaction = reaction;
            this.gender = gender;
            this.age = age;
        }

        public static IEnumerable<Tal_Or> Data
        {
            get
            {
                yield return new Tal_Or(1, 1, 7, 6, 5.25, 1, 51);
                yield return new Tal_Or(2, 0, 6, 1, 1.25, 1, 40);
                yield return new Tal_Or(3, 1, 5.5, 6, 5, 1, 26);
                yield return new Tal_Or(4, 0, 6.5, 6, 2.75, 2, 21);
                yield return new Tal_Or(5, 0, 6, 5, 2.5, 1, 27);
                yield return new Tal_Or(6, 0, 5.5, 1, 1.25, 1, 25);
                yield return new Tal_Or(7, 0, 3.5, 1, 1.5, 2, 23);
                yield return new Tal_Or(8, 1, 6, 6, 4.75, 1, 25);
                yield return new Tal_Or(9, 0, 4.5, 6, 4.25, 1, 22);
                yield return new Tal_Or(10, 0, 7, 6, 6.25, 1, 24);
                yield return new Tal_Or(11, 1, 1, 3, 1.25, 2, 22);
                yield return new Tal_Or(12, 0, 6, 3, 2.75, 2, 21);
                yield return new Tal_Or(13, 1, 5, 4, 3.75, 2, 23);
                yield return new Tal_Or(14, 0, 7, 7, 5, 2, 21);
                yield return new Tal_Or(15, 1, 7, 1, 4, 2, 22);
                yield return new Tal_Or(16, 1, 7, 6, 5, 2, 23);
                yield return new Tal_Or(17, 0, 4.5, 3, 3.5, 2, 23);
                yield return new Tal_Or(18, 0, 3.5, 3, 2.25, 2, 23);
                yield return new Tal_Or(19, 1, 7, 2, 4.5, 2, 22);
                yield return new Tal_Or(20, 0, 7, 4, 5.75, 1, 23);
                yield return new Tal_Or(21, 1, 4.5, 4, 2.75, 2, 22);
                yield return new Tal_Or(22, 1, 6, 6, 3.75, 2, 19.5);
                yield return new Tal_Or(23, 1, 6, 7, 2.75, 1, 61);
                yield return new Tal_Or(24, 1, 4, 4, 4, 1, 25);
                yield return new Tal_Or(25, 1, 7, 5, 5, 2, 23);
                yield return new Tal_Or(26, 0, 4, 4, 2, 1, 60);
                yield return new Tal_Or(27, 1, 6.5, 6, 4, 2, 22);
                yield return new Tal_Or(28, 0, 6, 5, 1.75, 2, 23);
                yield return new Tal_Or(29, 1, 6.5, 5, 3.5, 2, 22);
                yield return new Tal_Or(30, 0, 6, 7, 4.75, 1, 23);
                yield return new Tal_Or(31, 0, 4, 4, 4, 2, 25);
                yield return new Tal_Or(32, 1, 7, 1, 3, 2, 22);
                yield return new Tal_Or(33, 0, 6, 4, 5.75, 2, 23);
                yield return new Tal_Or(34, 0, 7, 5, 2.75, 2, 22);
                yield return new Tal_Or(35, 1, 6.5, 5, 3.25, 1, 25);
                yield return new Tal_Or(36, 0, 5.5, 4, 5.5, 2, 24);
                yield return new Tal_Or(37, 1, 6, 4, 3.25, 1, 24);
                yield return new Tal_Or(38, 0, 2, 2, 1.25, 1, 29);
                yield return new Tal_Or(39, 1, 4.5, 2, 2, 1, 24);
                yield return new Tal_Or(40, 0, 4, 3, 2.5, 1, 18);
                yield return new Tal_Or(41, 0, 7, 3, 3, 1, 23);
                yield return new Tal_Or(42, 0, 6, 4, 5.75, 2, 21);
                yield return new Tal_Or(43, 1, 7, 2, 1.5, 1, 24);
                yield return new Tal_Or(44, 0, 5, 5, 4, 2, 26);
                yield return new Tal_Or(45, 1, 7, 3, 1.25, 1, 24);
                yield return new Tal_Or(46, 1, 7, 7, 3.25, 1, 22);
                yield return new Tal_Or(47, 0, 5, 4, 3.75, 2, 21);
                yield return new Tal_Or(48, 0, 6, 4, 2.75, 1, 26);
                yield return new Tal_Or(49, 0, 5.5, 4, 3, 1, 24);
                yield return new Tal_Or(50, 1, 7, 4, 6, 1, 27);
                yield return new Tal_Or(51, 0, 3.5, 6, 3.25, 1, 26);
                yield return new Tal_Or(52, 1, 7, 2, 2.75, 1, 24);
                yield return new Tal_Or(53, 0, 6, 5, 5, 1, 24);
                yield return new Tal_Or(54, 0, 3.5, 4, 1.5, 2, 26);
                yield return new Tal_Or(55, 1, 7, 7, 7, 1, 24);
                yield return new Tal_Or(56, 1, 5, 1, 5, 1, 22);
                yield return new Tal_Or(57, 1, 1.5, 2, 1.75, 1, 23);
                yield return new Tal_Or(58, 0, 6.5, 2, 2.25, 2, 24);
                yield return new Tal_Or(59, 1, 6, 5, 3.5, 2, 24);
                yield return new Tal_Or(60, 0, 7, 1, 3.5, 1, 25);
                yield return new Tal_Or(61, 0, 7, 5, 6.75, 2, 23);
                yield return new Tal_Or(62, 1, 6, 5, 4.25, 2, 23);
                yield return new Tal_Or(63, 1, 6, 5, 4, 2, 23);
                yield return new Tal_Or(64, 0, 4, 3, 2.25, 2, 24);
                yield return new Tal_Or(65, 0, 3.5, 2, 3, 2, 18);
                yield return new Tal_Or(66, 0, 6, 4, 5.5, 2, 23);
                yield return new Tal_Or(67, 1, 6, 5, 1.75, 1, 25);
                yield return new Tal_Or(68, 1, 6, 3, 4.5, 2, 24);
                yield return new Tal_Or(69, 0, 5, 6, 4.25, 2, 23);
                yield return new Tal_Or(70, 0, 3, 4, 1.5, 2, 23);
                yield return new Tal_Or(71, 1, 7, 4, 2, 2, 24);
                yield return new Tal_Or(72, 0, 6, 2, 1.5, 2, 22);
                yield return new Tal_Or(73, 1, 5, 4, 3.25, 1, 24);
                yield return new Tal_Or(74, 0, 5, 5, 1, 2, 25);
                yield return new Tal_Or(75, 1, 5.5, 2, 1.5, 2, 22);
                yield return new Tal_Or(76, 0, 5.5, 5, 1, 2, 22);
                yield return new Tal_Or(77, 0, 6, 6, 2.5, 2, 23);
                yield return new Tal_Or(78, 0, 2.5, 2, 1, 1, 25);
                yield return new Tal_Or(79, 1, 4.5, 4, 3, 2, 23);
                yield return new Tal_Or(80, 0, 5, 4, 2.5, 2, 23);
                yield return new Tal_Or(81, 0, 6, 2, 1, 1, 24);
                yield return new Tal_Or(82, 1, 5, 5, 3.75, 1, 21);
                yield return new Tal_Or(83, 1, 7, 7, 1.75, 2, 23);
                yield return new Tal_Or(84, 1, 5, 3, 2.75, 2, 21);
                yield return new Tal_Or(85, 1, 4.5, 5, 5.25, 1, 23);
                yield return new Tal_Or(86, 1, 6.5, 6, 5.25, 2, 19);
                yield return new Tal_Or(87, 1, 7, 6, 5, 1, 25);
                yield return new Tal_Or(88, 0, 6, 5, 5, 2, 23);
                yield return new Tal_Or(89, 1, 5, 7, 5, 2, 22);
                yield return new Tal_Or(90, 1, 7, 6, 6.5, 2, 19);
                yield return new Tal_Or(91, 0, 5.5, 5, 3, 2, 23);
                yield return new Tal_Or(92, 1, 6, 4, 2.75, 2, 24);
                yield return new Tal_Or(93, 1, 6, 5, 4.25, 1, 32);
                yield return new Tal_Or(94, 1, 7, 6, 7, 2, 27);
                yield return new Tal_Or(95, 1, 4, 7, 5.75, 2, 25);
                yield return new Tal_Or(96, 1, 6.5, 5, 3, 2, 24);
                yield return new Tal_Or(97, 1, 5, 4, 4.5, 2, 23);
                yield return new Tal_Or(98, 0, 7, 3, 4.25, 2, 28);
                yield return new Tal_Or(99, 0, 7, 4, 4.5, 2, 24);
                yield return new Tal_Or(100, 0, 5, 3, 3.75, 2, 24);
                yield return new Tal_Or(101, 0, 7, 1, 4.75, 2, 24);
                yield return new Tal_Or(102, 0, 7, 4, 2.5, 2, 25);
                yield return new Tal_Or(103, 0, 5, 3, 1, 2, 24);
                yield return new Tal_Or(104, 0, 6, 5, 6, 2, 25);
                yield return new Tal_Or(105, 0, 5, 6, 2, 2, 24);
                yield return new Tal_Or(106, 0, 6.5, 6, 5, 2, 24);
                yield return new Tal_Or(107, 1, 7, 7, 5, 2, 24);
                yield return new Tal_Or(108, 1, 6.5, 7, 4.25, 2, 25);
                yield return new Tal_Or(109, 1, 6, 3, 2, 1, 28);
                yield return new Tal_Or(110, 1, 5, 6, 3.5, 2, 24);
                yield return new Tal_Or(111, 1, 5.5, 1, 1.75, 2, 26);
                yield return new Tal_Or(112, 1, 5.5, 6, 3.5, 2, 27);
                yield return new Tal_Or(113, 1, 5, 4, 2.25, 2, 25);
                yield return new Tal_Or(114, 1, 7, 5, 5.5, 1, 25);
                yield return new Tal_Or(115, 0, 1.5, 1, 1, 2, 26);
                yield return new Tal_Or(116, 0, 6, 3, 3, 2, 25);
                yield return new Tal_Or(117, 0, 5.5, 5, 2.25, 2, 25);
                yield return new Tal_Or(118, 0, 6.5, 6, 4.75, 1, 25);
                yield return new Tal_Or(119, 0, 4.5, 3, 2.25, 2, 26);
                yield return new Tal_Or(120, 0, 3.5, 1, 1.5, 2, 22);
                yield return new Tal_Or(121, 0, 6, 6, 5.75, 2, 24);
                yield return new Tal_Or(122, 0, 6.5, 2, 5.25, 2, 23);
                yield return new Tal_Or(123, 0, 5.5, 6, 3, 2, 24);
            }
        }
    }
}
