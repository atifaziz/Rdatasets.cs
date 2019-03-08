// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Performance of decontaminants used in the culturing of a micro-organism
    /// </summary>

    public class decontaminants
    {
        public readonly double conc;
        public readonly int count;
        public readonly string group;

        public decontaminants(double conc, int count, string group)
        {
            this.conc = conc;
            this.count = count;
            this.group = group;
        }

        public static IEnumerable<decontaminants> Data
        {
            get
            {
                yield return new decontaminants(0.75, 2, "hpc");
                yield return new decontaminants(0.75, 4, "hpc");
                yield return new decontaminants(0.75, 8, "hpc");
                yield return new decontaminants(0.75, 9, "hpc");
                yield return new decontaminants(0.75, 10, "hpc");
                yield return new decontaminants(0.75, 1, "hpc");
                yield return new decontaminants(0.75, 0, "hpc");
                yield return new decontaminants(0.75, 5, "hpc");
                yield return new decontaminants(0.75, 14, "hpc");
                yield return new decontaminants(0.75, 7, "hpc");
                yield return new decontaminants(0.375, 11, "hpc");
                yield return new decontaminants(0.375, 12, "hpc");
                yield return new decontaminants(0.375, 13, "hpc");
                yield return new decontaminants(0.375, 12, "hpc");
                yield return new decontaminants(0.375, 11, "hpc");
                yield return new decontaminants(0.375, 13, "hpc");
                yield return new decontaminants(0.375, 17, "hpc");
                yield return new decontaminants(0.375, 16, "hpc");
                yield return new decontaminants(0.375, 21, "hpc");
                yield return new decontaminants(0.375, 2, "hpc");
                yield return new decontaminants(0.1875, 16, "hpc");
                yield return new decontaminants(0.1875, 6, "hpc");
                yield return new decontaminants(0.1875, 20, "hpc");
                yield return new decontaminants(0.1875, 23, "hpc");
                yield return new decontaminants(0.1875, 23, "hpc");
                yield return new decontaminants(0.1875, 39, "hpc");
                yield return new decontaminants(0.1875, 18, "hpc");
                yield return new decontaminants(0.1875, 23, "hpc");
                yield return new decontaminants(0.1875, 33, "hpc");
                yield return new decontaminants(0.1875, 21, "hpc");
                yield return new decontaminants(0.09375, 33, "hpc");
                yield return new decontaminants(0.09375, 46, "hpc");
                yield return new decontaminants(0.09375, 42, "hpc");
                yield return new decontaminants(0.09375, 18, "hpc");
                yield return new decontaminants(0.09375, 35, "hpc");
                yield return new decontaminants(0.09375, 20, "hpc");
                yield return new decontaminants(0.09375, 19, "hpc");
                yield return new decontaminants(0.09375, 29, "hpc");
                yield return new decontaminants(0.09375, 41, "hpc");
                yield return new decontaminants(0.09375, 36, "hpc");
                yield return new decontaminants(0.075, 30, "hpc");
                yield return new decontaminants(0.075, 30, "hpc");
                yield return new decontaminants(0.075, 27, "hpc");
                yield return new decontaminants(0.075, 53, "hpc");
                yield return new decontaminants(0.075, 51, "hpc");
                yield return new decontaminants(0.075, 39, "hpc");
                yield return new decontaminants(0.075, 31, "hpc");
                yield return new decontaminants(0.075, 36, "hpc");
                yield return new decontaminants(0.075, 38, "hpc");
                yield return new decontaminants(0.075, 22, "hpc");
                yield return new decontaminants(0.0075, 53, "hpc");
                yield return new decontaminants(0.0075, 62, "hpc");
                yield return new decontaminants(0.0075, 38, "hpc");
                yield return new decontaminants(0.0075, 54, "hpc");
                yield return new decontaminants(0.0075, 54, "hpc");
                yield return new decontaminants(0.0075, 38, "hpc");
                yield return new decontaminants(0.0075, 46, "hpc");
                yield return new decontaminants(0.0075, 58, "hpc");
                yield return new decontaminants(0.0075, 54, "hpc");
                yield return new decontaminants(0.0075, 57, "hpc");
                yield return new decontaminants(0.00075, 42, "hpc");
                yield return new decontaminants(0.00075, 45, "hpc");
                yield return new decontaminants(0.00075, 49, "hpc");
                yield return new decontaminants(0.00075, 32, "hpc");
                yield return new decontaminants(0.00075, 39, "hpc");
                yield return new decontaminants(0.00075, 40, "hpc");
                yield return new decontaminants(0.00075, 34, "hpc");
                yield return new decontaminants(0.00075, 45, "hpc");
                yield return new decontaminants(0.00075, 51, "hpc");
                yield return new decontaminants(5, 14, "oxalic");
                yield return new decontaminants(5, 15, "oxalic");
                yield return new decontaminants(5, 6, "oxalic");
                yield return new decontaminants(5, 13, "oxalic");
                yield return new decontaminants(5, 4, "oxalic");
                yield return new decontaminants(5, 1, "oxalic");
                yield return new decontaminants(5, 9, "oxalic");
                yield return new decontaminants(5, 6, "oxalic");
                yield return new decontaminants(5, 12, "oxalic");
                yield return new decontaminants(5, 13, "oxalic");
                yield return new decontaminants(0.5, 27, "oxalic");
                yield return new decontaminants(0.5, 33, "oxalic");
                yield return new decontaminants(0.5, 31, "oxalic");
                yield return new decontaminants(0.5, 30, "oxalic");
                yield return new decontaminants(0.5, 26, "oxalic");
                yield return new decontaminants(0.5, 41, "oxalic");
                yield return new decontaminants(0.5, 33, "oxalic");
                yield return new decontaminants(0.5, 40, "oxalic");
                yield return new decontaminants(0.5, 31, "oxalic");
                yield return new decontaminants(0.5, 20, "oxalic");
                yield return new decontaminants(0.05, 33, "oxalic");
                yield return new decontaminants(0.05, 26, "oxalic");
                yield return new decontaminants(0.05, 32, "oxalic");
                yield return new decontaminants(0.05, 24, "oxalic");
                yield return new decontaminants(0.05, 30, "oxalic");
                yield return new decontaminants(0.05, 52, "oxalic");
                yield return new decontaminants(0.05, 28, "oxalic");
                yield return new decontaminants(0.05, 28, "oxalic");
                yield return new decontaminants(0.05, 26, "oxalic");
                yield return new decontaminants(0.05, 22, "oxalic");
                yield return new decontaminants(0.005, 36, "oxalic");
                yield return new decontaminants(0.005, 54, "oxalic");
                yield return new decontaminants(0.005, 31, "oxalic");
                yield return new decontaminants(0.005, 37, "oxalic");
                yield return new decontaminants(0.005, 50, "oxalic");
                yield return new decontaminants(0.005, 73, "oxalic");
                yield return new decontaminants(0.005, 44, "oxalic");
                yield return new decontaminants(0.005, 50, "oxalic");
                yield return new decontaminants(0.005, 37, "oxalic");
                yield return new decontaminants(0, 52, "oxalic");
                yield return new decontaminants(0, 80, "oxalic");
                yield return new decontaminants(0, 55, "oxalic");
                yield return new decontaminants(0, 50, "oxalic");
                yield return new decontaminants(0, 58, "oxalic");
                yield return new decontaminants(0, 50, "oxalic");
                yield return new decontaminants(0, 43, "oxalic");
                yield return new decontaminants(0, 50, "oxalic");
                yield return new decontaminants(0, 53, "oxalic");
                yield return new decontaminants(0, 54, "oxalic");
                yield return new decontaminants(0, 44, "oxalic");
                yield return new decontaminants(0, 51, "oxalic");
                yield return new decontaminants(0, 34, "oxalic");
                yield return new decontaminants(0, 37, "oxalic");
                yield return new decontaminants(0, 46, "oxalic");
                yield return new decontaminants(0, 56, "oxalic");
                yield return new decontaminants(0, 64, "oxalic");
                yield return new decontaminants(0, 51, "oxalic");
                yield return new decontaminants(0, 67, "oxalic");
                yield return new decontaminants(0, 40, "oxalic");
            }
        }
    }
}
