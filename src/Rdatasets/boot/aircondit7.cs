// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Failures of Air-conditioning Equipment
    /// </summary>

    public class aircondit7
    {
        public readonly int κ;
        public readonly int hours;

        public aircondit7(int κ, int hours)
        {
            this.κ = κ;
            this.hours = hours;
        }

        public static IEnumerable<aircondit7> Data
        {
            get
            {
                yield return new aircondit7(1, 3);
                yield return new aircondit7(2, 5);
                yield return new aircondit7(3, 5);
                yield return new aircondit7(4, 13);
                yield return new aircondit7(5, 14);
                yield return new aircondit7(6, 15);
                yield return new aircondit7(7, 22);
                yield return new aircondit7(8, 22);
                yield return new aircondit7(9, 23);
                yield return new aircondit7(10, 30);
                yield return new aircondit7(11, 36);
                yield return new aircondit7(12, 39);
                yield return new aircondit7(13, 44);
                yield return new aircondit7(14, 46);
                yield return new aircondit7(15, 50);
                yield return new aircondit7(16, 72);
                yield return new aircondit7(17, 79);
                yield return new aircondit7(18, 88);
                yield return new aircondit7(19, 97);
                yield return new aircondit7(20, 102);
                yield return new aircondit7(21, 139);
                yield return new aircondit7(22, 188);
                yield return new aircondit7(23, 197);
                yield return new aircondit7(24, 210);
            }
        }
    }
}
