// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Names with Character Set Problems
    /// </summary>

    public class nonEnglishNames
    {
        public readonly string nonEnglish;
        public readonly string English;

        public nonEnglishNames(string nonEnglish, string English)
        {
            this.nonEnglish = nonEnglish;
            this.English = English;
        }

        public static IEnumerable<nonEnglishNames> Data
        {
            get
            {
                yield return new nonEnglishNames("Andr_", "Andre");
                yield return new nonEnglishNames("C_rdenas", "Cardenas");
                yield return new nonEnglishNames("Cu_llar", "Cuellar");
                yield return new nonEnglishNames("Guti_rrez", "Gutierrez");
                yield return new nonEnglishNames("Jos_", "Jose");
                yield return new nonEnglishNames("Luj_n", "Lujan");
                yield return new nonEnglishNames("Men_ndez", "Menendez");
                yield return new nonEnglishNames("Ra_l", "Raul");
                yield return new nonEnglishNames("Rub_n", "Ruben");
                yield return new nonEnglishNames("S_nchez", "Sanchez");
                yield return new nonEnglishNames("Vel_zquez", "Velazquez");
            }
        }
    }
}
