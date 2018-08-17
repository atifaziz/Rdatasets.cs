// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Data on Children who have had Corrective Spinal Surgery
    /// </summary>

    public class kyphosis
    {
        public readonly string Kyphosis;
        public readonly int Age;
        public readonly int Number;
        public readonly int Start;

        public kyphosis(string Kyphosis, int Age, int Number, int Start)
        {
            this.Kyphosis = Kyphosis;
            this.Age = Age;
            this.Number = Number;
            this.Start = Start;
        }

        public static IEnumerable<kyphosis> Data
        {
            get
            {
                yield return new kyphosis("absent", 71, 3, 5);
                yield return new kyphosis("absent", 158, 3, 14);
                yield return new kyphosis("present", 128, 4, 5);
                yield return new kyphosis("absent", 2, 5, 1);
                yield return new kyphosis("absent", 1, 4, 15);
                yield return new kyphosis("absent", 1, 2, 16);
                yield return new kyphosis("absent", 61, 2, 17);
                yield return new kyphosis("absent", 37, 3, 16);
                yield return new kyphosis("absent", 113, 2, 16);
                yield return new kyphosis("present", 59, 6, 12);
                yield return new kyphosis("present", 82, 5, 14);
                yield return new kyphosis("absent", 148, 3, 16);
                yield return new kyphosis("absent", 18, 5, 2);
                yield return new kyphosis("absent", 1, 4, 12);
                yield return new kyphosis("absent", 168, 3, 18);
                yield return new kyphosis("absent", 1, 3, 16);
                yield return new kyphosis("absent", 78, 6, 15);
                yield return new kyphosis("absent", 175, 5, 13);
                yield return new kyphosis("absent", 80, 5, 16);
                yield return new kyphosis("absent", 27, 4, 9);
                yield return new kyphosis("absent", 22, 2, 16);
                yield return new kyphosis("present", 105, 6, 5);
                yield return new kyphosis("present", 96, 3, 12);
                yield return new kyphosis("absent", 131, 2, 3);
                yield return new kyphosis("present", 15, 7, 2);
                yield return new kyphosis("absent", 9, 5, 13);
                yield return new kyphosis("absent", 8, 3, 6);
                yield return new kyphosis("absent", 100, 3, 14);
                yield return new kyphosis("absent", 4, 3, 16);
                yield return new kyphosis("absent", 151, 2, 16);
                yield return new kyphosis("absent", 31, 3, 16);
                yield return new kyphosis("absent", 125, 2, 11);
                yield return new kyphosis("absent", 130, 5, 13);
                yield return new kyphosis("absent", 112, 3, 16);
                yield return new kyphosis("absent", 140, 5, 11);
                yield return new kyphosis("absent", 93, 3, 16);
                yield return new kyphosis("absent", 1, 3, 9);
                yield return new kyphosis("present", 52, 5, 6);
                yield return new kyphosis("absent", 20, 6, 9);
                yield return new kyphosis("present", 91, 5, 12);
                yield return new kyphosis("present", 73, 5, 1);
                yield return new kyphosis("absent", 35, 3, 13);
                yield return new kyphosis("absent", 143, 9, 3);
                yield return new kyphosis("absent", 61, 4, 1);
                yield return new kyphosis("absent", 97, 3, 16);
                yield return new kyphosis("present", 139, 3, 10);
                yield return new kyphosis("absent", 136, 4, 15);
                yield return new kyphosis("absent", 131, 5, 13);
                yield return new kyphosis("present", 121, 3, 3);
                yield return new kyphosis("absent", 177, 2, 14);
                yield return new kyphosis("absent", 68, 5, 10);
                yield return new kyphosis("absent", 9, 2, 17);
                yield return new kyphosis("present", 139, 10, 6);
                yield return new kyphosis("absent", 2, 2, 17);
                yield return new kyphosis("absent", 140, 4, 15);
                yield return new kyphosis("absent", 72, 5, 15);
                yield return new kyphosis("absent", 2, 3, 13);
                yield return new kyphosis("present", 120, 5, 8);
                yield return new kyphosis("absent", 51, 7, 9);
                yield return new kyphosis("absent", 102, 3, 13);
                yield return new kyphosis("present", 130, 4, 1);
                yield return new kyphosis("present", 114, 7, 8);
                yield return new kyphosis("absent", 81, 4, 1);
                yield return new kyphosis("absent", 118, 3, 16);
                yield return new kyphosis("absent", 118, 4, 16);
                yield return new kyphosis("absent", 17, 4, 10);
                yield return new kyphosis("absent", 195, 2, 17);
                yield return new kyphosis("absent", 159, 4, 13);
                yield return new kyphosis("absent", 18, 4, 11);
                yield return new kyphosis("absent", 15, 5, 16);
                yield return new kyphosis("absent", 158, 5, 14);
                yield return new kyphosis("absent", 127, 4, 12);
                yield return new kyphosis("absent", 87, 4, 16);
                yield return new kyphosis("absent", 206, 4, 10);
                yield return new kyphosis("absent", 11, 3, 15);
                yield return new kyphosis("absent", 178, 4, 15);
                yield return new kyphosis("present", 157, 3, 13);
                yield return new kyphosis("absent", 26, 7, 13);
                yield return new kyphosis("absent", 120, 2, 13);
                yield return new kyphosis("present", 42, 7, 6);
                yield return new kyphosis("absent", 36, 4, 13);
            }
        }
    }
}
