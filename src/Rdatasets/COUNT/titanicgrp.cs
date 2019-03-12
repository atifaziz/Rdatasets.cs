// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// titanicgrp
    /// </summary>

    public class titanicgrp
    {
        public readonly int κ;
        public readonly int survive;
        public readonly int cases;
        public readonly int age;
        public readonly int sex;
        public readonly int @class;

        public titanicgrp(int κ, int survive, int cases, int age, int sex, int @class)
        {
            this.κ = κ;
            this.survive = survive;
            this.cases = cases;
            this.age = age;
            this.sex = sex;
            this.@class = @class;
        }

        public static IEnumerable<titanicgrp> Data
        {
            get
            {
                yield return new titanicgrp(1, 1, 1, 0, 0, 1);
                yield return new titanicgrp(2, 13, 13, 0, 0, 2);
                yield return new titanicgrp(3, 14, 31, 0, 0, 3);
                yield return new titanicgrp(4, 5, 5, 0, 1, 1);
                yield return new titanicgrp(5, 11, 11, 0, 1, 2);
                yield return new titanicgrp(6, 13, 48, 0, 1, 3);
                yield return new titanicgrp(7, 140, 144, 1, 0, 1);
                yield return new titanicgrp(8, 80, 93, 1, 0, 2);
                yield return new titanicgrp(9, 76, 165, 1, 0, 3);
                yield return new titanicgrp(10, 57, 175, 1, 1, 1);
                yield return new titanicgrp(11, 14, 168, 1, 1, 2);
                yield return new titanicgrp(12, 75, 462, 1, 1, 3);
            }
        }
    }
}
