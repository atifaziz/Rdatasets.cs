// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Failures of Air-conditioning Equipment
    /// </summary>

    public class aircondit
    {
        public readonly int hours;

        public aircondit(int hours)
        {
            this.hours = hours;
        }

        public static IEnumerable<aircondit> Data
        {
            get
            {
                yield return new aircondit(3);
                yield return new aircondit(5);
                yield return new aircondit(7);
                yield return new aircondit(18);
                yield return new aircondit(43);
                yield return new aircondit(85);
                yield return new aircondit(91);
                yield return new aircondit(98);
                yield return new aircondit(100);
                yield return new aircondit(130);
                yield return new aircondit(230);
                yield return new aircondit(487);
            }
        }
    }
}
