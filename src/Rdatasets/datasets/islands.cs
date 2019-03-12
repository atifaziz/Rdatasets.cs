// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Areas of the World's Major Landmasses
    /// </summary>

    public class islands
    {
        public readonly string κ;
        public readonly int dat;

        public islands(string κ, int dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<islands> Data
        {
            get
            {
                yield return new islands("Africa", 11506);
                yield return new islands("Antarctica", 5500);
                yield return new islands("Asia", 16988);
                yield return new islands("Australia", 2968);
                yield return new islands("Axel Heiberg", 16);
                yield return new islands("Baffin", 184);
                yield return new islands("Banks", 23);
                yield return new islands("Borneo", 280);
                yield return new islands("Britain", 84);
                yield return new islands("Celebes", 73);
                yield return new islands("Celon", 25);
                yield return new islands("Cuba", 43);
                yield return new islands("Devon", 21);
                yield return new islands("Ellesmere", 82);
                yield return new islands("Europe", 3745);
                yield return new islands("Greenland", 840);
                yield return new islands("Hainan", 13);
                yield return new islands("Hispaniola", 30);
                yield return new islands("Hokkaido", 30);
                yield return new islands("Honshu", 89);
                yield return new islands("Iceland", 40);
                yield return new islands("Ireland", 33);
                yield return new islands("Java", 49);
                yield return new islands("Kyushu", 14);
                yield return new islands("Luzon", 42);
                yield return new islands("Madagascar", 227);
                yield return new islands("Melville", 16);
                yield return new islands("Mindanao", 36);
                yield return new islands("Moluccas", 29);
                yield return new islands("New Britain", 15);
                yield return new islands("New Guinea", 306);
                yield return new islands("New Zealand (N)", 44);
                yield return new islands("New Zealand (S)", 58);
                yield return new islands("Newfoundland", 43);
                yield return new islands("North America", 9390);
                yield return new islands("Novaya Zemlya", 32);
                yield return new islands("Prince of Wales", 13);
                yield return new islands("Sakhalin", 29);
                yield return new islands("South America", 6795);
                yield return new islands("Southampton", 16);
                yield return new islands("Spitsbergen", 15);
                yield return new islands("Sumatra", 183);
                yield return new islands("Taiwan", 14);
                yield return new islands("Tasmania", 26);
                yield return new islands("Tierra del Fuego", 19);
                yield return new islands("Timor", 13);
                yield return new islands("Vancouver", 12);
                yield return new islands("Victoria", 82);
            }
        }
    }
}
