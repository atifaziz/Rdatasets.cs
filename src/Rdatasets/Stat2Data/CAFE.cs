// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// CAFE
    /// </summary>

    public class CAFE
    {
        public readonly string Senator;
        public readonly string State;
        public readonly string Party;
        public readonly int Contribution;
        public readonly double LogContr;
        public readonly int Dem;
        public readonly int Vote;

        public CAFE(string Senator, string State, string Party, int Contribution, double LogContr, int Dem, int Vote)
        {
            this.Senator = Senator;
            this.State = State;
            this.Party = Party;
            this.Contribution = Contribution;
            this.LogContr = LogContr;
            this.Dem = Dem;
            this.Vote = Vote;
        }

        public static IEnumerable<CAFE> Data
        {
            get
            {
                yield return new CAFE("Murkowski, Frank", "AK", "R", 19700, 4.305351369, 0, 1);
                yield return new CAFE("Stevens, Ted", "AK", "R", 13000, 4.130333768, 0, 1);
                yield return new CAFE("Sessions, Jeff", "AL", "R", 9500, 4, 0, 1);
                yield return new CAFE("Shelby, Richard", "AL", "R", 25000, 4.40654018, 0, 1);
                yield return new CAFE("Hutchinson, Tim", "AR", "R", 4900, 3.73239376, 0, 1);
                yield return new CAFE("Lincoln, Blanche", "AR", "D", 5500, 3.77815125, 1, 1);
                yield return new CAFE("McCain, John", "AZ", "R", 29350, 4.474944335, 0, 0);
                yield return new CAFE("Kyl, Jon", "AZ", "R", 14500, 4.176091259, 0, 1);
                yield return new CAFE("Boxer, Barbara", "CA", "D", 1500, 3.301029996, 1, 0);
                yield return new CAFE("Feinstein, Dianne", "CA", "D", 9750, 4.010723865, 1, 0);
                yield return new CAFE("Allard, Wayne", "CO", "R", 7500, 3.903089987, 0, 1);
                yield return new CAFE("Campbell, Ben N.", "CO", "R", 4000, 3.653212514, 0, 1);
                yield return new CAFE("Dodd, Christopher", "CT", "D", 500, 3, 1, 0);
                yield return new CAFE("Lieberman, Joseph", "CT", "D", 3000, 3.544068044, 1, 0);
                yield return new CAFE("Carper, Thomas", "DE", "D", 17640, 4.258637283, 1, 1);
                yield return new CAFE("Biden Jr, Joseph", "DE", "D", 5125, 3.750122527, 1, 0);
                yield return new CAFE("Graham, Bob", "FL", "D", 7000, 3.875061263, 1, 0);
                yield return new CAFE("Nelson, Bill", "FL", "D", 300, 2.903089987, 1, 0);
                yield return new CAFE("Cleland, Max", "GA", "D", 4500, 3.698970004, 1, 1);
                yield return new CAFE("Miller, Zell", "GA", "D", 1000, 3.176091259, 1, 1);
                yield return new CAFE("Akaka, Daniel", "HI", "D", 2350, 3.45484486, 1, 0);
                yield return new CAFE("Inouye, Daniel", "HI", "D", 7000, 3.875061263, 1, 0);
                yield return new CAFE("Harkin, Tom", "IA", "D", 4000, 3.653212514, 1, 0);
                yield return new CAFE("Grassley, Chuck", "IA", "R", 22500, 4.361727836, 0, 1);
                yield return new CAFE("Craig, Larry", "ID", "R", 26800, 4.436162647, 0, 1);
                yield return new CAFE("Crapo, Mike", "ID", "R", 10000, 4.021189299, 0, 1);
                yield return new CAFE("Durbin, Richard", "IL", "D", 15600, 4.206825876, 1, 0);
                yield return new CAFE("Fitzgerald, Peter", "IL", "R", 13450, 4.144574208, 0, 1);
                yield return new CAFE("Bayh, Evan", "IN", "D", 21000, 4.33243846, 1, 1);
                yield return new CAFE("Lugar, Richard", "IN", "R", 23500, 4.380211242, 0, 1);
                yield return new CAFE("Brownback, Sam", "KS", "R", 13500, 4.146128036, 0, 1);
                yield return new CAFE("Roberts, Pat", "KS", "R", 9750, 4.010723865, 0, 1);
                yield return new CAFE("Bunning, Jim", "KY", "R", 28850, 4.467608106, 0, 1);
                yield return new CAFE("McConnell, Mitch", "KY", "R", 25000, 4.40654018, 0, 1);
                yield return new CAFE("Breaux, John", "LA", "D", 18150, 4.270678836, 1, 1);
                yield return new CAFE("Landrieu, Mary", "LA", "D", 5000, 3.740362689, 1, 1);
                yield return new CAFE("Kennedy, Edward", "MA", "D", 3150, 3.562292864, 1, 0);
                yield return new CAFE("Kerry, John", "MA", "D", 750, 3.096910013, 1, 0);
                yield return new CAFE("Sarbanes, Paul", "MD", "D", 1500, 3.301029996, 1, 0);
                yield return new CAFE("Mikulski, Barbara", "MD", "D", 18600, 4.281033367, 1, 1);
                yield return new CAFE("Collins, Susan", "ME", "R", 4000, 3.653212514, 0, 0);
                yield return new CAFE("Snowe, Olympia", "ME", "R", 6100, 3.819543936, 0, 0);
                yield return new CAFE("Levin, Carl", "MI", "D", 133250, 5.126293791, 1, 1);
                yield return new CAFE("Stabenow, Debbie", "MI", "D", 51668, 4.717404187, 1, 1);
                yield return new CAFE("Dayton, Mark", "MN", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE("Wellstone, Paul", "MN", "D", 800, 3.113943352, 1, 0);
                yield return new CAFE("Bond, Christopher", "MO", "R", 48939, 4.694069678, 0, 1);
                yield return new CAFE("Carnahan, Jean", "MO", "D", 4250, 3.67669361, 1, 1);
                yield return new CAFE("Cochran, Thad", "MS", "R", 9000, 3.977723605, 0, 1);
                yield return new CAFE("Lott, Trent", "MS", "R", 24000, 4.389166084, 0, 1);
                yield return new CAFE("Baucus, Max", "MT", "D", 18500, 4.278753601, 1, 1);
                yield return new CAFE("Burns, Conrad", "MT", "R", 25000, 4.40654018, 0, 1);
                yield return new CAFE("Edwards, John", "NC", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE("Helms, Jesse", "NC", "R", 10500, 4.041392685, 0, 1);
                yield return new CAFE("Conrad, Kent", "ND", "D", 21125, 4.334956116, 1, 1);
                yield return new CAFE("Dorgan, Byron", "ND", "D", 15000, 4.190331698, 1, 1);
                yield return new CAFE("Hagel, Charles", "NE", "R", 10400, 4.037426498, 0, 1);
                yield return new CAFE("Nelson, Ben", "NE", "D", 5000, 3.740362689, 1, 1);
                yield return new CAFE("Gregg, Judd", "NH", "R", 5000, 3.740362689, 0, 0);
                yield return new CAFE("Smith, Bob", "NH", "R", 15500, 4.204119983, 0, 1);
                yield return new CAFE("Corzine, Jon", "NJ", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE("Torricelli, Robert", "NJ", "D", 6150, 3.822821645, 1, 0);
                yield return new CAFE("Bingaman, Jeff", "NM", "D", 1000, 3.176091259, 1, 0);
                yield return new CAFE("Domenici, Pete", "NM", "R", 15000, 4.190331698, 0, 1);
                yield return new CAFE("Reid, Harry", "NV", "D", 1000, 3.176091259, 1, 0);
                yield return new CAFE("Ensign, John", "NV", "R", 27500, 4.447158031, 0, 1);
                yield return new CAFE("Clinton, Hillary", "NY", "D", 6530, 3.846955325, 1, 0);
                yield return new CAFE("Schumer, Charles", "NY", "D", 2000, 3.397940009, 1, 0);
                yield return new CAFE("DeWine, Mike", "OH", "R", 48350, 4.688864568, 0, 1);
                yield return new CAFE("Voinovich, George", "OH", "R", 41224, 4.620385937, 0, 1);
                yield return new CAFE("Inhofe, James", "OK", "R", 28600, 4.463892989, 0, 1);
                yield return new CAFE("Nickles, Don", "OK", "R", 35500, 4.556302501, 0, 1);
                yield return new CAFE("Smith, Gordon", "OR", "R", 18500, 4.278753601, 0, 0);
                yield return new CAFE("Wyden, Ron", "OR", "D", 2000, 3.397940009, 1, 0);
                yield return new CAFE("Santorum, Rick", "PA", "R", 18000, 4.267171728, 0, 1);
                yield return new CAFE("Specter, Arlen", "PA", "R", 25500, 4.414973348, 0, 1);
                yield return new CAFE("Chafee, Lincoln", "RI", "R", 250, 2.875061263, 0, 0);
                yield return new CAFE("Reed, Jack", "RI", "D", 3000, 3.544068044, 1, 0);
                yield return new CAFE("Hollings, Ernest", "SC", "D", 10500, 4.041392685, 1, 0);
                yield return new CAFE("Thurmond, Strom", "SC", "R", 7350, 3.894869657, 0, 1);
                yield return new CAFE("Daschle, Thomas", "SD", "D", 20000, 4.311753861, 1, 0);
                yield return new CAFE("Johnson, Tim", "SD", "D", 4500, 3.698970004, 1, 1);
                yield return new CAFE("Frist, William", "TN", "R", 22250, 4.356981401, 0, 1);
                yield return new CAFE("Thompson, Fred", "TN", "R", 13250, 4.138302698, 0, 1);
                yield return new CAFE("Gramm, Phil", "TX", "R", 18550, 4.27989498, 0, 1);
                yield return new CAFE("Hutchison, Kay B.", "TX", "R", 12000, 4.096910013, 0, 1);
                yield return new CAFE("Bennett, Robert", "UT", "R", 6000, 3.812913357, 0, 1);
                yield return new CAFE("Hatch, Orrin", "UT", "R", 22400, 4.359835482, 0, 1);
                yield return new CAFE("Allen, George", "VA", "R", 14500, 4.176091259, 0, 1);
                yield return new CAFE("Warner, John", "VA", "R", 26800, 4.436162647, 0, 1);
                yield return new CAFE("Jeffords, James", "VT", "I", 8000, 3.929418926, 1, 0);
                yield return new CAFE("Leahy, Patrick", "VT", "D", 750, 3.096910013, 1, 0);
                yield return new CAFE("Cantwell, Maria", "WA", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE("Murray, Patty", "WA", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE("Feingold, Russell", "WI", "D", 1326, 3.261500773, 1, 1);
                yield return new CAFE("Kohl, Herb", "WI", "D", 0, 2.698970004, 1, 1);
                yield return new CAFE("Rockefeller, John", "WV", "D", 26000, 4.423245874, 1, 0);
                yield return new CAFE("Byrd, Robert", "WV", "D", 14000, 4.161368002, 1, 1);
                yield return new CAFE("Enzi, Mike", "WY", "R", 2000, 3.397940009, 0, 1);
                yield return new CAFE("Thomas, Craig", "WY", "R", 8600, 3.959041392, 0, 1);
            }
        }
    }
}
