// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cuckoo
    /// </summary>

    public class Cuckoo
    {
        public readonly string Bird;
        public readonly double Length;

        public Cuckoo(string Bird, double Length)
        {
            this.Bird = Bird;
            this.Length = Length;
        }

        public static IEnumerable<Cuckoo> Data
        {
            get
            {
                yield return new Cuckoo("mdw_pippit", 19.65);
                yield return new Cuckoo("mdw_pippit", 20.05);
                yield return new Cuckoo("mdw_pippit", 20.65);
                yield return new Cuckoo("mdw_pippit", 20.85);
                yield return new Cuckoo("mdw_pippit", 21.65);
                yield return new Cuckoo("mdw_pippit", 21.65);
                yield return new Cuckoo("mdw_pippit", 21.65);
                yield return new Cuckoo("mdw_pippit", 21.85);
                yield return new Cuckoo("mdw_pippit", 21.85);
                yield return new Cuckoo("mdw_pippit", 21.85);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.05);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.25);
                yield return new Cuckoo("mdw_pippit", 22.45);
                yield return new Cuckoo("mdw_pippit", 22.45);
                yield return new Cuckoo("mdw_pippit", 22.45);
                yield return new Cuckoo("mdw_pippit", 22.65);
                yield return new Cuckoo("mdw_pippit", 22.65);
                yield return new Cuckoo("mdw_pippit", 22.85);
                yield return new Cuckoo("mdw_pippit", 22.85);
                yield return new Cuckoo("mdw_pippit", 22.85);
                yield return new Cuckoo("mdw_pippit", 22.85);
                yield return new Cuckoo("mdw_pippit", 23.05);
                yield return new Cuckoo("mdw_pippit", 23.25);
                yield return new Cuckoo("mdw_pippit", 23.25);
                yield return new Cuckoo("mdw_pippit", 23.45);
                yield return new Cuckoo("mdw_pippit", 23.65);
                yield return new Cuckoo("mdw_pippit", 23.85);
                yield return new Cuckoo("mdw_pippit", 24.25);
                yield return new Cuckoo("mdw_pippit", 24.45);
                yield return new Cuckoo("tree_pippit", 21.05);
                yield return new Cuckoo("tree_pippit", 21.85);
                yield return new Cuckoo("tree_pippit", 22.05);
                yield return new Cuckoo("tree_pippit", 22.45);
                yield return new Cuckoo("tree_pippit", 22.65);
                yield return new Cuckoo("tree_pippit", 23.25);
                yield return new Cuckoo("tree_pippit", 23.25);
                yield return new Cuckoo("tree_pippit", 23.25);
                yield return new Cuckoo("tree_pippit", 23.45);
                yield return new Cuckoo("tree_pippit", 23.45);
                yield return new Cuckoo("tree_pippit", 23.65);
                yield return new Cuckoo("tree_pippit", 23.85);
                yield return new Cuckoo("tree_pippit", 24.05);
                yield return new Cuckoo("tree_pippit", 24.05);
                yield return new Cuckoo("tree_pippit", 24.05);
                yield return new Cuckoo("hedge_sparrow", 20.85);
                yield return new Cuckoo("hedge_sparrow", 21.65);
                yield return new Cuckoo("hedge_sparrow", 22.05);
                yield return new Cuckoo("hedge_sparrow", 22.85);
                yield return new Cuckoo("hedge_sparrow", 23.05);
                yield return new Cuckoo("hedge_sparrow", 23.05);
                yield return new Cuckoo("hedge_sparrow", 23.05);
                yield return new Cuckoo("hedge_sparrow", 23.05);
                yield return new Cuckoo("hedge_sparrow", 23.45);
                yield return new Cuckoo("hedge_sparrow", 23.85);
                yield return new Cuckoo("hedge_sparrow", 23.85);
                yield return new Cuckoo("hedge_sparrow", 23.85);
                yield return new Cuckoo("hedge_sparrow", 24.05);
                yield return new Cuckoo("hedge_sparrow", 25.05);
                yield return new Cuckoo("robin", 21.05);
                yield return new Cuckoo("robin", 21.85);
                yield return new Cuckoo("robin", 22.05);
                yield return new Cuckoo("robin", 22.05);
                yield return new Cuckoo("robin", 22.05);
                yield return new Cuckoo("robin", 22.25);
                yield return new Cuckoo("robin", 22.45);
                yield return new Cuckoo("robin", 22.45);
                yield return new Cuckoo("robin", 22.65);
                yield return new Cuckoo("robin", 23.05);
                yield return new Cuckoo("robin", 23.05);
                yield return new Cuckoo("robin", 23.05);
                yield return new Cuckoo("robin", 23.05);
                yield return new Cuckoo("robin", 23.05);
                yield return new Cuckoo("robin", 23.25);
                yield return new Cuckoo("robin", 23.85);
                yield return new Cuckoo("wagtail", 21.05);
                yield return new Cuckoo("wagtail", 21.85);
                yield return new Cuckoo("wagtail", 21.85);
                yield return new Cuckoo("wagtail", 21.85);
                yield return new Cuckoo("wagtail", 22.05);
                yield return new Cuckoo("wagtail", 22.45);
                yield return new Cuckoo("wagtail", 22.65);
                yield return new Cuckoo("wagtail", 23.05);
                yield return new Cuckoo("wagtail", 23.05);
                yield return new Cuckoo("wagtail", 23.25);
                yield return new Cuckoo("wagtail", 23.45);
                yield return new Cuckoo("wagtail", 24.05);
                yield return new Cuckoo("wagtail", 24.05);
                yield return new Cuckoo("wagtail", 24.05);
                yield return new Cuckoo("wagtail", 24.85);
                yield return new Cuckoo("wren", 19.85);
                yield return new Cuckoo("wren", 20.05);
                yield return new Cuckoo("wren", 20.25);
                yield return new Cuckoo("wren", 20.85);
                yield return new Cuckoo("wren", 20.85);
                yield return new Cuckoo("wren", 20.85);
                yield return new Cuckoo("wren", 21.05);
                yield return new Cuckoo("wren", 21.05);
                yield return new Cuckoo("wren", 21.05);
                yield return new Cuckoo("wren", 21.25);
                yield return new Cuckoo("wren", 21.45);
                yield return new Cuckoo("wren", 22.05);
                yield return new Cuckoo("wren", 22.05);
                yield return new Cuckoo("wren", 22.05);
                yield return new Cuckoo("wren", 22.25);
            }
        }
    }
}
