// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Pharmacokinetics of Theophylline
    /// </summary>

    public class Theoph
    {
        public readonly int κ;
        public readonly int Subject;
        public readonly double Wt;
        public readonly double Dose;
        public readonly double Time;
        public readonly double conc;

        public Theoph(int κ, int Subject, double Wt, double Dose, double Time, double conc)
        {
            this.κ = κ;
            this.Subject = Subject;
            this.Wt = Wt;
            this.Dose = Dose;
            this.Time = Time;
            this.conc = conc;
        }

        public static IEnumerable<Theoph> Data
        {
            get
            {
                yield return new Theoph(1, 1, 79.6, 4.02, 0, 0.74);
                yield return new Theoph(2, 1, 79.6, 4.02, 0.25, 2.84);
                yield return new Theoph(3, 1, 79.6, 4.02, 0.57, 6.57);
                yield return new Theoph(4, 1, 79.6, 4.02, 1.12, 10.5);
                yield return new Theoph(5, 1, 79.6, 4.02, 2.02, 9.66);
                yield return new Theoph(6, 1, 79.6, 4.02, 3.82, 8.58);
                yield return new Theoph(7, 1, 79.6, 4.02, 5.1, 8.36);
                yield return new Theoph(8, 1, 79.6, 4.02, 7.03, 7.47);
                yield return new Theoph(9, 1, 79.6, 4.02, 9.05, 6.89);
                yield return new Theoph(10, 1, 79.6, 4.02, 12.12, 5.94);
                yield return new Theoph(11, 1, 79.6, 4.02, 24.37, 3.28);
                yield return new Theoph(12, 2, 72.4, 4.4, 0, 0);
                yield return new Theoph(13, 2, 72.4, 4.4, 0.27, 1.72);
                yield return new Theoph(14, 2, 72.4, 4.4, 0.52, 7.91);
                yield return new Theoph(15, 2, 72.4, 4.4, 1, 8.31);
                yield return new Theoph(16, 2, 72.4, 4.4, 1.92, 8.33);
                yield return new Theoph(17, 2, 72.4, 4.4, 3.5, 6.85);
                yield return new Theoph(18, 2, 72.4, 4.4, 5.02, 6.08);
                yield return new Theoph(19, 2, 72.4, 4.4, 7.03, 5.4);
                yield return new Theoph(20, 2, 72.4, 4.4, 9, 4.55);
                yield return new Theoph(21, 2, 72.4, 4.4, 12, 3.01);
                yield return new Theoph(22, 2, 72.4, 4.4, 24.3, 0.9);
                yield return new Theoph(23, 3, 70.5, 4.53, 0, 0);
                yield return new Theoph(24, 3, 70.5, 4.53, 0.27, 4.4);
                yield return new Theoph(25, 3, 70.5, 4.53, 0.58, 6.9);
                yield return new Theoph(26, 3, 70.5, 4.53, 1.02, 8.2);
                yield return new Theoph(27, 3, 70.5, 4.53, 2.02, 7.8);
                yield return new Theoph(28, 3, 70.5, 4.53, 3.62, 7.5);
                yield return new Theoph(29, 3, 70.5, 4.53, 5.08, 6.2);
                yield return new Theoph(30, 3, 70.5, 4.53, 7.07, 5.3);
                yield return new Theoph(31, 3, 70.5, 4.53, 9, 4.9);
                yield return new Theoph(32, 3, 70.5, 4.53, 12.15, 3.7);
                yield return new Theoph(33, 3, 70.5, 4.53, 24.17, 1.05);
                yield return new Theoph(34, 4, 72.7, 4.4, 0, 0);
                yield return new Theoph(35, 4, 72.7, 4.4, 0.35, 1.89);
                yield return new Theoph(36, 4, 72.7, 4.4, 0.6, 4.6);
                yield return new Theoph(37, 4, 72.7, 4.4, 1.07, 8.6);
                yield return new Theoph(38, 4, 72.7, 4.4, 2.13, 8.38);
                yield return new Theoph(39, 4, 72.7, 4.4, 3.5, 7.54);
                yield return new Theoph(40, 4, 72.7, 4.4, 5.02, 6.88);
                yield return new Theoph(41, 4, 72.7, 4.4, 7.02, 5.78);
                yield return new Theoph(42, 4, 72.7, 4.4, 9.02, 5.33);
                yield return new Theoph(43, 4, 72.7, 4.4, 11.98, 4.19);
                yield return new Theoph(44, 4, 72.7, 4.4, 24.65, 1.15);
                yield return new Theoph(45, 5, 54.6, 5.86, 0, 0);
                yield return new Theoph(46, 5, 54.6, 5.86, 0.3, 2.02);
                yield return new Theoph(47, 5, 54.6, 5.86, 0.52, 5.63);
                yield return new Theoph(48, 5, 54.6, 5.86, 1, 11.4);
                yield return new Theoph(49, 5, 54.6, 5.86, 2.02, 9.33);
                yield return new Theoph(50, 5, 54.6, 5.86, 3.5, 8.74);
                yield return new Theoph(51, 5, 54.6, 5.86, 5.02, 7.56);
                yield return new Theoph(52, 5, 54.6, 5.86, 7.02, 7.09);
                yield return new Theoph(53, 5, 54.6, 5.86, 9.1, 5.9);
                yield return new Theoph(54, 5, 54.6, 5.86, 12, 4.37);
                yield return new Theoph(55, 5, 54.6, 5.86, 24.35, 1.57);
                yield return new Theoph(56, 6, 80, 4, 0, 0);
                yield return new Theoph(57, 6, 80, 4, 0.27, 1.29);
                yield return new Theoph(58, 6, 80, 4, 0.58, 3.08);
                yield return new Theoph(59, 6, 80, 4, 1.15, 6.44);
                yield return new Theoph(60, 6, 80, 4, 2.03, 6.32);
                yield return new Theoph(61, 6, 80, 4, 3.57, 5.53);
                yield return new Theoph(62, 6, 80, 4, 5, 4.94);
                yield return new Theoph(63, 6, 80, 4, 7, 4.02);
                yield return new Theoph(64, 6, 80, 4, 9.22, 3.46);
                yield return new Theoph(65, 6, 80, 4, 12.1, 2.78);
                yield return new Theoph(66, 6, 80, 4, 23.85, 0.92);
                yield return new Theoph(67, 7, 64.6, 4.95, 0, 0.15);
                yield return new Theoph(68, 7, 64.6, 4.95, 0.25, 0.85);
                yield return new Theoph(69, 7, 64.6, 4.95, 0.5, 2.35);
                yield return new Theoph(70, 7, 64.6, 4.95, 1.02, 5.02);
                yield return new Theoph(71, 7, 64.6, 4.95, 2.02, 6.58);
                yield return new Theoph(72, 7, 64.6, 4.95, 3.48, 7.09);
                yield return new Theoph(73, 7, 64.6, 4.95, 5, 6.66);
                yield return new Theoph(74, 7, 64.6, 4.95, 6.98, 5.25);
                yield return new Theoph(75, 7, 64.6, 4.95, 9, 4.39);
                yield return new Theoph(76, 7, 64.6, 4.95, 12.05, 3.53);
                yield return new Theoph(77, 7, 64.6, 4.95, 24.22, 1.15);
                yield return new Theoph(78, 8, 70.5, 4.53, 0, 0);
                yield return new Theoph(79, 8, 70.5, 4.53, 0.25, 3.05);
                yield return new Theoph(80, 8, 70.5, 4.53, 0.52, 3.05);
                yield return new Theoph(81, 8, 70.5, 4.53, 0.98, 7.31);
                yield return new Theoph(82, 8, 70.5, 4.53, 2.02, 7.56);
                yield return new Theoph(83, 8, 70.5, 4.53, 3.53, 6.59);
                yield return new Theoph(84, 8, 70.5, 4.53, 5.05, 5.88);
                yield return new Theoph(85, 8, 70.5, 4.53, 7.15, 4.73);
                yield return new Theoph(86, 8, 70.5, 4.53, 9.07, 4.57);
                yield return new Theoph(87, 8, 70.5, 4.53, 12.1, 3);
                yield return new Theoph(88, 8, 70.5, 4.53, 24.12, 1.25);
                yield return new Theoph(89, 9, 86.4, 3.1, 0, 0);
                yield return new Theoph(90, 9, 86.4, 3.1, 0.3, 7.37);
                yield return new Theoph(91, 9, 86.4, 3.1, 0.63, 9.03);
                yield return new Theoph(92, 9, 86.4, 3.1, 1.05, 7.14);
                yield return new Theoph(93, 9, 86.4, 3.1, 2.02, 6.33);
                yield return new Theoph(94, 9, 86.4, 3.1, 3.53, 5.66);
                yield return new Theoph(95, 9, 86.4, 3.1, 5.02, 5.67);
                yield return new Theoph(96, 9, 86.4, 3.1, 7.17, 4.24);
                yield return new Theoph(97, 9, 86.4, 3.1, 8.8, 4.11);
                yield return new Theoph(98, 9, 86.4, 3.1, 11.6, 3.16);
                yield return new Theoph(99, 9, 86.4, 3.1, 24.43, 1.12);
                yield return new Theoph(100, 10, 58.2, 5.5, 0, 0.24);
                yield return new Theoph(101, 10, 58.2, 5.5, 0.37, 2.89);
                yield return new Theoph(102, 10, 58.2, 5.5, 0.77, 5.22);
                yield return new Theoph(103, 10, 58.2, 5.5, 1.02, 6.41);
                yield return new Theoph(104, 10, 58.2, 5.5, 2.05, 7.83);
                yield return new Theoph(105, 10, 58.2, 5.5, 3.55, 10.21);
                yield return new Theoph(106, 10, 58.2, 5.5, 5.05, 9.18);
                yield return new Theoph(107, 10, 58.2, 5.5, 7.08, 8.02);
                yield return new Theoph(108, 10, 58.2, 5.5, 9.38, 7.14);
                yield return new Theoph(109, 10, 58.2, 5.5, 12.1, 5.68);
                yield return new Theoph(110, 10, 58.2, 5.5, 23.7, 2.42);
                yield return new Theoph(111, 11, 65, 4.92, 0, 0);
                yield return new Theoph(112, 11, 65, 4.92, 0.25, 4.86);
                yield return new Theoph(113, 11, 65, 4.92, 0.5, 7.24);
                yield return new Theoph(114, 11, 65, 4.92, 0.98, 8);
                yield return new Theoph(115, 11, 65, 4.92, 1.98, 6.81);
                yield return new Theoph(116, 11, 65, 4.92, 3.6, 5.87);
                yield return new Theoph(117, 11, 65, 4.92, 5.02, 5.22);
                yield return new Theoph(118, 11, 65, 4.92, 7.03, 4.45);
                yield return new Theoph(119, 11, 65, 4.92, 9.03, 3.62);
                yield return new Theoph(120, 11, 65, 4.92, 12.12, 2.69);
                yield return new Theoph(121, 11, 65, 4.92, 24.08, 0.86);
                yield return new Theoph(122, 12, 60.5, 5.3, 0, 0);
                yield return new Theoph(123, 12, 60.5, 5.3, 0.25, 1.25);
                yield return new Theoph(124, 12, 60.5, 5.3, 0.5, 3.96);
                yield return new Theoph(125, 12, 60.5, 5.3, 1, 7.82);
                yield return new Theoph(126, 12, 60.5, 5.3, 2, 9.72);
                yield return new Theoph(127, 12, 60.5, 5.3, 3.52, 9.75);
                yield return new Theoph(128, 12, 60.5, 5.3, 5.07, 8.57);
                yield return new Theoph(129, 12, 60.5, 5.3, 7.07, 6.59);
                yield return new Theoph(130, 12, 60.5, 5.3, 9.03, 6.11);
                yield return new Theoph(131, 12, 60.5, 5.3, 12.05, 4.57);
                yield return new Theoph(132, 12, 60.5, 5.3, 24.15, 1.17);
            }
        }
    }
}
