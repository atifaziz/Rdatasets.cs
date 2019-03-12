// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Foot measurements in children
    /// </summary>

    public class KidsFeet
    {
        public readonly int κ;
        public readonly string name;
        public readonly int birthmonth;
        public readonly int birthyear;
        public readonly double length;
        public readonly double width;
        public readonly string sex;
        public readonly string biggerfoot;
        public readonly string domhand;

        public KidsFeet(int κ, string name, int birthmonth, int birthyear, double length, double width, string sex, string biggerfoot, string domhand)
        {
            this.κ = κ;
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
                yield return new KidsFeet(1, "David", 5, 88, 24.4, 8.4, "B", "L", "R");
                yield return new KidsFeet(2, "Lars", 10, 87, 25.4, 8.8, "B", "L", "L");
                yield return new KidsFeet(3, "Zach", 12, 87, 24.5, 9.7, "B", "R", "R");
                yield return new KidsFeet(4, "Josh", 1, 88, 25.2, 9.8, "B", "L", "R");
                yield return new KidsFeet(5, "Lang", 2, 88, 25.1, 8.9, "B", "L", "R");
                yield return new KidsFeet(6, "Scotty", 3, 88, 25.7, 9.7, "B", "R", "R");
                yield return new KidsFeet(7, "Edward", 2, 88, 26.1, 9.6, "B", "L", "R");
                yield return new KidsFeet(8, "Caitlin", 6, 88, 23, 8.8, "G", "L", "R");
                yield return new KidsFeet(9, "Eleanor", 5, 88, 23.6, 9.3, "G", "R", "R");
                yield return new KidsFeet(10, "Damon", 9, 88, 22.9, 8.8, "B", "R", "L");
                yield return new KidsFeet(11, "Mark", 9, 87, 27.5, 9.8, "B", "R", "R");
                yield return new KidsFeet(12, "Ray", 3, 88, 24.8, 8.9, "B", "L", "R");
                yield return new KidsFeet(13, "Cal", 8, 87, 26.1, 9.1, "B", "L", "R");
                yield return new KidsFeet(14, "Cam", 3, 88, 27, 9.8, "B", "L", "R");
                yield return new KidsFeet(15, "Julie", 11, 87, 26, 9.3, "G", "L", "R");
                yield return new KidsFeet(16, "Kate", 4, 88, 23.7, 7.9, "G", "R", "R");
                yield return new KidsFeet(17, "Caroline", 12, 87, 24, 8.7, "G", "R", "L");
                yield return new KidsFeet(18, "Maggie", 3, 88, 24.7, 8.8, "G", "R", "R");
                yield return new KidsFeet(19, "Lee", 6, 88, 26.7, 9, "G", "L", "L");
                yield return new KidsFeet(20, "Heather", 3, 88, 25.5, 9.5, "G", "R", "R");
                yield return new KidsFeet(21, "Andy", 6, 88, 24, 9.2, "B", "R", "R");
                yield return new KidsFeet(22, "Josh", 7, 88, 24.4, 8.6, "B", "L", "R");
                yield return new KidsFeet(23, "Laura", 9, 88, 24, 8.3, "G", "R", "L");
                yield return new KidsFeet(24, "Erica", 9, 88, 24.5, 9, "G", "L", "R");
                yield return new KidsFeet(25, "Peggy", 10, 88, 24.2, 8.1, "G", "L", "R");
                yield return new KidsFeet(26, "Glen", 7, 88, 27.1, 9.4, "B", "L", "R");
                yield return new KidsFeet(27, "Abby", 2, 88, 26.1, 9.5, "G", "L", "R");
                yield return new KidsFeet(28, "David", 12, 87, 25.5, 9.5, "B", "R", "R");
                yield return new KidsFeet(29, "Mike", 11, 88, 24.2, 8.9, "B", "L", "R");
                yield return new KidsFeet(30, "Dwayne", 8, 88, 23.9, 9.3, "B", "R", "L");
                yield return new KidsFeet(31, "Danielle", 6, 88, 24, 9.3, "G", "L", "R");
                yield return new KidsFeet(32, "Caitlin", 7, 88, 22.5, 8.6, "G", "R", "R");
                yield return new KidsFeet(33, "Leigh", 3, 88, 24.5, 8.6, "G", "L", "R");
                yield return new KidsFeet(34, "Dylan", 4, 88, 23.6, 9, "B", "R", "L");
                yield return new KidsFeet(35, "Peter", 4, 88, 24.7, 8.6, "B", "R", "L");
                yield return new KidsFeet(36, "Hannah", 3, 88, 22.9, 8.5, "G", "L", "R");
                yield return new KidsFeet(37, "Teshanna", 3, 88, 26, 9, "G", "L", "R");
                yield return new KidsFeet(38, "Hayley", 1, 88, 21.6, 7.9, "G", "R", "R");
                yield return new KidsFeet(39, "Alisha", 9, 88, 24.6, 8.8, "G", "L", "R");
            }
        }
    }
}
