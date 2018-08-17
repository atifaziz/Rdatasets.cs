// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Road Accident Deaths in US States
    /// </summary>

    public class road
    {
        public readonly int deaths;
        public readonly int drivers;
        public readonly double popden;
        public readonly double rural;
        public readonly int temp;
        public readonly double fuel;

        public road(int deaths, int drivers, double popden, double rural, int temp, double fuel)
        {
            this.deaths = deaths;
            this.drivers = drivers;
            this.popden = popden;
            this.rural = rural;
            this.temp = temp;
            this.fuel = fuel;
        }

        public static IEnumerable<road> Data
        {
            get
            {
                yield return new road(968, 158, 64, 66, 62, 119);
                yield return new road(43, 11, 0.4, 5.9, 30, 6.2);
                yield return new road(588, 91, 12, 33, 64, 65);
                yield return new road(640, 92, 34, 73, 51, 74);
                yield return new road(4743, 952, 100, 118, 65, 105);
                yield return new road(566, 109, 17, 73, 42, 78);
                yield return new road(325, 167, 518, 5.1, 37, 95);
                yield return new road(118, 30, 226, 3.4, 41, 20);
                yield return new road(115, 35, 12524, 0, 44, 23);
                yield return new road(1545, 298, 91, 57, 67, 216);
                yield return new road(1302, 203, 68, 83, 54, 162);
                yield return new road(262, 41, 8.1, 40, 36, 29);
                yield return new road(2207, 544, 180, 102, 33, 350);
                yield return new road(1410, 254, 129, 89, 37, 196);
                yield return new road(833, 150, 49, 100, 30, 109);
                yield return new road(669, 136, 27, 124, 42, 94);
                yield return new road(911, 147, 76, 65, 44, 104);
                yield return new road(1037, 146, 72, 40, 65, 109);
                yield return new road(1196, 46, 31, 19, 30, 37);
                yield return new road(616, 157, 314, 29, 44, 113);
                yield return new road(766, 255, 655, 17, 37, 166);
                yield return new road(2120, 403, 137, 95, 33, 306);
                yield return new road(841, 189, 43, 110, 22, 132);
                yield return new road(648, 85, 46, 59, 57, 77);
                yield return new road(1289, 234, 63, 100, 40, 180);
                yield return new road(259, 38, 4.6, 72, 29, 31);
            }
        }
    }
}
