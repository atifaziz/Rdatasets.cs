// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Attributes of Animals
    /// </summary>

    public class animals
    {
        public readonly int war;
        public readonly int fly;
        public readonly int ver;
        public readonly string end;
        public readonly string gro;
        public readonly int hai;

        public animals(int war, int fly, int ver, string end, string gro, int hai)
        {
            this.war = war;
            this.fly = fly;
            this.ver = ver;
            this.end = end;
            this.gro = gro;
            this.hai = hai;
        }

        public static IEnumerable<animals> Data
        {
            get
            {
                yield return new animals(1, 1, 1, "1", "2", 1);
                yield return new animals(1, 2, 1, "1", "2", 2);
                yield return new animals(2, 1, 2, "1", "1", 2);
                yield return new animals(1, 1, 1, "1", "1", 2);
                yield return new animals(2, 1, 2, "2", "2", 2);
                yield return new animals(2, 1, 2, "1", "2", 2);
                yield return new animals(2, 2, 2, "1", "2", 1);
                yield return new animals(2, 2, 2, "2", "1", 1);
                yield return new animals(2, 1, 2, "2", "2", 1);
                yield return new animals(1, 2, 1, "1", "1", 1);
                yield return new animals(1, 1, 2, "2", null, 1);
                yield return new animals(1, 1, 2, "1", "2", 1);
                yield return new animals(2, 1, 2, null, "2", 2);
                yield return new animals(1, 1, 2, "1", "1", 1);
                yield return new animals(1, 1, 1, "1", null, 1);
                yield return new animals(2, 1, 2, "2", "2", 2);
                yield return new animals(2, 1, 2, "1", "2", 2);
                yield return new animals(1, 1, 2, "1", null, 1);
                yield return new animals(1, 1, 1, null, "1", 2);
                yield return new animals(2, 1, 2, "2", "2", 1);
            }
        }
    }
}
