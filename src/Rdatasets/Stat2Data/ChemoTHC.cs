// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ChemoTHC
    /// </summary>

    public class ChemoTHC
    {
        public readonly string Drug;
        public readonly int Effective;
        public readonly int NotEffective;
        public readonly int Patients;

        public ChemoTHC(string Drug, int Effective, int NotEffective, int Patients)
        {
            this.Drug = Drug;
            this.Effective = Effective;
            this.NotEffective = NotEffective;
            this.Patients = Patients;
        }

        public static IEnumerable<ChemoTHC> Data
        {
            get
            {
                yield return new ChemoTHC("THC", 36, 43, 79);
                yield return new ChemoTHC("Prochlorperazine", 16, 62, 78);
            }
        }
    }
}
