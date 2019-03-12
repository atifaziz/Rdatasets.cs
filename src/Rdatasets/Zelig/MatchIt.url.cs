// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Table of links for Zelig
    /// </summary>

    public class MatchIt_url
    {
        public readonly int κ;
        public readonly string MatchIt;
        public readonly string http___gking_harvard_edu_matchit;

        public MatchIt_url(int κ, string MatchIt, string http___gking_harvard_edu_matchit)
        {
            this.κ = κ;
            this.MatchIt = MatchIt;
            this.http___gking_harvard_edu_matchit = http___gking_harvard_edu_matchit;
        }

        public static IEnumerable<MatchIt_url> Data
        {
            get
            {
                yield return new MatchIt_url(1, "matchit", "http://gking.harvard.edu/matchit/docs/_TT_matchit_TT__Implem.html");
                yield return new MatchIt_url(2, "match.data", "http://gking.harvard.edu/matchit/docs/_TT_match_data_TT__Ext.html");
            }
        }
    }
}
