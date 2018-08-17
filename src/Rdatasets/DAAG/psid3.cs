// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Labour Training Evaluation Data
    /// </summary>

    public class psid3
    {
        public readonly int trt;
        public readonly int age;
        public readonly int educ;
        public readonly int black;
        public readonly int hisp;
        public readonly int marr;
        public readonly int nodeg;
        public readonly double re74;
        public readonly double re75;
        public readonly double re78;

        public psid3(int trt, int age, int educ, int black, int hisp, int marr, int nodeg, double re74, double re75, double re78)
        {
            this.trt = trt;
            this.age = age;
            this.educ = educ;
            this.black = black;
            this.hisp = hisp;
            this.marr = marr;
            this.nodeg = nodeg;
            this.re74 = re74;
            this.re75 = re75;
            this.re78 = re78;
        }

        public static IEnumerable<psid3> Data
        {
            get
            {
                yield return new psid3(0, 46, 6, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 45, 7, 1, 0, 1, 1, 0, 0, 11821.813);
                yield return new psid3(0, 45, 9, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 49, 14, 0, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 53, 6, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 47, 12, 0, 0, 0, 0, 0, 0, 0);
                yield return new psid3(0, 47, 8, 0, 0, 0, 1, 0, 0, 0);
                yield return new psid3(0, 52, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 40, 10, 0, 1, 1, 1, 0, 0, 0);
                yield return new psid3(0, 55, 14, 0, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 54, 3, 1, 0, 0, 1, 0, 0, 221.65899);
                yield return new psid3(0, 50, 12, 1, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 52, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 25, 11, 1, 0, 0, 1, 0, 0, 3694.3164);
                yield return new psid3(0, 46, 9, 0, 1, 1, 1, 0, 0, 0);
                yield return new psid3(0, 48, 9, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 44, 12, 0, 0, 0, 0, 0, 0, 0);
                yield return new psid3(0, 26, 17, 0, 0, 1, 0, 0, 0, 11821.813);
                yield return new psid3(0, 51, 5, 1, 0, 0, 1, 0, 0, 0);
                yield return new psid3(0, 34, 16, 0, 0, 1, 0, 0, 0, 11821.813);
                yield return new psid3(0, 41, 6, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 55, 8, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 46, 9, 0, 1, 1, 1, 0, 0, 0);
                yield return new psid3(0, 55, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 34, 14, 1, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 28, 12, 1, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 54, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 53, 7, 0, 1, 0, 1, 0, 0, 0);
                yield return new psid3(0, 54, 10, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 55, 12, 0, 1, 1, 0, 0, 0, 0);
                yield return new psid3(0, 53, 8, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 47, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 55, 13, 0, 1, 1, 0, 0, 0, 0);
                yield return new psid3(0, 41, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 45, 9, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 54, 3, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 54, 9, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 54, 10, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 53, 4, 1, 0, 0, 1, 0, 0, 0);
                yield return new psid3(0, 25, 12, 1, 0, 0, 0, 0, 0, 0);
                yield return new psid3(0, 54, 3, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 54, 3, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 44, 12, 0, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 51, 4, 1, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 45, 8, 0, 0, 1, 1, 0, 0, 0);
                yield return new psid3(0, 41, 11, 0, 0, 1, 1, 0, 0, 14481.72);
                yield return new psid3(0, 23, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new psid3(0, 50, 12, 1, 0, 1, 0, 0, 0, 0);
                yield return new psid3(0, 23, 11, 1, 0, 0, 1, 0, 0, 0);
                yield return new psid3(0, 23, 12, 1, 0, 0, 0, 0, 0, 4728.725);
                yield return new psid3(0, 21, 13, 0, 0, 0, 0, 0, 692.85484, 2659.9078);
                yield return new psid3(0, 23, 14, 0, 0, 0, 0, 0, 3401.6129, 5319.8157);
                yield return new psid3(0, 25, 12, 1, 0, 1, 0, 0, 21483.871, 1220.6022);
                yield return new psid3(0, 43, 3, 1, 0, 1, 1, 17.633401, 0, 0);
                yield return new psid3(0, 52, 6, 1, 0, 1, 1, 235.11202, 1246.0645, 1477.7266);
                yield return new psid3(0, 54, 8, 0, 0, 1, 1, 293.89002, 537.09677, 295.54531);
                yield return new psid3(0, 52, 7, 1, 0, 0, 1, 293.89002, 5012.9032, 0);
                yield return new psid3(0, 24, 12, 1, 0, 0, 0, 783.70672, 0, 10344.086);
                yield return new psid3(0, 22, 13, 0, 0, 0, 0, 783.70672, 0, 2305.2535);
                yield return new psid3(0, 23, 12, 1, 0, 0, 0, 1077.5967, 3222.5806, 5910.9063);
                yield return new psid3(0, 22, 12, 1, 0, 1, 0, 1269.6049, 0, 0);
                yield return new psid3(0, 24, 17, 0, 0, 1, 0, 1371.4868, 0, 24825.806);
                yield return new psid3(0, 31, 6, 1, 0, 0, 1, 1410.6721, 555, 16059.932);
                yield return new psid3(0, 27, 16, 0, 0, 1, 0, 1469.4501, 1253.2258, 4363.7266);
                yield return new psid3(0, 19, 11, 1, 0, 0, 1, 1567.4134, 0, 0);
                yield return new psid3(0, 35, 9, 1, 0, 0, 1, 1567.4134, 5370.9677, 5910.9063);
                yield return new psid3(0, 21, 12, 1, 0, 0, 0, 1959.2668, 5460.4839, 1152.6267);
                yield return new psid3(0, 22, 12, 1, 0, 1, 0, 2006.2892, 2470.6452, 0);
                yield return new psid3(0, 23, 13, 0, 0, 1, 0, 2155.1935, 5370.9677, 11378.495);
                yield return new psid3(0, 19, 14, 0, 0, 0, 0, 2938.9002, 3222.5806, 0);
                yield return new psid3(0, 40, 4, 1, 0, 0, 1, 2962.4114, 1933.5484, 1034.4086);
                yield return new psid3(0, 22, 9, 1, 0, 0, 1, 3134.8269, 4345.1129, 13299.539);
                yield return new psid3(0, 23, 15, 0, 0, 1, 0, 3320.9572, 2506.4516, 9974.6544);
                yield return new psid3(0, 19, 6, 1, 0, 0, 1, 3526.6802, 0, 0);
                yield return new psid3(0, 27, 15, 0, 0, 1, 0, 3722.6069, 4654.8387, 19210.445);
                yield return new psid3(0, 27, 12, 1, 0, 1, 0, 3918.5336, 1994.4194, 17732.719);
                yield return new psid3(0, 43, 10, 1, 0, 1, 1, 3918.5336, 2148.3871, 0);
                yield return new psid3(0, 20, 12, 0, 0, 0, 0, 4811.9593, 716.12903, 0);
                yield return new psid3(0, 52, 12, 0, 0, 1, 0, 4898.167, 0, 0);
                yield return new psid3(0, 24, 11, 1, 0, 1, 1, 5427.169, 0, 1329.9539);
                yield return new psid3(0, 38, 10, 1, 0, 1, 1, 5877.8004, 0, 0);
                yield return new psid3(0, 24, 9, 1, 0, 0, 1, 5877.8004, 5370.9677, 13299.539);
                yield return new psid3(0, 32, 11, 1, 0, 1, 1, 6524.3585, 0, 930.96774);
                yield return new psid3(0, 22, 13, 0, 0, 0, 0, 6857.4338, 6266.129, 17363.287);
                yield return new psid3(0, 21, 14, 0, 0, 1, 0, 6974.9898, 11407.935, 17141.628);
                yield return new psid3(0, 29, 10, 0, 0, 1, 1, 7347.2505, 0, 0);
                yield return new psid3(0, 54, 12, 0, 0, 1, 0, 7445.2138, 0, 0);
                yield return new psid3(0, 33, 13, 0, 0, 0, 0, 7837.0672, 3580.6452, 16254.992);
                yield return new psid3(0, 27, 11, 1, 0, 1, 1, 7837.0672, 5370.9677, 7388.6329);
                yield return new psid3(0, 21, 11, 1, 0, 1, 1, 8032.9939, 4848.1935, 8570.8141);
                yield return new psid3(0, 54, 6, 1, 0, 1, 1, 8354.3136, 0, 0);
                yield return new psid3(0, 23, 9, 0, 0, 1, 1, 9012.6273, 0, 14777.266);
                yield return new psid3(0, 24, 12, 0, 0, 1, 0, 9371.1731, 2864.5161, 2216.5899);
                yield return new psid3(0, 20, 13, 0, 1, 0, 0, 9404.4807, 0, 8275.2688);
                yield return new psid3(0, 26, 12, 0, 0, 1, 0, 9561.222, 0, 13299.539);
                yield return new psid3(0, 27, 12, 1, 0, 1, 0, 9796.334, 0, 11821.813);
                yield return new psid3(0, 29, 12, 1, 0, 1, 0, 9796.334, 12532.258, 19210.445);
                yield return new psid3(0, 32, 10, 1, 0, 0, 1, 10188.187, 8951.6129, 0);
                yield return new psid3(0, 47, 8, 0, 1, 1, 1, 10286.151, 7161.2903, 1477.7266);
                yield return new psid3(0, 26, 12, 1, 0, 1, 0, 11167.821, 1074.1935, 8866.3594);
                yield return new psid3(0, 43, 12, 0, 0, 1, 0, 11755.601, 0, 295.54531);
                yield return new psid3(0, 34, 11, 1, 0, 0, 1, 11755.601, 2148.3871, 15516.129);
                yield return new psid3(0, 53, 12, 0, 0, 1, 0, 11755.601, 9893.3226, 5172.043);
                yield return new psid3(0, 42, 13, 0, 0, 1, 0, 13701.153, 0, 33987.711);
                yield return new psid3(0, 22, 12, 1, 0, 1, 0, 13714.868, 0, 664.97696);
                yield return new psid3(0, 47, 12, 0, 0, 1, 0, 13714.868, 0, 12560.676);
                yield return new psid3(0, 26, 12, 0, 0, 1, 0, 13714.868, 716.12903, 22904.762);
                yield return new psid3(0, 53, 5, 1, 0, 1, 1, 14008.758, 2660.4194, 11082.949);
                yield return new psid3(0, 54, 8, 0, 1, 1, 1, 14302.648, 0, 8866.3594);
                yield return new psid3(0, 54, 8, 0, 1, 1, 1, 14302.648, 0, 8866.3594);
                yield return new psid3(0, 37, 13, 0, 0, 1, 0, 14694.501, 8951.6129, 17732.719);
                yield return new psid3(0, 49, 8, 0, 1, 0, 1, 15674.134, 1074.1935, 0);
                yield return new psid3(0, 21, 13, 0, 0, 0, 0, 15674.134, 4946.6613, 1733.3733);
                yield return new psid3(0, 18, 10, 0, 1, 1, 1, 15674.134, 10741.935, 20688.172);
                yield return new psid3(0, 54, 12, 0, 0, 1, 0, 15674.134, 25064.516, 0);
                yield return new psid3(0, 54, 12, 0, 0, 1, 0, 15674.134, 25064.516, 0);
                yield return new psid3(0, 53, 4, 1, 0, 1, 1, 16142.399, 984.67742, 0);
                yield return new psid3(0, 45, 4, 0, 1, 1, 1, 16261.914, 28108.065, 28076.805);
                yield return new psid3(0, 25, 12, 0, 0, 1, 0, 16653.768, 12181.355, 17732.719);
                yield return new psid3(0, 46, 10, 0, 1, 1, 1, 17633.401, 10741.935, 5910.9063);
                yield return new psid3(0, 26, 12, 0, 1, 1, 0, 19055.829, 0, 13299.539);
                yield return new psid3(0, 21, 12, 1, 0, 0, 0, 19592.668, 716.12903, 22165.899);
                yield return new psid3(0, 48, 10, 0, 0, 1, 1, 23511.202, 2864.5161, 0);
                yield return new psid3(0, 46, 12, 0, 0, 0, 0, 23918.729, 12532.258, 0);
                yield return new psid3(0, 26, 16, 0, 0, 0, 0, 24490.835, 27750, 9605.2227);
                yield return new psid3(0, 48, 8, 0, 0, 1, 1, 25470.468, 0, 13299.539);
                yield return new psid3(0, 50, 12, 0, 0, 1, 0, 26254.175, 0, 0);
                yield return new psid3(0, 41, 13, 0, 0, 0, 0, 29389.002, 0, 30293.395);
            }
        }
    }
}
