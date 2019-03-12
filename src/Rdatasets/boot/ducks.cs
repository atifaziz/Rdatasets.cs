// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Behavioral and Plumage Characteristics of Hybrid Ducks
    /// </summary>

    public class ducks
    {
        public readonly int κ;
        public readonly int plumage;
        public readonly int behaviour;

        public ducks(int κ, int plumage, int behaviour)
        {
            this.κ = κ;
            this.plumage = plumage;
            this.behaviour = behaviour;
        }

        public static IEnumerable<ducks> Data
        {
            get
            {
                yield return new ducks(1, 7, 3);
                yield return new ducks(2, 13, 10);
                yield return new ducks(3, 14, 11);
                yield return new ducks(4, 6, 5);
                yield return new ducks(5, 14, 15);
                yield return new ducks(6, 15, 15);
                yield return new ducks(7, 4, 7);
                yield return new ducks(8, 8, 10);
                yield return new ducks(9, 7, 4);
                yield return new ducks(10, 9, 9);
                yield return new ducks(11, 14, 11);
            }
        }
    }
}
