// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Violent Crime Rates by US State
    /// </summary>

    public class USArrests
    {
        public readonly string κ;
        public readonly double Murder;
        public readonly int Assault;
        public readonly int UrbanPop;
        public readonly double Rape;

        public USArrests(string κ, double Murder, int Assault, int UrbanPop, double Rape)
        {
            this.κ = κ;
            this.Murder = Murder;
            this.Assault = Assault;
            this.UrbanPop = UrbanPop;
            this.Rape = Rape;
        }

        public static IEnumerable<USArrests> Data
        {
            get
            {
                yield return new USArrests("Alabama", 13.2, 236, 58, 21.2);
                yield return new USArrests("Alaska", 10, 263, 48, 44.5);
                yield return new USArrests("Arizona", 8.1, 294, 80, 31);
                yield return new USArrests("Arkansas", 8.8, 190, 50, 19.5);
                yield return new USArrests("California", 9, 276, 91, 40.6);
                yield return new USArrests("Colorado", 7.9, 204, 78, 38.7);
                yield return new USArrests("Connecticut", 3.3, 110, 77, 11.1);
                yield return new USArrests("Delaware", 5.9, 238, 72, 15.8);
                yield return new USArrests("Florida", 15.4, 335, 80, 31.9);
                yield return new USArrests("Georgia", 17.4, 211, 60, 25.8);
                yield return new USArrests("Hawaii", 5.3, 46, 83, 20.2);
                yield return new USArrests("Idaho", 2.6, 120, 54, 14.2);
                yield return new USArrests("Illinois", 10.4, 249, 83, 24);
                yield return new USArrests("Indiana", 7.2, 113, 65, 21);
                yield return new USArrests("Iowa", 2.2, 56, 57, 11.3);
                yield return new USArrests("Kansas", 6, 115, 66, 18);
                yield return new USArrests("Kentucky", 9.7, 109, 52, 16.3);
                yield return new USArrests("Louisiana", 15.4, 249, 66, 22.2);
                yield return new USArrests("Maine", 2.1, 83, 51, 7.8);
                yield return new USArrests("Maryland", 11.3, 300, 67, 27.8);
                yield return new USArrests("Massachusetts", 4.4, 149, 85, 16.3);
                yield return new USArrests("Michigan", 12.1, 255, 74, 35.1);
                yield return new USArrests("Minnesota", 2.7, 72, 66, 14.9);
                yield return new USArrests("Mississippi", 16.1, 259, 44, 17.1);
                yield return new USArrests("Missouri", 9, 178, 70, 28.2);
                yield return new USArrests("Montana", 6, 109, 53, 16.4);
                yield return new USArrests("Nebraska", 4.3, 102, 62, 16.5);
                yield return new USArrests("Nevada", 12.2, 252, 81, 46);
                yield return new USArrests("New Hampshire", 2.1, 57, 56, 9.5);
                yield return new USArrests("New Jersey", 7.4, 159, 89, 18.8);
                yield return new USArrests("New Mexico", 11.4, 285, 70, 32.1);
                yield return new USArrests("New York", 11.1, 254, 86, 26.1);
                yield return new USArrests("North Carolina", 13, 337, 45, 16.1);
                yield return new USArrests("North Dakota", 0.8, 45, 44, 7.3);
                yield return new USArrests("Ohio", 7.3, 120, 75, 21.4);
                yield return new USArrests("Oklahoma", 6.6, 151, 68, 20);
                yield return new USArrests("Oregon", 4.9, 159, 67, 29.3);
                yield return new USArrests("Pennsylvania", 6.3, 106, 72, 14.9);
                yield return new USArrests("Rhode Island", 3.4, 174, 87, 8.3);
                yield return new USArrests("South Carolina", 14.4, 279, 48, 22.5);
                yield return new USArrests("South Dakota", 3.8, 86, 45, 12.8);
                yield return new USArrests("Tennessee", 13.2, 188, 59, 26.9);
                yield return new USArrests("Texas", 12.7, 201, 80, 25.5);
                yield return new USArrests("Utah", 3.2, 120, 80, 22.9);
                yield return new USArrests("Vermont", 2.2, 48, 32, 11.2);
                yield return new USArrests("Virginia", 8.5, 156, 63, 20.7);
                yield return new USArrests("Washington", 4, 145, 73, 26.2);
                yield return new USArrests("West Virginia", 5.7, 81, 39, 9.3);
                yield return new USArrests("Wisconsin", 2.6, 53, 66, 10.8);
                yield return new USArrests("Wyoming", 6.8, 161, 60, 15.6);
            }
        }
    }
}
