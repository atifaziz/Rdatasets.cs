// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Family Medical Expenses
    /// </summary>

    public class medExpenses
    {
        public readonly int familysize;
        public readonly double expenses;

        public medExpenses(int familysize, double expenses)
        {
            this.familysize = familysize;
            this.expenses = expenses;
        }

        public static IEnumerable<medExpenses> Data
        {
            get
            {
                yield return new medExpenses(2, 7.15);
                yield return new medExpenses(3, 6.93);
                yield return new medExpenses(3, 7.57);
                yield return new medExpenses(5, 6.1);
                yield return new medExpenses(4, 10.3);
                yield return new medExpenses(7, 4.03);
                yield return new medExpenses(2, 12.1);
                yield return new medExpenses(4, 7.5);
                yield return new medExpenses(2, 12.1);
                yield return new medExpenses(5, 8.88);
                yield return new medExpenses(3, 4.47);
                yield return new medExpenses(6, 3.3);
                yield return new medExpenses(4, 7.35);
                yield return new medExpenses(4, 6.78);
                yield return new medExpenses(2, 11.1);
                yield return new medExpenses(5, 7.54);
                yield return new medExpenses(3, 7.53);
                yield return new medExpenses(4, 9);
                yield return new medExpenses(2, 10.3);
                yield return new medExpenses(4, 6.92);
                yield return new medExpenses(2, 12.95);
                yield return new medExpenses(5, 4.66);
                yield return new medExpenses(3, 13.27);
                yield return new medExpenses(4, 4.2);
                yield return new medExpenses(7, 5.4);
                yield return new medExpenses(3, 8.27);
                yield return new medExpenses(3, 9.57);
                yield return new medExpenses(6, 10.5);
                yield return new medExpenses(2, 9.75);
                yield return new medExpenses(2, 10.8);
                yield return new medExpenses(6, 3.03);
                yield return new medExpenses(4, 5.03);
                yield return new medExpenses(2, 10.35);
            }
        }
    }
}
