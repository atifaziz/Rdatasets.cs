// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// O'Brien and Kaiser's Repeated-Measures Data
    /// </summary>

    public class OBrienKaiser
    {
        public readonly string treatment;
        public readonly string gender;
        public readonly int pre_1;
        public readonly int pre_2;
        public readonly int pre_3;
        public readonly int pre_4;
        public readonly int pre_5;
        public readonly int post_1;
        public readonly int post_2;
        public readonly int post_3;
        public readonly int post_4;
        public readonly int post_5;
        public readonly int fup_1;
        public readonly int fup_2;
        public readonly int fup_3;
        public readonly int fup_4;
        public readonly int fup_5;

        public OBrienKaiser(string treatment, string gender, int pre_1, int pre_2, int pre_3, int pre_4, int pre_5, int post_1, int post_2, int post_3, int post_4, int post_5, int fup_1, int fup_2, int fup_3, int fup_4, int fup_5)
        {
            this.treatment = treatment;
            this.gender = gender;
            this.pre_1 = pre_1;
            this.pre_2 = pre_2;
            this.pre_3 = pre_3;
            this.pre_4 = pre_4;
            this.pre_5 = pre_5;
            this.post_1 = post_1;
            this.post_2 = post_2;
            this.post_3 = post_3;
            this.post_4 = post_4;
            this.post_5 = post_5;
            this.fup_1 = fup_1;
            this.fup_2 = fup_2;
            this.fup_3 = fup_3;
            this.fup_4 = fup_4;
            this.fup_5 = fup_5;
        }

        public static IEnumerable<OBrienKaiser> Data
        {
            get
            {
                yield return new OBrienKaiser("control", "M", 1, 2, 4, 2, 1, 3, 2, 5, 3, 2, 2, 3, 2, 4, 4);
                yield return new OBrienKaiser("control", "M", 4, 4, 5, 3, 4, 2, 2, 3, 5, 3, 4, 5, 6, 4, 1);
                yield return new OBrienKaiser("control", "M", 5, 6, 5, 7, 7, 4, 5, 7, 5, 4, 7, 6, 9, 7, 6);
                yield return new OBrienKaiser("control", "F", 5, 4, 7, 5, 4, 2, 2, 3, 5, 3, 4, 4, 5, 3, 4);
                yield return new OBrienKaiser("control", "F", 3, 4, 6, 4, 3, 6, 7, 8, 6, 3, 4, 3, 6, 4, 3);
                yield return new OBrienKaiser("A", "M", 7, 8, 7, 9, 9, 9, 9, 10, 8, 9, 9, 10, 11, 9, 6);
                yield return new OBrienKaiser("A", "M", 5, 5, 6, 4, 5, 7, 7, 8, 10, 8, 8, 9, 11, 9, 8);
                yield return new OBrienKaiser("A", "F", 2, 3, 5, 3, 2, 2, 4, 8, 6, 5, 6, 6, 7, 5, 6);
                yield return new OBrienKaiser("A", "F", 3, 3, 4, 6, 4, 4, 5, 6, 4, 1, 5, 4, 7, 5, 4);
                yield return new OBrienKaiser("B", "M", 4, 4, 5, 3, 4, 6, 7, 6, 8, 8, 8, 8, 9, 7, 8);
                yield return new OBrienKaiser("B", "M", 3, 3, 4, 2, 3, 5, 4, 7, 5, 4, 5, 6, 8, 6, 5);
                yield return new OBrienKaiser("B", "M", 6, 7, 8, 6, 3, 9, 10, 11, 9, 6, 8, 7, 10, 8, 7);
                yield return new OBrienKaiser("B", "F", 5, 5, 6, 8, 6, 4, 6, 6, 8, 6, 7, 7, 8, 10, 8);
                yield return new OBrienKaiser("B", "F", 2, 2, 3, 1, 2, 5, 6, 7, 5, 2, 6, 7, 8, 6, 3);
                yield return new OBrienKaiser("B", "F", 2, 2, 3, 4, 4, 6, 6, 7, 9, 7, 7, 7, 8, 6, 7);
                yield return new OBrienKaiser("B", "F", 4, 5, 7, 5, 4, 7, 7, 8, 6, 7, 7, 8, 10, 8, 7);
            }
        }
    }
}
