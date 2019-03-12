// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Math Enrollments
    /// </summary>

    public class MathEnrollment
    {
        public readonly int κ;
        public readonly int Ayear;
        public readonly int Fall;
        public readonly int Spring;

        public MathEnrollment(int κ, int Ayear, int Fall, int Spring)
        {
            this.κ = κ;
            this.Ayear = Ayear;
            this.Fall = Fall;
            this.Spring = Spring;
        }

        public static IEnumerable<MathEnrollment> Data
        {
            get
            {
                yield return new MathEnrollment(1, 2001, 259, 246);
                yield return new MathEnrollment(2, 2002, 301, 206);
                yield return new MathEnrollment(3, 2003, 343, 288);
                yield return new MathEnrollment(4, 2004, 307, 215);
                yield return new MathEnrollment(5, 2005, 286, 230);
                yield return new MathEnrollment(6, 2006, 273, 247);
                yield return new MathEnrollment(7, 2007, 248, 308);
                yield return new MathEnrollment(8, 2008, 292, 271);
                yield return new MathEnrollment(9, 2009, 250, 285);
                yield return new MathEnrollment(10, 2010, 278, 286);
                yield return new MathEnrollment(11, 2011, 303, 254);
            }
        }
    }
}
