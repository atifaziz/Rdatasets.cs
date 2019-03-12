// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Pulp Fiber and Paper Data
    /// </summary>

    public class pulpfiber
    {
        public readonly int κ;
        public readonly double X1;
        public readonly double X2;
        public readonly double X3;
        public readonly double X4;
        public readonly double Y1;
        public readonly double Y2;
        public readonly double Y3;
        public readonly double Y4;

        public pulpfiber(int κ, double X1, double X2, double X3, double X4, double Y1, double Y2, double Y3, double Y4)
        {
            this.κ = κ;
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.X4 = X4;
            this.Y1 = Y1;
            this.Y2 = Y2;
            this.Y3 = Y3;
            this.Y4 = Y4;
        }

        public static IEnumerable<pulpfiber> Data
        {
            get
            {
                yield return new pulpfiber(1, -0.03, 35.239, 36.991, 1.057, 21.312, 7.039, 5.326, 0.932);
                yield return new pulpfiber(2, 0.015, 35.713, 36.851, 1.064, 21.206, 6.979, 5.237, 0.871);
                yield return new pulpfiber(3, 0.025, 39.22, 30.586, 1.053, 20.709, 6.779, 5.06, 0.742);
                yield return new pulpfiber(4, 0.03, 39.756, 21.072, 1.05, 19.542, 6.601, 4.479, 0.513);
                yield return new pulpfiber(5, -0.07, 32.991, 36.57, 1.049, 20.449, 6.795, 4.912, 0.577);
                yield return new pulpfiber(6, -0.05, 31.14, 38.115, 1.052, 20.841, 6.919, 5.108, 0.784);
                yield return new pulpfiber(7, -0.247, 28.375, 41.364, 1.044, 19.06, 6.447, 4.246, 0.358);
                yield return new pulpfiber(8, -0.099, 32.58, 36.43, 1.038, 18.597, 6.261, 4.032, 0.215);
                yield return new pulpfiber(9, -0.242, 23.889, 49.08, 1.042, 19.346, 6.572, 4.358, 0.432);
                yield return new pulpfiber(10, -0.188, 28.027, 39.243, 1.042, 18.72, 6.455, 4.072, 0.372);
                yield return new pulpfiber(11, -0.099, 33.128, 32.802, 1.052, 18.587, 6.295, 4.068, 0.239);
                yield return new pulpfiber(12, -0.232, 26.492, 40.939, 1.042, 19.813, 6.775, 4.604, 0.637);
                yield return new pulpfiber(13, -0.045, 32.169, 32.524, 1.045, 19.989, 6.737, 4.686, 0.779);
                yield return new pulpfiber(14, 0.055, 35.103, 31.139, 1.042, 19.116, 6.512, 4.299, 0.588);
                yield return new pulpfiber(15, 0.07, 40.893, 21.473, 1.049, 18.769, 6.335, 4.089, 0.47);
                yield return new pulpfiber(16, -0.015, 32.649, 31.554, 1.038, 18.708, 6.271, 3.978, 0.457);
                yield return new pulpfiber(17, -0.109, 27.749, 38.538, 1.036, 19.323, 6.55, 4.404, 0.588);
                yield return new pulpfiber(18, 0, 36.187, 25.927, 1.022, 17.433, 5.948, 3.486, 0.104);
                yield return new pulpfiber(19, -0.193, 34.491, 25.519, 1.047, 19.195, 6.213, 4.3, 0.405);
                yield return new pulpfiber(20, -0.09, 31.827, 29.209, 1.05, 19.436, 6.387, 4.404, 0.519);
                yield return new pulpfiber(21, -0.154, 29.622, 32.385, 1.057, 20.136, 6.725, 4.723, 0.652);
                yield return new pulpfiber(22, -0.154, 35.917, 29.346, 1.033, 16.74, 6.168, 3.201, 0.104);
                yield return new pulpfiber(23, -0.149, 30.658, 35.73, 1.033, 18.589, 6.531, 3.989, 0.336);
                yield return new pulpfiber(24, -0.271, 29.415, 33.775, 1.033, 19.422, 6.615, 4.382, 0.432);
                yield return new pulpfiber(25, 0.243, 51.638, 15.922, 1.099, 24.42, 7.874, 6.999, 1.73);
                yield return new pulpfiber(26, 0.34, 58.686, 9.159, 1.101, 25.288, 8.034, 7.406, 1.873);
                yield return new pulpfiber(27, 0.08, 49.025, 27.7, 1.097, 26.119, 8.222, 7.771, 1.946);
                yield return new pulpfiber(28, 0.131, 46.266, 23.893, 1.076, 23.113, 7.288, 6.329, 1.513);
                yield return new pulpfiber(29, 0.136, 50.333, 17.888, 1.095, 25.209, 7.955, 7.296, 1.792);
                yield return new pulpfiber(30, 0.176, 44.218, 26.88, 1.09, 25.444, 8.045, 7.477, 1.847);
                yield return new pulpfiber(31, 0.151, 43.887, 33.775, 1.082, 23.699, 7.593, 6.609, 1.482);
                yield return new pulpfiber(32, 0.207, 48.894, 23.219, 1.081, 24.303, 7.775, 6.861, 1.583);
                yield return new pulpfiber(33, -0.015, 40.158, 42.074, 1.066, 24.793, 8.123, 7.202, 1.703);
                yield return new pulpfiber(34, 0.126, 54.559, 11.293, 1.089, 23.438, 7.65, 6.457, 1.477);
                yield return new pulpfiber(35, 0.131, 49.025, 17.494, 1.088, 24.197, 7.794, 6.833, 1.583);
                yield return new pulpfiber(36, 0.07, 49.287, 23.354, 1.092, 24.741, 7.996, 7.152, 1.728);
                yield return new pulpfiber(37, 0.156, 45.673, 29.622, 1.07, 24.17, 7.766, 6.846, 1.615);
                yield return new pulpfiber(38, 0.055, 45.475, 21.072, 1.076, 24.174, 7.877, 6.826, 1.692);
                yield return new pulpfiber(39, -0.015, 42.958, 33.636, 1.085, 25.052, 8.287, 7.332, 1.773);
                yield return new pulpfiber(40, 0.09, 48.632, 13.977, 1.07, 23.846, 7.639, 6.615, 1.56);
                yield return new pulpfiber(41, 0.015, 49.025, 18.284, 1.073, 24.822, 8.041, 7.129, 1.721);
                yield return new pulpfiber(42, 0.01, 43.821, 27.29, 1.087, 25.2, 8.27, 7.356, 1.785);
                yield return new pulpfiber(43, 0.131, 46.53, 18.284, 1.069, 23.695, 7.46, 6.567, 1.543);
                yield return new pulpfiber(44, 0, 46.398, 18.416, 1.075, 24.941, 7.929, 7.286, 1.703);
                yield return new pulpfiber(45, -0.099, 44.946, 24.164, 1.078, 25.007, 8.081, 7.287, 1.787);
                yield return new pulpfiber(46, -0.188, 51.898, 19.209, 1.064, 21.183, 7.156, 5.388, 0.924);
                yield return new pulpfiber(47, -0.173, 48.436, 26.88, 1.065, 21.875, 7.336, 5.762, 1.068);
                yield return new pulpfiber(48, -0.227, 47.254, 29.346, 1.066, 22.095, 7.447, 5.79, 1.182);
                yield return new pulpfiber(49, 0.314, 56.627, 2.925, 1.118, 25.166, 7.913, 7.211, 1.813);
                yield return new pulpfiber(50, 0.217, 53.458, 0.511, 1.122, 24.56, 7.854, 7.02, 1.701);
                yield return new pulpfiber(51, 0.381, 60.993, 0, 1.118, 22.007, 8.259, 7.322, 1.169);
                yield return new pulpfiber(52, 0.397, 58.429, 1.147, 1.129, 21.115, 7.913, 6.557, 0.928);
                yield return new pulpfiber(53, 0.289, 56.755, 0.407, 1.113, 26.194, 8.454, 7.816, 2.145);
                yield return new pulpfiber(54, 0.202, 56.111, 0.407, 1.104, 25.674, 8.208, 7.534, 2.046);
                yield return new pulpfiber(55, 0.273, 53.847, 2.023, 1.111, 25.93, 8.1, 7.669, 2.037);
                yield return new pulpfiber(56, 0.558, 63.035, -0.391, 1.113, 21.39, 7.475, 5.294, 0.875);
                yield return new pulpfiber(57, -0.672, 3.448, 76.878, 1.02, 18.441, 6.652, 3.946, 0.14);
                yield return new pulpfiber(58, -0.605, 2.845, 84.554, 1.008, 16.441, 6.315, 2.997, -0.4);
                yield return new pulpfiber(59, -0.694, 1.515, 81.988, 0.998, 16.294, 6.572, 3.017, -0.478);
                yield return new pulpfiber(60, -0.559, 2.054, 8.786, 1.081, 20.289, 7.719, 4.866, 0.239);
                yield return new pulpfiber(61, -0.415, 3.018, 5.855, 1.033, 17.163, 7.086, 3.396, -0.236);
                yield return new pulpfiber(62, -0.324, 17.639, 28.934, 1.07, 20.289, 7.437, 4.859, 0.47);
            }
        }
    }
}
