// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// 8 cognitive variables used by Dwyer for an example.
    /// </summary>

    public class Dwyer
    {
        public readonly string κ;
        public readonly double V1;
        public readonly double V2;
        public readonly double V3;
        public readonly double V4;
        public readonly double V5;
        public readonly double V6;
        public readonly double V7;
        public readonly double V8;

        public Dwyer(string κ, double V1, double V2, double V3, double V4, double V5, double V6, double V7, double V8)
        {
            this.κ = κ;
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
            this.V6 = V6;
            this.V7 = V7;
            this.V8 = V8;
        }

        public static IEnumerable<Dwyer> Data
        {
            get
            {
                yield return new Dwyer("V1", 1, 0.58, -0.28, 0.01, 0.36, 0.38, 0.61, 0.15);
                yield return new Dwyer("V2", 0.58, 1, -0.28, 0.1, 0.52, 0.44, 0.78, 0.1);
                yield return new Dwyer("V3", -0.28, -0.28, 1, 0.56, 0.14, -0.56, -0.42, -0.7);
                yield return new Dwyer("V4", 0.01, 0.1, 0.56, 1, 0.4, -0.34, -0.03, -0.65);
                yield return new Dwyer("V5", 0.36, 0.52, 0.14, 0.4, 1, 0.08, 0.46, -0.3);
                yield return new Dwyer("V6", 0.38, 0.44, -0.56, -0.34, 0.08, 1, 0.54, 0.5);
                yield return new Dwyer("V7", 0.61, 0.78, -0.42, -0.03, 0.46, 0.54, 1, 0.25);
                yield return new Dwyer("V8", 0.15, 0.1, -0.7, -0.65, -0.3, 0.5, 0.25, 1);
            }
        }
    }
}
