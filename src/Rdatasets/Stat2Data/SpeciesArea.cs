// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Species Area
    /// </summary>

    public class SpeciesArea
    {
        public readonly int κ;
        public readonly string Name;
        public readonly int Area;
        public readonly int Species;
        public readonly double logArea;
        public readonly double logSpecies;

        public SpeciesArea(int κ, string Name, int Area, int Species, double logArea, double logSpecies)
        {
            this.κ = κ;
            this.Name = Name;
            this.Area = Area;
            this.Species = Species;
            this.logArea = logArea;
            this.logSpecies = logSpecies;
        }

        public static IEnumerable<SpeciesArea> Data
        {
            get
            {
                yield return new SpeciesArea(1, "Borneo", 743244, 129, 13.5188, 4.85981);
                yield return new SpeciesArea(2, "Sumatra", 473607, 126, 13.0681, 4.83628);
                yield return new SpeciesArea(3, "Java", 125628, 78, 11.7411, 4.35671);
                yield return new SpeciesArea(4, "Bangka", 11964, 38, 9.38966, 3.63759);
                yield return new SpeciesArea(5, "Bunguran", 1594, 24, 7.374, 3.17805);
                yield return new SpeciesArea(6, "Banggi", 450, 18, 6.10925, 2.89037);
                yield return new SpeciesArea(7, "Jemaja", 194, 15, 5.26786, 2.70805);
                yield return new SpeciesArea(8, "Karimata Besar", 130, 19, 4.86753, 2.94444);
                yield return new SpeciesArea(9, "Tioman", 114, 23, 4.7362, 3.13549);
                yield return new SpeciesArea(10, "Siantan", 113, 16, 4.72739, 2.77259);
                yield return new SpeciesArea(11, "Sirhassan", 46, 16, 3.82864, 2.77259);
                yield return new SpeciesArea(12, "Redang", 25, 8, 3.21888, 2.07944);
                yield return new SpeciesArea(13, "Penebangan", 13, 13, 2.56495, 2.56495);
                yield return new SpeciesArea(14, "Perhentian Besar", 8, 6, 2.07944, 1.79176);
            }
        }
    }
}
