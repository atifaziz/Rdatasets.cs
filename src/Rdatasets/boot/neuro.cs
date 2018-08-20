// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Neurophysiological Point Process Data
    /// </summary>

    public class neuro
    {
        public readonly double? V1;
        public readonly double? V2;
        public readonly double V3;
        public readonly double? V4;
        public readonly double? V5;
        public readonly double? V6;

        public neuro(double? V1, double? V2, double V3, double? V4, double? V5, double? V6)
        {
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
            this.V6 = V6;
        }

        public static IEnumerable<neuro> Data
        {
            get
            {
                yield return new neuro(null, -203.7, -84.1, 18.5, null, null);
                yield return new neuro(null, -203, -97.8, 25.8, 134.7, null);
                yield return new neuro(null, -249, -92.1, 27.8, 177.1, null);
                yield return new neuro(null, -231.5, -97.5, 27, 150.3, null);
                yield return new neuro(null, null, -130.1, 25.8, 160, null);
                yield return new neuro(null, -223.1, -70.7, 62.1, 197.5, null);
                yield return new neuro(null, -164.8, -12.2, 76.8, 202.8, null);
                yield return new neuro(null, -221.6, -81.9, 27.5, 144.5, null);
                yield return new neuro(null, -153.7, -17, 76.1, 222.4, null);
                yield return new neuro(null, -184.7, -47.3, 74.4, 208.9, null);
                yield return new neuro(null, null, -148.8, 11.4, 137.7, null);
                yield return new neuro(null, -197.6, -6.4, 137.1, null, null);
                yield return new neuro(null, -247.8, -35.4, 80.9, 229.5, null);
                yield return new neuro(null, -227, -104.7, 20.2, 140.2, null);
                yield return new neuro(-233.6, -115.9, -10.5, 70, 202.6, null);
                yield return new neuro(null, -232.4, -100.6, 16.8, 145.1, null);
                yield return new neuro(null, -199.4, -58.2, 29.1, 184.4, null);
                yield return new neuro(null, -195.7, -89.5, 26.4, 142.7, null);
                yield return new neuro(null, -180.1, -65, 27.3, 171.1, null);
                yield return new neuro(null, null, -85.2, 27.1, null, null);
                yield return new neuro(null, -217.3, -77.1, 27.6, 151.5, null);
                yield return new neuro(null, -139.7, -15.8, 83, 215.5, null);
                yield return new neuro(-249.6, -132.8, -14.1, 78.1, 205.7, null);
                yield return new neuro(null, -152.7, -36.9, 29.7, 149.8, null);
                yield return new neuro(null, -224.1, -81.9, 29.1, 172.2, null);
                yield return new neuro(null, null, -235.8, 6, 144.4, null);
                yield return new neuro(null, -202.8, -45.1, 84, 227.3, null);
                yield return new neuro(-240.9, -138.4, -21.5, 73.4, 210.6, null);
                yield return new neuro(-247.1, -128.2, -31.3, 29.2, 143.1, null);
                yield return new neuro(null, -185.4, -80.3, 23.9, 115.8, 222.7);
                yield return new neuro(null, -182.5, -75.8, 27.5, 165.2, null);
                yield return new neuro(null, -202.2, -99.1, 23.8, 136.3, 242.5);
                yield return new neuro(null, -193.3, -82.6, 26.3, 160.5, null);
                yield return new neuro(null, -189.4, -63.3, 27.6, 136.8, null);
                yield return new neuro(null, -149, -31, 73.5, 187.8, null);
                yield return new neuro(null, -162.4, -26.5, 72.6, null, null);
                yield return new neuro(null, -213.4, -107.2, 24.7, 158.5, null);
                yield return new neuro(null, -183.1, -38.8, 69.1, 207.7, null);
                yield return new neuro(null, -247.2, -115.2, 14.3, 141.1, null);
                yield return new neuro(null, -233.6, -85.9, 27.6, 164, null);
                yield return new neuro(null, -167.9, -33, 72, 236.9, null);
                yield return new neuro(null, -186, -54.1, 74, 229.4, null);
                yield return new neuro(-247, -132.2, -18.8, 28.2, 81.4, 237.9);
                yield return new neuro(null, -204.9, -87.4, 27.2, 165.8, null);
                yield return new neuro(null, -166.6, -19.3, 74, 207.8, null);
                yield return new neuro(null, -190.3, -54.2, 84.2, 210.9, null);
                yield return new neuro(null, -191.4, -39.7, 76, 227, null);
                yield return new neuro(null, -165.8, -21.6, 73.7, 224.7, null);
                yield return new neuro(null, -118.4, -9.1, 79.2, 214.2, null);
                yield return new neuro(null, -197.4, -63.9, 64.6, 190.6, null);
                yield return new neuro(null, -230.4, -98.3, 27.1, 132.2, 243);
                yield return new neuro(null, -202.8, -35, 71.5, 221.8, null);
                yield return new neuro(null, -170.6, -51.7, 29.1, 140.5, null);
                yield return new neuro(null, -226.5, -80.5, 27.5, 155.3, null);
                yield return new neuro(null, -153.2, -40.3, 70.2, 186.3, null);
                yield return new neuro(null, -198.8, -57.7, 67.3, 218.3, null);
                yield return new neuro(null, -224.4, -106.4, 19.2, 125.4, null);
                yield return new neuro(null, -170, -31, 79.2, 209.7, null);
                yield return new neuro(null, -239.1, -97.1, 27.4, 169.6, null);
                yield return new neuro(null, -236.5, -80, 27.2, 152.2, null);
                yield return new neuro(null, -233.9, -83.4, 30.1, 190.9, null);
                yield return new neuro(null, null, -115.6, 26.3, 146.4, null);
                yield return new neuro(null, -239.9, -115.9, 26.6, 175.8, null);
                yield return new neuro(null, -210, -89.4, 14.2, 130.3, null);
                yield return new neuro(null, -162, -47.6, 28.2, 149.6, null);
                yield return new neuro(null, -156.2, -32.2, 68.4, 202.9, null);
                yield return new neuro(null, -200.1, -71.5, 29, 172.7, null);
                yield return new neuro(null, -238.1, -95.2, 29.2, 181.8, null);
                yield return new neuro(null, -160.4, -32, 73.8, 209.8, null);
                yield return new neuro(null, -217.5, -115, 18.4, 144.3, null);
                yield return new neuro(null, -182.4, -74.5, 27.4, 144.7, null);
                yield return new neuro(-216.8, -121.8, -25.9, 74.2, 224.3, null);
                yield return new neuro(null, -191.6, -81.5, 26.1, 132.2, null);
                yield return new neuro(null, null, -115.5, 27.1, 182.2, null);
                yield return new neuro(null, -233.9, -95.9, 26.1, 150.8, null);
                yield return new neuro(null, -197.4, -81.7, 29.3, 224.1, null);
                yield return new neuro(null, -237.4, -106.8, 25.7, 141.5, null);
                yield return new neuro(null, -177.3, -53.4, 71.1, 193.3, null);
                yield return new neuro(null, -236, -108, 20.8, 116.7, 234.7);
                yield return new neuro(null, -158.6, -35, 70.9, 192.8, null);
                yield return new neuro(null, -232.2, -90.9, 20.8, 102.8, null);
                yield return new neuro(null, null, -125.9, 82.7, 210.6, null);
                yield return new neuro(null, -226.1, -106, 26.4, 95.8, null);
                yield return new neuro(null, -139.3, -4, 85.1, null, null);
                yield return new neuro(null, null, -112.1, 24.8, 96.2, null);
                yield return new neuro(null, null, -103.3, 27.6, 152.4, null);
                yield return new neuro(null, -236.6, -90.8, 29, null, null);
                yield return new neuro(null, -179.5, -16.8, 78.1, null, null);
                yield return new neuro(null, -220.3, -108, 26.3, 138.4, null);
                yield return new neuro(null, -231.3, -104.2, 27.5, 138.8, null);
                yield return new neuro(null, null, -87.9, 29.7, 165.6, null);
                yield return new neuro(null, null, -102.1, 17.4, 194.3, null);
                yield return new neuro(null, -129.3, -19.2, 79.3, null, null);
                yield return new neuro(null, -166.1, -29.7, 75.9, null, null);
                yield return new neuro(null, -206.6, -75.6, 28.2, 195.3, null);
                yield return new neuro(null, -168.1, -31.1, 65.6, 236.2, null);
                yield return new neuro(null, -98.6, -6, 119, null, null);
                yield return new neuro(null, -209.2, -40.2, 82.1, null, null);
                yield return new neuro(null, -248.9, -122.7, 10.3, 122.7, null);
                yield return new neuro(null, -161.4, -19.3, 102.4, 232.1, null);
                yield return new neuro(null, -239, -30, 72.9, 224.2, null);
                yield return new neuro(null, -244.1, -102.3, 25.9, 149.4, null);
                yield return new neuro(null, -246.9, -120.9, 5.8, 130.8, null);
                yield return new neuro(null, -200.2, -73.9, 27.7, 152.4, null);
                yield return new neuro(null, -232, -68.6, 51.2, 177.7, null);
                yield return new neuro(null, -193.1, -70.7, 52.3, 204.5, null);
                yield return new neuro(null, -200.8, -55.1, 71.8, 213.8, null);
                yield return new neuro(null, -223.2, -61.3, 69.8, 204.8, null);
                yield return new neuro(null, -146.4, -3.3, 104.8, 230.5, null);
                yield return new neuro(null, -245.2, -109.9, 15.3, 130.1, null);
                yield return new neuro(null, -227.6, -105, 14.5, 130.9, null);
                yield return new neuro(null, -208.3, -93.5, 32.4, 140.5, null);
                yield return new neuro(null, -150.6, -5.3, 120.2, null, null);
                yield return new neuro(null, -233.8, -83.4, 27.5, 139.9, null);
                yield return new neuro(null, -215.4, -85.9, 27.3, 137.3, null);
                yield return new neuro(null, -142.8, -3.6, 85.9, 224.6, null);
                yield return new neuro(null, -169.3, -28.1, 73, 195.8, null);
                yield return new neuro(null, -173.8, -31.8, 70.9, 215.7, null);
                yield return new neuro(null, -206.5, -102.1, 18.1, 115.1, null);
                yield return new neuro(null, null, -101.5, 26, 165.2, null);
                yield return new neuro(null, -188.4, -54.2, 75, 189.6, null);
                yield return new neuro(null, -168, -36.4, 77.7, 209.3, null);
                yield return new neuro(null, -226.5, -81.5, 27.6, 192.9, null);
                yield return new neuro(null, -214.8, -57.4, 67.2, 214.8, null);
                yield return new neuro(null, -180.6, -59.1, 67.8, 188.7, null);
                yield return new neuro(null, -210.9, -73.2, 28.2, 182.2, null);
                yield return new neuro(null, -141.5, -6.2, 76.6, 222.7, null);
                yield return new neuro(null, -142.9, -18.5, 83.4, 221.7, null);
                yield return new neuro(null, -246.2, -104.7, 25.9, 136.8, null);
                yield return new neuro(null, -211.3, -99.9, 26.4, 131.9, 248.9);
                yield return new neuro(null, -213.1, -35.9, 71.6, 207.3, null);
                yield return new neuro(-201.6, -103.9, -12.1, 65.8, 211, null);
                yield return new neuro(null, -203.9, -56, 29.7, 143.7, null);
                yield return new neuro(null, -210.6, -73.2, 26.5, 130.8, 248.7);
                yield return new neuro(null, -204.3, -70.8, 29.4, 246.1, null);
                yield return new neuro(null, -161.4, -33.4, 67.7, 200.9, null);
                yield return new neuro(null, -223, -94.3, 27.5, 134.7, null);
                yield return new neuro(null, -239.2, -94.3, 26.5, 149.8, null);
                yield return new neuro(null, -177.9, -26.6, 79.5, 220.5, null);
                yield return new neuro(null, -221.4, -83.2, 27.6, 144.1, null);
                yield return new neuro(null, -201.7, -79.4, 55, 159.9, null);
                yield return new neuro(null, -238.1, -78.5, 26.3, 128, 241.5);
                yield return new neuro(null, -198.2, -64.9, 29, 137.1, null);
                yield return new neuro(null, null, -161.2, 18.1, 136.1, null);
                yield return new neuro(null, -227.2, -99.3, 27.5, 125.3, 249.1);
                yield return new neuro(null, -153, -20.4, 74.4, 217.8, null);
                yield return new neuro(null, -216.6, -82.2, 29, 118.7, null);
                yield return new neuro(null, -155.9, -24.4, 75.6, 180, null);
                yield return new neuro(null, null, -118.9, 15.9, 137.1, null);
                yield return new neuro(null, -222.5, -103.2, 19.8, 178.8, null);
                yield return new neuro(null, -165.2, -28.6, 74.8, 181.6, null);
                yield return new neuro(null, -161.6, -19.7, 71.7, 206.9, null);
                yield return new neuro(null, -193.8, -40.6, 71.4, 194.7, null);
                yield return new neuro(null, -206.6, -71.4, 29.6, 175.6, null);
                yield return new neuro(-229.8, -118.2, -7.6, 73.8, 206.9, null);
                yield return new neuro(null, -182.7, -55.4, 29.4, 135, 244.2);
                yield return new neuro(null, -151.2, -28.5, 67.8, 171, null);
                yield return new neuro(null, -168.5, -38.9, 73.8, 191.6, null);
                yield return new neuro(null, -150.3, -22.9, 68.8, 193.9, null);
                yield return new neuro(null, -185.2, -58.6, 59.8, 148.4, null);
                yield return new neuro(-238.8, -143.4, -33.7, 66.6, 174.2, null);
                yield return new neuro(null, -155.6, -41.5, 74.9, 186.1, null);
                yield return new neuro(null, -130.8, -33.1, 70, 153.2, null);
                yield return new neuro(-239.4, -128, -26.9, 72.2, 155, null);
                yield return new neuro(null, -147, -38.1, 69.1, 168.3, null);
                yield return new neuro(null, -143.5, -21, 72.4, 175.2, null);
                yield return new neuro(null, -170.2, -60.2, 29.4, 131.8, null);
                yield return new neuro(null, -215.1, -91.3, 27.6, 140.8, null);
                yield return new neuro(null, -216, -91.8, 24.4, 126.3, 238.8);
                yield return new neuro(null, -131.6, -41.3, 30.1, 135.3, 248.1);
                yield return new neuro(null, null, -89.8, 22.7, 127.7, null);
                yield return new neuro(null, -205.3, -87.2, 27.6, 117.4, 238.2);
                yield return new neuro(null, -201.8, -77.9, 26.4, 137.8, 238.6);
                yield return new neuro(null, -206.4, -92, 21.5, 119.4, 234.4);
                yield return new neuro(null, null, -91.4, 8.2, 135.2, null);
                yield return new neuro(null, -154.5, -37.8, 70.3, 194.5, null);
                yield return new neuro(null, -205.8, -70.7, 66.4, 193.6, null);
                yield return new neuro(null, -170.7, -19.8, 70.8, 187.7, null);
                yield return new neuro(null, -192.3, -80.8, 15.4, 120, 244.1);
                yield return new neuro(null, -206.8, -60.3, 29.8, 144.4, null);
                yield return new neuro(null, -229.4, -101.3, 27.6, 154.9, null);
                yield return new neuro(null, -139.8, -11.6, 81.2, 175.5, null);
                yield return new neuro(null, -149.8, -45.4, 69.1, 190, null);
                yield return new neuro(null, -242.1, -106, 21.9, 120, null);
                yield return new neuro(null, -248.4, -97.4, 26.3, 144.7, null);
                yield return new neuro(null, -239.2, -89.5, 27.1, 153, null);
                yield return new neuro(null, -159.7, -23.3, 69.6, 202.6, null);
                yield return new neuro(null, -178, -52.8, 29, 137.3, null);
                yield return new neuro(null, -184, -62.2, 65, 191.2, null);
                yield return new neuro(null, -179.9, -9.1, 107.6, null, null);
                yield return new neuro(null, -199.9, -104.4, 25.6, 126.1, 249);
                yield return new neuro(null, -128, -3.9, 83.4, null, null);
                yield return new neuro(null, -232.9, -103.6, 21.6, 121.4, null);
                yield return new neuro(null, -146.5, -2.9, 113.7, 241.9, null);
                yield return new neuro(null, -214.1, -100.4, 8.1, 108.2, null);
                yield return new neuro(null, null, -128, 10.8, 88.7, 245.2);
                yield return new neuro(null, -234.3, -111.6, 3.6, 134.2, null);
                yield return new neuro(null, -196.8, -67.9, 29.4, 218.6, null);
                yield return new neuro(null, -208.7, -71.1, 28.9, 147, null);
                yield return new neuro(null, -230.5, -92.2, 27.7, 136.7, null);
                yield return new neuro(null, -243.3, -109.3, 13.3, 146.5, null);
                yield return new neuro(null, -133.1, -0.1, 114.6, 237.2, null);
                yield return new neuro(null, -134.7, -5.1, 81.8, null, null);
                yield return new neuro(null, -227.7, -96.2, 26.3, 142.6, 241.8);
                yield return new neuro(null, -207.6, -64.2, 31.6, 207, null);
                yield return new neuro(null, -207.7, -72.8, 27.8, 145, null);
                yield return new neuro(null, -236, -84.5, 27.6, 141.6, null);
                yield return new neuro(null, null, -127.3, 14.5, 81.3, 212.8);
                yield return new neuro(null, -147.6, -17.7, 124.8, 248.7, null);
                yield return new neuro(null, -184.5, -42.1, 69.7, 205.2, null);
                yield return new neuro(null, -246.4, -99.5, 27, 153.3, null);
                yield return new neuro(null, -206.8, -76.9, 27.8, 146.4, null);
                yield return new neuro(null, -195.7, -55.8, 77.2, 207.4, null);
                yield return new neuro(-221.7, -120.4, -14.8, 72.2, 182.1, null);
                yield return new neuro(-248.9, -136.7, -17.6, 75.9, 188, null);
                yield return new neuro(-247.8, -141.5, -19.5, 78.5, 190.5, null);
                yield return new neuro(-249.9, -130.5, -21.2, 67.3, 145.6, null);
                yield return new neuro(null, -197.7, -81.3, 25.9, 140.9, null);
                yield return new neuro(null, -238.9, -74.7, 66.6, 189.5, null);
                yield return new neuro(null, -208.7, -20.1, 73.6, 209.7, null);
                yield return new neuro(null, -148.8, -29.5, 69.5, 154.6, null);
                yield return new neuro(null, -154.3, -21.4, 92.3, 228.1, null);
                yield return new neuro(null, -215.5, -81.3, 68.5, 205.3, null);
                yield return new neuro(null, -244.1, -125, 84.4, 197, null);
                yield return new neuro(null, -145, -43.3, 25.8, 114.8, 223.7);
                yield return new neuro(null, -170.4, -23.5, 70.4, 210.4, null);
                yield return new neuro(null, null, -13.6, 96.2, 215.3, null);
                yield return new neuro(null, null, -41.7, 72.2, 192.9, null);
                yield return new neuro(null, null, -101.4, 27.7, 153.2, null);
                yield return new neuro(null, -185.6, -58.4, 69.2, 192.2, null);
                yield return new neuro(null, -210.8, -46.6, 29.8, 151, null);
                yield return new neuro(null, null, -210.4, 11.3, 166, null);
                yield return new neuro(null, -139.6, -3, 83.4, 208.8, null);
                yield return new neuro(null, null, -111.9, 27.3, 134.3, null);
                yield return new neuro(null, -151, -8, 79.7, 219.1, null);
                yield return new neuro(null, -150.3, -14.2, 82.8, 202.9, null);
                yield return new neuro(null, -117.4, -16.6, 78, 193.8, null);
                yield return new neuro(null, -230.5, -106.6, 26.2, 141.2, null);
                yield return new neuro(null, -213.4, -108.9, 19.2, 117.9, 235.6);
                yield return new neuro(null, -181.6, -73.1, 10.5, 100.2, 190.5);
                yield return new neuro(null, -169.1, -71.2, 24.6, 111.5, 224.5);
                yield return new neuro(null, -177.6, -72.8, 26.2, 139, 218.7);
                yield return new neuro(null, -124.8, -4.4, 87, 199.7, null);
                yield return new neuro(null, -212.2, -95.7, 11.6, 107.3, 214.5);
                yield return new neuro(-231.6, -127.2, -14.7, 103, 181.3, null);
                yield return new neuro(null, null, -123.5, 9.5, 110.6, 244.3);
                yield return new neuro(null, null, -133, 27.7, 144.2, null);
                yield return new neuro(null, -188.8, -77, 27.7, 139.2, null);
                yield return new neuro(null, -205, -73.7, 28, 142.6, null);
                yield return new neuro(null, -182.7, -63.2, 27.8, 129.4, 234.1);
                yield return new neuro(null, -177.4, -55.1, 56.7, 166.9, null);
                yield return new neuro(-230.2, -128.8, -9.7, 76.7, 199.8, null);
                yield return new neuro(null, -217.3, -85.2, 26.9, 127.7, 242.2);
                yield return new neuro(null, null, -118.8, 6.1, 104, 208.5);
                yield return new neuro(null, -211.8, -96.8, 11.9, 111.9, 229.2);
                yield return new neuro(null, -181, -77.9, 27.8, 138.1, null);
                yield return new neuro(null, -220, -96.9, 8.3, 121.6, 232.8);
                yield return new neuro(null, -166.8, -23.1, 72.7, 188.4, null);
                yield return new neuro(null, -247, -104.8, 15.3, 126.9, 240.6);
                yield return new neuro(null, -236.6, -102.6, 10.2, 124.3, 248.4);
                yield return new neuro(null, -236.2, -110.7, 12.6, 127.8, 230.1);
                yield return new neuro(null, -209.9, -93.6, 26.3, 130.1, null);
                yield return new neuro(null, -188.9, -61.6, 28.5, 170.6, null);
                yield return new neuro(null, -201.3, -43.1, 72.8, 205.5, null);
                yield return new neuro(null, -210.4, -77.7, 28, 133.2, 242);
                yield return new neuro(null, -235.3, -75.6, 11.6, 108.5, 197.1);
                yield return new neuro(null, -175.1, -51.7, 64.7, 181, null);
                yield return new neuro(null, null, -106.7, 28, 161.1, null);
                yield return new neuro(null, -222, -107.8, 2.6, 81.9, 190.8);
                yield return new neuro(null, -200.7, -84.7, 24.6, 121.3, 229.2);
                yield return new neuro(-239.8, -123.3, -13, 70.2, 149.4, null);
                yield return new neuro(null, -160.9, -43.2, 69.6, 153.3, null);
                yield return new neuro(null, -138.4, -14.9, 73, 184.4, null);
                yield return new neuro(null, null, -95.1, 71.1, 223.4, null);
                yield return new neuro(null, -227.5, -83.3, 27.7, 145.8, null);
                yield return new neuro(null, null, -112.6, 27.9, 188.5, null);
                yield return new neuro(null, null, -120.2, 27.6, 155.7, null);
                yield return new neuro(null, -163.1, -52.6, 66, 206.1, null);
                yield return new neuro(null, -205.2, -100.7, 12.1, 95.7, 224.8);
                yield return new neuro(null, -190.8, -72.1, 28.1, 128.2, null);
                yield return new neuro(null, null, -130.7, 10.1, 81.5, 221.9);
                yield return new neuro(null, -180.1, -49.1, 65.3, 184.8, null);
                yield return new neuro(null, -215.2, -81, 64.6, 200.7, null);
                yield return new neuro(-243.3, -128.8, -8.4, 75.9, 189, null);
                yield return new neuro(null, -145, -10.6, 91.8, 231, null);
                yield return new neuro(null, -241.6, -113.4, 27.3, 138.8, null);
                yield return new neuro(null, -182.5, -75, 28.2, 137.1, null);
                yield return new neuro(null, -177.4, -65.9, 63.2, 189.9, null);
                yield return new neuro(null, -143.3, -10, 141, null, null);
                yield return new neuro(null, -242.2, -62.2, 29, 198.5, null);
                yield return new neuro(null, -247.8, -95.3, 28.3, 194.7, null);
                yield return new neuro(null, -164.6, -80.1, 26.2, 126.6, 243.6);
                yield return new neuro(null, -207.6, -110, 2.8, 84.9, 207.1);
                yield return new neuro(null, -243.3, -87.4, 62.4, 193.3, null);
                yield return new neuro(null, -168, -3, 73.8, 183.9, null);
                yield return new neuro(null, -234.5, -104.8, 27.5, 133.2, null);
                yield return new neuro(null, -189.5, -64.1, 59.7, 140.7, null);
                yield return new neuro(null, -156.3, -38.1, 73, 146.8, null);
                yield return new neuro(null, -191.5, -87, 27.8, 137.6, 246);
                yield return new neuro(null, -171.2, -66.7, 28.4, 141.8, 248.4);
                yield return new neuro(null, -221.8, -93.5, 27.8, 130.1, null);
                yield return new neuro(null, -158.8, -15.1, 73.6, 199.8, null);
                yield return new neuro(null, -177.5, -1.9, 117.9, 223.2, null);
                yield return new neuro(-196.9, -105, -2.3, 76.3, 178.8, null);
                yield return new neuro(null, -196.2, -94.9, 4.3, 84.2, 183.4);
                yield return new neuro(null, -150.3, -39.9, 68.9, 172.3, null);
                yield return new neuro(-213.9, -107.7, -7.5, 92.7, 211.5, null);
                yield return new neuro(null, -215.9, -85, 19.4, 103.3, 224.2);
                yield return new neuro(null, -139.7, -24.3, 81, 211.8, null);
                yield return new neuro(null, null, -159.4, 28.3, null, null);
                yield return new neuro(null, -229, -107.4, 19.5, 137, null);
                yield return new neuro(null, null, -158.4, 5.6, 132.9, null);
                yield return new neuro(null, -144.7, -38.2, 67, 152.7, null);
                yield return new neuro(null, -222.1, -84, 26.6, 140, null);
                yield return new neuro(null, -163, -46.6, 74, 204.2, null);
                yield return new neuro(null, -201.9, -85.3, 22.7, 138.4, 247.5);
                yield return new neuro(null, -176.6, -64.6, 47.8, 160.6, null);
                yield return new neuro(null, -234.3, -106.7, 25, 114.7, 229.3);
                yield return new neuro(null, -152.4, -31.7, 70.4, 182.2, null);
                yield return new neuro(null, -163.9, -53.7, 56.3, 146.1, null);
                yield return new neuro(null, -125, -1.4, 108, 220.9, null);
                yield return new neuro(-235.9, -138.1, -28.1, 63.1, 178.3, null);
                yield return new neuro(null, null, -116.3, 6, 109.7, 222.8);
                yield return new neuro(null, -183.8, -8.7, 130, null, null);
                yield return new neuro(null, -181.8, -8.5, 84.2, 216.6, null);
                yield return new neuro(null, -235.1, -99.5, 27.9, 152.4, null);
                yield return new neuro(null, null, -136, 84.2, 219.6, null);
                yield return new neuro(null, null, -155.2, 21, 130.3, null);
                yield return new neuro(null, -173, -43.3, 81.3, 213.6, null);
                yield return new neuro(null, null, -129.1, 14.8, 119.3, null);
                yield return new neuro(null, null, -138.9, 9.4, 121.9, null);
                yield return new neuro(null, -198.5, -15.9, 115.6, 233.5, null);
                yield return new neuro(null, -138.6, -3, 133.5, null, null);
                yield return new neuro(null, -226.1, -69.5, 30, 165.4, null);
                yield return new neuro(null, -172.7, -47.6, 29.2, 144.5, null);
                yield return new neuro(null, -194.4, -78.9, 64.6, 135.9, null);
                yield return new neuro(null, -183, -60.9, 79.1, 241.8, null);
                yield return new neuro(null, -222.8, -105, 24.6, 112.1, 234.4);
                yield return new neuro(null, -217.7, -91, 27.5, 144.6, null);
                yield return new neuro(-231.9, -128.3, -20.4, 73.7, 189.9, null);
                yield return new neuro(null, -179.1, -65.2, 28, 155.5, null);
                yield return new neuro(null, -139.5, -18.9, 82.8, 215.6, null);
                yield return new neuro(null, -247.4, -99.2, 26.2, 122.7, 247.4);
                yield return new neuro(null, -193.6, -51, 64.9, 170.2, null);
                yield return new neuro(null, null, -145.8, 27.6, 142.7, null);
                yield return new neuro(null, null, -143, 16.1, 142.4, null);
                yield return new neuro(null, null, -106.4, 19.3, 117.6, null);
                yield return new neuro(null, -199.4, -67.7, 27.6, 137.1, 246.9);
                yield return new neuro(null, -200.6, -59.6, 197.8, null, null);
                yield return new neuro(null, -172.6, -27.3, 65.9, 134.9, 242.5);
                yield return new neuro(null, -195.3, -84.4, 26.2, 133.5, null);
                yield return new neuro(null, -206, -101.6, 80.4, 192, null);
                yield return new neuro(null, -157.1, -54.3, 60.8, 157.9, null);
                yield return new neuro(null, -140.7, -24.7, 76.6, 159.1, null);
                yield return new neuro(null, -151.9, -37.4, 69.1, 166.6, null);
                yield return new neuro(-239.9, -140.4, -41.6, 64.5, 149.7, null);
                yield return new neuro(null, -157.9, -44.5, 55.3, 180.4, null);
                yield return new neuro(null, -168.8, -55.3, 46.5, 164.2, null);
                yield return new neuro(null, -220.9, -102.8, 10, 78.7, 185.8);
                yield return new neuro(null, -202.8, -61.9, 30, 146.7, null);
                yield return new neuro(null, -217.5, -90, 29.8, 172.4, null);
                yield return new neuro(null, null, -136.6, 27.1, 186.3, null);
                yield return new neuro(null, -234, -97.2, 29.7, 219.5, null);
                yield return new neuro(null, null, -127, 28, 164, null);
                yield return new neuro(null, null, -108.9, 26.5, 152.8, null);
                yield return new neuro(null, null, -46.7, 70.4, 187.4, null);
                yield return new neuro(null, null, -157.2, 9.6, 136.5, null);
                yield return new neuro(null, -157.6, -6, 126.3, null, null);
                yield return new neuro(null, -159.3, -11.3, 81.4, null, null);
                yield return new neuro(null, -226.7, -83.5, 66.8, 229.2, null);
                yield return new neuro(null, null, -74.3, 69.8, 223, null);
                yield return new neuro(null, -160.5, -36.2, 72.3, 201.5, null);
                yield return new neuro(null, -194.9, -58.8, 68.8, 184.4, null);
                yield return new neuro(-227.8, -129.1, -20.9, 66.3, 166.8, null);
                yield return new neuro(null, -221.8, -79.7, 17.3, 111, 207.4);
                yield return new neuro(null, -191, -79.3, 27.3, 130.9, 236.8);
                yield return new neuro(null, -203, -102.6, 1.7, 101.5, 208.1);
                yield return new neuro(-232.8, -116.6, -17.3, 65.8, 167.6, null);
                yield return new neuro(null, null, -18.5, 70.2, 173.8, null);
                yield return new neuro(-245.2, -147.9, -47.9, 60.9, 147.7, null);
                yield return new neuro(null, -210.2, -107.6, 3.6, 103.1, 218.5);
                yield return new neuro(null, -213.2, -99, 15.5, 93.4, 196.4);
                yield return new neuro(-224.6, -104.6, -1.6, 104.7, 229.5, null);
                yield return new neuro(null, -148.3, -39.4, 32.3, 133, 243);
                yield return new neuro(null, -200.6, -98.6, 77.3, 170.3, null);
                yield return new neuro(null, -168.2, -54.3, 66.2, 169.5, null);
                yield return new neuro(null, -170.8, -44.1, 61.7, 183.9, null);
                yield return new neuro(null, -232.7, -89.4, 8.9, 108, 235.8);
                yield return new neuro(null, -217.2, -97.5, 17, 128.6, 245.6);
                yield return new neuro(null, -166.8, -49.5, 52, 135.3, null);
                yield return new neuro(-234, -140.8, -56.5, 28, 114.3, 222.9);
                yield return new neuro(null, -141.7, -35.3, 69.6, 153.3, null);
                yield return new neuro(null, -157.9, -52.7, 59.1, 163, null);
                yield return new neuro(null, -181.3, -59.2, 61.5, 141.1, null);
                yield return new neuro(null, -188, -67.3, 24.1, 122.3, 243.2);
                yield return new neuro(null, -233.5, -117.8, 2.7, 109.4, 220.8);
                yield return new neuro(null, -203.6, -95.9, 14.6, 133.7, 229.8);
                yield return new neuro(null, null, -107.2, 7.2, 126.9, null);
                yield return new neuro(null, -199.9, -78.1, 6.5, 91.2, 205.4);
                yield return new neuro(null, -174.3, -67.6, 28.3, 131.9, null);
                yield return new neuro(null, -188.7, -49.4, 73.9, 194.7, null);
                yield return new neuro(-239, -131.3, -12.9, 73.6, 192.6, null);
                yield return new neuro(-221.3, -116.8, -15.6, 72, 160.1, null);
                yield return new neuro(null, -175.3, -18.5, 86.3, 195.6, null);
                yield return new neuro(null, -233, -115.4, 11.5, 115.9, 249.1);
                yield return new neuro(null, -222.7, -92.6, 24.1, 134.2, 248.2);
                yield return new neuro(null, -218.2, -96.8, 27.6, 138.7, null);
                yield return new neuro(null, -213.8, -88.1, 21, 127.3, null);
                yield return new neuro(null, -229.9, -106.6, 16.9, 130.9, 247.5);
                yield return new neuro(null, -248.6, -106.1, 25.7, 143.9, null);
                yield return new neuro(null, -206.5, -78.4, 27, 140.6, null);
                yield return new neuro(null, -217.6, -103, 14.3, 137.2, null);
                yield return new neuro(null, -138.1, -16.5, 76.7, 179.7, null);
                yield return new neuro(null, null, -135.5, 11.6, 124.8, null);
                yield return new neuro(null, -228.4, -111.2, 6.4, 122.7, null);
                yield return new neuro(null, -209, -93.8, 10.7, 121.9, 237.3);
                yield return new neuro(null, -138, -21.1, 73, 194.2, null);
                yield return new neuro(null, -210.1, -44.8, 70.6, 185.6, null);
                yield return new neuro(null, -174.6, -44, 74.1, 194.6, null);
                yield return new neuro(null, -202.4, -83, 26.5, 122.6, 239);
                yield return new neuro(null, -141.7, -11.7, 87.9, 207.2, null);
                yield return new neuro(null, null, -208.3, 3.1, 109.1, null);
                yield return new neuro(null, -188.8, -16.8, 109.2, 218.8, null);
                yield return new neuro(null, -223.1, -127.4, 1, 108.9, 231);
                yield return new neuro(null, -147.6, -29.7, 67.2, 152.7, null);
                yield return new neuro(null, -223.8, -105.2, 27.7, 142.9, null);
                yield return new neuro(null, -228.1, -98.5, 28.1, 166.5, null);
                yield return new neuro(null, -194.8, -25.4, 69.8, 169.9, null);
                yield return new neuro(null, -164.6, -65.4, 26.4, 116.1, 196.7);
                yield return new neuro(null, -169, -43.1, 67.7, 190.3, null);
                yield return new neuro(null, -197.1, -98.2, 22.1, 124.6, 236.1);
                yield return new neuro(null, -156.2, -32.9, 63.3, 182.8, null);
                yield return new neuro(null, -220.6, -114.2, 9.7, 106.4, 227.9);
                yield return new neuro(-219.9, -120.9, -1.3, 99.5, 207.6, null);
                yield return new neuro(null, -240.5, -110.3, 26.1, 142.8, null);
                yield return new neuro(null, -239.6, -121.4, 2.9, 124.9, null);
                yield return new neuro(null, -139.8, -7.3, 121, null, null);
                yield return new neuro(null, -212, -66.2, 50.4, 178.2, null);
                yield return new neuro(null, -232.7, -109.2, 18.4, 127.5, null);
                yield return new neuro(null, -236.3, -115.1, 5.1, 109, 212);
                yield return new neuro(-241.2, -107.1, -9.1, 95.1, 198.6, null);
                yield return new neuro(-226.7, -143.8, -30.4, 75.8, 196.6, null);
                yield return new neuro(null, -131.8, -26.5, 64.7, 177.2, null);
                yield return new neuro(null, -144.9, -0.9, 105.3, 230.9, null);
                yield return new neuro(null, -214, -81.8, 66.1, 191.3, null);
                yield return new neuro(null, -210.6, -94.3, 16.7, 125.5, 239.7);
                yield return new neuro(-215.8, -114.8, -18.4, 65.3, 171.6, 249.7);
                yield return new neuro(null, -156, -14, 113.7, 249.3, null);
                yield return new neuro(null, -210.5, -41.9, null, null, null);
                yield return new neuro(null, -189.2, -72, 56.8, 133.8, 246.7);
                yield return new neuro(null, -214.2, -102.2, 5.5, 75.6, 154.3);
                yield return new neuro(-219.6, -107.9, -16, 101.7, 186, null);
                yield return new neuro(null, -153, -38, 61.3, 144.4, 245.9);
                yield return new neuro(null, -179.8, -63.4, 56, 157.5, null);
                yield return new neuro(null, -174.5, -44.8, 73.3, 179.7, null);
                yield return new neuro(null, -206.8, -108.9, 3.7, 102.1, 210.3);
                yield return new neuro(null, -169.5, -79.7, 27.9, 129.4, 242.8);
                yield return new neuro(-222.2, -104.6, -2.4, 84.3, 204.7, null);
                yield return new neuro(-236.3, -124, -6.8, 95.7, 196, null);
                yield return new neuro(null, -216.5, -90.2, 27.8, 138.9, null);
                yield return new neuro(null, -163.2, -43.6, 69.5, 173.9, null);
                yield return new neuro(null, -207.3, -88.3, 9.6, 104.1, 218);
                yield return new neuro(-242.6, -142, -21.8, 69.8, 148.7, null);
                yield return new neuro(-235.9, -128.8, -33.1, 68.8, 177.1, null);
                yield return new neuro(null, -140.8, -38.7, 58.1, 186.3, null);
                yield return new neuro(null, -149.5, -40.3, 62.8, 139.7, 242.5);
                yield return new neuro(-247.6, -157.8, -53.3, 28.3, 122.9, 227.6);
                yield return new neuro(null, -154.9, -50.8, 28.1, 119.9, 201.1);
                yield return new neuro(null, -180.7, -70.9, 33.7, 114.8, 222.5);
            }
        }
    }
}
