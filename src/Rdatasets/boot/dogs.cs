// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Cardiac Data for Domestic Dogs
    /// </summary>

    public class dogs
    {
        public readonly int κ;
        public readonly int mvo;
        public readonly int lvp;

        public dogs(int κ, int mvo, int lvp)
        {
            this.κ = κ;
            this.mvo = mvo;
            this.lvp = lvp;
        }

        public static IEnumerable<dogs> Data
        {
            get
            {
                yield return new dogs(1, 78, 32);
                yield return new dogs(2, 92, 33);
                yield return new dogs(3, 116, 45);
                yield return new dogs(4, 90, 30);
                yield return new dogs(5, 106, 38);
                yield return new dogs(6, 78, 24);
                yield return new dogs(7, 99, 44);
            }
        }
    }
}
