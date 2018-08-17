// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// 12 variables created by Schmid and Leiman to show the Schmid-Leiman Transformation
    /// </summary>

    public class Schmid
    {
        public readonly double V1;
        public readonly double V2;
        public readonly double V3;
        public readonly double V4;
        public readonly double V5;
        public readonly double V6;
        public readonly double V7;
        public readonly double V8;
        public readonly double V9;
        public readonly double V10;
        public readonly double V11;
        public readonly double V12;

        public Schmid(double V1, double V2, double V3, double V4, double V5, double V6, double V7, double V8, double V9, double V10, double V11, double V12)
        {
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
            this.V6 = V6;
            this.V7 = V7;
            this.V8 = V8;
            this.V9 = V9;
            this.V10 = V10;
            this.V11 = V11;
            this.V12 = V12;
        }

        public static IEnumerable<Schmid> Data
        {
            get
            {
                yield return new Schmid(1, 0.72, 0.3136, 0.2688, 0.0983, 0.0491, 0.129, 0.0369, 0.2903, 0.1613, 0.0645, 0.0753);
                yield return new Schmid(0.72, 1, 0.3528, 0.3024, 0.1106, 0.0553, 0.1452, 0.0415, 0.3266, 0.1814, 0.0726, 0.0847);
                yield return new Schmid(0.3136, 0.3528, 1, 0.42, 0.0753, 0.0377, 0.0988, 0.0282, 0.2222, 0.1235, 0.0494, 0.0576);
                yield return new Schmid(0.2688, 0.3024, 0.42, 1, 0.0645, 0.0323, 0.0847, 0.0242, 0.1905, 0.1058, 0.0424, 0.0494);
                yield return new Schmid(0.0983, 0.1106, 0.0753, 0.0645, 1, 0.32, 0.1344, 0.0384, 0.1089, 0.0605, 0.0242, 0.0282);
                yield return new Schmid(0.0491, 0.0553, 0.0377, 0.0323, 0.32, 1, 0.0672, 0.0192, 0.0544, 0.0302, 0.0121, 0.0141);
                yield return new Schmid(0.129, 0.1452, 0.0988, 0.0847, 0.1344, 0.0672, 1, 0.14, 0.1429, 0.0794, 0.0318, 0.037);
                yield return new Schmid(0.0369, 0.0415, 0.0282, 0.0242, 0.0384, 0.0192, 0.14, 1, 0.0408, 0.0227, 0.0091, 0.0106);
                yield return new Schmid(0.2903, 0.3266, 0.2222, 0.1905, 0.1089, 0.0544, 0.1429, 0.0408, 1, 0.45, 0.1458, 0.1701);
                yield return new Schmid(0.1613, 0.1814, 0.1235, 0.1058, 0.0605, 0.0302, 0.0794, 0.0227, 0.45, 1, 0.081, 0.0945);
                yield return new Schmid(0.0645, 0.0726, 0.0494, 0.0424, 0.0242, 0.0121, 0.0318, 0.0091, 0.1458, 0.081, 1, 0.42);
                yield return new Schmid(0.0753, 0.0847, 0.0576, 0.0494, 0.0282, 0.0141, 0.037, 0.0106, 0.1701, 0.0945, 0.42, 1);
            }
        }
    }
}
