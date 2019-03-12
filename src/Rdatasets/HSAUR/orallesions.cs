// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Oral Lesions in Rural India
    /// </summary>

    public class orallesions
    {
        public readonly int κ;
        public readonly string site_of_lesion;
        public readonly string region;
        public readonly int Freq;

        public orallesions(int κ, string site_of_lesion, string region, int Freq)
        {
            this.κ = κ;
            this.site_of_lesion = site_of_lesion;
            this.region = region;
            this.Freq = Freq;
        }

        public static IEnumerable<orallesions> Data
        {
            get
            {
                yield return new orallesions(1, "Buccal mucosa", "Kerala", 8);
                yield return new orallesions(2, "Commissure", "Kerala", 0);
                yield return new orallesions(3, "Gingiva", "Kerala", 0);
                yield return new orallesions(4, "Hard palate", "Kerala", 0);
                yield return new orallesions(5, "Soft palate", "Kerala", 0);
                yield return new orallesions(6, "Tongue", "Kerala", 0);
                yield return new orallesions(7, "Floor of mouth", "Kerala", 1);
                yield return new orallesions(8, "Alveolar ridge", "Kerala", 1);
                yield return new orallesions(9, "Buccal mucosa", "Gujarat", 1);
                yield return new orallesions(10, "Commissure", "Gujarat", 1);
                yield return new orallesions(11, "Gingiva", "Gujarat", 1);
                yield return new orallesions(12, "Hard palate", "Gujarat", 1);
                yield return new orallesions(13, "Soft palate", "Gujarat", 1);
                yield return new orallesions(14, "Tongue", "Gujarat", 1);
                yield return new orallesions(15, "Floor of mouth", "Gujarat", 0);
                yield return new orallesions(16, "Alveolar ridge", "Gujarat", 0);
                yield return new orallesions(17, "Buccal mucosa", "Andhra", 8);
                yield return new orallesions(18, "Commissure", "Andhra", 0);
                yield return new orallesions(19, "Gingiva", "Andhra", 0);
                yield return new orallesions(20, "Hard palate", "Andhra", 0);
                yield return new orallesions(21, "Soft palate", "Andhra", 0);
                yield return new orallesions(22, "Tongue", "Andhra", 0);
                yield return new orallesions(23, "Floor of mouth", "Andhra", 1);
                yield return new orallesions(24, "Alveolar ridge", "Andhra", 1);
            }
        }
    }
}
