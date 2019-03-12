// ReSharper disable All

namespace Rdatasets.hwde
{
    using System.Collections.Generic;

    /// <summary>
    /// Observed genotype frequencies at MN and S loci, for 2 populations
    /// </summary>

    public class IndianIrish
    {
        public readonly int κ;
        public readonly string Population;
        public readonly string locus1;
        public readonly string locus2;
        public readonly int Observed;

        public IndianIrish(int κ, string Population, string locus1, string locus2, int Observed)
        {
            this.κ = κ;
            this.Population = Population;
            this.locus1 = locus1;
            this.locus2 = locus2;
            this.Observed = Observed;
        }

        public static IEnumerable<IndianIrish> Data
        {
            get
            {
                yield return new IndianIrish(1, "Indian", "MM", "SS", 91);
                yield return new IndianIrish(2, "Indian", "MM", "Ss", 147);
                yield return new IndianIrish(3, "Indian", "MM", "ss", 85);
                yield return new IndianIrish(4, "Indian", "MN", "SS", 32);
                yield return new IndianIrish(5, "Indian", "MN", "Ss", 78);
                yield return new IndianIrish(6, "Indian", "MN", "ss", 75);
                yield return new IndianIrish(7, "Indian", "NN", "SS", 5);
                yield return new IndianIrish(8, "Indian", "NN", "Ss", 17);
                yield return new IndianIrish(9, "Indian", "NN", "ss", 7);
                yield return new IndianIrish(10, "Irish", "MM", "SS", 121);
                yield return new IndianIrish(11, "Irish", "MM", "Ss", 248);
                yield return new IndianIrish(12, "Irish", "MM", "ss", 164);
                yield return new IndianIrish(13, "Irish", "MN", "SS", 53);
                yield return new IndianIrish(14, "Irish", "MN", "Ss", 422);
                yield return new IndianIrish(15, "Irish", "MN", "ss", 375);
                yield return new IndianIrish(16, "Irish", "NN", "SS", 9);
                yield return new IndianIrish(17, "Irish", "NN", "Ss", 65);
                yield return new IndianIrish(18, "Irish", "NN", "ss", 241);
            }
        }
    }
}
