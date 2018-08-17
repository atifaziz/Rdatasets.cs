// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Foot measurements in children
    /// </summary>

    public class KidsFeet
    {
        public readonly string name;
        public readonly int birthmonth;
        public readonly int birthyear;
        public readonly double length;
        public readonly double width;
        public readonly string sex;
        public readonly string biggerfoot;
        public readonly string domhand;

        public KidsFeet(string name, int birthmonth, int birthyear, double length, double width, string sex, string biggerfoot, string domhand)
        {
            this.name = name;
            this.birthmonth = birthmonth;
            this.birthyear = birthyear;
            this.length = length;
            this.width = width;
            this.sex = sex;
            this.biggerfoot = biggerfoot;
            this.domhand = domhand;
        }

        public static IEnumerable<KidsFeet> Data
        {
            get
            {
                yield return new KidsFeet("David", 5, 88, 24.4, 8.4, "B", "L", "R");
                yield return new KidsFeet("Lars", 10, 87, 25.4, 8.8, "B", "L", "L");
                yield return new KidsFeet("Zach", 12, 87, 24.5, 9.7, "B", "R", "R");
                yield return new KidsFeet("Josh", 1, 88, 25.2, 9.8, "B", "L", "R");
                yield return new KidsFeet("Lang", 2, 88, 25.1, 8.9, "B", "L", "R");
                yield return new KidsFeet("Scotty", 3, 88, 25.7, 9.7, "B", "R", "R");
                yield return new KidsFeet("Edward", 2, 88, 26.1, 9.6, "B", "L", "R");
                yield return new KidsFeet("Caitlin", 6, 88, 23, 8.8, "G", "L", "R");
                yield return new KidsFeet("Eleanor", 5, 88, 23.6, 9.3, "G", "R", "R");
                yield return new KidsFeet("Damon", 9, 88, 22.9, 8.8, "B", "R", "L");
                yield return new KidsFeet("Mark", 9, 87, 27.5, 9.8, "B", "R", "R");
                yield return new KidsFeet("Ray", 3, 88, 24.8, 8.9, "B", "L", "R");
                yield return new KidsFeet("Cal", 8, 87, 26.1, 9.1, "B", "L", "R");
                yield return new KidsFeet("Cam", 3, 88, 27, 9.8, "B", "L", "R");
                yield return new KidsFeet("Julie", 11, 87, 26, 9.3, "G", "L", "R");
                yield return new KidsFeet("Kate", 4, 88, 23.7, 7.9, "G", "R", "R");
                yield return new KidsFeet("Caroline", 12, 87, 24, 8.7, "G", "R", "L");
                yield return new KidsFeet("Maggie", 3, 88, 24.7, 8.8, "G", "R", "R");
                yield return new KidsFeet("Lee", 6, 88, 26.7, 9, "G", "L", "L");
                yield return new KidsFeet("Heather", 3, 88, 25.5, 9.5, "G", "R", "R");
                yield return new KidsFeet("Andy", 6, 88, 24, 9.2, "B", "R", "R");
                yield return new KidsFeet("Josh", 7, 88, 24.4, 8.6, "B", "L", "R");
                yield return new KidsFeet("Laura", 9, 88, 24, 8.3, "G", "R", "L");
                yield return new KidsFeet("Erica", 9, 88, 24.5, 9, "G", "L", "R");
                yield return new KidsFeet("Peggy", 10, 88, 24.2, 8.1, "G", "L", "R");
                yield return new KidsFeet("Glen", 7, 88, 27.1, 9.4, "B", "L", "R");
                yield return new KidsFeet("Abby", 2, 88, 26.1, 9.5, "G", "L", "R");
                yield return new KidsFeet("David", 12, 87, 25.5, 9.5, "B", "R", "R");
                yield return new KidsFeet("Mike", 11, 88, 24.2, 8.9, "B", "L", "R");
                yield return new KidsFeet("Dwayne", 8, 88, 23.9, 9.3, "B", "R", "L");
                yield return new KidsFeet("Danielle", 6, 88, 24, 9.3, "G", "L", "R");
                yield return new KidsFeet("Caitlin", 7, 88, 22.5, 8.6, "G", "R", "R");
                yield return new KidsFeet("Leigh", 3, 88, 24.5, 8.6, "G", "L", "R");
                yield return new KidsFeet("Dylan", 4, 88, 23.6, 9, "B", "R", "L");
                yield return new KidsFeet("Peter", 4, 88, 24.7, 8.6, "B", "R", "L");
                yield return new KidsFeet("Hannah", 3, 88, 22.9, 8.5, "G", "L", "R");
                yield return new KidsFeet("Teshanna", 3, 88, 26, 9, "G", "L", "R");
                yield return new KidsFeet("Hayley", 1, 88, 21.6, 7.9, "G", "R", "R");
                yield return new KidsFeet("Alisha", 9, 88, 24.6, 8.8, "G", "L", "R");
            }
        }
    }
}
