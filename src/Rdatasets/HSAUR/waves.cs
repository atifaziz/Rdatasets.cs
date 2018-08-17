// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Electricity from Wave Power at Sea
    /// </summary>

    public class waves
    {
        public readonly double method1;
        public readonly double method2;

        public waves(double method1, double method2)
        {
            this.method1 = method1;
            this.method2 = method2;
        }

        public static IEnumerable<waves> Data
        {
            get
            {
                yield return new waves(2.23, 1.82);
                yield return new waves(2.55, 2.42);
                yield return new waves(7.99, 8.26);
                yield return new waves(4.09, 3.46);
                yield return new waves(9.62, 9.77);
                yield return new waves(1.59, 1.4);
                yield return new waves(8.98, 8.88);
                yield return new waves(0.82, 0.87);
                yield return new waves(10.83, 11.2);
                yield return new waves(1.54, 1.33);
                yield return new waves(10.75, 10.32);
                yield return new waves(5.79, 5.87);
                yield return new waves(5.91, 6.44);
                yield return new waves(5.79, 5.87);
                yield return new waves(5.5, 5.3);
                yield return new waves(9.96, 9.82);
                yield return new waves(1.92, 1.69);
                yield return new waves(7.38, 7.41);
            }
        }
    }
}
