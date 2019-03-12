// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Student's (1906) Yeast Cell Counts
    /// </summary>

    public class YeastD_mat
    {
        public readonly string κ;
        public readonly int C1;
        public readonly int C2;
        public readonly int C3;
        public readonly int C4;
        public readonly int C5;
        public readonly int C6;
        public readonly int C7;
        public readonly int C8;
        public readonly int C9;
        public readonly int C10;
        public readonly int C11;
        public readonly int C12;
        public readonly int C13;
        public readonly int C14;
        public readonly int C15;
        public readonly int C16;
        public readonly int C17;
        public readonly int C18;
        public readonly int C19;
        public readonly int C20;

        public YeastD_mat(string κ, int C1, int C2, int C3, int C4, int C5, int C6, int C7, int C8, int C9, int C10, int C11, int C12, int C13, int C14, int C15, int C16, int C17, int C18, int C19, int C20)
        {
            this.κ = κ;
            this.C1 = C1;
            this.C2 = C2;
            this.C3 = C3;
            this.C4 = C4;
            this.C5 = C5;
            this.C6 = C6;
            this.C7 = C7;
            this.C8 = C8;
            this.C9 = C9;
            this.C10 = C10;
            this.C11 = C11;
            this.C12 = C12;
            this.C13 = C13;
            this.C14 = C14;
            this.C15 = C15;
            this.C16 = C16;
            this.C17 = C17;
            this.C18 = C18;
            this.C19 = C19;
            this.C20 = C20;
        }

        public static IEnumerable<YeastD_mat> Data
        {
            get
            {
                yield return new YeastD_mat("R1", 2, 2, 4, 4, 4, 5, 2, 4, 7, 7, 4, 7, 5, 2, 8, 6, 7, 4, 3, 4);
                yield return new YeastD_mat("R2", 3, 3, 2, 4, 2, 5, 4, 2, 8, 6, 3, 6, 6, 10, 8, 3, 5, 6, 4, 4);
                yield return new YeastD_mat("R3", 7, 9, 5, 2, 7, 4, 4, 2, 4, 4, 4, 3, 5, 6, 5, 4, 1, 4, 2, 6);
                yield return new YeastD_mat("R4", 4, 1, 4, 7, 3, 2, 3, 5, 8, 2, 9, 5, 3, 9, 5, 5, 2, 4, 3, 4);
                yield return new YeastD_mat("R5", 4, 1, 5, 9, 3, 4, 4, 6, 6, 5, 4, 6, 5, 5, 4, 3, 5, 9, 6, 4);
                yield return new YeastD_mat("R6", 4, 4, 5, 10, 4, 4, 3, 8, 3, 2, 1, 4, 1, 5, 6, 4, 2, 3, 3, 3);
                yield return new YeastD_mat("R7", 3, 7, 4, 5, 1, 8, 5, 7, 9, 5, 8, 9, 5, 6, 6, 4, 3, 7, 4, 4);
                yield return new YeastD_mat("R8", 7, 5, 6, 3, 6, 7, 4, 5, 8, 6, 3, 3, 4, 3, 7, 4, 4, 4, 5, 3);
                yield return new YeastD_mat("R9", 8, 10, 6, 3, 3, 6, 5, 2, 5, 3, 11, 3, 7, 4, 7, 3, 5, 5, 3, 4);
                yield return new YeastD_mat("R10", 1, 3, 7, 2, 5, 5, 5, 3, 3, 4, 6, 5, 6, 1, 6, 4, 4, 4, 6, 4);
                yield return new YeastD_mat("R11", 4, 2, 5, 4, 8, 6, 3, 4, 6, 5, 2, 6, 6, 1, 2, 2, 2, 5, 2, 2);
                yield return new YeastD_mat("R12", 5, 9, 3, 5, 6, 4, 6, 5, 7, 1, 3, 6, 5, 4, 2, 8, 9, 5, 4, 3);
                yield return new YeastD_mat("R13", 2, 2, 11, 4, 6, 6, 4, 6, 2, 5, 3, 5, 7, 2, 6, 5, 5, 1, 2, 7);
                yield return new YeastD_mat("R14", 5, 12, 5, 8, 2, 4, 2, 1, 6, 4, 5, 1, 2, 9, 1, 3, 4, 7, 3, 6);
                yield return new YeastD_mat("R15", 5, 6, 5, 4, 4, 5, 2, 7, 6, 2, 7, 3, 5, 4, 4, 5, 4, 7, 5, 4);
                yield return new YeastD_mat("R16", 8, 4, 6, 6, 5, 3, 3, 5, 7, 4, 5, 5, 5, 6, 10, 2, 3, 8, 3, 5);
                yield return new YeastD_mat("R17", 6, 6, 4, 2, 6, 6, 7, 5, 4, 5, 8, 6, 7, 6, 4, 2, 6, 1, 1, 4);
                yield return new YeastD_mat("R18", 7, 2, 5, 7, 4, 6, 4, 5, 1, 5, 10, 8, 7, 5, 4, 6, 4, 4, 7, 5);
                yield return new YeastD_mat("R19", 4, 3, 1, 6, 2, 5, 3, 3, 3, 7, 4, 3, 7, 8, 4, 7, 3, 1, 4, 4);
                yield return new YeastD_mat("R20", 7, 6, 7, 2, 4, 5, 1, 3, 12, 4, 2, 2, 8, 7, 6, 7, 6, 3, 5, 4);
            }
        }
    }
}
