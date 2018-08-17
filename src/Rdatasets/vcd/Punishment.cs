// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Corporal Punishment Data
    /// </summary>

    public class Punishment
    {
        public readonly int Freq;
        public readonly string attitude;
        public readonly string memory;
        public readonly string education;
        public readonly string age;

        public Punishment(int Freq, string attitude, string memory, string education, string age)
        {
            this.Freq = Freq;
            this.attitude = attitude;
            this.memory = memory;
            this.education = education;
            this.age = age;
        }

        public static IEnumerable<Punishment> Data
        {
            get
            {
                yield return new Punishment(1, "no", "yes", "elementary", "15-24");
                yield return new Punishment(3, "no", "yes", "elementary", "25-39");
                yield return new Punishment(20, "no", "yes", "elementary", "40-");
                yield return new Punishment(2, "no", "yes", "secondary", "15-24");
                yield return new Punishment(8, "no", "yes", "secondary", "25-39");
                yield return new Punishment(4, "no", "yes", "secondary", "40-");
                yield return new Punishment(2, "no", "yes", "high", "15-24");
                yield return new Punishment(6, "no", "yes", "high", "25-39");
                yield return new Punishment(1, "no", "yes", "high", "40-");
                yield return new Punishment(26, "no", "no", "elementary", "15-24");
                yield return new Punishment(46, "no", "no", "elementary", "25-39");
                yield return new Punishment(109, "no", "no", "elementary", "40-");
                yield return new Punishment(23, "no", "no", "secondary", "15-24");
                yield return new Punishment(52, "no", "no", "secondary", "25-39");
                yield return new Punishment(44, "no", "no", "secondary", "40-");
                yield return new Punishment(26, "no", "no", "high", "15-24");
                yield return new Punishment(24, "no", "no", "high", "25-39");
                yield return new Punishment(13, "no", "no", "high", "40-");
                yield return new Punishment(21, "moderate", "yes", "elementary", "15-24");
                yield return new Punishment(41, "moderate", "yes", "elementary", "25-39");
                yield return new Punishment(143, "moderate", "yes", "elementary", "40-");
                yield return new Punishment(5, "moderate", "yes", "secondary", "15-24");
                yield return new Punishment(20, "moderate", "yes", "secondary", "25-39");
                yield return new Punishment(20, "moderate", "yes", "secondary", "40-");
                yield return new Punishment(1, "moderate", "yes", "high", "15-24");
                yield return new Punishment(4, "moderate", "yes", "high", "25-39");
                yield return new Punishment(8, "moderate", "yes", "high", "40-");
                yield return new Punishment(93, "moderate", "no", "elementary", "15-24");
                yield return new Punishment(119, "moderate", "no", "elementary", "25-39");
                yield return new Punishment(324, "moderate", "no", "elementary", "40-");
                yield return new Punishment(45, "moderate", "no", "secondary", "15-24");
                yield return new Punishment(84, "moderate", "no", "secondary", "25-39");
                yield return new Punishment(56, "moderate", "no", "secondary", "40-");
                yield return new Punishment(19, "moderate", "no", "high", "15-24");
                yield return new Punishment(26, "moderate", "no", "high", "25-39");
                yield return new Punishment(17, "moderate", "no", "high", "40-");
            }
        }
    }
}
