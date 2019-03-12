// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Chatterjee-Price Attitude Data
    /// </summary>

    public class attitude
    {
        public readonly int κ;
        public readonly int rating;
        public readonly int complaints;
        public readonly int privileges;
        public readonly int learning;
        public readonly int raises;
        public readonly int critical;
        public readonly int advance;

        public attitude(int κ, int rating, int complaints, int privileges, int learning, int raises, int critical, int advance)
        {
            this.κ = κ;
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
                yield return new attitude(1, 43, 51, 30, 39, 61, 92, 45);
                yield return new attitude(2, 63, 64, 51, 54, 63, 73, 47);
                yield return new attitude(3, 71, 70, 68, 69, 76, 86, 48);
                yield return new attitude(4, 61, 63, 45, 47, 54, 84, 35);
                yield return new attitude(5, 81, 78, 56, 66, 71, 83, 47);
                yield return new attitude(6, 43, 55, 49, 44, 54, 49, 34);
                yield return new attitude(7, 58, 67, 42, 56, 66, 68, 35);
                yield return new attitude(8, 71, 75, 50, 55, 70, 66, 41);
                yield return new attitude(9, 72, 82, 72, 67, 71, 83, 31);
                yield return new attitude(10, 67, 61, 45, 47, 62, 80, 41);
                yield return new attitude(11, 64, 53, 53, 58, 58, 67, 34);
                yield return new attitude(12, 67, 60, 47, 39, 59, 74, 41);
                yield return new attitude(13, 69, 62, 57, 42, 55, 63, 25);
                yield return new attitude(14, 68, 83, 83, 45, 59, 77, 35);
                yield return new attitude(15, 77, 77, 54, 72, 79, 77, 46);
                yield return new attitude(16, 81, 90, 50, 72, 60, 54, 36);
                yield return new attitude(17, 74, 85, 64, 69, 79, 79, 63);
                yield return new attitude(18, 65, 60, 65, 75, 55, 80, 60);
                yield return new attitude(19, 65, 70, 46, 57, 75, 85, 46);
                yield return new attitude(20, 50, 58, 68, 54, 64, 78, 52);
                yield return new attitude(21, 50, 40, 33, 34, 43, 64, 33);
                yield return new attitude(22, 64, 61, 52, 62, 66, 80, 41);
                yield return new attitude(23, 53, 66, 52, 50, 63, 80, 37);
                yield return new attitude(24, 40, 37, 42, 58, 50, 57, 49);
                yield return new attitude(25, 63, 54, 42, 48, 66, 75, 33);
                yield return new attitude(26, 66, 77, 66, 63, 88, 76, 72);
                yield return new attitude(27, 78, 75, 58, 74, 80, 78, 49);
                yield return new attitude(28, 48, 57, 44, 45, 51, 83, 38);
                yield return new attitude(29, 85, 85, 71, 71, 77, 74, 55);
                yield return new attitude(30, 82, 82, 39, 59, 64, 78, 39);
            }
        }
    }
}
