// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// CAFE
    /// </summary>

    public class CAFE
    {
        public readonly int κ;
        public readonly string Senator;
        public readonly string State;
        public readonly string Party;
        public readonly int Contribution;
        public readonly double LogContr;
        public readonly int Dem;
        public readonly int Vote;

        public CAFE(int κ, string Senator, string State, string Party, int Contribution, double LogContr, int Dem, int Vote)
        {
            this.κ = κ;
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
                yield return new CAFE(1, "Murkowski, Frank", "AK", "R", 19700, 4.305351369, 0, 1);
                yield return new CAFE(2, "Stevens, Ted", "AK", "R", 13000, 4.130333768, 0, 1);
                yield return new CAFE(3, "Sessions, Jeff", "AL", "R", 9500, 4, 0, 1);
                yield return new CAFE(4, "Shelby, Richard", "AL", "R", 25000, 4.40654018, 0, 1);
                yield return new CAFE(5, "Hutchinson, Tim", "AR", "R", 4900, 3.73239376, 0, 1);
                yield return new CAFE(6, "Lincoln, Blanche", "AR", "D", 5500, 3.77815125, 1, 1);
                yield return new CAFE(7, "McCain, John", "AZ", "R", 29350, 4.474944335, 0, 0);
                yield return new CAFE(8, "Kyl, Jon", "AZ", "R", 14500, 4.176091259, 0, 1);
                yield return new CAFE(9, "Boxer, Barbara", "CA", "D", 1500, 3.301029996, 1, 0);
                yield return new CAFE(10, "Feinstein, Dianne", "CA", "D", 9750, 4.010723865, 1, 0);
                yield return new CAFE(11, "Allard, Wayne", "CO", "R", 7500, 3.903089987, 0, 1);
                yield return new CAFE(12, "Campbell, Ben N.", "CO", "R", 4000, 3.653212514, 0, 1);
                yield return new CAFE(13, "Dodd, Christopher", "CT", "D", 500, 3, 1, 0);
                yield return new CAFE(14, "Lieberman, Joseph", "CT", "D", 3000, 3.544068044, 1, 0);
                yield return new CAFE(15, "Carper, Thomas", "DE", "D", 17640, 4.258637283, 1, 1);
                yield return new CAFE(16, "Biden Jr, Joseph", "DE", "D", 5125, 3.750122527, 1, 0);
                yield return new CAFE(17, "Graham, Bob", "FL", "D", 7000, 3.875061263, 1, 0);
                yield return new CAFE(18, "Nelson, Bill", "FL", "D", 300, 2.903089987, 1, 0);
                yield return new CAFE(19, "Cleland, Max", "GA", "D", 4500, 3.698970004, 1, 1);
                yield return new CAFE(20, "Miller, Zell", "GA", "D", 1000, 3.176091259, 1, 1);
                yield return new CAFE(21, "Akaka, Daniel", "HI", "D", 2350, 3.45484486, 1, 0);
                yield return new CAFE(22, "Inouye, Daniel", "HI", "D", 7000, 3.875061263, 1, 0);
                yield return new CAFE(23, "Harkin, Tom", "IA", "D", 4000, 3.653212514, 1, 0);
                yield return new CAFE(24, "Grassley, Chuck", "IA", "R", 22500, 4.361727836, 0, 1);
                yield return new CAFE(25, "Craig, Larry", "ID", "R", 26800, 4.436162647, 0, 1);
                yield return new CAFE(26, "Crapo, Mike", "ID", "R", 10000, 4.021189299, 0, 1);
                yield return new CAFE(27, "Durbin, Richard", "IL", "D", 15600, 4.206825876, 1, 0);
                yield return new CAFE(28, "Fitzgerald, Peter", "IL", "R", 13450, 4.144574208, 0, 1);
                yield return new CAFE(29, "Bayh, Evan", "IN", "D", 21000, 4.33243846, 1, 1);
                yield return new CAFE(30, "Lugar, Richard", "IN", "R", 23500, 4.380211242, 0, 1);
                yield return new CAFE(31, "Brownback, Sam", "KS", "R", 13500, 4.146128036, 0, 1);
                yield return new CAFE(32, "Roberts, Pat", "KS", "R", 9750, 4.010723865, 0, 1);
                yield return new CAFE(33, "Bunning, Jim", "KY", "R", 28850, 4.467608106, 0, 1);
                yield return new CAFE(34, "McConnell, Mitch", "KY", "R", 25000, 4.40654018, 0, 1);
                yield return new CAFE(35, "Breaux, John", "LA", "D", 18150, 4.270678836, 1, 1);
                yield return new CAFE(36, "Landrieu, Mary", "LA", "D", 5000, 3.740362689, 1, 1);
                yield return new CAFE(37, "Kennedy, Edward", "MA", "D", 3150, 3.562292864, 1, 0);
                yield return new CAFE(38, "Kerry, John", "MA", "D", 750, 3.096910013, 1, 0);
                yield return new CAFE(39, "Sarbanes, Paul", "MD", "D", 1500, 3.301029996, 1, 0);
                yield return new CAFE(40, "Mikulski, Barbara", "MD", "D", 18600, 4.281033367, 1, 1);
                yield return new CAFE(41, "Collins, Susan", "ME", "R", 4000, 3.653212514, 0, 0);
                yield return new CAFE(42, "Snowe, Olympia", "ME", "R", 6100, 3.819543936, 0, 0);
                yield return new CAFE(43, "Levin, Carl", "MI", "D", 133250, 5.126293791, 1, 1);
                yield return new CAFE(44, "Stabenow, Debbie", "MI", "D", 51668, 4.717404187, 1, 1);
                yield return new CAFE(45, "Dayton, Mark", "MN", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE(46, "Wellstone, Paul", "MN", "D", 800, 3.113943352, 1, 0);
                yield return new CAFE(47, "Bond, Christopher", "MO", "R", 48939, 4.694069678, 0, 1);
                yield return new CAFE(48, "Carnahan, Jean", "MO", "D", 4250, 3.67669361, 1, 1);
                yield return new CAFE(49, "Cochran, Thad", "MS", "R", 9000, 3.977723605, 0, 1);
                yield return new CAFE(50, "Lott, Trent", "MS", "R", 24000, 4.389166084, 0, 1);
                yield return new CAFE(51, "Baucus, Max", "MT", "D", 18500, 4.278753601, 1, 1);
                yield return new CAFE(52, "Burns, Conrad", "MT", "R", 25000, 4.40654018, 0, 1);
                yield return new CAFE(53, "Edwards, John", "NC", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE(54, "Helms, Jesse", "NC", "R", 10500, 4.041392685, 0, 1);
                yield return new CAFE(55, "Conrad, Kent", "ND", "D", 21125, 4.334956116, 1, 1);
                yield return new CAFE(56, "Dorgan, Byron", "ND", "D", 15000, 4.190331698, 1, 1);
                yield return new CAFE(57, "Hagel, Charles", "NE", "R", 10400, 4.037426498, 0, 1);
                yield return new CAFE(58, "Nelson, Ben", "NE", "D", 5000, 3.740362689, 1, 1);
                yield return new CAFE(59, "Gregg, Judd", "NH", "R", 5000, 3.740362689, 0, 0);
                yield return new CAFE(60, "Smith, Bob", "NH", "R", 15500, 4.204119983, 0, 1);
                yield return new CAFE(61, "Corzine, Jon", "NJ", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE(62, "Torricelli, Robert", "NJ", "D", 6150, 3.822821645, 1, 0);
                yield return new CAFE(63, "Bingaman, Jeff", "NM", "D", 1000, 3.176091259, 1, 0);
                yield return new CAFE(64, "Domenici, Pete", "NM", "R", 15000, 4.190331698, 0, 1);
                yield return new CAFE(65, "Reid, Harry", "NV", "D", 1000, 3.176091259, 1, 0);
                yield return new CAFE(66, "Ensign, John", "NV", "R", 27500, 4.447158031, 0, 1);
                yield return new CAFE(67, "Clinton, Hillary", "NY", "D", 6530, 3.846955325, 1, 0);
                yield return new CAFE(68, "Schumer, Charles", "NY", "D", 2000, 3.397940009, 1, 0);
                yield return new CAFE(69, "DeWine, Mike", "OH", "R", 48350, 4.688864568, 0, 1);
                yield return new CAFE(70, "Voinovich, George", "OH", "R", 41224, 4.620385937, 0, 1);
                yield return new CAFE(71, "Inhofe, James", "OK", "R", 28600, 4.463892989, 0, 1);
                yield return new CAFE(72, "Nickles, Don", "OK", "R", 35500, 4.556302501, 0, 1);
                yield return new CAFE(73, "Smith, Gordon", "OR", "R", 18500, 4.278753601, 0, 0);
                yield return new CAFE(74, "Wyden, Ron", "OR", "D", 2000, 3.397940009, 1, 0);
                yield return new CAFE(75, "Santorum, Rick", "PA", "R", 18000, 4.267171728, 0, 1);
                yield return new CAFE(76, "Specter, Arlen", "PA", "R", 25500, 4.414973348, 0, 1);
                yield return new CAFE(77, "Chafee, Lincoln", "RI", "R", 250, 2.875061263, 0, 0);
                yield return new CAFE(78, "Reed, Jack", "RI", "D", 3000, 3.544068044, 1, 0);
                yield return new CAFE(79, "Hollings, Ernest", "SC", "D", 10500, 4.041392685, 1, 0);
                yield return new CAFE(80, "Thurmond, Strom", "SC", "R", 7350, 3.894869657, 0, 1);
                yield return new CAFE(81, "Daschle, Thomas", "SD", "D", 20000, 4.311753861, 1, 0);
                yield return new CAFE(82, "Johnson, Tim", "SD", "D", 4500, 3.698970004, 1, 1);
                yield return new CAFE(83, "Frist, William", "TN", "R", 22250, 4.356981401, 0, 1);
                yield return new CAFE(84, "Thompson, Fred", "TN", "R", 13250, 4.138302698, 0, 1);
                yield return new CAFE(85, "Gramm, Phil", "TX", "R", 18550, 4.27989498, 0, 1);
                yield return new CAFE(86, "Hutchison, Kay B.", "TX", "R", 12000, 4.096910013, 0, 1);
                yield return new CAFE(87, "Bennett, Robert", "UT", "R", 6000, 3.812913357, 0, 1);
                yield return new CAFE(88, "Hatch, Orrin", "UT", "R", 22400, 4.359835482, 0, 1);
                yield return new CAFE(89, "Allen, George", "VA", "R", 14500, 4.176091259, 0, 1);
                yield return new CAFE(90, "Warner, John", "VA", "R", 26800, 4.436162647, 0, 1);
                yield return new CAFE(91, "Jeffords, James", "VT", "I", 8000, 3.929418926, 1, 0);
                yield return new CAFE(92, "Leahy, Patrick", "VT", "D", 750, 3.096910013, 1, 0);
                yield return new CAFE(93, "Cantwell, Maria", "WA", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE(94, "Murray, Patty", "WA", "D", 0, 2.698970004, 1, 0);
                yield return new CAFE(95, "Feingold, Russell", "WI", "D", 1326, 3.261500773, 1, 1);
                yield return new CAFE(96, "Kohl, Herb", "WI", "D", 0, 2.698970004, 1, 1);
                yield return new CAFE(97, "Rockefeller, John", "WV", "D", 26000, 4.423245874, 1, 0);
                yield return new CAFE(98, "Byrd, Robert", "WV", "D", 14000, 4.161368002, 1, 1);
                yield return new CAFE(99, "Enzi, Mike", "WY", "R", 2000, 3.397940009, 0, 1);
                yield return new CAFE(100, "Thomas, Craig", "WY", "R", 8600, 3.959041392, 0, 1);
            }
        }
    }
}
