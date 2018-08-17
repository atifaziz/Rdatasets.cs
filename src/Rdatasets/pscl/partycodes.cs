// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// political parties appearing in the U.S. Congress
    /// </summary>

    public class partycodes
    {
        public readonly int code;
        public readonly string party;

        public partycodes(int code, string party)
        {
            this.code = code;
            this.party = party;
        }

        public static IEnumerable<partycodes> Data
        {
            get
            {
                yield return new partycodes(1, "Federalist");
                yield return new partycodes(9, "Jefferson Republican");
                yield return new partycodes(10, "Anti-Federalist");
                yield return new partycodes(11, "Jefferson Democrat");
                yield return new partycodes(13, "Democrat-Republican");
                yield return new partycodes(22, "Adams");
                yield return new partycodes(25, "National Republican");
                yield return new partycodes(26, "Anti Masonic");
                yield return new partycodes(29, "Whig");
                yield return new partycodes(34, "Whig and Democrat");
                yield return new partycodes(37, "Constitutional Unionist");
                yield return new partycodes(40, "Anti-Democrat and States Rights");
                yield return new partycodes(41, "Anti-Jackson Democrat");
                yield return new partycodes(43, "Calhoun Nullifier");
                yield return new partycodes(44, "Nullifier");
                yield return new partycodes(46, "States Rights");
                yield return new partycodes(48, "States Rights Whig");
                yield return new partycodes(100, "Democrat");
                yield return new partycodes(101, "Jackson Democrat");
                yield return new partycodes(103, "Democrat and Anti-Mason");
                yield return new partycodes(104, "Van Buren Democrat");
                yield return new partycodes(105, "Conservative Democrat");
                yield return new partycodes(108, "Anti-Lecompton Democrat");
                yield return new partycodes(110, "Popular Sovereignty Democrat");
                yield return new partycodes(112, "Conservative");
                yield return new partycodes(114, "Readjuster");
                yield return new partycodes(117, "Readjuster Democrat ");
                yield return new partycodes(118, "Tariff for Revenue Democrat");
                yield return new partycodes(119, "United Democrat");
                yield return new partycodes(200, "Republican");
                yield return new partycodes(202, "Union Conservative");
                yield return new partycodes(203, "Unconditional Unionist");
                yield return new partycodes(206, "Unionist");
                yield return new partycodes(208, "Liberal Republican");
                yield return new partycodes(212, "United Republican");
                yield return new partycodes(213, "Progressive Republican");
                yield return new partycodes(214, "Non-Partisan and Republican");
                yield return new partycodes(215, "War Democrat");
                yield return new partycodes(300, "Free Soil");
                yield return new partycodes(301, "Free Soil Democrat");
                yield return new partycodes(302, "Free Soil Whig");
                yield return new partycodes(304, "Anti-Slavery");
                yield return new partycodes(308, "Free Soil American and Democrat");
                yield return new partycodes(310, "American");
                yield return new partycodes(326, "National Greenbacker");
                yield return new partycodes(328, "Independent");
                yield return new partycodes(329, "Ind. Democrat");
                yield return new partycodes(331, "Ind. Republican");
                yield return new partycodes(333, "Ind. Republican-Democrat");
                yield return new partycodes(336, "Anti-Monopolist");
                yield return new partycodes(337, "Anti-Monopoly Democrat");
                yield return new partycodes(340, "Populist");
                yield return new partycodes(341, "Peoples");
                yield return new partycodes(347, "Prohibitionist");
                yield return new partycodes(353, "Ind. Silver Republican");
                yield return new partycodes(354, "Silver Republican");
                yield return new partycodes(355, "Union");
                yield return new partycodes(356, "Union Labor");
                yield return new partycodes(370, "Progressive ");
                yield return new partycodes(380, "Socialist");
                yield return new partycodes(401, "Fusionist ");
                yield return new partycodes(402, "Liberal");
                yield return new partycodes(403, "Law and Order");
                yield return new partycodes(522, "American Labor");
                yield return new partycodes(537, "Farmer-Labor");
                yield return new partycodes(555, "Jackson");
                yield return new partycodes(603, "Ind. Whig");
                yield return new partycodes(1060, "Silver");
                yield return new partycodes(1061, "Emancipationist");
                yield return new partycodes(1111, "Liberty");
                yield return new partycodes(1116, "Conservative Republican");
                yield return new partycodes(1275, "Anti-Jackson");
                yield return new partycodes(1346, "Jackson Republican");
                yield return new partycodes(3333, "Opposition");
                yield return new partycodes(4000, "Anti-Administration");
                yield return new partycodes(4444, "Union");
                yield return new partycodes(5000, "Pro-Administration");
                yield return new partycodes(6000, "Crawford Federalist");
                yield return new partycodes(6666, "Crawford Republican");
                yield return new partycodes(7000, "Jackson Federalist");
                yield return new partycodes(7777, "Crawford Republican");
                yield return new partycodes(8000, "Adams-Clay Federalist");
                yield return new partycodes(8888, "Adams-Clay Republican");
                yield return new partycodes(9000, "Unknown");
                yield return new partycodes(9999, "Unknown");
            }
        }
    }
}
