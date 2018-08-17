// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Chatterjee-Price Attitude Data
    /// </summary>

    public class attitude
    {
        public readonly int rating;
        public readonly int complaints;
        public readonly int privileges;
        public readonly int learning;
        public readonly int raises;
        public readonly int critical;
        public readonly int advance;

        public attitude(int rating, int complaints, int privileges, int learning, int raises, int critical, int advance)
        {
            this.rating = rating;
            this.complaints = complaints;
            this.privileges = privileges;
            this.learning = learning;
            this.raises = raises;
            this.critical = critical;
            this.advance = advance;
        }

        public static IEnumerable<attitude> Data
        {
            get
            {
                yield return new attitude(43, 51, 30, 39, 61, 92, 45);
                yield return new attitude(63, 64, 51, 54, 63, 73, 47);
                yield return new attitude(71, 70, 68, 69, 76, 86, 48);
                yield return new attitude(61, 63, 45, 47, 54, 84, 35);
                yield return new attitude(81, 78, 56, 66, 71, 83, 47);
                yield return new attitude(43, 55, 49, 44, 54, 49, 34);
                yield return new attitude(58, 67, 42, 56, 66, 68, 35);
                yield return new attitude(71, 75, 50, 55, 70, 66, 41);
                yield return new attitude(72, 82, 72, 67, 71, 83, 31);
                yield return new attitude(67, 61, 45, 47, 62, 80, 41);
                yield return new attitude(64, 53, 53, 58, 58, 67, 34);
                yield return new attitude(67, 60, 47, 39, 59, 74, 41);
                yield return new attitude(69, 62, 57, 42, 55, 63, 25);
                yield return new attitude(68, 83, 83, 45, 59, 77, 35);
                yield return new attitude(77, 77, 54, 72, 79, 77, 46);
                yield return new attitude(81, 90, 50, 72, 60, 54, 36);
                yield return new attitude(74, 85, 64, 69, 79, 79, 63);
                yield return new attitude(65, 60, 65, 75, 55, 80, 60);
                yield return new attitude(65, 70, 46, 57, 75, 85, 46);
                yield return new attitude(50, 58, 68, 54, 64, 78, 52);
                yield return new attitude(50, 40, 33, 34, 43, 64, 33);
                yield return new attitude(64, 61, 52, 62, 66, 80, 41);
                yield return new attitude(53, 66, 52, 50, 63, 80, 37);
                yield return new attitude(40, 37, 42, 58, 50, 57, 49);
                yield return new attitude(63, 54, 42, 48, 66, 75, 33);
                yield return new attitude(66, 77, 66, 63, 88, 76, 72);
                yield return new attitude(78, 75, 58, 74, 80, 78, 49);
                yield return new attitude(48, 57, 44, 45, 51, 83, 38);
                yield return new attitude(85, 85, 71, 71, 77, 74, 55);
                yield return new attitude(82, 82, 39, 59, 64, 78, 39);
            }
        }
    }
}
