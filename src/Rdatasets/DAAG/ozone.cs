// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Ozone Data
    /// </summary>

    public class ozone
    {
        public readonly int κ;
        public readonly int Year;
        public readonly int Aug;
        public readonly int Sep;
        public readonly int Oct;
        public readonly int Nov;
        public readonly int Dec;
        public readonly int Jan;
        public readonly int Feb;
        public readonly int Mar;
        public readonly int Apr;
        public readonly int Annual;

        public ozone(int κ, int Year, int Aug, int Sep, int Oct, int Nov, int Dec, int Jan, int Feb, int Mar, int Apr, int Annual)
        {
            this.κ = κ;
            this.Year = Year;
            this.Aug = Aug;
            this.Sep = Sep;
            this.Oct = Oct;
            this.Nov = Nov;
            this.Dec = Dec;
            this.Jan = Jan;
            this.Feb = Feb;
            this.Mar = Mar;
            this.Apr = Apr;
            this.Annual = Annual;
        }

        public static IEnumerable<ozone> Data
        {
            get
            {
                yield return new ozone(1, 1956, 0, 313, 311, 370, 359, 334, 296, 288, 274, 318);
                yield return new ozone(2, 1957, 301, 284, 320, 394, 347, 332, 301, 280, 256, 312);
                yield return new ozone(3, 1958, 0, 0, 305, 349, 378, 341, 328, 297, 0, 333);
                yield return new ozone(4, 1959, 0, 0, 302, 303, 340, 322, 298, 295, 0, 309);
                yield return new ozone(5, 1960, 0, 287, 292, 345, 375, 318, 303, 304, 0, 318);
                yield return new ozone(6, 1961, 0, 267, 307, 332, 343, 310, 297, 329, 0, 312);
                yield return new ozone(7, 1962, 0, 0, 322, 380, 376, 319, 302, 305, 287, 327);
                yield return new ozone(8, 1963, 313, 0, 300, 347, 350, 316, 300, 325, 303, 319);
                yield return new ozone(9, 1964, 271, 0, 308, 401, 356, 314, 294, 296, 0, 320);
                yield return new ozone(10, 1965, 0, 0, 273, 298, 335, 299, 289, 283, 286, 295);
                yield return new ozone(11, 1966, 0, 288, 307, 338, 344, 299, 284, 268, 0, 304);
                yield return new ozone(12, 1967, 0, 0, 313, 357, 333, 318, 285, 289, 279, 310);
                yield return new ozone(13, 1968, 284, 279, 292, 385, 348, 311, 290, 280, 244, 302);
                yield return new ozone(14, 1969, 0, 285, 274, 297, 314, 305, 285, 268, 258, 286);
                yield return new ozone(15, 1970, 307, 0, 274, 355, 344, 317, 312, 274, 277, 307);
                yield return new ozone(16, 1971, 0, 278, 290, 373, 344, 315, 300, 300, 312, 314);
                yield return new ozone(17, 1972, 304, 265, 295, 375, 349, 306, 293, 286, 277, 306);
                yield return new ozone(18, 1973, 272, 263, 271, 326, 334, 307, 275, 262, 242, 292);
                yield return new ozone(19, 1974, 0, 244, 272, 337, 351, 320, 275, 279, 0, 301);
                yield return new ozone(20, 1975, 0, 267, 303, 309, 338, 314, 272, 257, 0, 298);
                yield return new ozone(21, 1976, 0, 265, 283, 326, 335, 318, 280, 275, 253, 300);
                yield return new ozone(22, 1977, 290, 239, 251, 332, 360, 310, 305, 282, 253, 302);
                yield return new ozone(23, 1978, 0, 264, 284, 345, 337, 295, 283, 278, 283, 301);
                yield return new ozone(24, 1979, 0, 232, 263, 323, 352, 324, 292, 290, 0, 303);
                yield return new ozone(25, 1980, 328, 236, 226, 293, 340, 299, 280, 253, 0, 280);
                yield return new ozone(26, 1981, 0, 241, 237, 285, 326, 290, 278, 260, 0, 278);
                yield return new ozone(27, 1982, 0, 210, 218, 268, 322, 308, 292, 278, 266, 276);
                yield return new ozone(28, 1983, 0, 228, 195, 289, 325, 301, 272, 273, 267, 270);
                yield return new ozone(29, 1984, 0, 215, 194, 248, 322, 301, 269, 263, 245, 260);
                yield return new ozone(30, 1985, 0, 217, 185, 215, 304, 286, 273, 247, 227, 247);
                yield return new ozone(31, 1986, 253, 212, 233, 282, 309, 301, 278, 274, 274, 272);
                yield return new ozone(32, 1987, 254, 182, 150, 188, 287, 286, 264, 271, 265, 235);
                yield return new ozone(33, 1988, 242, 207, 216, 312, 323, 284, 281, 260, 274, 270);
                yield return new ozone(34, 1989, 270, 186, 150, 255, 295, 290, 266, 254, 254, 246);
                yield return new ozone(35, 1990, 259, 173, 173, 207, 246, 281, 257, 263, 233, 231);
                yield return new ozone(36, 1991, 204, 163, 137, 232, 296, 271, 283, 281, 257, 239);
                yield return new ozone(37, 1992, 185, 152, 147, 206, 270, 284, 275, 277, 256, 233);
                yield return new ozone(38, 1993, 209, 167, 122, 179, 285, 278, 264, 255, 284, 225);
                yield return new ozone(39, 1994, 197, 152, 126, 217, 316, 278, 269, 256, 254, 232);
                yield return new ozone(40, 1995, 218, 160, 130, 164, 252, 261, 249, 246, 226, 212);
                yield return new ozone(41, 1996, 173, 155, 148, 181, 260, 278, 265, 247, 243, 217);
                yield return new ozone(42, 1997, 218, 171, 141, 210, 286, 267, 262, 264, 255, 230);
                yield return new ozone(43, 1998, 221, 162, 140, 183, 255, 272, 259, 254, 267, 224);
                yield return new ozone(44, 1999, 205, 172, 143, 172, 254, 281, 258, 250, 256, 221);
                yield return new ozone(45, 2000, 179, 151, 137, 267, 299, 286, 261, 251, 245, 231);
            }
        }
    }
}
