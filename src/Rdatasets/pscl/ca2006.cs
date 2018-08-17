// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// California Congressional Districts in 2006
    /// </summary>

    public class ca2006
    {
        public readonly int district;
        public readonly string D;
        public readonly string R;
        public readonly string Other;
        public readonly string IncParty;
        public readonly string IncName;
        public readonly bool open;
        public readonly bool contested;
        public readonly int Bush2004;
        public readonly int Kerry2004;
        public readonly int Other2004;
        public readonly int Bush2000;
        public readonly int Gore2000;

        public ca2006(int district, string D, string R, string Other, string IncParty, string IncName, bool open, bool contested, int Bush2004, int Kerry2004, int Other2004, int Bush2000, int Gore2000)
        {
            this.district = district;
            this.D = D;
            this.R = R;
            this.Other = Other;
            this.IncParty = IncParty;
            this.IncName = IncName;
            this.open = open;
            this.contested = contested;
            this.Bush2004 = Bush2004;
            this.Kerry2004 = Kerry2004;
            this.Other2004 = Other2004;
            this.Bush2000 = Bush2000;
            this.Gore2000 = Gore2000;
        }

        public static IEnumerable<ca2006> Data
        {
            get
            {
                yield return new ca2006(1, "111650", "49663", "7850", "D", "Thompson", false, true, 111754, 173926, 5508, 98506, 131376);
                yield return new ca2006(2, "54829", "108002", "5613", "R", "Herger", false, true, 173528, 102254, 3980, 150196, 81861);
                yield return new ca2006(3, "72815", "114155", "5193", "R", "Lungren", false, true, 176512, 123671, 2936, 142946, 107690);
                yield return new ca2006(4, "97705", "105525", "10754", "R", "Doolittle", false, true, 216838, 132267, 4119, 172169, 104437);
                yield return new ca2006(5, "89119", "29824", "7110", "D", "Matsui", false, true, 77788, 125378, 2172, 66011, 113987);
                yield return new ca2006(6, "127777", "50061", "6802", "D", "Woolsey", false, true, 90432, 226051, 4574, 87082, 178746);
                yield return new ca2006(7, "106955", null, "21021", "D", "Miller", false, false, 72994, 153988, 2300, 64477, 139421);
                yield return new ca2006(8, "119616", "15859", "13364", "D", "Pelosi", false, true, 40558, 244009, 4024, 37737, 196878);
                yield return new ca2006(9, "148876", "18810", "4969", "D", "Lee", false, true, 33450, 228642, 4082, 31464, 184030);
                yield return new ca2006(10, "113663", "58285", null, "D", "Tauscher", false, true, 117037, 169373, 3098, 109149, 145996);
                yield return new ca2006(11, "92571", "80112", null, "R", "Pombo", false, true, 151397, 127102, 2306, 125876, 106354);
                yield return new ca2006(12, "109187", "34966", null, "D", "Lantos", false, true, 73740, 193689, 2646, 70468, 164490);
                yield return new ca2006(13, "100175", "33828", null, "D", "Stark", false, true, 60559, 153598, 2378, 55803, 126477);
                yield return new ca2006(14, "123280", "42451", "8084", "D", "Eshoo", false, true, 83326, 188864, 3981, 84637, 155165);
                yield return new ca2006(15, "110502", "42547", null, "D", "Honda", false, true, 82742, 145007, 2903, 74974, 124880);
                yield return new ca2006(16, "94145", "35606", null, "D", "Lofgren", false, true, 70190, 125415, 2089, 57160, 109632);
                yield return new ca2006(17, "86617", "26013", null, "D", "Farr", false, true, 75005, 149029, 3144, 68717, 124580);
                yield return new ca2006(18, "63008", "33242", null, "D", "Cardoza", false, true, 80157, 79764, 1677, 65105, 77908);
                yield return new ca2006(19, "61610", "93486", null, "R", "Radanovich", false, true, 151603, 93918, 2308, 125465, 84559);
                yield return new ca2006(20, "56317", null, null, "D", "Costa", false, false, 56045, 58534, 1023, 46058, 57790);
                yield return new ca2006(21, "37374", "82258", "4033", "R", "Nunes", false, true, 133004, 68501, 1646, 107645, 65268);
                yield return new ca2006(22, "53610", "130298", null, "R", null, true, true, 180584, 82356, 2747, 141156, 73338);
                yield return new ca2006(23, "92158", "50241", null, "D", "Capps", false, true, 101817, 147361, 3464, 90550, 119795);
                yield return new ca2006(24, "61359", "98169", null, "R", "Gallegly", false, true, 165430, 127875, 3473, 140755, 112436);
                yield return new ca2006(25, "52555", "89132", "6426", "R", "McKeon", false, true, 142052, 96355, 3057, 108627, 81893);
                yield return new ca2006(26, "64133", "96728", "8621", "R", "Dreier", false, true, 148352, 117532, 3202, 127468, 105023);
                yield return new ca2006(27, "88109", "40160", null, "D", "Sherman", false, true, 86397, 130567, 3034, 70557, 117120);
                yield return new ca2006(28, "75532", "19606", "7005", "D", "Berman", false, true, 49220, 125351, 2011, 36762, 112332);
                yield return new ca2006(29, "86454", "37448", "12159", "D", "Schiff", false, true, 83448, 136796, 3097, 79210, 119396);
                yield return new ca2006(30, "141791", "52968", "4186", "D", "Waxman", false, true, 109014, 220181, 3660, 81336, 199282);
                yield return new ca2006(31, "60452", null, null, "D", "Becerra", false, false, 26054, 92894, 1815, 19400, 79560);
                yield return new ca2006(32, "72685", null, "15024", "D", "Solis", false, false, 58341, 99286, 1756, 45018, 96217);
                yield return new ca2006(33, "105133", null, null, "D", "Watson", false, false, 33132, 172382, 2631, 24214, 148978);
                yield return new ca2006(34, "53911", "16532", null, "D", "Roybal-Allard", false, true, 35926, 82942, 1654, 27384, 76876);
                yield return new ca2006(35, "77086", null, "15262", "D", "Waters", false, false, 33110, 130764, 1726, 24495, 118450);
                yield return new ca2006(36, "100296", "50758", "7280", "D", "Harman", false, true, 103425, 154010, 3558, 88619, 130752);
                yield return new ca2006(37, "75580", null, "16282", "D", "Millender-McDonald", false, false, 43160, 126068, 2281, 31832, 112235);
                yield return new ca2006(38, "71028", "23422", null, "D", "Napolitano", false, true, 54869, 106652, 1846, 41706, 104612);
                yield return new ca2006(39, "69012", "36004", null, "D", "Sanchez", false, true, 70635, 102660, 2110, 56067, 98478);
                yield return new ca2006(40, "44440", "97588", "3701", "R", "Royce", false, true, 138766, 88631, 2740, 119443, 86460);
                yield return new ca2006(41, "46443", "95282", null, "R", "Lewis", false, true, 149673, 89424, 2729, 114498, 83584);
                yield return new ca2006(42, null, "124140", null, "R", "Miller", false, false, 164998, 98108, 2578, 139655, 92169);
                yield return new ca2006(43, "49101", "27286", null, "D", "Baca", false, true, 55952, 79946, 1497, 41272, 76710);
                yield return new ca2006(44, "43551", "69712", "3454", "R", "Calvert", false, true, 139476, 94374, 2562, 101897, 84048);
                yield return new ca2006(45, "42384", "62007", null, "R", "Bono", false, true, 132288, 101679, 2102, 93802, 85427);
                yield return new ca2006(46, "68621", "111648", "6969", "R", "Rohrbacher", false, true, 168158, 122991, 3734, 145729, 110984);
                yield return new ca2006(47, "42822", "26507", null, "D", "Sanchez", false, true, 56226, 54623, 1393, 43752, 59515);
                yield return new ca2006(48, "71175", "114686", "5456", "R", "Campbell", false, true, 178739, 123664, 3364, 156340, 106809);
                yield return new ca2006(49, "44608", "83269", "4145", "R", "Issa", false, true, 149283, 86998, 2389, 114193, 75561);
                yield return new ca2006(50, "91793", "112209", "7047", "R", null, true, true, 169935, 135007, 2891, 136311, 107436);
                yield return new ca2006(51, "68514", "30803", "2407", "D", "Filner", false, true, 85762, 100062, 1731, 61008, 85561);
                yield return new ca2006(52, "56309", "114712", "5942", "R", "Hunter", false, true, 177055, 108806, 2509, 143081, 98633);
                yield return new ca2006(53, "92187", "40918", "3305", "D", "Davis", false, true, 89890, 146160, 2953, 74526, 114435);
            }
        }
    }
}
