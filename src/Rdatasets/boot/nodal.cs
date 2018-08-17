// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Nodal Involvement in Prostate Cancer
    /// </summary>

    public class nodal
    {
        public readonly int m;
        public readonly int r;
        public readonly int aged;
        public readonly int stage;
        public readonly int grade;
        public readonly int xray;
        public readonly int acid;

        public nodal(int m, int r, int aged, int stage, int grade, int xray, int acid)
        {
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
                yield return new nodal(1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(1, 1, 0, 1, 1, 1, 1);
                yield return new nodal(1, 0, 0, 1, 1, 1, 1);
                yield return new nodal(1, 1, 0, 0, 0, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 0, 1);
                yield return new nodal(1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(1, 0, 1, 1, 1, 0, 0);
                yield return new nodal(1, 1, 1, 1, 0, 0, 1);
                yield return new nodal(1, 1, 1, 1, 0, 0, 1);
                yield return new nodal(1, 0, 1, 1, 0, 0, 1);
                yield return new nodal(1, 0, 1, 1, 0, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(1, 0, 0, 0, 0, 0, 0);
                yield return new nodal(1, 1, 0, 1, 1, 0, 1);
                yield return new nodal(1, 1, 0, 1, 1, 0, 1);
                yield return new nodal(1, 0, 0, 1, 1, 0, 1);
                yield return new nodal(1, 1, 1, 1, 0, 0, 0);
                yield return new nodal(1, 0, 1, 1, 0, 0, 0);
                yield return new nodal(1, 0, 1, 1, 0, 0, 0);
                yield return new nodal(1, 0, 1, 0, 0, 0, 1);
                yield return new nodal(1, 0, 1, 0, 0, 0, 1);
                yield return new nodal(1, 0, 1, 0, 0, 0, 1);
                yield return new nodal(1, 0, 1, 0, 0, 0, 0);
                yield return new nodal(1, 0, 1, 0, 0, 0, 0);
                yield return new nodal(1, 0, 1, 0, 0, 0, 0);
                yield return new nodal(1, 0, 1, 0, 0, 1, 0);
                yield return new nodal(1, 0, 1, 0, 0, 1, 0);
                yield return new nodal(1, 1, 0, 1, 0, 0, 1);
                yield return new nodal(1, 0, 0, 1, 0, 0, 1);
                yield return new nodal(1, 1, 0, 0, 1, 0, 0);
                yield return new nodal(1, 0, 0, 0, 1, 0, 0);
                yield return new nodal(1, 1, 1, 1, 1, 1, 1);
                yield return new nodal(1, 1, 1, 1, 0, 1, 1);
                yield return new nodal(1, 1, 1, 0, 1, 1, 1);
                yield return new nodal(1, 1, 1, 0, 0, 1, 1);
                yield return new nodal(1, 0, 1, 0, 1, 0, 0);
                yield return new nodal(1, 1, 0, 1, 1, 1, 0);
                yield return new nodal(1, 0, 0, 1, 1, 0, 0);
                yield return new nodal(1, 1, 0, 1, 0, 1, 0);
                yield return new nodal(1, 1, 0, 0, 1, 0, 1);
                yield return new nodal(1, 0, 0, 0, 0, 1, 1);
                yield return new nodal(1, 0, 0, 0, 0, 1, 0);
            }
        }
    }
}
