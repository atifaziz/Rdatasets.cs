// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// political parties appearing in the U.S. Congress
    /// </summary>

    public class partycodes
    {
        public readonly int κ;
        public readonly int code;
        public readonly string party;

        public partycodes(int κ, int code, string party)
        {
            this.κ = κ;
            this.code = code;
            this.party = party;
        }

        public static IEnumerable<partycodes> Data
        {
            get
            {
                yield return new partycodes(1, 1, "Federalist");
                yield return new partycodes(2, 9, "Jefferson Republican");
                yield return new partycodes(3, 10, "Anti-Federalist");
                yield return new partycodes(4, 11, "Jefferson Democrat");
                yield return new partycodes(5, 13, "Democrat-Republican");
                yield return new partycodes(6, 22, "Adams");
                yield return new partycodes(7, 25, "National Republican");
                yield return new partycodes(8, 26, "Anti Masonic");
                yield return new partycodes(9, 29, "Whig");
                yield return new partycodes(10, 34, "Whig and Democrat");
                yield return new partycodes(11, 37, "Constitutional Unionist");
                yield return new partycodes(12, 40, "Anti-Democrat and States Rights");
                yield return new partycodes(13, 41, "Anti-Jackson Democrat");
                yield return new partycodes(14, 43, "Calhoun Nullifier");
                yield return new partycodes(15, 44, "Nullifier");
                yield return new partycodes(16, 46, "States Rights");
                yield return new partycodes(17, 48, "States Rights Whig");
                yield return new partycodes(18, 100, "Democrat");
                yield return new partycodes(19, 101, "Jackson Democrat");
                yield return new partycodes(20, 103, "Democrat and Anti-Mason");
                yield return new partycodes(21, 104, "Van Buren Democrat");
                yield return new partycodes(22, 105, "Conservative Democrat");
                yield return new partycodes(23, 108, "Anti-Lecompton Democrat");
                yield return new partycodes(24, 110, "Popular Sovereignty Democrat");
                yield return new partycodes(25, 112, "Conservative");
                yield return new partycodes(26, 114, "Readjuster");
                yield return new partycodes(27, 117, "Readjuster Democrat ");
                yield return new partycodes(28, 118, "Tariff for Revenue Democrat");
                yield return new partycodes(29, 119, "United Democrat");
                yield return new partycodes(30, 200, "Republican");
                yield return new partycodes(31, 202, "Union Conservative");
                yield return new partycodes(32, 203, "Unconditional Unionist");
                yield return new partycodes(33, 206, "Unionist");
                yield return new partycodes(34, 208, "Liberal Republican");
                yield return new partycodes(35, 212, "United Republican");
                yield return new partycodes(36, 213, "Progressive Republican");
                yield return new partycodes(37, 214, "Non-Partisan and Republican");
                yield return new partycodes(38, 215, "War Democrat");
                yield return new partycodes(39, 300, "Free Soil");
                yield return new partycodes(40, 301, "Free Soil Democrat");
                yield return new partycodes(41, 302, "Free Soil Whig");
                yield return new partycodes(42, 304, "Anti-Slavery");
                yield return new partycodes(43, 308, "Free Soil American and Democrat");
                yield return new partycodes(44, 310, "American");
                yield return new partycodes(45, 326, "National Greenbacker");
                yield return new partycodes(46, 328, "Independent");
                yield return new partycodes(47, 329, "Ind. Democrat");
                yield return new partycodes(48, 331, "Ind. Republican");
                yield return new partycodes(49, 333, "Ind. Republican-Democrat");
                yield return new partycodes(50, 336, "Anti-Monopolist");
                yield return new partycodes(51, 337, "Anti-Monopoly Democrat");
                yield return new partycodes(52, 340, "Populist");
                yield return new partycodes(53, 341, "Peoples");
                yield return new partycodes(54, 347, "Prohibitionist");
                yield return new partycodes(55, 353, "Ind. Silver Republican");
                yield return new partycodes(56, 354, "Silver Republican");
                yield return new partycodes(57, 355, "Union");
                yield return new partycodes(58, 356, "Union Labor");
                yield return new partycodes(59, 370, "Progressive ");
                yield return new partycodes(60, 380, "Socialist");
                yield return new partycodes(61, 401, "Fusionist ");
                yield return new partycodes(62, 402, "Liberal");
                yield return new partycodes(63, 403, "Law and Order");
                yield return new partycodes(64, 522, "American Labor");
                yield return new partycodes(65, 537, "Farmer-Labor");
                yield return new partycodes(66, 555, "Jackson");
                yield return new partycodes(67, 603, "Ind. Whig");
                yield return new partycodes(68, 1060, "Silver");
                yield return new partycodes(69, 1061, "Emancipationist");
                yield return new partycodes(70, 1111, "Liberty");
                yield return new partycodes(71, 1116, "Conservative Republican");
                yield return new partycodes(72, 1275, "Anti-Jackson");
                yield return new partycodes(73, 1346, "Jackson Republican");
                yield return new partycodes(74, 3333, "Opposition");
                yield return new partycodes(75, 4000, "Anti-Administration");
                yield return new partycodes(76, 4444, "Union");
                yield return new partycodes(77, 5000, "Pro-Administration");
                yield return new partycodes(78, 6000, "Crawford Federalist");
                yield return new partycodes(79, 6666, "Crawford Republican");
                yield return new partycodes(80, 7000, "Jackson Federalist");
                yield return new partycodes(81, 7777, "Crawford Republican");
                yield return new partycodes(82, 8000, "Adams-Clay Federalist");
                yield return new partycodes(83, 8888, "Adams-Clay Republican");
                yield return new partycodes(84, 9000, "Unknown");
                yield return new partycodes(85, 9999, "Unknown");
            }
        }
    }
}
