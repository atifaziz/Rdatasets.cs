// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Tuna Sighting Data
    /// </summary>

    public class tuna
    {
        public readonly double y;

        public tuna(double y)
        {
            this.y = y;
        }

        public static IEnumerable<tuna> Data
        {
            get
            {
                yield return new tuna(0.19);
                yield return new tuna(0.28);
                yield return new tuna(0.29);
                yield return new tuna(0.45);
                yield return new tuna(0.64);
                yield return new tuna(0.65);
                yield return new tuna(0.78);
                yield return new tuna(0.85);
                yield return new tuna(1);
                yield return new tuna(1.16);
                yield return new tuna(1.17);
                yield return new tuna(1.29);
                yield return new tuna(1.31);
                yield return new tuna(1.34);
                yield return new tuna(1.55);
                yield return new tuna(1.6);
                yield return new tuna(1.83);
                yield return new tuna(1.91);
                yield return new tuna(1.97);
                yield return new tuna(2.05);
                yield return new tuna(2.1);
                yield return new tuna(2.17);
                yield return new tuna(2.28);
                yield return new tuna(2.41);
                yield return new tuna(2.46);
                yield return new tuna(2.51);
                yield return new tuna(2.89);
                yield return new tuna(2.89);
                yield return new tuna(2.9);
                yield return new tuna(2.92);
                yield return new tuna(3.03);
                yield return new tuna(3.19);
                yield return new tuna(3.48);
                yield return new tuna(3.79);
                yield return new tuna(3.83);
                yield return new tuna(3.94);
                yield return new tuna(3.95);
                yield return new tuna(4.11);
                yield return new tuna(4.14);
                yield return new tuna(4.19);
                yield return new tuna(4.36);
                yield return new tuna(4.53);
                yield return new tuna(4.97);
                yield return new tuna(5.02);
                yield return new tuna(5.13);
                yield return new tuna(5.75);
                yield return new tuna(6.03);
                yield return new tuna(6.19);
                yield return new tuna(6.19);
                yield return new tuna(6.45);
                yield return new tuna(7.13);
                yield return new tuna(7.35);
                yield return new tuna(7.77);
                yield return new tuna(7.8);
                yield return new tuna(8.81);
                yield return new tuna(9.22);
                yield return new tuna(9.29);
                yield return new tuna(9.78);
                yield return new tuna(10.15);
                yield return new tuna(11.32);
                yield return new tuna(13.21);
                yield return new tuna(13.27);
                yield return new tuna(14.39);
                yield return new tuna(16.26);
            }
        }
    }
}
