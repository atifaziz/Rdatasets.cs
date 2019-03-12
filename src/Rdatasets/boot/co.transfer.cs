// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Carbon Monoxide Transfer
    /// </summary>

    public class co_transfer
    {
        public readonly int κ;
        public readonly int entry;
        public readonly int week;

        public co_transfer(int κ, int entry, int week)
        {
            this.κ = κ;
            this.entry = entry;
            this.week = week;
        }

        public static IEnumerable<co_transfer> Data
        {
            get
            {
                yield return new co_transfer(1, 40, 73);
                yield return new co_transfer(2, 50, 52);
                yield return new co_transfer(3, 56, 80);
                yield return new co_transfer(4, 58, 85);
                yield return new co_transfer(5, 60, 64);
                yield return new co_transfer(6, 62, 63);
                yield return new co_transfer(7, 66, 60);
            }
        }
    }
}
