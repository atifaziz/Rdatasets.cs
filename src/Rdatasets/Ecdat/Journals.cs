// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Economic Journals Dat Set
    /// </summary>

    public class Journals
    {
        public readonly int κ;
        public readonly string title;
        public readonly string pub;
        public readonly string society;
        public readonly int libprice;
        public readonly int pages;
        public readonly int charpp;
        public readonly int citestot;
        public readonly int date1;
        public readonly int oclc;
        public readonly string field;

        public Journals(int κ, string title, string pub, string society, int libprice, int pages, int charpp, int citestot, int date1, int oclc, string field)
        {
            this.κ = κ;
            this.title = title;
            this.pub = pub;
            this.society = society;
            this.libprice = libprice;
            this.pages = pages;
            this.charpp = charpp;
            this.citestot = citestot;
            this.date1 = date1;
            this.oclc = oclc;
            this.field = field;
        }

        public static IEnumerable<Journals> Data
        {
            get
            {
                yield return new Journals(1, "Asian-Pacific Economic Literature", "Blackwell", "no", 123, 440, 3822, 21, 1986, 14, "General");
                yield return new Journals(2, "South African Journal of Economic History", "So Afr ec history assn", "no", 20, 309, 1782, 22, 1986, 59, "Ec History");
                yield return new Journals(3, "Computational Economics", "Kluwer", "no", 443, 567, 2924, 22, 1987, 17, "Specialized");
                yield return new Journals(4, "MOCT-MOST Economic Policy in Transitional Economics", "Kluwer", "no", 276, 520, 3234, 22, 1991, 2, "Area Studies");
                yield return new Journals(5, "Journal of Socio-Economics", "Elsevier", "no", 295, 791, 3024, 24, 1972, 96, "Interdisciplinary");
                yield return new Journals(6, "Labour Economics", "Elsevier", "no", 344, 609, 2967, 24, 1994, 15, "Labor");
                yield return new Journals(7, "Environment and Development economics", "Cambridge Univ Pres", "no", 90, 602, 3185, 24, 1995, 14, "Development");
                yield return new Journals(8, "Review. of Radical Political Economics", "Elsevier", "no", 242, 665, 2688, 27, 1968, 202, "Specialized");
                yield return new Journals(9, "Economics of Planning", "Kluwer", "no", 226, 243, 3010, 28, 1987, 46, "Area Studies");
                yield return new Journals(10, "Metroeconomica", "Blackwell", "no", 262, 386, 2501, 30, 1949, 46, "General");
                yield return new Journals(11, "Journal of Consumer Policy", "Kluwer", "no", 279, 578, 2200, 32, 1978, 57, "Consumer Ec");
                yield return new Journals(12, "Real Estate Economics", "MIT", "no", 165, 749, 2496, 35, 1973, 125, "Specialized");
                yield return new Journals(13, "Development Policy Review", "Blackwell", "no", 242, 427, 2731, 36, 1982, 30, "Development");
                yield return new Journals(14, "Managerial and Decision Econ", "Wiley", "no", 905, 292, 4472, 37, 1980, 62, "Management Science");
                yield return new Journals(15, "Journal of Empirical Finance", "Elsevier", "no", 355, 607, 3053, 37, 1994, 16, "Finance");
                yield return new Journals(16, "International Journal of Finance & Economics", "Springer", "no", 375, 351, 4025, 40, 1996, 17, "Finance");
                yield return new Journals(17, "Journal of Economics & Management Strategy", "MIT Press", "no", 135, 602, 2394, 42, 1992, 37, "Management Science");
                yield return new Journals(18, "Atlantic Economic Journal", "Intnl Atlantic Ec. Soc.", "no", 171, 447, 3139, 44, 1972, 148, "General");
                yield return new Journals(19, "Economic Development Quarterly", "Sage", "no", 284, 385, 3318, 47, 1987, 110, "Development");
                yield return new Journals(20, "China Economic Review", "Elsevier", "no", 242, 167, 3619, 47, 1989, 16, "Area Studies");
                yield return new Journals(21, "Information Economics and Policy", "Elsevier", "no", 371, 442, 2924, 50, 1984, 30, "Specialized");
                yield return new Journals(22, "Australian Economic Papers", "Blackwell", "no", 115, 495, 3792, 51, 1961, 61, "General");
                yield return new Journals(23, "Japan and the World Economy", "Elsevier", "no", 355, 577, 3443, 56, 1988, 27, "Area Studies");
                yield return new Journals(24, "Journal of Economic Surveys", "Blackwell", "no", 355, 674, 2835, 61, 1987, 45, "General");
                yield return new Journals(25, "Insurance  Mathematics & Economics", "Elsevier", "no", 835, 745, 4263, 61, 1982, 15, "Insurance");
                yield return new Journals(26, "De Economist", "Kluwer", "no", 223, 579, 2594, 62, 1852, 25, "General");
                yield return new Journals(27, "Review of Social Economy", "Routledge", "no", 172, 578, 2720, 66, 1943, 203, "General");
                yield return new Journals(28, "Brookings Papers", "Brookings Inst.", "no", 62, 394, 2368, 67, 1970, 646, "Public Finance");
                yield return new Journals(29, "Papers in Regional Science", "Springer", "no", 191, 442, 2925, 68, 1922, 59, "Urban and Regional");
                yield return new Journals(30, "Journal of Population Economics", "Springer", "no", 411, 640, 3264, 69, 1987, 27, "Demography");
                yield return new Journals(31, "Finance and Stochastics", "Springer", "no", 274, 492, 3060, 69, 1996, 31, "Finance");
                yield return new Journals(32, "International Organization", "MIT", "no", 130, 814, 3024, 69, 1947, 532, "Ind Organization");
                yield return new Journals(33, "Canadian Public Policy", "University of Toronto Press", "no", 100, 714, 2248, 75, 1975, 52, "Public Finance");
                yield return new Journals(34, "Developing Economies", "Inst of Devel Econ", "no", 80, 539, 3345, 76, 1963, 87, "Development");
                yield return new Journals(35, "Journal of Housing Economics", "Academic Press", "no", 235, 330, 2623, 78, 1982, 27, "Specialized");
                yield return new Journals(36, "Journal of Economics & Business", "Elsevier", "no", 392, 563, 3456, 80, 1948, 291, "Business");
                yield return new Journals(37, "Journal of Evolutionary Economics", "Springer", "no", 410, 526, 2989, 81, 1991, 9, "Specialized");
                yield return new Journals(38, "Empirical Economics", "Springer", "no", 464, 719, 3366, 82, 1976, 24, "General");
                yield return new Journals(39, "Econometric Reviews", "Dekker", "no", 650, 448, 2418, 85, 1981, 49, "Econometrics");
                yield return new Journals(40, "Agricultural Economics", "Elsevier", "no", 558, 610, 4032, 87, 1986, 24, "Ag Econ");
                yield return new Journals(41, "Quarterly Review of Econ & Finance", "Elsevier", "no", 317, 931, 3036, 87, 1961, 323, "Finance");
                yield return new Journals(42, "Applied Economics Letters", "Routledge", "no", 495, 774, 5610, 89, 1994, 69, "General");
                yield return new Journals(43, "Economic Modelling", "Elsevier", "no", 535, 632, 2880, 89, 1983, 21, "General");
                yield return new Journals(44, "Growth and Change", "Blackwell", "no", 123, 302, 2772, 97, 1969, 212, "Development");
                yield return new Journals(45, "Environmental and Resource Economics", "Kluwer", "no", 717, 1061, 2924, 97, 1992, 14, "Natural Resources");
                yield return new Journals(46, "Journal of Regulatory Economics", "Kluwer", "no", 481, 628, 3666, 98, 1991, 38, "Ind Organization");
                yield return new Journals(47, "Bulletin of Indonesian Economic Studies", "ANU Press", "no", 54, 518, 2858, 98, 1964, 22, "Specialized");
                yield return new Journals(48, "Annals of Regional Science", "Springer", "no", 379, 580, 2914, 100, 1967, 77, "Urban and Regional");
                yield return new Journals(49, "Contemporary Economic Policy", "Oxford Univ Press", "no", 168, 566, 4104, 109, 1982, 290, "Public Finance");
                yield return new Journals(50, "Journal of Economic Education", "Heldref", "no", 82, 426, 2990, 112, 1970, 386, "Specialized");
                yield return new Journals(51, "Journal of the Japanese & Intnl Economies", "Academic Press", "no", 355, 451, 2541, 119, 1986, 50, "Area Studies");
                yield return new Journals(52, "Economics and Philosophy", "Cambridge Univ Pres", "no", 95, 373, 2574, 121, 1984, 144, "Interdisciplinary");
                yield return new Journals(53, "Journal of Financial Intermediation", "Academic Press", "no", 240, 420, 2773, 121, 1991, 48, "Finance");
                yield return new Journals(54, "Resource and Energy Economics", "Elsevier", "no", 448, 416, 3010, 122, 1978, 33, "Natural Resources");
                yield return new Journals(55, "Oxford Review of Economic Policy", "Oxford Univ Press", "no", 255, 600, 4284, 124, 1985, 29, "Public Finance");
                yield return new Journals(56, "Review of Industrial Organization", "Kluwer", "no", 448, 792, 1820, 126, 1990, 58, "Ind Organization");
                yield return new Journals(57, "International Review of Law & Economics", "Elsevier", "no", 392, 585, 3479, 126, 1980, 71, "Law and Econ");
                yield return new Journals(58, "Journal of World Trade", "Kluwer", "no", 475, 1138, 3088, 134, 1967, 135, "International");
                yield return new Journals(59, "Journal of Macroeconomics", "LSU Press", "no", 85, 856, 2562, 137, 1979, 183, "Macroeconomics");
                yield return new Journals(60, "American Journal of Economics & Sociology", "Blackwell", "no", 108, 578, 2331, 138, 1941, 573, "Interdisciplinary");
                yield return new Journals(61, "Public Finance Review", "Sage", "no", 394, 636, 2204, 138, 1973, 268, "Public Finance");
                yield return new Journals(62, "Manchester School", "Blackwell", "no", 336, 618, 2772, 140, 1930, 57, "General");
                yield return new Journals(63, "Energy Economics", "Elsevier", "no", 565, 495, 3038, 143, 1978, 52, "Natural Resources");
                yield return new Journals(64, "European Review of Agricultural Economics", "Oxford Univ Press", "no", 255, 573, 3228, 144, 1974, 21, "Ag Econ");
                yield return new Journals(65, "Labor History", "Carfax", "no", 165, 515, 3430, 147, 1960, 479, "Labor");
                yield return new Journals(66, "Weltwirtschaftliches Archiv/ Rev of World Economics", "Mohr Siebeck", "no", 99, 758, 2499, 150, 1865, 77, "General");
                yield return new Journals(67, "Scottish J. of Political Economy", "Blackwell", "no", 203, 596, 3036, 151, 1953, 89, "General");
                yield return new Journals(68, "Development and Change", "Blackwell", "no", 318, 888, 2623, 154, 1970, 83, "Development");
                yield return new Journals(69, "Journal of Real Estate Finance and Economics", "Kluwer", "no", 476, 630, 3432, 162, 1990, 59, "Business");
                yield return new Journals(70, "Journal of Policy Modeling", "Elsevier", "no", 473, 907, 2160, 164, 1979, 67, "Specialized");
                yield return new Journals(71, "Journal of PostKeynesian Econ", "M.E Sharpe", "no", 186, 550, 2360, 170, 1978, 225, "General");
                yield return new Journals(72, "Economic Policy", "Blackwell", "no", 170, 440, 2856, 179, 1985, 56, "Public Finance");
                yield return new Journals(73, "Mathematical Social Sciences", "Elsevier", "no", 824, 697, 3420, 180, 1981, 36, "Interdisciplinary");
                yield return new Journals(74, "Omega", "Elsevier", "no", 805, 780, 4028, 183, 1973, 101, "Business");
                yield return new Journals(75, "History of Political Economy", "Duke Univ Press", "no", 132, 767, 2280, 183, 1969, 288, "Ec History");
                yield return new Journals(76, "Economic Record", "Ec. Society of Australia", "yes", 50, 421, 4320, 188, 1925, 183, "General");
                yield return new Journals(77, "Journal of Productivity Analysis", "Kluwer", "no", 424, 567, 3432, 188, 1992, 25, "General");
                yield return new Journals(78, "Review of Income and Wealth", "Int Assn for Res in I & W", "yes", 130, 585, 3312, 189, 1945, 120, "Public Finance");
                yield return new Journals(79, "Journal of Risk and Insurance", "Am. Risk & Ins. Assn", "yes", 90, 720, 2924, 193, 1964, 263, "Insurance");
                yield return new Journals(80, "World Development", "Blackwell", "no", 805, 1270, 2842, 214, 1977, 101, "Development");
                yield return new Journals(81, "Journal of Agricultural Economics", "Agric. Econ. Society", "yes", 96, 277, 4218, 220, 1948, 43, "Ag Econ");
                yield return new Journals(82, "Economics of Education Review", "Elsevier", "no", 448, 471, 5040, 224, 1982, 73, "Specialized");
                yield return new Journals(83, "Journal of Labor Research", "George Mason Univ", "no", 130, 725, 3010, 227, 1980, 221, "Labor");
                yield return new Journals(84, "Theory and Decision", "Kluwer", "no", 595, 607, 2072, 237, 1970, 83, "Theory");
                yield return new Journals(85, "Social Choice & Welfare", "Springer", "no", 474, 674, 2990, 239, 1984, 37, "Public Finance");
                yield return new Journals(86, "Journal of Comparative Economics", "Academic Press", "no", 410, 803, 2442, 245, 1977, 185, "Area Studies");
                yield return new Journals(87, "Journal of Economic Psychology", "Elsevier", "no", 395, 802, 2535, 245, 1981, 61, "Interdisciplinary");
                yield return new Journals(88, "International Journal of Forecasting", "Elsevier", "no", 437, 464, 4324, 249, 1985, 57, "Specialized");
                yield return new Journals(89, "Kyklos", "Helbing & Lichtenhahn", "no", 270, 618, 2760, 254, 1948, 186, "General");
                yield return new Journals(90, "Explorations in Economic History", "Academic Press", "no", 265, 447, 2904, 261, 1963, 199, "Ec History");
                yield return new Journals(91, "Economic Theory", "Springer", "no", 899, 1493, 2806, 264, 1992, 165, "Theory");
                yield return new Journals(92, "Journal of Transport Economics & Policy", "LSE and Univ of Bath", "no", 133, 406, 3182, 292, 1967, 95, "Specialized");
                yield return new Journals(93, "British Journal of Industrial Relations", "Blackwell", "no", 262, 663, 3450, 294, 1963, 82, "Specialized");
                yield return new Journals(94, "Journal of Common Market Studies", "Blackwell", "no", 506, 710, 2747, 299, 1962, 214, "Area Studies");
                yield return new Journals(95, "Journal of Futures Markets", "Wiley", "no", 1140, 990, 2460, 302, 1981, 152, "Finance");
                yield return new Journals(96, "Journal of Inst. & Theoretical Econ.", "Mohr Siebeck", "no", 211, 792, 3402, 313, 1844, 33, "General");
                yield return new Journals(97, "International Journal of Industrial Organization", "Elsevier", "no", 799, 1230, 3124, 313, 1983, 81, "Ind Organization");
                yield return new Journals(98, "Journal of Forecasting", "Wiley", "no", 760, 516, 4032, 317, 1982, 137, "Specialized");
                yield return new Journals(99, "Operations Research Letters", "Elsevier", "no", 442, 460, 4056, 338, 1982, 59, "Management Science");
                yield return new Journals(100, "Scandinavian Journal of Economics", "Blackwell", "no", 296, 688, 2666, 339, 1898, 98, "General");
                yield return new Journals(101, "Cambridge Journal of Economics", "Oxford Univ Press", "no", 272, 814, 3545, 351, 1976, 163, "General");
                yield return new Journals(102, "Journal of Economic Issues", "Assn Ev. Economics", "yes", 45, 1003, 2870, 355, 1967, 462, "Public Finance");
                yield return new Journals(103, "Regional Science & Urban Econ", "Elsevier", "no", 614, 802, 2967, 370, 1971, 99, "Urban and Regional");
                yield return new Journals(104, "International Journal of Game Theory", "Springer", "no", 436, 582, 3366, 382, 1971, 52, "Theory");
                yield return new Journals(105, "Journal of Risk and Uncertainty", "Kluwer", "no", 481, 595, 3476, 383, 1990, 47, "Insurance");
                yield return new Journals(106, "Journal of Financial and Quantitative Analysis", "Univ Wash Press", "no", 95, 500, 3314, 388, 1966, 394, "Finance");
                yield return new Journals(107, "Journal of Development Studies", "Frank Cass", "no", 357, 500, 2604, 388, 1964, 227, "Development");
                yield return new Journals(108, "Econometric Theory", "Cambridge Univ Pres", "no", 280, 899, 2948, 390, 1985, 65, "Econometrics");
                yield return new Journals(109, "Journal of Regional Science", "Blackwell", "no", 142, 764, 2992, 397, 1961, 242, "Urban and Regional");
                yield return new Journals(110, "Journal of Accounting & Economics", "Elsevier", "no", 710, 1112, 2945, 406, 1979, 154, "Interdisciplinary");
                yield return new Journals(111, "Games and Econ. Behavior", "Academic Press", "no", 490, 1197, 2460, 412, 1988, 45, "Theory");
                yield return new Journals(112, "Journal of Applied Econometrics", "Wiley", "no", 870, 689, 3680, 412, 1986, 81, "Econometrics");
                yield return new Journals(113, "Journal of Mathematical Economics", "Elsevier", "no", 1147, 1340, 2940, 418, 1974, 79, "Theory");
                yield return new Journals(114, "Journal of International Money and Finance", "Elsevier", "no", 743, 940, 2660, 427, 1981, 120, "International");
                yield return new Journals(115, "Regional Studies", "Carfax", "no", 759, 911, 4988, 440, 1967, 91, "Urban and Regional");
                yield return new Journals(116, "Population & Development Review", "Population Council", "no", 36, 910, 2904, 445, 1975, 218, "Demography");
                yield return new Journals(117, "Economy and Society", "Routledge", "no", 224, 640, 2970, 488, 1971, 97, "General");
                yield return new Journals(118, "Decision Sciences", "Georgia State Univ", "no", 82, 1067, 3124, 495, 1970, 322, "Management Science");
                yield return new Journals(119, "Journal of Industrial Economics", "Blackwell", "no", 160, 476, 2684, 497, 1953, 283, "Ind Organization");
                yield return new Journals(120, "Ecological Economics", "Elsevier", "no", 1170, 1990, 4128, 499, 1989, 40, "Natural Resources");
                yield return new Journals(121, "National Tax Journal", "National Tax Assn.", "no", 90, 785, 2940, 502, 1948, 552, "Public Finance");
                yield return new Journals(122, "Urban Studies", "Carfax", "no", 742, 1711, 3747, 508, 1964, 222, "Urban and Regional");
                yield return new Journals(123, "Health Economics", "Wiley", "no", 575, 736, 4264, 544, 1992, 29, "Health");
                yield return new Journals(124, "Economic History Review", "Blackwell", "no", 163, 846, 3570, 545, 1947, 390, "Ec History");
                yield return new Journals(125, "Review of Financial Studies", "Oxford Univ. Press", "no", 175, 1235, 2604, 547, 1988, 95, "Finance");
                yield return new Journals(126, "Canadian Journal of Economics", "Blackwell", "yes", 120, 1247, 2992, 556, 1967, 305, "General");
                yield return new Journals(127, "Risk Analysis", "Kluwer", "no", 590, 1260, 4628, 574, 1981, 98, "Insurance");
                yield return new Journals(128, "Applied Economics", "Routledge", "no", 2120, 1683, 5445, 578, 1958, 146, "General");
                yield return new Journals(129, "Oxford Economic Papers", "Oxford Univ. Press", "no", 205, 767, 2924, 582, 1949, 271, "General");
                yield return new Journals(130, "Economic Development & Cultural Change", "Univ of Chicago Press", "no", 128, 889, 2700, 597, 1952, 515, "Development");
                yield return new Journals(131, "Journal of Banking and Finance", "Elsevier", "no", 1539, 1911, 2516, 602, 1977, 172, "Finance");
                yield return new Journals(132, "Oxford Bull. Of Econ. & Statistics", "Blackwell", "no", 346, 545, 2655, 617, 1939, 127, "General");
                yield return new Journals(133, "Journal of Economic Dynamics & Control", "Elsevier", "yes", 1046, 1636, 2945, 636, 1979, 58, "Theory");
                yield return new Journals(134, "Southern Economic Journal", "Southern Econ. Assn", "yes", 97, 1032, 3680, 646, 1932, 524, "General");
                yield return new Journals(135, "Journal of Management Studies", "Blackwell", "no", 686, 850, 3456, 654, 1964, 222, "Management Science");
                yield return new Journals(136, "Journal of Business Ethics", "Kluwer", "no", 914, 1270, 3650, 662, 1981, 385, "Business");
                yield return new Journals(137, "Demography", "Pop Assn America", "no", 85, 568, 6859, 670, 1964, 413, "Demography");
                yield return new Journals(138, "Economic Inquiry", "Oxford Univ Press", "no", 206, 684, 4134, 684, 1962, 366, "General");
                yield return new Journals(139, "Journal of Economic Behavior & Org.", "Elsevier", "no", 1154, 1380, 3330, 698, 1980, 75, "Theory");
                yield return new Journals(140, "Journal of Legal Studies", "Univ of Chicago Press", "no", 45, 530, 2625, 700, 1972, 238, "Law and Econ");
                yield return new Journals(141, "Journal of Development Economics", "Elsevier", "no", 1146, 1110, 2816, 707, 1974, 142, "Development");
                yield return new Journals(142, "Land Economics", "Univ of Wisconsin Press", "no", 95, 580, 3672, 730, 1925, 437, "Urban and Regional");
                yield return new Journals(143, "Journal of Labor Economics", "Univ of Chicago Press", "no", 138, 600, 2728, 733, 1983, 269, "Labor");
                yield return new Journals(144, "Journal of Economic History", "Cambridge Univ Pres", "no", 115, 1200, 4029, 737, 1941, 643, "Ec History");
                yield return new Journals(145, "Journal of Urban Economics", "Academic Press", "no", 640, 1058, 2666, 787, 1974, 230, "Urban and Regional");
                yield return new Journals(146, "Economica", "Blackwell", "no", 122, 565, 3120, 825, 1933, 313, "General");
                yield return new Journals(147, "Journal of Money Credit & Banking", "Ohio State Univ. Press", "no", 110, 860, 3168, 834, 1969, 512, "Macroeconomics");
                yield return new Journals(148, "Journal of International Economics", "Elsevier", "no", 923, 1299, 2898, 838, 1971, 211, "International");
                yield return new Journals(149, "Public Choice", "Kluwer", "no", 1000, 1600, 2583, 871, 1966, 171, "Public Finance");
                yield return new Journals(150, "Research Policy", "Elsevier", "no", 1234, 781, 4320, 922, 1972, 34, "Business");
                yield return new Journals(151, "Economics Letters", "Elsevier", "no", 1492, 1540, 3315, 930, 1978, 81, "General");
                yield return new Journals(152, "Journal of Health Economics", "Elsevier", "no", 810, 828, 2924, 957, 1982, 144, "Health");
                yield return new Journals(153, "Journal of Business & Economic Statistics", "Am Stat Assn", "yes", 90, 510, 6360, 988, 1983, 190, "Business");
                yield return new Journals(154, "Rand Journal of Economics", "RAND", "no", 177, 757, 3450, 1039, 1970, 339, "Ind Organization");
                yield return new Journals(155, "Journal of Business", "Univ of Chicago Press", "no", 74, 583, 2655, 1083, 1928, 771, "Business");
                yield return new Journals(156, "Journal of Human Resources", "Univ of Wisconsin Press", "no", 113, 837, 3312, 1113, 1966, 522, "Labor");
                yield return new Journals(157, "International Economic Review", "Blackwell", "no", 145, 969, 3082, 1113, 1960, 284, "General");
                yield return new Journals(158, "Journal of Environmental Ec. & Mgmt", "Academic Press", "no", 590, 636, 3096, 1152, 1974, 202, "Natural Resources");
                yield return new Journals(159, "European Economic Review", "Elsevier", "yes", 1154, 1823, 2178, 1243, 1969, 118, "General");
                yield return new Journals(160, "World Development", "Elsevier", "no", 1450, 1145, 5480, 1408, 1973, 160, "Development");
                yield return new Journals(161, "Journal of Public Economics", "Elsevier", "no", 1431, 1880, 2924, 1437, 1972, 141, "Public Finance");
                yield return new Journals(162, "Journal of Economic Literature", "Am Ec Assn", "yes", 47, 2632, 3848, 1530, 1963, 972, "General");
                yield return new Journals(163, "Journal of Law and Economics", "Univ of Chicago Press", "no", 45, 850, 2604, 1580, 1968, 542, "Law and Econ");
                yield return new Journals(164, "Journal of Economic Perspectives", "Am Ec Assn", "yes", 47, 940, 3036, 1583, 1987, 866, "General");
                yield return new Journals(165, "American Journal of Agricultural Economics", "Am. Ag. Econ Assn", "no", 81, 1253, 4368, 1812, 1918, 267, "Ag Econ");
                yield return new Journals(166, "Journal of Monetary Economics", "Elsevier", "no", 1010, 1346, 3174, 1860, 1975, 186, "Macroeconomics");
                yield return new Journals(167, "Management Science", "Inst for OR and MS", "no", 334, 1175, 4232, 2022, 1954, 558, "Management Science");
                yield return new Journals(168, "Review of Economics & Statistics", "MIT press", "no", 190, 733, 5600, 2331, 1919, 523, "General");
                yield return new Journals(169, "Review of Economic Studies", "Blackwell", "no", 180, 761, 3626, 2411, 1933, 325, "General");
                yield return new Journals(170, "Journal of Econometrics", "Elsevier", "no", 1893, 1527, 2178, 2479, 1973, 129, "Econometrics");
                yield return new Journals(171, "Journal of Economic Theory", "Academic Press", "no", 1400, 2000, 2684, 2514, 1969, 165, "Theory");
                yield return new Journals(172, "Economic Journal", "Blackwell", "no", 301, 1983, 3036, 2540, 1890, 531, "General");
                yield return new Journals(173, "Journal of Financial Economics", "Elsevier", "no", 1339, 1947, 2838, 2676, 1974, 231, "Finance");
                yield return new Journals(174, "Journal of Consumer Research", "Univ of Chicago Press", "no", 90, 439, 5336, 2762, 1974, 536, "Consumer Ec");
                yield return new Journals(175, "Journal of American Statistical Assn", "Am. Statistical Assn", "yes", 310, 1260, 5664, 2800, 1971, 487, "Econometrics");
                yield return new Journals(176, "Journal of Finance", "Am. Finance Assn", "yes", 226, 2272, 3036, 3791, 1945, 799, "Finance");
                yield return new Journals(177, "Quarterly Journal of Economics", "MIT press", "no", 148, 1467, 2184, 4138, 1886, 660, "General");
                yield return new Journals(178, "Journal of Political Economy", "Univ of Chicago Press", "no", 159, 1669, 2640, 6697, 1892, 737, "General");
                yield return new Journals(179, "Econometrica", "Blackwell", "yes", 178, 1482, 2992, 7943, 1932, 346, "General");
                yield return new Journals(180, "American Economic Review", "Am Ec Assn", "yes", 47, 1867, 3900, 8999, 1911, 1098, "General");
            }
        }
    }
}
