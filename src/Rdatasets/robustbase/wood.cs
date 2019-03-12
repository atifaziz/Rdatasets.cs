// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Modified Data on Wood Specific Gravity
    /// </summary>

    public class wood
    {
        public readonly int κ;
        public readonly double x1;
        public readonly double x2;
        public readonly double x3;
        public readonly double x4;
        public readonly double x5;
        public readonly double y;

        public wood(int κ, double x1, double x2, double x3, double x4, double x5, double y)
        {
            this.κ = κ;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.y = y;
        }

        public static IEnumerable<wood> Data
        {
            get
            {
                yield return new wood(1, 0.573, 0.1059, 0.465, 0.538, 0.841, 0.534);
                yield return new wood(2, 0.651, 0.1356, 0.527, 0.545, 0.887, 0.535);
                yield return new wood(3, 0.606, 0.1273, 0.494, 0.521, 0.92, 0.57);
                yield return new wood(4, 0.437, 0.1591, 0.446, 0.423, 0.992, 0.45);
                yield return new wood(5, 0.547, 0.1135, 0.531, 0.519, 0.915, 0.548);
                yield return new wood(6, 0.444, 0.1628, 0.429, 0.411, 0.984, 0.431);
                yield return new wood(7, 0.489, 0.1231, 0.562, 0.455, 0.824, 0.481);
                yield return new wood(8, 0.413, 0.1673, 0.418, 0.43, 0.978, 0.423);
                yield return new wood(9, 0.536, 0.1182, 0.592, 0.464, 0.854, 0.475);
                yield return new wood(10, 0.685, 0.1564, 0.631, 0.564, 0.914, 0.486);
                yield return new wood(11, 0.664, 0.1588, 0.506, 0.481, 0.867, 0.554);
                yield return new wood(12, 0.703, 0.1335, 0.519, 0.484, 0.812, 0.519);
                yield return new wood(13, 0.653, 0.1395, 0.625, 0.519, 0.892, 0.492);
                yield return new wood(14, 0.586, 0.1114, 0.505, 0.565, 0.889, 0.517);
                yield return new wood(15, 0.534, 0.1143, 0.521, 0.57, 0.889, 0.502);
                yield return new wood(16, 0.523, 0.132, 0.505, 0.612, 0.919, 0.508);
                yield return new wood(17, 0.58, 0.1249, 0.546, 0.608, 0.954, 0.52);
                yield return new wood(18, 0.448, 0.1028, 0.522, 0.534, 0.918, 0.506);
                yield return new wood(19, 0.417, 0.1687, 0.405, 0.415, 0.981, 0.401);
                yield return new wood(20, 0.528, 0.1057, 0.424, 0.566, 0.909, 0.568);
            }
        }
    }
}
