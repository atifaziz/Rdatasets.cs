// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Campbell Bushfire Data
    /// </summary>

    public class bushfire
    {
        public readonly int κ;
        public readonly int V1;
        public readonly int V2;
        public readonly int V3;
        public readonly int V4;
        public readonly int V5;

        public bushfire(int κ, int V1, int V2, int V3, int V4, int V5)
        {
            this.κ = κ;
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
        }

        public static IEnumerable<bushfire> Data
        {
            get
            {
                yield return new bushfire(1, 111, 145, 188, 190, 260);
                yield return new bushfire(2, 113, 147, 187, 190, 259);
                yield return new bushfire(3, 113, 150, 195, 192, 259);
                yield return new bushfire(4, 110, 147, 211, 195, 262);
                yield return new bushfire(5, 101, 136, 240, 200, 266);
                yield return new bushfire(6, 93, 125, 262, 203, 271);
                yield return new bushfire(7, 92, 110, 46, 165, 235);
                yield return new bushfire(8, 94, 95, 29, 113, 190);
                yield return new bushfire(9, 94, 94, 29, 110, 188);
                yield return new bushfire(10, 100, 104, 21, 133, 208);
                yield return new bushfire(11, 108, 115, 17, 144, 215);
                yield return new bushfire(12, 134, 156, 10, 163, 233);
                yield return new bushfire(13, 149, 181, 68, 180, 247);
                yield return new bushfire(14, 108, 154, 305, 222, 285);
                yield return new bushfire(15, 81, 137, 426, 251, 306);
                yield return new bushfire(16, 86, 138, 381, 246, 300);
                yield return new bushfire(17, 89, 137, 378, 246, 301);
                yield return new bushfire(18, 88, 133, 366, 244, 298);
                yield return new bushfire(19, 88, 131, 370, 243, 298);
                yield return new bushfire(20, 89, 133, 380, 246, 302);
                yield return new bushfire(21, 92, 137, 362, 244, 300);
                yield return new bushfire(22, 94, 139, 355, 240, 299);
                yield return new bushfire(23, 115, 156, 231, 215, 276);
                yield return new bushfire(24, 128, 167, 181, 201, 265);
                yield return new bushfire(25, 113, 156, 242, 212, 273);
                yield return new bushfire(26, 112, 155, 236, 209, 271);
                yield return new bushfire(27, 121, 162, 224, 205, 268);
                yield return new bushfire(28, 126, 166, 248, 212, 273);
                yield return new bushfire(29, 136, 174, 259, 217, 278);
                yield return new bushfire(30, 146, 177, 203, 212, 272);
                yield return new bushfire(31, 136, 155, 322, 246, 301);
                yield return new bushfire(32, 103, 97, 552, 320, 364);
                yield return new bushfire(33, 80, 66, 576, 340, 377);
                yield return new bushfire(34, 79, 66, 572, 340, 376);
                yield return new bushfire(35, 79, 66, 577, 341, 379);
                yield return new bushfire(36, 78, 66, 574, 342, 377);
                yield return new bushfire(37, 78, 66, 571, 343, 379);
                yield return new bushfire(38, 78, 66, 572, 344, 380);
            }
        }
    }
}
