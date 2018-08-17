// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// The Discretized Painter's Data of de Piles
    /// </summary>

    public class newpainters
    {
        public readonly int Composition;
        public readonly int Drawing;
        public readonly int Colour;
        public readonly int Expression;

        public newpainters(int Composition, int Drawing, int Colour, int Expression)
        {
            this.Composition = Composition;
            this.Drawing = Drawing;
            this.Colour = Colour;
            this.Expression = Expression;
        }

        public static IEnumerable<newpainters> Data
        {
            get
            {
                yield return new newpainters(200, 100, 400, 100);
                yield return new newpainters(400, 400, 100, 400);
                yield return new newpainters(100, 200, 400, 300);
                yield return new newpainters(200, 400, 200, 300);
                yield return new newpainters(100, 400, 200, 100);
                yield return new newpainters(400, 400, 100, 400);
                yield return new newpainters(100, 400, 100, 300);
                yield return new newpainters(400, 400, 100, 300);
                yield return new newpainters(100, 200, 300, 200);
                yield return new newpainters(400, 400, 300, 400);
                yield return new newpainters(200, 200, 200, 300);
                yield return new newpainters(300, 400, 200, 300);
                yield return new newpainters(200, 400, 100, 300);
                yield return new newpainters(400, 300, 100, 300);
                yield return new newpainters(300, 300, 300, 300);
                yield return new newpainters(200, 400, 100, 300);
                yield return new newpainters(300, 400, 100, 300);
                yield return new newpainters(400, 300, 300, 300);
                yield return new newpainters(200, 200, 100, 100);
                yield return new newpainters(300, 200, 200, 300);
                yield return new newpainters(200, 400, 100, 300);
                yield return new newpainters(400, 400, 300, 400);
                yield return new newpainters(100, 100, 400, 100);
                yield return new newpainters(100, 100, 300, 100);
                yield return new newpainters(100, 100, 400, 200);
                yield return new newpainters(100, 100, 300, 200);
                yield return new newpainters(200, 100, 300, 300);
                yield return new newpainters(100, 100, 400, 100);
                yield return new newpainters(100, 300, 400, 200);
                yield return new newpainters(400, 300, 400, 200);
                yield return new newpainters(200, 400, 400, 300);
                yield return new newpainters(400, 200, 400, 100);
                yield return new newpainters(300, 300, 300, 300);
                yield return new newpainters(100, 100, 400, 100);
                yield return new newpainters(300, 200, 300, 400);
                yield return new newpainters(400, 400, 200, 400);
                yield return new newpainters(400, 200, 300, 200);
                yield return new newpainters(300, 200, 300, 200);
                yield return new newpainters(400, 400, 300, 400);
                yield return new newpainters(100, 200, 300, 300);
                yield return new newpainters(200, 200, 400, 400);
                yield return new newpainters(100, 400, 100, 300);
                yield return new newpainters(100, 100, 100, 200);
                yield return new newpainters(200, 200, 300, 300);
                yield return new newpainters(200, 100, 400, 300);
                yield return new newpainters(300, 300, 300, 300);
                yield return new newpainters(400, 100, 400, 400);
                yield return new newpainters(400, 200, 400, 400);
                yield return new newpainters(400, 200, 300, 300);
                yield return new newpainters(400, 200, 400, 400);
                yield return new newpainters(200, 100, 200, 200);
                yield return new newpainters(400, 400, 200, 400);
                yield return new newpainters(400, 400, 100, 400);
                yield return new newpainters(400, 400, 100, 400);
            }
        }
    }
}
