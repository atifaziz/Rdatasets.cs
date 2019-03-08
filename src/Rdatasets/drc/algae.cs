// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Volume of algae as function of increasing concentrations of a herbicide
    /// </summary>

    public class algae
    {
        public readonly double conc;
        public readonly double vol;

        public algae(double conc, double vol)
        {
            this.conc = conc;
            this.vol = vol;
        }

        public static IEnumerable<algae> Data
        {
            get
            {
                yield return new algae(0, 100.91);
                yield return new algae(0, 111.22);
                yield return new algae(0.89, 101.48);
                yield return new algae(0.89, 90.78);
                yield return new algae(8.94, 43.72);
                yield return new algae(8.94, 35.84);
                yield return new algae(40, 3.81);
                yield return new algae(40, 7.01);
                yield return new algae(78.61, 3.81);
                yield return new algae(78.61, 3.61);
                yield return new algae(98.11, 0.91);
                yield return new algae(98.11, 1.54);
                yield return new algae(196.22, 0.65);
                yield return new algae(196.22, 0.19);
            }
        }
    }
}
