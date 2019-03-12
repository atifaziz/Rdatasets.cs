// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Colours of Eyes and Hair of People in Caithness
    /// </summary>

    public class caith
    {
        public readonly string κ;
        public readonly int fair;
        public readonly int red;
        public readonly int medium;
        public readonly int dark;
        public readonly int black;

        public caith(string κ, int fair, int red, int medium, int dark, int black)
        {
            this.κ = κ;
            this.fair = fair;
            this.red = red;
            this.medium = medium;
            this.dark = dark;
            this.black = black;
        }

        public static IEnumerable<caith> Data
        {
            get
            {
                yield return new caith("blue", 326, 38, 241, 110, 3);
                yield return new caith("light", 688, 116, 584, 188, 4);
                yield return new caith("medium", 343, 84, 909, 412, 26);
                yield return new caith("dark", 98, 48, 403, 681, 85);
            }
        }
    }
}
