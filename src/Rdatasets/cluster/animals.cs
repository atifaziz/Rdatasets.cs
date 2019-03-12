// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Attributes of Animals
    /// </summary>

    public class animals
    {
        public readonly string κ;
        public readonly int war;
        public readonly int fly;
        public readonly int ver;
        public readonly int? end;
        public readonly int? gro;
        public readonly int hai;

        public animals(string κ, int war, int fly, int ver, int? end, int? gro, int hai)
        {
            this.κ = κ;
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
                yield return new animals("ant", 1, 1, 1, 1, 2, 1);
                yield return new animals("bee", 1, 2, 1, 1, 2, 2);
                yield return new animals("cat", 2, 1, 2, 1, 1, 2);
                yield return new animals("cpl", 1, 1, 1, 1, 1, 2);
                yield return new animals("chi", 2, 1, 2, 2, 2, 2);
                yield return new animals("cow", 2, 1, 2, 1, 2, 2);
                yield return new animals("duc", 2, 2, 2, 1, 2, 1);
                yield return new animals("eag", 2, 2, 2, 2, 1, 1);
                yield return new animals("ele", 2, 1, 2, 2, 2, 1);
                yield return new animals("fly", 1, 2, 1, 1, 1, 1);
                yield return new animals("fro", 1, 1, 2, 2, null, 1);
                yield return new animals("her", 1, 1, 2, 1, 2, 1);
                yield return new animals("lio", 2, 1, 2, null, 2, 2);
                yield return new animals("liz", 1, 1, 2, 1, 1, 1);
                yield return new animals("lob", 1, 1, 1, 1, null, 1);
                yield return new animals("man", 2, 1, 2, 2, 2, 2);
                yield return new animals("rab", 2, 1, 2, 1, 2, 2);
                yield return new animals("sal", 1, 1, 2, 1, null, 1);
                yield return new animals("spi", 1, 1, 1, null, 1, 2);
                yield return new animals("wha", 2, 1, 2, 2, 2, 1);
            }
        }
    }
}
