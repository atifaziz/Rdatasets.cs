// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival of passengers on the Titanic
    /// </summary>

    public class Titanic
    {
        public readonly int κ;
        public readonly string Class;
        public readonly string Sex;
        public readonly string Age;
        public readonly string Survived;
        public readonly int Freq;

        public Titanic(int κ, string Class, string Sex, string Age, string Survived, int Freq)
        {
            this.κ = κ;
            this.Class = Class;
            this.Sex = Sex;
            this.Age = Age;
            this.Survived = Survived;
            this.Freq = Freq;
        }

        public static IEnumerable<Titanic> Data
        {
            get
            {
                yield return new Titanic(1, "1st", "Male", "Child", "No", 0);
                yield return new Titanic(2, "2nd", "Male", "Child", "No", 0);
                yield return new Titanic(3, "3rd", "Male", "Child", "No", 35);
                yield return new Titanic(4, "Crew", "Male", "Child", "No", 0);
                yield return new Titanic(5, "1st", "Female", "Child", "No", 0);
                yield return new Titanic(6, "2nd", "Female", "Child", "No", 0);
                yield return new Titanic(7, "3rd", "Female", "Child", "No", 17);
                yield return new Titanic(8, "Crew", "Female", "Child", "No", 0);
                yield return new Titanic(9, "1st", "Male", "Adult", "No", 118);
                yield return new Titanic(10, "2nd", "Male", "Adult", "No", 154);
                yield return new Titanic(11, "3rd", "Male", "Adult", "No", 387);
                yield return new Titanic(12, "Crew", "Male", "Adult", "No", 670);
                yield return new Titanic(13, "1st", "Female", "Adult", "No", 4);
                yield return new Titanic(14, "2nd", "Female", "Adult", "No", 13);
                yield return new Titanic(15, "3rd", "Female", "Adult", "No", 89);
                yield return new Titanic(16, "Crew", "Female", "Adult", "No", 3);
                yield return new Titanic(17, "1st", "Male", "Child", "Yes", 5);
                yield return new Titanic(18, "2nd", "Male", "Child", "Yes", 11);
                yield return new Titanic(19, "3rd", "Male", "Child", "Yes", 13);
                yield return new Titanic(20, "Crew", "Male", "Child", "Yes", 0);
                yield return new Titanic(21, "1st", "Female", "Child", "Yes", 1);
                yield return new Titanic(22, "2nd", "Female", "Child", "Yes", 13);
                yield return new Titanic(23, "3rd", "Female", "Child", "Yes", 14);
                yield return new Titanic(24, "Crew", "Female", "Child", "Yes", 0);
                yield return new Titanic(25, "1st", "Male", "Adult", "Yes", 57);
                yield return new Titanic(26, "2nd", "Male", "Adult", "Yes", 14);
                yield return new Titanic(27, "3rd", "Male", "Adult", "Yes", 75);
                yield return new Titanic(28, "Crew", "Male", "Adult", "Yes", 192);
                yield return new Titanic(29, "1st", "Female", "Adult", "Yes", 140);
                yield return new Titanic(30, "2nd", "Female", "Adult", "Yes", 80);
                yield return new Titanic(31, "3rd", "Female", "Adult", "Yes", 76);
                yield return new Titanic(32, "Crew", "Female", "Adult", "Yes", 20);
            }
        }
    }
}
