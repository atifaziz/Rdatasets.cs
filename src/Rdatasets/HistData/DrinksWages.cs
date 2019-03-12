// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Elderton and Pearson's (1910) data on drinking and wages
    /// </summary>

    public class DrinksWages
    {
        public readonly int κ;
        public readonly string @class;
        public readonly string trade;
        public readonly int sober;
        public readonly int drinks;
        public readonly double wage;
        public readonly int n;

        public DrinksWages(int κ, string @class, string trade, int sober, int drinks, double wage, int n)
        {
            this.κ = κ;
            this.@class = @class;
            this.trade = trade;
            this.sober = sober;
            this.drinks = drinks;
            this.wage = wage;
            this.n = n;
        }

        public static IEnumerable<DrinksWages> Data
        {
            get
            {
                yield return new DrinksWages(1, "A", "papercutter", 1, 1, 24, 2);
                yield return new DrinksWages(2, "A", "cabmen", 1, 10, 18.416666667, 11);
                yield return new DrinksWages(3, "A", "goldbeater", 2, 1, 21.5, 3);
                yield return new DrinksWages(4, "A", "stablemen", 1, 5, 21.166666667, 6);
                yield return new DrinksWages(5, "A", "millworker", 2, 0, 19, 2);
                yield return new DrinksWages(6, "A", "porter", 9, 8, 20.5, 17);
                yield return new DrinksWages(7, "A", "warehouse", 8, 2, 24.333333333, 10);
                yield return new DrinksWages(8, "A", "maltmen", 3, 5, 23, 8);
                yield return new DrinksWages(9, "A", "chimneysweep", 0, 7, 17.333333333, 7);
                yield return new DrinksWages(10, "A", "carter", 12, 23, 22.166666667, 35);
                yield return new DrinksWages(11, "A", "barman", 1, 0, 23.666666667, 1);
                yield return new DrinksWages(12, "A", "brassfounder", 2, 4, 21.5, 6);
                yield return new DrinksWages(13, "A", "shoemaker", 11, 9, 22.833333333, 20);
                yield return new DrinksWages(14, "A", "scavenger", 2, 2, 22.833333333, 4);
                yield return new DrinksWages(15, "A", "stonecutter", 1, 1, 23, 2);
                yield return new DrinksWages(16, "A", "cellarman", 1, 2, 24.166666667, 3);
                yield return new DrinksWages(17, "A", "french polisher", 1, 0, 13.5, 1);
                yield return new DrinksWages(18, "A", "wagon examiner", 1, 0, 20, 1);
                yield return new DrinksWages(19, "A", "surfaceman", 4, 0, 18.5, 4);
                yield return new DrinksWages(20, "A", "gardener", 2, 0, 20.5, 2);
                yield return new DrinksWages(21, "A", "platelayer", 0, 2, 18, 2);
                yield return new DrinksWages(22, "A", "hammerman", 2, 1, 20, 3);
                yield return new DrinksWages(23, "A", "factory worker", 1, 3, 12, 4);
                yield return new DrinksWages(24, "A", "billposter", 1, 0, 18, 1);
                yield return new DrinksWages(25, "A", "general labourer", 71, 85, 18.5, 156);
                yield return new DrinksWages(26, "B", "sadler", 0, 3, 25, 3);
                yield return new DrinksWages(27, "B", "turnroom", 1, 0, 25, 1);
                yield return new DrinksWages(28, "B", "shop hand", 4, 3, 25, 7);
                yield return new DrinksWages(29, "B", "typecaster", 4, 5, 26, 9);
                yield return new DrinksWages(30, "B", "clerk", 2, 1, 27, 3);
                yield return new DrinksWages(31, "B", "ironmoulder", 3, 5, 28.416666667, 8);
                yield return new DrinksWages(32, "B", "coachbuilder", 3, 1, 28, 4);
                yield return new DrinksWages(33, "B", "wellsinker", 1, 0, 30, 1);
                yield return new DrinksWages(34, "B", "tailors", 4, 15, 27, 19);
                yield return new DrinksWages(35, "B", "coopers", 8, 4, 28.5, 12);
                yield return new DrinksWages(36, "B", "linesman", 0, 2, 26, 2);
                yield return new DrinksWages(37, "B", "timekeeper", 1, 0, 30, 1);
                yield return new DrinksWages(38, "B", "jeweller", 2, 0, 28, 2);
                yield return new DrinksWages(39, "B", "butcher", 2, 1, 30, 3);
                yield return new DrinksWages(40, "B", "painter", 14, 23, 25.5, 37);
                yield return new DrinksWages(41, "B", "pipelayer", 0, 1, 27.666666667, 1);
                yield return new DrinksWages(42, "B", "sailor", 3, 1, 30, 4);
                yield return new DrinksWages(43, "B", "baker", 11, 10, 26.166666667, 21);
                yield return new DrinksWages(44, "B", "bottler", 1, 0, 27.25, 1);
                yield return new DrinksWages(45, "B", "railway porter", 7, 2, 28, 9);
                yield return new DrinksWages(46, "B", "gasworker", 5, 0, 27, 5);
                yield return new DrinksWages(47, "B", "tramdriver", 0, 1, 27, 1);
                yield return new DrinksWages(48, "C", "letterpresser", 1, 0, 34, 1);
                yield return new DrinksWages(49, "C", "lithographer", 2, 2, 36.5, 4);
                yield return new DrinksWages(50, "C", "bookbinder", 3, 6, 30.25, 9);
                yield return new DrinksWages(51, "C", "upholsterer", 1, 2, 36, 3);
                yield return new DrinksWages(52, "C", "ironfounder", 5, 4, 32.583333333, 9);
                yield return new DrinksWages(53, "C", "wireworker", 0, 1, 32.5, 1);
                yield return new DrinksWages(54, "C", "plasterer", 1, 0, 37, 1);
                yield return new DrinksWages(55, "C", "cabinetmaker", 2, 1, 33.5, 3);
                yield return new DrinksWages(56, "C", "joiner", 3, 9, 30.833333333, 12);
                yield return new DrinksWages(57, "C", "stream crane", 1, 1, 30.833333333, 2);
                yield return new DrinksWages(58, "C", "mason", 5, 17, 34.083333333, 22);
                yield return new DrinksWages(59, "C", "blacksmith", 1, 5, 38.833333333, 6);
                yield return new DrinksWages(60, "C", "engineer", 6, 2, 30.166666667, 8);
                yield return new DrinksWages(61, "C", "printer", 13, 16, 31.083333333, 29);
                yield return new DrinksWages(62, "C", "stoker", 2, 1, 31.583333333, 3);
                yield return new DrinksWages(63, "C", "plumber", 3, 5, 34.5, 8);
                yield return new DrinksWages(64, "C", "rivetter", 1, 0, 40, 1);
                yield return new DrinksWages(65, "C", "tinsmith", 2, 4, 31.583333333, 6);
                yield return new DrinksWages(66, "C", "slater", 3, 2, 36.083333333, 5);
                yield return new DrinksWages(67, "C", "chemist", 1, 0, 36.5, 1);
                yield return new DrinksWages(68, "C", "picture framer", 0, 2, 31.083333333, 2);
                yield return new DrinksWages(69, "C", "postman", 0, 2, 32, 2);
                yield return new DrinksWages(70, "C", "glassmaker", 1, 0, 40, 1);
            }
        }
    }
}
