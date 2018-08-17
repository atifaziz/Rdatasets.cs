// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// titanicgrp
    /// </summary>

    public class titanicgrp
    {
        public readonly int survive;
        public readonly int cases;
        public readonly int age;
        public readonly int sex;
        public readonly int @class;

        public titanicgrp(int survive, int cases, int age, int sex, int @class)
        {
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
                yield return new titanicgrp(1, 1, 0, 0, 1);
                yield return new titanicgrp(13, 13, 0, 0, 2);
                yield return new titanicgrp(14, 31, 0, 0, 3);
                yield return new titanicgrp(5, 5, 0, 1, 1);
                yield return new titanicgrp(11, 11, 0, 1, 2);
                yield return new titanicgrp(13, 48, 0, 1, 3);
                yield return new titanicgrp(140, 144, 1, 0, 1);
                yield return new titanicgrp(80, 93, 1, 0, 2);
                yield return new titanicgrp(76, 165, 1, 0, 3);
                yield return new titanicgrp(57, 175, 1, 1, 1);
                yield return new titanicgrp(14, 168, 1, 1, 2);
                yield return new titanicgrp(75, 462, 1, 1, 3);
            }
        }
    }
}
