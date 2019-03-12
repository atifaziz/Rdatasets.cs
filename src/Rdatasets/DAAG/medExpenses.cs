// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Family Medical Expenses
    /// </summary>

    public class medExpenses
    {
        public readonly int κ;
        public readonly int familysize;
        public readonly double expenses;

        public medExpenses(int κ, int familysize, double expenses)
        {
            this.κ = κ;
            this.familysize = familysize;
            this.expenses = expenses;
        }

        public static IEnumerable<medExpenses> Data
        {
            get
            {
                yield return new medExpenses(1, 2, 7.15);
                yield return new medExpenses(2, 3, 6.93);
                yield return new medExpenses(3, 3, 7.57);
                yield return new medExpenses(4, 5, 6.1);
                yield return new medExpenses(5, 4, 10.3);
                yield return new medExpenses(6, 7, 4.03);
                yield return new medExpenses(7, 2, 12.1);
                yield return new medExpenses(8, 4, 7.5);
                yield return new medExpenses(9, 2, 12.1);
                yield return new medExpenses(10, 5, 8.88);
                yield return new medExpenses(11, 3, 4.47);
                yield return new medExpenses(12, 6, 3.3);
                yield return new medExpenses(13, 4, 7.35);
                yield return new medExpenses(14, 4, 6.78);
                yield return new medExpenses(15, 2, 11.1);
                yield return new medExpenses(16, 5, 7.54);
                yield return new medExpenses(17, 3, 7.53);
                yield return new medExpenses(18, 4, 9);
                yield return new medExpenses(19, 2, 10.3);
                yield return new medExpenses(20, 4, 6.92);
                yield return new medExpenses(21, 2, 12.95);
                yield return new medExpenses(22, 5, 4.66);
                yield return new medExpenses(23, 3, 13.27);
                yield return new medExpenses(24, 4, 4.2);
                yield return new medExpenses(25, 7, 5.4);
                yield return new medExpenses(26, 3, 8.27);
                yield return new medExpenses(27, 3, 9.57);
                yield return new medExpenses(28, 6, 10.5);
                yield return new medExpenses(29, 2, 9.75);
                yield return new medExpenses(30, 2, 10.8);
                yield return new medExpenses(31, 6, 3.03);
                yield return new medExpenses(32, 4, 5.03);
                yield return new medExpenses(33, 2, 10.35);
            }
        }
    }
}
