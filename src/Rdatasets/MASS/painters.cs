// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Painter's Data of de Piles
    /// </summary>

    public class painters
    {
        public readonly int Composition;
        public readonly int Drawing;
        public readonly int Colour;
        public readonly int Expression;
        public readonly string School;

        public painters(int Composition, int Drawing, int Colour, int Expression, string School)
        {
            this.Composition = Composition;
            this.Drawing = Drawing;
            this.Colour = Colour;
            this.Expression = Expression;
            this.School = School;
        }

        public static IEnumerable<painters> Data
        {
            get
            {
                yield return new painters(10, 8, 16, 3, "A");
                yield return new painters(15, 16, 4, 14, "A");
                yield return new painters(8, 13, 16, 7, "A");
                yield return new painters(12, 16, 9, 8, "A");
                yield return new painters(0, 15, 8, 0, "A");
                yield return new painters(15, 16, 4, 14, "A");
                yield return new painters(8, 17, 4, 8, "A");
                yield return new painters(15, 16, 7, 6, "A");
                yield return new painters(4, 12, 10, 4, "A");
                yield return new painters(17, 18, 12, 18, "A");
                yield return new painters(10, 13, 8, 8, "B");
                yield return new painters(13, 15, 8, 8, "B");
                yield return new painters(10, 15, 6, 6, "B");
                yield return new painters(15, 14, 7, 10, "B");
                yield return new painters(13, 14, 10, 9, "B");
                yield return new painters(12, 15, 5, 8, "B");
                yield return new painters(14, 15, 6, 10, "C");
                yield return new painters(16, 14, 12, 6, "C");
                yield return new painters(10, 10, 6, 2, "C");
                yield return new painters(13, 12, 9, 6, "C");
                yield return new painters(11, 15, 0, 6, "C");
                yield return new painters(15, 15, 12, 13, "C");
                yield return new painters(6, 8, 17, 0, "D");
                yield return new painters(4, 6, 14, 0, "D");
                yield return new painters(8, 9, 18, 4, "D");
                yield return new painters(6, 8, 15, 4, "D");
                yield return new painters(12, 9, 14, 6, "D");
                yield return new painters(5, 6, 16, 0, "D");
                yield return new painters(8, 14, 17, 5, "D");
                yield return new painters(15, 14, 16, 4, "D");
                yield return new painters(12, 15, 18, 6, "D");
                yield return new painters(15, 10, 16, 3, "D");
                yield return new painters(14, 14, 10, 6, "E");
                yield return new painters(6, 6, 16, 0, "E");
                yield return new painters(13, 13, 15, 12, "E");
                yield return new painters(15, 17, 9, 17, "E");
                yield return new painters(18, 10, 10, 4, "E");
                yield return new painters(14, 13, 10, 5, "E");
                yield return new painters(15, 17, 13, 13, "E");
                yield return new painters(8, 10, 10, 8, "F");
                yield return new painters(9, 10, 16, 13, "F");
                yield return new painters(4, 15, 6, 6, "F");
                yield return new painters(8, 6, 6, 4, "F");
                yield return new painters(11, 10, 14, 6, "G");
                yield return new painters(10, 8, 16, 6, "G");
                yield return new painters(13, 14, 10, 10, "G");
                yield return new painters(15, 6, 17, 12, "G");
                yield return new painters(18, 13, 17, 17, "G");
                yield return new painters(15, 12, 13, 6, "G");
                yield return new painters(15, 10, 17, 13, "G");
                yield return new painters(10, 8, 8, 4, "H");
                yield return new painters(16, 16, 8, 16, "H");
                yield return new painters(15, 15, 4, 15, "H");
                yield return new painters(15, 17, 6, 15, "H");
            }
        }
    }
}
