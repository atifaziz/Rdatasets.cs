// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Competition between two biotypes
    /// </summary>

    public class RScompetition
    {
        public readonly int z;
        public readonly int x;
        public readonly double biomass;

        public RScompetition(int z, int x, double biomass)
        {
            this.z = z;
            this.x = x;
            this.biomass = biomass;
        }

        public static IEnumerable<RScompetition> Data
        {
            get
            {
                yield return new RScompetition(8, 8, 7.725);
                yield return new RScompetition(8, 16, 3.475);
                yield return new RScompetition(7, 32, 3.86875);
                yield return new RScompetition(8, 61, 1.949180328);
                yield return new RScompetition(16, 8, 3.1);
                yield return new RScompetition(16, 16, 2.9125);
                yield return new RScompetition(16, 64, 1.7984375);
                yield return new RScompetition(32, 8, 3.1875);
                yield return new RScompetition(31, 32, 2.54375);
                yield return new RScompetition(64, 6, 2.7);
                yield return new RScompetition(62, 15, 1.553333333);
                yield return new RScompetition(0, 2, 19.45);
                yield return new RScompetition(0, 8, 12.7875);
                yield return new RScompetition(0, 16, 6.5);
                yield return new RScompetition(0, 32, 4.340625);
                yield return new RScompetition(0, 63, 2.179365079);
                yield return new RScompetition(8, 8, 4.2125);
                yield return new RScompetition(8, 16, 6.29375);
                yield return new RScompetition(8, 32, 3.790625);
                yield return new RScompetition(8, 63, 2.428571429);
                yield return new RScompetition(16, 8, 6.4875);
                yield return new RScompetition(16, 16, 2.51875);
                yield return new RScompetition(16, 64, 2.0453125);
                yield return new RScompetition(32, 7, 3.257142857);
                yield return new RScompetition(32, 32, 1.36875);
                yield return new RScompetition(63, 8, 1.3875);
                yield return new RScompetition(63, 16, 1.7375);
                yield return new RScompetition(0, 2, 15.1);
                yield return new RScompetition(0, 8, 6.2625);
                yield return new RScompetition(0, 16, 2.45625);
                yield return new RScompetition(0, 31, 5.029032258);
                yield return new RScompetition(0, 64, 3.0875);
                yield return new RScompetition(8, 7, 3.785714286);
                yield return new RScompetition(8, 16, 7.45625);
                yield return new RScompetition(8, 32, 3.728125);
                yield return new RScompetition(8, 63, 2.285714286);
                yield return new RScompetition(16, 7, 4.628571429);
                yield return new RScompetition(16, 15, 4.446666667);
                yield return new RScompetition(15, 59, 2.013559322);
                yield return new RScompetition(32, 8, 4.025);
                yield return new RScompetition(32, 32, 2.278125);
                yield return new RScompetition(62, 8, 2.075);
                yield return new RScompetition(63, 16, 2.0875);
                yield return new RScompetition(62, 63, 1.063492063);
                yield return new RScompetition(0, 2, 23.6);
                yield return new RScompetition(0, 7, 12.34285714);
                yield return new RScompetition(0, 16, 9.03125);
                yield return new RScompetition(0, 32, 5.103125);
                yield return new RScompetition(0, 64, 2.3578125);
            }
        }
    }
}
