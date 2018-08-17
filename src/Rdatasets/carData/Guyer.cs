// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Anonymity and Cooperation
    /// </summary>

    public class Guyer
    {
        public readonly int cooperation;
        public readonly string condition;
        public readonly string sex;

        public Guyer(int cooperation, string condition, string sex)
        {
            this.cooperation = cooperation;
            this.condition = condition;
            this.sex = sex;
        }

        public static IEnumerable<Guyer> Data
        {
            get
            {
                yield return new Guyer(49, "public", "male");
                yield return new Guyer(64, "public", "male");
                yield return new Guyer(37, "public", "male");
                yield return new Guyer(52, "public", "male");
                yield return new Guyer(68, "public", "male");
                yield return new Guyer(54, "public", "female");
                yield return new Guyer(61, "public", "female");
                yield return new Guyer(79, "public", "female");
                yield return new Guyer(64, "public", "female");
                yield return new Guyer(29, "public", "female");
                yield return new Guyer(27, "anonymous", "male");
                yield return new Guyer(58, "anonymous", "male");
                yield return new Guyer(52, "anonymous", "male");
                yield return new Guyer(41, "anonymous", "male");
                yield return new Guyer(30, "anonymous", "male");
                yield return new Guyer(40, "anonymous", "female");
                yield return new Guyer(39, "anonymous", "female");
                yield return new Guyer(44, "anonymous", "female");
                yield return new Guyer(34, "anonymous", "female");
                yield return new Guyer(44, "anonymous", "female");
            }
        }
    }
}
