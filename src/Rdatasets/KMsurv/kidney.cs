// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.4
    /// </summary>

    public class kidney
    {
        public readonly double time;
        public readonly int delta;
        public readonly int type;

        public kidney(double time, int delta, int type)
        {
            this.time = time;
            this.delta = delta;
            this.type = type;
        }

        public static IEnumerable<kidney> Data
        {
            get
            {
                yield return new kidney(1.5, 1, 1);
                yield return new kidney(3.5, 1, 1);
                yield return new kidney(4.5, 1, 1);
                yield return new kidney(4.5, 1, 1);
                yield return new kidney(5.5, 1, 1);
                yield return new kidney(8.5, 1, 1);
                yield return new kidney(8.5, 1, 1);
                yield return new kidney(9.5, 1, 1);
                yield return new kidney(10.5, 1, 1);
                yield return new kidney(11.5, 1, 1);
                yield return new kidney(15.5, 1, 1);
                yield return new kidney(16.5, 1, 1);
                yield return new kidney(18.5, 1, 1);
                yield return new kidney(23.5, 1, 1);
                yield return new kidney(26.5, 1, 1);
                yield return new kidney(2.5, 0, 1);
                yield return new kidney(2.5, 0, 1);
                yield return new kidney(3.5, 0, 1);
                yield return new kidney(3.5, 0, 1);
                yield return new kidney(3.5, 0, 1);
                yield return new kidney(4.5, 0, 1);
                yield return new kidney(5.5, 0, 1);
                yield return new kidney(6.5, 0, 1);
                yield return new kidney(6.5, 0, 1);
                yield return new kidney(7.5, 0, 1);
                yield return new kidney(7.5, 0, 1);
                yield return new kidney(7.5, 0, 1);
                yield return new kidney(7.5, 0, 1);
                yield return new kidney(8.5, 0, 1);
                yield return new kidney(9.5, 0, 1);
                yield return new kidney(10.5, 0, 1);
                yield return new kidney(11.5, 0, 1);
                yield return new kidney(12.5, 0, 1);
                yield return new kidney(12.5, 0, 1);
                yield return new kidney(13.5, 0, 1);
                yield return new kidney(14.5, 0, 1);
                yield return new kidney(14.5, 0, 1);
                yield return new kidney(21.5, 0, 1);
                yield return new kidney(21.5, 0, 1);
                yield return new kidney(22.5, 0, 1);
                yield return new kidney(22.5, 0, 1);
                yield return new kidney(25.5, 0, 1);
                yield return new kidney(27.5, 0, 1);
                yield return new kidney(0.5, 1, 2);
                yield return new kidney(0.5, 1, 2);
                yield return new kidney(0.5, 1, 2);
                yield return new kidney(0.5, 1, 2);
                yield return new kidney(0.5, 1, 2);
                yield return new kidney(0.5, 1, 2);
                yield return new kidney(2.5, 1, 2);
                yield return new kidney(2.5, 1, 2);
                yield return new kidney(3.5, 1, 2);
                yield return new kidney(6.5, 1, 2);
                yield return new kidney(15.5, 1, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(0.5, 0, 2);
                yield return new kidney(1.5, 0, 2);
                yield return new kidney(1.5, 0, 2);
                yield return new kidney(1.5, 0, 2);
                yield return new kidney(1.5, 0, 2);
                yield return new kidney(2.5, 0, 2);
                yield return new kidney(2.5, 0, 2);
                yield return new kidney(2.5, 0, 2);
                yield return new kidney(2.5, 0, 2);
                yield return new kidney(2.5, 0, 2);
                yield return new kidney(3.5, 0, 2);
                yield return new kidney(3.5, 0, 2);
                yield return new kidney(3.5, 0, 2);
                yield return new kidney(3.5, 0, 2);
                yield return new kidney(3.5, 0, 2);
                yield return new kidney(4.5, 0, 2);
                yield return new kidney(4.5, 0, 2);
                yield return new kidney(4.5, 0, 2);
                yield return new kidney(5.5, 0, 2);
                yield return new kidney(5.5, 0, 2);
                yield return new kidney(5.5, 0, 2);
                yield return new kidney(5.5, 0, 2);
                yield return new kidney(5.5, 0, 2);
                yield return new kidney(6.5, 0, 2);
                yield return new kidney(7.5, 0, 2);
                yield return new kidney(7.5, 0, 2);
                yield return new kidney(7.5, 0, 2);
                yield return new kidney(8.5, 0, 2);
                yield return new kidney(8.5, 0, 2);
                yield return new kidney(8.5, 0, 2);
                yield return new kidney(9.5, 0, 2);
                yield return new kidney(9.5, 0, 2);
                yield return new kidney(10.5, 0, 2);
                yield return new kidney(10.5, 0, 2);
                yield return new kidney(10.5, 0, 2);
                yield return new kidney(11.5, 0, 2);
                yield return new kidney(11.5, 0, 2);
                yield return new kidney(12.5, 0, 2);
                yield return new kidney(12.5, 0, 2);
                yield return new kidney(12.5, 0, 2);
                yield return new kidney(12.5, 0, 2);
                yield return new kidney(14.5, 0, 2);
                yield return new kidney(14.5, 0, 2);
                yield return new kidney(16.5, 0, 2);
                yield return new kidney(16.5, 0, 2);
                yield return new kidney(18.5, 0, 2);
                yield return new kidney(19.5, 0, 2);
                yield return new kidney(19.5, 0, 2);
                yield return new kidney(19.5, 0, 2);
                yield return new kidney(20.5, 0, 2);
                yield return new kidney(22.5, 0, 2);
                yield return new kidney(24.5, 0, 2);
                yield return new kidney(25.5, 0, 2);
                yield return new kidney(26.5, 0, 2);
                yield return new kidney(26.5, 0, 2);
                yield return new kidney(28.5, 0, 2);
            }
        }
    }
}
