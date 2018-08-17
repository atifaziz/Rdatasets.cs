// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival Times and White Blood Counts for Leukaemia Patients
    /// </summary>

    public class leuk
    {
        public readonly int wbc;
        public readonly string ag;
        public readonly int time;

        public leuk(int wbc, string ag, int time)
        {
            this.wbc = wbc;
            this.ag = ag;
            this.time = time;
        }

        public static IEnumerable<leuk> Data
        {
            get
            {
                yield return new leuk(2300, "present", 65);
                yield return new leuk(750, "present", 156);
                yield return new leuk(4300, "present", 100);
                yield return new leuk(2600, "present", 134);
                yield return new leuk(6000, "present", 16);
                yield return new leuk(10500, "present", 108);
                yield return new leuk(10000, "present", 121);
                yield return new leuk(17000, "present", 4);
                yield return new leuk(5400, "present", 39);
                yield return new leuk(7000, "present", 143);
                yield return new leuk(9400, "present", 56);
                yield return new leuk(32000, "present", 26);
                yield return new leuk(35000, "present", 22);
                yield return new leuk(100000, "present", 1);
                yield return new leuk(100000, "present", 1);
                yield return new leuk(52000, "present", 5);
                yield return new leuk(100000, "present", 65);
                yield return new leuk(4400, "absent", 56);
                yield return new leuk(3000, "absent", 65);
                yield return new leuk(4000, "absent", 17);
                yield return new leuk(1500, "absent", 7);
                yield return new leuk(9000, "absent", 16);
                yield return new leuk(5300, "absent", 22);
                yield return new leuk(10000, "absent", 3);
                yield return new leuk(19000, "absent", 4);
                yield return new leuk(27000, "absent", 2);
                yield return new leuk(28000, "absent", 3);
                yield return new leuk(31000, "absent", 8);
                yield return new leuk(26000, "absent", 4);
                yield return new leuk(21000, "absent", 3);
                yield return new leuk(79000, "absent", 30);
                yield return new leuk(100000, "absent", 4);
                yield return new leuk(100000, "absent", 43);
            }
        }
    }
}
