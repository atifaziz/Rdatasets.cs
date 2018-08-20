// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Female Possum Measurements
    /// </summary>

    public class fossum
    {
        public readonly int @case;
        public readonly int site;
        public readonly string Pop;
        public readonly string sex;
        public readonly int age;
        public readonly double hdlngth;
        public readonly double skullw;
        public readonly double totlngth;
        public readonly double taill;
        public readonly double? footlgth;
        public readonly double earconch;
        public readonly double eye;
        public readonly double chest;
        public readonly double belly;

        public fossum(int @case, int site, string Pop, string sex, int age, double hdlngth, double skullw, double totlngth, double taill, double? footlgth, double earconch, double eye, double chest, double belly)
        {
            this.@case = @case;
            this.site = site;
            this.Pop = Pop;
            this.sex = sex;
            this.age = age;
            this.hdlngth = hdlngth;
            this.skullw = skullw;
            this.totlngth = totlngth;
            this.taill = taill;
            this.footlgth = footlgth;
            this.earconch = earconch;
            this.eye = eye;
            this.chest = chest;
            this.belly = belly;
        }

        public static IEnumerable<fossum> Data
        {
            get
            {
                yield return new fossum(2, 1, "Vic", "f", 6, 92.5, 57.6, 91.5, 36.5, 72.5, 51.2, 16, 28.5, 33);
                yield return new fossum(3, 1, "Vic", "f", 6, 94, 60, 95.5, 39, 75.4, 51.9, 15.5, 30, 34);
                yield return new fossum(4, 1, "Vic", "f", 6, 93.2, 57.1, 92, 38, 76.1, 52.2, 15.2, 28, 34);
                yield return new fossum(5, 1, "Vic", "f", 2, 91.5, 56.3, 85.5, 36, 71, 53.2, 15.1, 28.5, 33);
                yield return new fossum(6, 1, "Vic", "f", 1, 93.1, 54.8, 90.5, 35.5, 73.2, 53.6, 14.2, 30, 32);
                yield return new fossum(8, 1, "Vic", "f", 6, 94.8, 57.6, 91, 37, 72.7, 53.9, 14.5, 29, 34);
                yield return new fossum(9, 1, "Vic", "f", 9, 93.4, 56.3, 91.5, 37, 72.4, 52.9, 15.5, 28, 33);
                yield return new fossum(10, 1, "Vic", "f", 6, 91.8, 58, 89.5, 37.5, 70.9, 53.4, 14.4, 27.5, 32);
                yield return new fossum(11, 1, "Vic", "f", 9, 93.3, 57.2, 89.5, 39, 77.2, 51.3, 14.9, 31, 34);
                yield return new fossum(12, 1, "Vic", "f", 5, 94.9, 55.6, 92, 35.5, 71.7, 51, 15.3, 28, 33);
                yield return new fossum(17, 1, "Vic", "f", 1, 94.7, 67.7, 89.5, 36.5, 73.2, 53.2, 14.7, 29, 31);
                yield return new fossum(19, 1, "Vic", "f", 5, 94.4, 55.4, 90.5, 35, 73.4, 53.9, 15.2, 28, 32);
                yield return new fossum(20, 1, "Vic", "f", 4, 94.8, 56.3, 89, 38, 73.8, 52.4, 15.5, 27, 36);
                yield return new fossum(21, 1, "Vic", "f", 3, 95.9, 58.1, 96.5, 39.5, 77.9, 52.9, 14.2, 30, 40);
                yield return new fossum(23, 1, "Vic", "f", 4, 92.5, 56.1, 89, 36, 72.8, 53.3, 15.4, 28, 35);
                yield return new fossum(27, 1, "Vic", "f", 2, 90.5, 54.5, 85, 35, 70.3, 50.8, 14.2, 23, 28);
                yield return new fossum(29, 1, "Vic", "f", 3, 92.8, 56, 88, 35, 74.9, 51.8, 14, 24, 32);
                yield return new fossum(30, 1, "Vic", "f", 2, 92.1, 54.4, 84, 33.5, 70.6, 50.8, 14.5, 24.5, 33);
                yield return new fossum(32, 1, "Vic", "f", 4, 94.3, 56.7, 94, 39, 74.8, 52, 14.9, 28, 34);
                yield return new fossum(37, 2, "Vic", "f", 2, 89.3, 54.8, 82.5, 35, 71.2, 52, 13.6, 28, 31.5);
                yield return new fossum(39, 2, "Vic", "f", 1, 84.7, 51.5, 75, 34, 68.7, 53.4, 13, 25, 25);
                yield return new fossum(40, 2, "Vic", "f", 3, 91, 55, 84.5, 36, 72.8, 51.4, 13.6, 27, 30);
                yield return new fossum(41, 2, "Vic", "f", 5, 88.4, 57, 83, 36.5, null, 40.3, 15.9, 27, 30.5);
                yield return new fossum(43, 2, "Vic", "f", 2, 90, 55.5, 81, 32, 72, 49.4, 13.4, 29, 31);
                yield return new fossum(50, 3, "other", "f", 5, 91.6, 56.4, 88, 38, 65, 47.2, 14.9, 28, 36);
                yield return new fossum(51, 3, "other", "f", 5, 95.6, 59.6, 85, 36, 64, 43.9, 17.4, 28, 38.5);
                yield return new fossum(53, 3, "other", "f", 3, 93.1, 58.1, 91, 38, 67.4, 46, 16.5, 26, 33.5);
                yield return new fossum(57, 4, "other", "f", 4, 95.1, 59.4, 93, 41, 67.2, 45.3, 14.5, 31, 39);
                yield return new fossum(60, 4, "other", "f", 2, 91.3, 57.7, 88, 39, 63.1, 47, 14.4, 26, 30);
                yield return new fossum(62, 5, "other", "f", 3, 91.3, 58, 90.5, 39, 65.5, 41.3, 16, 27, 32);
                yield return new fossum(63, 5, "other", "f", 6, 92, 56.4, 88.5, 38, 64.1, 46.3, 15.2, 25.5, 28.5);
                yield return new fossum(64, 5, "other", "f", 3, 96.9, 56.5, 89.5, 38.5, 63, 45.1, 17.1, 25.5, 33);
                yield return new fossum(65, 5, "other", "f", 5, 93.5, 57.4, 88.5, 38, 68.2, 41.7, 14, 29, 38.5);
                yield return new fossum(66, 5, "other", "f", 3, 90.4, 55.8, 86, 36.5, 63.2, 44.2, 15.7, 26.5, 34);
                yield return new fossum(70, 5, "other", "f", 7, 91.9, 56.4, 87, 38, 65.4, 44.1, 13, 27, 34);
                yield return new fossum(74, 6, "other", "f", 4, 88.7, 52, 83, 38, 61.5, 45.9, 14.7, 26, 34);
                yield return new fossum(82, 6, "other", "f", 4, 86, 54, 82, 36.5, 60.7, 42.9, 15.4, 26, 32);
                yield return new fossum(83, 6, "other", "f", 3, 90, 53.8, 81.5, 36, 62, 43.3, 14, 25, 29);
                yield return new fossum(86, 6, "other", "f", 3, 88.2, 53.2, 86.5, 38.5, 60.3, 43.7, 13.6, 26, 31);
                yield return new fossum(88, 7, "other", "f", 2, 89.6, 58, 87.5, 38, 66.7, 43.5, 16, 25.5, 31.5);
                yield return new fossum(99, 7, "other", "f", 3, 93.3, 56.2, 86.5, 38.5, 64.8, 43.8, 14, 28, 35);
                yield return new fossum(102, 7, "other", "f", 6, 92.4, 55, 89, 38, 63.5, 45.4, 13, 25, 30);
                yield return new fossum(104, 7, "other", "f", 3, 93.6, 59.9, 89, 40, 67.6, 46, 14.8, 28.5, 33.5);
            }
        }
    }
}
