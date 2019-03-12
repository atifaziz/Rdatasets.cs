// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// information about the American states needed for U.S. Congress
    /// </summary>

    public class state_info
    {
        public readonly int κ;
        public readonly int icpsr;
        public readonly string state;
        public readonly int? year;

        public state_info(int κ, int icpsr, string state, int? year)
        {
            this.κ = κ;
            this.icpsr = icpsr;
            this.state = state;
            this.year = year;
        }

        public static IEnumerable<state_info> Data
        {
            get
            {
                yield return new state_info(1, 1, "Connecticut", 1788);
                yield return new state_info(2, 2, "Maine", 1820);
                yield return new state_info(3, 3, "Massachusetts", 1788);
                yield return new state_info(4, 4, "New Hampshire", 1788);
                yield return new state_info(5, 5, "Rhode Island", 1790);
                yield return new state_info(6, 6, "Vermont", 1791);
                yield return new state_info(7, 11, "Delaware", 1787);
                yield return new state_info(8, 12, "New Jersey", 1787);
                yield return new state_info(9, 13, "New York", 1788);
                yield return new state_info(10, 14, "Pennsylvania", 1787);
                yield return new state_info(11, 21, "Illinois", 1818);
                yield return new state_info(12, 22, "Indiana", 1816);
                yield return new state_info(13, 23, "Michigan", 1837);
                yield return new state_info(14, 24, "Ohio", 1803);
                yield return new state_info(15, 25, "Wisconsin", 1848);
                yield return new state_info(16, 31, "Iowa", 1846);
                yield return new state_info(17, 32, "Kansas", 1861);
                yield return new state_info(18, 33, "Minnesota", 1858);
                yield return new state_info(19, 34, "Missouri", 1821);
                yield return new state_info(20, 35, "Nebraska", 1867);
                yield return new state_info(21, 36, "North Dakota", 1889);
                yield return new state_info(22, 37, "South Dakota", 1889);
                yield return new state_info(23, 41, "Alabama", 1819);
                yield return new state_info(24, 42, "Arkansas", 1836);
                yield return new state_info(25, 43, "Florida", 1845);
                yield return new state_info(26, 44, "Georgia", 1788);
                yield return new state_info(27, 45, "Louisiana", 1812);
                yield return new state_info(28, 46, "Mississippi", 1817);
                yield return new state_info(29, 47, "North Carolina", 1789);
                yield return new state_info(30, 48, "South Carolina", 1788);
                yield return new state_info(31, 49, "Texas", 1845);
                yield return new state_info(32, 40, "Virginia", 1788);
                yield return new state_info(33, 51, "Kentucky", 1792);
                yield return new state_info(34, 52, "Maryland", 1788);
                yield return new state_info(35, 53, "Oklahoma", 1907);
                yield return new state_info(36, 54, "Tennessee", 1796);
                yield return new state_info(37, 55, "Washington D.C.", null);
                yield return new state_info(38, 56, "West Virginia", 1863);
                yield return new state_info(39, 61, "Arizona", 1912);
                yield return new state_info(40, 62, "Colorado", 1876);
                yield return new state_info(41, 63, "Idaho", 1890);
                yield return new state_info(42, 64, "Montana", 1889);
                yield return new state_info(43, 65, "Nevada", 1864);
                yield return new state_info(44, 66, "New Mexico", 1912);
                yield return new state_info(45, 67, "Utah", 1896);
                yield return new state_info(46, 68, "Wyoming", 1890);
                yield return new state_info(47, 71, "California", 1850);
                yield return new state_info(48, 72, "Oregon", 1859);
                yield return new state_info(49, 73, "Washington", 1889);
                yield return new state_info(50, 81, "Alaska", 1959);
                yield return new state_info(51, 82, "Hawaii", 1959);
            }
        }
    }
}
