// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Piston Rings Failures
    /// </summary>

    public class pistonrings
    {
        public readonly int κ;
        public readonly string compressor;
        public readonly string leg;
        public readonly int Freq;

        public pistonrings(int κ, string compressor, string leg, int Freq)
        {
            this.κ = κ;
            this.compressor = compressor;
            this.leg = leg;
            this.Freq = Freq;
        }

        public static IEnumerable<pistonrings> Data
        {
            get
            {
                yield return new pistonrings(1, "C1", "North", 17);
                yield return new pistonrings(2, "C2", "North", 11);
                yield return new pistonrings(3, "C3", "North", 11);
                yield return new pistonrings(4, "C4", "North", 14);
                yield return new pistonrings(5, "C1", "Centre", 17);
                yield return new pistonrings(6, "C2", "Centre", 9);
                yield return new pistonrings(7, "C3", "Centre", 8);
                yield return new pistonrings(8, "C4", "Centre", 7);
                yield return new pistonrings(9, "C1", "South", 12);
                yield return new pistonrings(10, "C2", "South", 13);
                yield return new pistonrings(11, "C3", "South", 19);
                yield return new pistonrings(12, "C4", "South", 28);
            }
        }
    }
}
