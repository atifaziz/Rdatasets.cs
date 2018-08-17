// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.6, p222
    /// </summary>

    public class drughiv
    {
        public readonly int drug;
        public readonly int time;
        public readonly int delta;

        public drughiv(int drug, int time, int delta)
        {
            this.drug = drug;
            this.time = time;
            this.delta = delta;
        }

        public static IEnumerable<drughiv> Data
        {
            get
            {
                yield return new drughiv(1, 85, 1);
                yield return new drughiv(1, 32, 1);
                yield return new drughiv(1, 38, 0);
                yield return new drughiv(1, 45, 1);
                yield return new drughiv(1, 4, 0);
                yield return new drughiv(1, 84, 1);
                yield return new drughiv(1, 49, 1);
                yield return new drughiv(1, 180, 0);
                yield return new drughiv(1, 87, 1);
                yield return new drughiv(1, 75, 1);
                yield return new drughiv(1, 102, 1);
                yield return new drughiv(1, 39, 1);
                yield return new drughiv(1, 12, 1);
                yield return new drughiv(1, 11, 1);
                yield return new drughiv(1, 80, 1);
                yield return new drughiv(1, 35, 1);
                yield return new drughiv(1, 6, 1);
                yield return new drughiv(2, 22, 1);
                yield return new drughiv(2, 2, 1);
                yield return new drughiv(2, 48, 1);
                yield return new drughiv(2, 85, 1);
                yield return new drughiv(2, 160, 1);
                yield return new drughiv(2, 238, 1);
                yield return new drughiv(2, 56, 0);
                yield return new drughiv(2, 94, 0);
                yield return new drughiv(2, 51, 0);
                yield return new drughiv(2, 12, 1);
                yield return new drughiv(2, 171, 1);
                yield return new drughiv(2, 80, 1);
                yield return new drughiv(2, 180, 1);
                yield return new drughiv(2, 4, 1);
                yield return new drughiv(2, 90, 1);
                yield return new drughiv(2, 180, 0);
                yield return new drughiv(2, 3, 1);
            }
        }
    }
}
