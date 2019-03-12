// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Edgar Anderson's Iris Data
    /// </summary>

    public class iris3
    {
        public readonly int κ;
        public readonly double Sepal_L__Setosa;
        public readonly double Sepal_W__Setosa;
        public readonly double Petal_L__Setosa;
        public readonly double Petal_W__Setosa;
        public readonly double Sepal_L__Versicolor;
        public readonly double Sepal_W__Versicolor;
        public readonly double Petal_L__Versicolor;
        public readonly double Petal_W__Versicolor;
        public readonly double Sepal_L__Virginica;
        public readonly double Sepal_W__Virginica;
        public readonly double Petal_L__Virginica;
        public readonly double Petal_W__Virginica;

        public iris3(int κ, double Sepal_L__Setosa, double Sepal_W__Setosa, double Petal_L__Setosa, double Petal_W__Setosa, double Sepal_L__Versicolor, double Sepal_W__Versicolor, double Petal_L__Versicolor, double Petal_W__Versicolor, double Sepal_L__Virginica, double Sepal_W__Virginica, double Petal_L__Virginica, double Petal_W__Virginica)
        {
            this.κ = κ;
            this.Sepal_L__Setosa = Sepal_L__Setosa;
            this.Sepal_W__Setosa = Sepal_W__Setosa;
            this.Petal_L__Setosa = Petal_L__Setosa;
            this.Petal_W__Setosa = Petal_W__Setosa;
            this.Sepal_L__Versicolor = Sepal_L__Versicolor;
            this.Sepal_W__Versicolor = Sepal_W__Versicolor;
            this.Petal_L__Versicolor = Petal_L__Versicolor;
            this.Petal_W__Versicolor = Petal_W__Versicolor;
            this.Sepal_L__Virginica = Sepal_L__Virginica;
            this.Sepal_W__Virginica = Sepal_W__Virginica;
            this.Petal_L__Virginica = Petal_L__Virginica;
            this.Petal_W__Virginica = Petal_W__Virginica;
        }

        public static IEnumerable<iris3> Data
        {
            get
            {
                yield return new iris3(1, 5.1, 3.5, 1.4, 0.2, 7, 3.2, 4.7, 1.4, 6.3, 3.3, 6, 2.5);
                yield return new iris3(2, 4.9, 3, 1.4, 0.2, 6.4, 3.2, 4.5, 1.5, 5.8, 2.7, 5.1, 1.9);
                yield return new iris3(3, 4.7, 3.2, 1.3, 0.2, 6.9, 3.1, 4.9, 1.5, 7.1, 3, 5.9, 2.1);
                yield return new iris3(4, 4.6, 3.1, 1.5, 0.2, 5.5, 2.3, 4, 1.3, 6.3, 2.9, 5.6, 1.8);
                yield return new iris3(5, 5, 3.6, 1.4, 0.2, 6.5, 2.8, 4.6, 1.5, 6.5, 3, 5.8, 2.2);
                yield return new iris3(6, 5.4, 3.9, 1.7, 0.4, 5.7, 2.8, 4.5, 1.3, 7.6, 3, 6.6, 2.1);
                yield return new iris3(7, 4.6, 3.4, 1.4, 0.3, 6.3, 3.3, 4.7, 1.6, 4.9, 2.5, 4.5, 1.7);
                yield return new iris3(8, 5, 3.4, 1.5, 0.2, 4.9, 2.4, 3.3, 1, 7.3, 2.9, 6.3, 1.8);
                yield return new iris3(9, 4.4, 2.9, 1.4, 0.2, 6.6, 2.9, 4.6, 1.3, 6.7, 2.5, 5.8, 1.8);
                yield return new iris3(10, 4.9, 3.1, 1.5, 0.1, 5.2, 2.7, 3.9, 1.4, 7.2, 3.6, 6.1, 2.5);
                yield return new iris3(11, 5.4, 3.7, 1.5, 0.2, 5, 2, 3.5, 1, 6.5, 3.2, 5.1, 2);
                yield return new iris3(12, 4.8, 3.4, 1.6, 0.2, 5.9, 3, 4.2, 1.5, 6.4, 2.7, 5.3, 1.9);
                yield return new iris3(13, 4.8, 3, 1.4, 0.1, 6, 2.2, 4, 1, 6.8, 3, 5.5, 2.1);
                yield return new iris3(14, 4.3, 3, 1.1, 0.1, 6.1, 2.9, 4.7, 1.4, 5.7, 2.5, 5, 2);
                yield return new iris3(15, 5.8, 4, 1.2, 0.2, 5.6, 2.9, 3.6, 1.3, 5.8, 2.8, 5.1, 2.4);
                yield return new iris3(16, 5.7, 4.4, 1.5, 0.4, 6.7, 3.1, 4.4, 1.4, 6.4, 3.2, 5.3, 2.3);
                yield return new iris3(17, 5.4, 3.9, 1.3, 0.4, 5.6, 3, 4.5, 1.5, 6.5, 3, 5.5, 1.8);
                yield return new iris3(18, 5.1, 3.5, 1.4, 0.3, 5.8, 2.7, 4.1, 1, 7.7, 3.8, 6.7, 2.2);
                yield return new iris3(19, 5.7, 3.8, 1.7, 0.3, 6.2, 2.2, 4.5, 1.5, 7.7, 2.6, 6.9, 2.3);
                yield return new iris3(20, 5.1, 3.8, 1.5, 0.3, 5.6, 2.5, 3.9, 1.1, 6, 2.2, 5, 1.5);
                yield return new iris3(21, 5.4, 3.4, 1.7, 0.2, 5.9, 3.2, 4.8, 1.8, 6.9, 3.2, 5.7, 2.3);
                yield return new iris3(22, 5.1, 3.7, 1.5, 0.4, 6.1, 2.8, 4, 1.3, 5.6, 2.8, 4.9, 2);
                yield return new iris3(23, 4.6, 3.6, 1, 0.2, 6.3, 2.5, 4.9, 1.5, 7.7, 2.8, 6.7, 2);
                yield return new iris3(24, 5.1, 3.3, 1.7, 0.5, 6.1, 2.8, 4.7, 1.2, 6.3, 2.7, 4.9, 1.8);
                yield return new iris3(25, 4.8, 3.4, 1.9, 0.2, 6.4, 2.9, 4.3, 1.3, 6.7, 3.3, 5.7, 2.1);
                yield return new iris3(26, 5, 3, 1.6, 0.2, 6.6, 3, 4.4, 1.4, 7.2, 3.2, 6, 1.8);
                yield return new iris3(27, 5, 3.4, 1.6, 0.4, 6.8, 2.8, 4.8, 1.4, 6.2, 2.8, 4.8, 1.8);
                yield return new iris3(28, 5.2, 3.5, 1.5, 0.2, 6.7, 3, 5, 1.7, 6.1, 3, 4.9, 1.8);
                yield return new iris3(29, 5.2, 3.4, 1.4, 0.2, 6, 2.9, 4.5, 1.5, 6.4, 2.8, 5.6, 2.1);
                yield return new iris3(30, 4.7, 3.2, 1.6, 0.2, 5.7, 2.6, 3.5, 1, 7.2, 3, 5.8, 1.6);
                yield return new iris3(31, 4.8, 3.1, 1.6, 0.2, 5.5, 2.4, 3.8, 1.1, 7.4, 2.8, 6.1, 1.9);
                yield return new iris3(32, 5.4, 3.4, 1.5, 0.4, 5.5, 2.4, 3.7, 1, 7.9, 3.8, 6.4, 2);
                yield return new iris3(33, 5.2, 4.1, 1.5, 0.1, 5.8, 2.7, 3.9, 1.2, 6.4, 2.8, 5.6, 2.2);
                yield return new iris3(34, 5.5, 4.2, 1.4, 0.2, 6, 2.7, 5.1, 1.6, 6.3, 2.8, 5.1, 1.5);
                yield return new iris3(35, 4.9, 3.1, 1.5, 0.2, 5.4, 3, 4.5, 1.5, 6.1, 2.6, 5.6, 1.4);
                yield return new iris3(36, 5, 3.2, 1.2, 0.2, 6, 3.4, 4.5, 1.6, 7.7, 3, 6.1, 2.3);
                yield return new iris3(37, 5.5, 3.5, 1.3, 0.2, 6.7, 3.1, 4.7, 1.5, 6.3, 3.4, 5.6, 2.4);
                yield return new iris3(38, 4.9, 3.6, 1.4, 0.1, 6.3, 2.3, 4.4, 1.3, 6.4, 3.1, 5.5, 1.8);
                yield return new iris3(39, 4.4, 3, 1.3, 0.2, 5.6, 3, 4.1, 1.3, 6, 3, 4.8, 1.8);
                yield return new iris3(40, 5.1, 3.4, 1.5, 0.2, 5.5, 2.5, 4, 1.3, 6.9, 3.1, 5.4, 2.1);
                yield return new iris3(41, 5, 3.5, 1.3, 0.3, 5.5, 2.6, 4.4, 1.2, 6.7, 3.1, 5.6, 2.4);
                yield return new iris3(42, 4.5, 2.3, 1.3, 0.3, 6.1, 3, 4.6, 1.4, 6.9, 3.1, 5.1, 2.3);
                yield return new iris3(43, 4.4, 3.2, 1.3, 0.2, 5.8, 2.6, 4, 1.2, 5.8, 2.7, 5.1, 1.9);
                yield return new iris3(44, 5, 3.5, 1.6, 0.6, 5, 2.3, 3.3, 1, 6.8, 3.2, 5.9, 2.3);
                yield return new iris3(45, 5.1, 3.8, 1.9, 0.4, 5.6, 2.7, 4.2, 1.3, 6.7, 3.3, 5.7, 2.5);
                yield return new iris3(46, 4.8, 3, 1.4, 0.3, 5.7, 3, 4.2, 1.2, 6.7, 3, 5.2, 2.3);
                yield return new iris3(47, 5.1, 3.8, 1.6, 0.2, 5.7, 2.9, 4.2, 1.3, 6.3, 2.5, 5, 1.9);
                yield return new iris3(48, 4.6, 3.2, 1.4, 0.2, 6.2, 2.9, 4.3, 1.3, 6.5, 3, 5.2, 2);
                yield return new iris3(49, 5.3, 3.7, 1.5, 0.2, 5.1, 2.5, 3, 1.1, 6.2, 3.4, 5.4, 2.3);
                yield return new iris3(50, 5, 3.3, 1.4, 0.2, 5.7, 2.8, 4.1, 1.3, 5.9, 3, 5.1, 1.8);
            }
        }
    }
}
