// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Carbon Monoxide Transfer
    /// </summary>

    public class co_transfer
    {
        public readonly int entry;
        public readonly int week;

        public co_transfer(int entry, int week)
        {
            this.entry = entry;
            this.week = week;
        }

        public static IEnumerable<co_transfer> Data
        {
            get
            {
                yield return new co_transfer(40, 73);
                yield return new co_transfer(50, 52);
                yield return new co_transfer(56, 80);
                yield return new co_transfer(58, 85);
                yield return new co_transfer(60, 64);
                yield return new co_transfer(62, 63);
                yield return new co_transfer(66, 60);
            }
        }
    }
}
