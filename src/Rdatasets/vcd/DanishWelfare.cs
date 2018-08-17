// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Danish Welfare Study Data
    /// </summary>

    public class DanishWelfare
    {
        public readonly int Freq;
        public readonly string Alcohol;
        public readonly string Income;
        public readonly string Status;
        public readonly string Urban;

        public DanishWelfare(int Freq, string Alcohol, string Income, string Status, string Urban)
        {
            this.Freq = Freq;
            this.Alcohol = Alcohol;
            this.Income = Income;
            this.Status = Status;
            this.Urban = Urban;
        }

        public static IEnumerable<DanishWelfare> Data
        {
            get
            {
                yield return new DanishWelfare(1, "<1", "0-50", "Widow", "Copenhagen");
                yield return new DanishWelfare(4, "<1", "0-50", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(1, "<1", "0-50", "Widow", "LargeCity");
                yield return new DanishWelfare(8, "<1", "0-50", "Widow", "City");
                yield return new DanishWelfare(6, "<1", "0-50", "Widow", "Country");
                yield return new DanishWelfare(14, "<1", "0-50", "Married", "Copenhagen");
                yield return new DanishWelfare(8, "<1", "0-50", "Married", "SubCopenhagen");
                yield return new DanishWelfare(41, "<1", "0-50", "Married", "LargeCity");
                yield return new DanishWelfare(100, "<1", "0-50", "Married", "City");
                yield return new DanishWelfare(175, "<1", "0-50", "Married", "Country");
                yield return new DanishWelfare(6, "<1", "0-50", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(1, "<1", "0-50", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(2, "<1", "0-50", "Unmarried", "LargeCity");
                yield return new DanishWelfare(6, "<1", "0-50", "Unmarried", "City");
                yield return new DanishWelfare(9, "<1", "0-50", "Unmarried", "Country");
                yield return new DanishWelfare(8, "<1", "50-100", "Widow", "Copenhagen");
                yield return new DanishWelfare(2, "<1", "50-100", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(7, "<1", "50-100", "Widow", "LargeCity");
                yield return new DanishWelfare(14, "<1", "50-100", "Widow", "City");
                yield return new DanishWelfare(5, "<1", "50-100", "Widow", "Country");
                yield return new DanishWelfare(42, "<1", "50-100", "Married", "Copenhagen");
                yield return new DanishWelfare(51, "<1", "50-100", "Married", "SubCopenhagen");
                yield return new DanishWelfare(62, "<1", "50-100", "Married", "LargeCity");
                yield return new DanishWelfare(234, "<1", "50-100", "Married", "City");
                yield return new DanishWelfare(255, "<1", "50-100", "Married", "Country");
                yield return new DanishWelfare(7, "<1", "50-100", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(5, "<1", "50-100", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(9, "<1", "50-100", "Unmarried", "LargeCity");
                yield return new DanishWelfare(20, "<1", "50-100", "Unmarried", "City");
                yield return new DanishWelfare(27, "<1", "50-100", "Unmarried", "Country");
                yield return new DanishWelfare(2, "<1", "100-150", "Widow", "Copenhagen");
                yield return new DanishWelfare(3, "<1", "100-150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(1, "<1", "100-150", "Widow", "LargeCity");
                yield return new DanishWelfare(5, "<1", "100-150", "Widow", "City");
                yield return new DanishWelfare(2, "<1", "100-150", "Widow", "Country");
                yield return new DanishWelfare(21, "<1", "100-150", "Married", "Copenhagen");
                yield return new DanishWelfare(30, "<1", "100-150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(23, "<1", "100-150", "Married", "LargeCity");
                yield return new DanishWelfare(87, "<1", "100-150", "Married", "City");
                yield return new DanishWelfare(77, "<1", "100-150", "Married", "Country");
                yield return new DanishWelfare(3, "<1", "100-150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(2, "<1", "100-150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(1, "<1", "100-150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(12, "<1", "100-150", "Unmarried", "City");
                yield return new DanishWelfare(4, "<1", "100-150", "Unmarried", "Country");
                yield return new DanishWelfare(42, "<1", ">150", "Widow", "Copenhagen");
                yield return new DanishWelfare(29, "<1", ">150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(17, "<1", ">150", "Widow", "LargeCity");
                yield return new DanishWelfare(95, "<1", ">150", "Widow", "City");
                yield return new DanishWelfare(46, "<1", ">150", "Widow", "Country");
                yield return new DanishWelfare(24, "<1", ">150", "Married", "Copenhagen");
                yield return new DanishWelfare(30, "<1", ">150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(50, "<1", ">150", "Married", "LargeCity");
                yield return new DanishWelfare(167, "<1", ">150", "Married", "City");
                yield return new DanishWelfare(232, "<1", ">150", "Married", "Country");
                yield return new DanishWelfare(33, "<1", ">150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(24, "<1", ">150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(15, "<1", ">150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(64, "<1", ">150", "Unmarried", "City");
                yield return new DanishWelfare(68, "<1", ">150", "Unmarried", "Country");
                yield return new DanishWelfare(3, "1-2", "0-50", "Widow", "Copenhagen");
                yield return new DanishWelfare(0, "1-2", "0-50", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(1, "1-2", "0-50", "Widow", "LargeCity");
                yield return new DanishWelfare(4, "1-2", "0-50", "Widow", "City");
                yield return new DanishWelfare(2, "1-2", "0-50", "Widow", "Country");
                yield return new DanishWelfare(15, "1-2", "0-50", "Married", "Copenhagen");
                yield return new DanishWelfare(7, "1-2", "0-50", "Married", "SubCopenhagen");
                yield return new DanishWelfare(15, "1-2", "0-50", "Married", "LargeCity");
                yield return new DanishWelfare(25, "1-2", "0-50", "Married", "City");
                yield return new DanishWelfare(48, "1-2", "0-50", "Married", "Country");
                yield return new DanishWelfare(2, "1-2", "0-50", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(3, "1-2", "0-50", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(9, "1-2", "0-50", "Unmarried", "LargeCity");
                yield return new DanishWelfare(9, "1-2", "0-50", "Unmarried", "City");
                yield return new DanishWelfare(7, "1-2", "0-50", "Unmarried", "Country");
                yield return new DanishWelfare(1, "1-2", "50-100", "Widow", "Copenhagen");
                yield return new DanishWelfare(1, "1-2", "50-100", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(3, "1-2", "50-100", "Widow", "LargeCity");
                yield return new DanishWelfare(8, "1-2", "50-100", "Widow", "City");
                yield return new DanishWelfare(4, "1-2", "50-100", "Widow", "Country");
                yield return new DanishWelfare(39, "1-2", "50-100", "Married", "Copenhagen");
                yield return new DanishWelfare(59, "1-2", "50-100", "Married", "SubCopenhagen");
                yield return new DanishWelfare(68, "1-2", "50-100", "Married", "LargeCity");
                yield return new DanishWelfare(172, "1-2", "50-100", "Married", "City");
                yield return new DanishWelfare(143, "1-2", "50-100", "Married", "Country");
                yield return new DanishWelfare(12, "1-2", "50-100", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(3, "1-2", "50-100", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(11, "1-2", "50-100", "Unmarried", "LargeCity");
                yield return new DanishWelfare(20, "1-2", "50-100", "Unmarried", "City");
                yield return new DanishWelfare(23, "1-2", "50-100", "Unmarried", "Country");
                yield return new DanishWelfare(5, "1-2", "100-150", "Widow", "Copenhagen");
                yield return new DanishWelfare(4, "1-2", "100-150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(1, "1-2", "100-150", "Widow", "LargeCity");
                yield return new DanishWelfare(9, "1-2", "100-150", "Widow", "City");
                yield return new DanishWelfare(4, "1-2", "100-150", "Widow", "Country");
                yield return new DanishWelfare(32, "1-2", "100-150", "Married", "Copenhagen");
                yield return new DanishWelfare(68, "1-2", "100-150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(43, "1-2", "100-150", "Married", "LargeCity");
                yield return new DanishWelfare(128, "1-2", "100-150", "Married", "City");
                yield return new DanishWelfare(86, "1-2", "100-150", "Married", "Country");
                yield return new DanishWelfare(6, "1-2", "100-150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(10, "1-2", "100-150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(5, "1-2", "100-150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(21, "1-2", "100-150", "Unmarried", "City");
                yield return new DanishWelfare(15, "1-2", "100-150", "Unmarried", "Country");
                yield return new DanishWelfare(26, "1-2", ">150", "Widow", "Copenhagen");
                yield return new DanishWelfare(34, "1-2", ">150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(14, "1-2", ">150", "Widow", "LargeCity");
                yield return new DanishWelfare(48, "1-2", ">150", "Widow", "City");
                yield return new DanishWelfare(24, "1-2", ">150", "Widow", "Country");
                yield return new DanishWelfare(43, "1-2", ">150", "Married", "Copenhagen");
                yield return new DanishWelfare(76, "1-2", ">150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(70, "1-2", ">150", "Married", "LargeCity");
                yield return new DanishWelfare(198, "1-2", ">150", "Married", "City");
                yield return new DanishWelfare(136, "1-2", ">150", "Married", "Country");
                yield return new DanishWelfare(36, "1-2", ">150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(23, "1-2", ">150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(48, "1-2", ">150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(89, "1-2", ">150", "Unmarried", "City");
                yield return new DanishWelfare(64, "1-2", ">150", "Unmarried", "Country");
                yield return new DanishWelfare(2, ">2", "0-50", "Widow", "Copenhagen");
                yield return new DanishWelfare(0, ">2", "0-50", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(2, ">2", "0-50", "Widow", "LargeCity");
                yield return new DanishWelfare(1, ">2", "0-50", "Widow", "City");
                yield return new DanishWelfare(0, ">2", "0-50", "Widow", "Country");
                yield return new DanishWelfare(1, ">2", "0-50", "Married", "Copenhagen");
                yield return new DanishWelfare(2, ">2", "0-50", "Married", "SubCopenhagen");
                yield return new DanishWelfare(2, ">2", "0-50", "Married", "LargeCity");
                yield return new DanishWelfare(7, ">2", "0-50", "Married", "City");
                yield return new DanishWelfare(7, ">2", "0-50", "Married", "Country");
                yield return new DanishWelfare(3, ">2", "0-50", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(0, ">2", "0-50", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(1, ">2", "0-50", "Unmarried", "LargeCity");
                yield return new DanishWelfare(5, ">2", "0-50", "Unmarried", "City");
                yield return new DanishWelfare(1, ">2", "0-50", "Unmarried", "Country");
                yield return new DanishWelfare(3, ">2", "50-100", "Widow", "Copenhagen");
                yield return new DanishWelfare(0, ">2", "50-100", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(2, ">2", "50-100", "Widow", "LargeCity");
                yield return new DanishWelfare(1, ">2", "50-100", "Widow", "City");
                yield return new DanishWelfare(3, ">2", "50-100", "Widow", "Country");
                yield return new DanishWelfare(14, ">2", "50-100", "Married", "Copenhagen");
                yield return new DanishWelfare(21, ">2", "50-100", "Married", "SubCopenhagen");
                yield return new DanishWelfare(14, ">2", "50-100", "Married", "LargeCity");
                yield return new DanishWelfare(38, ">2", "50-100", "Married", "City");
                yield return new DanishWelfare(35, ">2", "50-100", "Married", "Country");
                yield return new DanishWelfare(2, ">2", "50-100", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(0, ">2", "50-100", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(3, ">2", "50-100", "Unmarried", "LargeCity");
                yield return new DanishWelfare(12, ">2", "50-100", "Unmarried", "City");
                yield return new DanishWelfare(13, ">2", "50-100", "Unmarried", "Country");
                yield return new DanishWelfare(2, ">2", "100-150", "Widow", "Copenhagen");
                yield return new DanishWelfare(1, ">2", "100-150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(1, ">2", "100-150", "Widow", "LargeCity");
                yield return new DanishWelfare(1, ">2", "100-150", "Widow", "City");
                yield return new DanishWelfare(0, ">2", "100-150", "Widow", "Country");
                yield return new DanishWelfare(20, ">2", "100-150", "Married", "Copenhagen");
                yield return new DanishWelfare(31, ">2", "100-150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(10, ">2", "100-150", "Married", "LargeCity");
                yield return new DanishWelfare(36, ">2", "100-150", "Married", "City");
                yield return new DanishWelfare(21, ">2", "100-150", "Married", "Country");
                yield return new DanishWelfare(0, ">2", "100-150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(2, ">2", "100-150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(3, ">2", "100-150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(9, ">2", "100-150", "Unmarried", "City");
                yield return new DanishWelfare(7, ">2", "100-150", "Unmarried", "Country");
                yield return new DanishWelfare(21, ">2", ">150", "Widow", "Copenhagen");
                yield return new DanishWelfare(13, ">2", ">150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(5, ">2", ">150", "Widow", "LargeCity");
                yield return new DanishWelfare(20, ">2", ">150", "Widow", "City");
                yield return new DanishWelfare(8, ">2", ">150", "Widow", "Country");
                yield return new DanishWelfare(23, ">2", ">150", "Married", "Copenhagen");
                yield return new DanishWelfare(47, ">2", ">150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(21, ">2", ">150", "Married", "LargeCity");
                yield return new DanishWelfare(53, ">2", ">150", "Married", "City");
                yield return new DanishWelfare(36, ">2", ">150", "Married", "Country");
                yield return new DanishWelfare(38, ">2", ">150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(20, ">2", ">150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(13, ">2", ">150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(39, ">2", ">150", "Unmarried", "City");
                yield return new DanishWelfare(26, ">2", ">150", "Unmarried", "Country");
            }
        }
    }
}
