// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.6, p222
    /// </summary>

    public class drughiv
    {
        public readonly int κ;
        public readonly int drug;
        public readonly int time;
        public readonly int delta;

        public drughiv(int κ, int drug, int time, int delta)
        {
            this.κ = κ;
            this.drug = drug;
            this.time = time;
            this.delta = delta;
        }

        public static IEnumerable<drughiv> Data
        {
            get
            {
                yield return new drughiv(1, 1, 85, 1);
                yield return new drughiv(2, 1, 32, 1);
                yield return new drughiv(3, 1, 38, 0);
                yield return new drughiv(4, 1, 45, 1);
                yield return new drughiv(5, 1, 4, 0);
                yield return new drughiv(6, 1, 84, 1);
                yield return new drughiv(7, 1, 49, 1);
                yield return new drughiv(8, 1, 180, 0);
                yield return new drughiv(9, 1, 87, 1);
                yield return new drughiv(10, 1, 75, 1);
                yield return new drughiv(11, 1, 102, 1);
                yield return new drughiv(12, 1, 39, 1);
                yield return new drughiv(13, 1, 12, 1);
                yield return new drughiv(14, 1, 11, 1);
                yield return new drughiv(15, 1, 80, 1);
                yield return new drughiv(16, 1, 35, 1);
                yield return new drughiv(17, 1, 6, 1);
                yield return new drughiv(18, 2, 22, 1);
                yield return new drughiv(19, 2, 2, 1);
                yield return new drughiv(20, 2, 48, 1);
                yield return new drughiv(21, 2, 85, 1);
                yield return new drughiv(22, 2, 160, 1);
                yield return new drughiv(23, 2, 238, 1);
                yield return new drughiv(24, 2, 56, 0);
                yield return new drughiv(25, 2, 94, 0);
                yield return new drughiv(26, 2, 51, 0);
                yield return new drughiv(27, 2, 12, 1);
                yield return new drughiv(28, 2, 171, 1);
                yield return new drughiv(29, 2, 80, 1);
                yield return new drughiv(30, 2, 180, 1);
                yield return new drughiv(31, 2, 4, 1);
                yield return new drughiv(32, 2, 90, 1);
                yield return new drughiv(33, 2, 180, 0);
                yield return new drughiv(34, 2, 3, 1);
            }
        }
    }
}
