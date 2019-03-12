// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Gain in Weight of Rats
    /// </summary>

    public class weightgain
    {
        public readonly int κ;
        public readonly string source;
        public readonly string type;
        public readonly int weightgain_;

        public weightgain(int κ, string source, string type, int weightgain_)
        {
            this.κ = κ;
            this.source = source;
            this.type = type;
            this.weightgain_ = weightgain_;
        }

        public static IEnumerable<weightgain> Data
        {
            get
            {
                yield return new weightgain(1, "Beef", "Low", 90);
                yield return new weightgain(2, "Beef", "Low", 76);
                yield return new weightgain(3, "Beef", "Low", 90);
                yield return new weightgain(4, "Beef", "Low", 64);
                yield return new weightgain(5, "Beef", "Low", 86);
                yield return new weightgain(6, "Beef", "Low", 51);
                yield return new weightgain(7, "Beef", "Low", 72);
                yield return new weightgain(8, "Beef", "Low", 90);
                yield return new weightgain(9, "Beef", "Low", 95);
                yield return new weightgain(10, "Beef", "Low", 78);
                yield return new weightgain(11, "Beef", "High", 73);
                yield return new weightgain(12, "Beef", "High", 102);
                yield return new weightgain(13, "Beef", "High", 118);
                yield return new weightgain(14, "Beef", "High", 104);
                yield return new weightgain(15, "Beef", "High", 81);
                yield return new weightgain(16, "Beef", "High", 107);
                yield return new weightgain(17, "Beef", "High", 100);
                yield return new weightgain(18, "Beef", "High", 87);
                yield return new weightgain(19, "Beef", "High", 117);
                yield return new weightgain(20, "Beef", "High", 111);
                yield return new weightgain(21, "Cereal", "Low", 107);
                yield return new weightgain(22, "Cereal", "Low", 95);
                yield return new weightgain(23, "Cereal", "Low", 97);
                yield return new weightgain(24, "Cereal", "Low", 80);
                yield return new weightgain(25, "Cereal", "Low", 98);
                yield return new weightgain(26, "Cereal", "Low", 74);
                yield return new weightgain(27, "Cereal", "Low", 74);
                yield return new weightgain(28, "Cereal", "Low", 67);
                yield return new weightgain(29, "Cereal", "Low", 89);
                yield return new weightgain(30, "Cereal", "Low", 58);
                yield return new weightgain(31, "Cereal", "High", 98);
                yield return new weightgain(32, "Cereal", "High", 74);
                yield return new weightgain(33, "Cereal", "High", 56);
                yield return new weightgain(34, "Cereal", "High", 111);
                yield return new weightgain(35, "Cereal", "High", 95);
                yield return new weightgain(36, "Cereal", "High", 88);
                yield return new weightgain(37, "Cereal", "High", 82);
                yield return new weightgain(38, "Cereal", "High", 77);
                yield return new weightgain(39, "Cereal", "High", 86);
                yield return new weightgain(40, "Cereal", "High", 92);
            }
        }
    }
}
