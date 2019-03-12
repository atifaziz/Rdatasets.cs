// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Ship Accidents
    /// </summary>

    public class Accident
    {
        public readonly int κ;
        public readonly string type;
        public readonly string constr;
        public readonly string operate;
        public readonly int? months;
        public readonly int? acc;

        public Accident(int κ, string type, string constr, string operate, int? months, int? acc)
        {
            this.κ = κ;
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
                yield return new Accident(1, "A", "C6064", "O6074", 127, 0);
                yield return new Accident(2, "A", "C6064", "O7579", 63, 0);
                yield return new Accident(3, "A", "C6569", "O6074", 1095, 3);
                yield return new Accident(4, "A", "C6569", "O7579", 1095, 4);
                yield return new Accident(5, "A", "C7074", "O6074", 1512, 6);
                yield return new Accident(6, "A", "C7074", "O7579", 3353, 18);
                yield return new Accident(7, "A", "C7579", "O6074", null, null);
                yield return new Accident(8, "A", "C7579", "O7579", 2244, 11);
                yield return new Accident(9, "B", "C6064", "O6074", 44882, 39);
                yield return new Accident(10, "B", "C6064", "O7579", 17176, 29);
                yield return new Accident(11, "B", "C6569", "O6074", 28609, 58);
                yield return new Accident(12, "B", "C6569", "O7579", 20370, 53);
                yield return new Accident(13, "B", "C7074", "O6074", 7064, 12);
                yield return new Accident(14, "B", "C7074", "O7579", 13099, 44);
                yield return new Accident(15, "B", "C7579", "O6074", null, null);
                yield return new Accident(16, "B", "C7579", "O7579", 7117, 18);
                yield return new Accident(17, "C", "C6064", "O6074", 1179, 1);
                yield return new Accident(18, "C", "C6064", "O7579", 552, 1);
                yield return new Accident(19, "C", "C6569", "O6074", 781, 0);
                yield return new Accident(20, "C", "C6569", "O7579", 676, 1);
                yield return new Accident(21, "C", "C7074", "O6074", 783, 6);
                yield return new Accident(22, "C", "C7074", "O7579", 1948, 2);
                yield return new Accident(23, "C", "C7579", "O6074", null, null);
                yield return new Accident(24, "C", "C7579", "O7579", 274, 1);
                yield return new Accident(25, "D", "C6064", "O6074", 251, 0);
                yield return new Accident(26, "D", "C6064", "O7579", 105, 0);
                yield return new Accident(27, "D", "C6569", "O6074", 288, 0);
                yield return new Accident(28, "D", "C6569", "O7579", 192, 0);
                yield return new Accident(29, "D", "C7074", "O6074", 349, 2);
                yield return new Accident(30, "D", "C7074", "O7579", 1208, 11);
                yield return new Accident(31, "D", "C7579", "O6074", null, null);
                yield return new Accident(32, "D", "C7579", "O7579", 2051, 4);
                yield return new Accident(33, "E", "C7579", "O7579", 45, 0);
                yield return new Accident(34, "E", "C6064", "O7579", null, null);
                yield return new Accident(35, "E", "C6569", "O6074", 789, 7);
                yield return new Accident(36, "E", "C6569", "O7579", 437, 7);
                yield return new Accident(37, "E", "C7074", "O6074", 1157, 5);
                yield return new Accident(38, "E", "C7074", "O7579", 2161, 12);
                yield return new Accident(39, "E", "C7579", "O6074", null, null);
                yield return new Accident(40, "E", "C7579", "O7579", 542, 1);
            }
        }
    }
}
