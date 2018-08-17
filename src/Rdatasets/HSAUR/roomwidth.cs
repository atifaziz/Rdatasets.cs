// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Students Estimates of Lecture Room Width
    /// </summary>

    public class roomwidth
    {
        public readonly string unit;
        public readonly int width;

        public roomwidth(string unit, int width)
        {
            this.unit = unit;
            this.width = width;
        }

        public static IEnumerable<roomwidth> Data
        {
            get
            {
                yield return new roomwidth("metres", 8);
                yield return new roomwidth("metres", 9);
                yield return new roomwidth("metres", 10);
                yield return new roomwidth("metres", 10);
                yield return new roomwidth("metres", 10);
                yield return new roomwidth("metres", 10);
                yield return new roomwidth("metres", 10);
                yield return new roomwidth("metres", 10);
                yield return new roomwidth("metres", 11);
                yield return new roomwidth("metres", 11);
                yield return new roomwidth("metres", 11);
                yield return new roomwidth("metres", 11);
                yield return new roomwidth("metres", 12);
                yield return new roomwidth("metres", 12);
                yield return new roomwidth("metres", 13);
                yield return new roomwidth("metres", 13);
                yield return new roomwidth("metres", 13);
                yield return new roomwidth("metres", 14);
                yield return new roomwidth("metres", 14);
                yield return new roomwidth("metres", 14);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 15);
                yield return new roomwidth("metres", 16);
                yield return new roomwidth("metres", 16);
                yield return new roomwidth("metres", 16);
                yield return new roomwidth("metres", 17);
                yield return new roomwidth("metres", 17);
                yield return new roomwidth("metres", 17);
                yield return new roomwidth("metres", 17);
                yield return new roomwidth("metres", 18);
                yield return new roomwidth("metres", 18);
                yield return new roomwidth("metres", 20);
                yield return new roomwidth("metres", 22);
                yield return new roomwidth("metres", 25);
                yield return new roomwidth("metres", 27);
                yield return new roomwidth("metres", 35);
                yield return new roomwidth("metres", 38);
                yield return new roomwidth("metres", 40);
                yield return new roomwidth("feet", 24);
                yield return new roomwidth("feet", 25);
                yield return new roomwidth("feet", 27);
                yield return new roomwidth("feet", 30);
                yield return new roomwidth("feet", 30);
                yield return new roomwidth("feet", 30);
                yield return new roomwidth("feet", 30);
                yield return new roomwidth("feet", 30);
                yield return new roomwidth("feet", 30);
                yield return new roomwidth("feet", 32);
                yield return new roomwidth("feet", 32);
                yield return new roomwidth("feet", 33);
                yield return new roomwidth("feet", 34);
                yield return new roomwidth("feet", 34);
                yield return new roomwidth("feet", 34);
                yield return new roomwidth("feet", 35);
                yield return new roomwidth("feet", 35);
                yield return new roomwidth("feet", 36);
                yield return new roomwidth("feet", 36);
                yield return new roomwidth("feet", 36);
                yield return new roomwidth("feet", 37);
                yield return new roomwidth("feet", 37);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 40);
                yield return new roomwidth("feet", 41);
                yield return new roomwidth("feet", 41);
                yield return new roomwidth("feet", 42);
                yield return new roomwidth("feet", 42);
                yield return new roomwidth("feet", 42);
                yield return new roomwidth("feet", 42);
                yield return new roomwidth("feet", 43);
                yield return new roomwidth("feet", 43);
                yield return new roomwidth("feet", 44);
                yield return new roomwidth("feet", 44);
                yield return new roomwidth("feet", 44);
                yield return new roomwidth("feet", 45);
                yield return new roomwidth("feet", 45);
                yield return new roomwidth("feet", 45);
                yield return new roomwidth("feet", 45);
                yield return new roomwidth("feet", 45);
                yield return new roomwidth("feet", 45);
                yield return new roomwidth("feet", 46);
                yield return new roomwidth("feet", 46);
                yield return new roomwidth("feet", 47);
                yield return new roomwidth("feet", 48);
                yield return new roomwidth("feet", 48);
                yield return new roomwidth("feet", 50);
                yield return new roomwidth("feet", 50);
                yield return new roomwidth("feet", 50);
                yield return new roomwidth("feet", 51);
                yield return new roomwidth("feet", 54);
                yield return new roomwidth("feet", 54);
                yield return new roomwidth("feet", 54);
                yield return new roomwidth("feet", 55);
                yield return new roomwidth("feet", 55);
                yield return new roomwidth("feet", 60);
                yield return new roomwidth("feet", 60);
                yield return new roomwidth("feet", 63);
                yield return new roomwidth("feet", 70);
                yield return new roomwidth("feet", 75);
                yield return new roomwidth("feet", 80);
                yield return new roomwidth("feet", 94);
            }
        }
    }
}
