// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Closing Numbers for S and P 500 Index - First 100 Days of 1990
    /// </summary>

    public class SP500W90
    {
        public readonly int day;
        public readonly double closing;

        public SP500W90(int day, double closing)
        {
            this.day = day;
            this.closing = closing;
        }

        public static IEnumerable<SP500W90> Data
        {
            get
            {
                yield return new SP500W90(3, 358.76);
                yield return new SP500W90(4, 355.67);
                yield return new SP500W90(5, 352.2);
                yield return new SP500W90(8, 353.79);
                yield return new SP500W90(9, 349.62);
                yield return new SP500W90(10, 347.31);
                yield return new SP500W90(11, 348.53);
                yield return new SP500W90(12, 339.93);
                yield return new SP500W90(15, 337);
                yield return new SP500W90(16, 340.75);
                yield return new SP500W90(17, 337.4);
                yield return new SP500W90(18, 338.19);
                yield return new SP500W90(19, 339.15);
                yield return new SP500W90(22, 330.38);
                yield return new SP500W90(23, 331.61);
                yield return new SP500W90(24, 330.26);
                yield return new SP500W90(25, 326.08);
                yield return new SP500W90(26, 325.8);
                yield return new SP500W90(29, 325.2);
                yield return new SP500W90(30, 322.98);
                yield return new SP500W90(31, 329.08);
                yield return new SP500W90(32, 328.79);
                yield return new SP500W90(33, 330.92);
                yield return new SP500W90(36, 331.85);
                yield return new SP500W90(37, 329.66);
                yield return new SP500W90(38, 333.75);
                yield return new SP500W90(39, 332.96);
                yield return new SP500W90(40, 333.62);
                yield return new SP500W90(43, 330.08);
                yield return new SP500W90(44, 331.02);
                yield return new SP500W90(45, 332.01);
                yield return new SP500W90(46, 334.89);
                yield return new SP500W90(47, 332.72);
                yield return new SP500W90(50, 327.99);
                yield return new SP500W90(51, 327.67);
                yield return new SP500W90(52, 325.7);
                yield return new SP500W90(53, 324.15);
                yield return new SP500W90(54, 328.67);
                yield return new SP500W90(57, 330.26);
                yield return new SP500W90(58, 331.89);
                yield return new SP500W90(59, 332.74);
                yield return new SP500W90(60, 335.54);
                yield return new SP500W90(61, 333.74);
                yield return new SP500W90(64, 337.93);
                yield return new SP500W90(65, 336.95);
                yield return new SP500W90(66, 340.27);
                yield return new SP500W90(67, 337.93);
                yield return new SP500W90(68, 338.67);
                yield return new SP500W90(71, 336);
                yield return new SP500W90(72, 336.87);
                yield return new SP500W90(73, 338.07);
                yield return new SP500W90(74, 341.91);
                yield return new SP500W90(75, 343.53);
                yield return new SP500W90(78, 341.57);
                yield return new SP500W90(79, 339.74);
                yield return new SP500W90(80, 335.69);
                yield return new SP500W90(81, 337.22);
                yield return new SP500W90(82, 337.63);
                yield return new SP500W90(85, 341.5);
                yield return new SP500W90(86, 342);
                yield return new SP500W90(87, 340.79);
                yield return new SP500W90(88, 339.94);
                yield return new SP500W90(89, 338.7);
                yield return new SP500W90(92, 343.64);
                yield return new SP500W90(93, 341.09);
                yield return new SP500W90(94, 340.73);
                yield return new SP500W90(95, 340.08);
                yield return new SP500W90(96, 341.37);
                yield return new SP500W90(99, 342.07);
                yield return new SP500W90(100, 341.92);
                yield return new SP500W90(101, 344.34);
                yield return new SP500W90(102, 344.74);
                yield return new SP500W90(103, 344.68);
                yield return new SP500W90(106, 340.72);
                yield return new SP500W90(107, 338.09);
                yield return new SP500W90(108, 335.12);
                yield return new SP500W90(109, 331.05);
                yield return new SP500W90(110, 330.36);
                yield return new SP500W90(113, 332.03);
                yield return new SP500W90(114, 332.92);
                yield return new SP500W90(115, 329.11);
                yield return new SP500W90(116, 330.8);
                yield return new SP500W90(117, 332.25);
                yield return new SP500W90(120, 334.48);
                yield return new SP500W90(121, 335.57);
                yield return new SP500W90(122, 338.39);
                yield return new SP500W90(123, 340.53);
                yield return new SP500W90(124, 342.01);
                yield return new SP500W90(127, 342.86);
                yield return new SP500W90(128, 343.82);
                yield return new SP500W90(129, 352);
                yield return new SP500W90(130, 354.75);
                yield return new SP500W90(131, 354.28);
                yield return new SP500W90(134, 354);
                yield return new SP500W90(135, 354.47);
                yield return new SP500W90(136, 354.64);
                yield return new SP500W90(137, 358);
                yield return new SP500W90(138, 358.43);
                yield return new SP500W90(141, 359.29);
                yield return new SP500W90(142, 358.41);
            }
        }
    }
}
