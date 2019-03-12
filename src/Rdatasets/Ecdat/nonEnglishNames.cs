// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Names with Character Set Problems
    /// </summary>

    public class nonEnglishNames
    {
        public readonly int κ;
        public readonly string nonEnglish;
        public readonly string English;

        public nonEnglishNames(int κ, string nonEnglish, string English)
        {
            this.κ = κ;
            this.nonEnglish = nonEnglish;
            this.English = English;
        }

        public static IEnumerable<nonEnglishNames> Data
        {
            get
            {
                yield return new nonEnglishNames(1, "Andr_", "Andre");
                yield return new nonEnglishNames(2, "C_rdenas", "Cardenas");
                yield return new nonEnglishNames(3, "Cu_llar", "Cuellar");
                yield return new nonEnglishNames(4, "Guti_rrez", "Gutierrez");
                yield return new nonEnglishNames(5, "Jos_", "Jose");
                yield return new nonEnglishNames(6, "Luj_n", "Lujan");
                yield return new nonEnglishNames(7, "Men_ndez", "Menendez");
                yield return new nonEnglishNames(8, "Ra_l", "Raul");
                yield return new nonEnglishNames(9, "Rub_n", "Ruben");
                yield return new nonEnglishNames(10, "S_nchez", "Sanchez");
                yield return new nonEnglishNames(11, "Vel_zquez", "Velazquez");
            }
        }
    }
}
