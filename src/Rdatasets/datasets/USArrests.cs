// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Violent Crime Rates by US State
    /// </summary>

    public class USArrests
    {
        public readonly double Murder;
        public readonly int Assault;
        public readonly int UrbanPop;
        public readonly double Rape;

        public USArrests(double Murder, int Assault, int UrbanPop, double Rape)
        {
            this.Murder = Murder;
            this.Assault = Assault;
            this.UrbanPop = UrbanPop;
            this.Rape = Rape;
        }

        public static IEnumerable<USArrests> Data
        {
            get
            {
                yield return new USArrests(13.2, 236, 58, 21.2);
                yield return new USArrests(10, 263, 48, 44.5);
                yield return new USArrests(8.1, 294, 80, 31);
                yield return new USArrests(8.8, 190, 50, 19.5);
                yield return new USArrests(9, 276, 91, 40.6);
                yield return new USArrests(7.9, 204, 78, 38.7);
                yield return new USArrests(3.3, 110, 77, 11.1);
                yield return new USArrests(5.9, 238, 72, 15.8);
                yield return new USArrests(15.4, 335, 80, 31.9);
                yield return new USArrests(17.4, 211, 60, 25.8);
                yield return new USArrests(5.3, 46, 83, 20.2);
                yield return new USArrests(2.6, 120, 54, 14.2);
                yield return new USArrests(10.4, 249, 83, 24);
                yield return new USArrests(7.2, 113, 65, 21);
                yield return new USArrests(2.2, 56, 57, 11.3);
                yield return new USArrests(6, 115, 66, 18);
                yield return new USArrests(9.7, 109, 52, 16.3);
                yield return new USArrests(15.4, 249, 66, 22.2);
                yield return new USArrests(2.1, 83, 51, 7.8);
                yield return new USArrests(11.3, 300, 67, 27.8);
                yield return new USArrests(4.4, 149, 85, 16.3);
                yield return new USArrests(12.1, 255, 74, 35.1);
                yield return new USArrests(2.7, 72, 66, 14.9);
                yield return new USArrests(16.1, 259, 44, 17.1);
                yield return new USArrests(9, 178, 70, 28.2);
                yield return new USArrests(6, 109, 53, 16.4);
                yield return new USArrests(4.3, 102, 62, 16.5);
                yield return new USArrests(12.2, 252, 81, 46);
                yield return new USArrests(2.1, 57, 56, 9.5);
                yield return new USArrests(7.4, 159, 89, 18.8);
                yield return new USArrests(11.4, 285, 70, 32.1);
                yield return new USArrests(11.1, 254, 86, 26.1);
                yield return new USArrests(13, 337, 45, 16.1);
                yield return new USArrests(0.8, 45, 44, 7.3);
                yield return new USArrests(7.3, 120, 75, 21.4);
                yield return new USArrests(6.6, 151, 68, 20);
                yield return new USArrests(4.9, 159, 67, 29.3);
                yield return new USArrests(6.3, 106, 72, 14.9);
                yield return new USArrests(3.4, 174, 87, 8.3);
                yield return new USArrests(14.4, 279, 48, 22.5);
                yield return new USArrests(3.8, 86, 45, 12.8);
                yield return new USArrests(13.2, 188, 59, 26.9);
                yield return new USArrests(12.7, 201, 80, 25.5);
                yield return new USArrests(3.2, 120, 80, 22.9);
                yield return new USArrests(2.2, 48, 32, 11.2);
                yield return new USArrests(8.5, 156, 63, 20.7);
                yield return new USArrests(4, 145, 73, 26.2);
                yield return new USArrests(5.7, 81, 39, 9.3);
                yield return new USArrests(2.6, 53, 66, 10.8);
                yield return new USArrests(6.8, 161, 60, 15.6);
            }
        }
    }
}
