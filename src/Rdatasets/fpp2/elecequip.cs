// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Electrical equipment manufactured in the Euro area.
    /// </summary>

    public class elecequip
    {
        public readonly double time;
        public readonly double value;

        public elecequip(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<elecequip> Data
        {
            get
            {
                yield return new elecequip(1996, 79.35);
                yield return new elecequip(1996.08333333333, 75.78);
                yield return new elecequip(1996.16666666667, 86.32);
                yield return new elecequip(1996.25, 72.6);
                yield return new elecequip(1996.33333333333, 74.86);
                yield return new elecequip(1996.41666666667, 83.81);
                yield return new elecequip(1996.5, 79.8);
                yield return new elecequip(1996.58333333333, 62.41);
                yield return new elecequip(1996.66666666667, 85.41);
                yield return new elecequip(1996.75, 83.11);
                yield return new elecequip(1996.83333333333, 84.21);
                yield return new elecequip(1996.91666666667, 89.7);
                yield return new elecequip(1997, 78.64);
                yield return new elecequip(1997.08333333333, 77.42);
                yield return new elecequip(1997.16666666667, 89.86);
                yield return new elecequip(1997.25, 81.27);
                yield return new elecequip(1997.33333333333, 78.68);
                yield return new elecequip(1997.41666666667, 89.51);
                yield return new elecequip(1997.5, 83.67);
                yield return new elecequip(1997.58333333333, 69.8);
                yield return new elecequip(1997.66666666667, 91.09);
                yield return new elecequip(1997.75, 89.43);
                yield return new elecequip(1997.83333333333, 91.04);
                yield return new elecequip(1997.91666666667, 92.87);
                yield return new elecequip(1998, 81.87);
                yield return new elecequip(1998.08333333333, 85.36);
                yield return new elecequip(1998.16666666667, 92.98);
                yield return new elecequip(1998.25, 81.09);
                yield return new elecequip(1998.33333333333, 85.64);
                yield return new elecequip(1998.41666666667, 91.14);
                yield return new elecequip(1998.5, 83.46);
                yield return new elecequip(1998.58333333333, 66.37);
                yield return new elecequip(1998.66666666667, 93.34);
                yield return new elecequip(1998.75, 85.93);
                yield return new elecequip(1998.83333333333, 86.81);
                yield return new elecequip(1998.91666666667, 93.3);
                yield return new elecequip(1999, 81.59);
                yield return new elecequip(1999.08333333333, 81.77);
                yield return new elecequip(1999.16666666667, 91.24);
                yield return new elecequip(1999.25, 79.45);
                yield return new elecequip(1999.33333333333, 86.99);
                yield return new elecequip(1999.41666666667, 96.6);
                yield return new elecequip(1999.5, 97.99);
                yield return new elecequip(1999.58333333333, 79.13);
                yield return new elecequip(1999.66666666667, 103.56);
                yield return new elecequip(1999.75, 100.89);
                yield return new elecequip(1999.83333333333, 99.4);
                yield return new elecequip(1999.91666666667, 111.8);
                yield return new elecequip(2000, 95.3);
                yield return new elecequip(2000.08333333333, 97.77);
                yield return new elecequip(2000.16666666667, 116.23);
                yield return new elecequip(2000.25, 100.98);
                yield return new elecequip(2000.33333333333, 104.07);
                yield return new elecequip(2000.41666666667, 114.64);
                yield return new elecequip(2000.5, 107.62);
                yield return new elecequip(2000.58333333333, 96.12);
                yield return new elecequip(2000.66666666667, 123.5);
                yield return new elecequip(2000.75, 116.12);
                yield return new elecequip(2000.83333333333, 116.86);
                yield return new elecequip(2000.91666666667, 128.61);
                yield return new elecequip(2001, 100.56);
                yield return new elecequip(2001.08333333333, 103.05);
                yield return new elecequip(2001.16666666667, 119.06);
                yield return new elecequip(2001.25, 92.46);
                yield return new elecequip(2001.33333333333, 98.75);
                yield return new elecequip(2001.41666666667, 111.14);
                yield return new elecequip(2001.5, 96.13);
                yield return new elecequip(2001.58333333333, 79.72);
                yield return new elecequip(2001.66666666667, 102.07);
                yield return new elecequip(2001.75, 96.18);
                yield return new elecequip(2001.83333333333, 101.26);
                yield return new elecequip(2001.91666666667, 109.85);
                yield return new elecequip(2002, 89.52);
                yield return new elecequip(2002.08333333333, 89.27);
                yield return new elecequip(2002.16666666667, 104.35);
                yield return new elecequip(2002.25, 87.05);
                yield return new elecequip(2002.33333333333, 89.33);
                yield return new elecequip(2002.41666666667, 102.2);
                yield return new elecequip(2002.5, 88.13);
                yield return new elecequip(2002.58333333333, 75.68);
                yield return new elecequip(2002.66666666667, 99.48);
                yield return new elecequip(2002.75, 96.4);
                yield return new elecequip(2002.83333333333, 96.16);
                yield return new elecequip(2002.91666666667, 101);
                yield return new elecequip(2003, 89.34);
                yield return new elecequip(2003.08333333333, 86.91);
                yield return new elecequip(2003.16666666667, 98.9);
                yield return new elecequip(2003.25, 85.54);
                yield return new elecequip(2003.33333333333, 85.25);
                yield return new elecequip(2003.41666666667, 101.14);
                yield return new elecequip(2003.5, 91.8);
                yield return new elecequip(2003.58333333333, 76.98);
                yield return new elecequip(2003.66666666667, 104.33);
                yield return new elecequip(2003.75, 99.72);
                yield return new elecequip(2003.83333333333, 101.06);
                yield return new elecequip(2003.91666666667, 109);
                yield return new elecequip(2004, 89.88);
                yield return new elecequip(2004.08333333333, 92.27);
                yield return new elecequip(2004.16666666667, 105.11);
                yield return new elecequip(2004.25, 91.5);
                yield return new elecequip(2004.33333333333, 92.56);
                yield return new elecequip(2004.41666666667, 104.35);
                yield return new elecequip(2004.5, 96.21);
                yield return new elecequip(2004.58333333333, 79.58);
                yield return new elecequip(2004.66666666667, 105.43);
                yield return new elecequip(2004.75, 99.18);
                yield return new elecequip(2004.83333333333, 99.77);
                yield return new elecequip(2004.91666666667, 113.55);
                yield return new elecequip(2005, 91.65);
                yield return new elecequip(2005.08333333333, 90.56);
                yield return new elecequip(2005.16666666667, 105.52);
                yield return new elecequip(2005.25, 92.18);
                yield return new elecequip(2005.33333333333, 91.22);
                yield return new elecequip(2005.41666666667, 109.04);
                yield return new elecequip(2005.5, 99.26);
                yield return new elecequip(2005.58333333333, 83.36);
                yield return new elecequip(2005.66666666667, 110.8);
                yield return new elecequip(2005.75, 104.95);
                yield return new elecequip(2005.83333333333, 107.07);
                yield return new elecequip(2005.91666666667, 114.4);
                yield return new elecequip(2006, 99.16);
                yield return new elecequip(2006.08333333333, 99.86);
                yield return new elecequip(2006.16666666667, 116.14);
                yield return new elecequip(2006.25, 103.48);
                yield return new elecequip(2006.33333333333, 103.07);
                yield return new elecequip(2006.41666666667, 119.32);
                yield return new elecequip(2006.5, 107.94);
                yield return new elecequip(2006.58333333333, 90.59);
                yield return new elecequip(2006.66666666667, 121.8);
                yield return new elecequip(2006.75, 117.11);
                yield return new elecequip(2006.83333333333, 113.71);
                yield return new elecequip(2006.91666666667, 120.37);
                yield return new elecequip(2007, 103.93);
                yield return new elecequip(2007.08333333333, 104.1);
                yield return new elecequip(2007.16666666667, 125.72);
                yield return new elecequip(2007.25, 104.7);
                yield return new elecequip(2007.33333333333, 108.45);
                yield return new elecequip(2007.41666666667, 123.11);
                yield return new elecequip(2007.5, 108.89);
                yield return new elecequip(2007.58333333333, 94.07);
                yield return new elecequip(2007.66666666667, 121.88);
                yield return new elecequip(2007.75, 116.81);
                yield return new elecequip(2007.83333333333, 115.87);
                yield return new elecequip(2007.91666666667, 127.14);
                yield return new elecequip(2008, 109.45);
                yield return new elecequip(2008.08333333333, 105.23);
                yield return new elecequip(2008.16666666667, 121.32);
                yield return new elecequip(2008.25, 108.78);
                yield return new elecequip(2008.33333333333, 103.2);
                yield return new elecequip(2008.41666666667, 117.93);
                yield return new elecequip(2008.5, 103.76);
                yield return new elecequip(2008.58333333333, 89.27);
                yield return new elecequip(2008.66666666667, 109.5);
                yield return new elecequip(2008.75, 104.02);
                yield return new elecequip(2008.83333333333, 100.12);
                yield return new elecequip(2008.91666666667, 101.18);
                yield return new elecequip(2009, 77.38);
                yield return new elecequip(2009.08333333333, 75.19);
                yield return new elecequip(2009.16666666667, 86.4);
                yield return new elecequip(2009.25, 74.13);
                yield return new elecequip(2009.33333333333, 74.1);
                yield return new elecequip(2009.41666666667, 85.61);
                yield return new elecequip(2009.5, 79.9);
                yield return new elecequip(2009.58333333333, 65.36);
                yield return new elecequip(2009.66666666667, 88.09);
                yield return new elecequip(2009.75, 84.6);
                yield return new elecequip(2009.83333333333, 88.09);
                yield return new elecequip(2009.91666666667, 102.52);
                yield return new elecequip(2010, 79.28);
                yield return new elecequip(2010.08333333333, 78.74);
                yield return new elecequip(2010.16666666667, 94.62);
                yield return new elecequip(2010.25, 84.66);
                yield return new elecequip(2010.33333333333, 85.2);
                yield return new elecequip(2010.41666666667, 103.94);
                yield return new elecequip(2010.5, 89.87);
                yield return new elecequip(2010.58333333333, 78.14);
                yield return new elecequip(2010.66666666667, 96.5);
                yield return new elecequip(2010.75, 94.68);
                yield return new elecequip(2010.83333333333, 101.77);
                yield return new elecequip(2010.91666666667, 103.48);
                yield return new elecequip(2011, 92.57);
                yield return new elecequip(2011.08333333333, 89.16);
                yield return new elecequip(2011.16666666667, 104.48);
                yield return new elecequip(2011.25, 89.45);
                yield return new elecequip(2011.33333333333, 93.4);
                yield return new elecequip(2011.41666666667, 102.9);
                yield return new elecequip(2011.5, 93.77);
                yield return new elecequip(2011.58333333333, 77.58);
                yield return new elecequip(2011.66666666667, 95.04);
                yield return new elecequip(2011.75, 91.77);
                yield return new elecequip(2011.83333333333, 93.37);
                yield return new elecequip(2011.91666666667, 98.34);
                yield return new elecequip(2012, 86.44);
                yield return new elecequip(2012.08333333333, 85.04);
                yield return new elecequip(2012.16666666667, 97.8);
            }
        }
    }
}
