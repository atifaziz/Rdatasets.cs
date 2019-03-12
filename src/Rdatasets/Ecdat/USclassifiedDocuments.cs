// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Official Secrecy of the United States Government
    /// </summary>

    public class USclassifiedDocuments
    {
        public readonly int κ;
        public readonly int year;
        public readonly int? OCAuthorities;
        public readonly int? OCActivity;
        public readonly double? TenYrDeclass;
        public readonly int? DerivClassActivity;

        public USclassifiedDocuments(int κ, int year, int? OCAuthorities, int? OCActivity, double? TenYrDeclass, int? DerivClassActivity)
        {
            this.κ = κ;
            this.year = year;
            this.OCAuthorities = OCAuthorities;
            this.OCActivity = OCActivity;
            this.TenYrDeclass = TenYrDeclass;
            this.DerivClassActivity = DerivClassActivity;
        }

        public static IEnumerable<USclassifiedDocuments> Data
        {
            get
            {
                yield return new USclassifiedDocuments(1, 1980, 7149, null, null, null);
                yield return new USclassifiedDocuments(2, 1982, 6943, null, null, null);
                yield return new USclassifiedDocuments(3, 1984, 6900, null, null, null);
                yield return new USclassifiedDocuments(4, 1986, 6756, null, null, null);
                yield return new USclassifiedDocuments(5, 1988, 6654, null, null, null);
                yield return new USclassifiedDocuments(6, 1989, null, 507794, null, null);
                yield return new USclassifiedDocuments(7, 1990, 6492, 490975, null, null);
                yield return new USclassifiedDocuments(8, 1991, null, 511858, null, null);
                yield return new USclassifiedDocuments(9, 1992, 5793, 480843, null, null);
                yield return new USclassifiedDocuments(10, 1993, null, 245951, null, null);
                yield return new USclassifiedDocuments(11, 1994, 5461, 204683, null, null);
                yield return new USclassifiedDocuments(12, 1995, null, 167840, null, null);
                yield return new USclassifiedDocuments(13, 1996, 4420, 105163, 0.5, 5685462);
                yield return new USclassifiedDocuments(14, 1997, null, 158788, 0.5, 6361366);
                yield return new USclassifiedDocuments(15, 1998, 3903, 137005, 0.36, 7157763);
                yield return new USclassifiedDocuments(16, 1999, null, 169735, 0.5, 7858857);
                yield return new USclassifiedDocuments(17, 2000, 4130, 220926, 0.59, 10929943);
                yield return new USclassifiedDocuments(18, 2001, null, 260678, 0.54, 8390057);
                yield return new USclassifiedDocuments(19, 2002, 4006, 217268, 0.57, 11054350);
                yield return new USclassifiedDocuments(20, 2003, null, 234052, 0.52, 13993968);
                yield return new USclassifiedDocuments(21, 2004, 4007, 351150, 0.34, 15294087);
                yield return new USclassifiedDocuments(22, 2005, null, 258633, 0.64, 13948140);
                yield return new USclassifiedDocuments(23, 2006, 4042, 231005, 0.61, 20324450);
                yield return new USclassifiedDocuments(24, 2007, null, 233630, 0.57, 22868618);
                yield return new USclassifiedDocuments(25, 2008, 4109, 203541, 0.58, 23217557);
                yield return new USclassifiedDocuments(26, 2009, null, 183224, 0.67, 54651765);
                yield return new USclassifiedDocuments(27, 2010, 2378, 224734, 0.74, 76571211);
                yield return new USclassifiedDocuments(28, 2011, 2362, 127072, 0.7, 92064862);
                yield return new USclassifiedDocuments(29, 2012, 2326, 73477, 0.48, 95180243);
            }
        }
    }
}
