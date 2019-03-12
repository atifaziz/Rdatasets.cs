// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival Times after Mastectomy of Breast Cancer Patients
    /// </summary>

    public class mastectomy
    {
        public readonly int κ;
        public readonly int time;
        public readonly bool @event;
        public readonly string metastized;

        public mastectomy(int κ, int time, bool @event, string metastized)
        {
            this.κ = κ;
            this.time = time;
            this.@event = @event;
            this.metastized = metastized;
        }

        public static IEnumerable<mastectomy> Data
        {
            get
            {
                yield return new mastectomy(1, 23, true, "no");
                yield return new mastectomy(2, 47, true, "no");
                yield return new mastectomy(3, 69, true, "no");
                yield return new mastectomy(4, 70, false, "no");
                yield return new mastectomy(5, 100, false, "no");
                yield return new mastectomy(6, 101, false, "no");
                yield return new mastectomy(7, 148, true, "no");
                yield return new mastectomy(8, 181, true, "no");
                yield return new mastectomy(9, 198, false, "no");
                yield return new mastectomy(10, 208, false, "no");
                yield return new mastectomy(11, 212, false, "no");
                yield return new mastectomy(12, 224, false, "no");
                yield return new mastectomy(13, 5, true, "yes");
                yield return new mastectomy(14, 8, true, "yes");
                yield return new mastectomy(15, 10, true, "yes");
                yield return new mastectomy(16, 13, true, "yes");
                yield return new mastectomy(17, 18, true, "yes");
                yield return new mastectomy(18, 24, true, "yes");
                yield return new mastectomy(19, 26, true, "yes");
                yield return new mastectomy(20, 26, true, "yes");
                yield return new mastectomy(21, 31, true, "yes");
                yield return new mastectomy(22, 35, true, "yes");
                yield return new mastectomy(23, 40, true, "yes");
                yield return new mastectomy(24, 41, true, "yes");
                yield return new mastectomy(25, 48, true, "yes");
                yield return new mastectomy(26, 50, true, "yes");
                yield return new mastectomy(27, 59, true, "yes");
                yield return new mastectomy(28, 61, true, "yes");
                yield return new mastectomy(29, 68, true, "yes");
                yield return new mastectomy(30, 71, true, "yes");
                yield return new mastectomy(31, 76, false, "yes");
                yield return new mastectomy(32, 105, false, "yes");
                yield return new mastectomy(33, 107, false, "yes");
                yield return new mastectomy(34, 109, false, "yes");
                yield return new mastectomy(35, 113, true, "yes");
                yield return new mastectomy(36, 116, false, "yes");
                yield return new mastectomy(37, 118, true, "yes");
                yield return new mastectomy(38, 143, true, "yes");
                yield return new mastectomy(39, 145, false, "yes");
                yield return new mastectomy(40, 162, false, "yes");
                yield return new mastectomy(41, 188, false, "yes");
                yield return new mastectomy(42, 212, false, "yes");
                yield return new mastectomy(43, 217, false, "yes");
                yield return new mastectomy(44, 225, false, "yes");
            }
        }
    }
}
