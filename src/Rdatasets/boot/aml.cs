// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Remission Times for Acute Myelogenous Leukaemia
    /// </summary>

    public class aml
    {
        public readonly int time;
        public readonly int cens;
        public readonly int group;

        public aml(int time, int cens, int group)
        {
            this.time = time;
            this.cens = cens;
            this.group = group;
        }

        public static IEnumerable<aml> Data
        {
            get
            {
                yield return new aml(9, 1, 1);
                yield return new aml(13, 1, 1);
                yield return new aml(13, 0, 1);
                yield return new aml(18, 1, 1);
                yield return new aml(23, 1, 1);
                yield return new aml(28, 0, 1);
                yield return new aml(31, 1, 1);
                yield return new aml(34, 1, 1);
                yield return new aml(45, 0, 1);
                yield return new aml(48, 1, 1);
                yield return new aml(161, 0, 1);
                yield return new aml(5, 1, 2);
                yield return new aml(5, 1, 2);
                yield return new aml(8, 1, 2);
                yield return new aml(8, 1, 2);
                yield return new aml(12, 1, 2);
                yield return new aml(16, 0, 2);
                yield return new aml(23, 1, 2);
                yield return new aml(27, 1, 2);
                yield return new aml(30, 1, 2);
                yield return new aml(33, 1, 2);
                yield return new aml(43, 1, 2);
                yield return new aml(45, 1, 2);
            }
        }
    }
}
