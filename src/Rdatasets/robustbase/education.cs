// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Education Expenditure Data
    /// </summary>

    public class education
    {
        public readonly int κ;
        public readonly string State;
        public readonly int Region;
        public readonly int X1;
        public readonly int X2;
        public readonly int X3;
        public readonly int Y;

        public education(int κ, string State, int Region, int X1, int X2, int X3, int Y)
        {
            this.κ = κ;
            this.State = State;
            this.Region = Region;
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.Y = Y;
        }

        public static IEnumerable<education> Data
        {
            get
            {
                yield return new education(1, "ME", 1, 508, 3944, 325, 235);
                yield return new education(2, "NH", 1, 564, 4578, 323, 231);
                yield return new education(3, "VT", 1, 322, 4011, 328, 270);
                yield return new education(4, "MA", 1, 846, 5233, 305, 261);
                yield return new education(5, "RI", 1, 871, 4780, 303, 300);
                yield return new education(6, "CT", 1, 774, 5889, 307, 317);
                yield return new education(7, "NY", 1, 856, 5663, 301, 387);
                yield return new education(8, "NJ", 1, 889, 5759, 310, 285);
                yield return new education(9, "PA", 1, 715, 4894, 300, 300);
                yield return new education(10, "OH", 2, 753, 5012, 324, 221);
                yield return new education(11, "IN", 2, 649, 4908, 329, 264);
                yield return new education(12, "IL", 2, 830, 5753, 320, 308);
                yield return new education(13, "MI", 2, 738, 5439, 337, 379);
                yield return new education(14, "WI", 2, 659, 4634, 328, 342);
                yield return new education(15, "MN", 2, 664, 4921, 330, 378);
                yield return new education(16, "IA", 2, 572, 4869, 318, 232);
                yield return new education(17, "MO", 2, 701, 4672, 309, 231);
                yield return new education(18, "ND", 2, 443, 4782, 333, 246);
                yield return new education(19, "SD", 2, 446, 4296, 330, 230);
                yield return new education(20, "NB", 2, 615, 4827, 318, 268);
                yield return new education(21, "KS", 2, 661, 5057, 304, 337);
                yield return new education(22, "DE", 3, 722, 5540, 328, 344);
                yield return new education(23, "MD", 3, 766, 5331, 323, 330);
                yield return new education(24, "VA", 3, 631, 4715, 317, 261);
                yield return new education(25, "WV", 3, 390, 3828, 310, 214);
                yield return new education(26, "NC", 3, 450, 4120, 321, 245);
                yield return new education(27, "SC", 3, 476, 3817, 342, 233);
                yield return new education(28, "GA", 3, 603, 4243, 339, 250);
                yield return new education(29, "FL", 3, 805, 4647, 287, 243);
                yield return new education(30, "DY", 3, 523, 3967, 325, 216);
                yield return new education(31, "TN", 3, 588, 3946, 315, 212);
                yield return new education(32, "AL", 3, 584, 3724, 332, 208);
                yield return new education(33, "MS", 3, 445, 3448, 358, 215);
                yield return new education(34, "AR", 3, 500, 3680, 320, 221);
                yield return new education(35, "LA", 3, 661, 3825, 355, 244);
                yield return new education(36, "OK", 3, 680, 4189, 306, 234);
                yield return new education(37, "TX", 3, 797, 4336, 335, 269);
                yield return new education(38, "MT", 4, 534, 4418, 335, 302);
                yield return new education(39, "ID", 4, 541, 4323, 344, 268);
                yield return new education(40, "WY", 4, 605, 4813, 331, 323);
                yield return new education(41, "CO", 4, 785, 5046, 324, 304);
                yield return new education(42, "NM", 4, 698, 3764, 366, 317);
                yield return new education(43, "AZ", 4, 796, 4504, 340, 332);
                yield return new education(44, "UT", 4, 804, 4005, 378, 315);
                yield return new education(45, "NV", 4, 809, 5560, 330, 291);
                yield return new education(46, "WA", 4, 726, 4989, 313, 312);
                yield return new education(47, "OR", 4, 671, 4697, 305, 316);
                yield return new education(48, "CA", 4, 909, 5438, 307, 332);
                yield return new education(49, "AK", 4, 831, 5309, 333, 311);
                yield return new education(50, "HI", 4, 484, 5613, 386, 546);
            }
        }
    }
}
