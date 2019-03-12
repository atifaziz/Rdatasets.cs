// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cuckoo
    /// </summary>

    public class Cuckoo
    {
        public readonly int κ;
        public readonly string Bird;
        public readonly double Length;

        public Cuckoo(int κ, string Bird, double Length)
        {
            this.κ = κ;
            this.Bird = Bird;
            this.Length = Length;
        }

        public static IEnumerable<Cuckoo> Data
        {
            get
            {
                yield return new Cuckoo(1, "mdw_pippit", 19.65);
                yield return new Cuckoo(2, "mdw_pippit", 20.05);
                yield return new Cuckoo(3, "mdw_pippit", 20.65);
                yield return new Cuckoo(4, "mdw_pippit", 20.85);
                yield return new Cuckoo(5, "mdw_pippit", 21.65);
                yield return new Cuckoo(6, "mdw_pippit", 21.65);
                yield return new Cuckoo(7, "mdw_pippit", 21.65);
                yield return new Cuckoo(8, "mdw_pippit", 21.85);
                yield return new Cuckoo(9, "mdw_pippit", 21.85);
                yield return new Cuckoo(10, "mdw_pippit", 21.85);
                yield return new Cuckoo(11, "mdw_pippit", 22.05);
                yield return new Cuckoo(12, "mdw_pippit", 22.05);
                yield return new Cuckoo(13, "mdw_pippit", 22.05);
                yield return new Cuckoo(14, "mdw_pippit", 22.05);
                yield return new Cuckoo(15, "mdw_pippit", 22.05);
                yield return new Cuckoo(16, "mdw_pippit", 22.05);
                yield return new Cuckoo(17, "mdw_pippit", 22.05);
                yield return new Cuckoo(18, "mdw_pippit", 22.05);
                yield return new Cuckoo(19, "mdw_pippit", 22.05);
                yield return new Cuckoo(20, "mdw_pippit", 22.05);
                yield return new Cuckoo(21, "mdw_pippit", 22.25);
                yield return new Cuckoo(22, "mdw_pippit", 22.25);
                yield return new Cuckoo(23, "mdw_pippit", 22.25);
                yield return new Cuckoo(24, "mdw_pippit", 22.25);
                yield return new Cuckoo(25, "mdw_pippit", 22.25);
                yield return new Cuckoo(26, "mdw_pippit", 22.25);
                yield return new Cuckoo(27, "mdw_pippit", 22.25);
                yield return new Cuckoo(28, "mdw_pippit", 22.25);
                yield return new Cuckoo(29, "mdw_pippit", 22.45);
                yield return new Cuckoo(30, "mdw_pippit", 22.45);
                yield return new Cuckoo(31, "mdw_pippit", 22.45);
                yield return new Cuckoo(32, "mdw_pippit", 22.65);
                yield return new Cuckoo(33, "mdw_pippit", 22.65);
                yield return new Cuckoo(34, "mdw_pippit", 22.85);
                yield return new Cuckoo(35, "mdw_pippit", 22.85);
                yield return new Cuckoo(36, "mdw_pippit", 22.85);
                yield return new Cuckoo(37, "mdw_pippit", 22.85);
                yield return new Cuckoo(38, "mdw_pippit", 23.05);
                yield return new Cuckoo(39, "mdw_pippit", 23.25);
                yield return new Cuckoo(40, "mdw_pippit", 23.25);
                yield return new Cuckoo(41, "mdw_pippit", 23.45);
                yield return new Cuckoo(42, "mdw_pippit", 23.65);
                yield return new Cuckoo(43, "mdw_pippit", 23.85);
                yield return new Cuckoo(44, "mdw_pippit", 24.25);
                yield return new Cuckoo(45, "mdw_pippit", 24.45);
                yield return new Cuckoo(46, "tree_pippit", 21.05);
                yield return new Cuckoo(47, "tree_pippit", 21.85);
                yield return new Cuckoo(48, "tree_pippit", 22.05);
                yield return new Cuckoo(49, "tree_pippit", 22.45);
                yield return new Cuckoo(50, "tree_pippit", 22.65);
                yield return new Cuckoo(51, "tree_pippit", 23.25);
                yield return new Cuckoo(52, "tree_pippit", 23.25);
                yield return new Cuckoo(53, "tree_pippit", 23.25);
                yield return new Cuckoo(54, "tree_pippit", 23.45);
                yield return new Cuckoo(55, "tree_pippit", 23.45);
                yield return new Cuckoo(56, "tree_pippit", 23.65);
                yield return new Cuckoo(57, "tree_pippit", 23.85);
                yield return new Cuckoo(58, "tree_pippit", 24.05);
                yield return new Cuckoo(59, "tree_pippit", 24.05);
                yield return new Cuckoo(60, "tree_pippit", 24.05);
                yield return new Cuckoo(61, "hedge_sparrow", 20.85);
                yield return new Cuckoo(62, "hedge_sparrow", 21.65);
                yield return new Cuckoo(63, "hedge_sparrow", 22.05);
                yield return new Cuckoo(64, "hedge_sparrow", 22.85);
                yield return new Cuckoo(65, "hedge_sparrow", 23.05);
                yield return new Cuckoo(66, "hedge_sparrow", 23.05);
                yield return new Cuckoo(67, "hedge_sparrow", 23.05);
                yield return new Cuckoo(68, "hedge_sparrow", 23.05);
                yield return new Cuckoo(69, "hedge_sparrow", 23.45);
                yield return new Cuckoo(70, "hedge_sparrow", 23.85);
                yield return new Cuckoo(71, "hedge_sparrow", 23.85);
                yield return new Cuckoo(72, "hedge_sparrow", 23.85);
                yield return new Cuckoo(73, "hedge_sparrow", 24.05);
                yield return new Cuckoo(74, "hedge_sparrow", 25.05);
                yield return new Cuckoo(75, "robin", 21.05);
                yield return new Cuckoo(76, "robin", 21.85);
                yield return new Cuckoo(77, "robin", 22.05);
                yield return new Cuckoo(78, "robin", 22.05);
                yield return new Cuckoo(79, "robin", 22.05);
                yield return new Cuckoo(80, "robin", 22.25);
                yield return new Cuckoo(81, "robin", 22.45);
                yield return new Cuckoo(82, "robin", 22.45);
                yield return new Cuckoo(83, "robin", 22.65);
                yield return new Cuckoo(84, "robin", 23.05);
                yield return new Cuckoo(85, "robin", 23.05);
                yield return new Cuckoo(86, "robin", 23.05);
                yield return new Cuckoo(87, "robin", 23.05);
                yield return new Cuckoo(88, "robin", 23.05);
                yield return new Cuckoo(89, "robin", 23.25);
                yield return new Cuckoo(90, "robin", 23.85);
                yield return new Cuckoo(91, "wagtail", 21.05);
                yield return new Cuckoo(92, "wagtail", 21.85);
                yield return new Cuckoo(93, "wagtail", 21.85);
                yield return new Cuckoo(94, "wagtail", 21.85);
                yield return new Cuckoo(95, "wagtail", 22.05);
                yield return new Cuckoo(96, "wagtail", 22.45);
                yield return new Cuckoo(97, "wagtail", 22.65);
                yield return new Cuckoo(98, "wagtail", 23.05);
                yield return new Cuckoo(99, "wagtail", 23.05);
                yield return new Cuckoo(100, "wagtail", 23.25);
                yield return new Cuckoo(101, "wagtail", 23.45);
                yield return new Cuckoo(102, "wagtail", 24.05);
                yield return new Cuckoo(103, "wagtail", 24.05);
                yield return new Cuckoo(104, "wagtail", 24.05);
                yield return new Cuckoo(105, "wagtail", 24.85);
                yield return new Cuckoo(106, "wren", 19.85);
                yield return new Cuckoo(107, "wren", 20.05);
                yield return new Cuckoo(108, "wren", 20.25);
                yield return new Cuckoo(109, "wren", 20.85);
                yield return new Cuckoo(110, "wren", 20.85);
                yield return new Cuckoo(111, "wren", 20.85);
                yield return new Cuckoo(112, "wren", 21.05);
                yield return new Cuckoo(113, "wren", 21.05);
                yield return new Cuckoo(114, "wren", 21.05);
                yield return new Cuckoo(115, "wren", 21.25);
                yield return new Cuckoo(116, "wren", 21.45);
                yield return new Cuckoo(117, "wren", 22.05);
                yield return new Cuckoo(118, "wren", 22.05);
                yield return new Cuckoo(119, "wren", 22.05);
                yield return new Cuckoo(120, "wren", 22.25);
            }
        }
    }
}
