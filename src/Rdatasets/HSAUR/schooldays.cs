// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Days not Spent at School
    /// </summary>

    public class schooldays
    {
        public readonly string race;
        public readonly string sex;
        public readonly string school;
        public readonly string learner;
        public readonly int absent;

        public schooldays(string race, string sex, string school, string learner, int absent)
        {
            this.race = race;
            this.sex = sex;
            this.school = school;
            this.learner = learner;
            this.absent = absent;
        }

        public static IEnumerable<schooldays> Data
        {
            get
            {
                yield return new schooldays("aboriginal", "male", "F0", "slow", 2);
                yield return new schooldays("aboriginal", "male", "F0", "slow", 11);
                yield return new schooldays("aboriginal", "male", "F0", "slow", 14);
                yield return new schooldays("aboriginal", "male", "F0", "average", 5);
                yield return new schooldays("aboriginal", "male", "F0", "average", 5);
                yield return new schooldays("aboriginal", "male", "F0", "average", 13);
                yield return new schooldays("aboriginal", "male", "F0", "average", 20);
                yield return new schooldays("aboriginal", "male", "F0", "average", 22);
                yield return new schooldays("aboriginal", "male", "F1", "slow", 6);
                yield return new schooldays("aboriginal", "male", "F1", "slow", 6);
                yield return new schooldays("aboriginal", "male", "F1", "slow", 15);
                yield return new schooldays("aboriginal", "male", "F1", "average", 7);
                yield return new schooldays("aboriginal", "male", "F1", "average", 14);
                yield return new schooldays("aboriginal", "male", "F2", "slow", 6);
                yield return new schooldays("aboriginal", "male", "F2", "slow", 32);
                yield return new schooldays("aboriginal", "male", "F2", "slow", 53);
                yield return new schooldays("aboriginal", "male", "F2", "slow", 57);
                yield return new schooldays("aboriginal", "male", "F2", "average", 14);
                yield return new schooldays("aboriginal", "male", "F2", "average", 16);
                yield return new schooldays("aboriginal", "male", "F2", "average", 16);
                yield return new schooldays("aboriginal", "male", "F2", "average", 17);
                yield return new schooldays("aboriginal", "male", "F2", "average", 40);
                yield return new schooldays("aboriginal", "male", "F2", "average", 43);
                yield return new schooldays("aboriginal", "male", "F2", "average", 46);
                yield return new schooldays("aboriginal", "male", "F3", "slow", 12);
                yield return new schooldays("aboriginal", "male", "F3", "slow", 15);
                yield return new schooldays("aboriginal", "male", "F3", "average", 8);
                yield return new schooldays("aboriginal", "male", "F3", "average", 23);
                yield return new schooldays("aboriginal", "male", "F3", "average", 23);
                yield return new schooldays("aboriginal", "male", "F3", "average", 28);
                yield return new schooldays("aboriginal", "male", "F3", "average", 34);
                yield return new schooldays("aboriginal", "male", "F3", "average", 36);
                yield return new schooldays("aboriginal", "male", "F3", "average", 38);
                yield return new schooldays("aboriginal", "female", "F0", "slow", 3);
                yield return new schooldays("aboriginal", "female", "F0", "average", 5);
                yield return new schooldays("aboriginal", "female", "F0", "average", 11);
                yield return new schooldays("aboriginal", "female", "F0", "average", 24);
                yield return new schooldays("aboriginal", "female", "F0", "average", 45);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 6);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 6);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 9);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 13);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 23);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 25);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 32);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 53);
                yield return new schooldays("aboriginal", "female", "F1", "slow", 54);
                yield return new schooldays("aboriginal", "female", "F1", "average", 5);
                yield return new schooldays("aboriginal", "female", "F1", "average", 5);
                yield return new schooldays("aboriginal", "female", "F1", "average", 11);
                yield return new schooldays("aboriginal", "female", "F1", "average", 17);
                yield return new schooldays("aboriginal", "female", "F1", "average", 19);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 8);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 13);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 14);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 20);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 47);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 48);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 60);
                yield return new schooldays("aboriginal", "female", "F2", "slow", 81);
                yield return new schooldays("aboriginal", "female", "F2", "average", 2);
                yield return new schooldays("aboriginal", "female", "F3", "slow", 5);
                yield return new schooldays("aboriginal", "female", "F3", "slow", 9);
                yield return new schooldays("aboriginal", "female", "F3", "slow", 7);
                yield return new schooldays("aboriginal", "female", "F3", "average", 0);
                yield return new schooldays("aboriginal", "female", "F3", "average", 2);
                yield return new schooldays("aboriginal", "female", "F3", "average", 3);
                yield return new schooldays("aboriginal", "female", "F3", "average", 5);
                yield return new schooldays("aboriginal", "female", "F3", "average", 10);
                yield return new schooldays("aboriginal", "female", "F3", "average", 14);
                yield return new schooldays("aboriginal", "female", "F3", "average", 21);
                yield return new schooldays("aboriginal", "female", "F3", "average", 36);
                yield return new schooldays("aboriginal", "female", "F3", "average", 40);
                yield return new schooldays("non-aboriginal", "male", "F0", "slow", 6);
                yield return new schooldays("non-aboriginal", "male", "F0", "slow", 17);
                yield return new schooldays("non-aboriginal", "male", "F0", "slow", 67);
                yield return new schooldays("non-aboriginal", "male", "F0", "average", 0);
                yield return new schooldays("non-aboriginal", "male", "F0", "average", 0);
                yield return new schooldays("non-aboriginal", "male", "F0", "average", 2);
                yield return new schooldays("non-aboriginal", "male", "F0", "average", 7);
                yield return new schooldays("non-aboriginal", "male", "F0", "average", 11);
                yield return new schooldays("non-aboriginal", "male", "F0", "average", 12);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 0);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 0);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 11);
                yield return new schooldays("non-aboriginal", "male", "F1", "slow", 17);
                yield return new schooldays("non-aboriginal", "male", "F1", "average", 3);
                yield return new schooldays("non-aboriginal", "male", "F1", "average", 3);
                yield return new schooldays("non-aboriginal", "male", "F2", "slow", 22);
                yield return new schooldays("non-aboriginal", "male", "F1", "average", 30);
                yield return new schooldays("non-aboriginal", "male", "F1", "average", 36);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 8);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 0);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 1);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 5);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 7);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 16);
                yield return new schooldays("non-aboriginal", "male", "F2", "average", 27);
                yield return new schooldays("non-aboriginal", "male", "F3", "slow", 12);
                yield return new schooldays("non-aboriginal", "male", "F3", "slow", 15);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 0);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 30);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 10);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 14);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 27);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 41);
                yield return new schooldays("non-aboriginal", "male", "F3", "average", 69);
                yield return new schooldays("non-aboriginal", "female", "F0", "slow", 25);
                yield return new schooldays("non-aboriginal", "female", "F0", "average", 10);
                yield return new schooldays("non-aboriginal", "female", "F0", "average", 11);
                yield return new schooldays("non-aboriginal", "female", "F0", "average", 20);
                yield return new schooldays("non-aboriginal", "female", "F0", "average", 33);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 7);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 0);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 1);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 5);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 7);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 11);
                yield return new schooldays("non-aboriginal", "female", "F1", "slow", 15);
                yield return new schooldays("non-aboriginal", "female", "F1", "average", 5);
                yield return new schooldays("non-aboriginal", "female", "F1", "average", 14);
                yield return new schooldays("non-aboriginal", "female", "F1", "average", 6);
                yield return new schooldays("non-aboriginal", "female", "F1", "average", 6);
                yield return new schooldays("non-aboriginal", "female", "F1", "average", 7);
                yield return new schooldays("non-aboriginal", "female", "F1", "average", 28);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 0);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 5);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 14);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 2);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 2);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 3);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 8);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 10);
                yield return new schooldays("non-aboriginal", "female", "F2", "slow", 12);
                yield return new schooldays("non-aboriginal", "female", "F2", "average", 1);
                yield return new schooldays("non-aboriginal", "female", "F3", "slow", 8);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 1);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 9);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 22);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 3);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 3);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 5);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 15);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 18);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 22);
                yield return new schooldays("non-aboriginal", "female", "F3", "average", 37);
            }
        }
    }
}
