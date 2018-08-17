// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// 9 Cognitive variables discussed by Tucker and Lewis (1973)
    /// </summary>

    public class Tucker
    {
        public readonly double t42;
        public readonly double t54;
        public readonly double t45;
        public readonly double t46;
        public readonly double t23;
        public readonly double t24;
        public readonly double t27;
        public readonly double t10;
        public readonly double t51;

        public Tucker(double t42, double t54, double t45, double t46, double t23, double t24, double t27, double t10, double t51)
        {
            this.t42 = t42;
            this.t54 = t54;
            this.t45 = t45;
            this.t46 = t46;
            this.t23 = t23;
            this.t24 = t24;
            this.t27 = t27;
            this.t10 = t10;
            this.t51 = t51;
        }

        public static IEnumerable<Tucker> Data
        {
            get
            {
                yield return new Tucker(1, 0.554, 0.227, 0.189, 0.461, 0.506, 0.408, 0.28, 0.241);
                yield return new Tucker(0.554, 1, 0.296, 0.219, 0.479, 0.53, 0.425, 0.311, 0.311);
                yield return new Tucker(0.227, 0.296, 1, 0.769, 0.237, 0.243, 0.304, 0.718, 0.73);
                yield return new Tucker(0.189, 0.219, 0.769, 1, 0.212, 0.226, 0.291, 0.681, 0.661);
                yield return new Tucker(0.461, 0.479, 0.237, 0.212, 1, 0.52, 0.514, 0.313, 0.245);
                yield return new Tucker(0.506, 0.53, 0.243, 0.226, 0.52, 1, 0.473, 0.348, 0.29);
                yield return new Tucker(0.408, 0.425, 0.304, 0.291, 0.514, 0.473, 1, 0.374, 0.306);
                yield return new Tucker(0.28, 0.311, 0.718, 0.681, 0.313, 0.348, 0.374, 1, 0.672);
                yield return new Tucker(0.241, 0.311, 0.73, 0.661, 0.245, 0.29, 0.306, 0.672, 1);
            }
        }
    }
}
