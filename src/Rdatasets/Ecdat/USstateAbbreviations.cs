// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Standard abbreviations for states of the United States
    /// </summary>

    public class USstateAbbreviations
    {
        public readonly int κ;
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

        public USstateAbbreviations(int κ, string Name, string Status, string ISO, string ANSI_letters, string ANSI_digits, string USPS, string USCG, string Old_GPO, string AP, string Other)
        {
            this.κ = κ;
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
                yield return new USstateAbbreviations(2, "United States", "Federal state", "US\nUSA", "US", "00", "", "", "U.S.", "U.S.", "U.S.A.");
                yield return new USstateAbbreviations(3, "Alabama", "State", "US-AL", "AL", "01", "AL", "AL", "Ala.", "Ala.", "");
                yield return new USstateAbbreviations(4, "Alaska", "State", "US-AK", "AK", "02", "AK", "AK", "Alaska", "Alaska", "Alas.");
                yield return new USstateAbbreviations(5, "Arizona", "State", "US-AZ", "AZ", "04", "AZ", "AZ", "Ariz.", "Ariz.", "Az.");
                yield return new USstateAbbreviations(6, "Arkansas", "State", "US-AR", "AR", "05", "AR", "AR", "Ark.", "Ark.", "");
                yield return new USstateAbbreviations(7, "California", "State", "US-CA", "CA", "06", "CA", "CF", "Calif.", "Calif.", "Ca., Cal., Cali.");
                yield return new USstateAbbreviations(8, "Colorado", "State", "US-CO", "CO", "08", "CO", "CL", "Colo.", "Colo.", "Col.");
                yield return new USstateAbbreviations(9, "Connecticut", "State", "US-CT", "CT", "09", "CT", "CT", "Conn.", "Conn.", "Ct.");
                yield return new USstateAbbreviations(10, "Delaware", "State", "US-DE", "DE", "10", "DE", "DL", "Del.", "Del.", "De.");
                yield return new USstateAbbreviations(11, "District of Columbia", "Federal district", "US-DC", "DC", "11", "DC", "DC", "D.C.", "D.C.", "Wash._D.C.");
                yield return new USstateAbbreviations(12, "Florida", "State", "US-FL", "FL", "12", "FL", "FL", "Fla.", "Fla.", "Fl., Flor.");
                yield return new USstateAbbreviations(13, "Georgia", "State", "US-GA", "GA", "13", "GA", "GA", "Ga.", "Ga.", "");
                yield return new USstateAbbreviations(14, "Hawaii", "State", "US-HI", "HI", "15", "HI", "HA", "Hawaii", "Hawaii", "H.I.");
                yield return new USstateAbbreviations(15, "Idaho", "State", "US-ID", "ID", "16", "ID", "ID", "Idaho", "Idaho", "Id., Ida.");
                yield return new USstateAbbreviations(16, "Illinois", "State", "US-IL", "IL", "17", "IL", "IL", "Ill.", "Ill.", "Il., Ills., Ill's");
                yield return new USstateAbbreviations(17, "Indiana", "State", "US-IN", "IN", "18", "IN", "IN", "Ind.", "Ind.", "In.");
                yield return new USstateAbbreviations(18, "Iowa", "State", "US-IA", "IA", "19", "IA", "IA", "Iowa", "Iowa", "Ia., Ioa.");
                yield return new USstateAbbreviations(19, "Kansas", "State", "US-KS", "KS", "20", "KS", "KA", "Kans.", "Kan.", "Ks., Ka.");
                yield return new USstateAbbreviations(20, "Kentucky", "State (Commonwealth)", "US-KY", "KY", "21", "KY", "KY", "Ky.", "Ky.", "Ken., Kent.");
                yield return new USstateAbbreviations(21, "Louisiana", "State", "US-LA", "LA", "22", "LA", "LA", "La.", "La.", "");
                yield return new USstateAbbreviations(22, "Maine", "State", "US-ME", "ME", "23", "ME", "ME", "Maine", "Maine", "Me.");
                yield return new USstateAbbreviations(23, "Maryland", "State", "US-MD", "MD", "24", "MD", "MD", "Md.", "Md.", "");
                yield return new USstateAbbreviations(24, "Massachusetts", "State (Commonwealth)", "US-MA", "MA", "25", "MA", "MS", "Mass.", "Mass.", "");
                yield return new USstateAbbreviations(25, "Michigan", "State", "US-MI", "MI", "26", "MI", "MC", "Mich.", "Mich.", "");
                yield return new USstateAbbreviations(26, "Minnesota", "State", "US-MN", "MN", "27", "MN", "MN", "Minn.", "Minn.", "Mn.");
                yield return new USstateAbbreviations(27, "Mississippi", "State", "US-MS", "MS", "28", "MS", "MI", "Miss.", "Miss.", "");
                yield return new USstateAbbreviations(28, "Missouri", "State", "US-MO", "MO", "29", "MO", "MO", "Mo.", "Mo.", "");
                yield return new USstateAbbreviations(29, "Montana", "State", "US-MT", "MT", "30", "MT", "MT", "Mont.", "Mont.", "");
                yield return new USstateAbbreviations(30, "Nebraska", "State", "US-NE", "NE", "31", "NE", "NB", "Nebr.", "Neb.", "");
                yield return new USstateAbbreviations(31, "Nevada", "State", "US-NV", "NV", "32", "NV", "NV", "Nev.", "Nev.", "Nv.");
                yield return new USstateAbbreviations(32, "New Hampshire", "State", "US-NH", "NH", "33", "NH", "NH", "N.H.", "N.H.", "");
                yield return new USstateAbbreviations(33, "New Jersey", "State", "US-NJ", "NJ", "34", "NJ", "NJ", "N.J.", "N.J.", "");
                yield return new USstateAbbreviations(34, "New Mexico", "State", "US-NM", "NM", "35", "NM", "NM", "N._Mex.", "N.M.", "New_M.");
                yield return new USstateAbbreviations(35, "New York", "State", "US-NY", "NY", "36", "NY", "NY", "N.Y.", "N.Y.", "N._York");
                yield return new USstateAbbreviations(36, "North Carolina", "State", "US-NC", "NC", "37", "NC", "NC", "N.C.", "N.C.", "N._Car.");
                yield return new USstateAbbreviations(37, "North Dakota", "State", "US-ND", "ND", "38", "ND", "ND", "N._Dak.", "N.D.", "NoDak");
                yield return new USstateAbbreviations(38, "Ohio", "State", "US-OH", "OH", "39", "OH", "OH", "Ohio", "Ohio", "O., Oh.");
                yield return new USstateAbbreviations(39, "Oklahoma", "State", "US-OK", "OK", "40", "OK", "OK", "Okla.", "Okla.", "Ok.");
                yield return new USstateAbbreviations(40, "Oregon", "State", "US-OR", "OR", "41", "OR", "OR", "Oreg.", "Ore.", "Or.");
                yield return new USstateAbbreviations(41, "Pennsylvania", "State (Commonwealth)", "US-PA", "PA", "42", "PA", "PA", "Pa.", "Pa.", "Penn., Penna.");
                yield return new USstateAbbreviations(42, "Rhode Island", "State", "US-RI", "RI", "44", "RI", "RI", "R.I.", "R.I.", "R.I._P.P.");
                yield return new USstateAbbreviations(43, "South Carolina", "State", "US-SC", "SC", "45", "SC", "SC", "S.C.", "S.C.", "S._Car.");
                yield return new USstateAbbreviations(44, "South Dakota", "State", "US-SD", "SD", "46", "SD", "SD", "S._Dak.", "S.D.", "SoDak");
                yield return new USstateAbbreviations(45, "Tennessee", "State", "US-TN", "TN", "47", "TN", "TN", "Tenn.", "Tenn.", "Tn.");
                yield return new USstateAbbreviations(46, "Texas", "State", "US-TX", "TX", "48", "TX", "TX", "Tex.", "Texas", "Tx.");
                yield return new USstateAbbreviations(47, "Utah", "State", "US-UT", "UT", "49", "UT", "UT", "Utah", "Utah", "Ut.");
                yield return new USstateAbbreviations(48, "Vermont", "State", "US-VT", "VT", "50", "VT", "VT", "Vt.", "Vt.", "");
                yield return new USstateAbbreviations(49, "Virginia", "State (Commonwealth)", "US-VA", "VA", "51", "VA", "VA", "Va.", "Va.", "Virg.");
                yield return new USstateAbbreviations(50, "Washington", "State", "US-WA", "WA", "53", "WA", "WN", "Wash.", "Wash.", "Wa., Wn.");
                yield return new USstateAbbreviations(51, "West Virginia", "State", "US-WV", "WV", "54", "WV", "WV", "W._Va.", "W.Va.", "W.V., W._Virg.");
                yield return new USstateAbbreviations(52, "Wisconsin", "State", "US-WI", "WI", "55", "WI", "WS", "Wis.", "Wis.", "Wi., Wisc.");
                yield return new USstateAbbreviations(53, "Wyoming", "State", "US-WY", "WY", "56", "WY", "WY", "Wyo.", "Wyo.", "Wy.");
                yield return new USstateAbbreviations(54, "American Samoa", "Insular area (Territory)", "AS\nASM\nUS-AS", "AS", "60", "AS", "AS", "A.S.", "", "");
                yield return new USstateAbbreviations(55, "Guam", "Insular area (Territory)", "GU\nGUM\nUS-GU", "GU", "66", "GU", "GU", "Guam", "", "");
                yield return new USstateAbbreviations(56, "Northern Mariana Islands", "Insular area (Commonwealth)", "MP\nMNP\nUS-MP", "MP", "69", "MP", "CM", "M.P.", "", "");
                yield return new USstateAbbreviations(57, "Puerto Rico", "Insular area (Commonwealth)", "PR\nPRI\nUS-PR", "PR", "72", "PR", "PR", "P.R.", "", "");
                yield return new USstateAbbreviations(58, "Virgin Islands", "Insular area (Territory)", "VI\nVIR\nUS-VI", "VI", "78", "VI", "VI", "V.I.", "", "U.S.V.I.");
                yield return new USstateAbbreviations(59, "U.S. Minor Outlying Islands", "Insular areas", "UM\nUMI\nUS-UM", "UM", "74", "", "", "", "", "");
                yield return new USstateAbbreviations(60, "Baker Island", "island", "UM-81", "", "81", "", "", "", "", "");
                yield return new USstateAbbreviations(61, "Howland Island", "island", "UM-84", "", "84", "", "", "", "", "");
                yield return new USstateAbbreviations(62, "Jarvis Island", "island", "UM-86", "", "86", "", "", "", "", "");
                yield return new USstateAbbreviations(63, "Johnston Atoll", "atoll", "UM-67", "", "67", "", "", "", "", "");
                yield return new USstateAbbreviations(64, "Kingman Reef", "atoll", "UM-89", "", "89", "", "", "", "", "");
                yield return new USstateAbbreviations(65, "Midway Islands", "atoll", "UM-71", "", "71", "", "", "", "", "");
                yield return new USstateAbbreviations(66, "Navassa Island", "island", "UM-76", "", "76", "", "", "", "", "");
                yield return new USstateAbbreviations(67, "Palmyra Atoll", "atoll", "UM-95", "", "95", "", "", "", "", "");
                yield return new USstateAbbreviations(68, "Wake Island", "atoll", "UM-79", "", "79", "", "", "", "", "");
                yield return new USstateAbbreviations(69, "Federated States of Micronesia", "Freely associated state", "FM\nFSM", "FM", "64", "FM", "", "", "", "");
                yield return new USstateAbbreviations(70, "Marshall Islands", "Freely associated state", "MH\nMHL", "MH", "68", "MH", "", "", "", "");
                yield return new USstateAbbreviations(71, "Palau", "Freely associated state", "PW\nPLW", "PW", "70", "PW", "", "", "", "");
                yield return new USstateAbbreviations(72, "U.S. Armed Forces _ Americas", "US military mail code", "", "", "", "AA", "", "", "", "");
                yield return new USstateAbbreviations(73, "U.S. Armed Forces _ Europe", "US military mail code", "", "", "", "AE", "", "", "", "");
                yield return new USstateAbbreviations(74, "U.S. Armed Forces _ Pacific", "US military mail code", "", "", "", "AP", "", "", "", "");
                yield return new USstateAbbreviations(76, "Panama Canal Zone", "Obsolete postal code", "", "", "", "CZ", "", "", "", "");
                yield return new USstateAbbreviations(78, "Philippine Islands", "Obsolete postal code", "PH\nPHL", "", "", "PI", "", "", "", "");
                yield return new USstateAbbreviations(79, "Trust Territory of the Pacific Islands", "Obsolete postal code", "", "", "", "TT", "", "", "", "");
            }
        }
    }
}
