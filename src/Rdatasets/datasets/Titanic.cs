// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival of passengers on the Titanic
    /// </summary>

    public class Titanic
    {
        public readonly string Class;
        public readonly string Sex;
        public readonly string Age;
        public readonly string Survived;
        public readonly int Freq;

        public Titanic(string Class, string Sex, string Age, string Survived, int Freq)
        {
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
                yield return new Titanic("1st", "Male", "Child", "No", 0);
                yield return new Titanic("2nd", "Male", "Child", "No", 0);
                yield return new Titanic("3rd", "Male", "Child", "No", 35);
                yield return new Titanic("Crew", "Male", "Child", "No", 0);
                yield return new Titanic("1st", "Female", "Child", "No", 0);
                yield return new Titanic("2nd", "Female", "Child", "No", 0);
                yield return new Titanic("3rd", "Female", "Child", "No", 17);
                yield return new Titanic("Crew", "Female", "Child", "No", 0);
                yield return new Titanic("1st", "Male", "Adult", "No", 118);
                yield return new Titanic("2nd", "Male", "Adult", "No", 154);
                yield return new Titanic("3rd", "Male", "Adult", "No", 387);
                yield return new Titanic("Crew", "Male", "Adult", "No", 670);
                yield return new Titanic("1st", "Female", "Adult", "No", 4);
                yield return new Titanic("2nd", "Female", "Adult", "No", 13);
                yield return new Titanic("3rd", "Female", "Adult", "No", 89);
                yield return new Titanic("Crew", "Female", "Adult", "No", 3);
                yield return new Titanic("1st", "Male", "Child", "Yes", 5);
                yield return new Titanic("2nd", "Male", "Child", "Yes", 11);
                yield return new Titanic("3rd", "Male", "Child", "Yes", 13);
                yield return new Titanic("Crew", "Male", "Child", "Yes", 0);
                yield return new Titanic("1st", "Female", "Child", "Yes", 1);
                yield return new Titanic("2nd", "Female", "Child", "Yes", 13);
                yield return new Titanic("3rd", "Female", "Child", "Yes", 14);
                yield return new Titanic("Crew", "Female", "Child", "Yes", 0);
                yield return new Titanic("1st", "Male", "Adult", "Yes", 57);
                yield return new Titanic("2nd", "Male", "Adult", "Yes", 14);
                yield return new Titanic("3rd", "Male", "Adult", "Yes", 75);
                yield return new Titanic("Crew", "Male", "Adult", "Yes", 192);
                yield return new Titanic("1st", "Female", "Adult", "Yes", 140);
                yield return new Titanic("2nd", "Female", "Adult", "Yes", 80);
                yield return new Titanic("3rd", "Female", "Adult", "Yes", 76);
                yield return new Titanic("Crew", "Female", "Adult", "Yes", 20);
            }
        }
    }
}
