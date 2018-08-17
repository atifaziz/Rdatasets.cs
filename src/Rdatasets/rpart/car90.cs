// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Automobile Data from 'Consumer Reports' 1990
    /// </summary>

    public class car90
    {
        public readonly string Country;
        public readonly string Disp;
        public readonly string Disp2;
        public readonly string Eng_Rev;
        public readonly double Front_Hd;
        public readonly double Frt_Leg_Room;
        public readonly double Frt_Shld;
        public readonly string Gear_Ratio;
        public readonly string Gear2;
        public readonly string HP;
        public readonly string HP_revs;
        public readonly double Height;
        public readonly int Length;
        public readonly int Luggage;
        public readonly string Mileage;
        public readonly string Model2;
        public readonly string Price;
        public readonly double Rear_Hd;
        public readonly double Rear_Seating;
        public readonly double RearShld;
        public readonly string Reliability;
        public readonly string Rim;
        public readonly string Sratio_m;
        public readonly string Sratio_p;
        public readonly string Steering;
        public readonly string Tank;
        public readonly string Tires;
        public readonly string Trans1;
        public readonly string Trans2;
        public readonly string Turning;
        public readonly string Type;
        public readonly string Weight;
        public readonly int Wheel_base;
        public readonly int Width;

        public car90(string Country, string Disp, string Disp2, string Eng_Rev, double Front_Hd, double Frt_Leg_Room, double Frt_Shld, string Gear_Ratio, string Gear2, string HP, string HP_revs, double Height, int Length, int Luggage, string Mileage, string Model2, string Price, double Rear_Hd, double Rear_Seating, double RearShld, string Reliability, string Rim, string Sratio_m, string Sratio_p, string Steering, string Tank, string Tires, string Trans1, string Trans2, string Turning, string Type, string Weight, int Wheel_base, int Width)
        {
            this.Country = Country;
            this.Disp = Disp;
            this.Disp2 = Disp2;
            this.Eng_Rev = Eng_Rev;
            this.Front_Hd = Front_Hd;
            this.Frt_Leg_Room = Frt_Leg_Room;
            this.Frt_Shld = Frt_Shld;
            this.Gear_Ratio = Gear_Ratio;
            this.Gear2 = Gear2;
            this.HP = HP;
            this.HP_revs = HP_revs;
            this.Height = Height;
            this.Length = Length;
            this.Luggage = Luggage;
            this.Mileage = Mileage;
            this.Model2 = Model2;
            this.Price = Price;
            this.Rear_Hd = Rear_Hd;
            this.Rear_Seating = Rear_Seating;
            this.RearShld = RearShld;
            this.Reliability = Reliability;
            this.Rim = Rim;
            this.Sratio_m = Sratio_m;
            this.Sratio_p = Sratio_p;
            this.Steering = Steering;
            this.Tank = Tank;
            this.Tires = Tires;
            this.Trans1 = Trans1;
            this.Trans2 = Trans2;
            this.Turning = Turning;
            this.Type = Type;
            this.Weight = Weight;
            this.Wheel_base = Wheel_base;
            this.Width = Width;
        }

        public static IEnumerable<car90> Data
        {
            get
            {
                yield return new car90("Japan", "112", "1.8", "2935", 3.5, 41.5, 53, "3.26", "3.21", "130", "6000", 47.5, 177, 16, null, "", "11950", 1.5, 26.5, 52, "Much better", "R14", null, "0.86", "power", "13.2", "195/60", "man.5", "auto.4", "37", "Small", "2700", 102, 67);
                yield return new car90("Japan", "163", "2.7", "2505", 2, 41.5, 55.5, "2.95", "3.02", "160", "5900", 50, 191, 14, "20", "", "24760", 2, 28.5, 55.5, "Much better", "R15", null, "0.96", "power", "18", "205/60", "man.5", "auto.4", "42", "Medium", "3265", 109, 69);
                yield return new car90("Germany", "141", "2.3", "2775", 2.5, 41.5, 56.5, "3.27", "3.25", "130", "5500", 51.5, 193, 17, null, "", "26900", 3, 31, 55, null, "R15", null, "0.97", "power", "21.1", "205/60", "man.5", "auto.3", "39", "Medium", "2935", 106, 71);
                yield return new car90("Germany", "121", "2", "2835", 4, 42, 52.5, "3.25", "3.25", "108", "5300", 50.5, 176, 10, "27", "", "18900", 1, 28, 52, null, "R14", null, "0.71", "power", "15.9", "175/70", "man.5", "auto.3", "35", "Compact", "2670", 100, 67);
                yield return new car90("Germany", "152", "2.5", "2625", 2, 42, 52, "3.02", "2.99", "168", "5800", 49.5, 175, 12, null, "", "24650", 1, 25.5, 51.5, "better", "R14", null, "0.88", "power", "16.4", "195/65", "man.5", "auto.4", "35", "Compact", "2895", 101, 65);
                yield return new car90("Germany", "209", "3.5", "2285", 3, 42, 54.5, "2.8", "2.85", "208", "5700", 51, 186, 12, null, "", "33200", 2.5, 27, 55.5, null, "R15", null, "0.78", "power", "21.1", "225/60", "man.5", "auto.4", "39", "Medium", "3640", 109, 69);
                yield return new car90("USA", "151", "2.5", null, 4, 42, 56.5, null, "2.84", "110", "5200", 49.5, 189, 16, "21", "", "13150", 2.5, 28, 56, "average", "R14", null, "0.76", "power", "15.7", "185/75", "", "auto.3", "41", "Medium", "2880", 105, 69);
                yield return new car90("USA", "231", "3.8", null, 6, 42, 58.5, null, "1.99", "165", "4800", 50.5, 197, 16, null, "Oldsmobile 98 Regency V6", "20225", 4.5, 30.5, 58.5, "average", "R14", null, "0.83", "power", "18", "205/75", "", "auto.4", "43", "Large", "3350", 111, 72);
                yield return new car90("USA", "231", "3.8", null, 5, 41, 59, null, "1.99", "165", "4800", 51, 197, 16, "23", "Oldsmobile 88 Royale V6", "16145", 3.5, 28.5, 58.5, "average", "R14", null, "0.87", "power", "18", "205/75", "", "auto.4", "42", "Large", "3325", 111, 72);
                yield return new car90(null, "189", "3.1", null, 5.5, 41, 58, null, "2.33", "101", "4400", 50.5, 192, 15, null, "", null, 3.5, 27.5, 56.5, null, "R14", null, "0.88", "power", "16.5", "205/70", "", "auto.4", "41", null, "3320", 108, 71);
                yield return new car90("USA", "231", "3.8", null, 3.5, 41.5, 58, null, "1.99", "165", "4800", 48.5, 198, 14, null, "", "23040", 2, 26.5, 56.5, "average", "R15", null, "0.76", "power", "18.8", "205/70", "", "auto.4", "41", "Medium", "3465", 108, 73);
                yield return new car90("USA", "307", "5", null, 5, 43, 60.5, null, "1.96", "140", "3200", 52.5, 221, 19, null, "", "27400", 3.5, 32, 60, "Much worse", "R15", null, "0.93", "power", "25", "225/75", "", "auto.4", "44", "Large", "4285", 122, 77);
                yield return new car90("USA", "273", "4.5", null, 6, 42, 59.5, null, "2.08", "180", "4300", 51, 206, 16, null, "Cadillac Fleetwood V8", "26960", 4, 30, 58.5, "average", "R15", null, "0.83", "power", "18", "205/70", "", "auto.4", "43", "Large", "3545", 114, 73);
                yield return new car90("USA", "273", "4.5", null, 3, 42, 58, null, "2.08", "180", "4300", 49, 191, 14, null, "Cadillac Seville V8", "28855", 2, 28, 57, "average", "R15", null, "0.77", "power", "18.8", "205/70", "", "auto.4", "42", "Medium", "3480", 108, 72);
                yield return new car90(null, null, null, null, 3, 42, 57.5, null, null, null, null, 49, 191, 14, null, "", null, 2, 29, 56.5, null, null, null, null, null, null, null, null, null, null, null, null, 108, 72);
                yield return new car90("USA", "262", "4.3", "1630", 5, 42, 61.5, "2.07", "2.26", "150", "4000", 68.5, 177, -2, null, "GMC Safari V6", "13790", 4.5, 28, 50.5, "Much worse", "R15", null, "0.75", "power", "27", "205/75", "man.5", "auto.4", "42", "Van", "4025", 111, 77);
                yield return new car90("USA", "133", "2.2", "2375", 3.5, 42, 55.5, "2.83", "3.18", "95", "5200", 49, 187, 14, "26", "Chevrolet Corsica 4", "10320", 0.5, 27.5, 55, "Much worse", "R14", null, "0.72", "power", "15.6", "195/70", "man.5", "auto.3", "38", "Compact", "2655", 103, 68);
                yield return new car90("USA", "191", "3.1", "2085", 3.5, 41.5, 58, "2.6", "2.26", "140", "4400", 46.5, 192, 12, null, "Pontiac Firebird V6", "10995", 0.5, 24, 55.5, "Much worse", "R15", null, "0.67", "power", "15.5", "215/65", "man.5", "auto.4", "41", "Sporty", "3110", 101, 73);
                yield return new car90("USA", "305", "5", null, 5, 41, 61, null, "1.83", "170", "4400", 52.5, 212, 20, "18", "", "14525", 2.5, 28, 61, "Much worse", "R15", null, "0.8", "power", "25", "205/75", "", "auto.4", "42", "Large", "3855", 116, 75);
                yield return new car90("USA", "133", "2.2", "2160", 4, 41, 53.5, "2.55", "2.84", "95", "5200", 50, 179, 14, null, "", "8620", 3, 26.5, 53.5, "Much worse", "R13", "0.95", "0.7", "both", "13.6", "185/80", "man.5", "auto.3", "38", "Compact", "2485", 101, 66);
                yield return new car90(null, null, null, null, 4, 41.5, 54.5, null, null, null, null, 51, 183, 14, null, "", null, 3, 26.5, 55, null, null, null, null, null, null, null, null, null, null, null, null, 103, 68);
                yield return new car90("USA", "350", "5.7", "1335", 2, 42, 54, "1.67", "1.81", "250", "4400", 43.5, 177, -2, null, "", "31979", -2, -2, -2, "Much worse", "R17", null, "0.66", "power", "20", "275/40", "man.6", "auto.4", "42", "Sporty", "3280", 96, 71);
                yield return new car90("USA", "151", "2.5", null, 4.5, 42, 58.5, null, "3.18", "110", "5200", 51, 198, 15, null, "", "12140", 3.5, 30, 56.5, null, "R14", null, "0.88", "power", "17.1", "195/75", "", "auto.3", "42", "Medium", "3195", 108, 71);
                yield return new car90("USA", "191", "3.1", null, 4.5, 41, 60.5, null, "3.18", "120", "4200", 60, 194, -2, "18", "Silhouette V6/ Pontiac Trans Sport V6", "13995", 4, 32.5, 62, null, "R14", null, "0.76", "power", "20", "205/70", "", "auto.3", "42", "Van", "3630", 110, 74);
                yield return new car90("USA", "202", "3.3", null, 4, 42, 56, null, "2.36", "150", "5000", 51, 203, 17, null, "", "25495", 1.5, 31.5, 55.5, "average", "R14", null, "0.84", "power", "16", "195/75", "", "auto.4", "43", "Medium", "3570", 109, 69);
                yield return new car90("USA", "153", "2.5", null, 4, 41, 54, null, "3.02", "150", "4800", 51, 183, 14, "25", "      Turbo 4 (3)", "10945", 2.5, 30.5, 53.5, "better", "R14", null, "0.68", "power", "14", "195/70", "", "auto.3", "39", "Compact", "2975", 103, 68);
                yield return new car90("USA", "153", "2.5", null, 3.5, 41.5, 56, null, "3.02", "150", "4800", 49, 185, 14, "22", "      Turbo 4 (3)", "12495", 0.5, 26, 55, "worse", "R14", null, "0.68", "power", "14", "195/70", "", "auto.3", "39", "Medium", "2975", 100, 69);
                yield return new car90("USA", "153", "2.5", "2250", 4.5, 41.5, 58.5, "2.76", "3.22", "100", "4800", 60.5, 176, -2, null, "Plymouth Voyager 4", "11995", 4.5, 27, 41.5, "average", "R14", null, "0.82", "power", "20", "195/75", "man.5", "auto.3", "42", "Van", "3385", 112, 72);
                yield return new car90("Japan", "90", "1.5", "2825", 3, 40.5, 54, "3.12", "3.6", "81", "5500", 50, 159, 12, null, "Mitsubishi Mirage 4", "6851", 2, 24.5, 52.5, null, "R13", "0.9", "0.66", "both", "13.2", "155/80", "man.5", "auto.3", "32", "Small", "2270", 94, 66);
                yield return new car90("USA", "135", "2.2", "2130", 3, 41, 56, "2.51", "3.02", "150", "4800", 47, 179, 17, "27", "", "9745", 0, 22.5, 54, "Much worse", "R15", null, "0.6", "power", "14", "205/60", "man.5", "auto.3", "38", "Sporty", "2935", 97, 69);
                yield return new car90("USA", "153", "2.5", null, 4, 41, 56, null, "3.02", "100", "4800", 51, 192, 16, null, "", "12995", 1.5, 31, 55.5, "average", "R14", null, "0.8", "power", "16", "195/75", "", "auto.3", "42", "Medium", "3080", 104, 69);
                yield return new car90("USA", "202", "3.3", null, 4, 40.5, 58, null, "2.36", "150", "4800", 61, 191, -2, "18", "Voyager V6/Chrysler Town & Country V6", "15395", 4, 31, 60.5, "average", "R14", null, "0.91", "power", "20", "205/70", "", "auto.4", "47", "Van", "3735", 119, 72);
                yield return new car90("USA", "135", "2.2", "2280", 3, 41, 51.5, "2.55", "2.78", "93", "4800", 51, 163, 15, null, "Plymouth Horizon 4", "6995", 0.5, 26, 51, "Much worse", "R13", "1.06", "0.77", "both", "13", "165/80", "man.5", "auto.3", "40", "Small", "2300", 99, 67);
                yield return new car90("USA", "153", "2.5", "2160", 4, 41.5, 54.5, "2.51", "3.02", "150", "4800", 51, 172, 13, null, "Plymouth Sundance Turbo 4", "8845", 2.5, 25, 53.5, "average", "R14", null, "0.58", "power", "14", "185/70", "man.5", "auto.3", "38", "Compact", "2670", 97, 67);
                yield return new car90(null, "181", "3", null, 3.5, 41, 54, null, "2.36", "141", "5000", 51, 181, 14, null, "Plymouth Acclaim V6", null, 3, 30.5, 54.5, null, "R14", null, "0.6", "power", "16", "195/70", "", "auto.4", "41", null, "2940", 103, 67);
                yield return new car90("USA", "180", "3", null, 3.5, 42, 57.5, null, "2.66", "150", "5000", 51, 193, 17, "22", "Dodge Monaco V6", "15350", 2, 30, 56.5, "worse", "R14", null, "0.77", "power", "17", "205/60", "", "auto.4", "39", "Medium", "3145", 106, 70);
                yield return new car90("USA", "97", "1.6", "3125", 4.5, 41, 53.5, "3.47", "2.78", "113", "6500", 49.5, 170, 10, "33", "", "8895", 2, 27.5, 52.5, "better", "R14", "0.9", "0.67", "both", "13.2", "195/60", "man.5", "auto.4", "36", "Small", "2560", 97, 66);
                yield return new car90("USA", "182", "3", "2075", 5, 42, 60, "2.58", "2.45", "145", "4800", 66.5, 175, -2, "18", "", "12267", 3.5, 30, 62.5, "average", "R14", null, "0.97", "power", "21", "215/70", "man.5", "auto.4", "42", "Van", "3665", 119, 72);
                yield return new car90("USA", "114", "1.9", "2320", 3.5, 41, 51.5, "2.66", "3.26", "90", "4600", 51.5, 169, 18, "33", "", "7402", 1, 26.5, 51.5, "worse", "R14", "0.85", "0.74", "both", "13", "175/70", "man.5", "auto.3", "37", "Small", "2345", 94, 66);
                yield return new car90("Korea", "81", "1.3", "2545", 4, 40.5, 52, "2.61", "3.23", "63", "5000", 52, 141, 12, "37", "", "6319", 3, 26, 51, "better", "R12", "0.78", "0.62", "both", "10", "145", "man.5", "auto.3", "33", "Small", "1845", 90, 63);
                yield return new car90("USA", "302", "5", null, 3.5, 41.5, 61.5, null, "1.83", "150", "3200", 52, 211, 22, "20", "Mercury Grand Marquis V8", "17257", 2, 29, 61.5, "average", "R15", null, "0.83", "power", "18", "215/70", "", "auto.4", "45", "Large", "3850", 114, 78);
                yield return new car90("USA", "140", "2.3", "2225", 3.5, 41, 55.5, "2.73", "2.8", "88", "4000", 49, 180, 12, null, "", "9456", 0.5, 24, 54.5, "Much worse", "R14", null, "0.78", "power", "15.4", "195/75", "man.5", "auto.4", "40", "Sporty", "2850", 101, 68);
                yield return new car90("USA", "133", "2.2", "2530", 3, 41.5, 54.5, "2.94", "2.59", "110", "4700", 47, 177, 12, "30", "", "11470", 0, 23.5, 52, "average", "R14", null, "0.74", "power", "15.1", "185/70", "man.5", "auto.4", "38", "Sporty", "2695", 99, 68);
                yield return new car90("USA", "153", "2.5", null, 4, 42, 57.5, null, "3.26", "90", "4400", 50.5, 188, 17, null, "", "12640", 2, 29, 57.5, "Much worse", "R14", null, "0.71", "power", "16", "205/70", "", "auto.3", "42", "Medium", "3015", 106, 71);
                yield return new car90("USA", "141", "2.3", "2195", 3.5, 41, 53, "2.55", "3.26", "98", "4400", 49.5, 177, 13, "24", "Mercury Topaz 4", "9483", 1.5, 27.5, 54, "worse", "R14", null, "0.78", "power", "15.4", "185/70", "man.5", "auto.3", "39", "Compact", "2750", 100, 68);
                yield return new car90("USA", "232", "3.8", null, 3.5, 41.5, 59, null, "2.19", "140", "3800", 49, 199, 15, "23", "Mercury Cougar V6", "14980", 0.5, 28, 59.5, "Much worse", "R15", null, "0.64", "power", "19", "205/70", "", "auto.4", "38", "Medium", "3610", 113, 73);
                yield return new car90("Japan", "61", "1", "3025", 2.5, 41, 50.5, "3.12", "3.87", "55", "5700", 48.5, 150, 10, null, "", "6695", 1.5, 27.5, 50, null, "R12", "0.72", null, "manual", "10.6", "145/80", "man.5", "auto.3", "34", "Small", "1695", 93, 63);
                yield return new car90("Japan/USA", "97", "1.6", "2780", 3.5, 40.5, 53, "3.05", "3.53", "102", "5800", 49.5, 171, 11, null, "", "10125", 1, 25.5, 52.5, "Much better", "R13", "1", "0.79", "both", "13.2", "175/70", "man.5", "auto.3", "35", "Small", "2255", 96, 65);
                yield return new car90("Japan", "97", "1.6", "2930", 3, 41.5, 51, "3.18", "2.45", "95", "5800", 46.5, 163, 11, null, "", "10390", 0, 24.5, 47.5, null, "R14", null, "0.57", "power", "12.4", "185/60", "man.5", "auto.3", "37", "Sporty", "2455", 97, 67);
                yield return new car90("Japan/USA", "132", "2.2", "2390", 4.5, 42, 54.5, "2.78", "2.89", "125", "5200", 49.5, 185, 14, "26", "", "12145", 2, 27, 54, "Much better", "R14", null, "0.83", "power", "17", "185/70", "man.5", "auto.4", "41", "Compact", "2920", 107, 68);
                yield return new car90("Japan/USA", "91", "1.5", "2855", 3.5, 41, 53.5, "3.13", "3.28", "92", "6000", 48, 169, 12, "32", "", "6635", 2.5, 27.5, 53, "Much better", "R13", "0.87", "0.75", "both", "11.9", "175/70", "man.5", "auto.4", "34", "Small", "2260", 98, 67);
                yield return new car90("Japan", "97", "1.6", "3010", 1.5, 42.5, 53, "3.27", null, "108", "6000", 45, 149, -2, "33", "", "9410", -2, -2, -2, "Much better", "R14", "0.81", null, "manual", "11.9", "185/60", "man.5", "", "32", "Sporty", "2170", 91, 66);
                yield return new car90("Japan", "125", "2", "3115", 1.5, 42.5, 52.5, "3.46", "3.23", "140", "6200", 47, 178, 11, "27", "", "13945", 0, 23.5, 50.5, "Much better", "R14", null, "0.63", "power", "15.9", "195/60", "man.5", "auto.4", "34", "Sporty", "2710", 101, 67);
                yield return new car90("Korea", "90", "1.5", "2825", 2.5, 41, 52, "3.12", "2.78", "81", "5500", 50, 168, 11, null, "", "5899", 1.5, 26, 51.5, "worse", "R13", "0.93", "0.67", "both", "11.9", "155/80", "man.5", "auto.4", "35", "Small", "2345", 94, 63);
                yield return new car90("Korea", "143", "2.4", "2305", 3.5, 41, 57, "2.68", "2.74", "110", "4500", 50.5, 184, 14, "23", "", "9999", 2.5, 31, 56.5, null, "R14", null, "0.8", "power", "15.9", "185/70", "man.5", "auto.4", "41", "Medium", "2885", 104, 69);
                yield return new car90("Japan", "274", "4.5", null, 2.5, 41.5, 57.5, null, "2.46", "278", "6000", 50.5, 200, 15, null, "", "38000", 1.5, 29.5, 57, null, "R15", null, "0.69", "power", "22.5", "215/65", "", "auto.4", "42", "Medium", "4000", 113, 72);
                yield return new car90("Japan", "242", "4", null, 3, 43, 57, null, "2.55", "250", "5600", 50.5, 197, 14, null, "", "35000", 2, 29, 56, null, "R15", null, "0.87", "power", "22.5", "205/65", "", "auto.4", "40", "Medium", "3930", 111, 72);
                yield return new car90("USA", "232", "3.8", null, 4, 41, 57.5, null, "2.33", "140", "3800", 50.5, 205, 19, null, "", "29422", 3, 29.5, 57.5, "worse", "R15", null, "0.68", "power", "18.6", "205/70", "", "auto.4", "42", "Medium", "3695", 109, 73);
                yield return new car90("USA", "302", "5", null, 3, 42, 56, null, "2.06", "225", "4200", 49, 203, 14, null, "", "29246", 0.5, 28.5, 57.5, "Much worse", "R15", null, "0.88", "power", "22.1", "215/70", "", "auto.4", "43", "Medium", "3780", 109, 71);
                yield return new car90("USA", "302", "5", null, 4.5, 41, 62, null, "2.06", "150", "3200", 53, 220, 22, null, "", "27986", 3, 31.5, 62, "average", "R15", null, "0.85", "power", "18", "215/70", "", "auto.4", "45", "Large", "4040", 117, 78);
                yield return new car90(null, null, null, null, 4, 41.5, 52, null, null, null, null, 49.5, 164, 13, null, "", null, 2.5, 27, 52, null, null, null, null, null, null, null, null, null, null, null, null, 97, 66);
                yield return new car90("Japan/USA", "133", "2.2", "2530", 3.5, 40.5, 55, "2.94", "2.59", "110", "4700", 49.5, 179, 15, "24", "", "12459", 2, 27, 55, "better", "R14", null, "0.72", "power", "15.9", "185/70", "man.5", "auto.4", "39", "Compact", "2780", 101, 67);
                yield return new car90("Japan", "180", "3", null, 3, 41.5, 55.5, null, "2.81", "158", "5500", 51, 194, 15, "21", "", "23300", 2.5, 29, 55.5, "Much better", "R15", null, "0.86", "power", "18.5", "195/65", "", "auto.4", "39", "Medium", "3480", 107, 68);
                yield return new car90("Japan", "181", "3", "2510", 5, 41, 57.5, "3.04", "2.71", "150", "5000", 61.5, 176, -2, "19", "", "14944", 5.5, 27.5, 43, "Much better", "R14", null, "1.06", "power", "19.6", "205/70", "man.5", "auto.4", "39", "Van", "3735", 110, 72);
                yield return new car90("Japan", "97", "1.6", "3225", 3.5, 40.5, 50.5, "3.5", null, "116", "6500", 43.5, 155, -2, null, "", "13800", -2, -2, -2, null, "R14", "0.68", "0.57", "both", "11.9", "185/60", "man.5", "", "33", "Sporty", "2210", 89, 66);
                yield return new car90("Japan/USA", "133", "2.2", "2530", 2, 41.5, 55, "2.94", "2.59", "110", "4700", 48.5, 177, 15, null, "", "12279", 2, 26, 52.5, "Much better", "R14", null, "0.71", "power", "15.9", "185/70", "man.5", "auto.4", "36", "Sporty", "2690", 99, 67);
                yield return new car90("Japan", "113", "1.8", "2735", 4, 40.5, 54, "3", "2.43", "103", "5500", 49, 172, 13, "32", "", "6599", 2.5, 26.5, 54, "Much better", "R13", "0.8", "0.71", "both", "14.5", "175/70", "man.5", "auto.4", "36", "Small", "2440", 98, 66);
                yield return new car90("Japan", "80", "1.3", "2430", 1.5, 42, 53, "2.86", "2.81", "160", "7000", 45.5, 170, -2, null, "", "17880", -2, -2, -2, "Much better", "R15", "0.84", "0.61", "both", "18.5", "205/60", "man.5", "auto.4", "37", "Sporty", "2790", 96, 67);
                yield return new car90("Germany", "159", "2.6", "2780", 2, 44, 53.5, "3.27", "3.27", "158", "5800", 50.5, 175, 12, null, "", "31600", 0.5, 26, 53, "average", "R15", null, "0.76", "power", "14.5", "185/65", "man.5", "auto.4", "34", "Compact", "3020", 105, 67);
                yield return new car90("Germany", "181", "3", null, 3, 42.5, 56, null, "2.87", "177", "5700", 52, 187, 15, null, "", "39950", 1.5, 27, 56, "Much worse", "R15", null, "0.72", "power", "18.5", "195/65", "", "auto.4", "37", "Medium", "3315", 110, 69);
                yield return new car90("Mexico", "97", "1.6", "2565", 3.5, 40.5, 52, "2.81", "3.63", "82", "5000", 49, 162, 15, "26", "", "8672", 2, 27, 52, "better", "R13", "0.81", "0.7", "both", "11.9", "175/70", "man.5", "auto.3", "36", "Small", "2285", 95, 65);
                yield return new car90("Japan", "122", "2", "2615", 4, 41, 55, "3.04", "2.74", "102", "5000", 50.5, 184, 11, "25", "", "10989", 2.5, 29.5, 55, "Much better", "R14", null, "0.8", "power", "15.9", "185/70", "man.5", "auto.4", "39", "Compact", "2745", 102, 67);
                yield return new car90("Korea", "90", "1.5", "2825", 4, 40, 52, "3.12", "2.78", "81", "5500", 50, 161, 11, null, "", "5899", 3, 26.5, 52.5, "worse", "R13", "0.93", "0.63", "both", "11.9", "155/80", "man.5", "auto.4", "37", "Small", "2185", 94, 63);
                yield return new car90("Japan", "181", "3", null, 1.5, 40, 53.5, null, "2.54", "142", "5000", 49.5, 186, 12, "21", "", "17879", 1.5, 28, 53, "better", "R15", null, "0.77", "power", "15.9", "195/65", "", "auto.4", "41", "Compact", "3110", 102, 67);
                yield return new car90("Japan", "143", "2.4", null, 4, 40.5, 56.5, null, "2.9", "107", "5000", 65.5, 175, -2, "20", "", "14929", 4.5, -1, 59, null, "R14", "0.89", "0.79", "both", "14.2", "205/75", "", "auto.4", "36", "Van", "3415", 88, 67);
                yield return new car90("Japan", "146", "2.5", "2670", 3, 41, 53.5, "3.1", "2.83", "140", "5600", 46.5, 178, 14, "24", "", "13249", 0, 21.5, 50.5, "average", "R15", null, "0.66", "power", "15.9", "195/60", "man.5", "auto.4", "38", "Sporty", "2775", 97, 67);
                yield return new car90("Japan", "180", "3", "2645", 3, 42, 56.5, "3.07", "2.83", "180", "6400", 45, 170, -2, null, "", "27900", -2, -2, -2, null, "R16", null, "0.68", "power", "18.7", "225/50", "man.5", "auto.4", "38", "Sporty", "3350", 97, 71);
                yield return new car90("Japan", "146", "2.4", null, 4, 40.5, 55.5, null, "2.7", "138", "5600", 58, 172, -3, "20", "", "13949", 4.5, 28.5, 56.5, null, "R14", null, "0.81", "power", "17.2", "195/70", "", "auto.4", "38", "Van", "3185", 103, 67);
                yield return new car90("Japan", "180", "3", "2350", 2, 41.5, 56.5, "2.9", "2.53", "160", "5200", 49.5, 188, 14, "22", "", "17899", 1.5, 29, 55.5, "Much better", "R15", null, "0.73", "power", "18.5", "205/65", "man.5", "auto.4", "42", "Medium", "3200", 104, 69);
                yield return new car90("Japan", "97", "1.6", "3015", 4, 41, 52, "3.38", "3.6", "90", "6000", 46, 167, 7, null, "", "12249", 0, 21, 49.5, "average", "R13", null, "0.68", "power", "13.2", "185/70", "man.5", "auto.3", "38", "Sporty", "2390", 96, 66);
                yield return new car90("Japan/USA", "97", "1.6", "2680", 3, 40, 52.5, "2.94", "3.6", "90", "6000", 49, 172, 12, "33", "", "7399", 2, 24.5, 52.5, "Much better", "R13", "0.87", "0.68", "both", "13.2", "175/70", "man.5", "auto.3", "37", "Small", "2275", 96, 65);
                yield return new car90("Japan", "146", "2.4", "2395", 3.5, 40.5, 55, "2.75", "2.53", "138", "5600", 49.5, 180, 14, "21", "", "11650", 2, 26.5, 54, "Much better", "R14", null, "0.74", "power", "16.4", "195/65", "man.5", "auto.4", "39", "Compact", "2920", 100, 67);
                yield return new car90("Japan", "146", "2.4", null, 3.5, 41, 57, null, "3.17", "106", "4800", 65.5, 178, -2, "19", "", "14799", 5, -1, 58.5, null, "R14", null, "0.74", "power", "17.7", "195/75", "", "auto.4", "38", "Van", "3690", 93, 67);
                yield return new car90("France", "116", "2", "2760", 4, 41, 55.5, "3.08", "3.12", "120", "5200", 51, 175, 14, "24", "", "15930", 1.5, 29, 55, null, "R14", null, "0.74", "power", "17.2", "185/65", "man.5", "auto.4", "37", "Compact", "2575", 105, 68);
                yield return new car90("France", "132", "2.2", null, 2.5, 42, 55.5, null, "3.38", "120", "5000", 52, 181, 11, null, "", "19945", 1, 29.5, 54.5, null, "R15", null, "0.8", "power", "18", "185/65", "", "auto.4", "39", "Medium", "3000", 108, 68);
                yield return new car90("USA", "107", "1.8", "2810", 3.5, 41.5, 54, "3.27", "3.27", "92", "5000", 47, 171, 10, "26", "Mitsubishi Eclipse", "10855", 0, 23, 52, null, "R14", "1.01", "0.67", "both", "15.9", "185/70", "man.5", "auto.4", "39", "Sporty", "2840", 97, 67);
                yield return new car90(null, "231", "3.8", null, 4, 42, 59, null, "1.99", "165", "4800", 50.5, 199, 15, null, "", null, 4, 29.5, 59, null, "R15", null, "0.78", "power", "18", "215/65", "", "auto.4", "43", null, "3360", 111, 72);
                yield return new car90("USA", "138", "2.3", "2245", 3.5, 41.5, 55, "2.6", "3.18", "160", "6200", 48.5, 180, 13, "23", "", "10565", 1, 26.5, 54, "worse", "R14", null, "0.72", "power", "13.6", "195/70", "man.5", "auto.3", "39", "Compact", "2770", 103, 67);
                yield return new car90("Korea", "98", "1.6", "2295", 5, 41.5, 53.5, "2.64", "3.43", "74", "5600", 50, 172, 18, "28", "", "7254", 2.5, 25.5, 53, "Much worse", "R13", "1.05", "0.78", "both", "13.2", "175/70", "man.5", "auto.3", "35", "Small", "2350", 99, 66);
                yield return new car90("Germany", "165", "2.7", "2380", 3.5, 43.5, 55.5, "2.84", "3.45", "165", "5900", 46, 169, 12, null, "", "41990", 0, 18, 51.5, null, "R15", null, "0.74", "power", "21.1", "195/65", "man.5", "auto.3", "36", "Sporty", "2900", 95, 68);
                yield return new car90("Sweden", "121", "2", "2575", 3.5, 41.5, 53, "3.03", "3.62", "128", "6000", 50.5, 184, 14, null, "", "16995", 2, 27.5, 53, "worse", "R15", null, "0.85", "power", "18", "185/65", "man.5", "auto.3", "37", "Compact", "2775", 99, 67);
                yield return new car90("Sweden", "121", "2", "2615", 2.5, 42, 57, "3.12", "3.1", "130", "6000", 52, 188, 18, null, "", "25995", 2.5, 31, 57, null, "R15", null, "0.79", "power", "17.9", "195/65", "man.5", "auto.4", "40", "Medium", "3065", 105, 69);
                yield return new car90("England", "163", "2.7", "2470", 2, 42, 55, "2.95", "3.02", "160", "5900", 50, 189, 12, null, "", "23550", 1.5, 29.5, 54, null, "R15", null, "0.96", "power", "17", "195/60", "man.5", "auto.4", "42", "Medium", "3295", 109, 68);
                yield return new car90("Japan", "73", "1.2", "2945", 2.5, 40.5, 51, "3.02", "2.99", "73", "5600", 50.5, 146, 9, "34", "", "5866", 0.5, 23.5, 50.5, null, "R13", "0.86", null, "manual", "9.2", "165/65", "man.5", "auto.CVT", "32", "Small", "1900", 90, 60);
                yield return new car90("Japan/USA", "135", "2.2", "2390", 2, 41, 54, "2.74", "2.57", "130", "5400", 49, 178, 14, "23", "", "11499", 2, 27.5, 53.5, "Much better", "R14", null, "0.77", "power", "15.9", "175/70", "man.5", "auto.4", "37", "Compact", "2935", 102, 67);
                yield return new car90("Japan", "109", "1.8", "2770", 2.5, 41, 53.5, "3.04", "3.6", "90", "5200", 49, 175, 15, "25", "", "9599", 2, 27.5, 53.5, "Much better", "R13", null, "0.82", "power", "15.9", "175/70", "man.5", "auto.3", "35", "Small", "2295", 97, 65);
                yield return new car90("Japan", "109", "1.8", "2935", 2, 42, 53, "3.29", "2.69", "97", "5200", 46, 178, 10, "28", "", "13071", 0, 22.5, 51, null, "R13", null, "0.74", "power", "15.9", "185/70", "man.5", "auto.4", "36", "Sporty", "2485", 97, 67);
                yield return new car90("Japan/USA", "122", "2", "2350", 3, 42, 54.5, "2.73", "2.74", "115", "5200", 50.5, 182, 12, "27", "", "11588", 2, 28.5, 53.5, "Much better", "R14", null, "0.76", "power", "15.9", "185/70", "man.5", "auto.4", "39", "Compact", "2920", 102, 67);
                yield return new car90("Japan", "132", "2.2", "2215", 2, 42, 51.5, "2.49", "3.52", "130", "5400", 47, 174, 13, null, "", "12268", 0, 23, 48, null, "R15", null, "0.73", "power", "15.9", "215/50", "man.5", "auto.4", "39", "Sporty", "2885", 99, 69);
                yield return new car90("Japan/USA", "97", "1.6", "2765", 4, 40.5, 53, "3.03", "3.53", "102", "5800", 49.5, 170, 11, "29", "", "8748", 2, 26, 52.5, "Much better", "R13", "1.06", "0.79", "both", "13.2", "155/65", "man.5", "auto.3", "36", "Small", "2390", 96, 65);
                yield return new car90("Japan", "180", "3", null, 2, 41, 55, null, "2.76", "190", "5600", 50.5, 190, 12, "23", "", "21498", 1.5, 27.5, 54.5, "average", "R15", null, "0.88", "power", "18.5", "195/65", "", "auto.4", "36", "Medium", "3480", 106, 67);
                yield return new car90("Japan", "180", "3", "2840", 2.5, 42.5, 52.5, "3.3", "3.03", "200", "6000", 46.5, 182, 11, null, "", "22860", 0, 23, 50.5, "better", "R16", null, "0.72", "power", "18.5", "225/50", "man.5", "auto.4", "40", "Sporty", "3470", 102, 69);
                yield return new car90("Japan", "89", "1.5", "2765", 3, 40.5, 53, "3.03", "3.72", "78", "6000", 49.5, 167, 13, "35", "", "6488", 1.5, 25, 52.5, "Much better", "R13", "0.83", "0.69", "both", "11.9", "155", "man.5", "auto.3", "35", "Small", "2075", 94, 64);
                yield return new car90("Germany", "109", "1.8", "2685", 2, 42, 53.5, "2.94", null, "158", "5600", 47, 159, 19, null, "", "17900", 0, 26, 51, null, "R15", null, "0.71", "power", "14.5", "195/50", "man.5", "", "34", "Sporty", "2680", 97, 66);
                yield return new car90("Brazil", "109", "1.8", "2765", 3, 42, 51.5, "3.03", null, "81", "5500", 49.5, 163, 10, null, "", "7225", 2, 26, 51, null, "R13", "0.82", null, "manual", "12.4", "175/70", "man.4", "", "34", "Small", "2190", 93, 63);
                yield return new car90("Mexico", "109", "1.8", "3000", 3.5, 41.5, 53, "3.26", null, "105", "5400", 50.5, 158, 18, null, "", "9995", 2, 27, 54, null, "R14", null, "0.75", "power", "14.5", "185/60", "man.5", "", "35", "Sporty", "2270", 97, 66);
                yield return new car90("Mexico", "109", "1.8", "2980", 3, 41, 53, "3.27", "3.41", "100", "5400", 51, 158, 18, null, "", "8695", 2, 27, 53, "average", "R13", "0.87", "0.7", "both", "14.5", "175/70", "man.5", "auto.3", "35", "Small", "2215", 97, 66);
                yield return new car90("Germany", "109", "1.8", "2510", 3.5, 41, 53, "2.75", "3.41", "100", "5400", 51, 172, 17, "26", "", "9995", 2.5, 28, 53.5, "average", "R13", "0.87", "0.7", "both", "14.5", "175/70", "man.5", "auto.3", "35", "Small", "2330", 97, 66);
                yield return new car90("Germany", "129", "2.1", "3370", 5, 39, 61.5, "4.11", "4.09", "90", "4800", 70.5, 180, -2, null, "", "14080", 9, 37, 39.5, null, "R14", null, "0.88", "power", "15.9", "185", "man.4", "auto.3", "37", "Van", "3460", 97, 73);
                yield return new car90("Sweden", "141", "2.3", "2330", 3.5, 41.5, 54, "2.71", "2.57", "114", "5400", 52.5, 190, 14, "23", "", "18450", 2, 29.5, 53, "average", "R14", null, "0.75", "power", "15.8", "185/70", "man.5", "auto.4", "37", "Compact", "2985", 104, 67);
                yield return new car90("Sweden", "141", "2.3", "2305", 2.5, 42, 56.5, "2.71", "2.83", "114", "5400", 50.5, 188, 17, null, "", "21700", 3, 29.5, 56.5, "average", "R15", null, "0.77", "power", "15.8", "185/65", "man.5", "auto.4", "37", "Medium", "3140", 109, 69);
            }
        }
    }
}
