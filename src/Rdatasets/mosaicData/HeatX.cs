// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a heat exchanger laboratory
    /// </summary>

    public class HeatX
    {
        public readonly int κ;
        public readonly int trial;
        public readonly double T_cold_in;
        public readonly double T_cold_out;
        public readonly double T_hot_in;
        public readonly double T_hot_out;
        public readonly double m_cold;
        public readonly int m_hot;

        public HeatX(int κ, int trial, double T_cold_in, double T_cold_out, double T_hot_in, double T_hot_out, double m_cold, int m_hot)
        {
            this.κ = κ;
            this.trial = trial;
            this.T_cold_in = T_cold_in;
            this.T_cold_out = T_cold_out;
            this.T_hot_in = T_hot_in;
            this.T_hot_out = T_hot_out;
            this.m_cold = m_cold;
            this.m_hot = m_hot;
        }

        public static IEnumerable<HeatX> Data
        {
            get
            {
                yield return new HeatX(1, 1, 14.3, 18.6, 38.2, 33.9, 10, 10);
                yield return new HeatX(2, 2, 14.1, 18.7, 35.9, 32.8, 7.5, 10);
                yield return new HeatX(3, 3, 14.1, 19.4, 35.9, 33.4, 5, 10);
                yield return new HeatX(4, 4, 14.2, 18.4, 35.8, 31.8, 5, 5);
                yield return new HeatX(5, 5, 14.1, 17.4, 35.7, 30.9, 7.5, 5);
                yield return new HeatX(6, 6, 14.1, 16.9, 35.8, 30.4, 10, 5);
            }
        }
    }
}
