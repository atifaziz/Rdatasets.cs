// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Average Heights and Weights for American Women
    /// </summary>

    public class women
    {
        public readonly int κ;
        public readonly int height;
        public readonly int weight;

        public women(int κ, int height, int weight)
        {
            this.κ = κ;
            this.height = height;
            this.weight = weight;
        }

        public static IEnumerable<women> Data
        {
            get
            {
                yield return new women(1, 58, 115);
                yield return new women(2, 59, 117);
                yield return new women(3, 60, 120);
                yield return new women(4, 61, 123);
                yield return new women(5, 62, 126);
                yield return new women(6, 63, 129);
                yield return new women(7, 64, 132);
                yield return new women(8, 65, 135);
                yield return new women(9, 66, 139);
                yield return new women(10, 67, 142);
                yield return new women(11, 68, 146);
                yield return new women(12, 69, 150);
                yield return new women(13, 70, 154);
                yield return new women(14, 71, 159);
                yield return new women(15, 72, 164);
            }
        }
    }
}
