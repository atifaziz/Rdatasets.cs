// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Remission Times for Acute Myelogenous Leukaemia
    /// </summary>

    public class aml
    {
        public readonly int κ;
        public readonly int time;
        public readonly int cens;
        public readonly int group;

        public aml(int κ, int time, int cens, int group)
        {
            this.κ = κ;
            this.time = time;
            this.cens = cens;
            this.group = group;
        }

        public static IEnumerable<aml> Data
        {
            get
            {
                yield return new aml(1, 9, 1, 1);
                yield return new aml(2, 13, 1, 1);
                yield return new aml(3, 13, 0, 1);
                yield return new aml(4, 18, 1, 1);
                yield return new aml(5, 23, 1, 1);
                yield return new aml(6, 28, 0, 1);
                yield return new aml(7, 31, 1, 1);
                yield return new aml(8, 34, 1, 1);
                yield return new aml(9, 45, 0, 1);
                yield return new aml(10, 48, 1, 1);
                yield return new aml(11, 161, 0, 1);
                yield return new aml(12, 5, 1, 2);
                yield return new aml(13, 5, 1, 2);
                yield return new aml(14, 8, 1, 2);
                yield return new aml(15, 8, 1, 2);
                yield return new aml(16, 12, 1, 2);
                yield return new aml(17, 16, 0, 2);
                yield return new aml(18, 23, 1, 2);
                yield return new aml(19, 27, 1, 2);
                yield return new aml(20, 30, 1, 2);
                yield return new aml(21, 33, 1, 2);
                yield return new aml(22, 43, 1, 2);
                yield return new aml(23, 45, 1, 2);
            }
        }
    }
}
