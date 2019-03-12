// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Duncan's Occupational Prestige Data
    /// </summary>

    public class Duncan
    {
        public readonly string κ;
        public readonly string type;
        public readonly int income;
        public readonly int education;
        public readonly int prestige;

        public Duncan(string κ, string type, int income, int education, int prestige)
        {
            this.κ = κ;
            this.type = type;
            this.income = income;
            this.education = education;
            this.prestige = prestige;
        }

        public static IEnumerable<Duncan> Data
        {
            get
            {
                yield return new Duncan("accountant", "prof", 62, 86, 82);
                yield return new Duncan("pilot", "prof", 72, 76, 83);
                yield return new Duncan("architect", "prof", 75, 92, 90);
                yield return new Duncan("author", "prof", 55, 90, 76);
                yield return new Duncan("chemist", "prof", 64, 86, 90);
                yield return new Duncan("minister", "prof", 21, 84, 87);
                yield return new Duncan("professor", "prof", 64, 93, 93);
                yield return new Duncan("dentist", "prof", 80, 100, 90);
                yield return new Duncan("reporter", "wc", 67, 87, 52);
                yield return new Duncan("engineer", "prof", 72, 86, 88);
                yield return new Duncan("undertaker", "prof", 42, 74, 57);
                yield return new Duncan("lawyer", "prof", 76, 98, 89);
                yield return new Duncan("physician", "prof", 76, 97, 97);
                yield return new Duncan("welfare.worker", "prof", 41, 84, 59);
                yield return new Duncan("teacher", "prof", 48, 91, 73);
                yield return new Duncan("conductor", "wc", 76, 34, 38);
                yield return new Duncan("contractor", "prof", 53, 45, 76);
                yield return new Duncan("factory.owner", "prof", 60, 56, 81);
                yield return new Duncan("store.manager", "prof", 42, 44, 45);
                yield return new Duncan("banker", "prof", 78, 82, 92);
                yield return new Duncan("bookkeeper", "wc", 29, 72, 39);
                yield return new Duncan("mail.carrier", "wc", 48, 55, 34);
                yield return new Duncan("insurance.agent", "wc", 55, 71, 41);
                yield return new Duncan("store.clerk", "wc", 29, 50, 16);
                yield return new Duncan("carpenter", "bc", 21, 23, 33);
                yield return new Duncan("electrician", "bc", 47, 39, 53);
                yield return new Duncan("RR.engineer", "bc", 81, 28, 67);
                yield return new Duncan("machinist", "bc", 36, 32, 57);
                yield return new Duncan("auto.repairman", "bc", 22, 22, 26);
                yield return new Duncan("plumber", "bc", 44, 25, 29);
                yield return new Duncan("gas.stn.attendant", "bc", 15, 29, 10);
                yield return new Duncan("coal.miner", "bc", 7, 7, 15);
                yield return new Duncan("streetcar.motorman", "bc", 42, 26, 19);
                yield return new Duncan("taxi.driver", "bc", 9, 19, 10);
                yield return new Duncan("truck.driver", "bc", 21, 15, 13);
                yield return new Duncan("machine.operator", "bc", 21, 20, 24);
                yield return new Duncan("barber", "bc", 16, 26, 20);
                yield return new Duncan("bartender", "bc", 16, 28, 7);
                yield return new Duncan("shoe.shiner", "bc", 9, 17, 3);
                yield return new Duncan("cook", "bc", 14, 22, 16);
                yield return new Duncan("soda.clerk", "bc", 12, 30, 6);
                yield return new Duncan("watchman", "bc", 17, 25, 11);
                yield return new Duncan("janitor", "bc", 7, 20, 8);
                yield return new Duncan("policeman", "bc", 34, 47, 41);
                yield return new Duncan("waiter", "bc", 8, 32, 10);
            }
        }
    }
}
