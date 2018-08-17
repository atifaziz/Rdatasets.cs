// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Ship Accidents
    /// </summary>

    public class Accident
    {
        public readonly string type;
        public readonly string constr;
        public readonly string operate;
        public readonly string months;
        public readonly string acc;

        public Accident(string type, string constr, string operate, string months, string acc)
        {
            this.type = type;
            this.constr = constr;
            this.operate = operate;
            this.months = months;
            this.acc = acc;
        }

        public static IEnumerable<Accident> Data
        {
            get
            {
                yield return new Accident("A", "C6064", "O6074", "127", "0");
                yield return new Accident("A", "C6064", "O7579", "63", "0");
                yield return new Accident("A", "C6569", "O6074", "1095", "3");
                yield return new Accident("A", "C6569", "O7579", "1095", "4");
                yield return new Accident("A", "C7074", "O6074", "1512", "6");
                yield return new Accident("A", "C7074", "O7579", "3353", "18");
                yield return new Accident("A", "C7579", "O6074", null, null);
                yield return new Accident("A", "C7579", "O7579", "2244", "11");
                yield return new Accident("B", "C6064", "O6074", "44882", "39");
                yield return new Accident("B", "C6064", "O7579", "17176", "29");
                yield return new Accident("B", "C6569", "O6074", "28609", "58");
                yield return new Accident("B", "C6569", "O7579", "20370", "53");
                yield return new Accident("B", "C7074", "O6074", "7064", "12");
                yield return new Accident("B", "C7074", "O7579", "13099", "44");
                yield return new Accident("B", "C7579", "O6074", null, null);
                yield return new Accident("B", "C7579", "O7579", "7117", "18");
                yield return new Accident("C", "C6064", "O6074", "1179", "1");
                yield return new Accident("C", "C6064", "O7579", "552", "1");
                yield return new Accident("C", "C6569", "O6074", "781", "0");
                yield return new Accident("C", "C6569", "O7579", "676", "1");
                yield return new Accident("C", "C7074", "O6074", "783", "6");
                yield return new Accident("C", "C7074", "O7579", "1948", "2");
                yield return new Accident("C", "C7579", "O6074", null, null);
                yield return new Accident("C", "C7579", "O7579", "274", "1");
                yield return new Accident("D", "C6064", "O6074", "251", "0");
                yield return new Accident("D", "C6064", "O7579", "105", "0");
                yield return new Accident("D", "C6569", "O6074", "288", "0");
                yield return new Accident("D", "C6569", "O7579", "192", "0");
                yield return new Accident("D", "C7074", "O6074", "349", "2");
                yield return new Accident("D", "C7074", "O7579", "1208", "11");
                yield return new Accident("D", "C7579", "O6074", null, null);
                yield return new Accident("D", "C7579", "O7579", "2051", "4");
                yield return new Accident("E", "C7579", "O7579", "45", "0");
                yield return new Accident("E", "C6064", "O7579", null, null);
                yield return new Accident("E", "C6569", "O6074", "789", "7");
                yield return new Accident("E", "C6569", "O7579", "437", "7");
                yield return new Accident("E", "C7074", "O6074", "1157", "5");
                yield return new Accident("E", "C7074", "O7579", "2161", "12");
                yield return new Accident("E", "C7579", "O6074", null, null);
                yield return new Accident("E", "C7579", "O7579", "542", "1");
            }
        }
    }
}
