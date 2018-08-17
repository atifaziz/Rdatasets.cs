// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Official Secrecy of the United States Government
    /// </summary>

    public class USclassifiedDocuments
    {
        public readonly int year;
        public readonly string OCAuthorities;
        public readonly string OCActivity;
        public readonly string TenYrDeclass;
        public readonly string DerivClassActivity;

        public USclassifiedDocuments(int year, string OCAuthorities, string OCActivity, string TenYrDeclass, string DerivClassActivity)
        {
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
                yield return new USclassifiedDocuments(1980, "7149", null, null, null);
                yield return new USclassifiedDocuments(1982, "6943", null, null, null);
                yield return new USclassifiedDocuments(1984, "6900", null, null, null);
                yield return new USclassifiedDocuments(1986, "6756", null, null, null);
                yield return new USclassifiedDocuments(1988, "6654", null, null, null);
                yield return new USclassifiedDocuments(1989, null, "507794", null, null);
                yield return new USclassifiedDocuments(1990, "6492", "490975", null, null);
                yield return new USclassifiedDocuments(1991, null, "511858", null, null);
                yield return new USclassifiedDocuments(1992, "5793", "480843", null, null);
                yield return new USclassifiedDocuments(1993, null, "245951", null, null);
                yield return new USclassifiedDocuments(1994, "5461", "204683", null, null);
                yield return new USclassifiedDocuments(1995, null, "167840", null, null);
                yield return new USclassifiedDocuments(1996, "4420", "105163", "0.5", "5685462");
                yield return new USclassifiedDocuments(1997, null, "158788", "0.5", "6361366");
                yield return new USclassifiedDocuments(1998, "3903", "137005", "0.36", "7157763");
                yield return new USclassifiedDocuments(1999, null, "169735", "0.5", "7858857");
                yield return new USclassifiedDocuments(2000, "4130", "220926", "0.59", "10929943");
                yield return new USclassifiedDocuments(2001, null, "260678", "0.54", "8390057");
                yield return new USclassifiedDocuments(2002, "4006", "217268", "0.57", "11054350");
                yield return new USclassifiedDocuments(2003, null, "234052", "0.52", "13993968");
                yield return new USclassifiedDocuments(2004, "4007", "351150", "0.34", "15294087");
                yield return new USclassifiedDocuments(2005, null, "258633", "0.64", "13948140");
                yield return new USclassifiedDocuments(2006, "4042", "231005", "0.61", "20324450");
                yield return new USclassifiedDocuments(2007, null, "233630", "0.57", "22868618");
                yield return new USclassifiedDocuments(2008, "4109", "203541", "0.58", "23217557");
                yield return new USclassifiedDocuments(2009, null, "183224", "0.67", "54651765");
                yield return new USclassifiedDocuments(2010, "2378", "224734", "0.74", "76571211");
                yield return new USclassifiedDocuments(2011, "2362", "127072", "0.7", "92064862");
                yield return new USclassifiedDocuments(2012, "2326", "73477", "0.48", "95180243");
            }
        }
    }
}
