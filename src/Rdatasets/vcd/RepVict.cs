// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Repeat Victimization Data
    /// </summary>

    public class RepVict
    {
        public readonly int κ;
        public readonly string First_Victimization;
        public readonly string Second_Victimization;
        public readonly int Freq;

        public RepVict(int κ, string First_Victimization, string Second_Victimization, int Freq)
        {
            this.κ = κ;
            this.First_Victimization = First_Victimization;
            this.Second_Victimization = Second_Victimization;
            this.Freq = Freq;
        }

        public static IEnumerable<RepVict> Data
        {
            get
            {
                yield return new RepVict(1, "Rape", "Rape", 26);
                yield return new RepVict(2, "Assault", "Rape", 65);
                yield return new RepVict(3, "Robbery", "Rape", 12);
                yield return new RepVict(4, "Pickpocket", "Rape", 3);
                yield return new RepVict(5, "Personal Larcency", "Rape", 75);
                yield return new RepVict(6, "Burglary", "Rape", 52);
                yield return new RepVict(7, "Household Larceny", "Rape", 42);
                yield return new RepVict(8, "Auto Theft", "Rape", 3);
                yield return new RepVict(9, "Rape", "Assault", 50);
                yield return new RepVict(10, "Assault", "Assault", 2997);
                yield return new RepVict(11, "Robbery", "Assault", 279);
                yield return new RepVict(12, "Pickpocket", "Assault", 102);
                yield return new RepVict(13, "Personal Larcency", "Assault", 2628);
                yield return new RepVict(14, "Burglary", "Assault", 1117);
                yield return new RepVict(15, "Household Larceny", "Assault", 1251);
                yield return new RepVict(16, "Auto Theft", "Assault", 221);
                yield return new RepVict(17, "Rape", "Robbery", 11);
                yield return new RepVict(18, "Assault", "Robbery", 238);
                yield return new RepVict(19, "Robbery", "Robbery", 197);
                yield return new RepVict(20, "Pickpocket", "Robbery", 40);
                yield return new RepVict(21, "Personal Larcency", "Robbery", 413);
                yield return new RepVict(22, "Burglary", "Robbery", 191);
                yield return new RepVict(23, "Household Larceny", "Robbery", 206);
                yield return new RepVict(24, "Auto Theft", "Robbery", 51);
                yield return new RepVict(25, "Rape", "Pickpocket", 6);
                yield return new RepVict(26, "Assault", "Pickpocket", 85);
                yield return new RepVict(27, "Robbery", "Pickpocket", 36);
                yield return new RepVict(28, "Pickpocket", "Pickpocket", 61);
                yield return new RepVict(29, "Personal Larcency", "Pickpocket", 329);
                yield return new RepVict(30, "Burglary", "Pickpocket", 102);
                yield return new RepVict(31, "Household Larceny", "Pickpocket", 117);
                yield return new RepVict(32, "Auto Theft", "Pickpocket", 24);
                yield return new RepVict(33, "Rape", "Personal Larcency", 82);
                yield return new RepVict(34, "Assault", "Personal Larcency", 2553);
                yield return new RepVict(35, "Robbery", "Personal Larcency", 459);
                yield return new RepVict(36, "Pickpocket", "Personal Larcency", 243);
                yield return new RepVict(37, "Personal Larcency", "Personal Larcency", 12137);
                yield return new RepVict(38, "Burglary", "Personal Larcency", 2649);
                yield return new RepVict(39, "Household Larceny", "Personal Larcency", 3757);
                yield return new RepVict(40, "Auto Theft", "Personal Larcency", 678);
                yield return new RepVict(41, "Rape", "Burglary", 39);
                yield return new RepVict(42, "Assault", "Burglary", 1083);
                yield return new RepVict(43, "Robbery", "Burglary", 197);
                yield return new RepVict(44, "Pickpocket", "Burglary", 115);
                yield return new RepVict(45, "Personal Larcency", "Burglary", 2685);
                yield return new RepVict(46, "Burglary", "Burglary", 3210);
                yield return new RepVict(47, "Household Larceny", "Burglary", 1962);
                yield return new RepVict(48, "Auto Theft", "Burglary", 301);
                yield return new RepVict(49, "Rape", "Household Larceny", 48);
                yield return new RepVict(50, "Assault", "Household Larceny", 1349);
                yield return new RepVict(51, "Robbery", "Household Larceny", 221);
                yield return new RepVict(52, "Pickpocket", "Household Larceny", 101);
                yield return new RepVict(53, "Personal Larcency", "Household Larceny", 3689);
                yield return new RepVict(54, "Burglary", "Household Larceny", 1973);
                yield return new RepVict(55, "Household Larceny", "Household Larceny", 4646);
                yield return new RepVict(56, "Auto Theft", "Household Larceny", 367);
                yield return new RepVict(57, "Rape", "Auto Theft", 11);
                yield return new RepVict(58, "Assault", "Auto Theft", 216);
                yield return new RepVict(59, "Robbery", "Auto Theft", 47);
                yield return new RepVict(60, "Pickpocket", "Auto Theft", 38);
                yield return new RepVict(61, "Personal Larcency", "Auto Theft", 687);
                yield return new RepVict(62, "Burglary", "Auto Theft", 301);
                yield return new RepVict(63, "Household Larceny", "Auto Theft", 391);
                yield return new RepVict(64, "Auto Theft", "Auto Theft", 269);
            }
        }
    }
}
