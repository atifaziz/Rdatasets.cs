// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Yield data from a Minnesota barley trial
    /// </summary>

    public class barley
    {
        public readonly double yield;
        public readonly string variety;
        public readonly int year;
        public readonly string site;

        public barley(double yield, string variety, int year, string site)
        {
            this.yield = yield;
            this.variety = variety;
            this.year = year;
            this.site = site;
        }

        public static IEnumerable<barley> Data
        {
            get
            {
                yield return new barley(27, "Manchuria", 1931, "University Farm");
                yield return new barley(48.86667, "Manchuria", 1931, "Waseca");
                yield return new barley(27.43334, "Manchuria", 1931, "Morris");
                yield return new barley(39.93333, "Manchuria", 1931, "Crookston");
                yield return new barley(32.96667, "Manchuria", 1931, "Grand Rapids");
                yield return new barley(28.96667, "Manchuria", 1931, "Duluth");
                yield return new barley(43.06666, "Glabron", 1931, "University Farm");
                yield return new barley(55.2, "Glabron", 1931, "Waseca");
                yield return new barley(28.76667, "Glabron", 1931, "Morris");
                yield return new barley(38.13333, "Glabron", 1931, "Crookston");
                yield return new barley(29.13333, "Glabron", 1931, "Grand Rapids");
                yield return new barley(29.66667, "Glabron", 1931, "Duluth");
                yield return new barley(35.13333, "Svansota", 1931, "University Farm");
                yield return new barley(47.33333, "Svansota", 1931, "Waseca");
                yield return new barley(25.76667, "Svansota", 1931, "Morris");
                yield return new barley(40.46667, "Svansota", 1931, "Crookston");
                yield return new barley(29.66667, "Svansota", 1931, "Grand Rapids");
                yield return new barley(25.7, "Svansota", 1931, "Duluth");
                yield return new barley(39.9, "Velvet", 1931, "University Farm");
                yield return new barley(50.23333, "Velvet", 1931, "Waseca");
                yield return new barley(26.13333, "Velvet", 1931, "Morris");
                yield return new barley(41.33333, "Velvet", 1931, "Crookston");
                yield return new barley(23.03333, "Velvet", 1931, "Grand Rapids");
                yield return new barley(26.3, "Velvet", 1931, "Duluth");
                yield return new barley(36.56666, "Trebi", 1931, "University Farm");
                yield return new barley(63.8333, "Trebi", 1931, "Waseca");
                yield return new barley(43.76667, "Trebi", 1931, "Morris");
                yield return new barley(46.93333, "Trebi", 1931, "Crookston");
                yield return new barley(29.76667, "Trebi", 1931, "Grand Rapids");
                yield return new barley(33.93333, "Trebi", 1931, "Duluth");
                yield return new barley(43.26667, "No. 457", 1931, "University Farm");
                yield return new barley(58.1, "No. 457", 1931, "Waseca");
                yield return new barley(28.7, "No. 457", 1931, "Morris");
                yield return new barley(45.66667, "No. 457", 1931, "Crookston");
                yield return new barley(32.16667, "No. 457", 1931, "Grand Rapids");
                yield return new barley(33.6, "No. 457", 1931, "Duluth");
                yield return new barley(36.6, "No. 462", 1931, "University Farm");
                yield return new barley(65.7667, "No. 462", 1931, "Waseca");
                yield return new barley(30.36667, "No. 462", 1931, "Morris");
                yield return new barley(48.56666, "No. 462", 1931, "Crookston");
                yield return new barley(24.93334, "No. 462", 1931, "Grand Rapids");
                yield return new barley(28.1, "No. 462", 1931, "Duluth");
                yield return new barley(32.76667, "Peatland", 1931, "University Farm");
                yield return new barley(48.56666, "Peatland", 1931, "Waseca");
                yield return new barley(29.86667, "Peatland", 1931, "Morris");
                yield return new barley(41.6, "Peatland", 1931, "Crookston");
                yield return new barley(34.7, "Peatland", 1931, "Grand Rapids");
                yield return new barley(32, "Peatland", 1931, "Duluth");
                yield return new barley(24.66667, "No. 475", 1931, "University Farm");
                yield return new barley(46.76667, "No. 475", 1931, "Waseca");
                yield return new barley(22.6, "No. 475", 1931, "Morris");
                yield return new barley(44.1, "No. 475", 1931, "Crookston");
                yield return new barley(19.7, "No. 475", 1931, "Grand Rapids");
                yield return new barley(33.06666, "No. 475", 1931, "Duluth");
                yield return new barley(39.3, "Wisconsin No. 38", 1931, "University Farm");
                yield return new barley(58.8, "Wisconsin No. 38", 1931, "Waseca");
                yield return new barley(29.46667, "Wisconsin No. 38", 1931, "Morris");
                yield return new barley(49.86667, "Wisconsin No. 38", 1931, "Crookston");
                yield return new barley(34.46667, "Wisconsin No. 38", 1931, "Grand Rapids");
                yield return new barley(31.6, "Wisconsin No. 38", 1931, "Duluth");
                yield return new barley(26.9, "Manchuria", 1932, "University Farm");
                yield return new barley(33.46667, "Manchuria", 1932, "Waseca");
                yield return new barley(34.36666, "Manchuria", 1932, "Morris");
                yield return new barley(32.96667, "Manchuria", 1932, "Crookston");
                yield return new barley(22.13333, "Manchuria", 1932, "Grand Rapids");
                yield return new barley(22.56667, "Manchuria", 1932, "Duluth");
                yield return new barley(36.8, "Glabron", 1932, "University Farm");
                yield return new barley(37.73333, "Glabron", 1932, "Waseca");
                yield return new barley(35.13333, "Glabron", 1932, "Morris");
                yield return new barley(26.16667, "Glabron", 1932, "Crookston");
                yield return new barley(14.43333, "Glabron", 1932, "Grand Rapids");
                yield return new barley(25.86667, "Glabron", 1932, "Duluth");
                yield return new barley(27.43334, "Svansota", 1932, "University Farm");
                yield return new barley(38.5, "Svansota", 1932, "Waseca");
                yield return new barley(35.03333, "Svansota", 1932, "Morris");
                yield return new barley(20.63333, "Svansota", 1932, "Crookston");
                yield return new barley(16.63333, "Svansota", 1932, "Grand Rapids");
                yield return new barley(22.23333, "Svansota", 1932, "Duluth");
                yield return new barley(26.8, "Velvet", 1932, "University Farm");
                yield return new barley(37.4, "Velvet", 1932, "Waseca");
                yield return new barley(38.83333, "Velvet", 1932, "Morris");
                yield return new barley(32.06666, "Velvet", 1932, "Crookston");
                yield return new barley(32.23333, "Velvet", 1932, "Grand Rapids");
                yield return new barley(22.46667, "Velvet", 1932, "Duluth");
                yield return new barley(29.06667, "Trebi", 1932, "University Farm");
                yield return new barley(49.2333, "Trebi", 1932, "Waseca");
                yield return new barley(46.63333, "Trebi", 1932, "Morris");
                yield return new barley(41.83333, "Trebi", 1932, "Crookston");
                yield return new barley(20.63333, "Trebi", 1932, "Grand Rapids");
                yield return new barley(30.6, "Trebi", 1932, "Duluth");
                yield return new barley(26.43334, "No. 457", 1932, "University Farm");
                yield return new barley(42.2, "No. 457", 1932, "Waseca");
                yield return new barley(43.53334, "No. 457", 1932, "Morris");
                yield return new barley(34.33333, "No. 457", 1932, "Crookston");
                yield return new barley(19.46667, "No. 457", 1932, "Grand Rapids");
                yield return new barley(22.7, "No. 457", 1932, "Duluth");
                yield return new barley(25.56667, "No. 462", 1932, "University Farm");
                yield return new barley(44.7, "No. 462", 1932, "Waseca");
                yield return new barley(47, "No. 462", 1932, "Morris");
                yield return new barley(30.53333, "No. 462", 1932, "Crookston");
                yield return new barley(19.9, "No. 462", 1932, "Grand Rapids");
                yield return new barley(22.5, "No. 462", 1932, "Duluth");
                yield return new barley(28.06667, "Peatland", 1932, "University Farm");
                yield return new barley(36.03333, "Peatland", 1932, "Waseca");
                yield return new barley(43.2, "Peatland", 1932, "Morris");
                yield return new barley(25.23333, "Peatland", 1932, "Crookston");
                yield return new barley(26.76667, "Peatland", 1932, "Grand Rapids");
                yield return new barley(31.36667, "Peatland", 1932, "Duluth");
                yield return new barley(30, "No. 475", 1932, "University Farm");
                yield return new barley(41.26667, "No. 475", 1932, "Waseca");
                yield return new barley(44.23333, "No. 475", 1932, "Morris");
                yield return new barley(32.13333, "No. 475", 1932, "Crookston");
                yield return new barley(15.23333, "No. 475", 1932, "Grand Rapids");
                yield return new barley(27.36667, "No. 475", 1932, "Duluth");
                yield return new barley(38, "Wisconsin No. 38", 1932, "University Farm");
                yield return new barley(58.16667, "Wisconsin No. 38", 1932, "Waseca");
                yield return new barley(47.16667, "Wisconsin No. 38", 1932, "Morris");
                yield return new barley(35.9, "Wisconsin No. 38", 1932, "Crookston");
                yield return new barley(20.66667, "Wisconsin No. 38", 1932, "Grand Rapids");
                yield return new barley(29.33333, "Wisconsin No. 38", 1932, "Duluth");
            }
        }
    }
}
