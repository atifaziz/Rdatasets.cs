// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Political knowledge in the US and Europe
    /// </summary>

    public class politicalKnowledge
    {
        public readonly int κ;
        public readonly string country;
        public readonly double DomesticKnowledge_hs;
        public readonly double DomesticKnowledge_sc;
        public readonly double DomesticKnowledge_c;
        public readonly double InternationalKnowledge_hs;
        public readonly double InternationalKnowledge_sc;
        public readonly double InternationalKnowledge_c;
        public readonly double PoliticalKnowledge_hs;
        public readonly double PoliticalKnowledge_sc;
        public readonly double PoliticalKnowledge_c;
        public readonly double PublicMediaPerCapita;
        public readonly double PublicMediaRel2US;

        public politicalKnowledge(int κ, string country, double DomesticKnowledge_hs, double DomesticKnowledge_sc, double DomesticKnowledge_c, double InternationalKnowledge_hs, double InternationalKnowledge_sc, double InternationalKnowledge_c, double PoliticalKnowledge_hs, double PoliticalKnowledge_sc, double PoliticalKnowledge_c, double PublicMediaPerCapita, double PublicMediaRel2US)
        {
            this.κ = κ;
            this.country = country;
            this.DomesticKnowledge_hs = DomesticKnowledge_hs;
            this.DomesticKnowledge_sc = DomesticKnowledge_sc;
            this.DomesticKnowledge_c = DomesticKnowledge_c;
            this.InternationalKnowledge_hs = InternationalKnowledge_hs;
            this.InternationalKnowledge_sc = InternationalKnowledge_sc;
            this.InternationalKnowledge_c = InternationalKnowledge_c;
            this.PoliticalKnowledge_hs = PoliticalKnowledge_hs;
            this.PoliticalKnowledge_sc = PoliticalKnowledge_sc;
            this.PoliticalKnowledge_c = PoliticalKnowledge_c;
            this.PublicMediaPerCapita = PublicMediaPerCapita;
            this.PublicMediaRel2US = PublicMediaRel2US;
        }

        public static IEnumerable<politicalKnowledge> Data
        {
            get
            {
                yield return new politicalKnowledge(1, "Denmark", 0.77, 0.79, 0.77, 0.65, 0.67, 0.65, 0.71, 0.73, 0.71, 101, 74.81);
                yield return new politicalKnowledge(2, "Finland", 0.74, 0.75, 0.85, 0.56, 0.69, 0.7, 0.65, 0.72, 0.775, 101, 74.81);
                yield return new politicalKnowledge(3, "UK", 0.62, 0.65, 0.72, 0.52, 0.54, 0.68, 0.57, 0.595, 0.7, 80, 59.26);
                yield return new politicalKnowledge(4, "US", 0.4, 0.61, 0.77, 0.22, 0.42, 0.65, 0.31, 0.515, 0.71, 1.35, 1);
            }
        }
    }
}
