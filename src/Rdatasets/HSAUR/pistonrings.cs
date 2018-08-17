// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Piston Rings Failures
    /// </summary>

    public class pistonrings
    {
        public readonly string compressor;
        public readonly string leg;
        public readonly int Freq;

        public pistonrings(string compressor, string leg, int Freq)
        {
            this.compressor = compressor;
            this.leg = leg;
            this.Freq = Freq;
        }

        public static IEnumerable<pistonrings> Data
        {
            get
            {
                yield return new pistonrings("C1", "North", 17);
                yield return new pistonrings("C2", "North", 11);
                yield return new pistonrings("C3", "North", 11);
                yield return new pistonrings("C4", "North", 14);
                yield return new pistonrings("C1", "Centre", 17);
                yield return new pistonrings("C2", "Centre", 9);
                yield return new pistonrings("C3", "Centre", 8);
                yield return new pistonrings("C4", "Centre", 7);
                yield return new pistonrings("C1", "South", 12);
                yield return new pistonrings("C2", "South", 13);
                yield return new pistonrings("C3", "South", 19);
                yield return new pistonrings("C4", "South", 28);
            }
        }
    }
}
