// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.5
    /// </summary>

    public class btrial
    {
        public readonly int time;
        public readonly int death;
        public readonly int im;

        public btrial(int time, int death, int im)
        {
            this.time = time;
            this.death = death;
            this.im = im;
        }

        public static IEnumerable<btrial> Data
        {
            get
            {
                yield return new btrial(19, 1, 1);
                yield return new btrial(25, 1, 1);
                yield return new btrial(30, 1, 1);
                yield return new btrial(34, 1, 1);
                yield return new btrial(37, 1, 1);
                yield return new btrial(46, 1, 1);
                yield return new btrial(47, 1, 1);
                yield return new btrial(51, 1, 1);
                yield return new btrial(56, 1, 1);
                yield return new btrial(57, 1, 1);
                yield return new btrial(61, 1, 1);
                yield return new btrial(66, 1, 1);
                yield return new btrial(67, 1, 1);
                yield return new btrial(74, 1, 1);
                yield return new btrial(78, 1, 1);
                yield return new btrial(86, 1, 1);
                yield return new btrial(122, 0, 1);
                yield return new btrial(123, 0, 1);
                yield return new btrial(130, 0, 1);
                yield return new btrial(130, 0, 1);
                yield return new btrial(133, 0, 1);
                yield return new btrial(134, 0, 1);
                yield return new btrial(136, 0, 1);
                yield return new btrial(141, 0, 1);
                yield return new btrial(143, 0, 1);
                yield return new btrial(148, 0, 1);
                yield return new btrial(151, 0, 1);
                yield return new btrial(152, 0, 1);
                yield return new btrial(153, 0, 1);
                yield return new btrial(154, 0, 1);
                yield return new btrial(156, 0, 1);
                yield return new btrial(162, 0, 1);
                yield return new btrial(164, 0, 1);
                yield return new btrial(165, 0, 1);
                yield return new btrial(182, 0, 1);
                yield return new btrial(189, 0, 1);
                yield return new btrial(22, 1, 2);
                yield return new btrial(23, 1, 2);
                yield return new btrial(38, 1, 2);
                yield return new btrial(42, 1, 2);
                yield return new btrial(73, 1, 2);
                yield return new btrial(77, 1, 2);
                yield return new btrial(89, 1, 2);
                yield return new btrial(115, 1, 2);
                yield return new btrial(144, 0, 2);
            }
        }
    }
}
