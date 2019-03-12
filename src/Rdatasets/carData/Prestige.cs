// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Prestige of Canadian Occupations
    /// </summary>

    public class Prestige
    {
        public readonly string κ;
        public readonly double education;
        public readonly int income;
        public readonly double women;
        public readonly double prestige;
        public readonly int census;
        public readonly string type;

        public Prestige(string κ, double education, int income, double women, double prestige, int census, string type)
        {
            this.κ = κ;
            this.education = education;
            this.income = income;
            this.women = women;
            this.prestige = prestige;
            this.census = census;
            this.type = type;
        }

        public static IEnumerable<Prestige> Data
        {
            get
            {
                yield return new Prestige("gov.administrators", 13.11, 12351, 11.16, 68.8, 1113, "prof");
                yield return new Prestige("general.managers", 12.26, 25879, 4.02, 69.1, 1130, "prof");
                yield return new Prestige("accountants", 12.77, 9271, 15.7, 63.4, 1171, "prof");
                yield return new Prestige("purchasing.officers", 11.42, 8865, 9.11, 56.8, 1175, "prof");
                yield return new Prestige("chemists", 14.62, 8403, 11.68, 73.5, 2111, "prof");
                yield return new Prestige("physicists", 15.64, 11030, 5.13, 77.6, 2113, "prof");
                yield return new Prestige("biologists", 15.09, 8258, 25.65, 72.6, 2133, "prof");
                yield return new Prestige("architects", 15.44, 14163, 2.69, 78.1, 2141, "prof");
                yield return new Prestige("civil.engineers", 14.52, 11377, 1.03, 73.1, 2143, "prof");
                yield return new Prestige("mining.engineers", 14.64, 11023, 0.94, 68.8, 2153, "prof");
                yield return new Prestige("surveyors", 12.39, 5902, 1.91, 62, 2161, "prof");
                yield return new Prestige("draughtsmen", 12.3, 7059, 7.83, 60, 2163, "prof");
                yield return new Prestige("computer.programers", 13.83, 8425, 15.33, 53.8, 2183, "prof");
                yield return new Prestige("economists", 14.44, 8049, 57.31, 62.2, 2311, "prof");
                yield return new Prestige("psychologists", 14.36, 7405, 48.28, 74.9, 2315, "prof");
                yield return new Prestige("social.workers", 14.21, 6336, 54.77, 55.1, 2331, "prof");
                yield return new Prestige("lawyers", 15.77, 19263, 5.13, 82.3, 2343, "prof");
                yield return new Prestige("librarians", 14.15, 6112, 77.1, 58.1, 2351, "prof");
                yield return new Prestige("vocational.counsellors", 15.22, 9593, 34.89, 58.3, 2391, "prof");
                yield return new Prestige("ministers", 14.5, 4686, 4.14, 72.8, 2511, "prof");
                yield return new Prestige("university.teachers", 15.97, 12480, 19.59, 84.6, 2711, "prof");
                yield return new Prestige("primary.school.teachers", 13.62, 5648, 83.78, 59.6, 2731, "prof");
                yield return new Prestige("secondary.school.teachers", 15.08, 8034, 46.8, 66.1, 2733, "prof");
                yield return new Prestige("physicians", 15.96, 25308, 10.56, 87.2, 3111, "prof");
                yield return new Prestige("veterinarians", 15.94, 14558, 4.32, 66.7, 3115, "prof");
                yield return new Prestige("osteopaths.chiropractors", 14.71, 17498, 6.91, 68.4, 3117, "prof");
                yield return new Prestige("nurses", 12.46, 4614, 96.12, 64.7, 3131, "prof");
                yield return new Prestige("nursing.aides", 9.45, 3485, 76.14, 34.9, 3135, "bc");
                yield return new Prestige("physio.therapsts", 13.62, 5092, 82.66, 72.1, 3137, "prof");
                yield return new Prestige("pharmacists", 15.21, 10432, 24.71, 69.3, 3151, "prof");
                yield return new Prestige("medical.technicians", 12.79, 5180, 76.04, 67.5, 3156, "wc");
                yield return new Prestige("commercial.artists", 11.09, 6197, 21.03, 57.2, 3314, "prof");
                yield return new Prestige("radio.tv.announcers", 12.71, 7562, 11.15, 57.6, 3337, "wc");
                yield return new Prestige("athletes", 11.44, 8206, 8.13, 54.1, 3373, null);
                yield return new Prestige("secretaries", 11.59, 4036, 97.51, 46, 4111, "wc");
                yield return new Prestige("typists", 11.49, 3148, 95.97, 41.9, 4113, "wc");
                yield return new Prestige("bookkeepers", 11.32, 4348, 68.24, 49.4, 4131, "wc");
                yield return new Prestige("tellers.cashiers", 10.64, 2448, 91.76, 42.3, 4133, "wc");
                yield return new Prestige("computer.operators", 11.36, 4330, 75.92, 47.7, 4143, "wc");
                yield return new Prestige("shipping.clerks", 9.17, 4761, 11.37, 30.9, 4153, "wc");
                yield return new Prestige("file.clerks", 12.09, 3016, 83.19, 32.7, 4161, "wc");
                yield return new Prestige("receptionsts", 11.04, 2901, 92.86, 38.7, 4171, "wc");
                yield return new Prestige("mail.carriers", 9.22, 5511, 7.62, 36.1, 4172, "wc");
                yield return new Prestige("postal.clerks", 10.07, 3739, 52.27, 37.2, 4173, "wc");
                yield return new Prestige("telephone.operators", 10.51, 3161, 96.14, 38.1, 4175, "wc");
                yield return new Prestige("collectors", 11.2, 4741, 47.06, 29.4, 4191, "wc");
                yield return new Prestige("claim.adjustors", 11.13, 5052, 56.1, 51.1, 4192, "wc");
                yield return new Prestige("travel.clerks", 11.43, 6259, 39.17, 35.7, 4193, "wc");
                yield return new Prestige("office.clerks", 11, 4075, 63.23, 35.6, 4197, "wc");
                yield return new Prestige("sales.supervisors", 9.84, 7482, 17.04, 41.5, 5130, "wc");
                yield return new Prestige("commercial.travellers", 11.13, 8780, 3.16, 40.2, 5133, "wc");
                yield return new Prestige("sales.clerks", 10.05, 2594, 67.82, 26.5, 5137, "wc");
                yield return new Prestige("newsboys", 9.62, 918, 7, 14.8, 5143, null);
                yield return new Prestige("service.station.attendant", 9.93, 2370, 3.69, 23.3, 5145, "bc");
                yield return new Prestige("insurance.agents", 11.6, 8131, 13.09, 47.3, 5171, "wc");
                yield return new Prestige("real.estate.salesmen", 11.09, 6992, 24.44, 47.1, 5172, "wc");
                yield return new Prestige("buyers", 11.03, 7956, 23.88, 51.1, 5191, "wc");
                yield return new Prestige("firefighters", 9.47, 8895, 0, 43.5, 6111, "bc");
                yield return new Prestige("policemen", 10.93, 8891, 1.65, 51.6, 6112, "bc");
                yield return new Prestige("cooks", 7.74, 3116, 52, 29.7, 6121, "bc");
                yield return new Prestige("bartenders", 8.5, 3930, 15.51, 20.2, 6123, "bc");
                yield return new Prestige("funeral.directors", 10.57, 7869, 6.01, 54.9, 6141, "bc");
                yield return new Prestige("babysitters", 9.46, 611, 96.53, 25.9, 6147, null);
                yield return new Prestige("launderers", 7.33, 3000, 69.31, 20.8, 6162, "bc");
                yield return new Prestige("janitors", 7.11, 3472, 33.57, 17.3, 6191, "bc");
                yield return new Prestige("elevator.operators", 7.58, 3582, 30.08, 20.1, 6193, "bc");
                yield return new Prestige("farmers", 6.84, 3643, 3.6, 44.1, 7112, null);
                yield return new Prestige("farm.workers", 8.6, 1656, 27.75, 21.5, 7182, "bc");
                yield return new Prestige("rotary.well.drillers", 8.88, 6860, 0, 35.3, 7711, "bc");
                yield return new Prestige("bakers", 7.54, 4199, 33.3, 38.9, 8213, "bc");
                yield return new Prestige("slaughterers.1", 7.64, 5134, 17.26, 25.2, 8215, "bc");
                yield return new Prestige("slaughterers.2", 7.64, 5134, 17.26, 34.8, 8215, "bc");
                yield return new Prestige("canners", 7.42, 1890, 72.24, 23.2, 8221, "bc");
                yield return new Prestige("textile.weavers", 6.69, 4443, 31.36, 33.3, 8267, "bc");
                yield return new Prestige("textile.labourers", 6.74, 3485, 39.48, 28.8, 8278, "bc");
                yield return new Prestige("tool.die.makers", 10.09, 8043, 1.5, 42.5, 8311, "bc");
                yield return new Prestige("machinists", 8.81, 6686, 4.28, 44.2, 8313, "bc");
                yield return new Prestige("sheet.metal.workers", 8.4, 6565, 2.3, 35.9, 8333, "bc");
                yield return new Prestige("welders", 7.92, 6477, 5.17, 41.8, 8335, "bc");
                yield return new Prestige("auto.workers", 8.43, 5811, 13.62, 35.9, 8513, "bc");
                yield return new Prestige("aircraft.workers", 8.78, 6573, 5.78, 43.7, 8515, "bc");
                yield return new Prestige("electronic.workers", 8.76, 3942, 74.54, 50.8, 8534, "bc");
                yield return new Prestige("radio.tv.repairmen", 10.29, 5449, 2.92, 37.2, 8537, "bc");
                yield return new Prestige("sewing.mach.operators", 6.38, 2847, 90.67, 28.2, 8563, "bc");
                yield return new Prestige("auto.repairmen", 8.1, 5795, 0.81, 38.1, 8581, "bc");
                yield return new Prestige("aircraft.repairmen", 10.1, 7716, 0.78, 50.3, 8582, "bc");
                yield return new Prestige("railway.sectionmen", 6.67, 4696, 0, 27.3, 8715, "bc");
                yield return new Prestige("electrical.linemen", 9.05, 8316, 1.34, 40.9, 8731, "bc");
                yield return new Prestige("electricians", 9.93, 7147, 0.99, 50.2, 8733, "bc");
                yield return new Prestige("construction.foremen", 8.24, 8880, 0.65, 51.1, 8780, "bc");
                yield return new Prestige("carpenters", 6.92, 5299, 0.56, 38.9, 8781, "bc");
                yield return new Prestige("masons", 6.6, 5959, 0.52, 36.2, 8782, "bc");
                yield return new Prestige("house.painters", 7.81, 4549, 2.46, 29.9, 8785, "bc");
                yield return new Prestige("plumbers", 8.33, 6928, 0.61, 42.9, 8791, "bc");
                yield return new Prestige("construction.labourers", 7.52, 3910, 1.09, 26.5, 8798, "bc");
                yield return new Prestige("pilots", 12.27, 14032, 0.58, 66.1, 9111, "prof");
                yield return new Prestige("train.engineers", 8.49, 8845, 0, 48.9, 9131, "bc");
                yield return new Prestige("bus.drivers", 7.58, 5562, 9.47, 35.9, 9171, "bc");
                yield return new Prestige("taxi.drivers", 7.93, 4224, 3.59, 25.1, 9173, "bc");
                yield return new Prestige("longshoremen", 8.37, 4753, 0, 26.1, 9313, "bc");
                yield return new Prestige("typesetters", 10, 6462, 13.58, 42.2, 9511, "bc");
                yield return new Prestige("bookbinders", 8.55, 3617, 70.87, 35.2, 9517, "bc");
            }
        }
    }
}
