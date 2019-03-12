// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from an Oats Field Trial
    /// </summary>

    public class oats
    {
        public readonly int κ;
        public readonly string B;
        public readonly string V;
        public readonly string N;
        public readonly int Y;

        public oats(int κ, string B, string V, string N, int Y)
        {
            this.κ = κ;
            this.B = B;
            this.V = V;
            this.N = N;
            this.Y = Y;
        }

        public static IEnumerable<oats> Data
        {
            get
            {
                yield return new oats(1, "I", "Victory", "0.0cwt", 111);
                yield return new oats(2, "I", "Victory", "0.2cwt", 130);
                yield return new oats(3, "I", "Victory", "0.4cwt", 157);
                yield return new oats(4, "I", "Victory", "0.6cwt", 174);
                yield return new oats(5, "I", "Golden.rain", "0.0cwt", 117);
                yield return new oats(6, "I", "Golden.rain", "0.2cwt", 114);
                yield return new oats(7, "I", "Golden.rain", "0.4cwt", 161);
                yield return new oats(8, "I", "Golden.rain", "0.6cwt", 141);
                yield return new oats(9, "I", "Marvellous", "0.0cwt", 105);
                yield return new oats(10, "I", "Marvellous", "0.2cwt", 140);
                yield return new oats(11, "I", "Marvellous", "0.4cwt", 118);
                yield return new oats(12, "I", "Marvellous", "0.6cwt", 156);
                yield return new oats(13, "II", "Victory", "0.0cwt", 61);
                yield return new oats(14, "II", "Victory", "0.2cwt", 91);
                yield return new oats(15, "II", "Victory", "0.4cwt", 97);
                yield return new oats(16, "II", "Victory", "0.6cwt", 100);
                yield return new oats(17, "II", "Golden.rain", "0.0cwt", 70);
                yield return new oats(18, "II", "Golden.rain", "0.2cwt", 108);
                yield return new oats(19, "II", "Golden.rain", "0.4cwt", 126);
                yield return new oats(20, "II", "Golden.rain", "0.6cwt", 149);
                yield return new oats(21, "II", "Marvellous", "0.0cwt", 96);
                yield return new oats(22, "II", "Marvellous", "0.2cwt", 124);
                yield return new oats(23, "II", "Marvellous", "0.4cwt", 121);
                yield return new oats(24, "II", "Marvellous", "0.6cwt", 144);
                yield return new oats(25, "III", "Victory", "0.0cwt", 68);
                yield return new oats(26, "III", "Victory", "0.2cwt", 64);
                yield return new oats(27, "III", "Victory", "0.4cwt", 112);
                yield return new oats(28, "III", "Victory", "0.6cwt", 86);
                yield return new oats(29, "III", "Golden.rain", "0.0cwt", 60);
                yield return new oats(30, "III", "Golden.rain", "0.2cwt", 102);
                yield return new oats(31, "III", "Golden.rain", "0.4cwt", 89);
                yield return new oats(32, "III", "Golden.rain", "0.6cwt", 96);
                yield return new oats(33, "III", "Marvellous", "0.0cwt", 89);
                yield return new oats(34, "III", "Marvellous", "0.2cwt", 129);
                yield return new oats(35, "III", "Marvellous", "0.4cwt", 132);
                yield return new oats(36, "III", "Marvellous", "0.6cwt", 124);
                yield return new oats(37, "IV", "Victory", "0.0cwt", 74);
                yield return new oats(38, "IV", "Victory", "0.2cwt", 89);
                yield return new oats(39, "IV", "Victory", "0.4cwt", 81);
                yield return new oats(40, "IV", "Victory", "0.6cwt", 122);
                yield return new oats(41, "IV", "Golden.rain", "0.0cwt", 64);
                yield return new oats(42, "IV", "Golden.rain", "0.2cwt", 103);
                yield return new oats(43, "IV", "Golden.rain", "0.4cwt", 132);
                yield return new oats(44, "IV", "Golden.rain", "0.6cwt", 133);
                yield return new oats(45, "IV", "Marvellous", "0.0cwt", 70);
                yield return new oats(46, "IV", "Marvellous", "0.2cwt", 89);
                yield return new oats(47, "IV", "Marvellous", "0.4cwt", 104);
                yield return new oats(48, "IV", "Marvellous", "0.6cwt", 117);
                yield return new oats(49, "V", "Victory", "0.0cwt", 62);
                yield return new oats(50, "V", "Victory", "0.2cwt", 90);
                yield return new oats(51, "V", "Victory", "0.4cwt", 100);
                yield return new oats(52, "V", "Victory", "0.6cwt", 116);
                yield return new oats(53, "V", "Golden.rain", "0.0cwt", 80);
                yield return new oats(54, "V", "Golden.rain", "0.2cwt", 82);
                yield return new oats(55, "V", "Golden.rain", "0.4cwt", 94);
                yield return new oats(56, "V", "Golden.rain", "0.6cwt", 126);
                yield return new oats(57, "V", "Marvellous", "0.0cwt", 63);
                yield return new oats(58, "V", "Marvellous", "0.2cwt", 70);
                yield return new oats(59, "V", "Marvellous", "0.4cwt", 109);
                yield return new oats(60, "V", "Marvellous", "0.6cwt", 99);
                yield return new oats(61, "VI", "Victory", "0.0cwt", 53);
                yield return new oats(62, "VI", "Victory", "0.2cwt", 74);
                yield return new oats(63, "VI", "Victory", "0.4cwt", 118);
                yield return new oats(64, "VI", "Victory", "0.6cwt", 113);
                yield return new oats(65, "VI", "Golden.rain", "0.0cwt", 89);
                yield return new oats(66, "VI", "Golden.rain", "0.2cwt", 82);
                yield return new oats(67, "VI", "Golden.rain", "0.4cwt", 86);
                yield return new oats(68, "VI", "Golden.rain", "0.6cwt", 104);
                yield return new oats(69, "VI", "Marvellous", "0.0cwt", 97);
                yield return new oats(70, "VI", "Marvellous", "0.2cwt", 99);
                yield return new oats(71, "VI", "Marvellous", "0.4cwt", 119);
                yield return new oats(72, "VI", "Marvellous", "0.6cwt", 121);
            }
        }
    }
}
