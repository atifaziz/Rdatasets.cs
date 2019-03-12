// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Head Dimensions in Brothers
    /// </summary>

    public class frets
    {
        public readonly int κ;
        public readonly int l1;
        public readonly int b1;
        public readonly int l2;
        public readonly int b2;

        public frets(int κ, int l1, int b1, int l2, int b2)
        {
            this.κ = κ;
            this.l1 = l1;
            this.b1 = b1;
            this.l2 = l2;
            this.b2 = b2;
        }

        public static IEnumerable<frets> Data
        {
            get
            {
                yield return new frets(1, 191, 155, 179, 145);
                yield return new frets(2, 195, 149, 201, 152);
                yield return new frets(3, 181, 148, 185, 149);
                yield return new frets(4, 183, 153, 188, 149);
                yield return new frets(5, 176, 144, 171, 142);
                yield return new frets(6, 208, 157, 192, 152);
                yield return new frets(7, 189, 150, 190, 149);
                yield return new frets(8, 197, 159, 189, 152);
                yield return new frets(9, 188, 152, 197, 159);
                yield return new frets(10, 192, 150, 187, 151);
                yield return new frets(11, 179, 158, 186, 148);
                yield return new frets(12, 183, 147, 174, 147);
                yield return new frets(13, 174, 150, 185, 152);
                yield return new frets(14, 190, 159, 195, 157);
                yield return new frets(15, 188, 151, 187, 158);
                yield return new frets(16, 163, 137, 161, 130);
                yield return new frets(17, 195, 155, 183, 158);
                yield return new frets(18, 186, 153, 173, 148);
                yield return new frets(19, 181, 145, 182, 146);
                yield return new frets(20, 175, 140, 165, 137);
                yield return new frets(21, 192, 154, 185, 152);
                yield return new frets(22, 174, 143, 178, 147);
                yield return new frets(23, 176, 139, 176, 143);
                yield return new frets(24, 197, 167, 200, 158);
                yield return new frets(25, 190, 163, 187, 150);
            }
        }
    }
}
