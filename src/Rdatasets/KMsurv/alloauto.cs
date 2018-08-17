// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.9
    /// </summary>

    public class alloauto
    {
        public readonly double time;
        public readonly int type;
        public readonly int delta;

        public alloauto(double time, int type, int delta)
        {
            this.time = time;
            this.type = type;
            this.delta = delta;
        }

        public static IEnumerable<alloauto> Data
        {
            get
            {
                yield return new alloauto(0.03, 1, 1);
                yield return new alloauto(0.493, 1, 1);
                yield return new alloauto(0.855, 1, 1);
                yield return new alloauto(1.184, 1, 1);
                yield return new alloauto(1.283, 1, 1);
                yield return new alloauto(1.48, 1, 1);
                yield return new alloauto(1.776, 1, 1);
                yield return new alloauto(2.138, 1, 1);
                yield return new alloauto(2.5, 1, 1);
                yield return new alloauto(2.763, 1, 1);
                yield return new alloauto(2.993, 1, 1);
                yield return new alloauto(3.224, 1, 1);
                yield return new alloauto(3.421, 1, 1);
                yield return new alloauto(4.178, 1, 1);
                yield return new alloauto(4.441, 1, 0);
                yield return new alloauto(5.691, 1, 1);
                yield return new alloauto(5.855, 1, 0);
                yield return new alloauto(6.941, 1, 0);
                yield return new alloauto(6.941, 1, 1);
                yield return new alloauto(7.993, 1, 0);
                yield return new alloauto(8.882, 1, 1);
                yield return new alloauto(8.882, 1, 1);
                yield return new alloauto(9.145, 1, 0);
                yield return new alloauto(11.48, 1, 1);
                yield return new alloauto(11.513, 1, 1);
                yield return new alloauto(12.105, 1, 0);
                yield return new alloauto(12.796, 1, 1);
                yield return new alloauto(12.993, 1, 0);
                yield return new alloauto(13.849, 1, 0);
                yield return new alloauto(16.612, 1, 0);
                yield return new alloauto(17.138, 1, 0);
                yield return new alloauto(20.066, 1, 1);
                yield return new alloauto(20.329, 1, 0);
                yield return new alloauto(22.368, 1, 0);
                yield return new alloauto(26.776, 1, 0);
                yield return new alloauto(28.717, 1, 0);
                yield return new alloauto(28.717, 1, 0);
                yield return new alloauto(32.928, 1, 0);
                yield return new alloauto(33.783, 1, 0);
                yield return new alloauto(34.221, 1, 0);
                yield return new alloauto(34.77, 1, 0);
                yield return new alloauto(39.593, 1, 0);
                yield return new alloauto(41.118, 1, 0);
                yield return new alloauto(45.003, 1, 0);
                yield return new alloauto(46.053, 1, 0);
                yield return new alloauto(46.941, 1, 0);
                yield return new alloauto(48.289, 1, 0);
                yield return new alloauto(57.401, 1, 0);
                yield return new alloauto(58.322, 1, 0);
                yield return new alloauto(60.625, 1, 0);
                yield return new alloauto(0.658, 2, 1);
                yield return new alloauto(0.822, 2, 1);
                yield return new alloauto(1.414, 2, 1);
                yield return new alloauto(2.5, 2, 1);
                yield return new alloauto(3.322, 2, 1);
                yield return new alloauto(3.816, 2, 1);
                yield return new alloauto(4.737, 2, 1);
                yield return new alloauto(4.836, 2, 0);
                yield return new alloauto(4.934, 2, 1);
                yield return new alloauto(5.033, 2, 1);
                yield return new alloauto(5.757, 2, 1);
                yield return new alloauto(5.855, 2, 1);
                yield return new alloauto(5.987, 2, 1);
                yield return new alloauto(6.151, 2, 1);
                yield return new alloauto(6.217, 2, 1);
                yield return new alloauto(6.447, 2, 0);
                yield return new alloauto(8.651, 2, 1);
                yield return new alloauto(8.711, 2, 1);
                yield return new alloauto(9.441, 2, 0);
                yield return new alloauto(10.329, 2, 1);
                yield return new alloauto(11.48, 2, 1);
                yield return new alloauto(12.007, 2, 1);
                yield return new alloauto(12.007, 2, 0);
                yield return new alloauto(12.237, 2, 1);
                yield return new alloauto(12.401, 2, 0);
                yield return new alloauto(13.059, 2, 0);
                yield return new alloauto(14.474, 2, 0);
                yield return new alloauto(15, 2, 0);
                yield return new alloauto(15.461, 2, 1);
                yield return new alloauto(15.757, 2, 1);
                yield return new alloauto(16.48, 2, 1);
                yield return new alloauto(16.711, 2, 1);
                yield return new alloauto(17.204, 2, 0);
                yield return new alloauto(17.237, 2, 1);
                yield return new alloauto(17.303, 2, 0);
                yield return new alloauto(17.664, 2, 0);
                yield return new alloauto(18.092, 2, 1);
                yield return new alloauto(18.092, 2, 0);
                yield return new alloauto(18.75, 2, 0);
                yield return new alloauto(20.625, 2, 0);
                yield return new alloauto(23.158, 2, 1);
                yield return new alloauto(27.73, 2, 0);
                yield return new alloauto(31.184, 2, 0);
                yield return new alloauto(32.434, 2, 0);
                yield return new alloauto(35.921, 2, 0);
                yield return new alloauto(42.237, 2, 0);
                yield return new alloauto(44.638, 2, 0);
                yield return new alloauto(46.48, 2, 0);
                yield return new alloauto(47.467, 2, 0);
                yield return new alloauto(48.322, 2, 0);
                yield return new alloauto(56.086, 2, 1);
            }
        }
    }
}
