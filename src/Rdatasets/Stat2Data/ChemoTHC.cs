// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ChemoTHC
    /// </summary>

    public class ChemoTHC
    {
        public readonly int κ;
        public readonly string Drug;
        public readonly int Effective;
        public readonly int NotEffective;
        public readonly int Patients;

        public ChemoTHC(int κ, string Drug, int Effective, int NotEffective, int Patients)
        {
            this.κ = κ;
            this.Drug = Drug;
            this.Effective = Effective;
            this.NotEffective = NotEffective;
            this.Patients = Patients;
        }

        public static IEnumerable<ChemoTHC> Data
        {
            get
            {
                yield return new ChemoTHC(1, "THC", 36, 43, 79);
                yield return new ChemoTHC(2, "Prochlorperazine", 16, 62, 78);
            }
        }
    }
}
