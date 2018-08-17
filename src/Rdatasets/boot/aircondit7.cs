// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Failures of Air-conditioning Equipment
    /// </summary>

    public class aircondit7
    {
        public readonly int hours;

        public aircondit7(int hours)
        {
            this.hours = hours;
        }

        public static IEnumerable<aircondit7> Data
        {
            get
            {
                yield return new aircondit7(3);
                yield return new aircondit7(5);
                yield return new aircondit7(5);
                yield return new aircondit7(13);
                yield return new aircondit7(14);
                yield return new aircondit7(15);
                yield return new aircondit7(22);
                yield return new aircondit7(22);
                yield return new aircondit7(23);
                yield return new aircondit7(30);
                yield return new aircondit7(36);
                yield return new aircondit7(39);
                yield return new aircondit7(44);
                yield return new aircondit7(46);
                yield return new aircondit7(50);
                yield return new aircondit7(72);
                yield return new aircondit7(79);
                yield return new aircondit7(88);
                yield return new aircondit7(97);
                yield return new aircondit7(102);
                yield return new aircondit7(139);
                yield return new aircondit7(188);
                yield return new aircondit7(197);
                yield return new aircondit7(210);
            }
        }
    }
}
