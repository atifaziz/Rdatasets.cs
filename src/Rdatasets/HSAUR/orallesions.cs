// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Oral Lesions in Rural India
    /// </summary>

    public class orallesions
    {
        public readonly string site_of_lesion;
        public readonly string region;
        public readonly int Freq;

        public orallesions(string site_of_lesion, string region, int Freq)
        {
            this.site_of_lesion = site_of_lesion;
            this.region = region;
            this.Freq = Freq;
        }

        public static IEnumerable<orallesions> Data
        {
            get
            {
                yield return new orallesions("Buccal mucosa", "Kerala", 8);
                yield return new orallesions("Commissure", "Kerala", 0);
                yield return new orallesions("Gingiva", "Kerala", 0);
                yield return new orallesions("Hard palate", "Kerala", 0);
                yield return new orallesions("Soft palate", "Kerala", 0);
                yield return new orallesions("Tongue", "Kerala", 0);
                yield return new orallesions("Floor of mouth", "Kerala", 1);
                yield return new orallesions("Alveolar ridge", "Kerala", 1);
                yield return new orallesions("Buccal mucosa", "Gujarat", 1);
                yield return new orallesions("Commissure", "Gujarat", 1);
                yield return new orallesions("Gingiva", "Gujarat", 1);
                yield return new orallesions("Hard palate", "Gujarat", 1);
                yield return new orallesions("Soft palate", "Gujarat", 1);
                yield return new orallesions("Tongue", "Gujarat", 1);
                yield return new orallesions("Floor of mouth", "Gujarat", 0);
                yield return new orallesions("Alveolar ridge", "Gujarat", 0);
                yield return new orallesions("Buccal mucosa", "Andhra", 8);
                yield return new orallesions("Commissure", "Andhra", 0);
                yield return new orallesions("Gingiva", "Andhra", 0);
                yield return new orallesions("Hard palate", "Andhra", 0);
                yield return new orallesions("Soft palate", "Andhra", 0);
                yield return new orallesions("Tongue", "Andhra", 0);
                yield return new orallesions("Floor of mouth", "Andhra", 1);
                yield return new orallesions("Alveolar ridge", "Andhra", 1);
            }
        }
    }
}
