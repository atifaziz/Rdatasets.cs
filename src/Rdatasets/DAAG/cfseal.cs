// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Cape Fur Seal Data
    /// </summary>

    public class cfseal
    {
        public readonly int age;
        public readonly double weight;
        public readonly double heart;
        public readonly double? lung;
        public readonly double liver;
        public readonly double? spleen;
        public readonly double stomach;
        public readonly double? leftkid;
        public readonly double? rightkid;
        public readonly int kidney;
        public readonly double? intestines;

        public cfseal(int age, double weight, double heart, double? lung, double liver, double? spleen, double stomach, double? leftkid, double? rightkid, int kidney, double? intestines)
        {
            this.age = age;
            this.weight = weight;
            this.heart = heart;
            this.lung = lung;
            this.liver = liver;
            this.spleen = spleen;
            this.stomach = stomach;
            this.leftkid = leftkid;
            this.rightkid = rightkid;
            this.kidney = kidney;
            this.intestines = intestines;
        }

        public static IEnumerable<cfseal> Data
        {
            get
            {
                yield return new cfseal(33, 27.5, 127.7, 605, 855, 52.5, 338.2, 107.9, 107.5, 215, 885);
                yield return new cfseal(10, 24.3, 93.2, 436, 435.4, 24.5, 120.4, 62.8, 63.9, 127, 711.4);
                yield return new cfseal(10, 22, 84.5, 380, 530, 31.3, 237.6, 53.5, 58, 112, 765);
                yield return new cfseal(10, 18.5, 85.4, 493.9, 542, 30.8, 193.1, 66, 73.2, 139, 849.6);
                yield return new cfseal(12, 28, 182, null, 949, 46, 400, null, null, 238, null);
                yield return new cfseal(18, 23.8, 130, 550, 1100, 51, 443.2, 145.9, 147.3, 293, 1210);
                yield return new cfseal(19, 18.5, 98.8, 470, 627.2, 40, 265.9, 92.7, 88.5, 181, 959);
                yield return new cfseal(23, 18, 117.3, 592.5, 632.9, 28.9, 280.8, 86.1, 86, 172, 855.4);
                yield return new cfseal(31, 34, 180, 605, 1040, 45, 425, 125, 120, 245, 1540);
                yield return new cfseal(33, 28.5, 150.4, 799.9, 1047.1, 41.3, 476.2, 124.5, 123.9, 248, 1644);
                yield return new cfseal(44, 35.8, 145.5, 995, 1525, 90, 475.6, 176, 156.3, 332, 2405);
                yield return new cfseal(46, 30.3, 140, 785, 1210, 60.2, 360.3, 127.3, 104.9, 232, 1345);
                yield return new cfseal(46, 33, 168.1, 910, 1195, 89.3, 384.9, 123.4, 125.2, 249, 1460);
                yield return new cfseal(50, 42, 205, 1115, 1415, 80, 560, 145, 160, 305, 1745);
                yield return new cfseal(50, 37.5, 205, 1142.6, 1099.8, 57.5, 543, 143.3, 131.1, 274, 1372);
                yield return new cfseal(60, 55, 320.9, 1465, 2250, 96.5, 961.8, 226.5, 200.7, 427, 2805);
                yield return new cfseal(59, 50.5, 255, 1250, 2115, 135, 850, 200, 215, 415, 2675);
                yield return new cfseal(66, 57.5, 370, 1580, 2195, 140, 720, 220, 230, 450, 2490);
                yield return new cfseal(68, 67.5, 465, 2000, 2990, 350, 865, 255, 275, 530, 2880);
                yield return new cfseal(68, 53.5, 332.8, 1474.4, 2124.2, 149.6, 730, 227.6, 229.3, 457, 2497);
                yield return new cfseal(72, 73, 449, null, 2715, 127, 1044, null, null, 605, null);
                yield return new cfseal(73, 54.5, 282.5, 1220, 2795, 136.5, 919, 277.9, 262.8, 541, 2515);
                yield return new cfseal(73, 68.5, 355, 1790, 3875, 145, 1390, 290, 335, 625, 3535);
                yield return new cfseal(80, 74, 310, 1510, 3130, 118.3, 985.8, 285, 300, 585, 3410);
                yield return new cfseal(84, 68, 532, null, 2937, 160, 1209, null, null, 620, null);
                yield return new cfseal(96, 97, 667, null, 4241, 213, 1542, null, null, 757, null);
                yield return new cfseal(106, 101, 440, 2735, 3580, 305, 1260, 368.4, 391.7, 760, 3570);
                yield return new cfseal(108, 128, 1012, null, 5172, 284, 1734, null, null, 888, null);
                yield return new cfseal(118, 95, 505, 2380, 3720, 425, 1245, 385, 400, 785, 3565);
                yield return new cfseal(120, 179, 1075, null, 8309, null, 2500, null, null, 1410, null);
            }
        }
    }
}
