// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Clothing
    /// </summary>

    public class Clothing
    {
        public readonly int κ;
        public readonly int ID;
        public readonly int Amount;
        public readonly int Recency;
        public readonly int Freq12;
        public readonly int Dollar12;
        public readonly int Freq24;
        public readonly int Dollar24;
        public readonly int Card;

        public Clothing(int κ, int ID, int Amount, int Recency, int Freq12, int Dollar12, int Freq24, int Dollar24, int Card)
        {
            this.κ = κ;
            this.ID = ID;
            this.Amount = Amount;
            this.Recency = Recency;
            this.Freq12 = Freq12;
            this.Dollar12 = Dollar12;
            this.Freq24 = Freq24;
            this.Dollar24 = Dollar24;
            this.Card = Card;
        }

        public static IEnumerable<Clothing> Data
        {
            get
            {
                yield return new Clothing(1, 1, 0, 22, 0, 0, 3, 400, 0);
                yield return new Clothing(2, 2, 0, 30, 0, 0, 0, 0, 0);
                yield return new Clothing(3, 3, 0, 24, 0, 0, 1, 250, 0);
                yield return new Clothing(4, 4, 30, 6, 3, 140, 4, 225, 0);
                yield return new Clothing(5, 5, 33, 12, 1, 50, 1, 50, 0);
                yield return new Clothing(6, 6, 35, 48, 0, 0, 0, 0, 0);
                yield return new Clothing(7, 7, 35, 5, 5, 450, 6, 415, 0);
                yield return new Clothing(8, 8, 39, 2, 5, 245, 12, 661, 1);
                yield return new Clothing(9, 9, 40, 24, 0, 0, 1, 225, 0);
                yield return new Clothing(10, 10, 45, 3, 6, 403, 8, 1138, 0);
                yield return new Clothing(11, 11, 48, 6, 3, 155, 4, 262, 0);
                yield return new Clothing(12, 12, 50, 12, 1, 42, 7, 290, 0);
                yield return new Clothing(13, 13, 50, 5, 2, 100, 8, 700, 1);
                yield return new Clothing(14, 14, 50, 8, 3, 144, 4, 202, 0);
                yield return new Clothing(15, 15, 50, 1, 10, 562, 13, 595, 1);
                yield return new Clothing(16, 16, 50, 2, 3, 166, 4, 308, 0);
                yield return new Clothing(17, 17, 50, 4, 4, 228, 4, 228, 0);
                yield return new Clothing(18, 18, 50, 5, 5, 322, 7, 717, 1);
                yield return new Clothing(19, 19, 55, 13, 0, 0, 6, 1050, 0);
                yield return new Clothing(20, 20, 55, 6, 3, 244, 7, 811, 0);
                yield return new Clothing(21, 21, 57, 20, 0, 0, 2, 140, 0);
                yield return new Clothing(22, 22, 58, 3, 4, 200, 4, 818, 1);
                yield return new Clothing(23, 23, 60, 12, 1, 70, 2, 150, 0);
                yield return new Clothing(24, 24, 60, 3, 4, 256, 7, 468, 0);
                yield return new Clothing(25, 25, 62, 12, 1, 65, 5, 255, 0);
                yield return new Clothing(26, 26, 64, 8, 1, 70, 6, 300, 0);
                yield return new Clothing(27, 27, 65, 2, 6, 471, 8, 607, 0);
                yield return new Clothing(28, 28, 68, 6, 2, 110, 3, 150, 0);
                yield return new Clothing(29, 29, 70, 3, 3, 222, 5, 305, 0);
                yield return new Clothing(30, 30, 70, 6, 2, 120, 4, 230, 0);
                yield return new Clothing(31, 31, 70, 5, 3, 205, 8, 455, 1);
                yield return new Clothing(32, 32, 72, 7, 4, 445, 6, 400, 0);
                yield return new Clothing(33, 33, 75, 6, 1, 77, 2, 168, 0);
                yield return new Clothing(34, 34, 75, 4, 2, 166, 5, 404, 0);
                yield return new Clothing(35, 35, 75, 4, 3, 210, 4, 270, 0);
                yield return new Clothing(36, 36, 78, 8, 2, 180, 7, 555, 1);
                yield return new Clothing(37, 37, 78, 5, 3, 245, 9, 602, 1);
                yield return new Clothing(38, 38, 79, 4, 3, 225, 5, 350, 0);
                yield return new Clothing(39, 39, 80, 3, 4, 300, 6, 499, 0);
                yield return new Clothing(40, 40, 90, 3, 5, 400, 9, 723, 0);
                yield return new Clothing(41, 41, 95, 1, 6, 650, 9, 1006, 1);
                yield return new Clothing(42, 42, 98, 6, 2, 215, 3, 333, 0);
                yield return new Clothing(43, 43, 100, 12, 1, 100, 2, 200, 0);
                yield return new Clothing(44, 44, 100, 2, 1, 110, 4, 400, 1);
                yield return new Clothing(45, 45, 100, 3, 3, 217, 6, 605, 0);
                yield return new Clothing(46, 46, 100, 3, 4, 330, 8, 660, 1);
                yield return new Clothing(47, 47, 105, 2, 4, 400, 7, 560, 0);
                yield return new Clothing(48, 48, 110, 3, 4, 420, 6, 570, 0);
                yield return new Clothing(49, 49, 125, 3, 2, 270, 5, 590, 1);
                yield return new Clothing(50, 50, 140, 6, 3, 405, 6, 775, 0);
                yield return new Clothing(51, 51, 160, 2, 2, 411, 8, 706, 0);
                yield return new Clothing(52, 52, 180, 1, 5, 744, 10, 945, 1);
                yield return new Clothing(53, 53, 200, 1, 3, 558, 4, 755, 1);
                yield return new Clothing(54, 54, 240, 4, 4, 815, 10, 1150, 1);
                yield return new Clothing(55, 55, 250, 3, 3, 782, 10, 1500, 1);
                yield return new Clothing(56, 56, 300, 12, 1, 250, 4, 401, 0);
                yield return new Clothing(57, 57, 340, 1, 5, 1084, 7, 1162, 1);
                yield return new Clothing(58, 58, 500, 4, 2, 777, 3, 905, 1);
                yield return new Clothing(59, 59, 650, 1, 4, 1493, 7, 2050, 1);
                yield return new Clothing(60, 60, 1506000, 1, 6, 5000, 11, 8000, 1);
            }
        }
    }
}
