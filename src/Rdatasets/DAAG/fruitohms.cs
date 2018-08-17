// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Electrical Resistance of Kiwi Fruit
    /// </summary>

    public class fruitohms
    {
        public readonly double juice;
        public readonly int ohms;

        public fruitohms(double juice, int ohms)
        {
            this.juice = juice;
            this.ohms = ohms;
        }

        public static IEnumerable<fruitohms> Data
        {
            get
            {
                yield return new fruitohms(4, 4860);
                yield return new fruitohms(5, 5860);
                yield return new fruitohms(5.5, 6650);
                yield return new fruitohms(7.5, 7050);
                yield return new fruitohms(8.5, 5960);
                yield return new fruitohms(8.5, 6750);
                yield return new fruitohms(8.5, 7650);
                yield return new fruitohms(9, 6900);
                yield return new fruitohms(9, 9850);
                yield return new fruitohms(9.5, 6650);
                yield return new fruitohms(10, 6250);
                yield return new fruitohms(10, 7600);
                yield return new fruitohms(10, 7900);
                yield return new fruitohms(10.5, 6150);
                yield return new fruitohms(10.5, 7150);
                yield return new fruitohms(11.5, 6700);
                yield return new fruitohms(11.5, 7900);
                yield return new fruitohms(12, 5800);
                yield return new fruitohms(12.5, 7050);
                yield return new fruitohms(13, 9000);
                yield return new fruitohms(13.5, 7350);
                yield return new fruitohms(13.5, 6650);
                yield return new fruitohms(13.5, 6950);
                yield return new fruitohms(14, 6650);
                yield return new fruitohms(14, 5700);
                yield return new fruitohms(14.5, 7900);
                yield return new fruitohms(15, 6500);
                yield return new fruitohms(16, 4850);
                yield return new fruitohms(16.5, 5600);
                yield return new fruitohms(16.5, 6300);
                yield return new fruitohms(17.5, 7150);
                yield return new fruitohms(17.5, 5900);
                yield return new fruitohms(19, 3900);
                yield return new fruitohms(20, 7500);
                yield return new fruitohms(20.5, 8500);
                yield return new fruitohms(21.5, 5600);
                yield return new fruitohms(21.5, 6950);
                yield return new fruitohms(21.5, 7200);
                yield return new fruitohms(23.5, 5750);
                yield return new fruitohms(24, 6900);
                yield return new fruitohms(24.5, 4100);
                yield return new fruitohms(28, 6700);
                yield return new fruitohms(28.5, 3900);
                yield return new fruitohms(30, 3500);
                yield return new fruitohms(30, 3150);
                yield return new fruitohms(30.5, 3200);
                yield return new fruitohms(30.5, 2500);
                yield return new fruitohms(31.5, 3350);
                yield return new fruitohms(31.5, 3700);
                yield return new fruitohms(31.5, 4200);
                yield return new fruitohms(32, 3850);
                yield return new fruitohms(32.5, 3850);
                yield return new fruitohms(32.5, 400);
                yield return new fruitohms(35, 3000);
                yield return new fruitohms(35, 4150);
                yield return new fruitohms(36.5, 3200);
                yield return new fruitohms(36.5, 5400);
                yield return new fruitohms(37.5, 2800);
                yield return new fruitohms(37.5, 2550);
                yield return new fruitohms(38, 4150);
                yield return new fruitohms(39.5, 4150);
                yield return new fruitohms(40, 2950);
                yield return new fruitohms(40, 2700);
                yield return new fruitohms(41, 4400);
                yield return new fruitohms(41, 4250);
                yield return new fruitohms(41.5, 4100);
                yield return new fruitohms(41.5, 3350);
                yield return new fruitohms(42.5, 2700);
                yield return new fruitohms(43, 2750);
                yield return new fruitohms(43, 3150);
                yield return new fruitohms(43, 3250);
                yield return new fruitohms(43, 2300);
                yield return new fruitohms(43.5, 1500);
                yield return new fruitohms(43.5, 3750);
                yield return new fruitohms(44, 1850);
                yield return new fruitohms(44, 3550);
                yield return new fruitohms(44.5, 3900);
                yield return new fruitohms(44.5, 3550);
                yield return new fruitohms(44.5, 3100);
                yield return new fruitohms(44.5, 2700);
                yield return new fruitohms(45, 3650);
                yield return new fruitohms(45, 3500);
                yield return new fruitohms(45, 2950);
                yield return new fruitohms(45, 3650);
                yield return new fruitohms(45, 3150);
                yield return new fruitohms(45, 2650);
                yield return new fruitohms(45.5, 3000);
                yield return new fruitohms(46, 3000);
                yield return new fruitohms(46, 4850);
                yield return new fruitohms(46.5, 3550);
                yield return new fruitohms(46.5, 3150);
                yield return new fruitohms(47, 3500);
                yield return new fruitohms(47.5, 3000);
                yield return new fruitohms(47.5, 1950);
                yield return new fruitohms(48, 3150);
                yield return new fruitohms(48, 2400);
                yield return new fruitohms(48, 2350);
                yield return new fruitohms(48, 1900);
                yield return new fruitohms(49, 2050);
                yield return new fruitohms(49.5, 3350);
                yield return new fruitohms(49.5, 3700);
                yield return new fruitohms(50.5, 3550);
                yield return new fruitohms(50.5, 2950);
                yield return new fruitohms(50.5, 2900);
                yield return new fruitohms(51.5, 3550);
                yield return new fruitohms(51.5, 3500);
                yield return new fruitohms(52, 4350);
                yield return new fruitohms(52.5, 4050);
                yield return new fruitohms(52.5, 2750);
                yield return new fruitohms(53, 3150);
                yield return new fruitohms(53, 3350);
                yield return new fruitohms(53.5, 3300);
                yield return new fruitohms(53.5, 3150);
                yield return new fruitohms(53.5, 2450);
                yield return new fruitohms(54, 3350);
                yield return new fruitohms(54, 3850);
                yield return new fruitohms(54, 2650);
                yield return new fruitohms(55.5, 2450);
                yield return new fruitohms(55.5, 3000);
                yield return new fruitohms(56, 2550);
                yield return new fruitohms(57, 3350);
                yield return new fruitohms(58, 2150);
                yield return new fruitohms(58.5, 3350);
                yield return new fruitohms(58.5, 3650);
                yield return new fruitohms(58.5, 3750);
                yield return new fruitohms(58.5, 4550);
                yield return new fruitohms(59.5, 3300);
                yield return new fruitohms(60, 3600);
            }
        }
    }
}
