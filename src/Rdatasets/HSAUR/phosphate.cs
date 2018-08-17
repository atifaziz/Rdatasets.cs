// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Phosphate Level Data
    /// </summary>

    public class phosphate
    {
        public readonly string group;
        public readonly double t0;
        public readonly double t0_5;
        public readonly double t1;
        public readonly double t1_5;
        public readonly double t2;
        public readonly double t3;
        public readonly double t4;
        public readonly double t5;

        public phosphate(string group, double t0, double t0_5, double t1, double t1_5, double t2, double t3, double t4, double t5)
        {
            this.group = group;
            this.t0 = t0;
            this.t0_5 = t0_5;
            this.t1 = t1;
            this.t1_5 = t1_5;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.t5 = t5;
        }

        public static IEnumerable<phosphate> Data
        {
            get
            {
                yield return new phosphate("control", 4.3, 3.3, 3, 2.6, 2.2, 2.5, 3.4, 4.4);
                yield return new phosphate("control", 3.7, 2.6, 2.6, 1.9, 2.9, 3.2, 3.1, 3.9);
                yield return new phosphate("control", 4, 4.1, 3.1, 2.3, 2.9, 3.1, 3.9, 4);
                yield return new phosphate("control", 3.6, 3, 2.2, 2.8, 2.9, 3.9, 3.8, 4);
                yield return new phosphate("control", 4.1, 3.8, 2.1, 3, 3.6, 3.4, 3.6, 3.7);
                yield return new phosphate("control", 3.8, 2.2, 2, 2.6, 3.8, 3.6, 3, 3.5);
                yield return new phosphate("control", 3.8, 3, 2.4, 2.5, 3.1, 3.4, 3.5, 3.7);
                yield return new phosphate("control", 4.4, 3.9, 2.8, 2.1, 3.6, 3.8, 4, 3.9);
                yield return new phosphate("control", 5, 4, 3.4, 3.4, 3.3, 3.6, 4, 4.3);
                yield return new phosphate("control", 3.7, 3.1, 2.9, 2.2, 1.5, 2.3, 2.7, 2.8);
                yield return new phosphate("control", 3.7, 2.6, 2.6, 2.3, 2.9, 2.2, 3.1, 3.9);
                yield return new phosphate("control", 4.4, 3.7, 3.1, 3.2, 3.7, 4.3, 3.9, 4.8);
                yield return new phosphate("control", 4.7, 3.1, 3.2, 3.3, 3.2, 4.2, 3.7, 4.3);
                yield return new phosphate("control", 4.3, 3.3, 3, 2.6, 2.2, 2.5, 2.4, 3.4);
                yield return new phosphate("control", 5, 4.9, 4.1, 3.7, 3.7, 4.1, 4.7, 4.9);
                yield return new phosphate("control", 4.6, 4.4, 3.9, 3.9, 3.7, 4.2, 4.8, 5);
                yield return new phosphate("control", 4.3, 3.9, 3.1, 3.1, 3.1, 3.1, 3.6, 4);
                yield return new phosphate("control", 3.1, 3.1, 3.3, 2.6, 2.6, 1.9, 2.3, 2.7);
                yield return new phosphate("control", 4.8, 5, 2.9, 2.8, 2.2, 3.1, 3.5, 3.6);
                yield return new phosphate("control", 3.7, 3.1, 3.3, 2.8, 2.9, 3.6, 4.3, 4.4);
                yield return new phosphate("obese", 5.4, 4.7, 3.9, 4.1, 2.8, 3.7, 3.5, 3.7);
                yield return new phosphate("obese", 3, 2.5, 2.3, 2.2, 2.1, 2.6, 3.2, 3.5);
                yield return new phosphate("obese", 4.9, 5, 4.1, 3.7, 3.7, 4.1, 4.7, 4.9);
                yield return new phosphate("obese", 4.8, 4.3, 4.7, 4.6, 4.7, 3.7, 3.6, 3.9);
                yield return new phosphate("obese", 4.4, 4.2, 4.2, 3.4, 3.5, 3.4, 3.8, 4);
                yield return new phosphate("obese", 4.9, 4.3, 4, 4, 3.3, 4.1, 4.2, 4.3);
                yield return new phosphate("obese", 5.1, 4.1, 4.6, 4.1, 3.4, 4.2, 4.4, 4.9);
                yield return new phosphate("obese", 4.8, 4.6, 4.6, 4.4, 4.1, 4, 3.8, 3.8);
                yield return new phosphate("obese", 4.2, 3.5, 3.8, 3.6, 3.3, 3.1, 3.5, 3.9);
                yield return new phosphate("obese", 6.6, 6.1, 5.2, 4.1, 4.3, 3.8, 4.2, 4.8);
                yield return new phosphate("obese", 3.6, 3.4, 3.1, 2.8, 2.1, 2.4, 2.5, 3.5);
                yield return new phosphate("obese", 4.5, 4, 3.7, 3.3, 2.4, 2.3, 3.1, 3.3);
                yield return new phosphate("obese", 4.6, 4.4, 3.8, 3.8, 3.8, 3.6, 3.8, 3.8);
            }
        }
    }
}
