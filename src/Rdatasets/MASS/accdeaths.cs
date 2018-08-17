// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Accidental Deaths in the US 1973-1978
    /// </summary>

    public class accdeaths
    {
        public readonly double time;
        public readonly int value;

        public accdeaths(double time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<accdeaths> Data
        {
            get
            {
                yield return new accdeaths(1973, 9007);
                yield return new accdeaths(1973.08333333333, 8106);
                yield return new accdeaths(1973.16666666667, 8928);
                yield return new accdeaths(1973.25, 9137);
                yield return new accdeaths(1973.33333333333, 10017);
                yield return new accdeaths(1973.41666666667, 10826);
                yield return new accdeaths(1973.5, 11317);
                yield return new accdeaths(1973.58333333333, 10744);
                yield return new accdeaths(1973.66666666667, 9713);
                yield return new accdeaths(1973.75, 9938);
                yield return new accdeaths(1973.83333333333, 9161);
                yield return new accdeaths(1973.91666666667, 8927);
                yield return new accdeaths(1974, 7750);
                yield return new accdeaths(1974.08333333333, 6981);
                yield return new accdeaths(1974.16666666667, 8038);
                yield return new accdeaths(1974.25, 8422);
                yield return new accdeaths(1974.33333333333, 8714);
                yield return new accdeaths(1974.41666666667, 9512);
                yield return new accdeaths(1974.5, 10120);
                yield return new accdeaths(1974.58333333333, 9823);
                yield return new accdeaths(1974.66666666667, 8743);
                yield return new accdeaths(1974.75, 9129);
                yield return new accdeaths(1974.83333333333, 8710);
                yield return new accdeaths(1974.91666666667, 8680);
                yield return new accdeaths(1975, 8162);
                yield return new accdeaths(1975.08333333333, 7306);
                yield return new accdeaths(1975.16666666667, 8124);
                yield return new accdeaths(1975.25, 7870);
                yield return new accdeaths(1975.33333333333, 9387);
                yield return new accdeaths(1975.41666666667, 9556);
                yield return new accdeaths(1975.5, 10093);
                yield return new accdeaths(1975.58333333333, 9620);
                yield return new accdeaths(1975.66666666667, 8285);
                yield return new accdeaths(1975.75, 8466);
                yield return new accdeaths(1975.83333333333, 8160);
                yield return new accdeaths(1975.91666666667, 8034);
                yield return new accdeaths(1976, 7717);
                yield return new accdeaths(1976.08333333333, 7461);
                yield return new accdeaths(1976.16666666667, 7767);
                yield return new accdeaths(1976.25, 7925);
                yield return new accdeaths(1976.33333333333, 8623);
                yield return new accdeaths(1976.41666666667, 8945);
                yield return new accdeaths(1976.5, 10078);
                yield return new accdeaths(1976.58333333333, 9179);
                yield return new accdeaths(1976.66666666667, 8037);
                yield return new accdeaths(1976.75, 8488);
                yield return new accdeaths(1976.83333333333, 7874);
                yield return new accdeaths(1976.91666666667, 8647);
                yield return new accdeaths(1977, 7792);
                yield return new accdeaths(1977.08333333333, 6957);
                yield return new accdeaths(1977.16666666667, 7726);
                yield return new accdeaths(1977.25, 8106);
                yield return new accdeaths(1977.33333333333, 8890);
                yield return new accdeaths(1977.41666666667, 9299);
                yield return new accdeaths(1977.5, 10625);
                yield return new accdeaths(1977.58333333333, 9302);
                yield return new accdeaths(1977.66666666667, 8314);
                yield return new accdeaths(1977.75, 8850);
                yield return new accdeaths(1977.83333333333, 8265);
                yield return new accdeaths(1977.91666666667, 8796);
                yield return new accdeaths(1978, 7836);
                yield return new accdeaths(1978.08333333333, 6892);
                yield return new accdeaths(1978.16666666667, 7791);
                yield return new accdeaths(1978.25, 8192);
                yield return new accdeaths(1978.33333333333, 9115);
                yield return new accdeaths(1978.41666666667, 9434);
                yield return new accdeaths(1978.5, 10484);
                yield return new accdeaths(1978.58333333333, 9827);
                yield return new accdeaths(1978.66666666667, 9110);
                yield return new accdeaths(1978.75, 9070);
                yield return new accdeaths(1978.83333333333, 8633);
                yield return new accdeaths(1978.91666666667, 9240);
            }
        }
    }
}
