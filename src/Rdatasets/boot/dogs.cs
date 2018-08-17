// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Cardiac Data for Domestic Dogs
    /// </summary>

    public class dogs
    {
        public readonly int mvo;
        public readonly int lvp;

        public dogs(int mvo, int lvp)
        {
            this.mvo = mvo;
            this.lvp = lvp;
        }

        public static IEnumerable<dogs> Data
        {
            get
            {
                yield return new dogs(78, 32);
                yield return new dogs(92, 33);
                yield return new dogs(116, 45);
                yield return new dogs(90, 30);
                yield return new dogs(106, 38);
                yield return new dogs(78, 24);
                yield return new dogs(99, 44);
            }
        }
    }
}
