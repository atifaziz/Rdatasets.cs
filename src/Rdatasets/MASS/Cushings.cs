// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Diagnostic Tests on Patients with Cushing's Syndrome
    /// </summary>

    public class Cushings
    {
        public readonly string κ;
        public readonly double Tetrahydrocortisone;
        public readonly double Pregnanetriol;
        public readonly string Type;

        public Cushings(string κ, double Tetrahydrocortisone, double Pregnanetriol, string Type)
        {
            this.κ = κ;
            this.Tetrahydrocortisone = Tetrahydrocortisone;
            this.Pregnanetriol = Pregnanetriol;
            this.Type = Type;
        }

        public static IEnumerable<Cushings> Data
        {
            get
            {
                yield return new Cushings("a1", 3.1, 11.7, "a");
                yield return new Cushings("a2", 3, 1.3, "a");
                yield return new Cushings("a3", 1.9, 0.1, "a");
                yield return new Cushings("a4", 3.8, 0.04, "a");
                yield return new Cushings("a5", 4.1, 1.1, "a");
                yield return new Cushings("a6", 1.9, 0.4, "a");
                yield return new Cushings("b1", 8.3, 1, "b");
                yield return new Cushings("b2", 3.8, 0.2, "b");
                yield return new Cushings("b3", 3.9, 0.6, "b");
                yield return new Cushings("b4", 7.8, 1.2, "b");
                yield return new Cushings("b5", 9.1, 0.6, "b");
                yield return new Cushings("b6", 15.4, 3.6, "b");
                yield return new Cushings("b7", 7.7, 1.6, "b");
                yield return new Cushings("b8", 6.5, 0.4, "b");
                yield return new Cushings("b9", 5.7, 0.4, "b");
                yield return new Cushings("b10", 13.6, 1.6, "b");
                yield return new Cushings("c1", 10.2, 6.4, "c");
                yield return new Cushings("c2", 9.2, 7.9, "c");
                yield return new Cushings("c3", 9.6, 3.1, "c");
                yield return new Cushings("c4", 53.8, 2.5, "c");
                yield return new Cushings("c5", 15.8, 7.6, "c");
                yield return new Cushings("u1", 5.1, 0.4, "u");
                yield return new Cushings("u2", 12.9, 5, "u");
                yield return new Cushings("u3", 13, 0.8, "u");
                yield return new Cushings("u4", 2.6, 0.1, "u");
                yield return new Cushings("u5", 30, 0.1, "u");
                yield return new Cushings("u6", 20.5, 0.8, "u");
            }
        }
    }
}
