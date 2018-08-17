// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Mortality and Water Hardness
    /// </summary>

    public class water
    {
        public readonly string location;
        public readonly string town;
        public readonly int mortality;
        public readonly int hardness;

        public water(string location, string town, int mortality, int hardness)
        {
            this.location = location;
            this.town = town;
            this.mortality = mortality;
            this.hardness = hardness;
        }

        public static IEnumerable<water> Data
        {
            get
            {
                yield return new water("South", "Bath", 1247, 105);
                yield return new water("North", "Birkenhead", 1668, 17);
                yield return new water("South", "Birmingham", 1466, 5);
                yield return new water("North", "Blackburn", 1800, 14);
                yield return new water("North", "Blackpool", 1609, 18);
                yield return new water("North", "Bolton", 1558, 10);
                yield return new water("North", "Bootle", 1807, 15);
                yield return new water("South", "Bournemouth", 1299, 78);
                yield return new water("North", "Bradford", 1637, 10);
                yield return new water("South", "Brighton", 1359, 84);
                yield return new water("South", "Bristol", 1392, 73);
                yield return new water("North", "Burnley", 1755, 12);
                yield return new water("South", "Cardiff", 1519, 21);
                yield return new water("South", "Coventry", 1307, 78);
                yield return new water("South", "Croydon", 1254, 96);
                yield return new water("North", "Darlington", 1491, 20);
                yield return new water("North", "Derby", 1555, 39);
                yield return new water("North", "Doncaster", 1428, 39);
                yield return new water("South", "East Ham", 1318, 122);
                yield return new water("South", "Exeter", 1260, 21);
                yield return new water("North", "Gateshead", 1723, 44);
                yield return new water("North", "Grimsby", 1379, 94);
                yield return new water("North", "Halifax", 1742, 8);
                yield return new water("North", "Huddersfield", 1574, 9);
                yield return new water("North", "Hull", 1569, 91);
                yield return new water("South", "Ipswich", 1096, 138);
                yield return new water("North", "Leeds", 1591, 16);
                yield return new water("South", "Leicester", 1402, 37);
                yield return new water("North", "Liverpool", 1772, 15);
                yield return new water("North", "Manchester", 1828, 8);
                yield return new water("North", "Middlesbrough", 1704, 26);
                yield return new water("North", "Newcastle", 1702, 44);
                yield return new water("South", "Newport", 1581, 14);
                yield return new water("South", "Northampton", 1309, 59);
                yield return new water("South", "Norwich", 1259, 133);
                yield return new water("North", "Nottingham", 1427, 27);
                yield return new water("North", "Oldham", 1724, 6);
                yield return new water("South", "Oxford", 1175, 107);
                yield return new water("South", "Plymouth", 1486, 5);
                yield return new water("South", "Portsmouth", 1456, 90);
                yield return new water("North", "Preston", 1696, 6);
                yield return new water("South", "Reading", 1236, 101);
                yield return new water("North", "Rochdale", 1711, 13);
                yield return new water("North", "Rotherham", 1444, 14);
                yield return new water("North", "St Helens", 1591, 49);
                yield return new water("North", "Salford", 1987, 8);
                yield return new water("North", "Sheffield", 1495, 14);
                yield return new water("South", "Southampton", 1369, 68);
                yield return new water("South", "Southend", 1257, 50);
                yield return new water("North", "Southport", 1587, 75);
                yield return new water("North", "South Shields", 1713, 71);
                yield return new water("North", "Stockport", 1557, 13);
                yield return new water("North", "Stoke", 1640, 57);
                yield return new water("North", "Sunderland", 1709, 71);
                yield return new water("South", "Swansea", 1625, 13);
                yield return new water("North", "Wallasey", 1625, 20);
                yield return new water("South", "Walsall", 1527, 60);
                yield return new water("South", "West Bromwich", 1627, 53);
                yield return new water("South", "West Ham", 1486, 122);
                yield return new water("South", "Wolverhampton", 1485, 81);
                yield return new water("North", "York", 1378, 71);
            }
        }
    }
}
