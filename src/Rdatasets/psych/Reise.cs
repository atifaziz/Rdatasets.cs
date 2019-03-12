// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Reise
    {
        public readonly string κ;
        public readonly double phone;
        public readonly double routine;
        public readonly double illness;
        public readonly double listen;
        public readonly double explain;
        public readonly double respect;
        public readonly double time;
        public readonly double courtesy;
        public readonly double helpful;
        public readonly double happy;
        public readonly double referral;
        public readonly double necessary;
        public readonly double delay;
        public readonly double problem;
        public readonly double help;
        public readonly double paperwork;

        public Reise(string κ, double phone, double routine, double illness, double listen, double explain, double respect, double time, double courtesy, double helpful, double happy, double referral, double necessary, double delay, double problem, double help, double paperwork)
        {
            this.κ = κ;
            this.phone = phone;
            this.routine = routine;
            this.illness = illness;
            this.listen = listen;
            this.explain = explain;
            this.respect = respect;
            this.time = time;
            this.courtesy = courtesy;
            this.helpful = helpful;
            this.happy = happy;
            this.referral = referral;
            this.necessary = necessary;
            this.delay = delay;
            this.problem = problem;
            this.help = help;
            this.paperwork = paperwork;
        }

        public static IEnumerable<Reise> Data
        {
            get
            {
                yield return new Reise("phone", 1, 0.439269256, 0.424524733, 0.504944562, 0.403807061, 0.482973429, 0.475138818, 0.466447449, 0.515270291, 0.378462903, 0.320931228, 0.418434068, 0.359164412, 0.272578472, 0.288572677, 0.275218186);
                yield return new Reise("routine", 0.439269256, 1, 0.386764474, 0.431826008, 0.35827102, 0.408603703, 0.421149502, 0.405187946, 0.427279685, 0.304473036, 0.250230402, 0.370429919, 0.282120552, 0.226977546, 0.233126091, 0.220631452);
                yield return new Reise("illness", 0.424524733, 0.386764474, 1, 0.435535468, 0.338219473, 0.415547967, 0.408991283, 0.373662628, 0.409400225, 0.338899264, 0.295173627, 0.396206683, 0.328327994, 0.266641972, 0.282105995, 0.26984176);
                yield return new Reise("listen", 0.504944562, 0.431826008, 0.435535468, 1, 0.61849434, 0.765261201, 0.714312068, 0.601085615, 0.652546745, 0.414623991, 0.323990645, 0.481834415, 0.378575079, 0.322527242, 0.310137902, 0.31654971);
                yield return new Reise("explain", 0.403807061, 0.35827102, 0.338219473, 0.61849434, 1, 0.666772683, 0.604127633, 0.487914891, 0.518365531, 0.319810412, 0.257778912, 0.397312177, 0.302195722, 0.260604842, 0.249219507, 0.244622037);
                yield return new Reise("respect", 0.482973429, 0.408603703, 0.415547967, 0.765261201, 0.666772683, 1, 0.716350513, 0.608510696, 0.628801942, 0.405951684, 0.325471471, 0.464847656, 0.359338381, 0.318148039, 0.314066242, 0.308454931);
                yield return new Reise("time", 0.475138818, 0.421149502, 0.408991283, 0.714312068, 0.604127633, 0.716350513, 1, 0.556633048, 0.607791864, 0.385807796, 0.296697998, 0.433948495, 0.347219783, 0.300533301, 0.305021756, 0.297083301);
                yield return new Reise("courtesy", 0.466447449, 0.405187946, 0.373662628, 0.601085615, 0.487914891, 0.608510696, 0.556633048, 1, 0.734961704, 0.355674731, 0.290778304, 0.405586254, 0.334574183, 0.26269303, 0.252147674, 0.266558035);
                yield return new Reise("helpful", 0.515270291, 0.427279685, 0.409400225, 0.652546745, 0.518365531, 0.628801942, 0.607791864, 0.734961704, 1, 0.381469734, 0.31830291, 0.438772593, 0.373236902, 0.283174898, 0.290170265, 0.287370324);
                yield return new Reise("happy", 0.378462903, 0.304473036, 0.338899264, 0.414623991, 0.319810412, 0.405951684, 0.385807796, 0.355674731, 0.381469734, 1, 0.343820948, 0.41583098, 0.382213607, 0.311428104, 0.336824824, 0.309726786);
                yield return new Reise("referral", 0.320931228, 0.250230402, 0.295173627, 0.323990645, 0.257778912, 0.325471471, 0.296697998, 0.290778304, 0.31830291, 0.343820948, 1, 0.442736066, 0.413803796, 0.255748733, 0.28264695, 0.248694599);
                yield return new Reise("necessary", 0.418434068, 0.370429919, 0.396206683, 0.481834415, 0.397312177, 0.464847656, 0.433948495, 0.405586254, 0.438772593, 0.41583098, 0.442736066, 1, 0.565193109, 0.313382719, 0.337841053, 0.287921173);
                yield return new Reise("delay", 0.359164412, 0.282120552, 0.328327994, 0.378575079, 0.302195722, 0.359338381, 0.347219783, 0.334574183, 0.373236902, 0.382213607, 0.413803796, 0.565193109, 1, 0.332990319, 0.380577847, 0.320040982);
                yield return new Reise("problem", 0.272578472, 0.226977546, 0.266641972, 0.322527242, 0.260604842, 0.318148039, 0.300533301, 0.26269303, 0.283174898, 0.311428104, 0.255748733, 0.313382719, 0.332990319, 1, 0.338096618, 0.289874996);
                yield return new Reise("help", 0.288572677, 0.233126091, 0.282105995, 0.310137902, 0.249219507, 0.314066242, 0.305021756, 0.252147674, 0.290170265, 0.336824824, 0.28264695, 0.337841053, 0.380577847, 0.338096618, 1, 0.334238479);
                yield return new Reise("paperwork", 0.275218186, 0.220631452, 0.26984176, 0.31654971, 0.244622037, 0.308454931, 0.297083301, 0.266558035, 0.287370324, 0.309726786, 0.248694599, 0.287921173, 0.320040982, 0.289874996, 0.334238479, 1);
            }
        }
    }
}
