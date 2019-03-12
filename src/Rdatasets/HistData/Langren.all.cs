// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// van Langren's Data on Longitude Distance between Toledo and Rome
    /// </summary>

    public class Langren_all
    {
        public readonly int κ;
        public readonly string Author;
        public readonly int Year;
        public readonly string Name;
        public readonly double Longitude;

        public Langren_all(int κ, string Author, int Year, string Name, double Longitude)
        {
            this.κ = κ;
            this.Author = Author;
            this.Year = Year;
            this.Name = Name;
            this.Longitude = Longitude;
        }

        public static IEnumerable<Langren_all> Data
        {
            get
            {
                yield return new Langren_all(1, "Langren", 1628, "Langren", 17.6907);
                yield return new Langren_all(2, "Langren", 1628, "Mercator", 19.6701);
                yield return new Langren_all(3, "Langren", 1628, "Schonerus", 20.7835);
                yield return new Langren_all(4, "Langren", 1628, "Orontius", 24.2474);
                yield return new Langren_all(5, "Langren", 1628, "Regiomontanus", 25.5464);
                yield return new Langren_all(6, "Langren", 1628, "Clavius", 26.5361);
                yield return new Langren_all(7, "Langren", 1628, "Ptolomeus", 27.7732);
                yield return new Langren_all(8, "Langren", 1632, "Algunos1", 17.6744);
                yield return new Langren_all(9, "Langren", 1632, "Maginus", 18.206);
                yield return new Langren_all(10, "Langren", 1632, "Ortelius", 19.1694);
                yield return new Langren_all(11, "Langren", 1632, "Bertius", 19.402);
                yield return new Langren_all(12, "Langren", 1632, "Mercator", 19.701);
                yield return new Langren_all(13, "Langren", 1632, "Algunos2", 20.3654);
                yield return new Langren_all(14, "Langren", 1632, "Schonerus", 20.7641);
                yield return new Langren_all(15, "Langren", 1632, "Brahe", 21.495);
                yield return new Langren_all(16, "Langren", 1632, "Regiomontanus", 25.5482);
                yield return new Langren_all(17, "Langren", 1632, "Ptolomeus", 26.2126);
                yield return new Langren_all(18, "Langren", 1632, "Orontius", 26.2126);
                yield return new Langren_all(19, "Langren", 1632, "Clavius", 26.711);
                yield return new Langren_all(20, "Langren", 1632, "Apianus", 27.3754);
                yield return new Langren_all(21, "Langren", 1632, "Leonitrus", 27.7076);
                yield return new Langren_all(22, "Langren", 1632, "Origanus", 27.7076);
                yield return new Langren_all(23, "Langren", 1633, "Algunos1", 17.3727);
                yield return new Langren_all(24, "Langren", 1633, "Maginus", 17.8909);
                yield return new Langren_all(25, "Langren", 1633, "Ortelius", 18.7909);
                yield return new Langren_all(26, "Langren", 1633, "Bertius", 19.0636);
                yield return new Langren_all(27, "Langren", 1633, "Mercator", 19.4182);
                yield return new Langren_all(28, "Langren", 1633, "Algunos2", 20.1545);
                yield return new Langren_all(29, "Langren", 1633, "Schonerus", 20.6727);
                yield return new Langren_all(30, "Langren", 1633, "Brahe", 21.3273);
                yield return new Langren_all(31, "Langren", 1633, "Regiomontanus", 25.1182);
                yield return new Langren_all(32, "Langren", 1633, "Ptolomeus", 26.0182);
                yield return new Langren_all(33, "Langren", 1633, "Orontius", 26.0182);
                yield return new Langren_all(34, "Langren", 1633, "Clavius", 26.5364);
                yield return new Langren_all(35, "Langren", 1633, "Apianus", 27.0545);
                yield return new Langren_all(36, "Langren", 1633, "Leonitrus", 27.4636);
                yield return new Langren_all(37, "Langren", 1633, "Origanus", 27.4636);
                yield return new Langren_all(38, "Langren", 1644, "Iansonius", 17.6197);
                yield return new Langren_all(39, "Langren", 1644, "Mercator", 19.6478);
                yield return new Langren_all(40, "Langren", 1644, "Schonerus", 20.7514);
                yield return new Langren_all(41, "Langren", 1644, "Lantsbergius", 21.1326);
                yield return new Langren_all(42, "Langren", 1644, "Brahe", 21.4135);
                yield return new Langren_all(43, "Langren", 1644, "Regiomontanus", 25.467);
                yield return new Langren_all(44, "Langren", 1644, "Orontius", 26.0473);
                yield return new Langren_all(45, "Langren", 1644, "Clavius", 26.5083);
                yield return new Langren_all(46, "Langren", 1644, "Ptolomeus", 27.6514);
                yield return new Langren_all(47, "Langren", 1644, "Argelius", 28.0538);
                yield return new Langren_all(48, "Langren", 1644, "Maginus", 29.7988);
                yield return new Langren_all(49, "Langren", 1644, "Origanus", 30.0597);
                yield return new Langren_all(50, "Lelewel", 1851, "Iansonius", 17.432);
                yield return new Langren_all(51, "Lelewel", 1851, "Mercator", 19.9006);
                yield return new Langren_all(52, "Lelewel", 1851, "Schonerus", 20.6691);
                yield return new Langren_all(53, "Lelewel", 1851, "Lantsbergius", 21.0527);
                yield return new Langren_all(54, "Lelewel", 1851, "Brahe", 21.4362);
                yield return new Langren_all(55, "Lelewel", 1851, "Regiomontanus", 25.6093);
                yield return new Langren_all(56, "Lelewel", 1851, "Orontius", 25.9943);
                yield return new Langren_all(57, "Lelewel", 1851, "Clavius", 26.3778);
                yield return new Langren_all(58, "Lelewel", 1851, "Ptolomeus", 27.7841);
                yield return new Langren_all(59, "Lelewel", 1851, "Argelius", 28.1661);
                yield return new Langren_all(60, "Lelewel", 1851, "Maginus", 29.8295);
                yield return new Langren_all(61, "Lelewel", 1851, "Origanus", 30.1689);
            }
        }
    }
}
