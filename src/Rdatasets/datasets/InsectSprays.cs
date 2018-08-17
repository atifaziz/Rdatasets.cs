// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Effectiveness of Insect Sprays
    /// </summary>

    public class InsectSprays
    {
        public readonly int count;
        public readonly string spray;

        public InsectSprays(int count, string spray)
        {
            this.count = count;
            this.spray = spray;
        }

        public static IEnumerable<InsectSprays> Data
        {
            get
            {
                yield return new InsectSprays(10, "A");
                yield return new InsectSprays(7, "A");
                yield return new InsectSprays(20, "A");
                yield return new InsectSprays(14, "A");
                yield return new InsectSprays(14, "A");
                yield return new InsectSprays(12, "A");
                yield return new InsectSprays(10, "A");
                yield return new InsectSprays(23, "A");
                yield return new InsectSprays(17, "A");
                yield return new InsectSprays(20, "A");
                yield return new InsectSprays(14, "A");
                yield return new InsectSprays(13, "A");
                yield return new InsectSprays(11, "B");
                yield return new InsectSprays(17, "B");
                yield return new InsectSprays(21, "B");
                yield return new InsectSprays(11, "B");
                yield return new InsectSprays(16, "B");
                yield return new InsectSprays(14, "B");
                yield return new InsectSprays(17, "B");
                yield return new InsectSprays(17, "B");
                yield return new InsectSprays(19, "B");
                yield return new InsectSprays(21, "B");
                yield return new InsectSprays(7, "B");
                yield return new InsectSprays(13, "B");
                yield return new InsectSprays(0, "C");
                yield return new InsectSprays(1, "C");
                yield return new InsectSprays(7, "C");
                yield return new InsectSprays(2, "C");
                yield return new InsectSprays(3, "C");
                yield return new InsectSprays(1, "C");
                yield return new InsectSprays(2, "C");
                yield return new InsectSprays(1, "C");
                yield return new InsectSprays(3, "C");
                yield return new InsectSprays(0, "C");
                yield return new InsectSprays(1, "C");
                yield return new InsectSprays(4, "C");
                yield return new InsectSprays(3, "D");
                yield return new InsectSprays(5, "D");
                yield return new InsectSprays(12, "D");
                yield return new InsectSprays(6, "D");
                yield return new InsectSprays(4, "D");
                yield return new InsectSprays(3, "D");
                yield return new InsectSprays(5, "D");
                yield return new InsectSprays(5, "D");
                yield return new InsectSprays(5, "D");
                yield return new InsectSprays(5, "D");
                yield return new InsectSprays(2, "D");
                yield return new InsectSprays(4, "D");
                yield return new InsectSprays(3, "E");
                yield return new InsectSprays(5, "E");
                yield return new InsectSprays(3, "E");
                yield return new InsectSprays(5, "E");
                yield return new InsectSprays(3, "E");
                yield return new InsectSprays(6, "E");
                yield return new InsectSprays(1, "E");
                yield return new InsectSprays(1, "E");
                yield return new InsectSprays(3, "E");
                yield return new InsectSprays(2, "E");
                yield return new InsectSprays(6, "E");
                yield return new InsectSprays(4, "E");
                yield return new InsectSprays(11, "F");
                yield return new InsectSprays(9, "F");
                yield return new InsectSprays(15, "F");
                yield return new InsectSprays(22, "F");
                yield return new InsectSprays(15, "F");
                yield return new InsectSprays(16, "F");
                yield return new InsectSprays(13, "F");
                yield return new InsectSprays(10, "F");
                yield return new InsectSprays(26, "F");
                yield return new InsectSprays(26, "F");
                yield return new InsectSprays(24, "F");
                yield return new InsectSprays(13, "F");
            }
        }
    }
}
