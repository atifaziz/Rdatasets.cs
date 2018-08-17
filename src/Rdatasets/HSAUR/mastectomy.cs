// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival Times after Mastectomy of Breast Cancer Patients
    /// </summary>

    public class mastectomy
    {
        public readonly int time;
        public readonly bool @event;
        public readonly string metastized;

        public mastectomy(int time, bool @event, string metastized)
        {
            this.time = time;
            this.@event = @event;
            this.metastized = metastized;
        }

        public static IEnumerable<mastectomy> Data
        {
            get
            {
                yield return new mastectomy(23, true, "no");
                yield return new mastectomy(47, true, "no");
                yield return new mastectomy(69, true, "no");
                yield return new mastectomy(70, false, "no");
                yield return new mastectomy(100, false, "no");
                yield return new mastectomy(101, false, "no");
                yield return new mastectomy(148, true, "no");
                yield return new mastectomy(181, true, "no");
                yield return new mastectomy(198, false, "no");
                yield return new mastectomy(208, false, "no");
                yield return new mastectomy(212, false, "no");
                yield return new mastectomy(224, false, "no");
                yield return new mastectomy(5, true, "yes");
                yield return new mastectomy(8, true, "yes");
                yield return new mastectomy(10, true, "yes");
                yield return new mastectomy(13, true, "yes");
                yield return new mastectomy(18, true, "yes");
                yield return new mastectomy(24, true, "yes");
                yield return new mastectomy(26, true, "yes");
                yield return new mastectomy(26, true, "yes");
                yield return new mastectomy(31, true, "yes");
                yield return new mastectomy(35, true, "yes");
                yield return new mastectomy(40, true, "yes");
                yield return new mastectomy(41, true, "yes");
                yield return new mastectomy(48, true, "yes");
                yield return new mastectomy(50, true, "yes");
                yield return new mastectomy(59, true, "yes");
                yield return new mastectomy(61, true, "yes");
                yield return new mastectomy(68, true, "yes");
                yield return new mastectomy(71, true, "yes");
                yield return new mastectomy(76, false, "yes");
                yield return new mastectomy(105, false, "yes");
                yield return new mastectomy(107, false, "yes");
                yield return new mastectomy(109, false, "yes");
                yield return new mastectomy(113, true, "yes");
                yield return new mastectomy(116, false, "yes");
                yield return new mastectomy(118, true, "yes");
                yield return new mastectomy(143, true, "yes");
                yield return new mastectomy(145, false, "yes");
                yield return new mastectomy(162, false, "yes");
                yield return new mastectomy(188, false, "yes");
                yield return new mastectomy(212, false, "yes");
                yield return new mastectomy(217, false, "yes");
                yield return new mastectomy(225, false, "yes");
            }
        }
    }
}
