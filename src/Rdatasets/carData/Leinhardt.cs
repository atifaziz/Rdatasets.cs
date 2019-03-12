// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data on Infant-Mortality
    /// </summary>

    public class Leinhardt
    {
        public readonly string κ;
        public readonly int income;
        public readonly double? infant;
        public readonly string region;
        public readonly string oil;

        public Leinhardt(string κ, int income, double? infant, string region, string oil)
        {
            this.κ = κ;
            this.income = income;
            this.infant = infant;
            this.region = region;
            this.oil = oil;
        }

        public static IEnumerable<Leinhardt> Data
        {
            get
            {
                yield return new Leinhardt("Australia", 3426, 26.7, "Asia", "no");
                yield return new Leinhardt("Austria", 3350, 23.7, "Europe", "no");
                yield return new Leinhardt("Belgium", 3346, 17, "Europe", "no");
                yield return new Leinhardt("Canada", 4751, 16.8, "Americas", "no");
                yield return new Leinhardt("Denmark", 5029, 13.5, "Europe", "no");
                yield return new Leinhardt("Finland", 3312, 10.1, "Europe", "no");
                yield return new Leinhardt("France", 3403, 12.9, "Europe", "no");
                yield return new Leinhardt("West.Germany", 5040, 20.4, "Europe", "no");
                yield return new Leinhardt("Ireland", 2009, 17.8, "Europe", "no");
                yield return new Leinhardt("Italy", 2298, 25.7, "Europe", "no");
                yield return new Leinhardt("Japan", 3292, 11.7, "Europe", "no");
                yield return new Leinhardt("Netherlands", 4103, 11.6, "Europe", "no");
                yield return new Leinhardt("New.Zealand", 3723, 16.2, "Asia", "no");
                yield return new Leinhardt("Norway", 4102, 11.3, "Europe", "no");
                yield return new Leinhardt("Portugal", 956, 44.8, "Europe", "no");
                yield return new Leinhardt("South.Africa", 1000, 71.5, "Africa", "no");
                yield return new Leinhardt("Sweden", 5596, 9.6, "Europe", "no");
                yield return new Leinhardt("Switzerland", 2963, 12.8, "Europe", "no");
                yield return new Leinhardt("Britain", 2503, 17.5, "Europe", "no");
                yield return new Leinhardt("United.States", 5523, 17.6, "Americas", "no");
                yield return new Leinhardt("Algeria", 400, 86.3, "Africa", "yes");
                yield return new Leinhardt("Ecuador", 250, 78.5, "Americas", "yes");
                yield return new Leinhardt("Indonesia", 110, 125, "Asia", "yes");
                yield return new Leinhardt("Iran", 1280, null, "Asia", "yes");
                yield return new Leinhardt("Iraq", 560, 28.1, "Asia", "yes");
                yield return new Leinhardt("Libya", 3010, 300, "Africa", "yes");
                yield return new Leinhardt("Nigeria", 220, 58, "Africa", "yes");
                yield return new Leinhardt("Saudi.Arabia", 1530, 650, "Asia", "yes");
                yield return new Leinhardt("Venezuela", 1240, 51.7, "Americas", "yes");
                yield return new Leinhardt("Argentina", 1191, 59.6, "Americas", "no");
                yield return new Leinhardt("Brazil", 425, 170, "Americas", "no");
                yield return new Leinhardt("Chile", 590, 78, "Americas", "no");
                yield return new Leinhardt("Colombia", 426, 62.8, "Americas", "no");
                yield return new Leinhardt("Costa.Rica", 725, 54.4, "Americas", "no");
                yield return new Leinhardt("Dominican.Republic", 406, 48.8, "Americas", "no");
                yield return new Leinhardt("Greece", 1760, 27.8, "Europe", "no");
                yield return new Leinhardt("Guatemala", 302, 79.1, "Americas", "no");
                yield return new Leinhardt("Israel", 2526, 22.1, "Asia", "no");
                yield return new Leinhardt("Jamaica", 727, 26.2, "Americas", "no");
                yield return new Leinhardt("Lebanon", 631, 13.6, "Asia", "no");
                yield return new Leinhardt("Malaysia", 295, 32, "Asia", "no");
                yield return new Leinhardt("Mexico", 684, 60.9, "Americas", "no");
                yield return new Leinhardt("Nicaragua", 507, 46, "Americas", "no");
                yield return new Leinhardt("Panama", 754, 34.1, "Americas", "no");
                yield return new Leinhardt("Peru", 335, 65.1, "Americas", "no");
                yield return new Leinhardt("Singapore", 1268, 20.4, "Asia", "no");
                yield return new Leinhardt("Spain", 1256, 15.1, "Europe", "no");
                yield return new Leinhardt("Taiwan", 261, 19.1, "Asia", "no");
                yield return new Leinhardt("Trinidad.and.Tobago", 732, 26.2, "Americas", "no");
                yield return new Leinhardt("Tunisia", 434, 76.3, "Africa", "no");
                yield return new Leinhardt("Uruguay", 799, 40.4, "Americas", "no");
                yield return new Leinhardt("Yugoslavia", 406, 43.3, "Europe", "no");
                yield return new Leinhardt("Zambia", 310, 259, "Africa", "no");
                yield return new Leinhardt("Bolivia", 200, 60.4, "Americas", "no");
                yield return new Leinhardt("Cameroon", 100, 137, "Africa", "no");
                yield return new Leinhardt("Congo", 281, 180, "Africa", "no");
                yield return new Leinhardt("Egypt", 210, 114, "Africa", "no");
                yield return new Leinhardt("El.Salvador", 319, 58.2, "Americas", "no");
                yield return new Leinhardt("Ghana", 217, 63.7, "Africa", "no");
                yield return new Leinhardt("Honduras", 284, 39.3, "Americas", "no");
                yield return new Leinhardt("Ivory.Coast", 387, 138, "Africa", "no");
                yield return new Leinhardt("Jordan", 334, 21.3, "Asia", "no");
                yield return new Leinhardt("South.Korea", 344, 58, "Asia", "no");
                yield return new Leinhardt("Liberia", 197, 159.2, "Africa", "no");
                yield return new Leinhardt("Moroco", 279, 149, "Africa", "no");
                yield return new Leinhardt("Papua.New.Guinea", 477, 10.2, "Asia", "no");
                yield return new Leinhardt("Paraguay", 347, 38.6, "Americas", "no");
                yield return new Leinhardt("Philippines", 230, 67.9, "Asia", "no");
                yield return new Leinhardt("Syria", 334, 21.7, "Asia", "no");
                yield return new Leinhardt("Thailand", 210, 27, "Asia", "no");
                yield return new Leinhardt("Turkey", 435, 153, "Asia", "no");
                yield return new Leinhardt("South.Vietnam", 130, 100, "Asia", "no");
                yield return new Leinhardt("Afganistan", 75, 400, "Asia", "no");
                yield return new Leinhardt("Bangladesh", 100, 124.3, "Asia", "no");
                yield return new Leinhardt("Burma", 73, 200, "Asia", "no");
                yield return new Leinhardt("Burundi", 68, 150, "Africa", "no");
                yield return new Leinhardt("Cambodia", 123, 100, "Asia", "no");
                yield return new Leinhardt("Central.African.Republic", 122, 190, "Africa", "no");
                yield return new Leinhardt("Chad", 70, 160, "Africa", "no");
                yield return new Leinhardt("Dahomey", 81, 109.6, "Africa", "no");
                yield return new Leinhardt("Ethiopia", 79, 84.2, "Africa", "no");
                yield return new Leinhardt("Guinea", 79, 216, "Africa", "no");
                yield return new Leinhardt("Haiti", 100, null, "Americas", "no");
                yield return new Leinhardt("India", 93, 60.6, "Asia", "no");
                yield return new Leinhardt("Kenya", 169, 55, "Africa", "no");
                yield return new Leinhardt("Laos", 71, null, "Asia", "no");
                yield return new Leinhardt("Madagascar", 120, 102, "Africa", "no");
                yield return new Leinhardt("Malawi", 130, 148.3, "Africa", "no");
                yield return new Leinhardt("Mali", 50, 120, "Africa", "no");
                yield return new Leinhardt("Mauritania", 174, 187, "Africa", "no");
                yield return new Leinhardt("Nepal", 90, null, "Asia", "no");
                yield return new Leinhardt("Niger", 70, 200, "Africa", "no");
                yield return new Leinhardt("Pakistan", 102, 124.3, "Asia", "no");
                yield return new Leinhardt("Rwanda", 61, 132.9, "Africa", "no");
                yield return new Leinhardt("Sierra.Leone", 148, 170, "Africa", "no");
                yield return new Leinhardt("Somalia", 85, 158, "Africa", "no");
                yield return new Leinhardt("Sri.Lanka", 162, 45.1, "Asia", "no");
                yield return new Leinhardt("Sudan", 125, 129.4, "Africa", "no");
                yield return new Leinhardt("Tanzania", 120, 162.5, "Africa", "no");
                yield return new Leinhardt("Togo", 160, 127, "Africa", "no");
                yield return new Leinhardt("Uganda", 134, 160, "Africa", "no");
                yield return new Leinhardt("Upper.Volta", 82, 180, "Africa", "no");
                yield return new Leinhardt("Southern.Yemen", 96, 80, "Asia", "no");
                yield return new Leinhardt("Yemen", 77, 50, "Asia", "no");
                yield return new Leinhardt("Zaire", 118, 104, "Africa", "no");
            }
        }
    }
}
