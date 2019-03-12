// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// State by State SAT data
    /// </summary>

    public class SAT
    {
        public readonly int κ;
        public readonly string state;
        public readonly double expend;
        public readonly double ratio;
        public readonly double salary;
        public readonly int frac;
        public readonly int verbal;
        public readonly int math;
        public readonly int sat;

        public SAT(int κ, string state, double expend, double ratio, double salary, int frac, int verbal, int math, int sat)
        {
            this.κ = κ;
            this.state = state;
            this.expend = expend;
            this.ratio = ratio;
            this.salary = salary;
            this.frac = frac;
            this.verbal = verbal;
            this.math = math;
            this.sat = sat;
        }

        public static IEnumerable<SAT> Data
        {
            get
            {
                yield return new SAT(1, "Alabama", 4.405, 17.2, 31.144, 8, 491, 538, 1029);
                yield return new SAT(2, "Alaska", 8.963, 17.6, 47.951, 47, 445, 489, 934);
                yield return new SAT(3, "Arizona", 4.778, 19.3, 32.175, 27, 448, 496, 944);
                yield return new SAT(4, "Arkansas", 4.459, 17.1, 28.934, 6, 482, 523, 1005);
                yield return new SAT(5, "California", 4.992, 24, 41.078, 45, 417, 485, 902);
                yield return new SAT(6, "Colorado", 5.443, 18.4, 34.571, 29, 462, 518, 980);
                yield return new SAT(7, "Connecticut", 8.817, 14.4, 50.045, 81, 431, 477, 908);
                yield return new SAT(8, "Delaware", 7.03, 16.6, 39.076, 68, 429, 468, 897);
                yield return new SAT(9, "Florida", 5.718, 19.1, 32.588, 48, 420, 469, 889);
                yield return new SAT(10, "Georgia", 5.193, 16.3, 32.291, 65, 406, 448, 854);
                yield return new SAT(11, "Hawaii", 6.078, 17.9, 38.518, 57, 407, 482, 889);
                yield return new SAT(12, "Idaho", 4.21, 19.1, 29.783, 15, 468, 511, 979);
                yield return new SAT(13, "Illinois", 6.136, 17.3, 39.431, 13, 488, 560, 1048);
                yield return new SAT(14, "Indiana", 5.826, 17.5, 36.785, 58, 415, 467, 882);
                yield return new SAT(15, "Iowa", 5.483, 15.8, 31.511, 5, 516, 583, 1099);
                yield return new SAT(16, "Kansas", 5.817, 15.1, 34.652, 9, 503, 557, 1060);
                yield return new SAT(17, "Kentucky", 5.217, 17, 32.257, 11, 477, 522, 999);
                yield return new SAT(18, "Louisiana", 4.761, 16.8, 26.461, 9, 486, 535, 1021);
                yield return new SAT(19, "Maine", 6.428, 13.8, 31.972, 68, 427, 469, 896);
                yield return new SAT(20, "Maryland", 7.245, 17, 40.661, 64, 430, 479, 909);
                yield return new SAT(21, "Massachusetts", 7.287, 14.8, 40.795, 80, 430, 477, 907);
                yield return new SAT(22, "Michigan", 6.994, 20.1, 41.895, 11, 484, 549, 1033);
                yield return new SAT(23, "Minnesota", 6, 17.5, 35.948, 9, 506, 579, 1085);
                yield return new SAT(24, "Mississippi", 4.08, 17.5, 26.818, 4, 496, 540, 1036);
                yield return new SAT(25, "Missouri", 5.383, 15.5, 31.189, 9, 495, 550, 1045);
                yield return new SAT(26, "Montana", 5.692, 16.3, 28.785, 21, 473, 536, 1009);
                yield return new SAT(27, "Nebraska", 5.935, 14.5, 30.922, 9, 494, 556, 1050);
                yield return new SAT(28, "Nevada", 5.16, 18.7, 34.836, 30, 434, 483, 917);
                yield return new SAT(29, "New Hampshire", 5.859, 15.6, 34.72, 70, 444, 491, 935);
                yield return new SAT(30, "New Jersey", 9.774, 13.8, 46.087, 70, 420, 478, 898);
                yield return new SAT(31, "New Mexico", 4.586, 17.2, 28.493, 11, 485, 530, 1015);
                yield return new SAT(32, "New York", 9.623, 15.2, 47.612, 74, 419, 473, 892);
                yield return new SAT(33, "North Carolina", 5.077, 16.2, 30.793, 60, 411, 454, 865);
                yield return new SAT(34, "North Dakota", 4.775, 15.3, 26.327, 5, 515, 592, 1107);
                yield return new SAT(35, "Ohio", 6.162, 16.6, 36.802, 23, 460, 515, 975);
                yield return new SAT(36, "Oklahoma", 4.845, 15.5, 28.172, 9, 491, 536, 1027);
                yield return new SAT(37, "Oregon", 6.436, 19.9, 38.555, 51, 448, 499, 947);
                yield return new SAT(38, "Pennsylvania", 7.109, 17.1, 44.51, 70, 419, 461, 880);
                yield return new SAT(39, "Rhode Island", 7.469, 14.7, 40.729, 70, 425, 463, 888);
                yield return new SAT(40, "South Carolina", 4.797, 16.4, 30.279, 58, 401, 443, 844);
                yield return new SAT(41, "South Dakota", 4.775, 14.4, 25.994, 5, 505, 563, 1068);
                yield return new SAT(42, "Tennessee", 4.388, 18.6, 32.477, 12, 497, 543, 1040);
                yield return new SAT(43, "Texas", 5.222, 15.7, 31.223, 47, 419, 474, 893);
                yield return new SAT(44, "Utah", 3.656, 24.3, 29.082, 4, 513, 563, 1076);
                yield return new SAT(45, "Vermont", 6.75, 13.8, 35.406, 68, 429, 472, 901);
                yield return new SAT(46, "Virginia", 5.327, 14.6, 33.987, 65, 428, 468, 896);
                yield return new SAT(47, "Washington", 5.906, 20.2, 36.151, 48, 443, 494, 937);
                yield return new SAT(48, "West Virginia", 6.107, 14.8, 31.944, 17, 448, 484, 932);
                yield return new SAT(49, "Wisconsin", 6.93, 15.9, 37.746, 9, 501, 572, 1073);
                yield return new SAT(50, "Wyoming", 6.16, 14.9, 31.285, 10, 476, 525, 1001);
            }
        }
    }
}
