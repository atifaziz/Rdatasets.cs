// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on Petroleum Rock Samples
    /// </summary>

    public class rock
    {
        public readonly int area;
        public readonly double peri;
        public readonly double shape;
        public readonly double perm;

        public rock(int area, double peri, double shape, double perm)
        {
            this.area = area;
            this.peri = peri;
            this.shape = shape;
            this.perm = perm;
        }

        public static IEnumerable<rock> Data
        {
            get
            {
                yield return new rock(4990, 2791.9, 0.0903296, 6.3);
                yield return new rock(7002, 3892.6, 0.148622, 6.3);
                yield return new rock(7558, 3930.66, 0.183312, 6.3);
                yield return new rock(7352, 3869.32, 0.117063, 6.3);
                yield return new rock(7943, 3948.54, 0.122417, 17.1);
                yield return new rock(7979, 4010.15, 0.167045, 17.1);
                yield return new rock(9333, 4345.75, 0.189651, 17.1);
                yield return new rock(8209, 4344.75, 0.164127, 17.1);
                yield return new rock(8393, 3682.04, 0.203654, 119);
                yield return new rock(6425, 3098.65, 0.162394, 119);
                yield return new rock(9364, 4480.05, 0.150944, 119);
                yield return new rock(8624, 3986.24, 0.148141, 119);
                yield return new rock(10651, 4036.54, 0.228595, 82.4);
                yield return new rock(8868, 3518.04, 0.231623, 82.4);
                yield return new rock(9417, 3999.37, 0.172567, 82.4);
                yield return new rock(8874, 3629.07, 0.153481, 82.4);
                yield return new rock(10962, 4608.66, 0.204314, 58.6);
                yield return new rock(10743, 4787.62, 0.262727, 58.6);
                yield return new rock(11878, 4864.22, 0.200071, 58.6);
                yield return new rock(9867, 4479.41, 0.14481, 58.6);
                yield return new rock(7838, 3428.74, 0.113852, 142);
                yield return new rock(11876, 4353.14, 0.291029, 142);
                yield return new rock(12212, 4697.65, 0.240077, 142);
                yield return new rock(8233, 3518.44, 0.161865, 142);
                yield return new rock(6360, 1977.39, 0.280887, 740);
                yield return new rock(4193, 1379.35, 0.179455, 740);
                yield return new rock(7416, 1916.24, 0.191802, 740);
                yield return new rock(5246, 1585.42, 0.133083, 740);
                yield return new rock(6509, 1851.21, 0.225214, 890);
                yield return new rock(4895, 1239.66, 0.341273, 890);
                yield return new rock(6775, 1728.14, 0.311646, 890);
                yield return new rock(7894, 1461.06, 0.276016, 890);
                yield return new rock(5980, 1426.76, 0.197653, 950);
                yield return new rock(5318, 990.388, 0.326635, 950);
                yield return new rock(7392, 1350.76, 0.154192, 950);
                yield return new rock(7894, 1461.06, 0.276016, 950);
                yield return new rock(3469, 1376.7, 0.176969, 100);
                yield return new rock(1468, 476.322, 0.438712, 100);
                yield return new rock(3524, 1189.46, 0.163586, 100);
                yield return new rock(5267, 1644.96, 0.253832, 100);
                yield return new rock(5048, 941.543, 0.328641, 1300);
                yield return new rock(1016, 308.642, 0.230081, 1300);
                yield return new rock(5605, 1145.69, 0.464125, 1300);
                yield return new rock(8793, 2280.49, 0.420477, 1300);
                yield return new rock(3475, 1174.11, 0.200744, 580);
                yield return new rock(1651, 597.808, 0.262651, 580);
                yield return new rock(5514, 1455.88, 0.182453, 580);
                yield return new rock(9718, 1485.58, 0.200447, 580);
            }
        }
    }
}
