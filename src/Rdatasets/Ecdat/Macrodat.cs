// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Macroeconomic Time Series for the United States
    /// </summary>

    public class Macrodat
    {
        public readonly double lhur;
        public readonly double punew;
        public readonly double fyff;
        public readonly double fygm3;
        public readonly double fygt1;
        public readonly double exruk;
        public readonly double? gdpjp;

        public Macrodat(double lhur, double punew, double fyff, double fygm3, double fygt1, double exruk, double? gdpjp)
        {
            this.lhur = lhur;
            this.punew = punew;
            this.fyff = fyff;
            this.fygm3 = fygm3;
            this.fygt1 = fygt1;
            this.exruk = exruk;
            this.gdpjp = gdpjp;
        }

        public static IEnumerable<Macrodat> Data
        {
            get
            {
                yield return new Macrodat(5.83333333333, 28.99333333333, 2.8, 2.8, 3.61, 281.271, 14.3195);
                yield return new Macrodat(5.1, 29.04333333333, 3.39, 3.21, 4.07, 281.254, 14.8032);
                yield return new Macrodat(5.26666666667, 29.19333333333, 3.76, 4.04, 5, 280.37, 15.5764);
                yield return new Macrodat(5.6, 29.37, 3.99, 4.49, 5.14, 279.845, 15.4222);
                yield return new Macrodat(5.13333333333, 29.39666666667, 3.84, 3.31, 4.02, 280.586, 16.5126);
                yield return new Macrodat(5.23333333333, 29.57333333333, 3.32, 2.46, 3.36, 280.268, 16.5398);
                yield return new Macrodat(5.53333333333, 29.59, 2.6, 2.48, 3.07, 281.271, 17.1065);
                yield return new Macrodat(6.26666666667, 29.78, 1.98, 2.25, 2.86, 280.737, 17.8172);
                yield return new Macrodat(6.8, 29.84, 2.02, 2.39, 2.88, 279.75, 18.3132);
                yield return new Macrodat(7, 29.83, 1.73, 2.33, 3.06, 278.98, 18.662);
                yield return new Macrodat(6.76666666667, 29.94666666667, 1.88, 2.28, 3.06, 281.22, 18.9993);
                yield return new Macrodat(6.2, 29.99, 2.33, 2.6, 3.18, 280.96, 19.935);
                yield return new Macrodat(5.63333333333, 30.10666666667, 2.7, 2.72, 3.06, 281.53, 20.2105);
                yield return new Macrodat(5.53333333333, 30.22, 2.68, 2.73, 3.03, 280.83, 20.4924);
                yield return new Macrodat(5.56666666667, 30.30666666667, 2.9, 2.78, 3.06, 280.09, 20.7547);
                yield return new Macrodat(5.53333333333, 30.38, 2.93, 2.87, 3.01, 280.33, 21.1522);
                yield return new Macrodat(5.76666666667, 30.47666666667, 2.98, 2.89, 3.03, 280.06, 21.4323);
                yield return new Macrodat(5.73333333333, 30.53333333333, 2.99, 2.99, 3.2, 280.02, 22.0484);
                yield return new Macrodat(5.5, 30.72, 3.48, 3.38, 3.57, 279.77, 22.663);
                yield return new Macrodat(5.56666666667, 30.80333333333, 3.38, 3.52, 3.81, 279.65, 23.4139);
                yield return new Macrodat(5.46666666667, 30.93, 3.43, 3.54, 3.91, 279.81, 24.2031);
                yield return new Macrodat(5.2, 30.98, 3.5, 3.48, 3.83, 279.42, 24.889);
                yield return new Macrodat(5, 31.05, 3.45, 3.53, 3.84, 278.34, 25.2485);
                yield return new Macrodat(4.96666666667, 31.19333333333, 3.85, 3.84, 4.02, 279.06, 25.4727);
                yield return new Macrodat(4.9, 31.29, 4.04, 3.93, 4.06, 279.24, 25.7379);
                yield return new Macrodat(4.66666666667, 31.49, 4.04, 3.8, 3.99, 279.23, 26.1416);
                yield return new Macrodat(4.36666666667, 31.58333333333, 4.01, 3.92, 4.2, 279.67, 26.7008);
                yield return new Macrodat(4.1, 31.75, 4.32, 4.37, 4.72, 280.21, 27.0065);
                yield return new Macrodat(3.86666666667, 32.04666666667, 4.65, 4.58, 4.97, 279.52, 27.7891);
                yield return new Macrodat(3.83333333333, 32.33666666667, 5.17, 4.5, 4.97, 278.98, 28.9819);
                yield return new Macrodat(3.76666666667, 32.61666666667, 5.4, 5.36, 5.82, 278.93, 29.6534);
                yield return new Macrodat(3.7, 32.88333333333, 5.4, 4.96, 5.2, 279.01, 30.1904);
                yield return new Macrodat(3.83333333333, 32.96666666667, 4.53, 4.26, 4.35, 279.63, 31.003);
                yield return new Macrodat(3.83333333333, 33.16666666667, 3.98, 3.53, 4.48, 279.12, 31.8183);
                yield return new Macrodat(3.8, 33.5, 4, 4.42, 5.24, 278.37, 32.9275);
                yield return new Macrodat(3.9, 33.86666666667, 4.51, 4.96, 5.71, 240.63, 33.5658);
                yield return new Macrodat(3.73333333333, 34.2, 5.05, 5.16, 5.58, 239.97, 34.339);
                yield return new Macrodat(3.56666666667, 34.53333333333, 6.07, 5.52, 5.98, 238.46, 35.5893);
                yield return new Macrodat(3.53333333333, 35, 5.78, 5.2, 5.44, 238.74, 36.4165);
                yield return new Macrodat(3.4, 35.43333333333, 6.02, 5.94, 6.19, 238.42, 38.7207);
                yield return new Macrodat(3.4, 35.86666666667, 6.79, 6.01, 6.34, 239.17, 38.9211);
                yield return new Macrodat(3.43333333333, 36.43333333333, 8.9, 6.43, 7.04, 238.95, 40.019);
                yield return new Macrodat(3.56666666667, 36.93333333333, 9.15, 7.08, 7.82, 238.4, 40.9396);
                yield return new Macrodat(3.56666666667, 37.5, 8.97, 7.81, 8.17, 239.73, 42.6926);
                yield return new Macrodat(4.16666666667, 38.1, 7.76, 6.63, 6.97, 240.58, 43.9338);
                yield return new Macrodat(4.76666666667, 38.63333333333, 7.6, 6.67, 7.55, 239.77, 44.3103);
                yield return new Macrodat(5.16666666667, 39.03333333333, 6.29, 6.12, 6.73, 238.53, 45.5504);
                yield return new Macrodat(5.83333333333, 39.6, 4.9, 4.87, 5, 239.06, 45.5102);
                yield return new Macrodat(5.93333333333, 39.93333333333, 3.71, 3.38, 3.69, 241.87, 45.6941);
                yield return new Macrodat(5.9, 40.3, 4.91, 4.74, 5.64, 241.87, 46.4166);
                yield return new Macrodat(6.03333333333, 40.7, 5.55, 4.69, 5.41, 246.94, 47.2102);
                yield return new Macrodat(5.93333333333, 41, 4.14, 4.01, 4.61, 252.66, 47.6719);
                yield return new Macrodat(5.76666666667, 41.33333333333, 3.83, 3.73, 4.67, 261.81, 48.9969);
                yield return new Macrodat(5.7, 41.6, 4.46, 3.91, 4.93, 256.91, 49.9872);
                yield return new Macrodat(5.56666666667, 41.93333333333, 4.87, 4.66, 5.52, 244.1, 50.9713);
                yield return new Macrodat(5.36666666667, 42.36666666667, 5.33, 5.07, 5.52, 234.48, 52.2425);
                yield return new Macrodat(4.93333333333, 43.03333333333, 7.09, 6.09, 6.85, 247.24, 53.9043);
                yield return new Macrodat(4.93333333333, 43.93333333333, 8.49, 7.19, 7.31, 257.62, 54.4643);
                yield return new Macrodat(4.8, 44.8, 10.78, 8.29, 8.31, 241.83, 54.4522);
                yield return new Macrodat(4.76666666667, 45.93333333333, 9.95, 7.45, 7.27, 231.74, 54.9244);
                yield return new Macrodat(5.13333333333, 47.3, 9.35, 7.96, 7.76, 234.06, 53.5401);
                yield return new Macrodat(5.2, 48.56666666667, 11.93, 7.9, 8.67, 239.02, 54.0039);
                yield return new Macrodat(5.63333333333, 49.93333333333, 11.34, 8.06, 8.87, 231.65, 54.667);
                yield return new Macrodat(6.6, 51.46666666667, 8.53, 7.15, 7.31, 232.94, 54.326);
                yield return new Macrodat(8.26666666667, 52.56666666667, 5.54, 5.49, 6.11, 241.8, 54.2179);
                yield return new Macrodat(8.86666666667, 53.2, 5.55, 5.34, 6.29, 228.03, 55.5512);
                yield return new Macrodat(8.46666666667, 54.26666666667, 6.24, 6.42, 7.75, 208.35, 56.1426);
                yield return new Macrodat(8.3, 55.26666666667, 5.2, 5.44, 6.6, 202.21, 56.771);
                yield return new Macrodat(7.73333333333, 55.9, 4.84, 5, 6.21, 194.28, 57.2991);
                yield return new Macrodat(7.56666666667, 56.4, 5.48, 5.41, 6.52, 176.4, 57.7307);
                yield return new Macrodat(7.73333333333, 57.3, 5.25, 5.08, 5.84, 172.72, 58.455);
                yield return new Macrodat(7.76666666667, 58.13333333333, 4.65, 4.35, 4.89, 167.84, 58.5833);
                yield return new Macrodat(7.5, 59.2, 4.69, 4.6, 5.5, 171.7408, 60.0074);
                yield return new Macrodat(7.13333333333, 60.23333333333, 5.39, 5.02, 5.8, 171.914, 60.4644);
                yield return new Macrodat(6.9, 61.06666666667, 6.14, 5.81, 6.53, 174.3139, 60.8331);
                yield return new Macrodat(6.66666666667, 61.96666666667, 6.56, 6.07, 6.96, 185.4575, 61.7063);
                yield return new Macrodat(6.33333333333, 63.03333333333, 6.79, 6.29, 7.31, 190.5467, 62.7128);
                yield return new Macrodat(6, 64.46666666667, 7.6, 6.73, 8.09, 183.7244, 63.1962);
                yield return new Macrodat(6.03333333333, 65.96666666667, 8.45, 7.85, 8.64, 195.95, 64.0711);
                yield return new Macrodat(5.9, 67.5, 10.03, 9.08, 10.3, 198.6109, 64.8563);
                yield return new Macrodat(5.86666666667, 69.2, 10.09, 9.48, 10.25, 203.78, 65.423);
                yield return new Macrodat(5.7, 71.4, 10.29, 9.06, 9.57, 211.19, 66.5621);
                yield return new Macrodat(5.86666666667, 73.7, 11.43, 10.26, 10.84, 219.66, 67.1826);
                yield return new Macrodat(5.96666666667, 76.03333333333, 13.78, 12.04, 11.98, 220.07, 67.7696);
                yield return new Macrodat(6.3, 79.03333333333, 17.19, 15.2, 15.82, 220.4511, 68.7697);
                yield return new Macrodat(7.33333333333, 81.7, 9.47, 7.07, 8.16, 233.5943, 68.6062);
                yield return new Macrodat(7.66666666667, 83.23333333333, 10.87, 10.27, 11.52, 240.1233, 69.2179);
                yield return new Macrodat(7.4, 85.56666666667, 18.9, 15.49, 14.88, 234.5937, 70.0654);
                yield return new Macrodat(7.43333333333, 87.93333333333, 14.7, 13.36, 13.71, 223.19, 71.1652);
                yield return new Macrodat(7.4, 89.76666666667, 19.1, 14.73, 14.86, 197.38, 71.2458);
                yield return new Macrodat(7.4, 92.26666666667, 15.87, 14.7, 16.52, 181.46, 71.9619);
                yield return new Macrodat(8.23333333333, 93.76666666667, 12.37, 10.85, 12.85, 190.3329, 72.2424);
                yield return new Macrodat(8.83333333333, 94.6, 14.68, 12.68, 13.95, 180.5, 72.9219);
                yield return new Macrodat(9.43333333333, 95.96666666667, 14.15, 12.47, 14.07, 175.63, 73.858);
                yield return new Macrodat(9.9, 97.63333333333, 10.31, 7.92, 10.85, 171.2, 74.1411);
                yield return new Macrodat(10.66666666667, 97.93333333333, 8.95, 7.94, 8.91, 161.6, 74.8163);
                yield return new Macrodat(10.36666666667, 98, 8.77, 8.35, 9.04, 149, 75.1548);
                yield return new Macrodat(10.13333333333, 99.13333333333, 8.98, 8.79, 9.66, 154.8, 75.362);
                yield return new Macrodat(9.36666666667, 100.1, 9.45, 9, 10.16, 149.86, 76.5103);
                yield return new Macrodat(8.53333333333, 101.1, 9.47, 9, 10.11, 143.38, 76.7657);
                yield return new Macrodat(7.86666666667, 102.53333333333, 9.91, 9.52, 10.59, 145.57, 77.9796);
                yield return new Macrodat(7.43333333333, 103.5, 11.06, 9.87, 12.08, 137.7, 79.0376);
                yield return new Macrodat(7.43333333333, 104.4, 11.3, 10.37, 11.58, 125.63, 79.5258);
                yield return new Macrodat(7.3, 105.3, 8.38, 8.06, 9.33, 118.61, 80.1512);
                yield return new Macrodat(7.23333333333, 106.26666666667, 8.58, 8.52, 9.86, 112.53, 81.3921);
                yield return new Macrodat(7.3, 107.23333333333, 7.53, 6.95, 7.8, 128.08, 82.9006);
                yield return new Macrodat(7.2, 107.9, 7.92, 7.1, 8.07, 136.42, 83.3768);
                yield return new Macrodat(7.03333333333, 109, 8.27, 7.1, 7.67, 144.47, 84.6351);
                yield return new Macrodat(7.03333333333, 109.56666666667, 7.48, 6.56, 7.03, 146.74, 83.7738);
                yield return new Macrodat(7.16666666667, 109.03333333333, 6.92, 6.21, 6.73, 150.85, 85.0508);
                yield return new Macrodat(6.96666666667, 109.7, 5.89, 5.21, 5.77, 146.98, 85.6048);
                yield return new Macrodat(6.83333333333, 110.46666666667, 6.91, 5.53, 5.87, 143.93, 86.7212);
                yield return new Macrodat(6.6, 111.9, 6.13, 5.59, 6.03, 159.23, 87.1465);
                yield return new Macrodat(6.26666666667, 113.16666666667, 6.73, 5.67, 6.8, 162.88, 87.5783);
                yield return new Macrodat(6, 114.36666666667, 7.22, 6.4, 7.67, 164.46, 89.1426);
                yield return new Macrodat(5.83333333333, 115.43333333333, 6.77, 5.77, 7.17, 182.88, 91.0798);
                yield return new Macrodat(5.7, 116.3, 6.58, 5.7, 6.71, 183.3, 92.5942);
                yield return new Macrodat(5.46666666667, 117.63333333333, 7.51, 6.46, 7.49, 177.68, 93.2352);
                yield return new Macrodat(5.46666666667, 119.06666666667, 8.19, 7.24, 8.09, 168.4, 95.1106);
                yield return new Macrodat(5.33333333333, 120.4, 8.76, 8.07, 8.99, 182.58, 96.2846);
                yield return new Macrodat(5.2, 121.76666666667, 9.85, 8.82, 9.57, 171.34, 97.5208);
                yield return new Macrodat(5.23333333333, 123.7, 9.53, 8.15, 8.44, 155.3, 97.3877);
                yield return new Macrodat(5.23333333333, 124.7, 9.02, 7.75, 8.22, 157.15, 99.3666);
                yield return new Macrodat(5.36666666667, 125.93333333333, 8.45, 7.63, 7.72, 159.65, 100.603);
                yield return new Macrodat(5.3, 128.1, 8.28, 7.9, 8.35, 162.45, 100.984);
                yield return new Macrodat(5.33333333333, 129.4, 8.29, 7.73, 8.1, 171.03, 103.155);
                yield return new Macrodat(5.7, 131.63333333333, 8.2, 7.36, 7.76, 187.94, 104.357);
                yield return new Macrodat(6.13333333333, 133.86666666667, 7.31, 6.74, 7.05, 192.19, 105.641);
                yield return new Macrodat(6.6, 134.86666666667, 6.12, 5.91, 6.4, 182.14, 106.774);
                yield return new Macrodat(6.83333333333, 135.66666666667, 5.9, 5.57, 6.36, 164.97, 107.437);
                yield return new Macrodat(6.86666666667, 136.7, 5.45, 5.22, 5.57, 172.65, 107.783);
                yield return new Macrodat(7.1, 137.83333333333, 4.43, 4.07, 4.38, 182.72, 108.653);
                yield return new Macrodat(7.36666666667, 138.76666666667, 3.98, 4.04, 4.63, 172.38, 109.295);
                yield return new Macrodat(7.6, 139.83333333333, 3.76, 3.66, 4.17, 185.51, 108.96);
                yield return new Macrodat(7.63333333333, 140.9, 3.22, 2.91, 3.18, 184.65, 108.446);
                yield return new Macrodat(7.36666666667, 142.13333333333, 2.92, 3.22, 3.71, 155.1, 108.467);
                yield return new Macrodat(7.13333333333, 143.13333333333, 3.07, 2.95, 3.33, 146.17, 108.565);
                yield return new Macrodat(7.06666666667, 144.2, 3.04, 3.07, 3.54, 150.82, 108.947);
                yield return new Macrodat(6.8, 144.86666666667, 3.09, 2.95, 3.36, 152.48, 109.108);
                yield return new Macrodat(6.63333333333, 146.03333333333, 2.96, 3.06, 3.61, 149.13, 108.979);
                yield return new Macrodat(6.56666666667, 146.8, 3.34, 3.5, 4.32, 149.19, 108.976);
                yield return new Macrodat(6.2, 147.63333333333, 4.25, 4.14, 5.27, 152.62, 109.537);
                yield return new Macrodat(6, 149, 4.73, 4.62, 5.76, 156.61, 110.209);
                yield return new Macrodat(5.63333333333, 149.86666666667, 5.45, 5.6, 7.14, 155.87, 109.905);
                yield return new Macrodat(5.46666666667, 150.96666666667, 5.98, 5.73, 6.43, 160.02, 109.329);
                yield return new Macrodat(5.66666666667, 152.2, 6, 5.47, 5.64, 159.48, 111.025);
                yield return new Macrodat(5.66666666667, 152.96666666667, 5.8, 5.28, 5.62, 155.9, 111.748);
                yield return new Macrodat(5.56666666667, 153.86666666667, 5.6, 5.14, 5.31, 154.05, 112.571);
                yield return new Macrodat(5.53333333333, 155.16666666667, 5.31, 4.96, 5.34, 152.71, 115.556);
                yield return new Macrodat(5.5, 156.5, 5.27, 5.09, 5.81, 154.16, 115.665);
                yield return new Macrodat(5.26666666667, 157.4, 5.3, 5.09, 5.83, 155.93, 115.197);
                yield return new Macrodat(5.33333333333, 158.76666666667, 5.29, 4.91, 5.47, 166.39, 116.425);
                yield return new Macrodat(5.26666666667, 159.76666666667, 5.39, 5.14, 5.8, 160.96, 118.765);
                yield return new Macrodat(5, 160.13333333333, 5.56, 4.93, 5.69, 164.49, 115.488);
                yield return new Macrodat(4.86666666667, 160.86666666667, 5.54, 4.95, 5.52, 160.13, 116.388);
                yield return new Macrodat(4.66666666667, 161.76666666667, 5.5, 5.16, 5.53, 165.97, 115.957);
                yield return new Macrodat(4.66666666667, 162.16666666667, 5.49, 5.03, 5.39, 166.19, 116.164);
                yield return new Macrodat(4.43333333333, 162.66666666667, 5.56, 4.98, 5.41, 165.04, 115.322);
                yield return new Macrodat(4.5, 163.4, 5.51, 4.61, 4.71, 168.23, 114.988);
                yield return new Macrodat(4.43333333333, 164.2, 4.68, 4.39, 4.52, 167.08, 114.035);
                yield return new Macrodat(4.3, 164.86666666667, 4.81, 4.44, 4.78, 162.13, 116.288);
                yield return new Macrodat(4.3, 166.03333333333, 4.76, 4.57, 5.1, 159.5, 116.408);
                yield return new Macrodat(4.23333333333, 167.2, 5.22, 4.68, 5.25, 162.47, null);
                yield return new Macrodat(4.1, 168.53333333333, 5.3, 5.2, 5.84, 161.32, null);
                yield return new Macrodat(4.03333333333, 170.26666666667, 5.85, 5.69, 6.22, 157.99, null);
                yield return new Macrodat(4.03333333333, 171.53333333333, 6.53, 5.69, 6.17, 150.92, null);
                yield return new Macrodat(4, 173.03333333333, 6.52, 6, 6.13, 143.36, null);
                yield return new Macrodat(3.96666666667, 174.26666666667, 6.4, 5.77, 5.6, 146.29, null);
            }
        }
    }
}
