// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Fertility and Contraception
    /// </summary>

    public class Robey
    {
        public readonly string κ;
        public readonly string region;
        public readonly double tfr;
        public readonly int contraceptors;

        public Robey(string κ, string region, double tfr, int contraceptors)
        {
            this.κ = κ;
            this.region = region;
            this.tfr = tfr;
            this.contraceptors = contraceptors;
        }

        public static IEnumerable<Robey> Data
        {
            get
            {
                yield return new Robey("Botswana", "Africa", 4.8, 35);
                yield return new Robey("Burundi", "Africa", 6.5, 9);
                yield return new Robey("Cameroon", "Africa", 5.9, 16);
                yield return new Robey("Ghana", "Africa", 6.1, 13);
                yield return new Robey("Kenya", "Africa", 6.5, 27);
                yield return new Robey("Liberia", "Africa", 6.4, 6);
                yield return new Robey("Mali", "Africa", 6.8, 5);
                yield return new Robey("Mauitius", "Africa", 2.2, 75);
                yield return new Robey("Niger", "Africa", 7.3, 4);
                yield return new Robey("Nigeria", "Africa", 5.7, 6);
                yield return new Robey("Senegal", "Africa", 6.4, 12);
                yield return new Robey("Sudan", "Africa", 4.8, 9);
                yield return new Robey("Swaziland", "Africa", 5, 21);
                yield return new Robey("Tanzania", "Africa", 6.1, 10);
                yield return new Robey("Togo", "Africa", 6.1, 12);
                yield return new Robey("Uganda", "Africa", 7.2, 5);
                yield return new Robey("Zambia", "Africa", 6.3, 15);
                yield return new Robey("Zimbabwe", "Africa", 5.3, 45);
                yield return new Robey("Bangladesh", "Asia", 5.5, 40);
                yield return new Robey("China", "Asia", 2.5, 72);
                yield return new Robey("India", "Asia", 4.3, 45);
                yield return new Robey("Indonesia", "Asia", 3, 50);
                yield return new Robey("Korea.Rep.of", "Asia", 1.7, 77);
                yield return new Robey("Pakistan", "Asia", 5.2, 12);
                yield return new Robey("Philippines", "Asia", 4.3, 34);
                yield return new Robey("Sri.Lanka", "Asia", 2.7, 62);
                yield return new Robey("Thailand", "Asia", 2.3, 68);
                yield return new Robey("Vietnam", "Asia", 3.9, 53);
                yield return new Robey("Belize", "Latin.Amer", 4.5, 47);
                yield return new Robey("Bolivia", "Latin.Amer", 4.9, 32);
                yield return new Robey("Brazil", "Latin.Amer", 3.6, 66);
                yield return new Robey("Columbia", "Latin.Amer", 2.8, 66);
                yield return new Robey("Costa.Rica", "Latin.Amer", 3.6, 70);
                yield return new Robey("Dom.Republic", "Latin.Amer", 3.3, 56);
                yield return new Robey("Ecuador", "Latin.Amer", 3.8, 53);
                yield return new Robey("El.Salvador", "Latin.Amer", 4.6, 47);
                yield return new Robey("Guatemala", "Latin.Amer", 5.6, 23);
                yield return new Robey("Haiti", "Latin.Amer", 6, 10);
                yield return new Robey("Jamaica", "Latin.Amer", 2.9, 55);
                yield return new Robey("Mexico", "Latin.Amer", 4, 55);
                yield return new Robey("Panama", "Latin.Amer", 4, 58);
                yield return new Robey("Paraguay", "Latin.Amer", 4.6, 48);
                yield return new Robey("Peru", "Latin.Amer", 3.5, 59);
                yield return new Robey("Trinidad.Tobago", "Latin.Amer", 3.1, 54);
                yield return new Robey("Egypt", "Near.East", 4.6, 40);
                yield return new Robey("Jordan", "Near.East", 5.5, 35);
                yield return new Robey("Morocco", "Near.East", 4, 42);
                yield return new Robey("Tunisia", "Near.East", 4.3, 51);
                yield return new Robey("Turkey", "Near.East", 3.4, 60);
                yield return new Robey("Yemen", "Near.East", 7, 7);
            }
        }
    }
}
