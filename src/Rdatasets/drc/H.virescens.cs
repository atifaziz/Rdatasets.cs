// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Mortality of tobacco budworms
    /// </summary>

    public class H_virescens
    {
        public readonly int κ;
        public readonly int dose;
        public readonly int numdead;
        public readonly int total;
        public readonly string sex;

        public H_virescens(int κ, int dose, int numdead, int total, string sex)
        {
            this.κ = κ;
            this.dose = dose;
            this.numdead = numdead;
            this.total = total;
            this.sex = sex;
        }

        public static IEnumerable<H_virescens> Data
        {
            get
            {
                yield return new H_virescens(1, 1, 1, 20, "M");
                yield return new H_virescens(2, 2, 4, 20, "M");
                yield return new H_virescens(3, 4, 9, 20, "M");
                yield return new H_virescens(4, 8, 13, 20, "M");
                yield return new H_virescens(5, 16, 18, 20, "M");
                yield return new H_virescens(6, 32, 20, 20, "M");
                yield return new H_virescens(7, 1, 0, 20, "F");
                yield return new H_virescens(8, 2, 2, 20, "F");
                yield return new H_virescens(9, 4, 6, 20, "F");
                yield return new H_virescens(10, 8, 10, 20, "F");
                yield return new H_virescens(11, 16, 12, 20, "F");
                yield return new H_virescens(12, 32, 16, 20, "F");
            }
        }
    }
}
