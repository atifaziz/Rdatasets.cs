// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth of Orange Trees
    /// </summary>

    public class Orange
    {
        public readonly int κ;
        public readonly int Tree;
        public readonly int age;
        public readonly int circumference;

        public Orange(int κ, int Tree, int age, int circumference)
        {
            this.κ = κ;
            this.Tree = Tree;
            this.age = age;
            this.circumference = circumference;
        }

        public static IEnumerable<Orange> Data
        {
            get
            {
                yield return new Orange(1, 1, 118, 30);
                yield return new Orange(2, 1, 484, 58);
                yield return new Orange(3, 1, 664, 87);
                yield return new Orange(4, 1, 1004, 115);
                yield return new Orange(5, 1, 1231, 120);
                yield return new Orange(6, 1, 1372, 142);
                yield return new Orange(7, 1, 1582, 145);
                yield return new Orange(8, 2, 118, 33);
                yield return new Orange(9, 2, 484, 69);
                yield return new Orange(10, 2, 664, 111);
                yield return new Orange(11, 2, 1004, 156);
                yield return new Orange(12, 2, 1231, 172);
                yield return new Orange(13, 2, 1372, 203);
                yield return new Orange(14, 2, 1582, 203);
                yield return new Orange(15, 3, 118, 30);
                yield return new Orange(16, 3, 484, 51);
                yield return new Orange(17, 3, 664, 75);
                yield return new Orange(18, 3, 1004, 108);
                yield return new Orange(19, 3, 1231, 115);
                yield return new Orange(20, 3, 1372, 139);
                yield return new Orange(21, 3, 1582, 140);
                yield return new Orange(22, 4, 118, 32);
                yield return new Orange(23, 4, 484, 62);
                yield return new Orange(24, 4, 664, 112);
                yield return new Orange(25, 4, 1004, 167);
                yield return new Orange(26, 4, 1231, 179);
                yield return new Orange(27, 4, 1372, 209);
                yield return new Orange(28, 4, 1582, 214);
                yield return new Orange(29, 5, 118, 30);
                yield return new Orange(30, 5, 484, 49);
                yield return new Orange(31, 5, 664, 81);
                yield return new Orange(32, 5, 1004, 125);
                yield return new Orange(33, 5, 1231, 142);
                yield return new Orange(34, 5, 1372, 174);
                yield return new Orange(35, 5, 1582, 177);
            }
        }
    }
}
