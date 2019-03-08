// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly retail trade: Euro area.
    /// </summary>

    public class euretail
    {
        public readonly double time;
        public readonly double value;

        public euretail(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<euretail> Data
        {
            get
            {
                yield return new euretail(1996, 89.13);
                yield return new euretail(1996.25, 89.52);
                yield return new euretail(1996.5, 89.88);
                yield return new euretail(1996.75, 90.12);
                yield return new euretail(1997, 89.19);
                yield return new euretail(1997.25, 89.78);
                yield return new euretail(1997.5, 90.03);
                yield return new euretail(1997.75, 90.38);
                yield return new euretail(1998, 90.27);
                yield return new euretail(1998.25, 90.77);
                yield return new euretail(1998.5, 91.85);
                yield return new euretail(1998.75, 92.51);
                yield return new euretail(1999, 92.21);
                yield return new euretail(1999.25, 92.52);
                yield return new euretail(1999.5, 93.62);
                yield return new euretail(1999.75, 94.15);
                yield return new euretail(2000, 94.69);
                yield return new euretail(2000.25, 95.34);
                yield return new euretail(2000.5, 96.04);
                yield return new euretail(2000.75, 96.3);
                yield return new euretail(2001, 94.83);
                yield return new euretail(2001.25, 95.14);
                yield return new euretail(2001.5, 95.86);
                yield return new euretail(2001.75, 95.83);
                yield return new euretail(2002, 95.73);
                yield return new euretail(2002.25, 96.36);
                yield return new euretail(2002.5, 96.89);
                yield return new euretail(2002.75, 97.01);
                yield return new euretail(2003, 96.66);
                yield return new euretail(2003.25, 97.76);
                yield return new euretail(2003.5, 97.83);
                yield return new euretail(2003.75, 97.76);
                yield return new euretail(2004, 98.17);
                yield return new euretail(2004.25, 98.55);
                yield return new euretail(2004.5, 99.31);
                yield return new euretail(2004.75, 99.44);
                yield return new euretail(2005, 99.43);
                yield return new euretail(2005.25, 99.84);
                yield return new euretail(2005.5, 100.32);
                yield return new euretail(2005.75, 100.4);
                yield return new euretail(2006, 99.88);
                yield return new euretail(2006.25, 100.19);
                yield return new euretail(2006.5, 100.75);
                yield return new euretail(2006.75, 101.01);
                yield return new euretail(2007, 100.84);
                yield return new euretail(2007.25, 101.34);
                yield return new euretail(2007.5, 101.94);
                yield return new euretail(2007.75, 102.1);
                yield return new euretail(2008, 101.56);
                yield return new euretail(2008.25, 101.48);
                yield return new euretail(2008.5, 101.13);
                yield return new euretail(2008.75, 100.34);
                yield return new euretail(2009, 98.93);
                yield return new euretail(2009.25, 98.31);
                yield return new euretail(2009.5, 97.67);
                yield return new euretail(2009.75, 97.44);
                yield return new euretail(2010, 96.53);
                yield return new euretail(2010.25, 96.56);
                yield return new euretail(2010.5, 96.51);
                yield return new euretail(2010.75, 96.7);
                yield return new euretail(2011, 95.88);
                yield return new euretail(2011.25, 95.84);
                yield return new euretail(2011.5, 95.79);
                yield return new euretail(2011.75, 95.94);
            }
        }
    }
}
