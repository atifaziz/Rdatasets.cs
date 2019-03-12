// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// van Langren's Data on Longitude Distance between Toledo and Rome
    /// </summary>

    public class Langren1644
    {
        public readonly int κ;
        public readonly string Name;
        public readonly double Longitude;
        public readonly int Year;
        public readonly string Longname;
        public readonly string City;
        public readonly string Country;
        public readonly double Latitude;
        public readonly string Source;
        public readonly int Gap;

        public Langren1644(int κ, string Name, double Longitude, int Year, string Longname, string City, string Country, double Latitude, string Source, int Gap)
        {
            this.κ = κ;
            this.Name = Name;
            this.Longitude = Longitude;
            this.Year = Year;
            this.Longname = Longname;
            this.City = City;
            this.Country = Country;
            this.Latitude = Latitude;
            this.Source = Source;
            this.Gap = Gap;
        }

        public static IEnumerable<Langren1644> Data
        {
            get
            {
                yield return new Langren1644(1, "G. Jansonius", 17.736, 1605, "Jan Jansson", "Amsterdam", "Flanders", 52.373056, "Map", 0);
                yield return new Langren1644(2, "G. Mercator", 19.872, 1567, "Gerardus Mercator", "Leuven", "Flanders", 50.883333, "Map", 0);
                yield return new Langren1644(3, "I. Schonerus", 20.638, 1536, "Johann Schoner", "Bamberg", "Germany", 49.891667, "Astron", 0);
                yield return new Langren1644(4, "P. Lantsbergius", 21.106, 1530, "Phillip van Lansberge", "Middelburg", "Belgium", 51.5, "Astron", 0);
                yield return new Langren1644(5, "T. Brahe", 21.447, 1578, "Tycho Brahe", "Hven", "Denmark", 55.866667, "Astron", 0);
                yield return new Langren1644(6, "I. Regiomontanus", 25.617, 1463, "Johann Muller", "Nuremberg", "Germany", 49.45, "Astron", 1);
                yield return new Langren1644(7, "Orontius", 26, 1542, "Oronce Fine", "Paris", "France", 48.866667, "Astron", 1);
                yield return new Langren1644(8, "C. Clavius", 26.34, 1567, "Christoph Clavius", "Rome", "Italy", 41.9, "Astron", 1);
                yield return new Langren1644(9, "C. Ptolomeus", 27.787, 150, "Claudius Ptolemaeus", "Alexandria", "Egypt", 31.1980556, "Astron", 1);
                yield return new Langren1644(10, "A. Argelius", 28.17, 1610, "Andrea Argoli", "Padua", "Italy ", 45.4166667, "Astron", 1);
                yield return new Langren1644(11, "A. Maginus", 29.787, 1582, "Giovanni Antonio Magini", "Bologna", "Italy", 44.4833333, "Astron", 1);
                yield return new Langren1644(12, "D. Origanus", 30.128, 1601, "David Origanus", "Frankfurt", "Germany", 52.3471, "Astron", 1);
            }
        }
    }
}
