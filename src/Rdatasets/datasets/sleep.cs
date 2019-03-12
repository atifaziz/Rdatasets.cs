// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Student's Sleep Data
    /// </summary>

    public class sleep
    {
        public readonly int κ;
        public readonly double extra;
        public readonly int group;
        public readonly int ID;

        public sleep(int κ, double extra, int group, int ID)
        {
            this.κ = κ;
            this.extra = extra;
            this.group = group;
            this.ID = ID;
        }

        public static IEnumerable<sleep> Data
        {
            get
            {
                yield return new sleep(1, 0.7, 1, 1);
                yield return new sleep(2, -1.6, 1, 2);
                yield return new sleep(3, -0.2, 1, 3);
                yield return new sleep(4, -1.2, 1, 4);
                yield return new sleep(5, -0.1, 1, 5);
                yield return new sleep(6, 3.4, 1, 6);
                yield return new sleep(7, 3.7, 1, 7);
                yield return new sleep(8, 0.8, 1, 8);
                yield return new sleep(9, 0, 1, 9);
                yield return new sleep(10, 2, 1, 10);
                yield return new sleep(11, 1.9, 2, 1);
                yield return new sleep(12, 0.8, 2, 2);
                yield return new sleep(13, 1.1, 2, 3);
                yield return new sleep(14, 0.1, 2, 4);
                yield return new sleep(15, -0.1, 2, 5);
                yield return new sleep(16, 4.4, 2, 6);
                yield return new sleep(17, 5.5, 2, 7);
                yield return new sleep(18, 1.6, 2, 8);
                yield return new sleep(19, 4.6, 2, 9);
                yield return new sleep(20, 3.4, 2, 10);
            }
        }
    }
}
