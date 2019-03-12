// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Birth and Death Rates Data
    /// </summary>

    public class birthdeathrates
    {
        public readonly string κ;
        public readonly double birth;
        public readonly double death;

        public birthdeathrates(string κ, double birth, double death)
        {
            this.κ = κ;
            this.birth = birth;
            this.death = death;
        }

        public static IEnumerable<birthdeathrates> Data
        {
            get
            {
                yield return new birthdeathrates("alg", 36.4, 14.6);
                yield return new birthdeathrates("con", 37.3, 8);
                yield return new birthdeathrates("egy", 42.1, 15.3);
                yield return new birthdeathrates("gha", 55.8, 25.6);
                yield return new birthdeathrates("ict", 56.1, 33.1);
                yield return new birthdeathrates("mag", 41.8, 15.8);
                yield return new birthdeathrates("mor", 46.1, 18.7);
                yield return new birthdeathrates("tun", 41.7, 10.1);
                yield return new birthdeathrates("cam", 41.4, 19.7);
                yield return new birthdeathrates("cey", 35.8, 8.5);
                yield return new birthdeathrates("chi", 34, 11);
                yield return new birthdeathrates("tai", 36.3, 6.1);
                yield return new birthdeathrates("hkg", 32.1, 5.5);
                yield return new birthdeathrates("ind", 20.9, 8.8);
                yield return new birthdeathrates("ids", 27.7, 10.2);
                yield return new birthdeathrates("irq", 20.5, 3.9);
                yield return new birthdeathrates("isr", 25, 6.2);
                yield return new birthdeathrates("jap", 17.3, 7);
                yield return new birthdeathrates("jor", 46.3, 6.4);
                yield return new birthdeathrates("kor", 14.8, 5.7);
                yield return new birthdeathrates("mal", 33.5, 6.4);
                yield return new birthdeathrates("mog", 39.2, 11.2);
                yield return new birthdeathrates("phl", 28.4, 7.1);
                yield return new birthdeathrates("syr", 26.2, 4.3);
                yield return new birthdeathrates("tha", 34.8, 7.9);
                yield return new birthdeathrates("vit", 23.4, 5.1);
                yield return new birthdeathrates("can", 24.8, 7.8);
                yield return new birthdeathrates("cra", 49.9, 8.5);
                yield return new birthdeathrates("dmr", 33, 8.4);
                yield return new birthdeathrates("gut", 47.7, 17.3);
                yield return new birthdeathrates("hon", 46.6, 9.7);
                yield return new birthdeathrates("mex", 45.1, 10.5);
                yield return new birthdeathrates("nic", 42.9, 7.1);
                yield return new birthdeathrates("pan", 40.1, 8);
                yield return new birthdeathrates("usa", 21.7, 9.6);
                yield return new birthdeathrates("arg", 21.8, 8.1);
                yield return new birthdeathrates("bol", 17.4, 5.8);
                yield return new birthdeathrates("bra", 45, 13.5);
                yield return new birthdeathrates("chl", 33.6, 11.8);
                yield return new birthdeathrates("clo", 44, 11.7);
                yield return new birthdeathrates("ecu", 44.2, 13.5);
                yield return new birthdeathrates("per", 27.7, 8.2);
                yield return new birthdeathrates("urg", 22.5, 7.8);
                yield return new birthdeathrates("ven", 42.8, 6.7);
                yield return new birthdeathrates("aus", 18.8, 12.8);
                yield return new birthdeathrates("bel", 17.1, 12.7);
                yield return new birthdeathrates("brt", 18.2, 12.2);
                yield return new birthdeathrates("bul", 16.4, 8.2);
                yield return new birthdeathrates("cze", 16.9, 9.5);
                yield return new birthdeathrates("dem", 17.6, 19.8);
                yield return new birthdeathrates("fin", 18.1, 9.2);
                yield return new birthdeathrates("fra", 18.2, 11.7);
                yield return new birthdeathrates("gmy", 18, 12.5);
                yield return new birthdeathrates("gre", 17.4, 7.8);
                yield return new birthdeathrates("hun", 13.1, 9.9);
                yield return new birthdeathrates("irl", 22.3, 11.9);
                yield return new birthdeathrates("ity", 19, 10.2);
                yield return new birthdeathrates("net", 20.9, 8);
                yield return new birthdeathrates("now", 17.5, 10);
                yield return new birthdeathrates("pol", 19, 7.5);
                yield return new birthdeathrates("pog", 23.5, 10.8);
                yield return new birthdeathrates("rom", 15.7, 8.3);
                yield return new birthdeathrates("spa", 21.5, 9.1);
                yield return new birthdeathrates("swe", 14.8, 10.1);
                yield return new birthdeathrates("swz", 18.9, 9.6);
                yield return new birthdeathrates("rus", 21.2, 7.2);
                yield return new birthdeathrates("yug", 21.4, 8.9);
                yield return new birthdeathrates("ast", 21.6, 8.7);
                yield return new birthdeathrates("nzl", 25.5, 8.8);
            }
        }
    }
}
