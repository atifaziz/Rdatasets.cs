// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Halley's Life Table
    /// </summary>

    public class HalleyLifeTable
    {
        public readonly int age;
        public readonly int deaths;
        public readonly int number;
        public readonly string ratio;

        public HalleyLifeTable(int age, int deaths, int number, string ratio)
        {
            this.age = age;
            this.deaths = deaths;
            this.number = number;
            this.ratio = ratio;
        }

        public static IEnumerable<HalleyLifeTable> Data
        {
            get
            {
                yield return new HalleyLifeTable(1, 238, 1000, "0.855");
                yield return new HalleyLifeTable(2, 145, 855, "0.933333333333333");
                yield return new HalleyLifeTable(3, 57, 798, "0.952380952380952");
                yield return new HalleyLifeTable(4, 38, 760, "0.963157894736842");
                yield return new HalleyLifeTable(5, 28, 732, "0.969945355191257");
                yield return new HalleyLifeTable(6, 22, 710, "0.974647887323944");
                yield return new HalleyLifeTable(7, 18, 692, "0.982658959537572");
                yield return new HalleyLifeTable(8, 12, 680, "0.985294117647059");
                yield return new HalleyLifeTable(9, 10, 670, "0.986567164179105");
                yield return new HalleyLifeTable(10, 9, 661, "0.987897125567322");
                yield return new HalleyLifeTable(11, 8, 653, "0.989280245022971");
                yield return new HalleyLifeTable(12, 7, 646, "0.990712074303406");
                yield return new HalleyLifeTable(13, 6, 640, "0.990625");
                yield return new HalleyLifeTable(14, 6, 634, "0.990536277602524");
                yield return new HalleyLifeTable(15, 6, 628, "0.990445859872611");
                yield return new HalleyLifeTable(16, 6, 622, "0.990353697749196");
                yield return new HalleyLifeTable(17, 6, 616, "0.99025974025974");
                yield return new HalleyLifeTable(18, 6, 610, "0.99016393442623");
                yield return new HalleyLifeTable(19, 6, 604, "0.990066225165563");
                yield return new HalleyLifeTable(20, 6, 598, "0.989966555183946");
                yield return new HalleyLifeTable(21, 6, 592, "0.989864864864865");
                yield return new HalleyLifeTable(22, 6, 586, "0.988054607508532");
                yield return new HalleyLifeTable(23, 7, 579, "0.989637305699482");
                yield return new HalleyLifeTable(24, 6, 573, "0.989528795811518");
                yield return new HalleyLifeTable(25, 6, 567, "0.987654320987654");
                yield return new HalleyLifeTable(26, 7, 560, "0.9875");
                yield return new HalleyLifeTable(27, 7, 553, "0.987341772151899");
                yield return new HalleyLifeTable(28, 7, 546, "0.987179487179487");
                yield return new HalleyLifeTable(29, 7, 539, "0.985157699443414");
                yield return new HalleyLifeTable(30, 8, 531, "0.984934086629002");
                yield return new HalleyLifeTable(31, 8, 523, "0.984703632887189");
                yield return new HalleyLifeTable(32, 8, 515, "0.984466019417476");
                yield return new HalleyLifeTable(33, 8, 507, "0.98422090729783");
                yield return new HalleyLifeTable(34, 8, 499, "0.981963927855711");
                yield return new HalleyLifeTable(35, 9, 490, "0.981632653061224");
                yield return new HalleyLifeTable(36, 9, 481, "0.981288981288981");
                yield return new HalleyLifeTable(37, 9, 472, "0.980932203389831");
                yield return new HalleyLifeTable(38, 9, 463, "0.980561555075594");
                yield return new HalleyLifeTable(39, 9, 454, "0.980176211453744");
                yield return new HalleyLifeTable(40, 9, 445, "0.979775280898876");
                yield return new HalleyLifeTable(41, 9, 436, "0.979357798165138");
                yield return new HalleyLifeTable(42, 9, 427, "0.976580796252927");
                yield return new HalleyLifeTable(43, 10, 417, "0.976019184652278");
                yield return new HalleyLifeTable(44, 10, 407, "0.975429975429975");
                yield return new HalleyLifeTable(45, 10, 397, "0.974811083123426");
                yield return new HalleyLifeTable(46, 10, 387, "0.974160206718346");
                yield return new HalleyLifeTable(47, 10, 377, "0.973474801061008");
                yield return new HalleyLifeTable(48, 10, 367, "0.97275204359673");
                yield return new HalleyLifeTable(49, 10, 357, "0.969187675070028");
                yield return new HalleyLifeTable(50, 11, 346, "0.968208092485549");
                yield return new HalleyLifeTable(51, 11, 335, "0.967164179104478");
                yield return new HalleyLifeTable(52, 11, 324, "0.966049382716049");
                yield return new HalleyLifeTable(53, 11, 313, "0.964856230031949");
                yield return new HalleyLifeTable(54, 11, 302, "0.966887417218543");
                yield return new HalleyLifeTable(55, 10, 292, "0.965753424657534");
                yield return new HalleyLifeTable(56, 10, 282, "0.964539007092199");
                yield return new HalleyLifeTable(57, 10, 272, "0.963235294117647");
                yield return new HalleyLifeTable(58, 10, 262, "0.961832061068702");
                yield return new HalleyLifeTable(59, 10, 252, "0.96031746031746");
                yield return new HalleyLifeTable(60, 10, 242, "0.958677685950413");
                yield return new HalleyLifeTable(61, 10, 232, "0.956896551724138");
                yield return new HalleyLifeTable(62, 10, 222, "0.954954954954955");
                yield return new HalleyLifeTable(63, 10, 212, "0.952830188679245");
                yield return new HalleyLifeTable(64, 10, 202, "0.95049504950495");
                yield return new HalleyLifeTable(65, 10, 192, "0.947916666666667");
                yield return new HalleyLifeTable(66, 10, 182, "0.945054945054945");
                yield return new HalleyLifeTable(67, 10, 172, "0.941860465116279");
                yield return new HalleyLifeTable(68, 10, 162, "0.938271604938272");
                yield return new HalleyLifeTable(69, 10, 152, "0.934210526315789");
                yield return new HalleyLifeTable(70, 10, 142, "0.922535211267606");
                yield return new HalleyLifeTable(71, 11, 131, "0.916030534351145");
                yield return new HalleyLifeTable(72, 11, 120, "0.908333333333333");
                yield return new HalleyLifeTable(73, 11, 109, "0.899082568807339");
                yield return new HalleyLifeTable(74, 11, 98, "0.897959183673469");
                yield return new HalleyLifeTable(75, 10, 88, "0.886363636363636");
                yield return new HalleyLifeTable(76, 10, 78, "0.871794871794872");
                yield return new HalleyLifeTable(77, 10, 68, "0.852941176470588");
                yield return new HalleyLifeTable(78, 10, 58, "0.862068965517241");
                yield return new HalleyLifeTable(79, 8, 50, "0.82");
                yield return new HalleyLifeTable(80, 9, 41, "0.829268292682927");
                yield return new HalleyLifeTable(81, 7, 34, "0.823529411764706");
                yield return new HalleyLifeTable(82, 6, 28, "0.821428571428571");
                yield return new HalleyLifeTable(83, 5, 23, "0.869565217391304");
                yield return new HalleyLifeTable(84, 3, 20, null);
            }
        }
    }
}
