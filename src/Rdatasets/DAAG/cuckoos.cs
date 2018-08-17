// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Cuckoo Eggs Data
    /// </summary>

    public class cuckoos
    {
        public readonly double length;
        public readonly double breadth;
        public readonly string species;
        public readonly int id;

        public cuckoos(double length, double breadth, string species, int id)
        {
            this.length = length;
            this.breadth = breadth;
            this.species = species;
            this.id = id;
        }

        public static IEnumerable<cuckoos> Data
        {
            get
            {
                yield return new cuckoos(21.7, 16.1, "meadow.pipit", 21);
                yield return new cuckoos(22.6, 17, "meadow.pipit", 22);
                yield return new cuckoos(20.9, 16.2, "meadow.pipit", 23);
                yield return new cuckoos(21.6, 16.2, "meadow.pipit", 24);
                yield return new cuckoos(22.2, 16.9, "meadow.pipit", 25);
                yield return new cuckoos(22.5, 16.9, "meadow.pipit", 26);
                yield return new cuckoos(22.2, 17.3, "meadow.pipit", 27);
                yield return new cuckoos(24.3, 16.8, "meadow.pipit", 28);
                yield return new cuckoos(22.3, 16.8, "meadow.pipit", 29);
                yield return new cuckoos(22.6, 17, "meadow.pipit", 30);
                yield return new cuckoos(20.1, 16.5, "meadow.pipit", 31);
                yield return new cuckoos(22, 16.9, "meadow.pipit", 32);
                yield return new cuckoos(22.8, 16.5, "meadow.pipit", 33);
                yield return new cuckoos(22, 17, "meadow.pipit", 34);
                yield return new cuckoos(22.4, 17, "meadow.pipit", 35);
                yield return new cuckoos(22.3, 16.3, "meadow.pipit", 36);
                yield return new cuckoos(20.6, 16.2, "meadow.pipit", 37);
                yield return new cuckoos(22.1, 16.8, "meadow.pipit", 38);
                yield return new cuckoos(21.9, 17, "meadow.pipit", 39);
                yield return new cuckoos(23, 16.9, "meadow.pipit", 40);
                yield return new cuckoos(22, 17, "meadow.pipit", 41);
                yield return new cuckoos(22, 17, "meadow.pipit", 42);
                yield return new cuckoos(22.1, 17.3, "meadow.pipit", 43);
                yield return new cuckoos(22, 16.8, "meadow.pipit", 44);
                yield return new cuckoos(19.6, 15.8, "meadow.pipit", 45);
                yield return new cuckoos(22.8, 17.1, "meadow.pipit", 46);
                yield return new cuckoos(22, 16.9, "meadow.pipit", 47);
                yield return new cuckoos(23.4, 16.4, "meadow.pipit", 48);
                yield return new cuckoos(23.8, 16.4, "meadow.pipit", 49);
                yield return new cuckoos(23.3, 16.8, "meadow.pipit", 50);
                yield return new cuckoos(22.5, 17.1, "meadow.pipit", 51);
                yield return new cuckoos(22.3, 17, "meadow.pipit", 52);
                yield return new cuckoos(21.9, 17.1, "meadow.pipit", 53);
                yield return new cuckoos(22, 17.2, "meadow.pipit", 54);
                yield return new cuckoos(21.7, 16.2, "meadow.pipit", 55);
                yield return new cuckoos(23.3, 16.7, "meadow.pipit", 56);
                yield return new cuckoos(22.2, 16.8, "meadow.pipit", 57);
                yield return new cuckoos(22.3, 16.2, "meadow.pipit", 58);
                yield return new cuckoos(22.8, 16.4, "meadow.pipit", 59);
                yield return new cuckoos(22.9, 17.2, "meadow.pipit", 60);
                yield return new cuckoos(23.7, 17, "meadow.pipit", 61);
                yield return new cuckoos(22, 17.2, "meadow.pipit", 62);
                yield return new cuckoos(21.9, 17, "meadow.pipit", 63);
                yield return new cuckoos(22.2, 16.2, "meadow.pipit", 64);
                yield return new cuckoos(24.4, 16.2, "meadow.pipit", 65);
                yield return new cuckoos(22.7, 16.3, "tree.pipit", 66);
                yield return new cuckoos(23.3, 16.6, "tree.pipit", 67);
                yield return new cuckoos(24, 17, "tree.pipit", 68);
                yield return new cuckoos(23.6, 16.9, "tree.pipit", 69);
                yield return new cuckoos(22.1, 16.3, "tree.pipit", 70);
                yield return new cuckoos(21.8, 16.7, "tree.pipit", 71);
                yield return new cuckoos(21.1, 16.5, "tree.pipit", 72);
                yield return new cuckoos(23.4, 16.2, "tree.pipit", 73);
                yield return new cuckoos(23.8, 16.3, "tree.pipit", 74);
                yield return new cuckoos(23.3, 16.7, "tree.pipit", 75);
                yield return new cuckoos(24, 17.5, "tree.pipit", 76);
                yield return new cuckoos(23.5, 17.3, "tree.pipit", 77);
                yield return new cuckoos(23.2, 16.4, "tree.pipit", 78);
                yield return new cuckoos(24, 17.3, "tree.pipit", 79);
                yield return new cuckoos(22.4, 16, "tree.pipit", 80);
                yield return new cuckoos(22, 17, "hedge.sparrow", 82);
                yield return new cuckoos(23.9, 16.9, "hedge.sparrow", 83);
                yield return new cuckoos(20.9, 15.8, "hedge.sparrow", 84);
                yield return new cuckoos(23.8, 17.3, "hedge.sparrow", 85);
                yield return new cuckoos(25, 17.5, "hedge.sparrow", 86);
                yield return new cuckoos(24, 17.5, "hedge.sparrow", 87);
                yield return new cuckoos(21.7, 16.2, "hedge.sparrow", 88);
                yield return new cuckoos(23.8, 16.5, "hedge.sparrow", 89);
                yield return new cuckoos(22.8, 16.2, "hedge.sparrow", 90);
                yield return new cuckoos(23.1, 17.1, "hedge.sparrow", 91);
                yield return new cuckoos(23.1, 16.1, "hedge.sparrow", 92);
                yield return new cuckoos(23.5, 16.9, "hedge.sparrow", 93);
                yield return new cuckoos(23, 16.7, "hedge.sparrow", 94);
                yield return new cuckoos(23, 17, "hedge.sparrow", 95);
                yield return new cuckoos(21.8, 16, "robin", 96);
                yield return new cuckoos(23, 15.9, "robin", 97);
                yield return new cuckoos(23.3, 17.1, "robin", 98);
                yield return new cuckoos(22.4, 16.6, "robin", 99);
                yield return new cuckoos(22.4, 16.9, "robin", 100);
                yield return new cuckoos(23, 16.1, "robin", 101);
                yield return new cuckoos(23, 17.2, "robin", 102);
                yield return new cuckoos(23, 16.2, "robin", 103);
                yield return new cuckoos(23.9, 16.9, "robin", 104);
                yield return new cuckoos(22.3, 15.2, "robin", 105);
                yield return new cuckoos(22, 16.3, "robin", 106);
                yield return new cuckoos(22.6, 17, "robin", 107);
                yield return new cuckoos(22, 16, "robin", 108);
                yield return new cuckoos(22.1, 16.4, "robin", 109);
                yield return new cuckoos(21.1, 16.4, "robin", 110);
                yield return new cuckoos(23, 17, "robin", 111);
                yield return new cuckoos(23, 16.3, "pied.wagtail", 198);
                yield return new cuckoos(23.4, 16.7, "pied.wagtail", 199);
                yield return new cuckoos(24, 17, "pied.wagtail", 200);
                yield return new cuckoos(23.3, 16.3, "pied.wagtail", 201);
                yield return new cuckoos(23.1, 16.7, "pied.wagtail", 202);
                yield return new cuckoos(22.4, 16.5, "pied.wagtail", 203);
                yield return new cuckoos(21.8, 16, "pied.wagtail", 204);
                yield return new cuckoos(21.8, 16, "pied.wagtail", 205);
                yield return new cuckoos(24.9, 16.8, "pied.wagtail", 206);
                yield return new cuckoos(24, 15.8, "pied.wagtail", 207);
                yield return new cuckoos(22.1, 16.2, "pied.wagtail", 208);
                yield return new cuckoos(21, 17.1, "pied.wagtail", 209);
                yield return new cuckoos(22.6, 16, "pied.wagtail", 210);
                yield return new cuckoos(21.9, 16.9, "pied.wagtail", 211);
                yield return new cuckoos(24, 17.2, "pied.wagtail", 212);
                yield return new cuckoos(19.8, 15, "wren", 224);
                yield return new cuckoos(22.1, 16, "wren", 225);
                yield return new cuckoos(21.5, 16.2, "wren", 226);
                yield return new cuckoos(20.9, 15.7, "wren", 227);
                yield return new cuckoos(22, 16.2, "wren", 228);
                yield return new cuckoos(21, 15.5, "wren", 229);
                yield return new cuckoos(22.3, 16, "wren", 230);
                yield return new cuckoos(21, 15.9, "wren", 231);
                yield return new cuckoos(20.3, 15.5, "wren", 232);
                yield return new cuckoos(20.9, 15.9, "wren", 233);
                yield return new cuckoos(22, 16, "wren", 234);
                yield return new cuckoos(20, 15.7, "wren", 235);
                yield return new cuckoos(20.8, 15.9, "wren", 236);
                yield return new cuckoos(21.2, 16, "wren", 237);
                yield return new cuckoos(21, 16, "wren", 238);
            }
        }
    }
}
