// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// van Langren's Data on Longitude Distance between Toledo and Rome
    /// </summary>

    public class Langren_all
    {
        public readonly string Author;
        public readonly int Year;
        public readonly string Name;
        public readonly double Longitude;

        public Langren_all(string Author, int Year, string Name, double Longitude)
        {
            this.Author = Author;
            this.Year = Year;
            this.Name = Name;
            this.Longitude = Longitude;
        }

        public static IEnumerable<Langren_all> Data
        {
            get
            {
                yield return new Langren_all("Langren", 1628, "Langren", 17.6907);
                yield return new Langren_all("Langren", 1628, "Mercator", 19.6701);
                yield return new Langren_all("Langren", 1628, "Schonerus", 20.7835);
                yield return new Langren_all("Langren", 1628, "Orontius", 24.2474);
                yield return new Langren_all("Langren", 1628, "Regiomontanus", 25.5464);
                yield return new Langren_all("Langren", 1628, "Clavius", 26.5361);
                yield return new Langren_all("Langren", 1628, "Ptolomeus", 27.7732);
                yield return new Langren_all("Langren", 1632, "Algunos1", 17.6744);
                yield return new Langren_all("Langren", 1632, "Maginus", 18.206);
                yield return new Langren_all("Langren", 1632, "Ortelius", 19.1694);
                yield return new Langren_all("Langren", 1632, "Bertius", 19.402);
                yield return new Langren_all("Langren", 1632, "Mercator", 19.701);
                yield return new Langren_all("Langren", 1632, "Algunos2", 20.3654);
                yield return new Langren_all("Langren", 1632, "Schonerus", 20.7641);
                yield return new Langren_all("Langren", 1632, "Brahe", 21.495);
                yield return new Langren_all("Langren", 1632, "Regiomontanus", 25.5482);
                yield return new Langren_all("Langren", 1632, "Ptolomeus", 26.2126);
                yield return new Langren_all("Langren", 1632, "Orontius", 26.2126);
                yield return new Langren_all("Langren", 1632, "Clavius", 26.711);
                yield return new Langren_all("Langren", 1632, "Apianus", 27.3754);
                yield return new Langren_all("Langren", 1632, "Leonitrus", 27.7076);
                yield return new Langren_all("Langren", 1632, "Origanus", 27.7076);
                yield return new Langren_all("Langren", 1633, "Algunos1", 17.3727);
                yield return new Langren_all("Langren", 1633, "Maginus", 17.8909);
                yield return new Langren_all("Langren", 1633, "Ortelius", 18.7909);
                yield return new Langren_all("Langren", 1633, "Bertius", 19.0636);
                yield return new Langren_all("Langren", 1633, "Mercator", 19.4182);
                yield return new Langren_all("Langren", 1633, "Algunos2", 20.1545);
                yield return new Langren_all("Langren", 1633, "Schonerus", 20.6727);
                yield return new Langren_all("Langren", 1633, "Brahe", 21.3273);
                yield return new Langren_all("Langren", 1633, "Regiomontanus", 25.1182);
                yield return new Langren_all("Langren", 1633, "Ptolomeus", 26.0182);
                yield return new Langren_all("Langren", 1633, "Orontius", 26.0182);
                yield return new Langren_all("Langren", 1633, "Clavius", 26.5364);
                yield return new Langren_all("Langren", 1633, "Apianus", 27.0545);
                yield return new Langren_all("Langren", 1633, "Leonitrus", 27.4636);
                yield return new Langren_all("Langren", 1633, "Origanus", 27.4636);
                yield return new Langren_all("Langren", 1644, "Iansonius", 17.6197);
                yield return new Langren_all("Langren", 1644, "Mercator", 19.6478);
                yield return new Langren_all("Langren", 1644, "Schonerus", 20.7514);
                yield return new Langren_all("Langren", 1644, "Lantsbergius", 21.1326);
                yield return new Langren_all("Langren", 1644, "Brahe", 21.4135);
                yield return new Langren_all("Langren", 1644, "Regiomontanus", 25.467);
                yield return new Langren_all("Langren", 1644, "Orontius", 26.0473);
                yield return new Langren_all("Langren", 1644, "Clavius", 26.5083);
                yield return new Langren_all("Langren", 1644, "Ptolomeus", 27.6514);
                yield return new Langren_all("Langren", 1644, "Argelius", 28.0538);
                yield return new Langren_all("Langren", 1644, "Maginus", 29.7988);
                yield return new Langren_all("Langren", 1644, "Origanus", 30.0597);
                yield return new Langren_all("Lelewel", 1851, "Iansonius", 17.432);
                yield return new Langren_all("Lelewel", 1851, "Mercator", 19.9006);
                yield return new Langren_all("Lelewel", 1851, "Schonerus", 20.6691);
                yield return new Langren_all("Lelewel", 1851, "Lantsbergius", 21.0527);
                yield return new Langren_all("Lelewel", 1851, "Brahe", 21.4362);
                yield return new Langren_all("Lelewel", 1851, "Regiomontanus", 25.6093);
                yield return new Langren_all("Lelewel", 1851, "Orontius", 25.9943);
                yield return new Langren_all("Lelewel", 1851, "Clavius", 26.3778);
                yield return new Langren_all("Lelewel", 1851, "Ptolomeus", 27.7841);
                yield return new Langren_all("Lelewel", 1851, "Argelius", 28.1661);
                yield return new Langren_all("Lelewel", 1851, "Maginus", 29.8295);
                yield return new Langren_all("Lelewel", 1851, "Origanus", 30.1689);
            }
        }
    }
}
