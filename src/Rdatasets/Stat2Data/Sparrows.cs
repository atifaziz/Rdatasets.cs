// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Sparrows
    /// </summary>

    public class Sparrows
    {
        public readonly string Treatment;
        public readonly double Weight;
        public readonly double WingLength;

        public Sparrows(string Treatment, double Weight, double WingLength)
        {
            this.Treatment = Treatment;
            this.Weight = Weight;
            this.WingLength = WingLength;
        }

        public static IEnumerable<Sparrows> Data
        {
            get
            {
                yield return new Sparrows("control", 14.9, 29);
                yield return new Sparrows("control", 15, 31);
                yield return new Sparrows("control", 14.3, 25);
                yield return new Sparrows("control", 17, 29);
                yield return new Sparrows("control", 16, 30);
                yield return new Sparrows("control", 16.2, 31.5);
                yield return new Sparrows("control", 12.4, 23.5);
                yield return new Sparrows("control", 14.6, 26);
                yield return new Sparrows("control", 12.2, 25.5);
                yield return new Sparrows("control", 13, 27);
                yield return new Sparrows("control", 12.9, 29.5);
                yield return new Sparrows("control", 13.2, 27.5);
                yield return new Sparrows("control", 13.6, 29.5);
                yield return new Sparrows("control", 16.2, 31);
                yield return new Sparrows("control", 15, 29.5);
                yield return new Sparrows("control", 17.5, 30.5);
                yield return new Sparrows("control", 14.8, 26.5);
                yield return new Sparrows("control", 15.7, 28);
                yield return new Sparrows("control", 15.5, 29);
                yield return new Sparrows("control", 14.4, 23);
                yield return new Sparrows("control", 16, 24);
                yield return new Sparrows("control", 13.5, 23);
                yield return new Sparrows("control", 13.2, 24.5);
                yield return new Sparrows("control", 15.6, 31);
                yield return new Sparrows("control", 15.1, 31);
                yield return new Sparrows("control", 16.6, 30);
                yield return new Sparrows("control", 10.1, 23);
                yield return new Sparrows("control", 13.1, 25.5);
                yield return new Sparrows("control", 15.1, 29);
                yield return new Sparrows("control", 14.2, 29.5);
                yield return new Sparrows("control", 13.3, 28.5);
                yield return new Sparrows("control", 12.2, 26);
                yield return new Sparrows("control", 13.4, 29.5);
                yield return new Sparrows("control", 12.4, 26);
                yield return new Sparrows("control", 14.3, 28);
                yield return new Sparrows("control", 15.9, 32.5);
                yield return new Sparrows("control", 12.8, 26.5);
                yield return new Sparrows("control", 11.9, 24);
                yield return new Sparrows("control", 12.2, 18);
                yield return new Sparrows("control", 14.8, 27);
                yield return new Sparrows("control", 14.9, 26.5);
                yield return new Sparrows("control", 10.2, 23);
                yield return new Sparrows("control", 18.5, 32);
                yield return new Sparrows("control", 7.6, 15);
                yield return new Sparrows("control", 5.3, 16);
                yield return new Sparrows("enlarged", 14.2, 28.5);
                yield return new Sparrows("enlarged", 14.4, 29);
                yield return new Sparrows("enlarged", 13.4, 32.5);
                yield return new Sparrows("enlarged", 11.3, 26);
                yield return new Sparrows("enlarged", 13.2, 29.5);
                yield return new Sparrows("enlarged", 12.2, 26);
                yield return new Sparrows("enlarged", 14.4, 30.5);
                yield return new Sparrows("enlarged", 13.4, 27.5);
                yield return new Sparrows("enlarged", 13.1, 30.5);
                yield return new Sparrows("enlarged", 13.9, 28.5);
                yield return new Sparrows("enlarged", 13.5, 29.5);
                yield return new Sparrows("enlarged", 15, 30);
                yield return new Sparrows("enlarged", 11.8, 26);
                yield return new Sparrows("enlarged", 12, 24);
                yield return new Sparrows("enlarged", 9.5, 24);
                yield return new Sparrows("enlarged", 14, 25.5);
                yield return new Sparrows("enlarged", 10, 24);
                yield return new Sparrows("enlarged", 13.7, 27.5);
                yield return new Sparrows("enlarged", 15.3, 30);
                yield return new Sparrows("enlarged", 17.3, 32);
                yield return new Sparrows("enlarged", 14.4, 31.5);
                yield return new Sparrows("enlarged", 15.8, 30.5);
                yield return new Sparrows("enlarged", 17.1, 32);
                yield return new Sparrows("enlarged", 10.7, 19.5);
                yield return new Sparrows("enlarged", 12.1, 19.5);
                yield return new Sparrows("enlarged", 12.7, 20);
                yield return new Sparrows("enlarged", 13.2, 20);
                yield return new Sparrows("enlarged", 13.6, 19.5);
                yield return new Sparrows("enlarged", 9.4, 20);
                yield return new Sparrows("enlarged", 15.9, 29.5);
                yield return new Sparrows("enlarged", 12.7, 26.5);
                yield return new Sparrows("enlarged", 13.6, 26.5);
                yield return new Sparrows("enlarged", 15.1, 28.5);
                yield return new Sparrows("enlarged", 15.3, 30.5);
                yield return new Sparrows("enlarged", 14.2, 30);
                yield return new Sparrows("enlarged", 8.3, 18.5);
                yield return new Sparrows("enlarged", 15.5, 31);
                yield return new Sparrows("enlarged", 15.6, 30);
                yield return new Sparrows("enlarged", 15.4, 29);
                yield return new Sparrows("enlarged", 14.9, 28.5);
                yield return new Sparrows("enlarged", 13.5, 26);
                yield return new Sparrows("enlarged", 15.8, 28);
                yield return new Sparrows("enlarged", 13.7, 29);
                yield return new Sparrows("enlarged", 15.4, 29.5);
                yield return new Sparrows("enlarged", 8.7, 21);
                yield return new Sparrows("reduced", 16, 30);
                yield return new Sparrows("reduced", 15.8, 31);
                yield return new Sparrows("reduced", 16.6, 31);
                yield return new Sparrows("reduced", 17.2, 32.5);
                yield return new Sparrows("reduced", 16.8, 29.5);
                yield return new Sparrows("reduced", 16.7, 30.5);
                yield return new Sparrows("reduced", 16.2, 28.5);
                yield return new Sparrows("reduced", 17.1, 29);
                yield return new Sparrows("reduced", 13, 24);
                yield return new Sparrows("reduced", 13.4, 24.5);
                yield return new Sparrows("reduced", 13.3, 22.5);
                yield return new Sparrows("reduced", 15.5, 27.5);
                yield return new Sparrows("reduced", 16.4, 27.5);
                yield return new Sparrows("reduced", 15.4, 29.5);
                yield return new Sparrows("reduced", 16.1, 29);
                yield return new Sparrows("reduced", 16.8, 30.5);
                yield return new Sparrows("reduced", 15.7, 29);
                yield return new Sparrows("reduced", 15.8, 27.5);
                yield return new Sparrows("reduced", 17, 32);
                yield return new Sparrows("reduced", 16.8, 34);
                yield return new Sparrows("reduced", 15.5, 29.5);
                yield return new Sparrows("reduced", 12.6, 25);
                yield return new Sparrows("reduced", 14.3, 26);
                yield return new Sparrows("reduced", 12.5, 26);
                yield return new Sparrows("reduced", 16.7, 29);
                yield return new Sparrows("reduced", 15.6, 28);
            }
        }
    }
}
