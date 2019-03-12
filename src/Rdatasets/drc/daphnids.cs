// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Daphnia test
    /// </summary>

    public class daphnids
    {
        public readonly int κ;
        public readonly double dose;
        public readonly int no;
        public readonly int total;
        public readonly string time;

        public daphnids(int κ, double dose, int no, int total, string time)
        {
            this.κ = κ;
            this.dose = dose;
            this.no = no;
            this.total = total;
            this.time = time;
        }

        public static IEnumerable<daphnids> Data
        {
            get
            {
                yield return new daphnids(1, 105, 0, 20, "24h");
                yield return new daphnids(2, 400.07, 1, 20, "24h");
                yield return new daphnids(3, 600.1, 3, 20, "24h");
                yield return new daphnids(4, 1199.2, 3, 20, "24h");
                yield return new daphnids(5, 1999.33, 5, 20, "24h");
                yield return new daphnids(6, 3198.52, 6, 20, "24h");
                yield return new daphnids(7, 5596.91, 7, 20, "24h");
                yield return new daphnids(8, 9595.57, 17, 20, "24h");
                yield return new daphnids(9, 105, 0, 20, "48h");
                yield return new daphnids(10, 400.07, 0, 20, "48h");
                yield return new daphnids(11, 600.1, 6, 20, "48h");
                yield return new daphnids(12, 1199.2, 8, 20, "48h");
                yield return new daphnids(13, 1999.33, 11, 20, "48h");
                yield return new daphnids(14, 3198.52, 16, 20, "48h");
                yield return new daphnids(15, 5596.91, 18, 20, "48h");
                yield return new daphnids(16, 9595.57, 20, 20, "48h");
            }
        }
    }
}
