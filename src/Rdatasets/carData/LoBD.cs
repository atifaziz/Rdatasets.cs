// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Cancer drug data use to provide an example of the use of the skew power distributions.
    /// </summary>

    public class LoBD
    {
        public readonly string pool;
        public readonly int I1L1;
        public readonly int I1L2;
        public readonly int I2L1;
        public readonly int I2L2;
        public readonly int I3L1;
        public readonly int I3L2;
        public readonly int I4L1;
        public readonly int I4L2;

        public LoBD(string pool, int I1L1, int I1L2, int I2L1, int I2L2, int I3L1, int I3L2, int I4L1, int I4L2)
        {
            this.pool = pool;
            this.I1L1 = I1L1;
            this.I1L2 = I1L2;
            this.I2L1 = I2L1;
            this.I2L2 = I2L2;
            this.I3L1 = I3L1;
            this.I3L2 = I3L2;
            this.I4L1 = I4L1;
            this.I4L2 = I4L2;
        }

        public static IEnumerable<LoBD> Data
        {
            get
            {
                yield return new LoBD("Blank_1_CAL_A", 2, 3, 3, -8, 3, -1, 3, 0);
                yield return new LoBD("Blank_1_CAL_A", 0, 1, -2, -6, 1, 2, 1, 4);
                yield return new LoBD("Blank_1_CAL_A", -1, 1, 3, -1, -1, 3, 5, 3);
                yield return new LoBD("Blank_1_CAL_A", -1, 2, -4, 0, 0, 3, 6, 4);
                yield return new LoBD("Blank_1_CAL_A", 0, 1, 2, 0, 0, 1, 2, 1);
                yield return new LoBD("Blank_2_CAL_A", -4, -2, 0, 0, 0, -2, 1, 4);
                yield return new LoBD("Blank_2_CAL_A", 2, 2, -1, 1, 2, 0, 2, 1);
                yield return new LoBD("Blank_2_CAL_A", 1, 0, 0, -2, 3, 0, 6, 4);
                yield return new LoBD("Blank_2_CAL_A", -2, -5, -1, -1, 1, 3, 3, 2);
                yield return new LoBD("Blank_2_CAL_A", -1, 2, -1, 0, 1, 1, 8, 2);
                yield return new LoBD("Blank_Plasma", 2, -3, -1, -8, 0, 1, 3, 1);
                yield return new LoBD("Blank_Plasma", 2, 3, -2, -5, 1, 2, 3, 2);
                yield return new LoBD("Blank_Plasma", -5, -5, -1, -7, -1, -1, 2, 2);
                yield return new LoBD("Blank_Plasma", -4, 2, 3, -8, -1, -2, 2, 3);
                yield return new LoBD("Blank_Plasma", -1, 5, -2, 0, -1, 2, 4, 6);
                yield return new LoBD("Blank_Serum", -1, 1, -3, -5, -3, -3, 1, 0);
                yield return new LoBD("Blank_Serum", 2, -4, -2, -8, 1, 0, 3, 3);
                yield return new LoBD("Blank_Serum", -2, -4, -4, -12, 0, 3, 2, -1);
                yield return new LoBD("Blank_Serum", 2, -1, 3, -8, -1, 1, 2, 4);
                yield return new LoBD("Blank_Serum", 3, 1, -2, -4, 0, 3, 2, 1);
                yield return new LoBD("Panel_1", 11, 9, 10, 9, 9, 11, 13, 10);
                yield return new LoBD("Panel_1", 11, 10, 9, 9, 8, 10, 11, 9);
                yield return new LoBD("Panel_1", 9, 10, 10, 8, 10, 8, 11, 10);
                yield return new LoBD("Panel_1", 8, 11, 8, 9, 7, 10, 10, 7);
                yield return new LoBD("Panel_1", 11, 12, 10, 9, 8, 7, 12, 12);
                yield return new LoBD("Panel_1", 10, 10, 9, 8, 9, 8, 10, 13);
                yield return new LoBD("Panel_1", 9, 11, 7, 10, 10, 11, 11, 10);
                yield return new LoBD("Panel_1", 8, 10, 11, 5, 9, 9, 10, 8);
                yield return new LoBD("Panel_2", 20, 18, 17, 17, 18, 19, 22, 20);
                yield return new LoBD("Panel_2", 19, 19, 19, 19, 19, 18, 20, 20);
                yield return new LoBD("Panel_2", 17, 19, 19, 21, 18, 18, 22, 18);
                yield return new LoBD("Panel_2", 19, 20, 17, 19, 18, 20, 20, 18);
                yield return new LoBD("Panel_2", 18, 19, 20, 20, 18, 18, 19, 21);
                yield return new LoBD("Panel_2", 17, 18, 15, 19, 20, 20, 20, 19);
                yield return new LoBD("Panel_2", 21, 20, 18, 20, 17, 19, 20, 20);
                yield return new LoBD("Panel_2", 19, 18, 18, 18, 17, 17, 21, 21);
                yield return new LoBD("Panel_3", 31, 27, 29, 30, 29, 27, 32, 30);
                yield return new LoBD("Panel_3", 29, 34, 25, 24, 28, 27, 32, 28);
                yield return new LoBD("Panel_3", 29, 28, 28, 31, 28, 29, 30, 25);
                yield return new LoBD("Panel_3", 29, 31, 26, 28, 29, 26, 31, 27);
                yield return new LoBD("Panel_3", 27, 27, 28, 29, 28, 29, 29, 27);
                yield return new LoBD("Panel_3", 29, 30, 28, 27, 28, 28, 29, 31);
                yield return new LoBD("Panel_3", 29, 29, 29, 30, 26, 27, 31, 28);
                yield return new LoBD("Panel_3", 28, 26, 29, 26, 27, 27, 30, 30);
                yield return new LoBD("Panel_4", 38, 37, 40, 36, 38, 37, 39, 37);
                yield return new LoBD("Panel_4", 35, 38, 34, 33, 37, 36, 38, 37);
                yield return new LoBD("Panel_4", 39, 38, 37, 35, 34, 36, 39, 34);
                yield return new LoBD("Panel_4", 38, 37, 37, 36, 36, 36, 40, 36);
                yield return new LoBD("Panel_4", 36, 36, 38, 34, 38, 37, 39, 36);
                yield return new LoBD("Panel_4", 38, 36, 34, 40, 36, 37, 41, 37);
                yield return new LoBD("Panel_4", 39, 35, 37, 39, 39, 36, 39, 39);
                yield return new LoBD("Panel_4", 37, 38, 37, 37, 35, 38, 41, 36);
                yield return new LoBD("Panel_5", 52, 51, 47, 46, 45, 47, 49, 43);
                yield return new LoBD("Panel_5", 50, 48, 49, 46, 46, 48, 48, 49);
                yield return new LoBD("Panel_5", 46, 45, 47, 49, 47, 46, 52, 45);
                yield return new LoBD("Panel_5", 47, 48, 50, 47, 47, 47, 48, 48);
                yield return new LoBD("Panel_5", 49, 49, 50, 46, 48, 46, 50, 46);
                yield return new LoBD("Panel_5", 47, 46, 44, 45, 48, 46, 49, 47);
                yield return new LoBD("Panel_5", 50, 45, 47, 47, 48, 47, 49, 46);
                yield return new LoBD("Panel_5", 46, 48, 45, 46, 46, 49, 51, 48);
                yield return new LoBD("Panel_6", 80, 78, 74, 80, 77, 78, 80, 79);
                yield return new LoBD("Panel_6", 81, 80, 76, 76, 76, 78, 80, 81);
                yield return new LoBD("Panel_6", 79, 74, 81, 71, 76, 78, 80, 75);
                yield return new LoBD("Panel_6", 77, 77, 80, 75, 79, 80, 85, 77);
                yield return new LoBD("Panel_6", 77, 73, 75, 78, 77, 77, 84, 79);
                yield return new LoBD("Panel_6", 76, 81, 79, 77, 79, 78, 80, 76);
                yield return new LoBD("Panel_6", 80, 74, 83, 82, 81, 75, 84, 79);
                yield return new LoBD("Panel_6", 80, 79, 72, 75, 80, 74, 82, 82);
                yield return new LoBD("Panel_7", 108, 100, 94, 106, 99, 97, 101, 96);
                yield return new LoBD("Panel_7", 100, 96, 89, 96, 96, 98, 96, 100);
                yield return new LoBD("Panel_7", 106, 103, 95, 99, 100, 100, 98, 95);
                yield return new LoBD("Panel_7", 99, 105, 104, 94, 101, 100, 105, 100);
                yield return new LoBD("Panel_7", 99, 97, 108, 107, 98, 95, 100, 98);
                yield return new LoBD("Panel_7", 103, 96, 97, 98, 98, 98, 104, 97);
                yield return new LoBD("Panel_7", 110, 95, 93, 101, 100, 98, 96, 98);
                yield return new LoBD("Panel_7", 102, 99, 98, 92, 95, 97, 109, 100);
                yield return new LoBD("Panel_8", 205, 192, 212, 189, 194, 199, 210, 191);
                yield return new LoBD("Panel_8", 193, 194, 202, 190, 202, 196, 194, 202);
                yield return new LoBD("Panel_8", 201, 196, 191, 186, 195, 192, 207, 202);
                yield return new LoBD("Panel_8", 202, 205, 187, 195, 199, 199, 193, 190);
                yield return new LoBD("Panel_8", 207, 204, 207, 198, 197, 203, 195, 193);
                yield return new LoBD("Panel_8", 206, 202, 192, 199, 192, 199, 198, 195);
                yield return new LoBD("Panel_8", 207, 190, 192, 197, 192, 200, 200, 200);
                yield return new LoBD("Panel_8", 203, 189, 189, 198, 185, 194, 205, 201);
            }
        }
    }
}
