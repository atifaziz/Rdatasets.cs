// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Moth Eggs
    /// </summary>

    public class MothEggs
    {
        public readonly double BodyMass;
        public readonly int Eggs;

        public MothEggs(double BodyMass, int Eggs)
        {
            this.BodyMass = BodyMass;
            this.Eggs = Eggs;
        }

        public static IEnumerable<MothEggs> Data
        {
            get
            {
                yield return new MothEggs(1.646, 172);
                yield return new MothEggs(2.3, 192);
                yield return new MothEggs(1.73, 159);
                yield return new MothEggs(1.92, 125);
                yield return new MothEggs(1.847, 197);
                yield return new MothEggs(1.477, 135);
                yield return new MothEggs(1.684, 140);
                yield return new MothEggs(1.666, 140);
                yield return new MothEggs(1.345, 138);
                yield return new MothEggs(1.797, 166);
                yield return new MothEggs(1.2, 136);
                yield return new MothEggs(1.744, 131);
                yield return new MothEggs(1.977, 246);
                yield return new MothEggs(1.433, 185);
                yield return new MothEggs(1.849, 240);
                yield return new MothEggs(1.616, 203);
                yield return new MothEggs(1.308, 132);
                yield return new MothEggs(1.154, 143);
                yield return new MothEggs(2.115, 235);
                yield return new MothEggs(1.248, 127);
                yield return new MothEggs(1.862, 160);
                yield return new MothEggs(1.482, 174);
                yield return new MothEggs(1.74, 124);
                yield return new MothEggs(1.733, 165);
                yield return new MothEggs(1.412, 130);
                yield return new MothEggs(1.438, 144);
                yield return new MothEggs(1.785, 212);
                yield return new MothEggs(1.496, 149);
                yield return new MothEggs(1.854, 217);
                yield return new MothEggs(2.287, 271);
                yield return new MothEggs(1.976, 160);
                yield return new MothEggs(1.589, 155);
                yield return new MothEggs(1.495, 108);
                yield return new MothEggs(1.66, 140);
                yield return new MothEggs(1.573, 109);
                yield return new MothEggs(2.013, 74);
                yield return new MothEggs(1.843, 193);
                yield return new MothEggs(1.505, 152);
                yield return new MothEggs(1.668, 0);
            }
        }
    }
}
