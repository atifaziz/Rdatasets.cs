// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Head Dimensions in Brothers
    /// </summary>

    public class frets
    {
        public readonly int l1;
        public readonly int b1;
        public readonly int l2;
        public readonly int b2;

        public frets(int l1, int b1, int l2, int b2)
        {
            this.l1 = l1;
            this.b1 = b1;
            this.l2 = l2;
            this.b2 = b2;
        }

        public static IEnumerable<frets> Data
        {
            get
            {
                yield return new frets(191, 155, 179, 145);
                yield return new frets(195, 149, 201, 152);
                yield return new frets(181, 148, 185, 149);
                yield return new frets(183, 153, 188, 149);
                yield return new frets(176, 144, 171, 142);
                yield return new frets(208, 157, 192, 152);
                yield return new frets(189, 150, 190, 149);
                yield return new frets(197, 159, 189, 152);
                yield return new frets(188, 152, 197, 159);
                yield return new frets(192, 150, 187, 151);
                yield return new frets(179, 158, 186, 148);
                yield return new frets(183, 147, 174, 147);
                yield return new frets(174, 150, 185, 152);
                yield return new frets(190, 159, 195, 157);
                yield return new frets(188, 151, 187, 158);
                yield return new frets(163, 137, 161, 130);
                yield return new frets(195, 155, 183, 158);
                yield return new frets(186, 153, 173, 148);
                yield return new frets(181, 145, 182, 146);
                yield return new frets(175, 140, 165, 137);
                yield return new frets(192, 154, 185, 152);
                yield return new frets(174, 143, 178, 147);
                yield return new frets(176, 139, 176, 143);
                yield return new frets(197, 167, 200, 158);
                yield return new frets(190, 163, 187, 150);
            }
        }
    }
}
