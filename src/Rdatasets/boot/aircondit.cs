// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Failures of Air-conditioning Equipment
    /// </summary>

    public class aircondit
    {
        public readonly int κ;
        public readonly int hours;

        public aircondit(int κ, int hours)
        {
            this.κ = κ;
            this.hours = hours;
        }

        public static IEnumerable<aircondit> Data
        {
            get
            {
                yield return new aircondit(1, 3);
                yield return new aircondit(2, 5);
                yield return new aircondit(3, 7);
                yield return new aircondit(4, 18);
                yield return new aircondit(5, 43);
                yield return new aircondit(6, 85);
                yield return new aircondit(7, 91);
                yield return new aircondit(8, 98);
                yield return new aircondit(9, 100);
                yield return new aircondit(10, 130);
                yield return new aircondit(11, 230);
                yield return new aircondit(12, 487);
            }
        }
    }
}
