// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 5.6, p146
    /// </summary>

    public class stddiag
    {
        public readonly int encounter;
        public readonly double diagnosed;

        public stddiag(int encounter, double diagnosed)
        {
            this.encounter = encounter;
            this.diagnosed = diagnosed;
        }

        public static IEnumerable<stddiag> Data
        {
            get
            {
                yield return new stddiag(15, 2.73);
                yield return new stddiag(8, 1.67);
                yield return new stddiag(11, 0.53);
                yield return new stddiag(13, 0.77);
                yield return new stddiag(14, 1.37);
                yield return new stddiag(4, 0.83);
                yield return new stddiag(2, 1.27);
                yield return new stddiag(8, 1.2);
                yield return new stddiag(20, 1.93);
                yield return new stddiag(7, 0.6);
                yield return new stddiag(18, 0.77);
                yield return new stddiag(4, 0.9);
                yield return new stddiag(6, 1.27);
                yield return new stddiag(15, 1.77);
                yield return new stddiag(35, 1.07);
                yield return new stddiag(17, 1.2);
                yield return new stddiag(16, 0.33);
                yield return new stddiag(26, 0.53);
                yield return new stddiag(33, 0.8);
                yield return new stddiag(20, 1.53);
                yield return new stddiag(23, 1.4);
                yield return new stddiag(36, 0.43);
                yield return new stddiag(10, 0.9);
                yield return new stddiag(5, 1.93);
                yield return new stddiag(25, 0.57);
            }
        }
    }
}
