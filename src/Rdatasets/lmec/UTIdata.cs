// ReSharper disable All

namespace Rdatasets.lmec
{
    using System.Collections.Generic;

    /// <summary>
    /// Data set for Unstructured Treatment Interruption Study
    /// </summary>

    public class UTIdata
    {
        public readonly string Patid;
        public readonly int Days_after_TI;
        public readonly int Fup;
        public readonly int? RNA;
        public readonly int RNAcens;

        public UTIdata(string Patid, int Days_after_TI, int Fup, int? RNA, int RNAcens)
        {
            this.Patid = Patid;
            this.Days_after_TI = Days_after_TI;
            this.Fup = Fup;
            this.RNA = RNA;
            this.RNAcens = RNAcens;
        }

        public static IEnumerable<UTIdata> Data
        {
            get
            {
                yield return new UTIdata("C1", -96, 0, 14920, 0);
                yield return new UTIdata("C1", 69, 12, 21758, 0);
                yield return new UTIdata("C1", 73, 1, 17535, 0);
                yield return new UTIdata("C1", 149, 3, 12409, 0);
                yield return new UTIdata("C1", 231, 6, 7140, 0);
                yield return new UTIdata("C1", 329, 9, 27682, 0);
                yield return new UTIdata("C10", -17, 0, 132619, 0);
                yield return new UTIdata("C10", 81, 1, 87580, 0);
                yield return new UTIdata("C10", 139, 3, 43826, 0);
                yield return new UTIdata("C10", 188, 6, 45068, 0);
                yield return new UTIdata("C10", 272, 9, 83947, 0);
                yield return new UTIdata("C10", 398, 12, 90957, 0);
                yield return new UTIdata("C11", 0, 0, 44631, 0);
                yield return new UTIdata("C11", 125, 1, 25340, 0);
                yield return new UTIdata("C11", 125, 3, 25340, 0);
                yield return new UTIdata("C11", 413, 12, 93214, 0);
                yield return new UTIdata("C12", -94, 0, 93620, 0);
                yield return new UTIdata("C12", 40, 1, 83170, 0);
                yield return new UTIdata("C12", 117, 3, 66566, 0);
                yield return new UTIdata("C12", 257, 6, 108256, 0);
                yield return new UTIdata("C12", 329, 9, 49324, 0);
                yield return new UTIdata("C12", 392, 12, 55205, 0);
                yield return new UTIdata("C12", 552, 18, 181315, 0);
                yield return new UTIdata("C12", 867, 24, 124481, 0);
                yield return new UTIdata("C13", 0, 0, 16929, 0);
                yield return new UTIdata("C13", 78, 1, 33059, 0);
                yield return new UTIdata("C13", 78, 3, 33059, 0);
                yield return new UTIdata("C13", 203, 6, 94831, 0);
                yield return new UTIdata("C14", -78, 0, 179147, 0);
                yield return new UTIdata("C14", 35, 1, 85071, 0);
                yield return new UTIdata("C14", 134, 3, 114258, 0);
                yield return new UTIdata("C14", 219, 6, 206520, 0);
                yield return new UTIdata("C15", -18, 0, 244465, 0);
                yield return new UTIdata("C15", 50, 1, null, 0);
                yield return new UTIdata("C15", 99, 3, null, 0);
                yield return new UTIdata("C15", 183, 6, 173600, 0);
                yield return new UTIdata("C15", 267, 9, 102147, 0);
                yield return new UTIdata("C15", 393, 12, 97082, 0);
                yield return new UTIdata("C15", 422, 18, 86303, 0);
                yield return new UTIdata("C16", -55, 0, 25771, 0);
                yield return new UTIdata("C16", 50, 1, 151412, 0);
                yield return new UTIdata("C16", 114, 3, null, 0);
                yield return new UTIdata("C17", -26, 0, 63386, 0);
                yield return new UTIdata("C17", 59, 1, 49188, 0);
                yield return new UTIdata("C17", 59, 3, 49188, 0);
                yield return new UTIdata("C18", -41, 0, 232486, 0);
                yield return new UTIdata("C18", 45, 1, 615480, 0);
                yield return new UTIdata("C18", 113, 3, 483843, 0);
                yield return new UTIdata("C18", 205, 6, 378358, 0);
                yield return new UTIdata("C18", 239, 9, 750000, 2);
                yield return new UTIdata("C19", -14, 0, 32000, 0);
                yield return new UTIdata("C19", 35, 1, 710738, 0);
                yield return new UTIdata("C19", 106, 3, 750000, 2);
                yield return new UTIdata("C19", 195, 6, 750000, 2);
                yield return new UTIdata("C19", 266, 9, 645044, 0);
                yield return new UTIdata("C2", -19, 0, 2140, 0);
                yield return new UTIdata("C2", 120, 1, 18958, 0);
                yield return new UTIdata("C2", 120, 3, 18958, 0);
                yield return new UTIdata("C2", 213, 6, 49178, 0);
                yield return new UTIdata("C2", 317, 9, 64664, 0);
                yield return new UTIdata("C2", 406, 12, 66719, 0);
                yield return new UTIdata("C3", 0, 0, 6423, 0);
                yield return new UTIdata("C3", 70, 1, 9151, 0);
                yield return new UTIdata("C3", 154, 3, 9193, 0);
                yield return new UTIdata("C4", 0, 0, 37965, 0);
                yield return new UTIdata("C4", 65, 1, 124429, 0);
                yield return new UTIdata("C4", 100, 3, 138600, 0);
                yield return new UTIdata("C5", -101, 0, 3304, 0);
                yield return new UTIdata("C5", 32, 1, 1765, 0);
                yield return new UTIdata("C5", 136, 3, 1287, 0);
                yield return new UTIdata("C5", 221, 6, 2287, 0);
                yield return new UTIdata("C5", 276, 9, 3980, 0);
                yield return new UTIdata("C5", 360, 12, 5870, 0);
                yield return new UTIdata("C5", 509, 18, 6879, 0);
                yield return new UTIdata("C6", 0, 0, 30282, 0);
                yield return new UTIdata("C7", -67, 0, 23690, 0);
                yield return new UTIdata("C7", 7, 1, 16714, 0);
                yield return new UTIdata("C7", 92, 3, 37345, 0);
                yield return new UTIdata("C7", 164, 6, 38220, 0);
                yield return new UTIdata("C8", -11, 0, 50, 1);
                yield return new UTIdata("C8", 16, 1, 24806, 0);
                yield return new UTIdata("C8", 100, 3, 27654, 0);
                yield return new UTIdata("C8", 211, 6, 77494, 0);
                yield return new UTIdata("C8", 255, 9, 103906, 0);
                yield return new UTIdata("C9", -70, 0, 50, 1);
                yield return new UTIdata("C9", 14, 1, 400, 1);
                yield return new UTIdata("C9", 82, 3, 58431, 0);
                yield return new UTIdata("C9", 174, 6, 29702, 0);
                yield return new UTIdata("C9", 237, 9, 19394, 0);
                yield return new UTIdata("C9", 383, 12, 13535, 0);
                yield return new UTIdata("LA10", 0, 0, 50, 1);
                yield return new UTIdata("LA10", 42, 1, 50, 1);
                yield return new UTIdata("LA10", 98, 3, 50, 1);
                yield return new UTIdata("LA10", 203, 6, 50, 1);
                yield return new UTIdata("LA10", 245, 9, 50, 1);
                yield return new UTIdata("LA11", -5, 0, 4770, 0);
                yield return new UTIdata("LA11", 79, 1, 1700, 0);
                yield return new UTIdata("LA11", 93, 3, null, 0);
                yield return new UTIdata("LA11", 198, 6, null, 0);
                yield return new UTIdata("LA11", 254, 9, 13700, 0);
                yield return new UTIdata("LA11", 331, 12, 15600, 0);
                yield return new UTIdata("LA11", 515, 18, 48500, 0);
                yield return new UTIdata("LA11", 695, 24, 33000, 0);
                yield return new UTIdata("LA12", -5, 0, null, 0);
                yield return new UTIdata("LA12", 65, 1, 23000, 0);
                yield return new UTIdata("LA12", 135, 3, 12000, 0);
                yield return new UTIdata("LA12", 191, 6, 12000, 0);
                yield return new UTIdata("LA12", 261, 9, 6500, 0);
                yield return new UTIdata("LA12", 408, 12, 7600, 0);
                yield return new UTIdata("LA12", 531, 18, 2947, 0);
                yield return new UTIdata("LA12", 758, 24, 2815, 0);
                yield return new UTIdata("LA13", -28, 0, 5800, 0);
                yield return new UTIdata("LA13", 92, 1, 1197, 0);
                yield return new UTIdata("LA13", 92, 3, 1197, 0);
                yield return new UTIdata("LA13", 182, 6, 2701, 0);
                yield return new UTIdata("LA2", 0, 0, 1422941, 0);
                yield return new UTIdata("LA2", 28, 1, 26610, 0);
                yield return new UTIdata("LA2", 98, 3, 109737, 0);
                yield return new UTIdata("LA2", 154, 6, 111335, 0);
                yield return new UTIdata("LA3", 0, 0, 9419, 0);
                yield return new UTIdata("LA3", 13, 1, 144647, 0);
                yield return new UTIdata("LA3", 83, 3, 153160, 0);
                yield return new UTIdata("LA3", 202, 6, 297621, 0);
                yield return new UTIdata("LA3", 279, 9, 750000, 2);
                yield return new UTIdata("LA3", 377, 12, 246343, 0);
                yield return new UTIdata("LA4", 0, 0, 21119, 0);
                yield return new UTIdata("LA4", 28, 1, 73643, 0);
                yield return new UTIdata("LA4", 63, 3, 344167, 0);
                yield return new UTIdata("LA4", 196, 6, 165783, 0);
                yield return new UTIdata("LA5", -10, 0, 673, 0);
                yield return new UTIdata("LA5", 32, 1, 750000, 2);
                yield return new UTIdata("LA5", 86, 3, 246188, 0);
                yield return new UTIdata("LA5", 179, 6, 412265, 0);
                yield return new UTIdata("LA5", 242, 9, 461047, 0);
                yield return new UTIdata("LA6", 0, 0, 897, 0);
                yield return new UTIdata("LA6", 30, 1, 14958, 0);
                yield return new UTIdata("LA6", 133, 6, 8964, 0);
                yield return new UTIdata("LA6", 247, 9, 24161, 0);
                yield return new UTIdata("LA7", 0, 0, 96800, 0);
                yield return new UTIdata("LA7", 28, 1, 214000, 0);
                yield return new UTIdata("LA7", 84, 3, 174000, 0);
                yield return new UTIdata("LA7", 204, 6, 182000, 0);
                yield return new UTIdata("LA7", 269, 9, 654000, 0);
                yield return new UTIdata("LA8", -35, 0, 316, 0);
                yield return new UTIdata("LA8", 35, 1, 1612, 0);
                yield return new UTIdata("LA8", 93, 3, 981, 0);
                yield return new UTIdata("LA8", 185, 6, 1252, 0);
                yield return new UTIdata("LA9", 0, 0, 50, 1);
                yield return new UTIdata("LA9", 35, 1, 6056, 0);
                yield return new UTIdata("LA9", 112, 3, 4004, 0);
                yield return new UTIdata("LA9", 203, 6, 1507, 0);
                yield return new UTIdata("SD10", 0, 0, 1200, 0);
                yield return new UTIdata("SD10", 252, 6, 19800, 0);
                yield return new UTIdata("SD10", 400, 12, 38200, 0);
                yield return new UTIdata("SD10", 552, 18, 70600, 0);
                yield return new UTIdata("SD11", 0, 0, 4180, 0);
                yield return new UTIdata("SD11", 70, 1, 2620, 0);
                yield return new UTIdata("SD11", 70, 3, 2620, 0);
                yield return new UTIdata("SD11", 175, 6, 1340, 0);
                yield return new UTIdata("SD11", 244, 9, 5830, 0);
                yield return new UTIdata("SD11", 364, 12, 3040, 0);
                yield return new UTIdata("SD12", -53, 0, 147000, 0);
                yield return new UTIdata("SD12", 195, 6, 267000, 0);
                yield return new UTIdata("SD13", -118, 0, 50, 1);
                yield return new UTIdata("SD13", 239, 9, 50, 1);
                yield return new UTIdata("SD13", 302, 12, 50, 1);
                yield return new UTIdata("SD13", 484, 18, 4130, 0);
                yield return new UTIdata("SD14", 0, 0, 3690, 0);
                yield return new UTIdata("SD14", 27, 1, 1000, 0);
                yield return new UTIdata("SD14", 91, 3, 2990, 0);
                yield return new UTIdata("SD14", 188, 6, 7080, 0);
                yield return new UTIdata("SD14", 252, 9, 7250, 0);
                yield return new UTIdata("SD14", 314, 12, 6640, 0);
                yield return new UTIdata("SD15", 0, 0, 50, 1);
                yield return new UTIdata("SD15", 65, 1, 26600, 0);
                yield return new UTIdata("SD15", 65, 3, 26600, 0);
                yield return new UTIdata("SD15", 155, 6, 9820, 0);
                yield return new UTIdata("SD15", 252, 9, 37500, 0);
                yield return new UTIdata("SD15", 321, 12, 49800, 0);
                yield return new UTIdata("SD16", 0, 0, 13000, 0);
                yield return new UTIdata("SD16", 92, 1, 15000, 0);
                yield return new UTIdata("SD16", 92, 3, 15000, 0);
                yield return new UTIdata("SD16", 169, 6, null, 0);
                yield return new UTIdata("SD17", -27, 0, 2510, 0);
                yield return new UTIdata("SD17", 78, 1, 4350, 0);
                yield return new UTIdata("SD17", 78, 3, 4350, 0);
                yield return new UTIdata("SD17", 161, 6, 21200, 0);
                yield return new UTIdata("SD17", 204, 9, 18500, 0);
                yield return new UTIdata("SD2", -68, 0, 50, 1);
                yield return new UTIdata("SD2", 23, 1, 75000, 0);
                yield return new UTIdata("SD2", 114, 3, 43243, 0);
                yield return new UTIdata("SD2", 177, 6, 49939, 0);
                yield return new UTIdata("SD2", 296, 9, 24511, 0);
                yield return new UTIdata("SD2", 387, 12, 29542, 0);
                yield return new UTIdata("SD2", 520, 18, 282692, 0);
                yield return new UTIdata("SD3", -24, 0, 50, 1);
                yield return new UTIdata("SD3", 53, 1, 50, 1);
                yield return new UTIdata("SD3", 109, 3, 50, 1);
                yield return new UTIdata("SD3", 228, 6, 50, 1);
                yield return new UTIdata("SD3", 321, 9, 629, 0);
                yield return new UTIdata("SD3", 374, 12, 1996, 0);
                yield return new UTIdata("SD3", 559, 18, 50, 1);
                yield return new UTIdata("SD3", 844, 24, 1010, 0);
                yield return new UTIdata("SD4", -42, 0, 47933, 0);
                yield return new UTIdata("SD4", 14, 1, 841, 0);
                yield return new UTIdata("SD4", 77, 3, 400, 1);
                yield return new UTIdata("SD4", 175, 6, 50, 1);
                yield return new UTIdata("SD4", 275, 9, 55181, 0);
                yield return new UTIdata("SD4", 414, 12, 30270, 0);
                yield return new UTIdata("SD4", 504, 18, 55500, 0);
                yield return new UTIdata("SD4", 686, 24, 60500, 0);
                yield return new UTIdata("SD5", -27, 0, 2932, 0);
                yield return new UTIdata("SD5", 22, 1, 1121, 0);
                yield return new UTIdata("SD5", 106, 3, 1109, 0);
                yield return new UTIdata("SD5", 183, 6, 8141, 0);
                yield return new UTIdata("SD5", 246, 9, 2060, 0);
                yield return new UTIdata("SD5", 379, 12, 2400, 0);
                yield return new UTIdata("SD5", 519, 18, 2580, 0);
                yield return new UTIdata("SD6", -182, 0, 74614, 0);
                yield return new UTIdata("SD6", 14, 1, null, 0);
                yield return new UTIdata("SD6", 133, 3, 146000, 0);
                yield return new UTIdata("SD6", 182, 6, 62300, 0);
                yield return new UTIdata("SD7", 0, 0, 65450, 0);
                yield return new UTIdata("SD7", 56, 1, 3020, 0);
                yield return new UTIdata("SD7", 84, 3, 2100, 0);
                yield return new UTIdata("SD7", 217, 6, 19200, 0);
                yield return new UTIdata("SD7", 296, 9, 10000, 0);
                yield return new UTIdata("SD7", 378, 12, 23200, 0);
                yield return new UTIdata("SD7", 568, 18, 48000, 0);
                yield return new UTIdata("SD7", 714, 24, 73300, 0);
                yield return new UTIdata("SD8", -55, 0, 50, 1);
                yield return new UTIdata("SD8", 50, 1, 7850, 0);
                yield return new UTIdata("SD8", 120, 3, 32200, 0);
                yield return new UTIdata("SD8", 204, 6, 52400, 0);
                yield return new UTIdata("SD8", 302, 9, 64300, 0);
                yield return new UTIdata("SD8", 414, 12, 207000, 0);
                yield return new UTIdata("SD8", 516, 18, 173000, 0);
                yield return new UTIdata("SD9", 0, 0, 639, 0);
                yield return new UTIdata("SD9", 49, 1, 413, 0);
                yield return new UTIdata("SD9", 91, 3, 1420, 0);
                yield return new UTIdata("SD9", 182, 6, 648, 0);
                yield return new UTIdata("SD9", 259, 9, 1880, 0);
                yield return new UTIdata("SD9", 385, 12, 2520, 0);
                yield return new UTIdata("T1", -62, 0, 5143, 0);
                yield return new UTIdata("T1", 43, 1, null, 0);
                yield return new UTIdata("T1", 130, 3, 13163, 0);
                yield return new UTIdata("T1", 288, 9, 77344, 0);
                yield return new UTIdata("T1", 372, 12, 44604, 0);
                yield return new UTIdata("T1", 612, 18, 38188, 0);
                yield return new UTIdata("T1", 736, 24, 195110, 0);
                yield return new UTIdata("T10", -33, 0, 10700, 0);
                yield return new UTIdata("T10", 65, 1, 35200, 0);
                yield return new UTIdata("T10", 65, 3, 35200, 0);
                yield return new UTIdata("T10", 553, 18, 100000, 0);
                yield return new UTIdata("T11", -35, 0, 10400, 0);
                yield return new UTIdata("T11", 49, 1, 24316, 0);
                yield return new UTIdata("T11", 49, 3, 24316, 0);
                yield return new UTIdata("T11", 133, 6, 49689, 0);
                yield return new UTIdata("T11", 224, 9, 52247, 0);
                yield return new UTIdata("T12", -36, 0, 357762, 0);
                yield return new UTIdata("T12", 27, 1, 470000, 0);
                yield return new UTIdata("T12", 111, 3, 367967, 0);
                yield return new UTIdata("T12", 223, 6, 290000, 0);
                yield return new UTIdata("T12", 279, 9, null, 0);
                yield return new UTIdata("T13", 0, 0, 400, 1);
                yield return new UTIdata("T13", 105, 1, 1302, 0);
                yield return new UTIdata("T13", 154, 6, 1155, 0);
                yield return new UTIdata("T13", 217, 9, 2067, 0);
                yield return new UTIdata("T13", 329, 12, 1413, 0);
                yield return new UTIdata("T14", -51, 0, 17620, 0);
                yield return new UTIdata("T14", 19, 1, 149799, 0);
                yield return new UTIdata("T14", 103, 3, 56024, 0);
                yield return new UTIdata("T14", 187, 6, 45061, 0);
                yield return new UTIdata("T14", 306, 9, 72826, 0);
                yield return new UTIdata("T15", 0, 0, 922, 0);
                yield return new UTIdata("T15", 119, 1, 3895, 0);
                yield return new UTIdata("T15", 119, 3, 3895, 0);
                yield return new UTIdata("T15", 210, 6, 12146, 0);
                yield return new UTIdata("T15", 331, 12, 15724, 0);
                yield return new UTIdata("T15", 602, 18, 5850, 0);
                yield return new UTIdata("T15", 720, 24, 8450, 0);
                yield return new UTIdata("T16", -33, 0, 39189, 0);
                yield return new UTIdata("T17", 0, 0, 80100, 0);
                yield return new UTIdata("T17", 49, 1, 95500, 0);
                yield return new UTIdata("T18", 0, 0, 50, 1);
                yield return new UTIdata("T18", 37, 1, 27900, 0);
                yield return new UTIdata("T18", 93, 3, 150000, 0);
                yield return new UTIdata("T18", 126, 6, 131000, 0);
                yield return new UTIdata("T19", -35, 0, 3680, 0);
                yield return new UTIdata("T19", 31, 1, 57500, 0);
                yield return new UTIdata("T19", 184, 6, 89560, 0);
                yield return new UTIdata("T2", -193, 0, 126, 0);
                yield return new UTIdata("T2", 32, 1, 1251, 0);
                yield return new UTIdata("T2", 122, 3, 1232, 0);
                yield return new UTIdata("T2", 229, 9, 1440, 0);
                yield return new UTIdata("T2", 369, 12, 2300, 0);
                yield return new UTIdata("T2", 467, 18, 4320, 0);
                yield return new UTIdata("T20", -56, 0, 17795, 0);
                yield return new UTIdata("T20", 42, 1, 31119, 0);
                yield return new UTIdata("T20", 84, 3, 56354, 0);
                yield return new UTIdata("T20", 140, 6, 97789, 0);
                yield return new UTIdata("T21", -74, 0, 2186, 0);
                yield return new UTIdata("T21", 38, 1, 18296, 0);
                yield return new UTIdata("T21", 122, 3, 22957, 0);
                yield return new UTIdata("T21", 206, 6, 116264, 0);
                yield return new UTIdata("T21", 270, 9, 750000, 2);
                yield return new UTIdata("T21", 360, 12, 66000, 0);
                yield return new UTIdata("T21", 542, 18, 181706, 0);
                yield return new UTIdata("T21", 647, 24, 101000, 0);
                yield return new UTIdata("T22", -58, 0, 37500, 0);
                yield return new UTIdata("T22", 34, 1, 74500, 0);
                yield return new UTIdata("T22", 138, 3, 195538, 0);
                yield return new UTIdata("T22", 173, 6, 361519, 0);
                yield return new UTIdata("T23", 0, 0, 26700, 0);
                yield return new UTIdata("T23", 210, 6, 24000, 0);
                yield return new UTIdata("T23", 280, 9, 120000, 0);
                yield return new UTIdata("T24", 0, 0, 8000, 0);
                yield return new UTIdata("T24", 77, 1, 85600, 0);
                yield return new UTIdata("T24", 77, 3, 85600, 0);
                yield return new UTIdata("T24", 198, 6, 23000, 0);
                yield return new UTIdata("T24", 266, 9, 52391, 0);
                yield return new UTIdata("T24", 350, 12, 22016, 0);
                yield return new UTIdata("T24", 562, 18, 50475, 0);
                yield return new UTIdata("T24", 714, 24, 197395, 0);
                yield return new UTIdata("T25", 0, 0, 5224, 0);
                yield return new UTIdata("T25", 112, 1, 6463, 0);
                yield return new UTIdata("T25", 112, 3, 6463, 0);
                yield return new UTIdata("T25", 217, 6, 42115, 0);
                yield return new UTIdata("T25", 315, 9, 34159, 0);
                yield return new UTIdata("T25", 392, 12, 36659, 0);
                yield return new UTIdata("T25", 588, 18, 23365, 0);
                yield return new UTIdata("T25", 721, 24, 42094, 0);
                yield return new UTIdata("T26", -5, 0, 19061, 0);
                yield return new UTIdata("T26", 198, 6, 29987, 0);
                yield return new UTIdata("T26", 247, 9, 22723, 0);
                yield return new UTIdata("T3", -81, 0, 275, 0);
                yield return new UTIdata("T3", 51, 1, 1882, 0);
                yield return new UTIdata("T3", 122, 3, 2348, 0);
                yield return new UTIdata("T3", 229, 9, 999, 0);
                yield return new UTIdata("T3", 369, 12, 2101, 0);
                yield return new UTIdata("T3", 467, 18, 4220, 0);
                yield return new UTIdata("T4", -28, 0, 50, 1);
                yield return new UTIdata("T4", 41, 1, 43000, 0);
                yield return new UTIdata("T4", 125, 3, 24897, 0);
                yield return new UTIdata("T4", 188, 6, 25713, 0);
                yield return new UTIdata("T4", 279, 9, 38529, 0);
                yield return new UTIdata("T4", 342, 12, 38141, 0);
                yield return new UTIdata("T4", 524, 18, 68497, 0);
                yield return new UTIdata("T4", 762, 24, 40129, 0);
                yield return new UTIdata("T5", -83, 0, 9123, 0);
                yield return new UTIdata("T5", 8, 1, 11563, 0);
                yield return new UTIdata("T5", 99, 3, 17366, 0);
                yield return new UTIdata("T5", 218, 6, 9650, 0);
                yield return new UTIdata("T5", 337, 12, 15916, 0);
                yield return new UTIdata("T5", 547, 18, 7800, 0);
                yield return new UTIdata("T6", -35, 0, 19800, 0);
                yield return new UTIdata("T6", 50, 1, 9000, 0);
                yield return new UTIdata("T6", 50, 3, 9000, 0);
                yield return new UTIdata("T6", 140, 6, 20900, 0);
                yield return new UTIdata("T6", 258, 9, null, 0);
                yield return new UTIdata("T7", -49, 0, 33900, 0);
                yield return new UTIdata("T7", 34, 1, 28500, 0);
                yield return new UTIdata("T7", 130, 3, 43900, 0);
                yield return new UTIdata("T7", 204, 6, 56700, 0);
                yield return new UTIdata("T7", 270, 9, 67600, 0);
                yield return new UTIdata("T7", 327, 12, 750000, 2);
                yield return new UTIdata("T7", 574, 18, 40100, 0);
                yield return new UTIdata("T7", 678, 24, 70500, 0);
                yield return new UTIdata("T9", -93, 0, 50, 1);
                yield return new UTIdata("T9", 14, 1, 26828, 0);
                yield return new UTIdata("T9", 134, 3, 60790, 0);
                yield return new UTIdata("T9", 197, 6, 113773, 0);
                yield return new UTIdata("T9", 286, 9, 120000, 0);
            }
        }
    }
}
