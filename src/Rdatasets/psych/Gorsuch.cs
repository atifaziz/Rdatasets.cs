// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Example data set from Gorsuch (1997) for an example factor extension.
    /// </summary>

    public class Gorsuch
    {
        public readonly string κ;
        public readonly double info;
        public readonly double verbal;
        public readonly double analogies;
        public readonly double ego;
        public readonly double guilt;
        public readonly double tension;
        public readonly double info2;
        public readonly double tension2;
        public readonly double v123;
        public readonly double v564;

        public Gorsuch(string κ, double info, double verbal, double analogies, double ego, double guilt, double tension, double info2, double tension2, double v123, double v564)
        {
            this.κ = κ;
            this.info = info;
            this.verbal = verbal;
            this.analogies = analogies;
            this.ego = ego;
            this.guilt = guilt;
            this.tension = tension;
            this.info2 = info2;
            this.tension2 = tension2;
            this.v123 = v123;
            this.v564 = v564;
        }

        public static IEnumerable<Gorsuch> Data
        {
            get
            {
                yield return new Gorsuch("info", 1, 0.67, 0.43, 0.11, -0.07, -0.17, 1, -0.17, 0.84, -0.15);
                yield return new Gorsuch("verbal", 0.67, 1, 0.49, 0.12, -0.05, -0.14, 0.67, -0.14, 0.87, -0.13);
                yield return new Gorsuch("analogies", 0.43, 0.49, 1, 0.03, -0.14, -0.1, 0.43, -0.1, 0.77, -0.12);
                yield return new Gorsuch("ego", 0.11, 0.12, 0.03, 1, -0.41, -0.48, 0.11, -0.48, 0.1, -0.8);
                yield return new Gorsuch("guilt", -0.07, -0.05, -0.14, -0.41, 1, 0.4, -0.07, 0.4, -0.1, 0.77);
                yield return new Gorsuch("tension", -0.17, -0.14, -0.1, -0.48, 0.4, 1, -0.17, 1, -0.16, 0.8);
                yield return new Gorsuch("info2", 1, 0.67, 0.43, 0.11, -0.07, -0.17, 1, -0.17, 0.84, -0.15);
                yield return new Gorsuch("tension2", -0.17, -0.14, -0.1, -0.48, 0.4, 1, -0.17, 1, -0.17, 0.8);
                yield return new Gorsuch("v123", 0.84, 0.87, 0.77, 0.1, -0.1, -0.16, 0.84, -0.17, 1, -0.16);
                yield return new Gorsuch("v564", -0.15, -0.13, -0.12, -0.8, 0.77, 0.8, -0.15, 0.8, -0.16, 1);
            }
        }
    }
}
