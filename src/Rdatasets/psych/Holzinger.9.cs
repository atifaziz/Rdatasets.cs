// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Holzinger_9
    {
        public readonly double vis_perc;
        public readonly double cubes;
        public readonly double lozenges;
        public readonly double par_comp;
        public readonly double sen_comp;
        public readonly double wordmean;
        public readonly double addition;
        public readonly double count_dot;
        public readonly double s_c_caps;

        public Holzinger_9(double vis_perc, double cubes, double lozenges, double par_comp, double sen_comp, double wordmean, double addition, double count_dot, double s_c_caps)
        {
            this.vis_perc = vis_perc;
            this.cubes = cubes;
            this.lozenges = lozenges;
            this.par_comp = par_comp;
            this.sen_comp = sen_comp;
            this.wordmean = wordmean;
            this.addition = addition;
            this.count_dot = count_dot;
            this.s_c_caps = s_c_caps;
        }

        public static IEnumerable<Holzinger_9> Data
        {
            get
            {
                yield return new Holzinger_9(1, 0.3258, 0.44864, 0.34163, 0.3091, 0.31713, 0.10419, 0.3076, 0.48683);
                yield return new Holzinger_9(0.3258, 1, 0.41701, 0.228, 0.15948, 0.19465, 0.066362, 0.16796, 0.24786);
                yield return new Holzinger_9(0.44864, 0.41701, 1, 0.32795, 0.28685, 0.34727, 0.074638, 0.23857, 0.37258);
                yield return new Holzinger_9(0.34163, 0.228, 0.32795, 1, 0.71861, 0.71447, 0.20885, 0.10381, 0.31444);
                yield return new Holzinger_9(0.3091, 0.15948, 0.28685, 0.71861, 1, 0.68528, 0.25386, 0.19784, 0.3556);
                yield return new Holzinger_9(0.31713, 0.19465, 0.34727, 0.71447, 0.68528, 1, 0.17866, 0.12114, 0.27177);
                yield return new Holzinger_9(0.10419, 0.066362, 0.074638, 0.20885, 0.25386, 0.17866, 1, 0.58706, 0.41831);
                yield return new Holzinger_9(0.3076, 0.16796, 0.23857, 0.10381, 0.19784, 0.12114, 0.58706, 1, 0.52835);
                yield return new Holzinger_9(0.48683, 0.24786, 0.37258, 0.31444, 0.3556, 0.27177, 0.41831, 0.52835, 1);
            }
        }
    }
}
