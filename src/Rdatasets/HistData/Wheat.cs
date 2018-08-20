// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Playfair's Data on Wages and the Price of Wheat
    /// </summary>

    public class Wheat
    {
        public readonly int Year;
        public readonly double Wheat_;
        public readonly double? Wages;

        public Wheat(int Year, double Wheat_, double? Wages)
        {
            this.Year = Year;
            this.Wheat_ = Wheat_;
            this.Wages = Wages;
        }

        public static IEnumerable<Wheat> Data
        {
            get
            {
                yield return new Wheat(1565, 41, 5);
                yield return new Wheat(1570, 45, 5.05);
                yield return new Wheat(1575, 42, 5.08);
                yield return new Wheat(1580, 49, 5.12);
                yield return new Wheat(1585, 41.5, 5.15);
                yield return new Wheat(1590, 47, 5.25);
                yield return new Wheat(1595, 64, 5.54);
                yield return new Wheat(1600, 27, 5.61);
                yield return new Wheat(1605, 33, 5.69);
                yield return new Wheat(1610, 32, 5.78);
                yield return new Wheat(1615, 33, 5.94);
                yield return new Wheat(1620, 35, 6.01);
                yield return new Wheat(1625, 33, 6.12);
                yield return new Wheat(1630, 45, 6.22);
                yield return new Wheat(1635, 33, 6.3);
                yield return new Wheat(1640, 39, 6.37);
                yield return new Wheat(1645, 53, 6.45);
                yield return new Wheat(1650, 42, 6.5);
                yield return new Wheat(1655, 40.5, 6.6);
                yield return new Wheat(1660, 46.5, 6.75);
                yield return new Wheat(1665, 32, 6.8);
                yield return new Wheat(1670, 37, 6.9);
                yield return new Wheat(1675, 43, 7);
                yield return new Wheat(1680, 35, 7.3);
                yield return new Wheat(1685, 27, 7.6);
                yield return new Wheat(1690, 40, 8);
                yield return new Wheat(1695, 50, 8.5);
                yield return new Wheat(1700, 30, 9);
                yield return new Wheat(1705, 32, 10);
                yield return new Wheat(1710, 44, 11);
                yield return new Wheat(1715, 33, 11.75);
                yield return new Wheat(1720, 29, 12.5);
                yield return new Wheat(1725, 39, 13);
                yield return new Wheat(1730, 26, 13.3);
                yield return new Wheat(1735, 32, 13.6);
                yield return new Wheat(1740, 27, 14);
                yield return new Wheat(1745, 27.5, 14.5);
                yield return new Wheat(1750, 31, 15);
                yield return new Wheat(1755, 35.5, 15.7);
                yield return new Wheat(1760, 31, 16.5);
                yield return new Wheat(1765, 43, 17.6);
                yield return new Wheat(1770, 47, 18.5);
                yield return new Wheat(1775, 44, 19.5);
                yield return new Wheat(1780, 46, 21);
                yield return new Wheat(1785, 42, 23);
                yield return new Wheat(1790, 47.5, 25.5);
                yield return new Wheat(1795, 76, 27.5);
                yield return new Wheat(1800, 79, 28.5);
                yield return new Wheat(1805, 81, 29.5);
                yield return new Wheat(1810, 99, 30);
                yield return new Wheat(1815, 78, null);
                yield return new Wheat(1820, 54, null);
                yield return new Wheat(1821, 54, null);
            }
        }
    }
}
