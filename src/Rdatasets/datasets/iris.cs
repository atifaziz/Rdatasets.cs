// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Edgar Anderson's Iris Data
    /// </summary>

    public class iris
    {
        public readonly double Sepal_Length;
        public readonly double Sepal_Width;
        public readonly double Petal_Length;
        public readonly double Petal_Width;
        public readonly string Species;

        public iris(double Sepal_Length, double Sepal_Width, double Petal_Length, double Petal_Width, string Species)
        {
            this.Sepal_Length = Sepal_Length;
            this.Sepal_Width = Sepal_Width;
            this.Petal_Length = Petal_Length;
            this.Petal_Width = Petal_Width;
            this.Species = Species;
        }

        public static IEnumerable<iris> Data
        {
            get
            {
                yield return new iris(5.1, 3.5, 1.4, 0.2, "setosa");
                yield return new iris(4.9, 3, 1.4, 0.2, "setosa");
                yield return new iris(4.7, 3.2, 1.3, 0.2, "setosa");
                yield return new iris(4.6, 3.1, 1.5, 0.2, "setosa");
                yield return new iris(5, 3.6, 1.4, 0.2, "setosa");
                yield return new iris(5.4, 3.9, 1.7, 0.4, "setosa");
                yield return new iris(4.6, 3.4, 1.4, 0.3, "setosa");
                yield return new iris(5, 3.4, 1.5, 0.2, "setosa");
                yield return new iris(4.4, 2.9, 1.4, 0.2, "setosa");
                yield return new iris(4.9, 3.1, 1.5, 0.1, "setosa");
                yield return new iris(5.4, 3.7, 1.5, 0.2, "setosa");
                yield return new iris(4.8, 3.4, 1.6, 0.2, "setosa");
                yield return new iris(4.8, 3, 1.4, 0.1, "setosa");
                yield return new iris(4.3, 3, 1.1, 0.1, "setosa");
                yield return new iris(5.8, 4, 1.2, 0.2, "setosa");
                yield return new iris(5.7, 4.4, 1.5, 0.4, "setosa");
                yield return new iris(5.4, 3.9, 1.3, 0.4, "setosa");
                yield return new iris(5.1, 3.5, 1.4, 0.3, "setosa");
                yield return new iris(5.7, 3.8, 1.7, 0.3, "setosa");
                yield return new iris(5.1, 3.8, 1.5, 0.3, "setosa");
                yield return new iris(5.4, 3.4, 1.7, 0.2, "setosa");
                yield return new iris(5.1, 3.7, 1.5, 0.4, "setosa");
                yield return new iris(4.6, 3.6, 1, 0.2, "setosa");
                yield return new iris(5.1, 3.3, 1.7, 0.5, "setosa");
                yield return new iris(4.8, 3.4, 1.9, 0.2, "setosa");
                yield return new iris(5, 3, 1.6, 0.2, "setosa");
                yield return new iris(5, 3.4, 1.6, 0.4, "setosa");
                yield return new iris(5.2, 3.5, 1.5, 0.2, "setosa");
                yield return new iris(5.2, 3.4, 1.4, 0.2, "setosa");
                yield return new iris(4.7, 3.2, 1.6, 0.2, "setosa");
                yield return new iris(4.8, 3.1, 1.6, 0.2, "setosa");
                yield return new iris(5.4, 3.4, 1.5, 0.4, "setosa");
                yield return new iris(5.2, 4.1, 1.5, 0.1, "setosa");
                yield return new iris(5.5, 4.2, 1.4, 0.2, "setosa");
                yield return new iris(4.9, 3.1, 1.5, 0.2, "setosa");
                yield return new iris(5, 3.2, 1.2, 0.2, "setosa");
                yield return new iris(5.5, 3.5, 1.3, 0.2, "setosa");
                yield return new iris(4.9, 3.6, 1.4, 0.1, "setosa");
                yield return new iris(4.4, 3, 1.3, 0.2, "setosa");
                yield return new iris(5.1, 3.4, 1.5, 0.2, "setosa");
                yield return new iris(5, 3.5, 1.3, 0.3, "setosa");
                yield return new iris(4.5, 2.3, 1.3, 0.3, "setosa");
                yield return new iris(4.4, 3.2, 1.3, 0.2, "setosa");
                yield return new iris(5, 3.5, 1.6, 0.6, "setosa");
                yield return new iris(5.1, 3.8, 1.9, 0.4, "setosa");
                yield return new iris(4.8, 3, 1.4, 0.3, "setosa");
                yield return new iris(5.1, 3.8, 1.6, 0.2, "setosa");
                yield return new iris(4.6, 3.2, 1.4, 0.2, "setosa");
                yield return new iris(5.3, 3.7, 1.5, 0.2, "setosa");
                yield return new iris(5, 3.3, 1.4, 0.2, "setosa");
                yield return new iris(7, 3.2, 4.7, 1.4, "versicolor");
                yield return new iris(6.4, 3.2, 4.5, 1.5, "versicolor");
                yield return new iris(6.9, 3.1, 4.9, 1.5, "versicolor");
                yield return new iris(5.5, 2.3, 4, 1.3, "versicolor");
                yield return new iris(6.5, 2.8, 4.6, 1.5, "versicolor");
                yield return new iris(5.7, 2.8, 4.5, 1.3, "versicolor");
                yield return new iris(6.3, 3.3, 4.7, 1.6, "versicolor");
                yield return new iris(4.9, 2.4, 3.3, 1, "versicolor");
                yield return new iris(6.6, 2.9, 4.6, 1.3, "versicolor");
                yield return new iris(5.2, 2.7, 3.9, 1.4, "versicolor");
                yield return new iris(5, 2, 3.5, 1, "versicolor");
                yield return new iris(5.9, 3, 4.2, 1.5, "versicolor");
                yield return new iris(6, 2.2, 4, 1, "versicolor");
                yield return new iris(6.1, 2.9, 4.7, 1.4, "versicolor");
                yield return new iris(5.6, 2.9, 3.6, 1.3, "versicolor");
                yield return new iris(6.7, 3.1, 4.4, 1.4, "versicolor");
                yield return new iris(5.6, 3, 4.5, 1.5, "versicolor");
                yield return new iris(5.8, 2.7, 4.1, 1, "versicolor");
                yield return new iris(6.2, 2.2, 4.5, 1.5, "versicolor");
                yield return new iris(5.6, 2.5, 3.9, 1.1, "versicolor");
                yield return new iris(5.9, 3.2, 4.8, 1.8, "versicolor");
                yield return new iris(6.1, 2.8, 4, 1.3, "versicolor");
                yield return new iris(6.3, 2.5, 4.9, 1.5, "versicolor");
                yield return new iris(6.1, 2.8, 4.7, 1.2, "versicolor");
                yield return new iris(6.4, 2.9, 4.3, 1.3, "versicolor");
                yield return new iris(6.6, 3, 4.4, 1.4, "versicolor");
                yield return new iris(6.8, 2.8, 4.8, 1.4, "versicolor");
                yield return new iris(6.7, 3, 5, 1.7, "versicolor");
                yield return new iris(6, 2.9, 4.5, 1.5, "versicolor");
                yield return new iris(5.7, 2.6, 3.5, 1, "versicolor");
                yield return new iris(5.5, 2.4, 3.8, 1.1, "versicolor");
                yield return new iris(5.5, 2.4, 3.7, 1, "versicolor");
                yield return new iris(5.8, 2.7, 3.9, 1.2, "versicolor");
                yield return new iris(6, 2.7, 5.1, 1.6, "versicolor");
                yield return new iris(5.4, 3, 4.5, 1.5, "versicolor");
                yield return new iris(6, 3.4, 4.5, 1.6, "versicolor");
                yield return new iris(6.7, 3.1, 4.7, 1.5, "versicolor");
                yield return new iris(6.3, 2.3, 4.4, 1.3, "versicolor");
                yield return new iris(5.6, 3, 4.1, 1.3, "versicolor");
                yield return new iris(5.5, 2.5, 4, 1.3, "versicolor");
                yield return new iris(5.5, 2.6, 4.4, 1.2, "versicolor");
                yield return new iris(6.1, 3, 4.6, 1.4, "versicolor");
                yield return new iris(5.8, 2.6, 4, 1.2, "versicolor");
                yield return new iris(5, 2.3, 3.3, 1, "versicolor");
                yield return new iris(5.6, 2.7, 4.2, 1.3, "versicolor");
                yield return new iris(5.7, 3, 4.2, 1.2, "versicolor");
                yield return new iris(5.7, 2.9, 4.2, 1.3, "versicolor");
                yield return new iris(6.2, 2.9, 4.3, 1.3, "versicolor");
                yield return new iris(5.1, 2.5, 3, 1.1, "versicolor");
                yield return new iris(5.7, 2.8, 4.1, 1.3, "versicolor");
                yield return new iris(6.3, 3.3, 6, 2.5, "virginica");
                yield return new iris(5.8, 2.7, 5.1, 1.9, "virginica");
                yield return new iris(7.1, 3, 5.9, 2.1, "virginica");
                yield return new iris(6.3, 2.9, 5.6, 1.8, "virginica");
                yield return new iris(6.5, 3, 5.8, 2.2, "virginica");
                yield return new iris(7.6, 3, 6.6, 2.1, "virginica");
                yield return new iris(4.9, 2.5, 4.5, 1.7, "virginica");
                yield return new iris(7.3, 2.9, 6.3, 1.8, "virginica");
                yield return new iris(6.7, 2.5, 5.8, 1.8, "virginica");
                yield return new iris(7.2, 3.6, 6.1, 2.5, "virginica");
                yield return new iris(6.5, 3.2, 5.1, 2, "virginica");
                yield return new iris(6.4, 2.7, 5.3, 1.9, "virginica");
                yield return new iris(6.8, 3, 5.5, 2.1, "virginica");
                yield return new iris(5.7, 2.5, 5, 2, "virginica");
                yield return new iris(5.8, 2.8, 5.1, 2.4, "virginica");
                yield return new iris(6.4, 3.2, 5.3, 2.3, "virginica");
                yield return new iris(6.5, 3, 5.5, 1.8, "virginica");
                yield return new iris(7.7, 3.8, 6.7, 2.2, "virginica");
                yield return new iris(7.7, 2.6, 6.9, 2.3, "virginica");
                yield return new iris(6, 2.2, 5, 1.5, "virginica");
                yield return new iris(6.9, 3.2, 5.7, 2.3, "virginica");
                yield return new iris(5.6, 2.8, 4.9, 2, "virginica");
                yield return new iris(7.7, 2.8, 6.7, 2, "virginica");
                yield return new iris(6.3, 2.7, 4.9, 1.8, "virginica");
                yield return new iris(6.7, 3.3, 5.7, 2.1, "virginica");
                yield return new iris(7.2, 3.2, 6, 1.8, "virginica");
                yield return new iris(6.2, 2.8, 4.8, 1.8, "virginica");
                yield return new iris(6.1, 3, 4.9, 1.8, "virginica");
                yield return new iris(6.4, 2.8, 5.6, 2.1, "virginica");
                yield return new iris(7.2, 3, 5.8, 1.6, "virginica");
                yield return new iris(7.4, 2.8, 6.1, 1.9, "virginica");
                yield return new iris(7.9, 3.8, 6.4, 2, "virginica");
                yield return new iris(6.4, 2.8, 5.6, 2.2, "virginica");
                yield return new iris(6.3, 2.8, 5.1, 1.5, "virginica");
                yield return new iris(6.1, 2.6, 5.6, 1.4, "virginica");
                yield return new iris(7.7, 3, 6.1, 2.3, "virginica");
                yield return new iris(6.3, 3.4, 5.6, 2.4, "virginica");
                yield return new iris(6.4, 3.1, 5.5, 1.8, "virginica");
                yield return new iris(6, 3, 4.8, 1.8, "virginica");
                yield return new iris(6.9, 3.1, 5.4, 2.1, "virginica");
                yield return new iris(6.7, 3.1, 5.6, 2.4, "virginica");
                yield return new iris(6.9, 3.1, 5.1, 2.3, "virginica");
                yield return new iris(5.8, 2.7, 5.1, 1.9, "virginica");
                yield return new iris(6.8, 3.2, 5.9, 2.3, "virginica");
                yield return new iris(6.7, 3.3, 5.7, 2.5, "virginica");
                yield return new iris(6.7, 3, 5.2, 2.3, "virginica");
                yield return new iris(6.3, 2.5, 5, 1.9, "virginica");
                yield return new iris(6.5, 3, 5.2, 2, "virginica");
                yield return new iris(6.2, 3.4, 5.4, 2.3, "virginica");
                yield return new iris(5.9, 3, 5.1, 1.8, "virginica");
            }
        }
    }
}
