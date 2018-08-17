// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Diagnostic Tests on Patients with Cushing's Syndrome
    /// </summary>

    public class Cushings
    {
        public readonly double Tetrahydrocortisone;
        public readonly double Pregnanetriol;
        public readonly string Type;

        public Cushings(double Tetrahydrocortisone, double Pregnanetriol, string Type)
        {
            this.Tetrahydrocortisone = Tetrahydrocortisone;
            this.Pregnanetriol = Pregnanetriol;
            this.Type = Type;
        }

        public static IEnumerable<Cushings> Data
        {
            get
            {
                yield return new Cushings(3.1, 11.7, "a");
                yield return new Cushings(3, 1.3, "a");
                yield return new Cushings(1.9, 0.1, "a");
                yield return new Cushings(3.8, 0.04, "a");
                yield return new Cushings(4.1, 1.1, "a");
                yield return new Cushings(1.9, 0.4, "a");
                yield return new Cushings(8.3, 1, "b");
                yield return new Cushings(3.8, 0.2, "b");
                yield return new Cushings(3.9, 0.6, "b");
                yield return new Cushings(7.8, 1.2, "b");
                yield return new Cushings(9.1, 0.6, "b");
                yield return new Cushings(15.4, 3.6, "b");
                yield return new Cushings(7.7, 1.6, "b");
                yield return new Cushings(6.5, 0.4, "b");
                yield return new Cushings(5.7, 0.4, "b");
                yield return new Cushings(13.6, 1.6, "b");
                yield return new Cushings(10.2, 6.4, "c");
                yield return new Cushings(9.2, 7.9, "c");
                yield return new Cushings(9.6, 3.1, "c");
                yield return new Cushings(53.8, 2.5, "c");
                yield return new Cushings(15.8, 7.6, "c");
                yield return new Cushings(5.1, 0.4, "u");
                yield return new Cushings(12.9, 5, "u");
                yield return new Cushings(13, 0.8, "u");
                yield return new Cushings(2.6, 0.1, "u");
                yield return new Cushings(30, 0.1, "u");
                yield return new Cushings(20.5, 0.8, "u");
            }
        }
    }
}
