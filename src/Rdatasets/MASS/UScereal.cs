// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Nutritional and Marketing Information on US Cereals
    /// </summary>

    public class UScereal
    {
        public readonly string mfr;
        public readonly double calories;
        public readonly double protein;
        public readonly double fat;
        public readonly double sodium;
        public readonly double fibre;
        public readonly double carbo;
        public readonly double sugars;
        public readonly int shelf;
        public readonly double potassium;
        public readonly string vitamins;

        public UScereal(string mfr, double calories, double protein, double fat, double sodium, double fibre, double carbo, double sugars, int shelf, double potassium, string vitamins)
        {
            this.mfr = mfr;
            this.calories = calories;
            this.protein = protein;
            this.fat = fat;
            this.sodium = sodium;
            this.fibre = fibre;
            this.carbo = carbo;
            this.sugars = sugars;
            this.shelf = shelf;
            this.potassium = potassium;
            this.vitamins = vitamins;
        }

        public static IEnumerable<UScereal> Data
        {
            get
            {
                yield return new UScereal("N", 212.12121, 12.1212121, 3.030303, 393.93939, 30.30303, 15.15152, 18.181818, 3, 848.48485, "enriched");
                yield return new UScereal("K", 212.12121, 12.1212121, 3.030303, 787.87879, 27.272727, 21.21212, 15.151515, 3, 969.69697, "enriched");
                yield return new UScereal("K", 100, 8, 0, 280, 28, 16, 0, 3, 660, "enriched");
                yield return new UScereal("G", 146.66667, 2.6666667, 2.6666667, 240, 2, 14, 13.333333, 1, 93.33333, "enriched");
                yield return new UScereal("K", 110, 2, 0, 125, 1, 11, 14, 2, 30, "enriched");
                yield return new UScereal("G", 173.33333, 4, 2.6666667, 280, 2.666667, 24, 10.666667, 3, 133.33333, "enriched");
                yield return new UScereal("R", 134.32836, 2.9850746, 1.4925373, 298.50746, 5.970149, 22.38806, 8.955224, 1, 186.56716, "enriched");
                yield return new UScereal("P", 134.32836, 4.4776119, 0, 313.43284, 7.462687, 19.40299, 7.462687, 3, 283.58209, "enriched");
                yield return new UScereal("Q", 160, 1.3333333, 2.6666667, 293.33333, 0, 16, 16, 2, 46.66667, "enriched");
                yield return new UScereal("G", 88, 4.8, 1.6, 232, 1.6, 13.6, 0.8, 1, 84, "enriched");
                yield return new UScereal("G", 160, 1.3333333, 4, 280, 0, 17.33333, 12, 2, 60, "enriched");
                yield return new UScereal("G", 220, 6, 4, 280, 4, 26, 14, 3, 210, "enriched");
                yield return new UScereal("G", 110, 1, 1, 180, 0, 12, 13, 2, 55, "enriched");
                yield return new UScereal("R", 110, 2, 0, 280, 0, 22, 3, 1, 25, "enriched");
                yield return new UScereal("K", 100, 2, 0, 290, 1, 21, 2, 1, 35, "enriched");
                yield return new UScereal("K", 110, 1, 0, 90, 1, 13, 12, 2, 20, "enriched");
                yield return new UScereal("G", 110, 1, 1, 180, 0, 12, 13, 2, 65, "enriched");
                yield return new UScereal("K", 220, 6, 6, 280, 8, 20, 14, 3, 320, "enriched");
                yield return new UScereal("K", 110, 2, 0, 220, 1, 21, 3, 3, 30, "enriched");
                yield return new UScereal("G", 133.33333, 2.6666667, 1.3333333, 186.66667, 2.666667, 14.66667, 13.333333, 3, 160, "enriched");
                yield return new UScereal("R", 133.33333, 2.6666667, 0, 253.33333, 1.333333, 24, 6.666667, 3, 106.66667, "enriched");
                yield return new UScereal("K", 110, 2, 1, 125, 1, 11, 13, 2, 30, "enriched");
                yield return new UScereal("K", 146.66667, 1.3333333, 0, 266.66667, 1.333333, 18.66667, 14.666667, 1, 33.33333, "enriched");
                yield return new UScereal("K", 125, 3.75, 0, 0, 3.75, 17.5, 8.75, 2, 125, "enriched");
                yield return new UScereal("P", 179.10448, 4.4776119, 2.9850746, 238.80597, 7.462687, 17.91045, 14.925373, 3, 298.50746, "enriched");
                yield return new UScereal("K", 179.10448, 4.4776119, 0, 358.20896, 7.462687, 20.89552, 17.910448, 3, 283.58209, "enriched");
                yield return new UScereal("P", 146.66667, 1.3333333, 1.3333333, 180, 0, 17.33333, 16, 2, 33.33333, "enriched");
                yield return new UScereal("P", 113.63636, 2.2727273, 0, 51.13636, 0, 12.5, 17.045455, 1, 45.45455, "enriched");
                yield return new UScereal("G", 146.66667, 1.3333333, 1.3333333, 373.33333, 0, 20, 12, 2, 60, "enriched");
                yield return new UScereal("P", 113.63636, 3.4090909, 1.1363636, 159.09091, 3.409091, 17.04545, 5.681818, 3, 96.59091, "enriched");
                yield return new UScereal("P", 440, 12, 0, 680, 12, 68, 12, 3, 360, "enriched");
                yield return new UScereal("P", 363.63636, 9.0909091, 9.0909091, 227.27273, 9.090909, 39.39394, 12.121212, 3, 303.0303, "enriched");
                yield return new UScereal("Q", 120, 1, 2, 220, 1, 12, 11, 2, 45, "enriched");
                yield return new UScereal("G", 146.66667, 4, 1.3333333, 333.33333, 2, 15.33333, 13.333333, 1, 120, "enriched");
                yield return new UScereal("P", 82.70677, 0.7518797, 0, 135.33835, 0, 10.52632, 8.270677, 1, 26.31579, "enriched");
                yield return new UScereal("K", 186.66667, 4, 1.3333333, 226.66667, 2.666667, 26.66667, 12, 3, 126.66667, "100%");
                yield return new UScereal("G", 73.33333, 1.3333333, 0.6666667, 173.33333, 0, 14, 2, 2, 26.66667, "enriched");
                yield return new UScereal("Q", 149.25373, 5.9701493, 2.9850746, 223.8806, 2.985075, 17.91045, 8.955224, 2, 141.79104, "enriched");
                yield return new UScereal("G", 110, 2, 1, 180, 0, 12, 12, 2, 55, "enriched");
                yield return new UScereal("K", 238.80597, 4.4776119, 2.9850746, 223.8806, 4.477612, 25.37313, 19.402985, 3, 238.80597, "enriched");
                yield return new UScereal("G", 100, 2, 1, 220, 2, 15, 6, 1, 90, "enriched");
                yield return new UScereal("K", 179.10448, 2.9850746, 1.4925373, 283.58209, 0, 22.38806, 13.432836, 2, 59.70149, "enriched");
                yield return new UScereal("K", 208.95522, 4.4776119, 2.9850746, 328.35821, 4.477612, 31.34328, 10.447761, 3, 194.02985, "enriched");
                yield return new UScereal("G", 260, 6, 4, 340, 3, 27, 20, 3, 240, "enriched");
                yield return new UScereal("P", 179.10448, 4.4776119, 1.4925373, 298.50746, 8.955224, 16.41791, 20.895522, 3, 388.0597, "enriched");
                yield return new UScereal("K", 100, 3, 0, 320, 1, 20, 3, 3, 45, "100%");
                yield return new UScereal("Q", 50, 1, 0, 0, 0, 13, 0, 3, 15, "none");
                yield return new UScereal("Q", 200, 8, 2, 270, 4, 28, 12, 3, 220, "enriched");
                yield return new UScereal("K", 160, 4, 1.3333333, 280, 6.666667, 18.66667, 16, 2, 320, "enriched");
                yield return new UScereal("G", 200, 6, 4, 280, 5, 21, 16, 3, 280, "enriched");
                yield return new UScereal("K", 180, 4, 0, 0, 4, 30, 12, 3, 220, "enriched");
                yield return new UScereal("R", 97.34513, 0.8849558, 0, 212.38938, 0, 20.35398, 1.769912, 1, 26.54867, "enriched");
                yield return new UScereal("K", 110, 2, 0, 290, 0, 22, 3, 1, 35, "enriched");
                yield return new UScereal("N", 134.32836, 4.4776119, 0, 0, 5.970149, 28.35821, 0, 1, 208.95522, "none");
                yield return new UScereal("N", 134.32836, 4.4776119, 0, 0, 4.477612, 29.85075, 0, 1, 179.10448, "none");
                yield return new UScereal("K", 146.66667, 2.6666667, 1.3333333, 93.33333, 1.333333, 12, 20, 2, 53.33333, "enriched");
                yield return new UScereal("K", 110, 6, 0, 230, 1, 16, 3, 1, 55, "enriched");
                yield return new UScereal("G", 110, 2, 1, 200, 0, 21, 3, 3, 35, "100%");
                yield return new UScereal("G", 140, 3, 1, 190, 4, 15, 14, 3, 230, "100%");
                yield return new UScereal("G", 100, 3, 1, 200, 3, 16, 3, 3, 110, "100%");
                yield return new UScereal("G", 146.66667, 2.6666667, 1.3333333, 333.33333, 0, 28, 4, 3, 80, "enriched");
                yield return new UScereal("G", 110, 1, 1, 140, 0, 13, 12, 2, 25, "enriched");
                yield return new UScereal("R", 149.25373, 4.4776119, 1.4925373, 343.28358, 4.477612, 25.37313, 4.477612, 1, 171.64179, "enriched");
                yield return new UScereal("G", 100, 3, 1, 200, 3, 17, 3, 1, 110, "enriched");
                yield return new UScereal("G", 146.66667, 2.6666667, 1.3333333, 266.66667, 1.333333, 21.33333, 10.666667, 1, 80, "enriched");
            }
        }
    }
}
