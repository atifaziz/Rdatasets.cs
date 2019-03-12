// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Mortality and Water Hardness
    /// </summary>

    public class water
    {
        public readonly int κ;
        public readonly string location;
        public readonly string town;
        public readonly int mortality;
        public readonly int hardness;

        public water(int κ, string location, string town, int mortality, int hardness)
        {
            this.κ = κ;
            this.location = location;
            this.town = town;
            this.mortality = mortality;
            this.hardness = hardness;
        }

        public static IEnumerable<water> Data
        {
            get
            {
                yield return new water(1, "South", "Bath", 1247, 105);
                yield return new water(2, "North", "Birkenhead", 1668, 17);
                yield return new water(3, "South", "Birmingham", 1466, 5);
                yield return new water(4, "North", "Blackburn", 1800, 14);
                yield return new water(5, "North", "Blackpool", 1609, 18);
                yield return new water(6, "North", "Bolton", 1558, 10);
                yield return new water(7, "North", "Bootle", 1807, 15);
                yield return new water(8, "South", "Bournemouth", 1299, 78);
                yield return new water(9, "North", "Bradford", 1637, 10);
                yield return new water(10, "South", "Brighton", 1359, 84);
                yield return new water(11, "South", "Bristol", 1392, 73);
                yield return new water(12, "North", "Burnley", 1755, 12);
                yield return new water(13, "South", "Cardiff", 1519, 21);
                yield return new water(14, "South", "Coventry", 1307, 78);
                yield return new water(15, "South", "Croydon", 1254, 96);
                yield return new water(16, "North", "Darlington", 1491, 20);
                yield return new water(17, "North", "Derby", 1555, 39);
                yield return new water(18, "North", "Doncaster", 1428, 39);
                yield return new water(19, "South", "East Ham", 1318, 122);
                yield return new water(20, "South", "Exeter", 1260, 21);
                yield return new water(21, "North", "Gateshead", 1723, 44);
                yield return new water(22, "North", "Grimsby", 1379, 94);
                yield return new water(23, "North", "Halifax", 1742, 8);
                yield return new water(24, "North", "Huddersfield", 1574, 9);
                yield return new water(25, "North", "Hull", 1569, 91);
                yield return new water(26, "South", "Ipswich", 1096, 138);
                yield return new water(27, "North", "Leeds", 1591, 16);
                yield return new water(28, "South", "Leicester", 1402, 37);
                yield return new water(29, "North", "Liverpool", 1772, 15);
                yield return new water(30, "North", "Manchester", 1828, 8);
                yield return new water(31, "North", "Middlesbrough", 1704, 26);
                yield return new water(32, "North", "Newcastle", 1702, 44);
                yield return new water(33, "South", "Newport", 1581, 14);
                yield return new water(34, "South", "Northampton", 1309, 59);
                yield return new water(35, "South", "Norwich", 1259, 133);
                yield return new water(36, "North", "Nottingham", 1427, 27);
                yield return new water(37, "North", "Oldham", 1724, 6);
                yield return new water(38, "South", "Oxford", 1175, 107);
                yield return new water(39, "South", "Plymouth", 1486, 5);
                yield return new water(40, "South", "Portsmouth", 1456, 90);
                yield return new water(41, "North", "Preston", 1696, 6);
                yield return new water(42, "South", "Reading", 1236, 101);
                yield return new water(43, "North", "Rochdale", 1711, 13);
                yield return new water(44, "North", "Rotherham", 1444, 14);
                yield return new water(45, "North", "St Helens", 1591, 49);
                yield return new water(46, "North", "Salford", 1987, 8);
                yield return new water(47, "North", "Sheffield", 1495, 14);
                yield return new water(48, "South", "Southampton", 1369, 68);
                yield return new water(49, "South", "Southend", 1257, 50);
                yield return new water(50, "North", "Southport", 1587, 75);
                yield return new water(51, "North", "South Shields", 1713, 71);
                yield return new water(52, "North", "Stockport", 1557, 13);
                yield return new water(53, "North", "Stoke", 1640, 57);
                yield return new water(54, "North", "Sunderland", 1709, 71);
                yield return new water(55, "South", "Swansea", 1625, 13);
                yield return new water(56, "North", "Wallasey", 1625, 20);
                yield return new water(57, "South", "Walsall", 1527, 60);
                yield return new water(58, "South", "West Bromwich", 1627, 53);
                yield return new water(59, "South", "West Ham", 1486, 122);
                yield return new water(60, "South", "Wolverhampton", 1485, 81);
                yield return new water(61, "North", "York", 1378, 71);
            }
        }
    }
}
