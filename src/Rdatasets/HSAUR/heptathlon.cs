// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Olympic Heptathlon Seoul 1988
    /// </summary>

    public class heptathlon
    {
        public readonly string κ;
        public readonly double hurdles;
        public readonly double highjump;
        public readonly double shot;
        public readonly double run200m;
        public readonly double longjump;
        public readonly double javelin;
        public readonly double run800m;
        public readonly int score;

        public heptathlon(string κ, double hurdles, double highjump, double shot, double run200m, double longjump, double javelin, double run800m, int score)
        {
            this.κ = κ;
            this.hurdles = hurdles;
            this.highjump = highjump;
            this.shot = shot;
            this.run200m = run200m;
            this.longjump = longjump;
            this.javelin = javelin;
            this.run800m = run800m;
            this.score = score;
        }

        public static IEnumerable<heptathlon> Data
        {
            get
            {
                yield return new heptathlon("Joyner-Kersee (USA)", 12.69, 1.86, 15.8, 22.56, 7.27, 45.66, 128.51, 7291);
                yield return new heptathlon("John (GDR)", 12.85, 1.8, 16.23, 23.65, 6.71, 42.56, 126.12, 6897);
                yield return new heptathlon("Behmer (GDR)", 13.2, 1.83, 14.2, 23.1, 6.68, 44.54, 124.2, 6858);
                yield return new heptathlon("Sablovskaite (URS)", 13.61, 1.8, 15.23, 23.92, 6.25, 42.78, 132.24, 6540);
                yield return new heptathlon("Choubenkova (URS)", 13.51, 1.74, 14.76, 23.93, 6.32, 47.46, 127.9, 6540);
                yield return new heptathlon("Schulz (GDR)", 13.75, 1.83, 13.5, 24.65, 6.33, 42.82, 125.79, 6411);
                yield return new heptathlon("Fleming (AUS)", 13.38, 1.8, 12.88, 23.59, 6.37, 40.28, 132.54, 6351);
                yield return new heptathlon("Greiner (USA)", 13.55, 1.8, 14.13, 24.48, 6.47, 38, 133.65, 6297);
                yield return new heptathlon("Lajbnerova (CZE)", 13.63, 1.83, 14.28, 24.86, 6.11, 42.2, 136.05, 6252);
                yield return new heptathlon("Bouraga (URS)", 13.25, 1.77, 12.62, 23.59, 6.28, 39.06, 134.74, 6252);
                yield return new heptathlon("Wijnsma (HOL)", 13.75, 1.86, 13.01, 25.03, 6.34, 37.86, 131.49, 6205);
                yield return new heptathlon("Dimitrova (BUL)", 13.24, 1.8, 12.88, 23.59, 6.37, 40.28, 132.54, 6171);
                yield return new heptathlon("Scheider (SWI)", 13.85, 1.86, 11.58, 24.87, 6.05, 47.5, 134.93, 6137);
                yield return new heptathlon("Braun (FRG)", 13.71, 1.83, 13.16, 24.78, 6.12, 44.58, 142.82, 6109);
                yield return new heptathlon("Ruotsalainen (FIN)", 13.79, 1.8, 12.32, 24.61, 6.08, 45.44, 137.06, 6101);
                yield return new heptathlon("Yuping (CHN)", 13.93, 1.86, 14.21, 25, 6.4, 38.6, 146.67, 6087);
                yield return new heptathlon("Hagger (GB)", 13.47, 1.8, 12.75, 25.47, 6.34, 35.76, 138.48, 5975);
                yield return new heptathlon("Brown (USA)", 14.07, 1.83, 12.69, 24.83, 6.13, 44.34, 146.43, 5972);
                yield return new heptathlon("Mulliner (GB)", 14.39, 1.71, 12.68, 24.92, 6.1, 37.76, 138.02, 5746);
                yield return new heptathlon("Hautenauve (BEL)", 14.04, 1.77, 11.81, 25.61, 5.99, 35.68, 133.9, 5734);
                yield return new heptathlon("Kytola (FIN)", 14.31, 1.77, 11.66, 25.69, 5.75, 39.48, 133.35, 5686);
                yield return new heptathlon("Geremias (BRA)", 14.23, 1.71, 12.95, 25.5, 5.5, 39.64, 144.02, 5508);
                yield return new heptathlon("Hui-Ing (TAI)", 14.85, 1.68, 10, 25.23, 5.47, 39.14, 137.3, 5290);
                yield return new heptathlon("Jeong-Mi (KOR)", 14.53, 1.71, 10.83, 26.61, 5.5, 39.26, 139.17, 5289);
                yield return new heptathlon("Launa (PNG)", 16.42, 1.5, 11.78, 26.16, 4.88, 46.38, 163.43, 4566);
            }
        }
    }
}
