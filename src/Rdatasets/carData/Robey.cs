// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Fertility and Contraception
    /// </summary>

    public class Robey
    {
        public readonly string region;
        public readonly double tfr;
        public readonly int contraceptors;

        public Robey(string region, double tfr, int contraceptors)
        {
            this.region = region;
            this.tfr = tfr;
            this.contraceptors = contraceptors;
        }

        public static IEnumerable<Robey> Data
        {
            get
            {
                yield return new Robey("Africa", 4.8, 35);
                yield return new Robey("Africa", 6.5, 9);
                yield return new Robey("Africa", 5.9, 16);
                yield return new Robey("Africa", 6.1, 13);
                yield return new Robey("Africa", 6.5, 27);
                yield return new Robey("Africa", 6.4, 6);
                yield return new Robey("Africa", 6.8, 5);
                yield return new Robey("Africa", 2.2, 75);
                yield return new Robey("Africa", 7.3, 4);
                yield return new Robey("Africa", 5.7, 6);
                yield return new Robey("Africa", 6.4, 12);
                yield return new Robey("Africa", 4.8, 9);
                yield return new Robey("Africa", 5, 21);
                yield return new Robey("Africa", 6.1, 10);
                yield return new Robey("Africa", 6.1, 12);
                yield return new Robey("Africa", 7.2, 5);
                yield return new Robey("Africa", 6.3, 15);
                yield return new Robey("Africa", 5.3, 45);
                yield return new Robey("Asia", 5.5, 40);
                yield return new Robey("Asia", 2.5, 72);
                yield return new Robey("Asia", 4.3, 45);
                yield return new Robey("Asia", 3, 50);
                yield return new Robey("Asia", 1.7, 77);
                yield return new Robey("Asia", 5.2, 12);
                yield return new Robey("Asia", 4.3, 34);
                yield return new Robey("Asia", 2.7, 62);
                yield return new Robey("Asia", 2.3, 68);
                yield return new Robey("Asia", 3.9, 53);
                yield return new Robey("Latin.Amer", 4.5, 47);
                yield return new Robey("Latin.Amer", 4.9, 32);
                yield return new Robey("Latin.Amer", 3.6, 66);
                yield return new Robey("Latin.Amer", 2.8, 66);
                yield return new Robey("Latin.Amer", 3.6, 70);
                yield return new Robey("Latin.Amer", 3.3, 56);
                yield return new Robey("Latin.Amer", 3.8, 53);
                yield return new Robey("Latin.Amer", 4.6, 47);
                yield return new Robey("Latin.Amer", 5.6, 23);
                yield return new Robey("Latin.Amer", 6, 10);
                yield return new Robey("Latin.Amer", 2.9, 55);
                yield return new Robey("Latin.Amer", 4, 55);
                yield return new Robey("Latin.Amer", 4, 58);
                yield return new Robey("Latin.Amer", 4.6, 48);
                yield return new Robey("Latin.Amer", 3.5, 59);
                yield return new Robey("Latin.Amer", 3.1, 54);
                yield return new Robey("Near.East", 4.6, 40);
                yield return new Robey("Near.East", 5.5, 35);
                yield return new Robey("Near.East", 4, 42);
                yield return new Robey("Near.East", 4.3, 51);
                yield return new Robey("Near.East", 3.4, 60);
                yield return new Robey("Near.East", 7, 7);
            }
        }
    }
}
