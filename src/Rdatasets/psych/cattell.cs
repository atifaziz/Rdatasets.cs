// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// 12 cognitive variables from Cattell (1963)
    /// </summary>

    public class cattell
    {
        public readonly string κ;
        public readonly double Verbal;
        public readonly double Verbal2;
        public readonly double Space1;
        public readonly double Space2;
        public readonly double Reason1;
        public readonly double Reason2;
        public readonly double Number1;
        public readonly double Number2;
        public readonly double IPATSer;
        public readonly double IPATCLAS;
        public readonly double IPATMatr;
        public readonly double IPATTOP;

        public cattell(string κ, double Verbal, double Verbal2, double Space1, double Space2, double Reason1, double Reason2, double Number1, double Number2, double IPATSer, double IPATCLAS, double IPATMatr, double IPATTOP)
        {
            this.κ = κ;
            this.Verbal = Verbal;
            this.Verbal2 = Verbal2;
            this.Space1 = Space1;
            this.Space2 = Space2;
            this.Reason1 = Reason1;
            this.Reason2 = Reason2;
            this.Number1 = Number1;
            this.Number2 = Number2;
            this.IPATSer = IPATSer;
            this.IPATCLAS = IPATCLAS;
            this.IPATMatr = IPATMatr;
            this.IPATTOP = IPATTOP;
        }

        public static IEnumerable<cattell> Data
        {
            get
            {
                yield return new cattell("Verbal", 1, 0.86, 0.3, 0.32, 0.41, 0.42, 0.34, 0.32, 0.29, 0.21, 0.33, 0.25);
                yield return new cattell("Verbal2", 0.86, 1, 0.3, 0.27, 0.42, 0.41, 0.37, 0.33, 0.3, 0.23, 0.33, 0.24);
                yield return new cattell("Space1", 0.3, 0.3, 1, 0.79, 0.21, 0.25, 0.23, 0.19, 0.27, 0.29, 0.28, 0.29);
                yield return new cattell("Space2", 0.32, 0.27, 0.79, 1, 0.23, 0.25, 0.16, 0.14, 0.27, 0.31, 0.24, 0.25);
                yield return new cattell("Reason1", 0.41, 0.42, 0.21, 0.23, 1, 0.77, 0.4, 0.43, 0.28, 0.26, 0.35, 0.23);
                yield return new cattell("Reason2", 0.42, 0.41, 0.25, 0.25, 0.77, 1, 0.37, 0.39, 0.24, 0.24, 0.37, 0.22);
                yield return new cattell("Number1", 0.34, 0.37, 0.23, 0.16, 0.4, 0.37, 1, 0.78, 0.23, 0.18, 0.32, 0.17);
                yield return new cattell("Number2", 0.32, 0.33, 0.19, 0.14, 0.43, 0.39, 0.78, 1, 0.14, 0.14, 0.2, 0.15);
                yield return new cattell("IPATSer", 0.29, 0.3, 0.27, 0.27, 0.28, 0.24, 0.23, 0.14, 1, 0.33, 0.45, 0.29);
                yield return new cattell("IPATCLAS", 0.21, 0.23, 0.29, 0.31, 0.26, 0.24, 0.18, 0.14, 0.33, 1, 0.44, 0.28);
                yield return new cattell("IPATMatr", 0.33, 0.33, 0.28, 0.24, 0.35, 0.37, 0.32, 0.2, 0.45, 0.44, 1, 0.33);
                yield return new cattell("IPATTOP", 0.25, 0.24, 0.29, 0.25, 0.23, 0.22, 0.17, 0.15, 0.29, 0.28, 0.33, 1);
            }
        }
    }
}
