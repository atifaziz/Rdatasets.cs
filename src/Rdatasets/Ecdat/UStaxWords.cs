// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Number of Words in US Tax Law
    /// </summary>

    public class UStaxWords
    {
        public readonly int year;
        public readonly string IncomeTaxCode;
        public readonly string otherTaxCode;
        public readonly string EntireTaxCode;
        public readonly string IncomeTaxRegulations;
        public readonly string otherTaxRegulations;
        public readonly string EntireTaxRegulations;
        public readonly string IncomeTaxCodeAndRegs;
        public readonly string otherTaxCodeAndRegs;
        public readonly int EntireTaxCodeAndRegs;

        public UStaxWords(int year, string IncomeTaxCode, string otherTaxCode, string EntireTaxCode, string IncomeTaxRegulations, string otherTaxRegulations, string EntireTaxRegulations, string IncomeTaxCodeAndRegs, string otherTaxCodeAndRegs, int EntireTaxCodeAndRegs)
        {
            this.year = year;
            this.IncomeTaxCode = IncomeTaxCode;
            this.otherTaxCode = otherTaxCode;
            this.EntireTaxCode = EntireTaxCode;
            this.IncomeTaxRegulations = IncomeTaxRegulations;
            this.otherTaxRegulations = otherTaxRegulations;
            this.EntireTaxRegulations = EntireTaxRegulations;
            this.IncomeTaxCodeAndRegs = IncomeTaxCodeAndRegs;
            this.otherTaxCodeAndRegs = otherTaxCodeAndRegs;
            this.EntireTaxCodeAndRegs = EntireTaxCodeAndRegs;
        }

        public static IEnumerable<UStaxWords> Data
        {
            get
            {
                yield return new UStaxWords(1955, "172", "237", "409", "547", "440", "987", "718", "678", 1396);
                yield return new UStaxWords(1965, "243", "305", "548", "1638", "565", "2203", "1881", "870", 2751);
                yield return new UStaxWords(1975, "395", "363", "758", "2456", "692", "3148", "2851", "1055", 3906);
                yield return new UStaxWords(1985, "776", "556", "1332", "3594", "813", "4407", "4369", "1370", 5739);
                yield return new UStaxWords(1995, "1060", "731", "1791", "4663", "1198", "5861", "5722", "1930", 7652);
                yield return new UStaxWords(2005, "1286", "853", "2139", "5778", "1180", "6958", "7064", "2033", 9097);
                yield return new UStaxWords(2015, null, null, null, null, null, null, null, null, 10067);
            }
        }
    }
}
