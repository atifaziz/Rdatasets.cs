// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Holzinger
    {
        public readonly double T1;
        public readonly double T2;
        public readonly double T3_4;
        public readonly double T6;
        public readonly double T28;
        public readonly double T29;
        public readonly double T32;
        public readonly double T34;
        public readonly double T35;
        public readonly double T36a;
        public readonly double T13;
        public readonly double T18;
        public readonly double T25b;
        public readonly double T77;

        public Holzinger(double T1, double T2, double T3_4, double T6, double T28, double T29, double T32, double T34, double T35, double T36a, double T13, double T18, double T25b, double T77)
        {
            this.T1 = T1;
            this.T2 = T2;
            this.T3_4 = T3_4;
            this.T6 = T6;
            this.T28 = T28;
            this.T29 = T29;
            this.T32 = T32;
            this.T34 = T34;
            this.T35 = T35;
            this.T36a = T36a;
            this.T13 = T13;
            this.T18 = T18;
            this.T25b = T25b;
            this.T77 = T77;
        }

        public static IEnumerable<Holzinger> Data
        {
            get
            {
                yield return new Holzinger(1, 0.514, 0.477, 0.433, 0.424, 0.35, 0.083, 0.239, 0.14, 0.286, 0.305, 0.26, 0.231, 0.25);
                yield return new Holzinger(0.514, 1, 0.662, 0.497, 0.397, 0.427, 0.152, 0.254, 0.083, 0.368, 0.545, 0.526, 0.437, 0.426);
                yield return new Holzinger(0.477, 0.662, 1, 0.415, 0.319, 0.376, 0.173, 0.172, 0.137, 0.229, 0.482, 0.373, 0.424, 0.368);
                yield return new Holzinger(0.433, 0.497, 0.415, 1, 0.444, 0.53, 0.064, 0.371, 0.214, 0.394, 0.354, 0.348, 0.31, 0.279);
                yield return new Holzinger(0.424, 0.397, 0.319, 0.444, 1, 0.437, 0.027, 0.211, 0.139, 0.267, 0.262, 0.193, 0.16, 0.189);
                yield return new Holzinger(0.35, 0.427, 0.376, 0.53, 0.437, 1, 0.018, 0.224, 0.066, 0.34, 0.349, 0.368, 0.245, 0.273);
                yield return new Holzinger(0.083, 0.152, 0.173, 0.064, 0.027, 0.018, 1, 0.264, 0.203, 0.191, 0.166, 0.115, 0.129, 0.133);
                yield return new Holzinger(0.239, 0.254, 0.172, 0.371, 0.211, 0.224, 0.264, 1, 0.334, 0.442, 0.202, 0.159, 0.053, 0.039);
                yield return new Holzinger(0.14, 0.083, 0.137, 0.214, 0.139, 0.066, 0.203, 0.334, 1, 0.234, 0.007, -0.014, -0.03, -0.037);
                yield return new Holzinger(0.286, 0.368, 0.229, 0.394, 0.267, 0.34, 0.191, 0.442, 0.234, 1, 0.36, 0.372, 0.235, 0.241);
                yield return new Holzinger(0.305, 0.545, 0.482, 0.354, 0.262, 0.349, 0.166, 0.202, 0.007, 0.36, 1, 0.677, 0.603, 0.586);
                yield return new Holzinger(0.26, 0.526, 0.373, 0.348, 0.193, 0.368, 0.115, 0.159, -0.014, 0.372, 0.677, 1, 0.596, 0.613);
                yield return new Holzinger(0.231, 0.437, 0.424, 0.31, 0.16, 0.245, 0.129, 0.053, -0.03, 0.235, 0.603, 0.596, 1, 0.559);
                yield return new Holzinger(0.25, 0.426, 0.368, 0.279, 0.189, 0.273, 0.133, 0.039, -0.037, 0.241, 0.586, 0.613, 0.559, 1);
            }
        }
    }
}
