// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Opinions About Joint Sports
    /// </summary>

    public class JointSports
    {
        public readonly int Freq;
        public readonly string opinion;
        public readonly int year;
        public readonly string grade;
        public readonly string gender;

        public JointSports(int Freq, string opinion, int year, string grade, string gender)
        {
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
                yield return new JointSports(31, "very good", 1983, "1st", "Boy");
                yield return new JointSports(103, "very good", 1983, "1st", "Girl");
                yield return new JointSports(23, "very good", 1983, "3rd", "Boy");
                yield return new JointSports(61, "very good", 1983, "3rd", "Girl");
                yield return new JointSports(41, "very good", 1985, "1st", "Boy");
                yield return new JointSports(77, "very good", 1985, "1st", "Girl");
                yield return new JointSports(31, "very good", 1985, "3rd", "Boy");
                yield return new JointSports(52, "very good", 1985, "3rd", "Girl");
                yield return new JointSports(51, "good", 1983, "1st", "Boy");
                yield return new JointSports(67, "good", 1983, "1st", "Girl");
                yield return new JointSports(39, "good", 1983, "3rd", "Boy");
                yield return new JointSports(72, "good", 1983, "3rd", "Girl");
                yield return new JointSports(67, "good", 1985, "1st", "Boy");
                yield return new JointSports(80, "good", 1985, "1st", "Girl");
                yield return new JointSports(31, "good", 1985, "3rd", "Boy");
                yield return new JointSports(70, "good", 1985, "3rd", "Girl");
                yield return new JointSports(38, "indifferent", 1983, "1st", "Boy");
                yield return new JointSports(29, "indifferent", 1983, "1st", "Girl");
                yield return new JointSports(36, "indifferent", 1983, "3rd", "Boy");
                yield return new JointSports(39, "indifferent", 1983, "3rd", "Girl");
                yield return new JointSports(35, "indifferent", 1985, "1st", "Boy");
                yield return new JointSports(27, "indifferent", 1985, "1st", "Girl");
                yield return new JointSports(31, "indifferent", 1985, "3rd", "Boy");
                yield return new JointSports(28, "indifferent", 1985, "3rd", "Girl");
                yield return new JointSports(10, "bad", 1983, "1st", "Boy");
                yield return new JointSports(15, "bad", 1983, "1st", "Girl");
                yield return new JointSports(15, "bad", 1983, "3rd", "Boy");
                yield return new JointSports(16, "bad", 1983, "3rd", "Girl");
                yield return new JointSports(12, "bad", 1985, "1st", "Boy");
                yield return new JointSports(10, "bad", 1985, "1st", "Girl");
                yield return new JointSports(4, "bad", 1985, "3rd", "Boy");
                yield return new JointSports(4, "bad", 1985, "3rd", "Girl");
                yield return new JointSports(4, "very bad", 1983, "1st", "Boy");
                yield return new JointSports(2, "very bad", 1983, "1st", "Girl");
                yield return new JointSports(2, "very bad", 1983, "3rd", "Boy");
                yield return new JointSports(3, "very bad", 1983, "3rd", "Girl");
                yield return new JointSports(2, "very bad", 1985, "1st", "Boy");
                yield return new JointSports(3, "very bad", 1985, "1st", "Girl");
                yield return new JointSports(7, "very bad", 1985, "3rd", "Boy");
                yield return new JointSports(3, "very bad", 1985, "3rd", "Girl");
            }
        }
    }
}
