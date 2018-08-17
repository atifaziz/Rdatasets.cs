// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// SAT scores and GPA
    /// </summary>

    public class SATGPA
    {
        public readonly int MathSAT;
        public readonly int VerbalSAT;
        public readonly double GPA;

        public SATGPA(int MathSAT, int VerbalSAT, double GPA)
        {
            this.MathSAT = MathSAT;
            this.VerbalSAT = VerbalSAT;
            this.GPA = GPA;
        }

        public static IEnumerable<SATGPA> Data
        {
            get
            {
                yield return new SATGPA(580, 420, 2.9);
                yield return new SATGPA(670, 530, 2.83);
                yield return new SATGPA(680, 540, 2.9);
                yield return new SATGPA(630, 640, 3.3);
                yield return new SATGPA(620, 630, 3.61);
                yield return new SATGPA(580, 550, 2.75);
                yield return new SATGPA(620, 600, 2.75);
                yield return new SATGPA(690, 500, 3);
                yield return new SATGPA(520, 500, 2.77);
                yield return new SATGPA(570, 630, 2.9);
                yield return new SATGPA(620, 550, 3);
                yield return new SATGPA(690, 570, 3.25);
                yield return new SATGPA(350, 300, 3.13);
                yield return new SATGPA(680, 570, 3.53);
                yield return new SATGPA(550, 530, 3.1);
                yield return new SATGPA(570, 540, 3.2);
                yield return new SATGPA(620, 640, 3.27);
                yield return new SATGPA(750, 560, 3.3);
                yield return new SATGPA(700, 680, 2.6);
                yield return new SATGPA(670, 550, 3.53);
                yield return new SATGPA(680, 550, 2.67);
                yield return new SATGPA(590, 700, 3.3);
                yield return new SATGPA(600, 650, 3.5);
                yield return new SATGPA(630, 640, 3.7);
            }
        }
    }
}
