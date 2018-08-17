// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Areas of the World's Major Landmasses
    /// </summary>

    public class islands
    {
        public readonly int dat;

        public islands(int dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<islands> Data
        {
            get
            {
                yield return new islands(11506);
                yield return new islands(5500);
                yield return new islands(16988);
                yield return new islands(2968);
                yield return new islands(16);
                yield return new islands(184);
                yield return new islands(23);
                yield return new islands(280);
                yield return new islands(84);
                yield return new islands(73);
                yield return new islands(25);
                yield return new islands(43);
                yield return new islands(21);
                yield return new islands(82);
                yield return new islands(3745);
                yield return new islands(840);
                yield return new islands(13);
                yield return new islands(30);
                yield return new islands(30);
                yield return new islands(89);
                yield return new islands(40);
                yield return new islands(33);
                yield return new islands(49);
                yield return new islands(14);
                yield return new islands(42);
                yield return new islands(227);
                yield return new islands(16);
                yield return new islands(36);
                yield return new islands(29);
                yield return new islands(15);
                yield return new islands(306);
                yield return new islands(44);
                yield return new islands(58);
                yield return new islands(43);
                yield return new islands(9390);
                yield return new islands(32);
                yield return new islands(13);
                yield return new islands(29);
                yield return new islands(6795);
                yield return new islands(16);
                yield return new islands(15);
                yield return new islands(183);
                yield return new islands(14);
                yield return new islands(26);
                yield return new islands(19);
                yield return new islands(13);
                yield return new islands(12);
                yield return new islands(82);
            }
        }
    }
}
