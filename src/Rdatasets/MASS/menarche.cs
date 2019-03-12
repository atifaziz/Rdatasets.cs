// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Age of Menarche in Warsaw
    /// </summary>

    public class menarche
    {
        public readonly int κ;
        public readonly double Age;
        public readonly int Total;
        public readonly int Menarche;

        public menarche(int κ, double Age, int Total, int Menarche)
        {
            this.κ = κ;
            this.Age = Age;
            this.Total = Total;
            this.Menarche = Menarche;
        }

        public static IEnumerable<menarche> Data
        {
            get
            {
                yield return new menarche(1, 9.21, 376, 0);
                yield return new menarche(2, 10.21, 200, 0);
                yield return new menarche(3, 10.58, 93, 0);
                yield return new menarche(4, 10.83, 120, 2);
                yield return new menarche(5, 11.08, 90, 2);
                yield return new menarche(6, 11.33, 88, 5);
                yield return new menarche(7, 11.58, 105, 10);
                yield return new menarche(8, 11.83, 111, 17);
                yield return new menarche(9, 12.08, 100, 16);
                yield return new menarche(10, 12.33, 93, 29);
                yield return new menarche(11, 12.58, 100, 39);
                yield return new menarche(12, 12.83, 108, 51);
                yield return new menarche(13, 13.08, 99, 47);
                yield return new menarche(14, 13.33, 106, 67);
                yield return new menarche(15, 13.58, 105, 81);
                yield return new menarche(16, 13.83, 117, 88);
                yield return new menarche(17, 14.08, 98, 79);
                yield return new menarche(18, 14.33, 97, 90);
                yield return new menarche(19, 14.58, 120, 113);
                yield return new menarche(20, 14.83, 102, 95);
                yield return new menarche(21, 15.08, 122, 117);
                yield return new menarche(22, 15.33, 111, 107);
                yield return new menarche(23, 15.58, 94, 92);
                yield return new menarche(24, 15.83, 114, 112);
                yield return new menarche(25, 17.58, 1049, 1049);
            }
        }
    }
}
