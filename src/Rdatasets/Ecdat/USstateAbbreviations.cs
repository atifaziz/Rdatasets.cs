// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Standard abbreviations for states of the United States
    /// </summary>

    public class USstateAbbreviations
    {
        public readonly string Name;
        public readonly string Status;
        public readonly string ISO;
        public readonly string ANSI_letters;
        public readonly string ANSI_digits;
        public readonly string USPS;
        public readonly string USCG;
        public readonly string Old_GPO;
        public readonly string AP;
        public readonly string Other;

        public USstateAbbreviations(string Name, string Status, string ISO, string ANSI_letters, string ANSI_digits, string USPS, string USCG, string Old_GPO, string AP, string Other)
        {
            this.Name = Name;
            this.Status = Status;
            this.ISO = ISO;
            this.ANSI_letters = ANSI_letters;
            this.ANSI_digits = ANSI_digits;
            this.USPS = USPS;
            this.USCG = USCG;
            this.Old_GPO = Old_GPO;
            this.AP = AP;
            this.Other = Other;
        }

        public static IEnumerable<USstateAbbreviations> Data
        {
            get
            {
                yield return new USstateAbbreviations("United States", "Federal state", "US\nUSA", "US", "00", "", "", "U.S.", "U.S.", "U.S.A.");
                yield return new USstateAbbreviations("Alabama", "State", "US-AL", "AL", "01", "AL", "AL", "Ala.", "Ala.", "");
                yield return new USstateAbbreviations("Alaska", "State", "US-AK", "AK", "02", "AK", "AK", "Alaska", "Alaska", "Alas.");
                yield return new USstateAbbreviations("Arizona", "State", "US-AZ", "AZ", "04", "AZ", "AZ", "Ariz.", "Ariz.", "Az.");
                yield return new USstateAbbreviations("Arkansas", "State", "US-AR", "AR", "05", "AR", "AR", "Ark.", "Ark.", "");
                yield return new USstateAbbreviations("California", "State", "US-CA", "CA", "06", "CA", "CF", "Calif.", "Calif.", "Ca., Cal., Cali.");
                yield return new USstateAbbreviations("Colorado", "State", "US-CO", "CO", "08", "CO", "CL", "Colo.", "Colo.", "Col.");
                yield return new USstateAbbreviations("Connecticut", "State", "US-CT", "CT", "09", "CT", "CT", "Conn.", "Conn.", "Ct.");
                yield return new USstateAbbreviations("Delaware", "State", "US-DE", "DE", "10", "DE", "DL", "Del.", "Del.", "De.");
                yield return new USstateAbbreviations("District of Columbia", "Federal district", "US-DC", "DC", "11", "DC", "DC", "D.C.", "D.C.", "Wash._D.C.");
                yield return new USstateAbbreviations("Florida", "State", "US-FL", "FL", "12", "FL", "FL", "Fla.", "Fla.", "Fl., Flor.");
                yield return new USstateAbbreviations("Georgia", "State", "US-GA", "GA", "13", "GA", "GA", "Ga.", "Ga.", "");
                yield return new USstateAbbreviations("Hawaii", "State", "US-HI", "HI", "15", "HI", "HA", "Hawaii", "Hawaii", "H.I.");
                yield return new USstateAbbreviations("Idaho", "State", "US-ID", "ID", "16", "ID", "ID", "Idaho", "Idaho", "Id., Ida.");
                yield return new USstateAbbreviations("Illinois", "State", "US-IL", "IL", "17", "IL", "IL", "Ill.", "Ill.", "Il., Ills., Ill's");
                yield return new USstateAbbreviations("Indiana", "State", "US-IN", "IN", "18", "IN", "IN", "Ind.", "Ind.", "In.");
                yield return new USstateAbbreviations("Iowa", "State", "US-IA", "IA", "19", "IA", "IA", "Iowa", "Iowa", "Ia., Ioa.");
                yield return new USstateAbbreviations("Kansas", "State", "US-KS", "KS", "20", "KS", "KA", "Kans.", "Kan.", "Ks., Ka.");
                yield return new USstateAbbreviations("Kentucky", "State (Commonwealth)", "US-KY", "KY", "21", "KY", "KY", "Ky.", "Ky.", "Ken., Kent.");
                yield return new USstateAbbreviations("Louisiana", "State", "US-LA", "LA", "22", "LA", "LA", "La.", "La.", "");
                yield return new USstateAbbreviations("Maine", "State", "US-ME", "ME", "23", "ME", "ME", "Maine", "Maine", "Me.");
                yield return new USstateAbbreviations("Maryland", "State", "US-MD", "MD", "24", "MD", "MD", "Md.", "Md.", "");
                yield return new USstateAbbreviations("Massachusetts", "State (Commonwealth)", "US-MA", "MA", "25", "MA", "MS", "Mass.", "Mass.", "");
                yield return new USstateAbbreviations("Michigan", "State", "US-MI", "MI", "26", "MI", "MC", "Mich.", "Mich.", "");
                yield return new USstateAbbreviations("Minnesota", "State", "US-MN", "MN", "27", "MN", "MN", "Minn.", "Minn.", "Mn.");
                yield return new USstateAbbreviations("Mississippi", "State", "US-MS", "MS", "28", "MS", "MI", "Miss.", "Miss.", "");
                yield return new USstateAbbreviations("Missouri", "State", "US-MO", "MO", "29", "MO", "MO", "Mo.", "Mo.", "");
                yield return new USstateAbbreviations("Montana", "State", "US-MT", "MT", "30", "MT", "MT", "Mont.", "Mont.", "");
                yield return new USstateAbbreviations("Nebraska", "State", "US-NE", "NE", "31", "NE", "NB", "Nebr.", "Neb.", "");
                yield return new USstateAbbreviations("Nevada", "State", "US-NV", "NV", "32", "NV", "NV", "Nev.", "Nev.", "Nv.");
                yield return new USstateAbbreviations("New Hampshire", "State", "US-NH", "NH", "33", "NH", "NH", "N.H.", "N.H.", "");
                yield return new USstateAbbreviations("New Jersey", "State", "US-NJ", "NJ", "34", "NJ", "NJ", "N.J.", "N.J.", "");
                yield return new USstateAbbreviations("New Mexico", "State", "US-NM", "NM", "35", "NM", "NM", "N._Mex.", "N.M.", "New_M.");
                yield return new USstateAbbreviations("New York", "State", "US-NY", "NY", "36", "NY", "NY", "N.Y.", "N.Y.", "N._York");
                yield return new USstateAbbreviations("North Carolina", "State", "US-NC", "NC", "37", "NC", "NC", "N.C.", "N.C.", "N._Car.");
                yield return new USstateAbbreviations("North Dakota", "State", "US-ND", "ND", "38", "ND", "ND", "N._Dak.", "N.D.", "NoDak");
                yield return new USstateAbbreviations("Ohio", "State", "US-OH", "OH", "39", "OH", "OH", "Ohio", "Ohio", "O., Oh.");
                yield return new USstateAbbreviations("Oklahoma", "State", "US-OK", "OK", "40", "OK", "OK", "Okla.", "Okla.", "Ok.");
                yield return new USstateAbbreviations("Oregon", "State", "US-OR", "OR", "41", "OR", "OR", "Oreg.", "Ore.", "Or.");
                yield return new USstateAbbreviations("Pennsylvania", "State (Commonwealth)", "US-PA", "PA", "42", "PA", "PA", "Pa.", "Pa.", "Penn., Penna.");
                yield return new USstateAbbreviations("Rhode Island", "State", "US-RI", "RI", "44", "RI", "RI", "R.I.", "R.I.", "R.I._P.P.");
                yield return new USstateAbbreviations("South Carolina", "State", "US-SC", "SC", "45", "SC", "SC", "S.C.", "S.C.", "S._Car.");
                yield return new USstateAbbreviations("South Dakota", "State", "US-SD", "SD", "46", "SD", "SD", "S._Dak.", "S.D.", "SoDak");
                yield return new USstateAbbreviations("Tennessee", "State", "US-TN", "TN", "47", "TN", "TN", "Tenn.", "Tenn.", "Tn.");
                yield return new USstateAbbreviations("Texas", "State", "US-TX", "TX", "48", "TX", "TX", "Tex.", "Texas", "Tx.");
                yield return new USstateAbbreviations("Utah", "State", "US-UT", "UT", "49", "UT", "UT", "Utah", "Utah", "Ut.");
                yield return new USstateAbbreviations("Vermont", "State", "US-VT", "VT", "50", "VT", "VT", "Vt.", "Vt.", "");
                yield return new USstateAbbreviations("Virginia", "State (Commonwealth)", "US-VA", "VA", "51", "VA", "VA", "Va.", "Va.", "Virg.");
                yield return new USstateAbbreviations("Washington", "State", "US-WA", "WA", "53", "WA", "WN", "Wash.", "Wash.", "Wa., Wn.");
                yield return new USstateAbbreviations("West Virginia", "State", "US-WV", "WV", "54", "WV", "WV", "W._Va.", "W.Va.", "W.V., W._Virg.");
                yield return new USstateAbbreviations("Wisconsin", "State", "US-WI", "WI", "55", "WI", "WS", "Wis.", "Wis.", "Wi., Wisc.");
                yield return new USstateAbbreviations("Wyoming", "State", "US-WY", "WY", "56", "WY", "WY", "Wyo.", "Wyo.", "Wy.");
                yield return new USstateAbbreviations("American Samoa", "Insular area (Territory)", "AS\nASM\nUS-AS", "AS", "60", "AS", "AS", "A.S.", "", "");
                yield return new USstateAbbreviations("Guam", "Insular area (Territory)", "GU\nGUM\nUS-GU", "GU", "66", "GU", "GU", "Guam", "", "");
                yield return new USstateAbbreviations("Northern Mariana Islands", "Insular area (Commonwealth)", "MP\nMNP\nUS-MP", "MP", "69", "MP", "CM", "M.P.", "", "");
                yield return new USstateAbbreviations("Puerto Rico", "Insular area (Commonwealth)", "PR\nPRI\nUS-PR", "PR", "72", "PR", "PR", "P.R.", "", "");
                yield return new USstateAbbreviations("Virgin Islands", "Insular area (Territory)", "VI\nVIR\nUS-VI", "VI", "78", "VI", "VI", "V.I.", "", "U.S.V.I.");
                yield return new USstateAbbreviations("U.S. Minor Outlying Islands", "Insular areas", "UM\nUMI\nUS-UM", "UM", "74", "", "", "", "", "");
                yield return new USstateAbbreviations("Baker Island", "island", "UM-81", "", "81", "", "", "", "", "");
                yield return new USstateAbbreviations("Howland Island", "island", "UM-84", "", "84", "", "", "", "", "");
                yield return new USstateAbbreviations("Jarvis Island", "island", "UM-86", "", "86", "", "", "", "", "");
                yield return new USstateAbbreviations("Johnston Atoll", "atoll", "UM-67", "", "67", "", "", "", "", "");
                yield return new USstateAbbreviations("Kingman Reef", "atoll", "UM-89", "", "89", "", "", "", "", "");
                yield return new USstateAbbreviations("Midway Islands", "atoll", "UM-71", "", "71", "", "", "", "", "");
                yield return new USstateAbbreviations("Navassa Island", "island", "UM-76", "", "76", "", "", "", "", "");
                yield return new USstateAbbreviations("Palmyra Atoll", "atoll", "UM-95", "", "95", "", "", "", "", "");
                yield return new USstateAbbreviations("Wake Island", "atoll", "UM-79", "", "79", "", "", "", "", "");
                yield return new USstateAbbreviations("Federated States of Micronesia", "Freely associated state", "FM\nFSM", "FM", "64", "FM", "", "", "", "");
                yield return new USstateAbbreviations("Marshall Islands", "Freely associated state", "MH\nMHL", "MH", "68", "MH", "", "", "", "");
                yield return new USstateAbbreviations("Palau", "Freely associated state", "PW\nPLW", "PW", "70", "PW", "", "", "", "");
                yield return new USstateAbbreviations("U.S. Armed Forces _ Americas", "US military mail code", "", "", "", "AA", "", "", "", "");
                yield return new USstateAbbreviations("U.S. Armed Forces _ Europe", "US military mail code", "", "", "", "AE", "", "", "", "");
                yield return new USstateAbbreviations("U.S. Armed Forces _ Pacific", "US military mail code", "", "", "", "AP", "", "", "", "");
                yield return new USstateAbbreviations("Panama Canal Zone", "Obsolete postal code", "", "", "", "CZ", "", "", "", "");
                yield return new USstateAbbreviations("Philippine Islands", "Obsolete postal code", "PH\nPHL", "", "", "PI", "", "", "", "");
                yield return new USstateAbbreviations("Trust Territory of the Pacific Islands", "Obsolete postal code", "", "", "", "TT", "", "", "", "");
            }
        }
    }
}
