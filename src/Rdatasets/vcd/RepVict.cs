// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Repeat Victimization Data
    /// </summary>

    public class RepVict
    {
        public readonly string First_Victimization;
        public readonly string Second_Victimization;
        public readonly int Freq;

        public RepVict(string First_Victimization, string Second_Victimization, int Freq)
        {
            this.First_Victimization = First_Victimization;
            this.Second_Victimization = Second_Victimization;
            this.Freq = Freq;
        }

        public static IEnumerable<RepVict> Data
        {
            get
            {
                yield return new RepVict("Rape", "Rape", 26);
                yield return new RepVict("Assault", "Rape", 65);
                yield return new RepVict("Robbery", "Rape", 12);
                yield return new RepVict("Pickpocket", "Rape", 3);
                yield return new RepVict("Personal Larcency", "Rape", 75);
                yield return new RepVict("Burglary", "Rape", 52);
                yield return new RepVict("Household Larceny", "Rape", 42);
                yield return new RepVict("Auto Theft", "Rape", 3);
                yield return new RepVict("Rape", "Assault", 50);
                yield return new RepVict("Assault", "Assault", 2997);
                yield return new RepVict("Robbery", "Assault", 279);
                yield return new RepVict("Pickpocket", "Assault", 102);
                yield return new RepVict("Personal Larcency", "Assault", 2628);
                yield return new RepVict("Burglary", "Assault", 1117);
                yield return new RepVict("Household Larceny", "Assault", 1251);
                yield return new RepVict("Auto Theft", "Assault", 221);
                yield return new RepVict("Rape", "Robbery", 11);
                yield return new RepVict("Assault", "Robbery", 238);
                yield return new RepVict("Robbery", "Robbery", 197);
                yield return new RepVict("Pickpocket", "Robbery", 40);
                yield return new RepVict("Personal Larcency", "Robbery", 413);
                yield return new RepVict("Burglary", "Robbery", 191);
                yield return new RepVict("Household Larceny", "Robbery", 206);
                yield return new RepVict("Auto Theft", "Robbery", 51);
                yield return new RepVict("Rape", "Pickpocket", 6);
                yield return new RepVict("Assault", "Pickpocket", 85);
                yield return new RepVict("Robbery", "Pickpocket", 36);
                yield return new RepVict("Pickpocket", "Pickpocket", 61);
                yield return new RepVict("Personal Larcency", "Pickpocket", 329);
                yield return new RepVict("Burglary", "Pickpocket", 102);
                yield return new RepVict("Household Larceny", "Pickpocket", 117);
                yield return new RepVict("Auto Theft", "Pickpocket", 24);
                yield return new RepVict("Rape", "Personal Larcency", 82);
                yield return new RepVict("Assault", "Personal Larcency", 2553);
                yield return new RepVict("Robbery", "Personal Larcency", 459);
                yield return new RepVict("Pickpocket", "Personal Larcency", 243);
                yield return new RepVict("Personal Larcency", "Personal Larcency", 12137);
                yield return new RepVict("Burglary", "Personal Larcency", 2649);
                yield return new RepVict("Household Larceny", "Personal Larcency", 3757);
                yield return new RepVict("Auto Theft", "Personal Larcency", 678);
                yield return new RepVict("Rape", "Burglary", 39);
                yield return new RepVict("Assault", "Burglary", 1083);
                yield return new RepVict("Robbery", "Burglary", 197);
                yield return new RepVict("Pickpocket", "Burglary", 115);
                yield return new RepVict("Personal Larcency", "Burglary", 2685);
                yield return new RepVict("Burglary", "Burglary", 3210);
                yield return new RepVict("Household Larceny", "Burglary", 1962);
                yield return new RepVict("Auto Theft", "Burglary", 301);
                yield return new RepVict("Rape", "Household Larceny", 48);
                yield return new RepVict("Assault", "Household Larceny", 1349);
                yield return new RepVict("Robbery", "Household Larceny", 221);
                yield return new RepVict("Pickpocket", "Household Larceny", 101);
                yield return new RepVict("Personal Larcency", "Household Larceny", 3689);
                yield return new RepVict("Burglary", "Household Larceny", 1973);
                yield return new RepVict("Household Larceny", "Household Larceny", 4646);
                yield return new RepVict("Auto Theft", "Household Larceny", 367);
                yield return new RepVict("Rape", "Auto Theft", 11);
                yield return new RepVict("Assault", "Auto Theft", 216);
                yield return new RepVict("Robbery", "Auto Theft", 47);
                yield return new RepVict("Pickpocket", "Auto Theft", 38);
                yield return new RepVict("Personal Larcency", "Auto Theft", 687);
                yield return new RepVict("Burglary", "Auto Theft", 301);
                yield return new RepVict("Household Larceny", "Auto Theft", 391);
                yield return new RepVict("Auto Theft", "Auto Theft", 269);
            }
        }
    }
}
