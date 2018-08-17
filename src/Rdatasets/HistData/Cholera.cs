// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// William Farr's Data on Cholera in London, 1849
    /// </summary>

    public class Cholera
    {
        public readonly string district;
        public readonly int cholera_drate;
        public readonly int cholera_deaths;
        public readonly int popn;
        public readonly int elevation;
        public readonly string region;
        public readonly string water;
        public readonly int annual_deaths;
        public readonly int pop_dens;
        public readonly double persons_house;
        public readonly double house_valpp;
        public readonly double poor_rate;
        public readonly int area;
        public readonly int houses;
        public readonly int house_val;

        public Cholera(string district, int cholera_drate, int cholera_deaths, int popn, int elevation, string region, string water, int annual_deaths, int pop_dens, double persons_house, double house_valpp, double poor_rate, int area, int houses, int house_val)
        {
            this.district = district;
            this.cholera_drate = cholera_drate;
            this.cholera_deaths = cholera_deaths;
            this.popn = popn;
            this.elevation = elevation;
            this.region = region;
            this.water = water;
            this.annual_deaths = annual_deaths;
            this.pop_dens = pop_dens;
            this.persons_house = persons_house;
            this.house_valpp = house_valpp;
            this.poor_rate = poor_rate;
            this.area = area;
            this.houses = houses;
            this.house_val = house_val;
        }

        public static IEnumerable<Cholera> Data
        {
            get
            {
                yield return new Cholera("Newington", 144, 907, 63074, -2, "Kent", "Battersea", 232, 101, 5.8, 3.788, 0.075, 624, 9370, 207460);
                yield return new Cholera("Rotherhithe", 205, 352, 17208, 0, "Kent", "Battersea", 277, 19, 5.8, 4.238, 0.143, 886, 2420, 59072);
                yield return new Cholera("Bermondsey", 164, 836, 50900, 0, "Kent", "Battersea", 267, 180, 7, 3.318, 0.089, 282, 6663, 155175);
                yield return new Cholera("St George Southwark", 161, 734, 45500, 0, "Kent", "Battersea", 264, 66, 6.2, 3.077, 0.134, 688, 5674, 107821);
                yield return new Cholera("St Olave", 181, 349, 19278, 2, "Kent", "Battersea", 281, 114, 7.9, 4.559, 0.079, 169, 2523, 90583);
                yield return new Cholera("St Saviour", 153, 539, 35227, 2, "Kent", "Battersea", 292, 141, 7.1, 5.291, 0.076, 250, 4659, 174732);
                yield return new Cholera("Westminster", 68, 437, 64109, 2, "West", "Battersea", 260, 70, 8.8, 4.189, 0.039, 917, 6439, 238164);
                yield return new Cholera("Lambeth", 120, 1618, 134768, 3, "Kent", "Battersea", 233, 34, 6.5, 4.389, 0.072, 4015, 17791, 510341);
                yield return new Cholera("Camberwell", 97, 504, 51704, 4, "Kent", "Battersea", 197, 12, 5.8, 4.508, 0.038, 4342, 6843, 180418);
                yield return new Cholera("Greenwich", 75, 718, 95954, 8, "Kent", "New River", 238, 18, 6.8, 3.379, 0.081, 5367, 11995, 274478);
                yield return new Cholera("Poplar", 71, 313, 44103, 10, "South", "New River", 241, 15, 6.2, 7.36, 0.06, 2918, 5066, 229751);
                yield return new Cholera("Chelsea", 46, 247, 53379, 12, "West", "Battersea", 287, 62, 7.1, 4.209, 0.067, 865, 5648, 169679);
                yield return new Cholera("Hammersmith, Brompton, Kensington and Fulham", 33, 225, 68425, 12, "West", "Kew", 228, 11, 6.6, 5.07, 0.039, 6097, 7483, 251925);
                yield return new Cholera("St George East", 42, 199, 47334, 15, "South", "New River", 289, 195, 6.9, 4.753, 0.08, 243, 5985, 196942);
                yield return new Cholera("Stepney", 47, 501, 106988, 16, "South", "New River", 242, 85, 6.3, 3.319, 0.066, 1257, 14364, 301888);
                yield return new Cholera("Belgrave", 28, 105, 37918, 19, "West", "Battersea", 194, 65, 8, 8.875, 0.018, 580, 3783, 267452);
                yield return new Cholera("Wandsworth", 100, 484, 48446, 22, "Kent", "Battersea", 198, 4, 6.2, 4.839, 0.072, 11695, 6459, 193395);
                yield return new Cholera("West London", 96, 278, 28829, 28, "Central", "New River", 302, 212, 9.7, 7.454, 0.067, 136, 3010, 217562);
                yield return new Cholera("Whitechapel", 64, 506, 78590, 28, "South", "New River", 290, 194, 8.1, 3.388, 0.075, 406, 8834, 243657);
                yield return new Cholera("Lewisham", 30, 96, 32299, 28, "Kent", "New River", 173, 2, 5.8, 4.824, 0.049, 17224, 3966, 111357);
                yield return new Cholera("St Martin-in-the-Fields", 37, 91, 24557, 35, "West", "New River", 240, 81, 10.3, 11.844, 0.039, 305, 2439, 297665);
                yield return new Cholera("Bethnal Green", 90, 789, 87263, 36, "South", "New River", 239, 115, 6.3, 1.48, 0.136, 760, 11782, 109937);
                yield return new Cholera("London City", 38, 213, 55816, 38, "Central", "New River", 214, 129, 7.1, 17.676, 0.056, 434, 7921, 990008);
                yield return new Cholera("East London", 45, 197, 43495, 42, "Central", "New River", 259, 284, 8.3, 4.823, 0.088, 153, 4796, 191558);
                yield return new Cholera("St James Westminster", 16, 57, 36426, 43, "West", "Kew", 212, 222, 10.4, 12.669, 0.023, 164, 3590, 474528);
                yield return new Cholera("Shoreditch", 76, 789, 104122, 48, "South", "New River", 251, 161, 6.6, 3.103, 0.082, 646, 12642, 259596);
                yield return new Cholera("St Luke", 34, 183, 53234, 48, "Central", "New River", 276, 242, 7.8, 3.731, 0.081, 220, 6385, 186256);
                yield return new Cholera("Hanover Square & Mayfair", 8, 26, 33196, 49, "West", "Kew", 179, 57, 9.5, 16.755, 0.018, 581, 3847, 611238);
                yield return new Cholera("Strand", 35, 156, 44254, 50, "Central", "New River", 242, 254, 10.1, 7.374, 0.047, 174, 4327, 321999);
                yield return new Cholera("Holborn", 35, 161, 46134, 53, "Central", "New River", 266, 235, 9.7, 5.883, 0.034, 196, 4603, 261970);
                yield return new Cholera("Hackney", 25, 139, 55152, 55, "North", "New River", 197, 14, 5.9, 4.397, 0.074, 3929, 7192, 186415);
                yield return new Cholera("Clerkenwell", 19, 121, 63499, 63, "Central", "New River", 242, 202, 8.2, 4.138, 0.057, 315, 6946, 235324);
                yield return new Cholera("St Giles", 53, 285, 54062, 68, "Central", "New River", 269, 221, 11, 5.635, 0.052, 245, 4959, 306439);
                yield return new Cholera("Paddington", 8, 35, 41267, 76, "West", "Kew", 197, 32, 7.3, 9.349, 0.039, 1277, 3479, 236263);
                yield return new Cholera("St Pancras", 22, 360, 160122, 80, "North", "New River", 222, 59, 8.8, 4.871, 0.042, 2716, 14766, 633974);
                yield return new Cholera("Islington", 22, 187, 86761, 88, "North", "New River", 200, 28, 6.6, 5.494, 0.03, 3127, 8508, 307286);
                yield return new Cholera("Marylebone", 17, 261, 153960, 100, "North", "Kew", 227, 102, 9.8, 7.586, 0.043, 1509, 14169, 1050664);
                yield return new Cholera("Hampstead", 8, 9, 11572, 350, "North", "Kew", 202, 5, 7.2, 5.805, 0.045, 2252, 1411, 58743);
            }
        }
    }
}
