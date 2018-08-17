// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Automobile Data from 'Consumer Reports' 1990
    /// </summary>

    public class cu_summary
    {
        public readonly int Price;
        public readonly string Country;
        public readonly string Reliability;
        public readonly string Mileage;
        public readonly string Type;

        public cu_summary(int Price, string Country, string Reliability, string Mileage, string Type)
        {
            this.Price = Price;
            this.Country = Country;
            this.Reliability = Reliability;
            this.Mileage = Mileage;
            this.Type = Type;
        }

        public static IEnumerable<cu_summary> Data
        {
            get
            {
                yield return new cu_summary(11950, "Japan", "Much better", null, "Small");
                yield return new cu_summary(6851, "Japan", null, null, "Small");
                yield return new cu_summary(6995, "USA", "Much worse", null, "Small");
                yield return new cu_summary(8895, "USA", "better", "33", "Small");
                yield return new cu_summary(7402, "USA", "worse", "33", "Small");
                yield return new cu_summary(6319, "Korea", "better", "37", "Small");
                yield return new cu_summary(6695, "Japan", null, null, "Small");
                yield return new cu_summary(10125, "Japan/USA", "Much better", null, "Small");
                yield return new cu_summary(6635, "Japan/USA", "Much better", "32", "Small");
                yield return new cu_summary(5899, "Korea", "worse", null, "Small");
                yield return new cu_summary(6599, "Japan", "Much better", "32", "Small");
                yield return new cu_summary(8672, "Mexico", "better", "26", "Small");
                yield return new cu_summary(5899, "Korea", "worse", null, "Small");
                yield return new cu_summary(7399, "Japan/USA", "Much better", "33", "Small");
                yield return new cu_summary(7254, "Korea", "Much worse", "28", "Small");
                yield return new cu_summary(9599, "Japan", "Much better", "25", "Small");
                yield return new cu_summary(5866, "Japan", null, "34", "Small");
                yield return new cu_summary(8748, "Japan/USA", "Much better", "29", "Small");
                yield return new cu_summary(6488, "Japan", "Much better", "35", "Small");
                yield return new cu_summary(7225, "Brazil", null, null, "Small");
                yield return new cu_summary(8695, "Mexico", "average", null, "Small");
                yield return new cu_summary(9995, "Germany", "average", "26", "Small");
                yield return new cu_summary(10995, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary(11545, "USA", "Much worse", "20", "Sporty");
                yield return new cu_summary(31979, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary(9745, "USA", "Much worse", "27", "Sporty");
                yield return new cu_summary(12895, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary(12995, "USA", null, null, "Sporty");
                yield return new cu_summary(9456, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary(12164, "USA", "Much worse", "19", "Sporty");
                yield return new cu_summary(11470, "USA", "average", "30", "Sporty");
                yield return new cu_summary(14726, "USA", "average", null, "Sporty");
                yield return new cu_summary(10390, "Japan", null, null, "Sporty");
                yield return new cu_summary(9410, "Japan", "Much better", "33", "Sporty");
                yield return new cu_summary(13945, "Japan", "Much better", "27", "Sporty");
                yield return new cu_summary(13800, "Japan", null, null, "Sporty");
                yield return new cu_summary(12279, "Japan/USA", "Much better", null, "Sporty");
                yield return new cu_summary(17880, "Japan", "Much better", null, "Sporty");
                yield return new cu_summary(13249, "Japan", "average", "24", "Sporty");
                yield return new cu_summary(27900, "Japan", null, null, "Sporty");
                yield return new cu_summary(12249, "Japan", "average", null, "Sporty");
                yield return new cu_summary(10855, "USA", null, "26", "Sporty");
                yield return new cu_summary(41990, "Germany", null, null, "Sporty");
                yield return new cu_summary(13071, "Japan", null, "28", "Sporty");
                yield return new cu_summary(12268, "Japan", null, null, "Sporty");
                yield return new cu_summary(22860, "Japan", "better", null, "Sporty");
                yield return new cu_summary(17900, "Germany", null, null, "Sporty");
                yield return new cu_summary(9995, "Mexico", null, null, "Sporty");
                yield return new cu_summary(18900, "Germany", null, "27", "Compact");
                yield return new cu_summary(23990, "Germany", null, null, "Compact");
                yield return new cu_summary(24650, "Germany", "better", null, "Compact");
                yield return new cu_summary(10565, "USA", "worse", "23", "Compact");
                yield return new cu_summary(10320, "USA", "Much worse", "26", "Compact");
                yield return new cu_summary(8620, "USA", "Much worse", null, "Compact");
                yield return new cu_summary(10945, "USA", "better", "25", "Compact");
                yield return new cu_summary(8845, "USA", "average", null, "Compact");
                yield return new cu_summary(9483, "USA", "worse", "24", "Compact");
                yield return new cu_summary(12145, "Japan/USA", "Much better", "26", "Compact");
                yield return new cu_summary(12459, "Japan/USA", "better", "24", "Compact");
                yield return new cu_summary(31600, "Germany", "average", null, "Compact");
                yield return new cu_summary(10989, "Japan", "Much better", "25", "Compact");
                yield return new cu_summary(17879, "Japan", "better", "21", "Compact");
                yield return new cu_summary(11650, "Japan", "Much better", "21", "Compact");
                yield return new cu_summary(9995, "USA", "worse", "23", "Compact");
                yield return new cu_summary(15930, "France", null, "24", "Compact");
                yield return new cu_summary(16995, "Sweden", "worse", null, "Compact");
                yield return new cu_summary(26945, "Sweden", "worse", null, "Compact");
                yield return new cu_summary(11499, "Japan/USA", "Much better", "23", "Compact");
                yield return new cu_summary(11588, "Japan/USA", "Much better", "27", "Compact");
                yield return new cu_summary(18450, "Sweden", "average", "23", "Compact");
                yield return new cu_summary(24760, "Japan", "Much better", "20", "Medium");
                yield return new cu_summary(26900, "Germany", null, null, "Medium");
                yield return new cu_summary(33200, "Germany", null, null, "Medium");
                yield return new cu_summary(13150, "USA", "average", "21", "Medium");
                yield return new cu_summary(23040, "USA", "average", null, "Medium");
                yield return new cu_summary(28855, "USA", "average", null, "Medium");
                yield return new cu_summary(12140, "USA", null, null, "Medium");
                yield return new cu_summary(25495, "USA", "average", null, "Medium");
                yield return new cu_summary(12495, "USA", "worse", "22", "Medium");
                yield return new cu_summary(16342, "USA", "average", "22", "Medium");
                yield return new cu_summary(12995, "USA", "average", null, "Medium");
                yield return new cu_summary(15350, "USA", "worse", "22", "Medium");
                yield return new cu_summary(12640, "USA", "Much worse", null, "Medium");
                yield return new cu_summary(13195, "USA", "average", "22", "Medium");
                yield return new cu_summary(14980, "USA", "Much worse", "23", "Medium");
                yield return new cu_summary(9999, "Korea", null, "23", "Medium");
                yield return new cu_summary(38000, "Japan", null, null, "Medium");
                yield return new cu_summary(35000, "Japan", null, null, "Medium");
                yield return new cu_summary(29422, "USA", "worse", null, "Medium");
                yield return new cu_summary(29246, "USA", "Much worse", null, "Medium");
                yield return new cu_summary(23300, "Japan", "Much better", "21", "Medium");
                yield return new cu_summary(39950, "Germany", "Much worse", null, "Medium");
                yield return new cu_summary(17899, "Japan", "Much better", "22", "Medium");
                yield return new cu_summary(13150, "USA", "worse", "21", "Medium");
                yield return new cu_summary(14495, "USA", null, "21", "Medium");
                yield return new cu_summary(19945, "France", null, null, "Medium");
                yield return new cu_summary(25995, "Sweden", null, null, "Medium");
                yield return new cu_summary(23550, "England", null, null, "Medium");
                yield return new cu_summary(21498, "Japan", "average", "23", "Medium");
                yield return new cu_summary(21700, "Sweden", "average", null, "Medium");
                yield return new cu_summary(20225, "USA", "average", null, "Large");
                yield return new cu_summary(16145, "USA", "average", "23", "Large");
                yield return new cu_summary(27400, "USA", "Much worse", null, "Large");
                yield return new cu_summary(26960, "USA", "average", null, "Large");
                yield return new cu_summary(14525, "USA", "Much worse", "18", "Large");
                yield return new cu_summary(17257, "USA", "average", "20", "Large");
                yield return new cu_summary(27986, "USA", "average", null, "Large");
                yield return new cu_summary(13790, "USA", "Much worse", null, "Van");
                yield return new cu_summary(13995, "USA", null, "18", "Van");
                yield return new cu_summary(11995, "USA", "average", null, "Van");
                yield return new cu_summary(15395, "USA", "average", "18", "Van");
                yield return new cu_summary(12267, "USA", "average", "18", "Van");
                yield return new cu_summary(14944, "Japan", "Much better", "19", "Van");
                yield return new cu_summary(14929, "Japan", null, "20", "Van");
                yield return new cu_summary(13949, "Japan", null, "20", "Van");
                yield return new cu_summary(14799, "Japan", null, "19", "Van");
                yield return new cu_summary(14080, "Germany", null, null, "Van");
            }
        }
    }
}
