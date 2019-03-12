// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Determination of Formaldehyde
    /// </summary>

    public class Formaldehyde
    {
        public readonly int κ;
        public readonly double carb;
        public readonly double optden;

        public Formaldehyde(int κ, double carb, double optden)
        {
            this.κ = κ;
            this.carb = carb;
            this.optden = optden;
        }

        public static IEnumerable<Formaldehyde> Data
        {
            get
            {
                yield return new Formaldehyde(1, 0.1, 0.086);
                yield return new Formaldehyde(2, 0.3, 0.269);
                yield return new Formaldehyde(3, 0.5, 0.446);
                yield return new Formaldehyde(4, 0.6, 0.538);
                yield return new Formaldehyde(5, 0.7, 0.626);
                yield return new Formaldehyde(6, 0.9, 0.782);
            }
        }
    }
}
