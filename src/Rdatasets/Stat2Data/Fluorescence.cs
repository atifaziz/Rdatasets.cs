// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Fluorescence
    /// </summary>

    public class Fluorescence
    {
        public readonly double Calcium;
        public readonly double ProteinProp;

        public Fluorescence(double Calcium, double ProteinProp)
        {
            this.Calcium = Calcium;
            this.ProteinProp = ProteinProp;
        }

        public static IEnumerable<Fluorescence> Data
        {
            get
            {
                yield return new Fluorescence(-10.14539036, 0.145164202);
                yield return new Fluorescence(-9.97798426, 0.223711498);
                yield return new Fluorescence(-9.351249787, 0.219828821);
                yield return new Fluorescence(-9.101000729, 0.334269431);
                yield return new Fluorescence(-9.01376587, 0.378526213);
                yield return new Fluorescence(-8.940436582, 0.409369052);
                yield return new Fluorescence(-8.578231599, 0.507444972);
                yield return new Fluorescence(-8.370182804, 0.57164134);
                yield return new Fluorescence(-8.289036881, 0.642186965);
                yield return new Fluorescence(-7.959793372, 0.807279963);
                yield return new Fluorescence(-7.592269272, 0.930025173);
                yield return new Fluorescence(-7.238448011, 0.901409641);
                yield return new Fluorescence(-7.038626372, 0.950327606);
                yield return new Fluorescence(-6.330776126, 0.957320456);
                yield return new Fluorescence(-6.167235695, 0.985104489);
                yield return new Fluorescence(-5.556893543, 0.969407033);
                yield return new Fluorescence(-5.321208566, 0.999285187);
                yield return new Fluorescence(-4.813608784, 1);
                yield return new Fluorescence(-10.14539036, 0.188284071);
                yield return new Fluorescence(-9.97798426, 0.226840832);
                yield return new Fluorescence(-9.351249787, 0.299825094);
                yield return new Fluorescence(-9.101000729, 0.351716328);
                yield return new Fluorescence(-9.01376587, 0.413916136);
                yield return new Fluorescence(-8.940436582, 0.437475476);
                yield return new Fluorescence(-8.578231599, 0.526377071);
                yield return new Fluorescence(-8.370182804, 0.619739975);
                yield return new Fluorescence(-8.289036881, 0.670996494);
                yield return new Fluorescence(-7.959793372, 0.844443513);
                yield return new Fluorescence(-7.592269272, 0.929812237);
                yield return new Fluorescence(-7.238448011, 0.979803174);
                yield return new Fluorescence(-7.038626372, 0.974212892);
                yield return new Fluorescence(-6.330776126, 0.974230866);
                yield return new Fluorescence(-6.167235695, 0.987524724);
                yield return new Fluorescence(-5.556893543, 0.998230049);
                yield return new Fluorescence(-5.321208566, 1);
                yield return new Fluorescence(-4.813608784, 0.995714469);
                yield return new Fluorescence(-10.72193267, 0.264766386);
                yield return new Fluorescence(-10.44575319, 0.336968113);
                yield return new Fluorescence(-9.689731633, 0.401104);
                yield return new Fluorescence(-9.047837426, 0.397172676);
                yield return new Fluorescence(-8.791558644, 0.535642225);
                yield return new Fluorescence(-8.448916135, 0.648687709);
                yield return new Fluorescence(-8.08820341, 0.668027433);
                yield return new Fluorescence(-7.851397345, 0.805547503);
                yield return new Fluorescence(-7.658565475, 0.858684464);
                yield return new Fluorescence(-7.482276405, 0.879804722);
                yield return new Fluorescence(-7.306448914, 1);
                yield return new Fluorescence(-7.115544504, 0.977186242);
                yield return new Fluorescence(-6.884056823, 0.965169616);
                yield return new Fluorescence(-6.539854183, 0.964522047);
                yield return new Fluorescence(-5.86518563, 0.98589626);
            }
        }
    }
}
