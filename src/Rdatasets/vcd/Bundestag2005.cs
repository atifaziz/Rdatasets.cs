// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Votes in German Bundestag Election 2005
    /// </summary>

    public class Bundestag2005
    {
        public readonly string Bundesland;
        public readonly string Fraktion;
        public readonly int Freq;

        public Bundestag2005(string Bundesland, string Fraktion, int Freq)
        {
            this.Bundesland = Bundesland;
            this.Fraktion = Fraktion;
            this.Freq = Freq;
        }

        public static IEnumerable<Bundestag2005> Data
        {
            get
            {
                yield return new Bundestag2005("Schleswig-Holstein", "SPD", 761302);
                yield return new Bundestag2005("Mecklenburg-Vorpommern", "SPD", 326130);
                yield return new Bundestag2005("Hamburg", "SPD", 447335);
                yield return new Bundestag2005("Niedersachsen", "SPD", 2249746);
                yield return new Bundestag2005("Bremen", "SPD", 184817);
                yield return new Bundestag2005("Brandenburg", "SPD", 608044);
                yield return new Bundestag2005("Sachsen-Anhalt", "SPD", 508573);
                yield return new Bundestag2005("Berlin", "SPD", 681591);
                yield return new Bundestag2005("Nordrhein-Westfalen", "SPD", 4658692);
                yield return new Bundestag2005("Sachsen", "SPD", 666709);
                yield return new Bundestag2005("Hessen", "SPD", 1415806);
                yield return new Bundestag2005("Thueringen", "SPD", 459850);
                yield return new Bundestag2005("Rheinland-Pfalz", "SPD", 946310);
                yield return new Bundestag2005("Bayern", "SPD", 1960561);
                yield return new Bundestag2005("Baden-Wuerttemberg", "SPD", 2013195);
                yield return new Bundestag2005("Saarland", "SPD", 240439);
                yield return new Bundestag2005("Schleswig-Holstein", "CDU/CSU", 733004);
                yield return new Bundestag2005("Mecklenburg-Vorpommern", "CDU/CSU", 316169);
                yield return new Bundestag2005("Hamburg", "CDU/CSU", 320444);
                yield return new Bundestag2005("Niedersachsen", "CDU/CSU", 1857583);
                yield return new Bundestag2005("Bremen", "CDU/CSU", 96120);
                yield return new Bundestag2005("Brandenburg", "CDU/CSU", 358754);
                yield return new Bundestag2005("Sachsen-Anhalt", "CDU/CSU", 404318);
                yield return new Bundestag2005("Berlin", "CDU/CSU", 483014);
                yield return new Bundestag2005("Nordrhein-Westfalen", "CDU/CSU", 4161570);
                yield return new Bundestag2005("Sachsen", "CDU/CSU", 940306);
                yield return new Bundestag2005("Hessen", "CDU/CSU", 1338785);
                yield return new Bundestag2005("Thueringen", "CDU/CSU", 420605);
                yield return new Bundestag2005("Rheinland-Pfalz", "CDU/CSU", 1024834);
                yield return new Bundestag2005("Bayern", "CDU/CSU", 3889990);
                yield return new Bundestag2005("Baden-Wuerttemberg", "CDU/CSU", 2720955);
                yield return new Bundestag2005("Saarland", "CDU/CSU", 214489);
                yield return new Bundestag2005("Schleswig-Holstein", "Gruene", 73345);
                yield return new Bundestag2005("Mecklenburg-Vorpommern", "Gruene", 34904);
                yield return new Bundestag2005("Hamburg", "Gruene", 85730);
                yield return new Bundestag2005("Niedersachsen", "Gruene", 224575);
                yield return new Bundestag2005("Bremen", "Gruene", 35147);
                yield return new Bundestag2005("Brandenburg", "Gruene", 44562);
                yield return new Bundestag2005("Sachsen-Anhalt", "Gruene", 39112);
                yield return new Bundestag2005("Berlin", "Gruene", 229849);
                yield return new Bundestag2005("Nordrhein-Westfalen", "Gruene", 433372);
                yield return new Bundestag2005("Sachsen", "Gruene", 94127);
                yield return new Bundestag2005("Hessen", "Gruene", 195060);
                yield return new Bundestag2005("Thueringen", "Gruene", 51835);
                yield return new Bundestag2005("Rheinland-Pfalz", "Gruene", 99769);
                yield return new Bundestag2005("Bayern", "Gruene", 449976);
                yield return new Bundestag2005("Baden-Wuerttemberg", "Gruene", 428574);
                yield return new Bundestag2005("Saarland", "Gruene", 18976);
                yield return new Bundestag2005("Schleswig-Holstein", "FDP", 65315);
                yield return new Bundestag2005("Mecklenburg-Vorpommern", "FDP", 42840);
                yield return new Bundestag2005("Hamburg", "FDP", 32904);
                yield return new Bundestag2005("Niedersachsen", "FDP", 186474);
                yield return new Bundestag2005("Bremen", "FDP", 13514);
                yield return new Bundestag2005("Brandenburg", "FDP", 66723);
                yield return new Bundestag2005("Sachsen-Anhalt", "FDP", 71965);
                yield return new Bundestag2005("Berlin", "FDP", 70471);
                yield return new Bundestag2005("Nordrhein-Westfalen", "FDP", 422724);
                yield return new Bundestag2005("Sachsen", "FDP", 176889);
                yield return new Bundestag2005("Hessen", "FDP", 158793);
                yield return new Bundestag2005("Thueringen", "FDP", 71968);
                yield return new Bundestag2005("Rheinland-Pfalz", "FDP", 130808);
                yield return new Bundestag2005("Bayern", "FDP", 353503);
                yield return new Bundestag2005("Baden-Wuerttemberg", "FDP", 321612);
                yield return new Bundestag2005("Saarland", "FDP", 22028);
                yield return new Bundestag2005("Schleswig-Holstein", "Linke", 48634);
                yield return new Bundestag2005("Mecklenburg-Vorpommern", "Linke", 231205);
                yield return new Bundestag2005("Hamburg", "Linke", 44503);
                yield return new Bundestag2005("Niedersachsen", "Linke", 168205);
                yield return new Bundestag2005("Bremen", "Linke", 25658);
                yield return new Bundestag2005("Brandenburg", "Linke", 423111);
                yield return new Bundestag2005("Sachsen-Anhalt", "Linke", 369268);
                yield return new Bundestag2005("Berlin", "Linke", 321714);
                yield return new Bundestag2005("Nordrhein-Westfalen", "Linke", 425709);
                yield return new Bundestag2005("Sachsen", "Linke", 590726);
                yield return new Bundestag2005("Hessen", "Linke", 142516);
                yield return new Bundestag2005("Thueringen", "Linke", 368228);
                yield return new Bundestag2005("Rheinland-Pfalz", "Linke", 111029);
                yield return new Bundestag2005("Bayern", "Linke", 201865);
                yield return new Bundestag2005("Baden-Wuerttemberg", "Linke", 182288);
                yield return new Bundestag2005("Saarland", "Linke", 109509);
            }
        }
    }
}
