// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Corporal Punishment Data
    /// </summary>

    public class Punishment
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string attitude;
        public readonly string memory;
        public readonly string education;
        public readonly string age;

        public Punishment(int κ, int Freq, string attitude, string memory, string education, string age)
        {
            this.κ = κ;
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
                yield return new Punishment(1, 1, "no", "yes", "elementary", "15-24");
                yield return new Punishment(2, 3, "no", "yes", "elementary", "25-39");
                yield return new Punishment(3, 20, "no", "yes", "elementary", "40-");
                yield return new Punishment(4, 2, "no", "yes", "secondary", "15-24");
                yield return new Punishment(5, 8, "no", "yes", "secondary", "25-39");
                yield return new Punishment(6, 4, "no", "yes", "secondary", "40-");
                yield return new Punishment(7, 2, "no", "yes", "high", "15-24");
                yield return new Punishment(8, 6, "no", "yes", "high", "25-39");
                yield return new Punishment(9, 1, "no", "yes", "high", "40-");
                yield return new Punishment(10, 26, "no", "no", "elementary", "15-24");
                yield return new Punishment(11, 46, "no", "no", "elementary", "25-39");
                yield return new Punishment(12, 109, "no", "no", "elementary", "40-");
                yield return new Punishment(13, 23, "no", "no", "secondary", "15-24");
                yield return new Punishment(14, 52, "no", "no", "secondary", "25-39");
                yield return new Punishment(15, 44, "no", "no", "secondary", "40-");
                yield return new Punishment(16, 26, "no", "no", "high", "15-24");
                yield return new Punishment(17, 24, "no", "no", "high", "25-39");
                yield return new Punishment(18, 13, "no", "no", "high", "40-");
                yield return new Punishment(19, 21, "moderate", "yes", "elementary", "15-24");
                yield return new Punishment(20, 41, "moderate", "yes", "elementary", "25-39");
                yield return new Punishment(21, 143, "moderate", "yes", "elementary", "40-");
                yield return new Punishment(22, 5, "moderate", "yes", "secondary", "15-24");
                yield return new Punishment(23, 20, "moderate", "yes", "secondary", "25-39");
                yield return new Punishment(24, 20, "moderate", "yes", "secondary", "40-");
                yield return new Punishment(25, 1, "moderate", "yes", "high", "15-24");
                yield return new Punishment(26, 4, "moderate", "yes", "high", "25-39");
                yield return new Punishment(27, 8, "moderate", "yes", "high", "40-");
                yield return new Punishment(28, 93, "moderate", "no", "elementary", "15-24");
                yield return new Punishment(29, 119, "moderate", "no", "elementary", "25-39");
                yield return new Punishment(30, 324, "moderate", "no", "elementary", "40-");
                yield return new Punishment(31, 45, "moderate", "no", "secondary", "15-24");
                yield return new Punishment(32, 84, "moderate", "no", "secondary", "25-39");
                yield return new Punishment(33, 56, "moderate", "no", "secondary", "40-");
                yield return new Punishment(34, 19, "moderate", "no", "high", "15-24");
                yield return new Punishment(35, 26, "moderate", "no", "high", "25-39");
                yield return new Punishment(36, 17, "moderate", "no", "high", "40-");
            }
        }
    }
}
