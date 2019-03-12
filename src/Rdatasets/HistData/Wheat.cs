// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Playfair's Data on Wages and the Price of Wheat
    /// </summary>

    public class Wheat
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double Wheat_;
        public readonly double? Wages;

        public Wheat(int κ, int Year, double Wheat_, double? Wages)
        {
            this.κ = κ;
            this.Year = Year;
            this.Wheat_ = Wheat_;
            this.Wages = Wages;
        }

        public static IEnumerable<Wheat> Data
        {
            get
            {
                yield return new Wheat(1, 1565, 41, 5);
                yield return new Wheat(2, 1570, 45, 5.05);
                yield return new Wheat(3, 1575, 42, 5.08);
                yield return new Wheat(4, 1580, 49, 5.12);
                yield return new Wheat(5, 1585, 41.5, 5.15);
                yield return new Wheat(6, 1590, 47, 5.25);
                yield return new Wheat(7, 1595, 64, 5.54);
                yield return new Wheat(8, 1600, 27, 5.61);
                yield return new Wheat(9, 1605, 33, 5.69);
                yield return new Wheat(10, 1610, 32, 5.78);
                yield return new Wheat(11, 1615, 33, 5.94);
                yield return new Wheat(12, 1620, 35, 6.01);
                yield return new Wheat(13, 1625, 33, 6.12);
                yield return new Wheat(14, 1630, 45, 6.22);
                yield return new Wheat(15, 1635, 33, 6.3);
                yield return new Wheat(16, 1640, 39, 6.37);
                yield return new Wheat(17, 1645, 53, 6.45);
                yield return new Wheat(18, 1650, 42, 6.5);
                yield return new Wheat(19, 1655, 40.5, 6.6);
                yield return new Wheat(20, 1660, 46.5, 6.75);
                yield return new Wheat(21, 1665, 32, 6.8);
                yield return new Wheat(22, 1670, 37, 6.9);
                yield return new Wheat(23, 1675, 43, 7);
                yield return new Wheat(24, 1680, 35, 7.3);
                yield return new Wheat(25, 1685, 27, 7.6);
                yield return new Wheat(26, 1690, 40, 8);
                yield return new Wheat(27, 1695, 50, 8.5);
                yield return new Wheat(28, 1700, 30, 9);
                yield return new Wheat(29, 1705, 32, 10);
                yield return new Wheat(30, 1710, 44, 11);
                yield return new Wheat(31, 1715, 33, 11.75);
                yield return new Wheat(32, 1720, 29, 12.5);
                yield return new Wheat(33, 1725, 39, 13);
                yield return new Wheat(34, 1730, 26, 13.3);
                yield return new Wheat(35, 1735, 32, 13.6);
                yield return new Wheat(36, 1740, 27, 14);
                yield return new Wheat(37, 1745, 27.5, 14.5);
                yield return new Wheat(38, 1750, 31, 15);
                yield return new Wheat(39, 1755, 35.5, 15.7);
                yield return new Wheat(40, 1760, 31, 16.5);
                yield return new Wheat(41, 1765, 43, 17.6);
                yield return new Wheat(42, 1770, 47, 18.5);
                yield return new Wheat(43, 1775, 44, 19.5);
                yield return new Wheat(44, 1780, 46, 21);
                yield return new Wheat(45, 1785, 42, 23);
                yield return new Wheat(46, 1790, 47.5, 25.5);
                yield return new Wheat(47, 1795, 76, 27.5);
                yield return new Wheat(48, 1800, 79, 28.5);
                yield return new Wheat(49, 1805, 81, 29.5);
                yield return new Wheat(50, 1810, 99, 30);
                yield return new Wheat(51, 1815, 78, null);
                yield return new Wheat(52, 1820, 54, null);
                yield return new Wheat(53, 1821, 54, null);
            }
        }
    }
}
