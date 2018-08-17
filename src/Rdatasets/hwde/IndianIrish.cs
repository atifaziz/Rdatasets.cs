// ReSharper disable All

namespace Rdatasets.hwde
{
    using System.Collections.Generic;

    /// <summary>
    /// Observed genotype frequencies at MN and S loci, for 2 populations
    /// </summary>

    public class IndianIrish
    {
        public readonly string Population;
        public readonly string locus1;
        public readonly string locus2;
        public readonly int Observed;

        public IndianIrish(string Population, string locus1, string locus2, int Observed)
        {
            this.Population = Population;
            this.locus1 = locus1;
            this.locus2 = locus2;
            this.Observed = Observed;
        }

        public static IEnumerable<IndianIrish> Data
        {
            get
            {
                yield return new IndianIrish("Indian", "MM", "SS", 91);
                yield return new IndianIrish("Indian", "MM", "Ss", 147);
                yield return new IndianIrish("Indian", "MM", "ss", 85);
                yield return new IndianIrish("Indian", "MN", "SS", 32);
                yield return new IndianIrish("Indian", "MN", "Ss", 78);
                yield return new IndianIrish("Indian", "MN", "ss", 75);
                yield return new IndianIrish("Indian", "NN", "SS", 5);
                yield return new IndianIrish("Indian", "NN", "Ss", 17);
                yield return new IndianIrish("Indian", "NN", "ss", 7);
                yield return new IndianIrish("Irish", "MM", "SS", 121);
                yield return new IndianIrish("Irish", "MM", "Ss", 248);
                yield return new IndianIrish("Irish", "MM", "ss", 164);
                yield return new IndianIrish("Irish", "MN", "SS", 53);
                yield return new IndianIrish("Irish", "MN", "Ss", 422);
                yield return new IndianIrish("Irish", "MN", "ss", 375);
                yield return new IndianIrish("Irish", "NN", "SS", 9);
                yield return new IndianIrish("Irish", "NN", "Ss", 65);
                yield return new IndianIrish("Irish", "NN", "ss", 241);
            }
        }
    }
}
