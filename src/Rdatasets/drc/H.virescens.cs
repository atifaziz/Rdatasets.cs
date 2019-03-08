// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Mortality of tobacco budworms
    /// </summary>

    public class H_virescens
    {
        public readonly int dose;
        public readonly int numdead;
        public readonly int total;
        public readonly string sex;

        public H_virescens(int dose, int numdead, int total, string sex)
        {
            this.dose = dose;
            this.numdead = numdead;
            this.total = total;
            this.sex = sex;
        }

        public static IEnumerable<H_virescens> Data
        {
            get
            {
                yield return new H_virescens(1, 1, 20, "M");
                yield return new H_virescens(2, 4, 20, "M");
                yield return new H_virescens(4, 9, 20, "M");
                yield return new H_virescens(8, 13, 20, "M");
                yield return new H_virescens(16, 18, 20, "M");
                yield return new H_virescens(32, 20, 20, "M");
                yield return new H_virescens(1, 0, 20, "F");
                yield return new H_virescens(2, 2, 20, "F");
                yield return new H_virescens(4, 6, 20, "F");
                yield return new H_virescens(8, 10, 20, "F");
                yield return new H_virescens(16, 12, 20, "F");
                yield return new H_virescens(32, 16, 20, "F");
            }
        }
    }
}
