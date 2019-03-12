// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Edgar Anderson's Iris Data
    /// </summary>

    public class iris
    {
        public readonly int κ;
        public readonly double Sepal_Length;
        public readonly double Sepal_Width;
        public readonly double Petal_Length;
        public readonly double Petal_Width;
        public readonly string Species;

        public iris(int κ, double Sepal_Length, double Sepal_Width, double Petal_Length, double Petal_Width, string Species)
        {
            this.κ = κ;
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
                yield return new iris(1, 5.1, 3.5, 1.4, 0.2, "setosa");
                yield return new iris(2, 4.9, 3, 1.4, 0.2, "setosa");
                yield return new iris(3, 4.7, 3.2, 1.3, 0.2, "setosa");
                yield return new iris(4, 4.6, 3.1, 1.5, 0.2, "setosa");
                yield return new iris(5, 5, 3.6, 1.4, 0.2, "setosa");
                yield return new iris(6, 5.4, 3.9, 1.7, 0.4, "setosa");
                yield return new iris(7, 4.6, 3.4, 1.4, 0.3, "setosa");
                yield return new iris(8, 5, 3.4, 1.5, 0.2, "setosa");
                yield return new iris(9, 4.4, 2.9, 1.4, 0.2, "setosa");
                yield return new iris(10, 4.9, 3.1, 1.5, 0.1, "setosa");
                yield return new iris(11, 5.4, 3.7, 1.5, 0.2, "setosa");
                yield return new iris(12, 4.8, 3.4, 1.6, 0.2, "setosa");
                yield return new iris(13, 4.8, 3, 1.4, 0.1, "setosa");
                yield return new iris(14, 4.3, 3, 1.1, 0.1, "setosa");
                yield return new iris(15, 5.8, 4, 1.2, 0.2, "setosa");
                yield return new iris(16, 5.7, 4.4, 1.5, 0.4, "setosa");
                yield return new iris(17, 5.4, 3.9, 1.3, 0.4, "setosa");
                yield return new iris(18, 5.1, 3.5, 1.4, 0.3, "setosa");
                yield return new iris(19, 5.7, 3.8, 1.7, 0.3, "setosa");
                yield return new iris(20, 5.1, 3.8, 1.5, 0.3, "setosa");
                yield return new iris(21, 5.4, 3.4, 1.7, 0.2, "setosa");
                yield return new iris(22, 5.1, 3.7, 1.5, 0.4, "setosa");
                yield return new iris(23, 4.6, 3.6, 1, 0.2, "setosa");
                yield return new iris(24, 5.1, 3.3, 1.7, 0.5, "setosa");
                yield return new iris(25, 4.8, 3.4, 1.9, 0.2, "setosa");
                yield return new iris(26, 5, 3, 1.6, 0.2, "setosa");
                yield return new iris(27, 5, 3.4, 1.6, 0.4, "setosa");
                yield return new iris(28, 5.2, 3.5, 1.5, 0.2, "setosa");
                yield return new iris(29, 5.2, 3.4, 1.4, 0.2, "setosa");
                yield return new iris(30, 4.7, 3.2, 1.6, 0.2, "setosa");
                yield return new iris(31, 4.8, 3.1, 1.6, 0.2, "setosa");
                yield return new iris(32, 5.4, 3.4, 1.5, 0.4, "setosa");
                yield return new iris(33, 5.2, 4.1, 1.5, 0.1, "setosa");
                yield return new iris(34, 5.5, 4.2, 1.4, 0.2, "setosa");
                yield return new iris(35, 4.9, 3.1, 1.5, 0.2, "setosa");
                yield return new iris(36, 5, 3.2, 1.2, 0.2, "setosa");
                yield return new iris(37, 5.5, 3.5, 1.3, 0.2, "setosa");
                yield return new iris(38, 4.9, 3.6, 1.4, 0.1, "setosa");
                yield return new iris(39, 4.4, 3, 1.3, 0.2, "setosa");
                yield return new iris(40, 5.1, 3.4, 1.5, 0.2, "setosa");
                yield return new iris(41, 5, 3.5, 1.3, 0.3, "setosa");
                yield return new iris(42, 4.5, 2.3, 1.3, 0.3, "setosa");
                yield return new iris(43, 4.4, 3.2, 1.3, 0.2, "setosa");
                yield return new iris(44, 5, 3.5, 1.6, 0.6, "setosa");
                yield return new iris(45, 5.1, 3.8, 1.9, 0.4, "setosa");
                yield return new iris(46, 4.8, 3, 1.4, 0.3, "setosa");
                yield return new iris(47, 5.1, 3.8, 1.6, 0.2, "setosa");
                yield return new iris(48, 4.6, 3.2, 1.4, 0.2, "setosa");
                yield return new iris(49, 5.3, 3.7, 1.5, 0.2, "setosa");
                yield return new iris(50, 5, 3.3, 1.4, 0.2, "setosa");
                yield return new iris(51, 7, 3.2, 4.7, 1.4, "versicolor");
                yield return new iris(52, 6.4, 3.2, 4.5, 1.5, "versicolor");
                yield return new iris(53, 6.9, 3.1, 4.9, 1.5, "versicolor");
                yield return new iris(54, 5.5, 2.3, 4, 1.3, "versicolor");
                yield return new iris(55, 6.5, 2.8, 4.6, 1.5, "versicolor");
                yield return new iris(56, 5.7, 2.8, 4.5, 1.3, "versicolor");
                yield return new iris(57, 6.3, 3.3, 4.7, 1.6, "versicolor");
                yield return new iris(58, 4.9, 2.4, 3.3, 1, "versicolor");
                yield return new iris(59, 6.6, 2.9, 4.6, 1.3, "versicolor");
                yield return new iris(60, 5.2, 2.7, 3.9, 1.4, "versicolor");
                yield return new iris(61, 5, 2, 3.5, 1, "versicolor");
                yield return new iris(62, 5.9, 3, 4.2, 1.5, "versicolor");
                yield return new iris(63, 6, 2.2, 4, 1, "versicolor");
                yield return new iris(64, 6.1, 2.9, 4.7, 1.4, "versicolor");
                yield return new iris(65, 5.6, 2.9, 3.6, 1.3, "versicolor");
                yield return new iris(66, 6.7, 3.1, 4.4, 1.4, "versicolor");
                yield return new iris(67, 5.6, 3, 4.5, 1.5, "versicolor");
                yield return new iris(68, 5.8, 2.7, 4.1, 1, "versicolor");
                yield return new iris(69, 6.2, 2.2, 4.5, 1.5, "versicolor");
                yield return new iris(70, 5.6, 2.5, 3.9, 1.1, "versicolor");
                yield return new iris(71, 5.9, 3.2, 4.8, 1.8, "versicolor");
                yield return new iris(72, 6.1, 2.8, 4, 1.3, "versicolor");
                yield return new iris(73, 6.3, 2.5, 4.9, 1.5, "versicolor");
                yield return new iris(74, 6.1, 2.8, 4.7, 1.2, "versicolor");
                yield return new iris(75, 6.4, 2.9, 4.3, 1.3, "versicolor");
                yield return new iris(76, 6.6, 3, 4.4, 1.4, "versicolor");
                yield return new iris(77, 6.8, 2.8, 4.8, 1.4, "versicolor");
                yield return new iris(78, 6.7, 3, 5, 1.7, "versicolor");
                yield return new iris(79, 6, 2.9, 4.5, 1.5, "versicolor");
                yield return new iris(80, 5.7, 2.6, 3.5, 1, "versicolor");
                yield return new iris(81, 5.5, 2.4, 3.8, 1.1, "versicolor");
                yield return new iris(82, 5.5, 2.4, 3.7, 1, "versicolor");
                yield return new iris(83, 5.8, 2.7, 3.9, 1.2, "versicolor");
                yield return new iris(84, 6, 2.7, 5.1, 1.6, "versicolor");
                yield return new iris(85, 5.4, 3, 4.5, 1.5, "versicolor");
                yield return new iris(86, 6, 3.4, 4.5, 1.6, "versicolor");
                yield return new iris(87, 6.7, 3.1, 4.7, 1.5, "versicolor");
                yield return new iris(88, 6.3, 2.3, 4.4, 1.3, "versicolor");
                yield return new iris(89, 5.6, 3, 4.1, 1.3, "versicolor");
                yield return new iris(90, 5.5, 2.5, 4, 1.3, "versicolor");
                yield return new iris(91, 5.5, 2.6, 4.4, 1.2, "versicolor");
                yield return new iris(92, 6.1, 3, 4.6, 1.4, "versicolor");
                yield return new iris(93, 5.8, 2.6, 4, 1.2, "versicolor");
                yield return new iris(94, 5, 2.3, 3.3, 1, "versicolor");
                yield return new iris(95, 5.6, 2.7, 4.2, 1.3, "versicolor");
                yield return new iris(96, 5.7, 3, 4.2, 1.2, "versicolor");
                yield return new iris(97, 5.7, 2.9, 4.2, 1.3, "versicolor");
                yield return new iris(98, 6.2, 2.9, 4.3, 1.3, "versicolor");
                yield return new iris(99, 5.1, 2.5, 3, 1.1, "versicolor");
                yield return new iris(100, 5.7, 2.8, 4.1, 1.3, "versicolor");
                yield return new iris(101, 6.3, 3.3, 6, 2.5, "virginica");
                yield return new iris(102, 5.8, 2.7, 5.1, 1.9, "virginica");
                yield return new iris(103, 7.1, 3, 5.9, 2.1, "virginica");
                yield return new iris(104, 6.3, 2.9, 5.6, 1.8, "virginica");
                yield return new iris(105, 6.5, 3, 5.8, 2.2, "virginica");
                yield return new iris(106, 7.6, 3, 6.6, 2.1, "virginica");
                yield return new iris(107, 4.9, 2.5, 4.5, 1.7, "virginica");
                yield return new iris(108, 7.3, 2.9, 6.3, 1.8, "virginica");
                yield return new iris(109, 6.7, 2.5, 5.8, 1.8, "virginica");
                yield return new iris(110, 7.2, 3.6, 6.1, 2.5, "virginica");
                yield return new iris(111, 6.5, 3.2, 5.1, 2, "virginica");
                yield return new iris(112, 6.4, 2.7, 5.3, 1.9, "virginica");
                yield return new iris(113, 6.8, 3, 5.5, 2.1, "virginica");
                yield return new iris(114, 5.7, 2.5, 5, 2, "virginica");
                yield return new iris(115, 5.8, 2.8, 5.1, 2.4, "virginica");
                yield return new iris(116, 6.4, 3.2, 5.3, 2.3, "virginica");
                yield return new iris(117, 6.5, 3, 5.5, 1.8, "virginica");
                yield return new iris(118, 7.7, 3.8, 6.7, 2.2, "virginica");
                yield return new iris(119, 7.7, 2.6, 6.9, 2.3, "virginica");
                yield return new iris(120, 6, 2.2, 5, 1.5, "virginica");
                yield return new iris(121, 6.9, 3.2, 5.7, 2.3, "virginica");
                yield return new iris(122, 5.6, 2.8, 4.9, 2, "virginica");
                yield return new iris(123, 7.7, 2.8, 6.7, 2, "virginica");
                yield return new iris(124, 6.3, 2.7, 4.9, 1.8, "virginica");
                yield return new iris(125, 6.7, 3.3, 5.7, 2.1, "virginica");
                yield return new iris(126, 7.2, 3.2, 6, 1.8, "virginica");
                yield return new iris(127, 6.2, 2.8, 4.8, 1.8, "virginica");
                yield return new iris(128, 6.1, 3, 4.9, 1.8, "virginica");
                yield return new iris(129, 6.4, 2.8, 5.6, 2.1, "virginica");
                yield return new iris(130, 7.2, 3, 5.8, 1.6, "virginica");
                yield return new iris(131, 7.4, 2.8, 6.1, 1.9, "virginica");
                yield return new iris(132, 7.9, 3.8, 6.4, 2, "virginica");
                yield return new iris(133, 6.4, 2.8, 5.6, 2.2, "virginica");
                yield return new iris(134, 6.3, 2.8, 5.1, 1.5, "virginica");
                yield return new iris(135, 6.1, 2.6, 5.6, 1.4, "virginica");
                yield return new iris(136, 7.7, 3, 6.1, 2.3, "virginica");
                yield return new iris(137, 6.3, 3.4, 5.6, 2.4, "virginica");
                yield return new iris(138, 6.4, 3.1, 5.5, 1.8, "virginica");
                yield return new iris(139, 6, 3, 4.8, 1.8, "virginica");
                yield return new iris(140, 6.9, 3.1, 5.4, 2.1, "virginica");
                yield return new iris(141, 6.7, 3.1, 5.6, 2.4, "virginica");
                yield return new iris(142, 6.9, 3.1, 5.1, 2.3, "virginica");
                yield return new iris(143, 5.8, 2.7, 5.1, 1.9, "virginica");
                yield return new iris(144, 6.8, 3.2, 5.9, 2.3, "virginica");
                yield return new iris(145, 6.7, 3.3, 5.7, 2.5, "virginica");
                yield return new iris(146, 6.7, 3, 5.2, 2.3, "virginica");
                yield return new iris(147, 6.3, 2.5, 5, 1.9, "virginica");
                yield return new iris(148, 6.5, 3, 5.2, 2, "virginica");
                yield return new iris(149, 6.2, 3.4, 5.4, 2.3, "virginica");
                yield return new iris(150, 5.9, 3, 5.1, 1.8, "virginica");
            }
        }
    }
}
