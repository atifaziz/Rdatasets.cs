// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ChildSpeaks
    /// </summary>

    public class ChildSpeaks
    {
        public readonly int κ;
        public readonly int Child;
        public readonly int Age;
        public readonly int Gesell;

        public ChildSpeaks(int κ, int Child, int Age, int Gesell)
        {
            this.κ = κ;
            this.Child = Child;
            this.Age = Age;
            this.Gesell = Gesell;
        }

        public static IEnumerable<ChildSpeaks> Data
        {
            get
            {
                yield return new ChildSpeaks(1, 1, 15, 95);
                yield return new ChildSpeaks(2, 2, 26, 71);
                yield return new ChildSpeaks(3, 3, 10, 83);
                yield return new ChildSpeaks(4, 4, 9, 91);
                yield return new ChildSpeaks(5, 5, 15, 102);
                yield return new ChildSpeaks(6, 6, 20, 87);
                yield return new ChildSpeaks(7, 7, 18, 93);
                yield return new ChildSpeaks(8, 8, 11, 100);
                yield return new ChildSpeaks(9, 9, 8, 104);
                yield return new ChildSpeaks(10, 10, 20, 94);
                yield return new ChildSpeaks(11, 11, 7, 113);
                yield return new ChildSpeaks(12, 12, 9, 96);
                yield return new ChildSpeaks(13, 13, 10, 83);
                yield return new ChildSpeaks(14, 14, 11, 84);
                yield return new ChildSpeaks(15, 15, 11, 102);
                yield return new ChildSpeaks(16, 16, 10, 100);
                yield return new ChildSpeaks(17, 17, 12, 105);
                yield return new ChildSpeaks(18, 18, 42, 57);
                yield return new ChildSpeaks(19, 19, 17, 121);
                yield return new ChildSpeaks(20, 20, 11, 86);
                yield return new ChildSpeaks(21, 21, 10, 100);
            }
        }
    }
}
