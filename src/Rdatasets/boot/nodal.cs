// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Nodal Involvement in Prostate Cancer
    /// </summary>

    public class nodal
    {
        public readonly int κ;
        public readonly int m;
        public readonly int r;
        public readonly int aged;
        public readonly int stage;
        public readonly int grade;
        public readonly int xray;
        public readonly int acid;

        public nodal(int κ, int m, int r, int aged, int stage, int grade, int xray, int acid)
        {
            this.κ = κ;
            this.m = m;
            this.r = r;
            this.aged = aged;
            this.stage = stage;
            this.grade = grade;
            this.xray = xray;
            this.acid = acid;
        }

        public static IEnumerable<nodal> Data
        {
            get
            {
                yield return new nodal(1, 1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(2, 1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(3, 1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(4, 1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(5, 1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(6, 1, 0, 0, 1, 1, 1, 1);
                yield return new nodal(7, 1, 1, 0, 0, 0, 0, 1);
                yield return new nodal(8, 1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(9, 1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(10, 1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(11, 1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(12, 1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(13, 1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(14, 1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(15, 1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(16, 1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(17, 1, 1, 1, 1, 0, 0, 1);
                yield return new nodal(18, 1, 1, 1, 1, 0, 0, 1);
                yield return new nodal(19, 1, 0, 1, 1, 0, 0, 1);
                yield return new nodal(20, 1, 0, 1, 1, 0, 0, 1);
                yield return new nodal(21, 1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(22, 1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(23, 1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(24, 1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(25, 1, 1, 0, 1, 1, 0, 1);
                yield return new nodal(26, 1, 1, 0, 1, 1, 0, 1);
                yield return new nodal(27, 1, 0, 0, 1, 1, 0, 1);
                yield return new nodal(28, 1, 1, 1, 1, 0, 0, 0);
                yield return new nodal(29, 1, 0, 1, 1, 0, 0, 0);
                yield return new nodal(30, 1, 0, 1, 1, 0, 0, 0);
                yield return new nodal(31, 1, 0, 1, 0, 0, 0, 1);
                yield return new nodal(32, 1, 0, 1, 0, 0, 0, 1);
                yield return new nodal(33, 1, 0, 1, 0, 0, 0, 1);
                yield return new nodal(34, 1, 0, 1, 0, 0, 0, 0);
                yield return new nodal(35, 1, 0, 1, 0, 0, 0, 0);
                yield return new nodal(36, 1, 0, 1, 0, 0, 0, 0);
                yield return new nodal(37, 1, 0, 1, 0, 0, 1, 0);
                yield return new nodal(38, 1, 0, 1, 0, 0, 1, 0);
                yield return new nodal(39, 1, 1, 0, 1, 0, 0, 1);
                yield return new nodal(40, 1, 0, 0, 1, 0, 0, 1);
                yield return new nodal(41, 1, 1, 0, 0, 1, 0, 0);
                yield return new nodal(42, 1, 0, 0, 0, 1, 0, 0);
                yield return new nodal(43, 1, 1, 1, 1, 1, 1, 1);
                yield return new nodal(44, 1, 1, 1, 1, 0, 1, 1);
                yield return new nodal(45, 1, 1, 1, 0, 1, 1, 1);
                yield return new nodal(46, 1, 1, 1, 0, 0, 1, 1);
                yield return new nodal(47, 1, 0, 1, 0, 1, 0, 0);
                yield return new nodal(48, 1, 1, 0, 1, 1, 1, 0);
                yield return new nodal(49, 1, 0, 0, 1, 1, 0, 0);
                yield return new nodal(50, 1, 1, 0, 1, 0, 1, 0);
                yield return new nodal(51, 1, 1, 0, 0, 1, 0, 1);
                yield return new nodal(52, 1, 0, 0, 0, 0, 1, 1);
                yield return new nodal(53, 1, 0, 0, 0, 0, 1, 0);
            }
        }
    }
}
