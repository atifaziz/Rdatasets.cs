// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Behavioral and Plumage Characteristics of Hybrid Ducks
    /// </summary>

    public class ducks
    {
        public readonly int plumage;
        public readonly int behaviour;

        public ducks(int plumage, int behaviour)
        {
            this.plumage = plumage;
            this.behaviour = behaviour;
        }

        public static IEnumerable<ducks> Data
        {
            get
            {
                yield return new ducks(7, 3);
                yield return new ducks(13, 10);
                yield return new ducks(14, 11);
                yield return new ducks(6, 5);
                yield return new ducks(14, 15);
                yield return new ducks(15, 15);
                yield return new ducks(4, 7);
                yield return new ducks(8, 10);
                yield return new ducks(7, 4);
                yield return new ducks(9, 9);
                yield return new ducks(14, 11);
            }
        }
    }
}
