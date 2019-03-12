// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Yield data from a Minnesota barley trial
    /// </summary>

    public class barley
    {
        public readonly int κ;
        public readonly double yield;
        public readonly string variety;
        public readonly int year;
        public readonly string site;

        public barley(int κ, double yield, string variety, int year, string site)
        {
            this.κ = κ;
            this.yield = yield;
            this.variety = variety;
            this.year = year;
            this.site = site;
        }

        public static IEnumerable<barley> Data
        {
            get
            {
                yield return new barley(1, 27, "Manchuria", 1931, "University Farm");
                yield return new barley(2, 48.86667, "Manchuria", 1931, "Waseca");
                yield return new barley(3, 27.43334, "Manchuria", 1931, "Morris");
                yield return new barley(4, 39.93333, "Manchuria", 1931, "Crookston");
                yield return new barley(5, 32.96667, "Manchuria", 1931, "Grand Rapids");
                yield return new barley(6, 28.96667, "Manchuria", 1931, "Duluth");
                yield return new barley(7, 43.06666, "Glabron", 1931, "University Farm");
                yield return new barley(8, 55.2, "Glabron", 1931, "Waseca");
                yield return new barley(9, 28.76667, "Glabron", 1931, "Morris");
                yield return new barley(10, 38.13333, "Glabron", 1931, "Crookston");
                yield return new barley(11, 29.13333, "Glabron", 1931, "Grand Rapids");
                yield return new barley(12, 29.66667, "Glabron", 1931, "Duluth");
                yield return new barley(13, 35.13333, "Svansota", 1931, "University Farm");
                yield return new barley(14, 47.33333, "Svansota", 1931, "Waseca");
                yield return new barley(15, 25.76667, "Svansota", 1931, "Morris");
                yield return new barley(16, 40.46667, "Svansota", 1931, "Crookston");
                yield return new barley(17, 29.66667, "Svansota", 1931, "Grand Rapids");
                yield return new barley(18, 25.7, "Svansota", 1931, "Duluth");
                yield return new barley(19, 39.9, "Velvet", 1931, "University Farm");
                yield return new barley(20, 50.23333, "Velvet", 1931, "Waseca");
                yield return new barley(21, 26.13333, "Velvet", 1931, "Morris");
                yield return new barley(22, 41.33333, "Velvet", 1931, "Crookston");
                yield return new barley(23, 23.03333, "Velvet", 1931, "Grand Rapids");
                yield return new barley(24, 26.3, "Velvet", 1931, "Duluth");
                yield return new barley(25, 36.56666, "Trebi", 1931, "University Farm");
                yield return new barley(26, 63.8333, "Trebi", 1931, "Waseca");
                yield return new barley(27, 43.76667, "Trebi", 1931, "Morris");
                yield return new barley(28, 46.93333, "Trebi", 1931, "Crookston");
                yield return new barley(29, 29.76667, "Trebi", 1931, "Grand Rapids");
                yield return new barley(30, 33.93333, "Trebi", 1931, "Duluth");
                yield return new barley(31, 43.26667, "No. 457", 1931, "University Farm");
                yield return new barley(32, 58.1, "No. 457", 1931, "Waseca");
                yield return new barley(33, 28.7, "No. 457", 1931, "Morris");
                yield return new barley(34, 45.66667, "No. 457", 1931, "Crookston");
                yield return new barley(35, 32.16667, "No. 457", 1931, "Grand Rapids");
                yield return new barley(36, 33.6, "No. 457", 1931, "Duluth");
                yield return new barley(37, 36.6, "No. 462", 1931, "University Farm");
                yield return new barley(38, 65.7667, "No. 462", 1931, "Waseca");
                yield return new barley(39, 30.36667, "No. 462", 1931, "Morris");
                yield return new barley(40, 48.56666, "No. 462", 1931, "Crookston");
                yield return new barley(41, 24.93334, "No. 462", 1931, "Grand Rapids");
                yield return new barley(42, 28.1, "No. 462", 1931, "Duluth");
                yield return new barley(43, 32.76667, "Peatland", 1931, "University Farm");
                yield return new barley(44, 48.56666, "Peatland", 1931, "Waseca");
                yield return new barley(45, 29.86667, "Peatland", 1931, "Morris");
                yield return new barley(46, 41.6, "Peatland", 1931, "Crookston");
                yield return new barley(47, 34.7, "Peatland", 1931, "Grand Rapids");
                yield return new barley(48, 32, "Peatland", 1931, "Duluth");
                yield return new barley(49, 24.66667, "No. 475", 1931, "University Farm");
                yield return new barley(50, 46.76667, "No. 475", 1931, "Waseca");
                yield return new barley(51, 22.6, "No. 475", 1931, "Morris");
                yield return new barley(52, 44.1, "No. 475", 1931, "Crookston");
                yield return new barley(53, 19.7, "No. 475", 1931, "Grand Rapids");
                yield return new barley(54, 33.06666, "No. 475", 1931, "Duluth");
                yield return new barley(55, 39.3, "Wisconsin No. 38", 1931, "University Farm");
                yield return new barley(56, 58.8, "Wisconsin No. 38", 1931, "Waseca");
                yield return new barley(57, 29.46667, "Wisconsin No. 38", 1931, "Morris");
                yield return new barley(58, 49.86667, "Wisconsin No. 38", 1931, "Crookston");
                yield return new barley(59, 34.46667, "Wisconsin No. 38", 1931, "Grand Rapids");
                yield return new barley(60, 31.6, "Wisconsin No. 38", 1931, "Duluth");
                yield return new barley(61, 26.9, "Manchuria", 1932, "University Farm");
                yield return new barley(62, 33.46667, "Manchuria", 1932, "Waseca");
                yield return new barley(63, 34.36666, "Manchuria", 1932, "Morris");
                yield return new barley(64, 32.96667, "Manchuria", 1932, "Crookston");
                yield return new barley(65, 22.13333, "Manchuria", 1932, "Grand Rapids");
                yield return new barley(66, 22.56667, "Manchuria", 1932, "Duluth");
                yield return new barley(67, 36.8, "Glabron", 1932, "University Farm");
                yield return new barley(68, 37.73333, "Glabron", 1932, "Waseca");
                yield return new barley(69, 35.13333, "Glabron", 1932, "Morris");
                yield return new barley(70, 26.16667, "Glabron", 1932, "Crookston");
                yield return new barley(71, 14.43333, "Glabron", 1932, "Grand Rapids");
                yield return new barley(72, 25.86667, "Glabron", 1932, "Duluth");
                yield return new barley(73, 27.43334, "Svansota", 1932, "University Farm");
                yield return new barley(74, 38.5, "Svansota", 1932, "Waseca");
                yield return new barley(75, 35.03333, "Svansota", 1932, "Morris");
                yield return new barley(76, 20.63333, "Svansota", 1932, "Crookston");
                yield return new barley(77, 16.63333, "Svansota", 1932, "Grand Rapids");
                yield return new barley(78, 22.23333, "Svansota", 1932, "Duluth");
                yield return new barley(79, 26.8, "Velvet", 1932, "University Farm");
                yield return new barley(80, 37.4, "Velvet", 1932, "Waseca");
                yield return new barley(81, 38.83333, "Velvet", 1932, "Morris");
                yield return new barley(82, 32.06666, "Velvet", 1932, "Crookston");
                yield return new barley(83, 32.23333, "Velvet", 1932, "Grand Rapids");
                yield return new barley(84, 22.46667, "Velvet", 1932, "Duluth");
                yield return new barley(85, 29.06667, "Trebi", 1932, "University Farm");
                yield return new barley(86, 49.2333, "Trebi", 1932, "Waseca");
                yield return new barley(87, 46.63333, "Trebi", 1932, "Morris");
                yield return new barley(88, 41.83333, "Trebi", 1932, "Crookston");
                yield return new barley(89, 20.63333, "Trebi", 1932, "Grand Rapids");
                yield return new barley(90, 30.6, "Trebi", 1932, "Duluth");
                yield return new barley(91, 26.43334, "No. 457", 1932, "University Farm");
                yield return new barley(92, 42.2, "No. 457", 1932, "Waseca");
                yield return new barley(93, 43.53334, "No. 457", 1932, "Morris");
                yield return new barley(94, 34.33333, "No. 457", 1932, "Crookston");
                yield return new barley(95, 19.46667, "No. 457", 1932, "Grand Rapids");
                yield return new barley(96, 22.7, "No. 457", 1932, "Duluth");
                yield return new barley(97, 25.56667, "No. 462", 1932, "University Farm");
                yield return new barley(98, 44.7, "No. 462", 1932, "Waseca");
                yield return new barley(99, 47, "No. 462", 1932, "Morris");
                yield return new barley(100, 30.53333, "No. 462", 1932, "Crookston");
                yield return new barley(101, 19.9, "No. 462", 1932, "Grand Rapids");
                yield return new barley(102, 22.5, "No. 462", 1932, "Duluth");
                yield return new barley(103, 28.06667, "Peatland", 1932, "University Farm");
                yield return new barley(104, 36.03333, "Peatland", 1932, "Waseca");
                yield return new barley(105, 43.2, "Peatland", 1932, "Morris");
                yield return new barley(106, 25.23333, "Peatland", 1932, "Crookston");
                yield return new barley(107, 26.76667, "Peatland", 1932, "Grand Rapids");
                yield return new barley(108, 31.36667, "Peatland", 1932, "Duluth");
                yield return new barley(109, 30, "No. 475", 1932, "University Farm");
                yield return new barley(110, 41.26667, "No. 475", 1932, "Waseca");
                yield return new barley(111, 44.23333, "No. 475", 1932, "Morris");
                yield return new barley(112, 32.13333, "No. 475", 1932, "Crookston");
                yield return new barley(113, 15.23333, "No. 475", 1932, "Grand Rapids");
                yield return new barley(114, 27.36667, "No. 475", 1932, "Duluth");
                yield return new barley(115, 38, "Wisconsin No. 38", 1932, "University Farm");
                yield return new barley(116, 58.16667, "Wisconsin No. 38", 1932, "Waseca");
                yield return new barley(117, 47.16667, "Wisconsin No. 38", 1932, "Morris");
                yield return new barley(118, 35.9, "Wisconsin No. 38", 1932, "Crookston");
                yield return new barley(119, 20.66667, "Wisconsin No. 38", 1932, "Grand Rapids");
                yield return new barley(120, 29.33333, "Wisconsin No. 38", 1932, "Duluth");
            }
        }
    }
}
