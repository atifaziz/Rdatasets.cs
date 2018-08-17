// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from an Oats Field Trial
    /// </summary>

    public class oats
    {
        public readonly string B;
        public readonly string V;
        public readonly string N;
        public readonly int Y;

        public oats(string B, string V, string N, int Y)
        {
            this.B = B;
            this.V = V;
            this.N = N;
            this.Y = Y;
        }

        public static IEnumerable<oats> Data
        {
            get
            {
                yield return new oats("I", "Victory", "0.0cwt", 111);
                yield return new oats("I", "Victory", "0.2cwt", 130);
                yield return new oats("I", "Victory", "0.4cwt", 157);
                yield return new oats("I", "Victory", "0.6cwt", 174);
                yield return new oats("I", "Golden.rain", "0.0cwt", 117);
                yield return new oats("I", "Golden.rain", "0.2cwt", 114);
                yield return new oats("I", "Golden.rain", "0.4cwt", 161);
                yield return new oats("I", "Golden.rain", "0.6cwt", 141);
                yield return new oats("I", "Marvellous", "0.0cwt", 105);
                yield return new oats("I", "Marvellous", "0.2cwt", 140);
                yield return new oats("I", "Marvellous", "0.4cwt", 118);
                yield return new oats("I", "Marvellous", "0.6cwt", 156);
                yield return new oats("II", "Victory", "0.0cwt", 61);
                yield return new oats("II", "Victory", "0.2cwt", 91);
                yield return new oats("II", "Victory", "0.4cwt", 97);
                yield return new oats("II", "Victory", "0.6cwt", 100);
                yield return new oats("II", "Golden.rain", "0.0cwt", 70);
                yield return new oats("II", "Golden.rain", "0.2cwt", 108);
                yield return new oats("II", "Golden.rain", "0.4cwt", 126);
                yield return new oats("II", "Golden.rain", "0.6cwt", 149);
                yield return new oats("II", "Marvellous", "0.0cwt", 96);
                yield return new oats("II", "Marvellous", "0.2cwt", 124);
                yield return new oats("II", "Marvellous", "0.4cwt", 121);
                yield return new oats("II", "Marvellous", "0.6cwt", 144);
                yield return new oats("III", "Victory", "0.0cwt", 68);
                yield return new oats("III", "Victory", "0.2cwt", 64);
                yield return new oats("III", "Victory", "0.4cwt", 112);
                yield return new oats("III", "Victory", "0.6cwt", 86);
                yield return new oats("III", "Golden.rain", "0.0cwt", 60);
                yield return new oats("III", "Golden.rain", "0.2cwt", 102);
                yield return new oats("III", "Golden.rain", "0.4cwt", 89);
                yield return new oats("III", "Golden.rain", "0.6cwt", 96);
                yield return new oats("III", "Marvellous", "0.0cwt", 89);
                yield return new oats("III", "Marvellous", "0.2cwt", 129);
                yield return new oats("III", "Marvellous", "0.4cwt", 132);
                yield return new oats("III", "Marvellous", "0.6cwt", 124);
                yield return new oats("IV", "Victory", "0.0cwt", 74);
                yield return new oats("IV", "Victory", "0.2cwt", 89);
                yield return new oats("IV", "Victory", "0.4cwt", 81);
                yield return new oats("IV", "Victory", "0.6cwt", 122);
                yield return new oats("IV", "Golden.rain", "0.0cwt", 64);
                yield return new oats("IV", "Golden.rain", "0.2cwt", 103);
                yield return new oats("IV", "Golden.rain", "0.4cwt", 132);
                yield return new oats("IV", "Golden.rain", "0.6cwt", 133);
                yield return new oats("IV", "Marvellous", "0.0cwt", 70);
                yield return new oats("IV", "Marvellous", "0.2cwt", 89);
                yield return new oats("IV", "Marvellous", "0.4cwt", 104);
                yield return new oats("IV", "Marvellous", "0.6cwt", 117);
                yield return new oats("V", "Victory", "0.0cwt", 62);
                yield return new oats("V", "Victory", "0.2cwt", 90);
                yield return new oats("V", "Victory", "0.4cwt", 100);
                yield return new oats("V", "Victory", "0.6cwt", 116);
                yield return new oats("V", "Golden.rain", "0.0cwt", 80);
                yield return new oats("V", "Golden.rain", "0.2cwt", 82);
                yield return new oats("V", "Golden.rain", "0.4cwt", 94);
                yield return new oats("V", "Golden.rain", "0.6cwt", 126);
                yield return new oats("V", "Marvellous", "0.0cwt", 63);
                yield return new oats("V", "Marvellous", "0.2cwt", 70);
                yield return new oats("V", "Marvellous", "0.4cwt", 109);
                yield return new oats("V", "Marvellous", "0.6cwt", 99);
                yield return new oats("VI", "Victory", "0.0cwt", 53);
                yield return new oats("VI", "Victory", "0.2cwt", 74);
                yield return new oats("VI", "Victory", "0.4cwt", 118);
                yield return new oats("VI", "Victory", "0.6cwt", 113);
                yield return new oats("VI", "Golden.rain", "0.0cwt", 89);
                yield return new oats("VI", "Golden.rain", "0.2cwt", 82);
                yield return new oats("VI", "Golden.rain", "0.4cwt", 86);
                yield return new oats("VI", "Golden.rain", "0.6cwt", 104);
                yield return new oats("VI", "Marvellous", "0.0cwt", 97);
                yield return new oats("VI", "Marvellous", "0.2cwt", 99);
                yield return new oats("VI", "Marvellous", "0.4cwt", 119);
                yield return new oats("VI", "Marvellous", "0.6cwt", 121);
            }
        }
    }
}
