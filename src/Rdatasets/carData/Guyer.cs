// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Anonymity and Cooperation
    /// </summary>

    public class Guyer
    {
        public readonly int κ;
        public readonly int cooperation;
        public readonly string condition;
        public readonly string sex;

        public Guyer(int κ, int cooperation, string condition, string sex)
        {
            this.κ = κ;
            this.cooperation = cooperation;
            this.condition = condition;
            this.sex = sex;
        }

        public static IEnumerable<Guyer> Data
        {
            get
            {
                yield return new Guyer(1, 49, "public", "male");
                yield return new Guyer(2, 64, "public", "male");
                yield return new Guyer(3, 37, "public", "male");
                yield return new Guyer(4, 52, "public", "male");
                yield return new Guyer(5, 68, "public", "male");
                yield return new Guyer(6, 54, "public", "female");
                yield return new Guyer(7, 61, "public", "female");
                yield return new Guyer(8, 79, "public", "female");
                yield return new Guyer(9, 64, "public", "female");
                yield return new Guyer(10, 29, "public", "female");
                yield return new Guyer(11, 27, "anonymous", "male");
                yield return new Guyer(12, 58, "anonymous", "male");
                yield return new Guyer(13, 52, "anonymous", "male");
                yield return new Guyer(14, 41, "anonymous", "male");
                yield return new Guyer(15, 30, "anonymous", "male");
                yield return new Guyer(16, 40, "anonymous", "female");
                yield return new Guyer(17, 39, "anonymous", "female");
                yield return new Guyer(18, 44, "anonymous", "female");
                yield return new Guyer(19, 34, "anonymous", "female");
                yield return new Guyer(20, 44, "anonymous", "female");
            }
        }
    }
}
