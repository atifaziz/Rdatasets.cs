// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Water Voles Data
    /// </summary>

    public class watervoles
    {
        public readonly double Surrey;
        public readonly double Shropshire;
        public readonly double Yorkshire;
        public readonly double Perthshire;
        public readonly double Aberdeen;
        public readonly double Elean_Gamhna;
        public readonly double Alps;
        public readonly double Yugoslavia;
        public readonly double Germany;
        public readonly double Norway;
        public readonly double Pyrenees_I;
        public readonly double Pyrenees_II;
        public readonly double North_Spain;
        public readonly double South_Spain;

        public watervoles(double Surrey, double Shropshire, double Yorkshire, double Perthshire, double Aberdeen, double Elean_Gamhna, double Alps, double Yugoslavia, double Germany, double Norway, double Pyrenees_I, double Pyrenees_II, double North_Spain, double South_Spain)
        {
            this.Surrey = Surrey;
            this.Shropshire = Shropshire;
            this.Yorkshire = Yorkshire;
            this.Perthshire = Perthshire;
            this.Aberdeen = Aberdeen;
            this.Elean_Gamhna = Elean_Gamhna;
            this.Alps = Alps;
            this.Yugoslavia = Yugoslavia;
            this.Germany = Germany;
            this.Norway = Norway;
            this.Pyrenees_I = Pyrenees_I;
            this.Pyrenees_II = Pyrenees_II;
            this.North_Spain = North_Spain;
            this.South_Spain = South_Spain;
        }

        public static IEnumerable<watervoles> Data
        {
            get
            {
                yield return new watervoles(0, 0.099, 0.033, 0.183, 0.148, 0.198, 0.462, 0.628, 0.113, 0.173, 0.434, 0.762, 0.53, 0.586);
                yield return new watervoles(0.099, 0, 0.022, 0.114, 0.224, 0.039, 0.266, 0.442, 0.07, 0.119, 0.419, 0.633, 0.389, 0.435);
                yield return new watervoles(0.033, 0.022, 0, 0.042, 0.059, 0.053, 0.322, 0.444, 0.046, 0.162, 0.339, 0.781, 0.482, 0.55);
                yield return new watervoles(0.183, 0.114, 0.042, 0, 0.068, 0.085, 0.435, 0.406, 0.047, 0.331, 0.505, 0.7, 0.579, 0.53);
                yield return new watervoles(0.148, 0.224, 0.059, 0.068, 0, 0.051, 0.268, 0.24, 0.034, 0.177, 0.469, 0.758, 0.597, 0.552);
                yield return new watervoles(0.198, 0.039, 0.053, 0.085, 0.051, 0, 0.025, 0.129, 0.002, 0.039, 0.39, 0.625, 0.498, 0.509);
                yield return new watervoles(0.462, 0.266, 0.322, 0.435, 0.268, 0.025, 0, 0.014, 0.106, 0.089, 0.315, 0.469, 0.374, 0.369);
                yield return new watervoles(0.628, 0.442, 0.444, 0.406, 0.24, 0.129, 0.014, 0, 0.129, 0.237, 0.349, 0.618, 0.562, 0.471);
                yield return new watervoles(0.113, 0.07, 0.046, 0.047, 0.034, 0.002, 0.106, 0.129, 0, 0.071, 0.151, 0.44, 0.247, 0.234);
                yield return new watervoles(0.173, 0.119, 0.162, 0.331, 0.177, 0.039, 0.089, 0.237, 0.071, 0, 0.43, 0.538, 0.383, 0.346);
                yield return new watervoles(0.434, 0.419, 0.339, 0.505, 0.469, 0.39, 0.315, 0.349, 0.151, 0.43, 0, 0.607, 0.387, 0.456);
                yield return new watervoles(0.762, 0.633, 0.781, 0.7, 0.758, 0.625, 0.469, 0.618, 0.44, 0.538, 0.607, 0, 0.084, 0.09);
                yield return new watervoles(0.53, 0.389, 0.482, 0.579, 0.597, 0.498, 0.374, 0.562, 0.247, 0.383, 0.387, 0.084, 0, 0.038);
                yield return new watervoles(0.586, 0.435, 0.55, 0.53, 0.552, 0.509, 0.369, 0.471, 0.234, 0.346, 0.456, 0.09, 0.038, 0);
            }
        }
    }
}
