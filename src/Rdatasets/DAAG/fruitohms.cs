// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Electrical Resistance of Kiwi Fruit
    /// </summary>

    public class fruitohms
    {
        public readonly int κ;
        public readonly double juice;
        public readonly int ohms;

        public fruitohms(int κ, double juice, int ohms)
        {
            this.κ = κ;
            this.juice = juice;
            this.ohms = ohms;
        }

        public static IEnumerable<fruitohms> Data
        {
            get
            {
                yield return new fruitohms(1, 4, 4860);
                yield return new fruitohms(2, 5, 5860);
                yield return new fruitohms(3, 5.5, 6650);
                yield return new fruitohms(4, 7.5, 7050);
                yield return new fruitohms(5, 8.5, 5960);
                yield return new fruitohms(6, 8.5, 6750);
                yield return new fruitohms(7, 8.5, 7650);
                yield return new fruitohms(8, 9, 6900);
                yield return new fruitohms(128, 9, 9850);
                yield return new fruitohms(9, 9.5, 6650);
                yield return new fruitohms(10, 10, 6250);
                yield return new fruitohms(11, 10, 7600);
                yield return new fruitohms(12, 10, 7900);
                yield return new fruitohms(13, 10.5, 6150);
                yield return new fruitohms(14, 10.5, 7150);
                yield return new fruitohms(15, 11.5, 6700);
                yield return new fruitohms(16, 11.5, 7900);
                yield return new fruitohms(17, 12, 5800);
                yield return new fruitohms(18, 12.5, 7050);
                yield return new fruitohms(19, 13, 9000);
                yield return new fruitohms(20, 13.5, 7350);
                yield return new fruitohms(21, 13.5, 6650);
                yield return new fruitohms(22, 13.5, 6950);
                yield return new fruitohms(23, 14, 6650);
                yield return new fruitohms(24, 14, 5700);
                yield return new fruitohms(25, 14.5, 7900);
                yield return new fruitohms(26, 15, 6500);
                yield return new fruitohms(27, 16, 4850);
                yield return new fruitohms(28, 16.5, 5600);
                yield return new fruitohms(29, 16.5, 6300);
                yield return new fruitohms(30, 17.5, 7150);
                yield return new fruitohms(31, 17.5, 5900);
                yield return new fruitohms(32, 19, 3900);
                yield return new fruitohms(33, 20, 7500);
                yield return new fruitohms(34, 20.5, 8500);
                yield return new fruitohms(35, 21.5, 5600);
                yield return new fruitohms(36, 21.5, 6950);
                yield return new fruitohms(37, 21.5, 7200);
                yield return new fruitohms(38, 23.5, 5750);
                yield return new fruitohms(39, 24, 6900);
                yield return new fruitohms(40, 24.5, 4100);
                yield return new fruitohms(41, 28, 6700);
                yield return new fruitohms(42, 28.5, 3900);
                yield return new fruitohms(43, 30, 3500);
                yield return new fruitohms(44, 30, 3150);
                yield return new fruitohms(45, 30.5, 3200);
                yield return new fruitohms(46, 30.5, 2500);
                yield return new fruitohms(47, 31.5, 3350);
                yield return new fruitohms(48, 31.5, 3700);
                yield return new fruitohms(49, 31.5, 4200);
                yield return new fruitohms(50, 32, 3850);
                yield return new fruitohms(51, 32.5, 3850);
                yield return new fruitohms(52, 32.5, 400);
                yield return new fruitohms(53, 35, 3000);
                yield return new fruitohms(54, 35, 4150);
                yield return new fruitohms(57, 36.5, 3200);
                yield return new fruitohms(58, 36.5, 5400);
                yield return new fruitohms(55, 37.5, 2800);
                yield return new fruitohms(59, 37.5, 2550);
                yield return new fruitohms(56, 38, 4150);
                yield return new fruitohms(60, 39.5, 4150);
                yield return new fruitohms(61, 40, 2950);
                yield return new fruitohms(95, 40, 2700);
                yield return new fruitohms(62, 41, 4400);
                yield return new fruitohms(63, 41, 4250);
                yield return new fruitohms(64, 41.5, 4100);
                yield return new fruitohms(65, 41.5, 3350);
                yield return new fruitohms(66, 42.5, 2700);
                yield return new fruitohms(67, 43, 2750);
                yield return new fruitohms(68, 43, 3150);
                yield return new fruitohms(69, 43, 3250);
                yield return new fruitohms(70, 43, 2300);
                yield return new fruitohms(71, 43.5, 1500);
                yield return new fruitohms(72, 43.5, 3750);
                yield return new fruitohms(73, 44, 1850);
                yield return new fruitohms(74, 44, 3550);
                yield return new fruitohms(75, 44.5, 3900);
                yield return new fruitohms(76, 44.5, 3550);
                yield return new fruitohms(77, 44.5, 3100);
                yield return new fruitohms(78, 44.5, 2700);
                yield return new fruitohms(79, 45, 3650);
                yield return new fruitohms(80, 45, 3500);
                yield return new fruitohms(81, 45, 2950);
                yield return new fruitohms(82, 45, 3650);
                yield return new fruitohms(83, 45, 3150);
                yield return new fruitohms(84, 45, 2650);
                yield return new fruitohms(85, 45.5, 3000);
                yield return new fruitohms(86, 46, 3000);
                yield return new fruitohms(88, 46, 4850);
                yield return new fruitohms(87, 46.5, 3550);
                yield return new fruitohms(89, 46.5, 3150);
                yield return new fruitohms(90, 47, 3500);
                yield return new fruitohms(91, 47.5, 3000);
                yield return new fruitohms(92, 47.5, 1950);
                yield return new fruitohms(93, 48, 3150);
                yield return new fruitohms(94, 48, 2400);
                yield return new fruitohms(96, 48, 2350);
                yield return new fruitohms(97, 48, 1900);
                yield return new fruitohms(98, 49, 2050);
                yield return new fruitohms(99, 49.5, 3350);
                yield return new fruitohms(100, 49.5, 3700);
                yield return new fruitohms(101, 50.5, 3550);
                yield return new fruitohms(102, 50.5, 2950);
                yield return new fruitohms(103, 50.5, 2900);
                yield return new fruitohms(104, 51.5, 3550);
                yield return new fruitohms(105, 51.5, 3500);
                yield return new fruitohms(106, 52, 4350);
                yield return new fruitohms(107, 52.5, 4050);
                yield return new fruitohms(108, 52.5, 2750);
                yield return new fruitohms(109, 53, 3150);
                yield return new fruitohms(110, 53, 3350);
                yield return new fruitohms(111, 53.5, 3300);
                yield return new fruitohms(112, 53.5, 3150);
                yield return new fruitohms(116, 53.5, 2450);
                yield return new fruitohms(113, 54, 3350);
                yield return new fruitohms(114, 54, 3850);
                yield return new fruitohms(115, 54, 2650);
                yield return new fruitohms(117, 55.5, 2450);
                yield return new fruitohms(118, 55.5, 3000);
                yield return new fruitohms(119, 56, 2550);
                yield return new fruitohms(120, 57, 3350);
                yield return new fruitohms(121, 58, 2150);
                yield return new fruitohms(122, 58.5, 3350);
                yield return new fruitohms(123, 58.5, 3650);
                yield return new fruitohms(124, 58.5, 3750);
                yield return new fruitohms(125, 58.5, 4550);
                yield return new fruitohms(126, 59.5, 3300);
                yield return new fruitohms(127, 60, 3600);
            }
        }
    }
}
