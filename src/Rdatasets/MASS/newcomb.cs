// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Newcomb's Measurements of the Passage Time of Light
    /// </summary>

    public class newcomb
    {
        public readonly int dat;

        public newcomb(int dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<newcomb> Data
        {
            get
            {
                yield return new newcomb(28);
                yield return new newcomb(-44);
                yield return new newcomb(29);
                yield return new newcomb(30);
                yield return new newcomb(24);
                yield return new newcomb(28);
                yield return new newcomb(37);
                yield return new newcomb(32);
                yield return new newcomb(36);
                yield return new newcomb(27);
                yield return new newcomb(26);
                yield return new newcomb(28);
                yield return new newcomb(29);
                yield return new newcomb(26);
                yield return new newcomb(27);
                yield return new newcomb(22);
                yield return new newcomb(23);
                yield return new newcomb(20);
                yield return new newcomb(25);
                yield return new newcomb(25);
                yield return new newcomb(36);
                yield return new newcomb(23);
                yield return new newcomb(31);
                yield return new newcomb(32);
                yield return new newcomb(24);
                yield return new newcomb(27);
                yield return new newcomb(33);
                yield return new newcomb(16);
                yield return new newcomb(24);
                yield return new newcomb(29);
                yield return new newcomb(36);
                yield return new newcomb(21);
                yield return new newcomb(28);
                yield return new newcomb(26);
                yield return new newcomb(27);
                yield return new newcomb(27);
                yield return new newcomb(32);
                yield return new newcomb(25);
                yield return new newcomb(28);
                yield return new newcomb(24);
                yield return new newcomb(40);
                yield return new newcomb(21);
                yield return new newcomb(31);
                yield return new newcomb(32);
                yield return new newcomb(28);
                yield return new newcomb(26);
                yield return new newcomb(30);
                yield return new newcomb(27);
                yield return new newcomb(26);
                yield return new newcomb(24);
                yield return new newcomb(32);
                yield return new newcomb(29);
                yield return new newcomb(34);
                yield return new newcomb(-2);
                yield return new newcomb(25);
                yield return new newcomb(19);
                yield return new newcomb(36);
                yield return new newcomb(29);
                yield return new newcomb(30);
                yield return new newcomb(22);
                yield return new newcomb(28);
                yield return new newcomb(33);
                yield return new newcomb(39);
                yield return new newcomb(25);
                yield return new newcomb(16);
                yield return new newcomb(23);
            }
        }
    }
}
