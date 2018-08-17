// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.13, p225
    /// </summary>

    public class rats
    {
        public readonly int time;
        public readonly int tumor;
        public readonly int trt;
        public readonly int litter;

        public rats(int time, int tumor, int trt, int litter)
        {
            this.time = time;
            this.tumor = tumor;
            this.trt = trt;
            this.litter = litter;
        }

        public static IEnumerable<rats> Data
        {
            get
            {
                yield return new rats(101, 0, 1, 1);
                yield return new rats(104, 0, 1, 2);
                yield return new rats(104, 0, 1, 3);
                yield return new rats(77, 0, 1, 4);
                yield return new rats(89, 0, 1, 5);
                yield return new rats(88, 1, 1, 6);
                yield return new rats(104, 1, 1, 7);
                yield return new rats(96, 1, 1, 8);
                yield return new rats(82, 0, 1, 9);
                yield return new rats(70, 1, 1, 10);
                yield return new rats(89, 1, 1, 11);
                yield return new rats(91, 0, 1, 12);
                yield return new rats(39, 1, 1, 13);
                yield return new rats(103, 1, 1, 14);
                yield return new rats(93, 0, 1, 15);
                yield return new rats(85, 0, 1, 16);
                yield return new rats(104, 0, 1, 17);
                yield return new rats(104, 0, 1, 18);
                yield return new rats(81, 0, 1, 19);
                yield return new rats(67, 1, 1, 20);
                yield return new rats(104, 0, 1, 21);
                yield return new rats(104, 0, 1, 22);
                yield return new rats(104, 0, 1, 23);
                yield return new rats(87, 0, 1, 24);
                yield return new rats(104, 0, 1, 25);
                yield return new rats(89, 0, 1, 26);
                yield return new rats(78, 0, 1, 27);
                yield return new rats(104, 0, 1, 28);
                yield return new rats(86, 1, 1, 29);
                yield return new rats(34, 1, 1, 30);
                yield return new rats(76, 0, 1, 31);
                yield return new rats(103, 1, 1, 32);
                yield return new rats(102, 1, 1, 33);
                yield return new rats(80, 1, 1, 34);
                yield return new rats(45, 1, 1, 35);
                yield return new rats(94, 1, 1, 36);
                yield return new rats(104, 0, 1, 37);
                yield return new rats(104, 0, 1, 38);
                yield return new rats(76, 0, 1, 39);
                yield return new rats(80, 1, 1, 40);
                yield return new rats(72, 1, 1, 41);
                yield return new rats(73, 1, 1, 42);
                yield return new rats(92, 1, 1, 43);
                yield return new rats(104, 0, 1, 44);
                yield return new rats(55, 0, 1, 45);
                yield return new rats(49, 0, 1, 46);
                yield return new rats(89, 1, 1, 47);
                yield return new rats(88, 0, 1, 48);
                yield return new rats(103, 1, 1, 49);
                yield return new rats(104, 0, 1, 50);
                yield return new rats(104, 0, 0, 1);
                yield return new rats(104, 0, 0, 2);
                yield return new rats(104, 0, 0, 3);
                yield return new rats(97, 0, 0, 4);
                yield return new rats(104, 0, 0, 5);
                yield return new rats(104, 0, 0, 6);
                yield return new rats(94, 0, 0, 7);
                yield return new rats(104, 0, 0, 8);
                yield return new rats(104, 0, 0, 9);
                yield return new rats(104, 0, 0, 10);
                yield return new rats(91, 0, 0, 11);
                yield return new rats(92, 0, 0, 12);
                yield return new rats(50, 1, 0, 13);
                yield return new rats(91, 0, 0, 14);
                yield return new rats(104, 0, 0, 15);
                yield return new rats(104, 0, 0, 16);
                yield return new rats(104, 0, 0, 17);
                yield return new rats(104, 0, 0, 18);
                yield return new rats(104, 0, 0, 19);
                yield return new rats(104, 0, 0, 20);
                yield return new rats(104, 0, 0, 21);
                yield return new rats(104, 0, 0, 22);
                yield return new rats(83, 0, 0, 23);
                yield return new rats(104, 0, 0, 24);
                yield return new rats(104, 0, 0, 25);
                yield return new rats(104, 0, 0, 26);
                yield return new rats(104, 0, 0, 27);
                yield return new rats(81, 1, 0, 28);
                yield return new rats(94, 0, 0, 29);
                yield return new rats(104, 0, 0, 30);
                yield return new rats(87, 0, 0, 31);
                yield return new rats(84, 1, 0, 32);
                yield return new rats(104, 0, 0, 33);
                yield return new rats(104, 0, 0, 34);
                yield return new rats(104, 0, 0, 35);
                yield return new rats(104, 0, 0, 36);
                yield return new rats(104, 0, 0, 37);
                yield return new rats(101, 1, 0, 38);
                yield return new rats(84, 1, 0, 39);
                yield return new rats(80, 1, 0, 40);
                yield return new rats(104, 0, 0, 41);
                yield return new rats(104, 0, 0, 42);
                yield return new rats(104, 0, 0, 43);
                yield return new rats(98, 0, 0, 44);
                yield return new rats(104, 0, 0, 45);
                yield return new rats(83, 0, 0, 46);
                yield return new rats(104, 0, 0, 47);
                yield return new rats(99, 0, 0, 48);
                yield return new rats(104, 0, 0, 49);
                yield return new rats(104, 0, 0, 50);
                yield return new rats(49, 1, 0, 1);
                yield return new rats(102, 0, 0, 2);
                yield return new rats(104, 0, 0, 3);
                yield return new rats(79, 0, 0, 4);
                yield return new rats(104, 0, 0, 5);
                yield return new rats(96, 1, 0, 6);
                yield return new rats(77, 1, 0, 7);
                yield return new rats(104, 0, 0, 8);
                yield return new rats(77, 0, 0, 9);
                yield return new rats(77, 0, 0, 10);
                yield return new rats(90, 0, 0, 11);
                yield return new rats(70, 0, 0, 12);
                yield return new rats(45, 0, 0, 13);
                yield return new rats(69, 0, 0, 14);
                yield return new rats(103, 0, 0, 15);
                yield return new rats(72, 0, 0, 16);
                yield return new rats(63, 0, 0, 17);
                yield return new rats(74, 0, 0, 18);
                yield return new rats(69, 0, 0, 19);
                yield return new rats(68, 1, 0, 20);
                yield return new rats(104, 0, 0, 21);
                yield return new rats(104, 0, 0, 22);
                yield return new rats(40, 1, 0, 23);
                yield return new rats(104, 0, 0, 24);
                yield return new rats(104, 0, 0, 25);
                yield return new rats(104, 0, 0, 26);
                yield return new rats(104, 0, 0, 27);
                yield return new rats(64, 1, 0, 28);
                yield return new rats(55, 1, 0, 29);
                yield return new rats(54, 1, 0, 30);
                yield return new rats(74, 0, 0, 31);
                yield return new rats(73, 1, 0, 32);
                yield return new rats(80, 0, 0, 33);
                yield return new rats(73, 0, 0, 34);
                yield return new rats(79, 0, 0, 35);
                yield return new rats(104, 0, 0, 36);
                yield return new rats(104, 0, 0, 37);
                yield return new rats(94, 0, 0, 38);
                yield return new rats(78, 1, 0, 39);
                yield return new rats(76, 0, 0, 40);
                yield return new rats(95, 0, 0, 41);
                yield return new rats(66, 1, 0, 42);
                yield return new rats(102, 1, 0, 43);
                yield return new rats(78, 0, 0, 44);
                yield return new rats(104, 0, 0, 45);
                yield return new rats(77, 0, 0, 46);
                yield return new rats(104, 0, 0, 47);
                yield return new rats(79, 0, 0, 48);
                yield return new rats(91, 0, 0, 49);
                yield return new rats(79, 1, 0, 50);
            }
        }
    }
}
