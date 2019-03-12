// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Isotopic Composition Plutonium Batches
    /// </summary>

    public class pluton
    {
        public readonly int κ;
        public readonly double Pu238;
        public readonly double Pu239;
        public readonly double Pu240;
        public readonly double Pu241;

        public pluton(int κ, double Pu238, double Pu239, double Pu240, double Pu241)
        {
            this.κ = κ;
            this.Pu238 = Pu238;
            this.Pu239 = Pu239;
            this.Pu240 = Pu240;
            this.Pu241 = Pu241;
        }

        public static IEnumerable<pluton> Data
        {
            get
            {
                yield return new pluton(1, 0.126, 75.804, 21.204, 2.18);
                yield return new pluton(2, 0.133, 75.515, 21.408, 2.24);
                yield return new pluton(3, 0.127, 75.175, 21.668, 2.305);
                yield return new pluton(4, 0.156, 78.872, 18.428, 1.906);
                yield return new pluton(5, 0.503, 73.317, 20.223, 4.128);
                yield return new pluton(6, 0.113, 79.116, 18.548, 1.69);
                yield return new pluton(7, 0.129, 75.751, 21.162, 2.26);
                yield return new pluton(8, 0.124, 75.326, 21.557, 2.282);
                yield return new pluton(9, 1.022, 63.287, 24.493, 6.99);
                yield return new pluton(10, 1.412, 59.553, 25.576, 8.027);
                yield return new pluton(11, 1.533, 58.688, 25.719, 8.279);
                yield return new pluton(12, 1.534, 58.758, 25.692, 8.261);
                yield return new pluton(13, 1.437, 59.728, 25.146, 8.377);
                yield return new pluton(14, 1.439, 59.544, 25.126, 8.569);
                yield return new pluton(15, 1.375, 59.877, 25.128, 8.428);
                yield return new pluton(16, 1.153, 61.182, 25.1, 7.802);
                yield return new pluton(17, 0.201, 78.244, 18.488, 2.351);
                yield return new pluton(18, 0.176, 78.166, 18.629, 2.365);
                yield return new pluton(19, 0.239, 74.254, 21.515, 2.901);
                yield return new pluton(20, 0.102, 79.84, 17.872, 1.674);
                yield return new pluton(21, 1.07, 62.455, 24.656, 7.512);
                yield return new pluton(22, 0.851, 73.189, 18.285, 5.597);
                yield return new pluton(23, 0.125, 75.968, 20.794, 2.407);
                yield return new pluton(24, 0.142, 75.957, 20.867, 2.341);
                yield return new pluton(25, 0.352, 72.885, 21.718, 3.618);
                yield return new pluton(26, 0.351, 72.907, 21.721, 3.601);
                yield return new pluton(27, 0.346, 72.919, 21.713, 3.6);
                yield return new pluton(28, 0.217, 76.089, 20.225, 2.556);
                yield return new pluton(29, 1.068, 70.129, 18.573, 7.689);
                yield return new pluton(30, 1.171, 69.273, 18.633, 8.3);
                yield return new pluton(31, 1.213, 69.147, 18.64, 8.363);
                yield return new pluton(32, 1.226, 68.294, 18.869, 8.826);
                yield return new pluton(33, 1.111, 71.076, 18.122, 7.248);
                yield return new pluton(34, 0.183, 75.714, 20.75, 2.488);
                yield return new pluton(35, 0.162, 76.15, 20.345, 2.524);
                yield return new pluton(36, 0.113, 77.845, 19.108, 2.275);
                yield return new pluton(37, 1.309, 62.382, 22.754, 9.311);
                yield return new pluton(38, 1.638, 60.112, 23.32, 9.972);
                yield return new pluton(39, 1.589, 60.519, 23.128, 9.97);
                yield return new pluton(40, 1.411, 61.585, 23.133, 9.339);
                yield return new pluton(41, 1.457, 61.332, 23.239, 9.321);
                yield return new pluton(42, 0.397, 72.291, 21.761, 3.836);
                yield return new pluton(43, 0.328, 73.451, 21.429, 3.419);
                yield return new pluton(44, 0.242, 74.888, 20.939, 2.875);
                yield return new pluton(45, 1.367, 60.507, 23.603, 9.839);
            }
        }
    }
}
