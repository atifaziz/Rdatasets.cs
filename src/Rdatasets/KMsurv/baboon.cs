// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 5.8, p147
    /// </summary>

    public class baboon
    {
        public readonly string date;
        public readonly int time;
        public readonly int observed;

        public baboon(string date, int time, int observed)
        {
            this.date = date;
            this.time = time;
            this.observed = observed;
        }

        public static IEnumerable<baboon> Data
        {
            get
            {
                yield return new baboon("25/11/63", 656, 1);
                yield return new baboon("29/10/63", 659, 1);
                yield return new baboon("5/11/63", 720, 1);
                yield return new baboon("12/2/64", 721, 1);
                yield return new baboon("29/3/64", 743, 1);
                yield return new baboon("14/2/64", 747, 1);
                yield return new baboon("18/2/64", 750, 1);
                yield return new baboon("1/4/64", 751, 1);
                yield return new baboon("8/2/64", 754, 1);
                yield return new baboon("26/5/64", 758, 1);
                yield return new baboon("19/2/64", 805, 1);
                yield return new baboon("7/6/64", 808, 1);
                yield return new baboon("22/6/64", 810, 1);
                yield return new baboon("24/5/64", 811, 1);
                yield return new baboon("21/2/64", 815, 1);
                yield return new baboon("13/2/64", 815, 1);
                yield return new baboon("11/6/64", 820, 1);
                yield return new baboon("21/6/64", 820, 1);
                yield return new baboon("13/3/64", 825, 1);
                yield return new baboon("12/7/64", 827, 1);
                yield return new baboon("30/6/64", 828, 1);
                yield return new baboon("5/5/64", 831, 1);
                yield return new baboon("12/5/64", 832, 1);
                yield return new baboon("25/4/64", 832, 1);
                yield return new baboon("26/3/64", 833, 1);
                yield return new baboon("18/3/64", 836, 1);
                yield return new baboon("15/3/64", 840, 1);
                yield return new baboon("6/3/64", 842, 1);
                yield return new baboon("11/5/64", 844, 1);
                yield return new baboon("5/6/64", 844, 1);
                yield return new baboon("17/7/64", 845, 1);
                yield return new baboon("12/6/64", 846, 1);
                yield return new baboon("28/2/64", 848, 1);
                yield return new baboon("14/5/64", 850, 1);
                yield return new baboon("7/7/64", 855, 1);
                yield return new baboon("6/7/64", 858, 1);
                yield return new baboon("2/7/64", 858, 1);
                yield return new baboon("17/3/64", 859, 1);
                yield return new baboon("10/6/64", 859, 1);
                yield return new baboon("11/3/64", 900, 1);
                yield return new baboon("23/7/64", 904, 1);
                yield return new baboon("27/2/64", 905, 1);
                yield return new baboon("31/3/64", 905, 1);
                yield return new baboon("10/4/64", 907, 1);
                yield return new baboon("22/4/64", 908, 1);
                yield return new baboon("7/3/64", 910, 1);
                yield return new baboon("29/2/64", 910, 1);
                yield return new baboon("13/5/64", 915, 1);
                yield return new baboon("20/4/64", 920, 1);
                yield return new baboon("27/4/64", 930, 1);
                yield return new baboon("28/4/64", 930, 1);
                yield return new baboon("23/4/64", 932, 1);
                yield return new baboon("4/3/64", 935, 1);
                yield return new baboon("6/5/64", 935, 1);
                yield return new baboon("26/6/64", 945, 1);
                yield return new baboon("25/3/64", 948, 1);
                yield return new baboon("8/7/64", 952, 1);
                yield return new baboon("21/4/64", 1027, 1);
                yield return new baboon("1/12/63", 705, 0);
                yield return new baboon("6/11/63", 710, 0);
                yield return new baboon("24/10/63", 715, 0);
                yield return new baboon("26/11/63", 720, 0);
                yield return new baboon("18/10/63", 720, 0);
                yield return new baboon("7/5/64", 730, 0);
                yield return new baboon("7/11/63", 740, 0);
                yield return new baboon("23/11/63", 750, 0);
                yield return new baboon("28/11/63", 750, 0);
                yield return new baboon("27/11/63", 753, 0);
                yield return new baboon("28/5/64", 755, 0);
                yield return new baboon("5/7/64", 757, 0);
                yield return new baboon("28/3/64", 800, 0);
                yield return new baboon("23/3/64", 805, 0);
                yield return new baboon("26/10/63", 805, 0);
                yield return new baboon("11/7/64", 805, 0);
                yield return new baboon("27/7/64", 807, 0);
                yield return new baboon("9/6/64", 810, 0);
                yield return new baboon("24/6/64", 812, 0);
                yield return new baboon("16/10/63", 812, 0);
                yield return new baboon("25/2/64", 813, 0);
                yield return new baboon("6/6/64", 814, 0);
                yield return new baboon("22/11/63", 815, 0);
                yield return new baboon("10/10/63", 815, 0);
                yield return new baboon("2/11/63", 815, 0);
                yield return new baboon("23/6/64", 817, 0);
                yield return new baboon("24/4/64", 823, 0);
                yield return new baboon("3/7/64", 830, 0);
                yield return new baboon("29/4/64", 831, 0);
                yield return new baboon("4/8/63", 838, 0);
                yield return new baboon("7/10/63", 840, 0);
                yield return new baboon("13/10/63", 840, 0);
                yield return new baboon("4/7/64", 845, 0);
                yield return new baboon("3/5/64", 850, 0);
                yield return new baboon("25/5/64", 851, 0);
                yield return new baboon("24/11/63", 853, 0);
                yield return new baboon("15/7/64", 855, 0);
                yield return new baboon("16/2/64", 856, 0);
                yield return new baboon("10/3/64", 857, 0);
                yield return new baboon("28/7/64", 858, 0);
                yield return new baboon("18/6/64", 858, 0);
                yield return new baboon("20/2/64", 858, 0);
                yield return new baboon("2/8/64", 859, 0);
                yield return new baboon("27/5/64", 900, 0);
                yield return new baboon("28/10/64", 905, 0);
                yield return new baboon("15/5/64", 907, 0);
                yield return new baboon("10/5/64", 908, 0);
                yield return new baboon("27/6/64", 915, 0);
                yield return new baboon("11/10/63", 915, 0);
                yield return new baboon("17/2/64", 920, 0);
                yield return new baboon("22/10/63", 920, 0);
                yield return new baboon("10/7/64", 925, 0);
                yield return new baboon("14/7/64", 926, 0);
                yield return new baboon("11/4/64", 931, 0);
                yield return new baboon("23/5/64", 933, 0);
                yield return new baboon("30/7/64", 943, 0);
                yield return new baboon("18/7/64", 945, 0);
                yield return new baboon("29/7/64", 946, 0);
                yield return new baboon("16/7/64", 950, 0);
                yield return new baboon("22/7/64", 955, 0);
                yield return new baboon("15/10/63", 955, 0);
                yield return new baboon("19/10/63", 1005, 0);
                yield return new baboon("2/5/64", 1012, 0);
                yield return new baboon("1/3/64", 1018, 0);
                yield return new baboon("17/10/63", 1020, 0);
                yield return new baboon("23/10/63", 1020, 0);
                yield return new baboon("25/7/64", 1020, 0);
                yield return new baboon("13/7/64", 1031, 0);
                yield return new baboon("8/6/64", 1050, 0);
                yield return new baboon("9/3/64", 1050, 0);
                yield return new baboon("26/4/64", 1100, 0);
                yield return new baboon("14/10/63", 1205, 0);
                yield return new baboon("18/11/63", 1245, 0);
                yield return new baboon("2/3/64", 1250, 0);
                yield return new baboon("8/5/64", 1405, 0);
                yield return new baboon("1/7/64", 1407, 0);
                yield return new baboon("12/10/63", 1500, 0);
                yield return new baboon("31/7/64", 1531, 0);
                yield return new baboon("6/10/63", 1535, 0);
                yield return new baboon("19/6/64", 1556, 0);
                yield return new baboon("29/6/64", 1603, 0);
                yield return new baboon("9/5/64", 1605, 0);
                yield return new baboon("9/10/63", 1625, 0);
                yield return new baboon("8/3/64", 1625, 0);
                yield return new baboon("11/2/64", 1653, 0);
                yield return new baboon("30/5/64", 1705, 0);
                yield return new baboon("5/3/64", 1708, 0);
                yield return new baboon("26/2/64", 1722, 0);
                yield return new baboon("4/5/64", 1728, 0);
                yield return new baboon("12/3/64", 1730, 0);
                yield return new baboon("25/10/63", 1730, 0);
                yield return new baboon("29/11/63", 1750, 0);
                yield return new baboon("22/2/64", 1801, 0);
                yield return new baboon("22/3/64", 1829, 0);
            }
        }
    }
}
