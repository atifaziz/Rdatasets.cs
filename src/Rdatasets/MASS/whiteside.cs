// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// House Insulation: Whiteside's Data
    /// </summary>

    public class whiteside
    {
        public readonly string Insul;
        public readonly double Temp;
        public readonly double Gas;

        public whiteside(string Insul, double Temp, double Gas)
        {
            this.Insul = Insul;
            this.Temp = Temp;
            this.Gas = Gas;
        }

        public static IEnumerable<whiteside> Data
        {
            get
            {
                yield return new whiteside("Before", -0.8, 7.2);
                yield return new whiteside("Before", -0.7, 6.9);
                yield return new whiteside("Before", 0.4, 6.4);
                yield return new whiteside("Before", 2.5, 6);
                yield return new whiteside("Before", 2.9, 5.8);
                yield return new whiteside("Before", 3.2, 5.8);
                yield return new whiteside("Before", 3.6, 5.6);
                yield return new whiteside("Before", 3.9, 4.7);
                yield return new whiteside("Before", 4.2, 5.8);
                yield return new whiteside("Before", 4.3, 5.2);
                yield return new whiteside("Before", 5.4, 4.9);
                yield return new whiteside("Before", 6, 4.9);
                yield return new whiteside("Before", 6, 4.3);
                yield return new whiteside("Before", 6, 4.4);
                yield return new whiteside("Before", 6.2, 4.5);
                yield return new whiteside("Before", 6.3, 4.6);
                yield return new whiteside("Before", 6.9, 3.7);
                yield return new whiteside("Before", 7, 3.9);
                yield return new whiteside("Before", 7.4, 4.2);
                yield return new whiteside("Before", 7.5, 4);
                yield return new whiteside("Before", 7.5, 3.9);
                yield return new whiteside("Before", 7.6, 3.5);
                yield return new whiteside("Before", 8, 4);
                yield return new whiteside("Before", 8.5, 3.6);
                yield return new whiteside("Before", 9.1, 3.1);
                yield return new whiteside("Before", 10.2, 2.6);
                yield return new whiteside("After", -0.7, 4.8);
                yield return new whiteside("After", 0.8, 4.6);
                yield return new whiteside("After", 1, 4.7);
                yield return new whiteside("After", 1.4, 4);
                yield return new whiteside("After", 1.5, 4.2);
                yield return new whiteside("After", 1.6, 4.2);
                yield return new whiteside("After", 2.3, 4.1);
                yield return new whiteside("After", 2.5, 4);
                yield return new whiteside("After", 2.5, 3.5);
                yield return new whiteside("After", 3.1, 3.2);
                yield return new whiteside("After", 3.9, 3.9);
                yield return new whiteside("After", 4, 3.5);
                yield return new whiteside("After", 4, 3.7);
                yield return new whiteside("After", 4.2, 3.5);
                yield return new whiteside("After", 4.3, 3.5);
                yield return new whiteside("After", 4.6, 3.7);
                yield return new whiteside("After", 4.7, 3.5);
                yield return new whiteside("After", 4.9, 3.4);
                yield return new whiteside("After", 4.9, 3.7);
                yield return new whiteside("After", 4.9, 4);
                yield return new whiteside("After", 5, 3.6);
                yield return new whiteside("After", 5.3, 3.7);
                yield return new whiteside("After", 6.2, 2.8);
                yield return new whiteside("After", 7.1, 3);
                yield return new whiteside("After", 7.2, 2.8);
                yield return new whiteside("After", 7.5, 2.6);
                yield return new whiteside("After", 8, 2.7);
                yield return new whiteside("After", 8.7, 2.8);
                yield return new whiteside("After", 8.8, 1.3);
                yield return new whiteside("After", 9.7, 1.5);
            }
        }
    }
}
