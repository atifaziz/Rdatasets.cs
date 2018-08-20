// ReSharper disable All

namespace Rdatasets.ggplot2
{
    using System.Collections.Generic;

    /// <summary>
    /// An updated and expanded version of the mammals sleep dataset
    /// </summary>

    public class msleep
    {
        public readonly string name;
        public readonly string genus;
        public readonly string vore;
        public readonly string order;
        public readonly string conservation;
        public readonly double sleep_total;
        public readonly double? sleep_rem;
        public readonly double? sleep_cycle;
        public readonly double awake;
        public readonly string brainwt;
        public readonly double bodywt;

        public msleep(string name, string genus, string vore, string order, string conservation, double sleep_total, double? sleep_rem, double? sleep_cycle, double awake, string brainwt, double bodywt)
        {
            this.name = name;
            this.genus = genus;
            this.vore = vore;
            this.order = order;
            this.conservation = conservation;
            this.sleep_total = sleep_total;
            this.sleep_rem = sleep_rem;
            this.sleep_cycle = sleep_cycle;
            this.awake = awake;
            this.brainwt = brainwt;
            this.bodywt = bodywt;
        }

        public static IEnumerable<msleep> Data
        {
            get
            {
                yield return new msleep("Cheetah", "Acinonyx", "carni", "Carnivora", "lc", 12.1, null, null, 11.9, null, 50);
                yield return new msleep("Owl monkey", "Aotus", "omni", "Primates", null, 17, 1.8, null, 7, "0.0155", 0.48);
                yield return new msleep("Mountain beaver", "Aplodontia", "herbi", "Rodentia", "nt", 14.4, 2.4, null, 9.6, null, 1.35);
                yield return new msleep("Greater short-tailed shrew", "Blarina", "omni", "Soricomorpha", "lc", 14.9, 2.3, 0.133333333, 9.1, "0.00029", 0.019);
                yield return new msleep("Cow", "Bos", "herbi", "Artiodactyla", "domesticated", 4, 0.7, 0.666666667, 20, "0.423", 600);
                yield return new msleep("Three-toed sloth", "Bradypus", "herbi", "Pilosa", null, 14.4, 2.2, 0.766666667, 9.6, null, 3.85);
                yield return new msleep("Northern fur seal", "Callorhinus", "carni", "Carnivora", "vu", 8.7, 1.4, 0.383333333, 15.3, null, 20.49);
                yield return new msleep("Vesper mouse", "Calomys", null, "Rodentia", null, 7, null, null, 17, null, 0.045);
                yield return new msleep("Dog", "Canis", "carni", "Carnivora", "domesticated", 10.1, 2.9, 0.333333333, 13.9, "0.07", 14);
                yield return new msleep("Roe deer", "Capreolus", "herbi", "Artiodactyla", "lc", 3, null, null, 21, "0.0982", 14.8);
                yield return new msleep("Goat", "Capri", "herbi", "Artiodactyla", "lc", 5.3, 0.6, null, 18.7, "0.115", 33.5);
                yield return new msleep("Guinea pig", "Cavis", "herbi", "Rodentia", "domesticated", 9.4, 0.8, 0.216666667, 14.6, "0.0055", 0.728);
                yield return new msleep("Grivet", "Cercopithecus", "omni", "Primates", "lc", 10, 0.7, null, 14, null, 4.75);
                yield return new msleep("Chinchilla", "Chinchilla", "herbi", "Rodentia", "domesticated", 12.5, 1.5, 0.116666667, 11.5, "0.0064", 0.42);
                yield return new msleep("Star-nosed mole", "Condylura", "omni", "Soricomorpha", "lc", 10.3, 2.2, null, 13.7, "0.001", 0.06);
                yield return new msleep("African giant pouched rat", "Cricetomys", "omni", "Rodentia", null, 8.3, 2, null, 15.7, "0.0066", 1);
                yield return new msleep("Lesser short-tailed shrew", "Cryptotis", "omni", "Soricomorpha", "lc", 9.1, 1.4, 0.15, 14.9, "0.00014", 0.005);
                yield return new msleep("Long-nosed armadillo", "Dasypus", "carni", "Cingulata", "lc", 17.4, 3.1, 0.383333333, 6.6, "0.0108", 3.5);
                yield return new msleep("Tree hyrax", "Dendrohyrax", "herbi", "Hyracoidea", "lc", 5.3, 0.5, null, 18.7, "0.0123", 2.95);
                yield return new msleep("North American Opossum", "Didelphis", "omni", "Didelphimorphia", "lc", 18, 4.9, 0.333333333, 6, "0.0063", 1.7);
                yield return new msleep("Asian elephant", "Elephas", "herbi", "Proboscidea", "en", 3.9, null, null, 20.1, "4.603", 2547);
                yield return new msleep("Big brown bat", "Eptesicus", "insecti", "Chiroptera", "lc", 19.7, 3.9, 0.116666667, 4.3, "3e-04", 0.023);
                yield return new msleep("Horse", "Equus", "herbi", "Perissodactyla", "domesticated", 2.9, 0.6, 1, 21.1, "0.655", 521);
                yield return new msleep("Donkey", "Equus", "herbi", "Perissodactyla", "domesticated", 3.1, 0.4, null, 20.9, "0.419", 187);
                yield return new msleep("European hedgehog", "Erinaceus", "omni", "Erinaceomorpha", "lc", 10.1, 3.5, 0.283333333, 13.9, "0.0035", 0.77);
                yield return new msleep("Patas monkey", "Erythrocebus", "omni", "Primates", "lc", 10.9, 1.1, null, 13.1, "0.115", 10);
                yield return new msleep("Western american chipmunk", "Eutamias", "herbi", "Rodentia", null, 14.9, null, null, 9.1, null, 0.071);
                yield return new msleep("Domestic cat", "Felis", "carni", "Carnivora", "domesticated", 12.5, 3.2, 0.416666667, 11.5, "0.0256", 3.3);
                yield return new msleep("Galago", "Galago", "omni", "Primates", null, 9.8, 1.1, 0.55, 14.2, "0.005", 0.2);
                yield return new msleep("Giraffe", "Giraffa", "herbi", "Artiodactyla", "cd", 1.9, 0.4, null, 22.1, null, 899.995);
                yield return new msleep("Pilot whale", "Globicephalus", "carni", "Cetacea", "cd", 2.7, 0.1, null, 21.35, null, 800);
                yield return new msleep("Gray seal", "Haliochoerus", "carni", "Carnivora", "lc", 6.2, 1.5, null, 17.8, "0.325", 85);
                yield return new msleep("Gray hyrax", "Heterohyrax", "herbi", "Hyracoidea", "lc", 6.3, 0.6, null, 17.7, "0.01227", 2.625);
                yield return new msleep("Human", "Homo", "omni", "Primates", null, 8, 1.9, 1.5, 16, "1.32", 62);
                yield return new msleep("Mongoose lemur", "Lemur", "herbi", "Primates", "vu", 9.5, 0.9, null, 14.5, null, 1.67);
                yield return new msleep("African elephant", "Loxodonta", "herbi", "Proboscidea", "vu", 3.3, null, null, 20.7, "5.712", 6654);
                yield return new msleep("Thick-tailed opposum", "Lutreolina", "carni", "Didelphimorphia", "lc", 19.4, 6.6, null, 4.6, null, 0.37);
                yield return new msleep("Macaque", "Macaca", "omni", "Primates", null, 10.1, 1.2, 0.75, 13.9, "0.179", 6.8);
                yield return new msleep("Mongolian gerbil", "Meriones", "herbi", "Rodentia", "lc", 14.2, 1.9, null, 9.8, null, 0.053);
                yield return new msleep("Golden hamster", "Mesocricetus", "herbi", "Rodentia", "en", 14.3, 3.1, 0.2, 9.7, "0.001", 0.12);
                yield return new msleep("Vole ", "Microtus", "herbi", "Rodentia", null, 12.8, null, null, 11.2, null, 0.035);
                yield return new msleep("House mouse", "Mus", "herbi", "Rodentia", "nt", 12.5, 1.4, 0.183333333, 11.5, "4e-04", 0.022);
                yield return new msleep("Little brown bat", "Myotis", "insecti", "Chiroptera", null, 19.9, 2, 0.2, 4.1, "0.00025", 0.01);
                yield return new msleep("Round-tailed muskrat", "Neofiber", "herbi", "Rodentia", "nt", 14.6, null, null, 9.4, null, 0.266);
                yield return new msleep("Slow loris", "Nyctibeus", "carni", "Primates", null, 11, null, null, 13, "0.0125", 1.4);
                yield return new msleep("Degu", "Octodon", "herbi", "Rodentia", "lc", 7.7, 0.9, null, 16.3, null, 0.21);
                yield return new msleep("Northern grasshopper mouse", "Onychomys", "carni", "Rodentia", "lc", 14.5, null, null, 9.5, null, 0.028);
                yield return new msleep("Rabbit", "Oryctolagus", "herbi", "Lagomorpha", "domesticated", 8.4, 0.9, 0.416666667, 15.6, "0.0121", 2.5);
                yield return new msleep("Sheep", "Ovis", "herbi", "Artiodactyla", "domesticated", 3.8, 0.6, null, 20.2, "0.175", 55.5);
                yield return new msleep("Chimpanzee", "Pan", "omni", "Primates", null, 9.7, 1.4, 1.416666667, 14.3, "0.44", 52.2);
                yield return new msleep("Tiger", "Panthera", "carni", "Carnivora", "en", 15.8, null, null, 8.2, null, 162.564);
                yield return new msleep("Jaguar", "Panthera", "carni", "Carnivora", "nt", 10.4, null, null, 13.6, "0.157", 100);
                yield return new msleep("Lion", "Panthera", "carni", "Carnivora", "vu", 13.5, null, null, 10.5, null, 161.499);
                yield return new msleep("Baboon", "Papio", "omni", "Primates", null, 9.4, 1, 0.666666667, 14.6, "0.18", 25.235);
                yield return new msleep("Desert hedgehog", "Paraechinus", null, "Erinaceomorpha", "lc", 10.3, 2.7, null, 13.7, "0.0024", 0.55);
                yield return new msleep("Potto", "Perodicticus", "omni", "Primates", "lc", 11, null, null, 13, null, 1.1);
                yield return new msleep("Deer mouse", "Peromyscus", null, "Rodentia", null, 11.5, null, null, 12.5, null, 0.021);
                yield return new msleep("Phalanger", "Phalanger", null, "Diprotodontia", null, 13.7, 1.8, null, 10.3, "0.0114", 1.62);
                yield return new msleep("Caspian seal", "Phoca", "carni", "Carnivora", "vu", 3.5, 0.4, null, 20.5, null, 86);
                yield return new msleep("Common porpoise", "Phocoena", "carni", "Cetacea", "vu", 5.6, null, null, 18.45, null, 53.18);
                yield return new msleep("Potoroo", "Potorous", "herbi", "Diprotodontia", null, 11.1, 1.5, null, 12.9, null, 1.1);
                yield return new msleep("Giant armadillo", "Priodontes", "insecti", "Cingulata", "en", 18.1, 6.1, null, 5.9, "0.081", 60);
                yield return new msleep("Rock hyrax", "Procavia", null, "Hyracoidea", "lc", 5.4, 0.5, null, 18.6, "0.021", 3.6);
                yield return new msleep("Laboratory rat", "Rattus", "herbi", "Rodentia", "lc", 13, 2.4, 0.183333333, 11, "0.0019", 0.32);
                yield return new msleep("African striped mouse", "Rhabdomys", "omni", "Rodentia", null, 8.7, null, null, 15.3, null, 0.044);
                yield return new msleep("Squirrel monkey", "Saimiri", "omni", "Primates", null, 9.6, 1.4, null, 14.4, "0.02", 0.743);
                yield return new msleep("Eastern american mole", "Scalopus", "insecti", "Soricomorpha", "lc", 8.4, 2.1, 0.166666667, 15.6, "0.0012", 0.075);
                yield return new msleep("Cotton rat", "Sigmodon", "herbi", "Rodentia", null, 11.3, 1.1, 0.15, 12.7, "0.00118", 0.148);
                yield return new msleep("Mole rat", "Spalax", null, "Rodentia", null, 10.6, 2.4, null, 13.4, "0.003", 0.122);
                yield return new msleep("Arctic ground squirrel", "Spermophilus", "herbi", "Rodentia", "lc", 16.6, null, null, 7.4, "0.0057", 0.92);
                yield return new msleep("Thirteen-lined ground squirrel", "Spermophilus", "herbi", "Rodentia", "lc", 13.8, 3.4, 0.216666667, 10.2, "0.004", 0.101);
                yield return new msleep("Golden-mantled ground squirrel", "Spermophilus", "herbi", "Rodentia", "lc", 15.9, 3, null, 8.1, null, 0.205);
                yield return new msleep("Musk shrew", "Suncus", null, "Soricomorpha", null, 12.8, 2, 0.183333333, 11.2, "0.00033", 0.048);
                yield return new msleep("Pig", "Sus", "omni", "Artiodactyla", "domesticated", 9.1, 2.4, 0.5, 14.9, "0.18", 86.25);
                yield return new msleep("Short-nosed echidna", "Tachyglossus", "insecti", "Monotremata", null, 8.6, null, null, 15.4, "0.025", 4.5);
                yield return new msleep("Eastern american chipmunk", "Tamias", "herbi", "Rodentia", null, 15.8, null, null, 8.2, null, 0.112);
                yield return new msleep("Brazilian tapir", "Tapirus", "herbi", "Perissodactyla", "vu", 4.4, 1, 0.9, 19.6, "0.169", 207.501);
                yield return new msleep("Tenrec", "Tenrec", "omni", "Afrosoricida", null, 15.6, 2.3, null, 8.4, "0.0026", 0.9);
                yield return new msleep("Tree shrew", "Tupaia", "omni", "Scandentia", null, 8.9, 2.6, 0.233333333, 15.1, "0.0025", 0.104);
                yield return new msleep("Bottle-nosed dolphin", "Tursiops", "carni", "Cetacea", null, 5.2, null, null, 18.8, null, 173.33);
                yield return new msleep("Genet", "Genetta", "carni", "Carnivora", null, 6.3, 1.3, null, 17.7, "0.0175", 2);
                yield return new msleep("Arctic fox", "Vulpes", "carni", "Carnivora", null, 12.5, null, null, 11.5, "0.0445", 3.38);
                yield return new msleep("Red fox", "Vulpes", "carni", "Carnivora", null, 9.8, 2.4, 0.35, 14.2, "0.0504", 4.23);
            }
        }
    }
}
