// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Galton's example of the relationship between height and 'cubit' or forearm length
    /// </summary>

    public class cubits
    {
        public readonly int _16_5;
        public readonly int _16_75;
        public readonly int _17_25;
        public readonly int _17_75;
        public readonly int _18_25;
        public readonly int _18_75;
        public readonly int _19_25;
        public readonly int _19_75;

        public cubits(int _16_5, int _16_75, int _17_25, int _17_75, int _18_25, int _18_75, int _19_25, int _19_75)
        {
            this._16_5 = _16_5;
            this._16_75 = _16_75;
            this._17_25 = _17_25;
            this._17_75 = _17_75;
            this._18_25 = _18_25;
            this._18_75 = _18_75;
            this._19_25 = _19_25;
            this._19_75 = _19_75;
        }

        public static IEnumerable<cubits> Data
        {
            get
            {
                yield return new cubits(0, 0, 0, 1, 3, 4, 15, 7);
                yield return new cubits(0, 0, 0, 1, 5, 13, 11, 0);
                yield return new cubits(0, 1, 1, 2, 25, 15, 6, 0);
                yield return new cubits(0, 1, 3, 7, 14, 7, 4, 2);
                yield return new cubits(0, 1, 7, 15, 28, 8, 2, 0);
                yield return new cubits(0, 1, 7, 18, 15, 6, 0, 0);
                yield return new cubits(0, 4, 10, 12, 8, 2, 0, 0);
                yield return new cubits(0, 5, 11, 2, 3, 0, 0, 0);
                yield return new cubits(9, 12, 10, 3, 1, 0, 0, 0);
            }
        }
    }
}
