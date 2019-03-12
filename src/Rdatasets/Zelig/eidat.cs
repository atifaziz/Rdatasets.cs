// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Simulation Data for Ecological Inference
    /// </summary>

    public class eidat
    {
        public readonly int κ;
        public readonly int x0;
        public readonly int x1;
        public readonly int t0;
        public readonly int t1;

        public eidat(int κ, int x0, int x1, int t0, int t1)
        {
            this.κ = κ;
            this.x0 = x0;
            this.x1 = x1;
            this.t0 = t0;
            this.t1 = t1;
        }

        public static IEnumerable<eidat> Data
        {
            get
            {
                yield return new eidat(1, 200, 3911, 2850, 1261);
                yield return new eidat(2, 162, 2636, 1541, 1257);
                yield return new eidat(3, 206, 2460, 1091, 1575);
                yield return new eidat(4, 213, 1654, 517, 1350);
                yield return new eidat(5, 209, 637, 163, 683);
                yield return new eidat(6, 190, 1911, 216, 1885);
                yield return new eidat(7, 206, 3460, 226, 3440);
                yield return new eidat(8, 190, 715, 102, 803);
                yield return new eidat(9, 183, 2058, 126, 2115);
                yield return new eidat(10, 189, 2658, 138, 2709);
            }
        }
    }
}
