// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Opinions About Joint Sports
    /// </summary>

    public class JointSports
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string opinion;
        public readonly int year;
        public readonly string grade;
        public readonly string gender;

        public JointSports(int κ, int Freq, string opinion, int year, string grade, string gender)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.opinion = opinion;
            this.year = year;
            this.grade = grade;
            this.gender = gender;
        }

        public static IEnumerable<JointSports> Data
        {
            get
            {
                yield return new JointSports(1, 31, "very good", 1983, "1st", "Boy");
                yield return new JointSports(2, 103, "very good", 1983, "1st", "Girl");
                yield return new JointSports(3, 23, "very good", 1983, "3rd", "Boy");
                yield return new JointSports(4, 61, "very good", 1983, "3rd", "Girl");
                yield return new JointSports(5, 41, "very good", 1985, "1st", "Boy");
                yield return new JointSports(6, 77, "very good", 1985, "1st", "Girl");
                yield return new JointSports(7, 31, "very good", 1985, "3rd", "Boy");
                yield return new JointSports(8, 52, "very good", 1985, "3rd", "Girl");
                yield return new JointSports(9, 51, "good", 1983, "1st", "Boy");
                yield return new JointSports(10, 67, "good", 1983, "1st", "Girl");
                yield return new JointSports(11, 39, "good", 1983, "3rd", "Boy");
                yield return new JointSports(12, 72, "good", 1983, "3rd", "Girl");
                yield return new JointSports(13, 67, "good", 1985, "1st", "Boy");
                yield return new JointSports(14, 80, "good", 1985, "1st", "Girl");
                yield return new JointSports(15, 31, "good", 1985, "3rd", "Boy");
                yield return new JointSports(16, 70, "good", 1985, "3rd", "Girl");
                yield return new JointSports(17, 38, "indifferent", 1983, "1st", "Boy");
                yield return new JointSports(18, 29, "indifferent", 1983, "1st", "Girl");
                yield return new JointSports(19, 36, "indifferent", 1983, "3rd", "Boy");
                yield return new JointSports(20, 39, "indifferent", 1983, "3rd", "Girl");
                yield return new JointSports(21, 35, "indifferent", 1985, "1st", "Boy");
                yield return new JointSports(22, 27, "indifferent", 1985, "1st", "Girl");
                yield return new JointSports(23, 31, "indifferent", 1985, "3rd", "Boy");
                yield return new JointSports(24, 28, "indifferent", 1985, "3rd", "Girl");
                yield return new JointSports(25, 10, "bad", 1983, "1st", "Boy");
                yield return new JointSports(26, 15, "bad", 1983, "1st", "Girl");
                yield return new JointSports(27, 15, "bad", 1983, "3rd", "Boy");
                yield return new JointSports(28, 16, "bad", 1983, "3rd", "Girl");
                yield return new JointSports(29, 12, "bad", 1985, "1st", "Boy");
                yield return new JointSports(30, 10, "bad", 1985, "1st", "Girl");
                yield return new JointSports(31, 4, "bad", 1985, "3rd", "Boy");
                yield return new JointSports(32, 4, "bad", 1985, "3rd", "Girl");
                yield return new JointSports(33, 4, "very bad", 1983, "1st", "Boy");
                yield return new JointSports(34, 2, "very bad", 1983, "1st", "Girl");
                yield return new JointSports(35, 2, "very bad", 1983, "3rd", "Boy");
                yield return new JointSports(36, 3, "very bad", 1983, "3rd", "Girl");
                yield return new JointSports(37, 2, "very bad", 1985, "1st", "Boy");
                yield return new JointSports(38, 3, "very bad", 1985, "1st", "Girl");
                yield return new JointSports(39, 7, "very bad", 1985, "3rd", "Boy");
                yield return new JointSports(40, 3, "very bad", 1985, "3rd", "Girl");
            }
        }
    }
}
