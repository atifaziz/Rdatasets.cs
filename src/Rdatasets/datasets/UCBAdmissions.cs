// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Student Admissions at UC Berkeley
    /// </summary>

    public class UCBAdmissions
    {
        public readonly int κ;
        public readonly string Admit;
        public readonly string Gender;
        public readonly string Dept;
        public readonly int Freq;

        public UCBAdmissions(int κ, string Admit, string Gender, string Dept, int Freq)
        {
            this.κ = κ;
            this.Admit = Admit;
            this.Gender = Gender;
            this.Dept = Dept;
            this.Freq = Freq;
        }

        public static IEnumerable<UCBAdmissions> Data
        {
            get
            {
                yield return new UCBAdmissions(1, "Admitted", "Male", "A", 512);
                yield return new UCBAdmissions(2, "Rejected", "Male", "A", 313);
                yield return new UCBAdmissions(3, "Admitted", "Female", "A", 89);
                yield return new UCBAdmissions(4, "Rejected", "Female", "A", 19);
                yield return new UCBAdmissions(5, "Admitted", "Male", "B", 353);
                yield return new UCBAdmissions(6, "Rejected", "Male", "B", 207);
                yield return new UCBAdmissions(7, "Admitted", "Female", "B", 17);
                yield return new UCBAdmissions(8, "Rejected", "Female", "B", 8);
                yield return new UCBAdmissions(9, "Admitted", "Male", "C", 120);
                yield return new UCBAdmissions(10, "Rejected", "Male", "C", 205);
                yield return new UCBAdmissions(11, "Admitted", "Female", "C", 202);
                yield return new UCBAdmissions(12, "Rejected", "Female", "C", 391);
                yield return new UCBAdmissions(13, "Admitted", "Male", "D", 138);
                yield return new UCBAdmissions(14, "Rejected", "Male", "D", 279);
                yield return new UCBAdmissions(15, "Admitted", "Female", "D", 131);
                yield return new UCBAdmissions(16, "Rejected", "Female", "D", 244);
                yield return new UCBAdmissions(17, "Admitted", "Male", "E", 53);
                yield return new UCBAdmissions(18, "Rejected", "Male", "E", 138);
                yield return new UCBAdmissions(19, "Admitted", "Female", "E", 94);
                yield return new UCBAdmissions(20, "Rejected", "Female", "E", 299);
                yield return new UCBAdmissions(21, "Admitted", "Male", "F", 22);
                yield return new UCBAdmissions(22, "Rejected", "Male", "F", 351);
                yield return new UCBAdmissions(23, "Admitted", "Female", "F", 24);
                yield return new UCBAdmissions(24, "Rejected", "Female", "F", 317);
            }
        }
    }
}
