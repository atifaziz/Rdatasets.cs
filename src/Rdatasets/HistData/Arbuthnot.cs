// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Arbuthnot's data on male and female birth ratios in London from 1629-1710.
    /// </summary>

    public class Arbuthnot
    {
        public readonly int κ;
        public readonly int Year;
        public readonly int Males;
        public readonly int Females;
        public readonly int Plague;
        public readonly int Mortality;
        public readonly double Ratio;
        public readonly double Total;

        public Arbuthnot(int κ, int Year, int Males, int Females, int Plague, int Mortality, double Ratio, double Total)
        {
            this.κ = κ;
            this.Year = Year;
            this.Males = Males;
            this.Females = Females;
            this.Plague = Plague;
            this.Mortality = Mortality;
            this.Ratio = Ratio;
            this.Total = Total;
        }

        public static IEnumerable<Arbuthnot> Data
        {
            get
            {
                yield return new Arbuthnot(1, 1629, 5218, 4683, 0, 8771, 1.1142430066, 9.901);
                yield return new Arbuthnot(2, 1630, 4858, 4457, 1317, 10554, 1.0899708324, 9.315);
                yield return new Arbuthnot(3, 1631, 4422, 4102, 274, 8562, 1.0780107265, 8.524);
                yield return new Arbuthnot(4, 1632, 4994, 4590, 8, 9535, 1.0880174292, 9.584);
                yield return new Arbuthnot(5, 1633, 5158, 4839, 0, 8393, 1.0659227113, 9.997);
                yield return new Arbuthnot(6, 1634, 5035, 4820, 1, 10400, 1.0446058091, 9.855);
                yield return new Arbuthnot(7, 1635, 5106, 4928, 0, 10651, 1.0361201299, 10.034);
                yield return new Arbuthnot(8, 1636, 4917, 4605, 10400, 23359, 1.067752443, 9.522);
                yield return new Arbuthnot(9, 1637, 4703, 4457, 3082, 11763, 1.0551940767, 9.16);
                yield return new Arbuthnot(10, 1638, 5359, 4952, 363, 13624, 1.0821890145, 10.311);
                yield return new Arbuthnot(11, 1639, 5366, 4784, 314, 9862, 1.1216555184, 10.15);
                yield return new Arbuthnot(12, 1640, 5518, 5332, 1450, 12771, 1.0348837209, 10.85);
                yield return new Arbuthnot(13, 1641, 5470, 5200, 1375, 13142, 1.0519230769, 10.67);
                yield return new Arbuthnot(14, 1642, 5460, 4910, 1274, 13273, 1.1120162933, 10.37);
                yield return new Arbuthnot(15, 1643, 4793, 4617, 996, 13212, 1.0381199913, 9.41);
                yield return new Arbuthnot(16, 1644, 4107, 3997, 1492, 10933, 1.0275206405, 8.104);
                yield return new Arbuthnot(17, 1645, 4047, 3919, 1871, 11479, 1.0326613932, 7.966);
                yield return new Arbuthnot(18, 1646, 3768, 3395, 2365, 12780, 1.1098674521, 7.163);
                yield return new Arbuthnot(19, 1647, 3796, 3536, 3597, 14059, 1.0735294118, 7.332);
                yield return new Arbuthnot(20, 1648, 3363, 3181, 611, 9894, 1.0572147124, 6.544);
                yield return new Arbuthnot(21, 1649, 3079, 2746, 67, 10566, 1.1212672979, 5.825);
                yield return new Arbuthnot(22, 1650, 2890, 2722, 15, 8754, 1.061719324, 5.612);
                yield return new Arbuthnot(23, 1651, 3231, 2840, 23, 10827, 1.1376760563, 6.071);
                yield return new Arbuthnot(24, 1652, 3220, 2908, 16, 12569, 1.1072902338, 6.128);
                yield return new Arbuthnot(25, 1653, 3196, 2959, 6, 10087, 1.0800946266, 6.155);
                yield return new Arbuthnot(26, 1654, 3441, 3179, 16, 13247, 1.082415854, 6.62);
                yield return new Arbuthnot(27, 1655, 3655, 3349, 9, 11357, 1.0913705584, 7.004);
                yield return new Arbuthnot(28, 1656, 3668, 3382, 6, 13921, 1.0845653459, 7.05);
                yield return new Arbuthnot(29, 1657, 3396, 3289, 4, 12434, 1.0325326847, 6.685);
                yield return new Arbuthnot(30, 1658, 3157, 3013, 14, 14993, 1.0477928974, 6.17);
                yield return new Arbuthnot(31, 1659, 3209, 2781, 36, 14756, 1.1539014743, 5.99);
                yield return new Arbuthnot(32, 1660, 3724, 3247, 13, 12681, 1.1469048352, 6.971);
                yield return new Arbuthnot(33, 1661, 4748, 4107, 20, 16665, 1.1560749939, 8.855);
                yield return new Arbuthnot(34, 1662, 5216, 4803, 12, 13664, 1.0859879242, 10.019);
                yield return new Arbuthnot(35, 1663, 5411, 4881, 9, 12741, 1.1085843065, 10.292);
                yield return new Arbuthnot(36, 1664, 6041, 5681, 5, 15453, 1.0633691252, 11.722);
                yield return new Arbuthnot(37, 1665, 5114, 4858, 68596, 97306, 1.052696583, 9.972);
                yield return new Arbuthnot(38, 1666, 4678, 4319, 1998, 12738, 1.0831210928, 8.997);
                yield return new Arbuthnot(39, 1667, 5616, 5322, 35, 15842, 1.0552423901, 10.938);
                yield return new Arbuthnot(40, 1668, 6073, 5560, 14, 17278, 1.0922661871, 11.633);
                yield return new Arbuthnot(41, 1669, 6506, 5829, 3, 19432, 1.1161434208, 12.335);
                yield return new Arbuthnot(42, 1670, 6278, 5719, 0, 20198, 1.0977443609, 11.997);
                yield return new Arbuthnot(43, 1671, 6449, 6061, 5, 15729, 1.064015839, 12.51);
                yield return new Arbuthnot(44, 1672, 6443, 6120, 5, 18230, 1.0527777778, 12.563);
                yield return new Arbuthnot(45, 1673, 6073, 5822, 5, 17504, 1.0431123325, 11.895);
                yield return new Arbuthnot(46, 1674, 6113, 5738, 3, 21201, 1.0653537818, 11.851);
                yield return new Arbuthnot(47, 1675, 6058, 5717, 1, 17244, 1.0596466678, 11.775);
                yield return new Arbuthnot(48, 1676, 6552, 5847, 2, 18732, 1.1205746537, 12.399);
                yield return new Arbuthnot(49, 1677, 6423, 6203, 2, 19076, 1.0354667097, 12.626);
                yield return new Arbuthnot(50, 1678, 6568, 6033, 5, 20678, 1.0886789325, 12.601);
                yield return new Arbuthnot(51, 1679, 6247, 6041, 2, 21730, 1.0341003145, 12.288);
                yield return new Arbuthnot(52, 1680, 6548, 6299, 0, 21053, 1.0395300841, 12.847);
                yield return new Arbuthnot(53, 1681, 6822, 6533, 0, 23951, 1.0442369509, 13.355);
                yield return new Arbuthnot(54, 1682, 6909, 6744, 0, 20691, 1.0244661922, 13.653);
                yield return new Arbuthnot(55, 1683, 7577, 7158, 0, 20587, 1.0585359039, 14.735);
                yield return new Arbuthnot(56, 1684, 7575, 7127, 0, 23202, 1.0628595482, 14.702);
                yield return new Arbuthnot(57, 1685, 7484, 7246, 0, 23222, 1.032845708, 14.73);
                yield return new Arbuthnot(58, 1686, 7575, 7119, 0, 22609, 1.0640539402, 14.694);
                yield return new Arbuthnot(59, 1687, 7737, 7214, 0, 21460, 1.0724979207, 14.951);
                yield return new Arbuthnot(60, 1688, 7487, 7101, 0, 22921, 1.0543585411, 14.588);
                yield return new Arbuthnot(61, 1689, 7604, 7167, 0, 23502, 1.0609739082, 14.771);
                yield return new Arbuthnot(62, 1690, 7909, 7302, 0, 21461, 1.0831279102, 15.211);
                yield return new Arbuthnot(63, 1691, 7662, 7392, 0, 22691, 1.036525974, 15.054);
                yield return new Arbuthnot(64, 1692, 7602, 7316, 0, 20874, 1.0390924002, 14.918);
                yield return new Arbuthnot(65, 1693, 7676, 7483, 0, 20959, 1.0257917947, 15.159);
                yield return new Arbuthnot(66, 1694, 6985, 6647, 0, 24109, 1.0508500075, 13.632);
                yield return new Arbuthnot(67, 1695, 7263, 6713, 0, 19047, 1.0819305825, 13.976);
                yield return new Arbuthnot(68, 1696, 7632, 7229, 0, 18638, 1.0557476829, 14.861);
                yield return new Arbuthnot(69, 1697, 8062, 7767, 0, 20292, 1.0379812025, 15.829);
                yield return new Arbuthnot(70, 1698, 8426, 7626, 0, 20183, 1.1049042748, 16.052);
                yield return new Arbuthnot(71, 1699, 7911, 7452, 0, 20795, 1.0615942029, 15.363);
                yield return new Arbuthnot(72, 1700, 7578, 7061, 0, 19443, 1.0732190908, 14.639);
                yield return new Arbuthnot(73, 1701, 8102, 7514, 0, 20471, 1.078253926, 15.616);
                yield return new Arbuthnot(74, 1702, 8031, 7656, 0, 19481, 1.0489811912, 15.687);
                yield return new Arbuthnot(75, 1703, 7765, 7683, 0, 20720, 1.0106729142, 15.448);
                yield return new Arbuthnot(76, 1704, 6113, 5738, 0, 22684, 1.0653537818, 11.851);
                yield return new Arbuthnot(77, 1705, 8366, 7779, 0, 22097, 1.0754595706, 16.145);
                yield return new Arbuthnot(78, 1706, 7952, 7417, 0, 19847, 1.0721315896, 15.369);
                yield return new Arbuthnot(79, 1707, 8379, 7687, 0, 21600, 1.0900221153, 16.066);
                yield return new Arbuthnot(80, 1708, 8239, 7623, 0, 21291, 1.0808080808, 15.862);
                yield return new Arbuthnot(81, 1709, 7840, 7380, 0, 21800, 1.0623306233, 15.22);
                yield return new Arbuthnot(82, 1710, 7640, 7288, 0, 24620, 1.048298573, 14.928);
            }
        }
    }
}
