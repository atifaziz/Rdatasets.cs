// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Gain in Weight of Rats
    /// </summary>

    public class weightgain
    {
        public readonly string source;
        public readonly string type;
        public readonly int weightgain_;

        public weightgain(string source, string type, int weightgain_)
        {
            this.source = source;
            this.type = type;
            this.weightgain_ = weightgain_;
        }

        public static IEnumerable<weightgain> Data
        {
            get
            {
                yield return new weightgain("Beef", "Low", 90);
                yield return new weightgain("Beef", "Low", 76);
                yield return new weightgain("Beef", "Low", 90);
                yield return new weightgain("Beef", "Low", 64);
                yield return new weightgain("Beef", "Low", 86);
                yield return new weightgain("Beef", "Low", 51);
                yield return new weightgain("Beef", "Low", 72);
                yield return new weightgain("Beef", "Low", 90);
                yield return new weightgain("Beef", "Low", 95);
                yield return new weightgain("Beef", "Low", 78);
                yield return new weightgain("Beef", "High", 73);
                yield return new weightgain("Beef", "High", 102);
                yield return new weightgain("Beef", "High", 118);
                yield return new weightgain("Beef", "High", 104);
                yield return new weightgain("Beef", "High", 81);
                yield return new weightgain("Beef", "High", 107);
                yield return new weightgain("Beef", "High", 100);
                yield return new weightgain("Beef", "High", 87);
                yield return new weightgain("Beef", "High", 117);
                yield return new weightgain("Beef", "High", 111);
                yield return new weightgain("Cereal", "Low", 107);
                yield return new weightgain("Cereal", "Low", 95);
                yield return new weightgain("Cereal", "Low", 97);
                yield return new weightgain("Cereal", "Low", 80);
                yield return new weightgain("Cereal", "Low", 98);
                yield return new weightgain("Cereal", "Low", 74);
                yield return new weightgain("Cereal", "Low", 74);
                yield return new weightgain("Cereal", "Low", 67);
                yield return new weightgain("Cereal", "Low", 89);
                yield return new weightgain("Cereal", "Low", 58);
                yield return new weightgain("Cereal", "High", 98);
                yield return new weightgain("Cereal", "High", 74);
                yield return new weightgain("Cereal", "High", 56);
                yield return new weightgain("Cereal", "High", 111);
                yield return new weightgain("Cereal", "High", 95);
                yield return new weightgain("Cereal", "High", 88);
                yield return new weightgain("Cereal", "High", 82);
                yield return new weightgain("Cereal", "High", 77);
                yield return new weightgain("Cereal", "High", 86);
                yield return new weightgain("Cereal", "High", 92);
            }
        }
    }
}
