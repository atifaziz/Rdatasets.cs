// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Student's Sleep Data
    /// </summary>

    public class sleep
    {
        public readonly double extra;
        public readonly int group;
        public readonly int ID;

        public sleep(double extra, int group, int ID)
        {
            this.extra = extra;
            this.group = group;
            this.ID = ID;
        }

        public static IEnumerable<sleep> Data
        {
            get
            {
                yield return new sleep(0.7, 1, 1);
                yield return new sleep(-1.6, 1, 2);
                yield return new sleep(-0.2, 1, 3);
                yield return new sleep(-1.2, 1, 4);
                yield return new sleep(-0.1, 1, 5);
                yield return new sleep(3.4, 1, 6);
                yield return new sleep(3.7, 1, 7);
                yield return new sleep(0.8, 1, 8);
                yield return new sleep(0, 1, 9);
                yield return new sleep(2, 1, 10);
                yield return new sleep(1.9, 2, 1);
                yield return new sleep(0.8, 2, 2);
                yield return new sleep(1.1, 2, 3);
                yield return new sleep(0.1, 2, 4);
                yield return new sleep(-0.1, 2, 5);
                yield return new sleep(4.4, 2, 6);
                yield return new sleep(5.5, 2, 7);
                yield return new sleep(1.6, 2, 8);
                yield return new sleep(4.6, 2, 9);
                yield return new sleep(3.4, 2, 10);
            }
        }
    }
}
