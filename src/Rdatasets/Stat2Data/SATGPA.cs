// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// SAT scores and GPA
    /// </summary>

    public class SATGPA
    {
        public readonly int κ;
        public readonly int MathSAT;
        public readonly int VerbalSAT;
        public readonly double GPA;

        public SATGPA(int κ, int MathSAT, int VerbalSAT, double GPA)
        {
            this.κ = κ;
            this.MathSAT = MathSAT;
            this.VerbalSAT = VerbalSAT;
            this.GPA = GPA;
        }

        public static IEnumerable<SATGPA> Data
        {
            get
            {
                yield return new SATGPA(1, 580, 420, 2.9);
                yield return new SATGPA(2, 670, 530, 2.83);
                yield return new SATGPA(3, 680, 540, 2.9);
                yield return new SATGPA(4, 630, 640, 3.3);
                yield return new SATGPA(5, 620, 630, 3.61);
                yield return new SATGPA(6, 580, 550, 2.75);
                yield return new SATGPA(7, 620, 600, 2.75);
                yield return new SATGPA(8, 690, 500, 3);
                yield return new SATGPA(9, 520, 500, 2.77);
                yield return new SATGPA(10, 570, 630, 2.9);
                yield return new SATGPA(11, 620, 550, 3);
                yield return new SATGPA(12, 690, 570, 3.25);
                yield return new SATGPA(13, 350, 300, 3.13);
                yield return new SATGPA(14, 680, 570, 3.53);
                yield return new SATGPA(15, 550, 530, 3.1);
                yield return new SATGPA(16, 570, 540, 3.2);
                yield return new SATGPA(17, 620, 640, 3.27);
                yield return new SATGPA(18, 750, 560, 3.3);
                yield return new SATGPA(19, 700, 680, 2.6);
                yield return new SATGPA(20, 670, 550, 3.53);
                yield return new SATGPA(21, 680, 550, 2.67);
                yield return new SATGPA(22, 590, 700, 3.3);
                yield return new SATGPA(23, 600, 650, 3.5);
                yield return new SATGPA(24, 630, 640, 3.7);
            }
        }
    }
}
