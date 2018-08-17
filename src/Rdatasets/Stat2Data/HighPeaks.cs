// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// HighPeaks
    /// </summary>

    public class HighPeaks
    {
        public readonly string Peak;
        public readonly int Elevation;
        public readonly int Difficulty;
        public readonly int Ascent;
        public readonly double Length;
        public readonly double Time;

        public HighPeaks(string Peak, int Elevation, int Difficulty, int Ascent, double Length, double Time)
        {
            this.Peak = Peak;
            this.Elevation = Elevation;
            this.Difficulty = Difficulty;
            this.Ascent = Ascent;
            this.Length = Length;
            this.Time = Time;
        }

        public static IEnumerable<HighPeaks> Data
        {
            get
            {
                yield return new HighPeaks("Mt. Marcy  ", 5344, 5, 3166, 14.8, 10);
                yield return new HighPeaks("Algonquin Peak ", 5114, 5, 2936, 9.6, 9);
                yield return new HighPeaks("Mt. Haystack ", 4960, 7, 3570, 17.8, 12);
                yield return new HighPeaks("Mt. Skylight ", 4926, 7, 4265, 17.9, 15);
                yield return new HighPeaks("Whiteface Mtn. ", 4867, 4, 2535, 10.4, 8.5);
                yield return new HighPeaks("Dix Mtn. ", 4857, 5, 2800, 13.2, 10);
                yield return new HighPeaks("Gray Peak ", 4840, 7, 4178, 16, 14);
                yield return new HighPeaks("Iroquois Peak ", 4840, 6, 3250, 11.6, 8.5);
                yield return new HighPeaks("Basin Mtn. ", 4827, 6, 3650, 16.5, 11);
                yield return new HighPeaks("Gothics ", 4736, 5, 4070, 10, 9);
                yield return new HighPeaks("Mt. Colden ", 4714, 5, 2850, 15.2, 10);
                yield return new HighPeaks("Giant Mtn. ", 4627, 4, 3050, 6, 7.5);
                yield return new HighPeaks("Nippletop ", 4620, 5, 4050, 12.6, 10);
                yield return new HighPeaks("Santanoni Peak ", 4607, 5, 2860, 11.4, 10);
                yield return new HighPeaks("Mt. Redfield ", 4606, 7, 3225, 17.5, 14);
                yield return new HighPeaks("Wright Peak ", 4580, 4, 2400, 7, 7);
                yield return new HighPeaks("Saddleback Mtn. ", 4515, 5, 2990, 13.4, 10);
                yield return new HighPeaks("Panther Peak ", 4442, 6, 3762, 17.6, 13.5);
                yield return new HighPeaks("Tabletop Mtn. ", 4427, 5, 3660, 15.2, 13);
                yield return new HighPeaks("Rocky Peak Ridge ", 4420, 6, 4500, 13.4, 11);
                yield return new HighPeaks("Macomb Mtn. ", 4405, 5, 2344, 8.4, 8);
                yield return new HighPeaks("Armstrong Mtn. ", 4400, 5, 3734, 12.7, 11);
                yield return new HighPeaks("Hough Peak ", 4400, 6, 3200, 13.7, 11);
                yield return new HighPeaks("Seward Mtn. ", 4361, 7, 3490, 16, 17);
                yield return new HighPeaks("Mt. Marshall ", 4360, 6, 2575, 14, 11);
                yield return new HighPeaks("Allen Mtn. ", 4340, 7, 2540, 16.2, 13);
                yield return new HighPeaks("Big Slide Mtn. ", 4240, 4, 2800, 9.4, 8);
                yield return new HighPeaks("Esther Mtn. ", 4240, 4, 3020, 9.4, 7.5);
                yield return new HighPeaks("Upper Wolfjaw ", 4185, 5, 3619, 12.7, 11);
                yield return new HighPeaks("Lower Wolfjaw ", 4175, 4, 2825, 8.7, 8);
                yield return new HighPeaks("Street Mtn. ", 4166, 6, 2115, 8.8, 9.5);
                yield return new HighPeaks("Phelps Mtn. ", 4161, 5, 3394, 10, 9);
                yield return new HighPeaks("Mt. Donaldson ", 4140, 7, 3490, 17, 17);
                yield return new HighPeaks("Seymour Mtn. ", 4120, 6, 2370, 14, 11);
                yield return new HighPeaks("Sawteeth ", 4100, 4, 2975, 11.8, 9);
                yield return new HighPeaks("Cascade Mtn. ", 4098, 2, 1940, 4.8, 5);
                yield return new HighPeaks("South Dix ", 4060, 6, 3050, 11.5, 12);
                yield return new HighPeaks("Porter Mtn. ", 4059, 3, 2700, 7.6, 5.5);
                yield return new HighPeaks("Mt. Colvin ", 4057, 4, 2130, 10.8, 10);
                yield return new HighPeaks("Mt. Emmons ", 4040, 7, 3490, 18, 18);
                yield return new HighPeaks("Dial Mtn. ", 4020, 5, 3450, 10, 9);
                yield return new HighPeaks("East Dix ", 4012, 6, 3002, 12.5, 12);
                yield return new HighPeaks("Blake ", 3960, 4, 3270, 13.6, 12);
                yield return new HighPeaks("Cliff Mtn. ", 3960, 6, 2160, 17.2, 12);
                yield return new HighPeaks("Nye Mtn. ", 3895, 6, 1844, 7.5, 8.5);
                yield return new HighPeaks("Couchsachraga Peak ", 3820, 6, 3140, 15, 12);
            }
        }
    }
}
