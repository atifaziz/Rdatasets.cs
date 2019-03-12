// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// prison
    /// </summary>

    public class prison
    {
        public readonly int κ;
        public readonly int ACTFRemanded_;
        public readonly int ACTFSentenced;
        public readonly int ACTMRemanded_;
        public readonly int ACTMSentenced;
        public readonly int NSWFRemanded_;
        public readonly int NSWFSentenced;
        public readonly int NSWMRemanded_;
        public readonly int NSWMSentenced;
        public readonly int NT_FRemanded_;
        public readonly int NT_FSentenced;
        public readonly int NT_MRemanded_;
        public readonly int NT_MSentenced;
        public readonly int QLDFRemanded_;
        public readonly int QLDFSentenced;
        public readonly int QLDMRemanded_;
        public readonly int QLDMSentenced;
        public readonly int SA_FRemanded_;
        public readonly int SA_FSentenced;
        public readonly int SA_MRemanded_;
        public readonly int SA_MSentenced;
        public readonly int TASFRemanded_;
        public readonly int TASFSentenced;
        public readonly int TASMRemanded_;
        public readonly int TASMSentenced;
        public readonly int VICFRemanded_;
        public readonly int VICFSentenced;
        public readonly int VICMRemanded_;
        public readonly int VICMSentenced;
        public readonly int WA_FRemanded_;
        public readonly int WA_FSentenced;
        public readonly int WA_MRemanded_;
        public readonly int WA_MSentenced;

        public prison(int κ, int ACTFRemanded_, int ACTFSentenced, int ACTMRemanded_, int ACTMSentenced, int NSWFRemanded_, int NSWFSentenced, int NSWMRemanded_, int NSWMSentenced, int NT_FRemanded_, int NT_FSentenced, int NT_MRemanded_, int NT_MSentenced, int QLDFRemanded_, int QLDFSentenced, int QLDMRemanded_, int QLDMSentenced, int SA_FRemanded_, int SA_FSentenced, int SA_MRemanded_, int SA_MSentenced, int TASFRemanded_, int TASFSentenced, int TASMRemanded_, int TASMSentenced, int VICFRemanded_, int VICFSentenced, int VICMRemanded_, int VICMSentenced, int WA_FRemanded_, int WA_FSentenced, int WA_MRemanded_, int WA_MSentenced)
        {
            this.κ = κ;
            this.ACTFRemanded_ = ACTFRemanded_;
            this.ACTFSentenced = ACTFSentenced;
            this.ACTMRemanded_ = ACTMRemanded_;
            this.ACTMSentenced = ACTMSentenced;
            this.NSWFRemanded_ = NSWFRemanded_;
            this.NSWFSentenced = NSWFSentenced;
            this.NSWMRemanded_ = NSWMRemanded_;
            this.NSWMSentenced = NSWMSentenced;
            this.NT_FRemanded_ = NT_FRemanded_;
            this.NT_FSentenced = NT_FSentenced;
            this.NT_MRemanded_ = NT_MRemanded_;
            this.NT_MSentenced = NT_MSentenced;
            this.QLDFRemanded_ = QLDFRemanded_;
            this.QLDFSentenced = QLDFSentenced;
            this.QLDMRemanded_ = QLDMRemanded_;
            this.QLDMSentenced = QLDMSentenced;
            this.SA_FRemanded_ = SA_FRemanded_;
            this.SA_FSentenced = SA_FSentenced;
            this.SA_MRemanded_ = SA_MRemanded_;
            this.SA_MSentenced = SA_MSentenced;
            this.TASFRemanded_ = TASFRemanded_;
            this.TASFSentenced = TASFSentenced;
            this.TASMRemanded_ = TASMRemanded_;
            this.TASMSentenced = TASMSentenced;
            this.VICFRemanded_ = VICFRemanded_;
            this.VICFSentenced = VICFSentenced;
            this.VICMRemanded_ = VICMRemanded_;
            this.VICMSentenced = VICMSentenced;
            this.WA_FRemanded_ = WA_FRemanded_;
            this.WA_FSentenced = WA_FSentenced;
            this.WA_MRemanded_ = WA_MRemanded_;
            this.WA_MSentenced = WA_MSentenced;
        }

        public static IEnumerable<prison> Data
        {
            get
            {
                yield return new prison(1, 2, 5, 65, 106, 182, 468, 1972, 6396, 13, 12, 147, 613, 81, 273, 1000, 3940, 38, 54, 486, 974, 10, 21, 106, 388, 62, 196, 587, 2689, 61, 210, 495, 2644);
                yield return new prison(2, 4, 6, 66, 107, 191, 461, 1975, 6472, 10, 18, 140, 654, 81, 277, 1019, 3968, 39, 54, 451, 967, 8, 20, 113, 399, 59, 196, 587, 2750, 52, 216, 518, 2765);
                yield return new prison(3, 1, 5, 63, 118, 186, 437, 1844, 6540, 8, 16, 123, 649, 76, 288, 989, 4015, 48, 52, 476, 954, 10, 21, 115, 383, 59, 198, 593, 2828, 49, 201, 504, 2662);
                yield return new prison(4, 4, 8, 63, 129, 172, 457, 1860, 6502, 10, 16, 125, 609, 81, 290, 985, 3965, 44, 58, 504, 950, 12, 23, 102, 382, 54, 188, 602, 2805, 43, 193, 488, 2669);
                yield return new prison(5, 4, 9, 60, 117, 191, 452, 1967, 6493, 12, 17, 141, 636, 80, 285, 1038, 4020, 41, 60, 481, 954, 11, 22, 89, 354, 50, 168, 605, 2733, 53, 194, 530, 2657);
                yield return new prison(6, 6, 9, 65, 110, 194, 463, 2005, 6594, 13, 20, 140, 643, 82, 298, 1084, 4063, 37, 64, 525, 950, 9, 29, 112, 353, 47, 178, 597, 2849, 53, 195, 544, 2686);
                yield return new prison(7, 9, 4, 52, 100, 202, 484, 2031, 6571, 11, 23, 158, 582, 89, 314, 1111, 4067, 36, 65, 514, 989, 14, 25, 124, 379, 48, 199, 687, 3006, 57, 201, 543, 2733);
                yield return new prison(8, 6, 6, 58, 109, 218, 476, 2074, 6661, 7, 21, 175, 606, 95, 320, 1127, 4098, 41, 64, 512, 1044, 16, 30, 105, 402, 45, 197, 722, 3087, 68, 213, 565, 2745);
                yield return new prison(9, 4, 5, 59, 104, 217, 463, 2154, 6664, 11, 28, 158, 635, 108, 310, 1134, 4063, 48, 62, 551, 1039, 10, 26, 101, 369, 51, 192, 695, 3080, 72, 217, 598, 2684);
                yield return new prison(10, 4, 4, 59, 93, 209, 488, 2173, 6761, 12, 28, 175, 685, 108, 332, 1185, 4059, 52, 66, 583, 1080, 11, 21, 111, 386, 54, 198, 726, 3138, 76, 243, 604, 2793);
                yield return new prison(11, 5, 6, 62, 93, 211, 470, 2167, 6746, 9, 29, 149, 670, 105, 298, 1167, 3943, 52, 68, 579, 1107, 8, 25, 106, 393, 54, 197, 758, 3162, 61, 261, 640, 2878);
                yield return new prison(12, 5, 7, 68, 95, 199, 467, 2272, 6622, 8, 30, 159, 643, 96, 310, 1100, 3935, 54, 68, 557, 1154, 10, 30, 102, 425, 50, 203, 750, 3237, 54, 264, 622, 2951);
                yield return new prison(13, 10, 9, 73, 94, 199, 443, 2354, 6606, 11, 30, 199, 660, 101, 305, 1159, 3853, 61, 67, 587, 1167, 10, 25, 103, 380, 51, 185, 744, 3131, 64, 233, 658, 2793);
                yield return new prison(14, 7, 8, 79, 84, 208, 485, 2363, 6703, 10, 30, 187, 679, 103, 303, 1152, 3988, 59, 67, 587, 1198, 13, 25, 104, 393, 62, 176, 793, 3145, 56, 202, 701, 2763);
                yield return new prison(15, 9, 3, 83, 65, 201, 514, 2322, 6903, 16, 31, 199, 699, 109, 324, 1131, 3998, 64, 63, 602, 1231, 9, 32, 103, 375, 61, 189, 765, 3269, 74, 207, 716, 2830);
                yield return new prison(16, 9, 5, 98, 61, 208, 524, 2324, 6875, 15, 32, 213, 713, 90, 353, 1061, 4086, 57, 61, 583, 1226, 7, 27, 98, 396, 64, 183, 805, 3307, 84, 222, 654, 2987);
                yield return new prison(17, 10, 3, 102, 45, 234, 511, 2491, 6855, 15, 31, 265, 787, 85, 336, 1078, 4044, 59, 71, 595, 1200, 11, 22, 97, 380, 70, 184, 743, 3216, 74, 229, 614, 3062);
                yield return new prison(18, 7, 11, 64, 88, 236, 531, 2477, 7142, 16, 35, 255, 778, 89, 345, 1081, 4215, 57, 74, 621, 1223, 11, 23, 112, 379, 77, 192, 800, 3242, 67, 256, 678, 3175);
                yield return new prison(19, 3, 11, 56, 92, 222, 546, 2484, 7147, 9, 35, 231, 763, 86, 327, 1051, 4147, 51, 76, 640, 1224, 10, 32, 103, 371, 77, 213, 767, 3333, 71, 290, 639, 3530);
                yield return new prison(20, 7, 6, 66, 97, 207, 562, 2389, 7190, 12, 34, 226, 795, 84, 336, 1054, 4058, 50, 74, 610, 1229, 9, 36, 90, 372, 76, 238, 815, 3375, 59, 321, 668, 3723);
                yield return new prison(21, 7, 6, 80, 101, 217, 540, 2519, 7006, 15, 35, 244, 804, 96, 327, 1108, 4064, 52, 74, 607, 1191, 8, 26, 84, 334, 69, 246, 768, 3394, 65, 323, 670, 3768);
                yield return new prison(22, 11, 8, 81, 116, 217, 558, 2561, 7091, 12, 38, 226, 837, 103, 343, 1117, 4170, 54, 70, 662, 1193, 11, 27, 88, 351, 70, 248, 791, 3452, 75, 328, 753, 3682);
                yield return new prison(23, 9, 5, 71, 129, 193, 555, 2398, 7090, 13, 37, 232, 815, 92, 342, 1068, 4099, 51, 79, 626, 1229, 8, 26, 101, 356, 70, 248, 741, 3507, 69, 335, 696, 3633);
                yield return new prison(24, 7, 5, 73, 133, 193, 545, 2330, 7032, 9, 37, 245, 848, 83, 325, 1081, 4065, 50, 77, 612, 1234, 6, 29, 87, 369, 69, 243, 758, 3536, 63, 316, 689, 3504);
                yield return new prison(25, 8, 7, 85, 133, 192, 501, 2564, 6749, 15, 37, 268, 855, 78, 323, 1093, 3934, 47, 78, 626, 1248, 6, 22, 78, 347, 71, 235, 776, 3432, 63, 307, 763, 3464);
                yield return new prison(26, 5, 9, 87, 137, 201, 488, 2665, 6763, 20, 40, 294, 895, 76, 347, 1114, 4033, 37, 84, 610, 1275, 7, 33, 82, 354, 73, 248, 822, 3498, 64, 297, 797, 3506);
                yield return new prison(27, 7, 6, 70, 157, 201, 487, 2569, 6707, 18, 41, 270, 934, 93, 334, 1110, 4073, 42, 85, 568, 1347, 9, 30, 98, 388, 67, 257, 827, 3613, 59, 284, 782, 3507);
                yield return new prison(28, 4, 3, 74, 154, 193, 455, 2511, 6648, 21, 39, 254, 968, 88, 392, 1096, 4140, 51, 81, 570, 1347, 6, 33, 95, 394, 75, 257, 834, 3680, 82, 283, 814, 3546);
                yield return new prison(29, 4, 6, 94, 161, 208, 438, 2523, 6549, 19, 44, 298, 1014, 94, 342, 1130, 4060, 56, 72, 621, 1357, 12, 25, 104, 366, 79, 242, 851, 3621, 93, 296, 871, 3578);
                yield return new prison(30, 3, 8, 92, 172, 204, 436, 2454, 6628, 29, 57, 302, 1035, 101, 360, 1132, 4052, 59, 79, 626, 1368, 7, 28, 94, 382, 81, 249, 899, 3666, 95, 325, 888, 3647);
                yield return new prison(31, 3, 11, 91, 168, 216, 439, 2371, 6613, 30, 53, 302, 1025, 105, 371, 1113, 4045, 53, 81, 594, 1351, 8, 38, 77, 369, 85, 255, 936, 3651, 97, 335, 881, 3627);
                yield return new prison(32, 4, 11, 86, 171, 214, 439, 2498, 6569, 23, 65, 282, 1074, 104, 370, 1092, 4178, 51, 84, 638, 1384, 7, 43, 87, 358, 93, 245, 897, 3805, 98, 342, 873, 3604);
                yield return new prison(33, 4, 8, 77, 153, 231, 449, 2635, 6544, 31, 61, 335, 1106, 118, 387, 1206, 4178, 55, 80, 666, 1406, 6, 31, 72, 350, 91, 246, 937, 3898, 109, 348, 907, 3599);
                yield return new prison(34, 5, 7, 75, 172, 227, 467, 2694, 6642, 26, 73, 316, 1103, 133, 414, 1232, 4247, 66, 79, 698, 1402, 7, 26, 97, 330, 88, 265, 934, 4000, 105, 343, 955, 3584);
                yield return new prison(35, 4, 10, 89, 208, 232, 460, 2620, 6757, 31, 73, 340, 981, 133, 438, 1259, 4360, 61, 86, 726, 1415, 5, 27, 92, 348, 99, 289, 886, 4175, 100, 349, 874, 3615);
                yield return new prison(36, 6, 11, 75, 242, 239, 460, 2656, 6925, 36, 73, 392, 1020, 149, 466, 1286, 4597, 55, 94, 747, 1472, 6, 29, 83, 362, 112, 300, 863, 4461, 93, 357, 882, 3614);
                yield return new prison(37, 5, 9, 77, 239, 262, 477, 2901, 6940, 48, 75, 447, 966, 161, 485, 1425, 4753, 70, 95, 751, 1515, 4, 27, 88, 353, 108, 297, 921, 4540, 108, 362, 911, 3635);
                yield return new prison(38, 5, 15, 92, 222, 267, 498, 2936, 7205, 37, 75, 428, 993, 163, 488, 1586, 4797, 67, 96, 819, 1542, 4, 26, 94, 343, 104, 296, 1006, 4615, 123, 353, 1012, 3692);
                yield return new prison(39, 5, 13, 82, 229, 221, 502, 2594, 7254, 43, 68, 382, 1024, 163, 498, 1498, 4899, 74, 98, 823, 1555, 4, 26, 89, 324, 98, 314, 1112, 4682, 135, 351, 1043, 3726);
                yield return new prison(40, 5, 11, 88, 239, 223, 497, 2639, 7231, 41, 75, 419, 1035, 161, 522, 1488, 5010, 75, 101, 828, 1669, 7, 19, 93, 340, 123, 319, 1275, 4712, 147, 370, 1065, 3780);
                yield return new prison(41, 7, 14, 92, 218, 298, 493, 3124, 7190, 53, 86, 462, 1058, 156, 499, 1566, 4935, 65, 91, 822, 1663, 8, 20, 103, 337, 132, 318, 1392, 4631, 156, 376, 1073, 3833);
                yield return new prison(42, 8, 12, 113, 219, 303, 543, 3278, 7493, 50, 93, 404, 1094, 174, 502, 1610, 5022, 64, 88, 849, 1693, 7, 21, 113, 371, 134, 296, 1357, 4505, 147, 380, 1135, 3843);
                yield return new prison(43, 6, 11, 109, 240, 305, 575, 3431, 7595, 43, 99, 413, 1041, 183, 500, 1621, 4958, 74, 85, 921, 1688, 12, 23, 129, 347, 135, 287, 1281, 4386, 141, 373, 1191, 3864);
                yield return new prison(44, 11, 8, 116, 264, 305, 570, 3490, 7815, 51, 114, 408, 1046, 196, 465, 1758, 4975, 78, 93, 987, 1679, 13, 31, 133, 350, 146, 276, 1438, 4442, 160, 357, 1314, 3894);
                yield return new prison(45, 13, 13, 117, 270, 349, 552, 3749, 7742, 50, 92, 481, 1106, 226, 450, 1943, 5063, 78, 95, 1029, 1651, 14, 34, 138, 349, 158, 278, 1588, 4363, 171, 367, 1425, 3876);
                yield return new prison(46, 11, 16, 127, 254, 414, 526, 3850, 7853, 40, 88, 480, 1089, 231, 452, 1987, 5083, 101, 90, 1126, 1671, 15, 34, 130, 374, 158, 278, 1716, 4305, 206, 401, 1566, 3969);
                yield return new prison(47, 11, 17, 133, 267, 425, 542, 3829, 7927, 43, 81, 417, 1087, 221, 468, 2082, 5000, 100, 89, 1086, 1669, 13, 43, 142, 381, 170, 263, 1801, 4364, 226, 396, 1623, 4076);
                yield return new prison(48, 12, 14, 143, 268, 426, 587, 3873, 7919, 38, 77, 404, 1076, 230, 511, 2079, 5208, 108, 97, 1100, 1679, 10, 41, 141, 401, 175, 268, 1915, 4418, 208, 404, 1608, 4088);
            }
        }
    }
}
