// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Internet Usage per Minute
    /// </summary>

    public class WWWusage
    {
        public readonly int time;
        public readonly int value;

        public WWWusage(int time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<WWWusage> Data
        {
            get
            {
                yield return new WWWusage(1, 88);
                yield return new WWWusage(2, 84);
                yield return new WWWusage(3, 85);
                yield return new WWWusage(4, 85);
                yield return new WWWusage(5, 84);
                yield return new WWWusage(6, 85);
                yield return new WWWusage(7, 83);
                yield return new WWWusage(8, 85);
                yield return new WWWusage(9, 88);
                yield return new WWWusage(10, 89);
                yield return new WWWusage(11, 91);
                yield return new WWWusage(12, 99);
                yield return new WWWusage(13, 104);
                yield return new WWWusage(14, 112);
                yield return new WWWusage(15, 126);
                yield return new WWWusage(16, 138);
                yield return new WWWusage(17, 146);
                yield return new WWWusage(18, 151);
                yield return new WWWusage(19, 150);
                yield return new WWWusage(20, 148);
                yield return new WWWusage(21, 147);
                yield return new WWWusage(22, 149);
                yield return new WWWusage(23, 143);
                yield return new WWWusage(24, 132);
                yield return new WWWusage(25, 131);
                yield return new WWWusage(26, 139);
                yield return new WWWusage(27, 147);
                yield return new WWWusage(28, 150);
                yield return new WWWusage(29, 148);
                yield return new WWWusage(30, 145);
                yield return new WWWusage(31, 140);
                yield return new WWWusage(32, 134);
                yield return new WWWusage(33, 131);
                yield return new WWWusage(34, 131);
                yield return new WWWusage(35, 129);
                yield return new WWWusage(36, 126);
                yield return new WWWusage(37, 126);
                yield return new WWWusage(38, 132);
                yield return new WWWusage(39, 137);
                yield return new WWWusage(40, 140);
                yield return new WWWusage(41, 142);
                yield return new WWWusage(42, 150);
                yield return new WWWusage(43, 159);
                yield return new WWWusage(44, 167);
                yield return new WWWusage(45, 170);
                yield return new WWWusage(46, 171);
                yield return new WWWusage(47, 172);
                yield return new WWWusage(48, 172);
                yield return new WWWusage(49, 174);
                yield return new WWWusage(50, 175);
                yield return new WWWusage(51, 172);
                yield return new WWWusage(52, 172);
                yield return new WWWusage(53, 174);
                yield return new WWWusage(54, 174);
                yield return new WWWusage(55, 169);
                yield return new WWWusage(56, 165);
                yield return new WWWusage(57, 156);
                yield return new WWWusage(58, 142);
                yield return new WWWusage(59, 131);
                yield return new WWWusage(60, 121);
                yield return new WWWusage(61, 112);
                yield return new WWWusage(62, 104);
                yield return new WWWusage(63, 102);
                yield return new WWWusage(64, 99);
                yield return new WWWusage(65, 99);
                yield return new WWWusage(66, 95);
                yield return new WWWusage(67, 88);
                yield return new WWWusage(68, 84);
                yield return new WWWusage(69, 84);
                yield return new WWWusage(70, 87);
                yield return new WWWusage(71, 89);
                yield return new WWWusage(72, 88);
                yield return new WWWusage(73, 85);
                yield return new WWWusage(74, 86);
                yield return new WWWusage(75, 89);
                yield return new WWWusage(76, 91);
                yield return new WWWusage(77, 91);
                yield return new WWWusage(78, 94);
                yield return new WWWusage(79, 101);
                yield return new WWWusage(80, 110);
                yield return new WWWusage(81, 121);
                yield return new WWWusage(82, 135);
                yield return new WWWusage(83, 145);
                yield return new WWWusage(84, 149);
                yield return new WWWusage(85, 156);
                yield return new WWWusage(86, 165);
                yield return new WWWusage(87, 171);
                yield return new WWWusage(88, 175);
                yield return new WWWusage(89, 177);
                yield return new WWWusage(90, 182);
                yield return new WWWusage(91, 193);
                yield return new WWWusage(92, 204);
                yield return new WWWusage(93, 208);
                yield return new WWWusage(94, 210);
                yield return new WWWusage(95, 215);
                yield return new WWWusage(96, 222);
                yield return new WWWusage(97, 228);
                yield return new WWWusage(98, 226);
                yield return new WWWusage(99, 222);
                yield return new WWWusage(100, 220);
            }
        }
    }
}
