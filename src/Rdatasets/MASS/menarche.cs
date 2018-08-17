// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Age of Menarche in Warsaw
    /// </summary>

    public class menarche
    {
        public readonly double Age;
        public readonly int Total;
        public readonly int Menarche;

        public menarche(double Age, int Total, int Menarche)
        {
            this.Age = Age;
            this.Total = Total;
            this.Menarche = Menarche;
        }

        public static IEnumerable<menarche> Data
        {
            get
            {
                yield return new menarche(9.21, 376, 0);
                yield return new menarche(10.21, 200, 0);
                yield return new menarche(10.58, 93, 0);
                yield return new menarche(10.83, 120, 2);
                yield return new menarche(11.08, 90, 2);
                yield return new menarche(11.33, 88, 5);
                yield return new menarche(11.58, 105, 10);
                yield return new menarche(11.83, 111, 17);
                yield return new menarche(12.08, 100, 16);
                yield return new menarche(12.33, 93, 29);
                yield return new menarche(12.58, 100, 39);
                yield return new menarche(12.83, 108, 51);
                yield return new menarche(13.08, 99, 47);
                yield return new menarche(13.33, 106, 67);
                yield return new menarche(13.58, 105, 81);
                yield return new menarche(13.83, 117, 88);
                yield return new menarche(14.08, 98, 79);
                yield return new menarche(14.33, 97, 90);
                yield return new menarche(14.58, 120, 113);
                yield return new menarche(14.83, 102, 95);
                yield return new menarche(15.08, 122, 117);
                yield return new menarche(15.33, 111, 107);
                yield return new menarche(15.58, 94, 92);
                yield return new menarche(15.83, 114, 112);
                yield return new menarche(17.58, 1049, 1049);
            }
        }
    }
}
