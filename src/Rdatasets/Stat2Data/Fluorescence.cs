// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Fluorescence
    /// </summary>

    public class Fluorescence
    {
        public readonly int κ;
        public readonly double Calcium;
        public readonly double ProteinProp;

        public Fluorescence(int κ, double Calcium, double ProteinProp)
        {
            this.κ = κ;
            this.Calcium = Calcium;
            this.ProteinProp = ProteinProp;
        }

        public static IEnumerable<Fluorescence> Data
        {
            get
            {
                yield return new Fluorescence(1, -10.14539036, 0.145164202);
                yield return new Fluorescence(2, -9.97798426, 0.223711498);
                yield return new Fluorescence(3, -9.351249787, 0.219828821);
                yield return new Fluorescence(4, -9.101000729, 0.334269431);
                yield return new Fluorescence(5, -9.01376587, 0.378526213);
                yield return new Fluorescence(6, -8.940436582, 0.409369052);
                yield return new Fluorescence(7, -8.578231599, 0.507444972);
                yield return new Fluorescence(8, -8.370182804, 0.57164134);
                yield return new Fluorescence(9, -8.289036881, 0.642186965);
                yield return new Fluorescence(10, -7.959793372, 0.807279963);
                yield return new Fluorescence(11, -7.592269272, 0.930025173);
                yield return new Fluorescence(12, -7.238448011, 0.901409641);
                yield return new Fluorescence(13, -7.038626372, 0.950327606);
                yield return new Fluorescence(14, -6.330776126, 0.957320456);
                yield return new Fluorescence(15, -6.167235695, 0.985104489);
                yield return new Fluorescence(16, -5.556893543, 0.969407033);
                yield return new Fluorescence(17, -5.321208566, 0.999285187);
                yield return new Fluorescence(18, -4.813608784, 1);
                yield return new Fluorescence(19, -10.14539036, 0.188284071);
                yield return new Fluorescence(20, -9.97798426, 0.226840832);
                yield return new Fluorescence(21, -9.351249787, 0.299825094);
                yield return new Fluorescence(22, -9.101000729, 0.351716328);
                yield return new Fluorescence(23, -9.01376587, 0.413916136);
                yield return new Fluorescence(24, -8.940436582, 0.437475476);
                yield return new Fluorescence(25, -8.578231599, 0.526377071);
                yield return new Fluorescence(26, -8.370182804, 0.619739975);
                yield return new Fluorescence(27, -8.289036881, 0.670996494);
                yield return new Fluorescence(28, -7.959793372, 0.844443513);
                yield return new Fluorescence(29, -7.592269272, 0.929812237);
                yield return new Fluorescence(30, -7.238448011, 0.979803174);
                yield return new Fluorescence(31, -7.038626372, 0.974212892);
                yield return new Fluorescence(32, -6.330776126, 0.974230866);
                yield return new Fluorescence(33, -6.167235695, 0.987524724);
                yield return new Fluorescence(34, -5.556893543, 0.998230049);
                yield return new Fluorescence(35, -5.321208566, 1);
                yield return new Fluorescence(36, -4.813608784, 0.995714469);
                yield return new Fluorescence(37, -10.72193267, 0.264766386);
                yield return new Fluorescence(38, -10.44575319, 0.336968113);
                yield return new Fluorescence(39, -9.689731633, 0.401104);
                yield return new Fluorescence(40, -9.047837426, 0.397172676);
                yield return new Fluorescence(41, -8.791558644, 0.535642225);
                yield return new Fluorescence(42, -8.448916135, 0.648687709);
                yield return new Fluorescence(43, -8.08820341, 0.668027433);
                yield return new Fluorescence(44, -7.851397345, 0.805547503);
                yield return new Fluorescence(45, -7.658565475, 0.858684464);
                yield return new Fluorescence(46, -7.482276405, 0.879804722);
                yield return new Fluorescence(47, -7.306448914, 1);
                yield return new Fluorescence(48, -7.115544504, 0.977186242);
                yield return new Fluorescence(49, -6.884056823, 0.965169616);
                yield return new Fluorescence(50, -6.539854183, 0.964522047);
                yield return new Fluorescence(51, -5.86518563, 0.98589626);
            }
        }
    }
}
