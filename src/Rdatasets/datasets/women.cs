// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Average Heights and Weights for American Women
    /// </summary>

    public class women
    {
        public readonly int height;
        public readonly int weight;

        public women(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public static IEnumerable<women> Data
        {
            get
            {
                yield return new women(58, 115);
                yield return new women(59, 117);
                yield return new women(60, 120);
                yield return new women(61, 123);
                yield return new women(62, 126);
                yield return new women(63, 129);
                yield return new women(64, 132);
                yield return new women(65, 135);
                yield return new women(66, 139);
                yield return new women(67, 142);
                yield return new women(68, 146);
                yield return new women(69, 150);
                yield return new women(70, 154);
                yield return new women(71, 159);
                yield return new women(72, 164);
            }
        }
    }
}
