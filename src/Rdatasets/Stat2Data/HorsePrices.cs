// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// HorsePrices
    /// </summary>

    public class HorsePrices
    {
        public readonly int κ;
        public readonly int HorseID;
        public readonly int Price;
        public readonly double Age;
        public readonly double? Height;
        public readonly string Sex;

        public HorsePrices(int κ, int HorseID, int Price, double Age, double? Height, string Sex)
        {
            this.κ = κ;
            this.HorseID = HorseID;
            this.Price = Price;
            this.Age = Age;
            this.Height = Height;
            this.Sex = Sex;
        }

        public static IEnumerable<HorsePrices> Data
        {
            get
            {
                yield return new HorsePrices(1, 97, 38000, 3, 16.75, "m");
                yield return new HorsePrices(2, 156, 40000, 5, 17, "m");
                yield return new HorsePrices(3, 56, 10000, 1, null, "m");
                yield return new HorsePrices(4, 139, 12000, 8, 16, "f");
                yield return new HorsePrices(5, 65, 25000, 4, 16.25, "m");
                yield return new HorsePrices(6, 184, 35000, 8, 16.25, "f");
                yield return new HorsePrices(7, 88, 35000, 5, 16.5, "m");
                yield return new HorsePrices(8, 182, 12000, 17, 16.75, "f");
                yield return new HorsePrices(9, 101, 22000, 4, 17.25, "m");
                yield return new HorsePrices(10, 135, 25000, 6, 15.25, "f");
                yield return new HorsePrices(11, 35, 40000, 7, 16.75, "m");
                yield return new HorsePrices(12, 39, 25000, 7, 15.75, "f");
                yield return new HorsePrices(13, 198, 4500, 14, 16, "f");
                yield return new HorsePrices(14, 107, 19900, 6, 15.5, "m");
                yield return new HorsePrices(15, 148, 45000, 3, 15.75, "f");
                yield return new HorsePrices(16, 102, 45000, 6, 16.75, "m");
                yield return new HorsePrices(17, 96, 48000, 6, 16.5, "m");
                yield return new HorsePrices(18, 71, 15500, 12, 15.75, "f");
                yield return new HorsePrices(19, 28, 8500, 7, 16.25, "f");
                yield return new HorsePrices(20, 30, 22000, 7, 16.5, "f");
                yield return new HorsePrices(21, 31, 35000, 5, 16.25, "m");
                yield return new HorsePrices(22, 60, 16000, 7, 16.25, "m");
                yield return new HorsePrices(23, 23, 16000, 3, 16.25, "m");
                yield return new HorsePrices(24, 115, 15000, 7, 16.25, "f");
                yield return new HorsePrices(25, 234, 33000, 4, 16.5, "m");
                yield return new HorsePrices(26, 132, 20000, 14, 16.5, "m");
                yield return new HorsePrices(27, 69, 25000, 6, 17, "m");
                yield return new HorsePrices(28, 141, 30000, 8, 16.75, "m");
                yield return new HorsePrices(29, 63, 50000, 6, 16.75, "m");
                yield return new HorsePrices(30, 164, 1100, 19, 16.25, "f");
                yield return new HorsePrices(31, 178, 15000, 0.5, 14.25, "f");
                yield return new HorsePrices(32, 4, 45000, 14, 17, "m");
                yield return new HorsePrices(33, 211, 2000, 20, 16, "f");
                yield return new HorsePrices(34, 89, 20000, 3, 15.75, "f");
                yield return new HorsePrices(35, 57, 45000, 5, 16.5, "m");
                yield return new HorsePrices(36, 200, 20000, 12, 17, "m");
                yield return new HorsePrices(37, 38, 50000, 7, 17.25, "m");
                yield return new HorsePrices(38, 2, 50000, 8, 16.5, "m");
                yield return new HorsePrices(39, 248, 39000, 11, 17.25, "m");
                yield return new HorsePrices(40, 27, 20000, 11, 16.75, "m");
                yield return new HorsePrices(41, 19, 12000, 6, 16.5, "f");
                yield return new HorsePrices(42, 129, 15000, 2, 15, "f");
                yield return new HorsePrices(43, 13, 27500, 5, 16, "f");
                yield return new HorsePrices(44, 206, 12000, 2, null, "f");
                yield return new HorsePrices(45, 236, 6000, 0.5, null, "f");
                yield return new HorsePrices(46, 179, 15000, 0.5, 14.5, "m");
                yield return new HorsePrices(47, 232, 60000, 13, 16.75, "m");
                yield return new HorsePrices(48, 152, 50000, 4, 16.5, "m");
                yield return new HorsePrices(49, 36, 30000, 9, 16.5, "m");
                yield return new HorsePrices(50, 249, 40000, 7, 17.25, "m");
            }
        }
    }
}
