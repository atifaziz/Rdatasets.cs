// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Comparison of cuckoo eggs with host eggs
    /// </summary>

    public class cuckoohosts
    {
        public readonly double clength;
        public readonly double cl_sd;
        public readonly double cbreadth;
        public readonly double cb_sd;
        public readonly int cnum;
        public readonly double? hlength;
        public readonly double? hl_sd;
        public readonly double? hbreadth;
        public readonly double? hb_sd;
        public readonly int? hnum;
        public readonly int match;
        public readonly int nomatch;

        public cuckoohosts(double clength, double cl_sd, double cbreadth, double cb_sd, int cnum, double? hlength, double? hl_sd, double? hbreadth, double? hb_sd, int? hnum, int match, int nomatch)
        {
            this.clength = clength;
            this.cl_sd = cl_sd;
            this.cbreadth = cbreadth;
            this.cb_sd = cb_sd;
            this.cnum = cnum;
            this.hlength = hlength;
            this.hl_sd = hl_sd;
            this.hbreadth = hbreadth;
            this.hb_sd = hb_sd;
            this.hnum = hnum;
            this.match = match;
            this.nomatch = nomatch;
        }

        public static IEnumerable<cuckoohosts> Data
        {
            get
            {
                yield return new cuckoohosts(22.3, 0.89, 16.7, 0.38, 45, 19.7, 1.25, 14.6, 0.56, 74, 56, 6);
                yield return new cuckoohosts(23.1, 1.01, 16.8, 0.52, 14, 20.1, 0.81, 14.7, 14.7, 26, 1, 19);
                yield return new cuckoohosts(22.5, 0.66, 16.4, 0.53, 16, 20.2, 0.86, 15.4, 15.4, 57, 7, 11);
                yield return new cuckoohosts(22.6, 0.9, 16.6, 0.45, 26, 20.75, 1.44, 14.67, 0.37, 16, 26, 3);
                yield return new cuckoohosts(23.1, 0.85, 16.6, 0.44, 15, 20, 0.7, 15.1, 0.48, 27, 11, 4);
                yield return new cuckoohosts(21.1, 0.76, 15.8, 0.3, 15, 17.7, 17.7, 12.7, 0.37, null, 0, 17);
                yield return new cuckoohosts(22.2, 0.65, 16.7, 0.57, 10, null, null, null, 0.45, null, 7, 13);
                yield return new cuckoohosts(22.6, 0.74, 16.6, 0.48, 9, 21.55, 0.68, 16.04, 0.4, 32, 0, 12);
                yield return new cuckoohosts(23.05, 0.13, 16.5, 0.48, 4, null, null, null, null, null, 4, 4);
                yield return new cuckoohosts(22.9, 1.26, 16.6, 0.87, 4, null, null, null, null, null, 1, 7);
            }
        }
    }
}
