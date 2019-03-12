// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// U. S. State Public-School Expenditures
    /// </summary>

    public class Anscombe
    {
        public readonly string κ;
        public readonly int education;
        public readonly int income;
        public readonly double young;
        public readonly int urban;

        public Anscombe(string κ, int education, int income, double young, int urban)
        {
            this.κ = κ;
            this.education = education;
            this.income = income;
            this.young = young;
            this.urban = urban;
        }

        public static IEnumerable<Anscombe> Data
        {
            get
            {
                yield return new Anscombe("ME", 189, 2824, 350.7, 508);
                yield return new Anscombe("NH", 169, 3259, 345.9, 564);
                yield return new Anscombe("VT", 230, 3072, 348.5, 322);
                yield return new Anscombe("MA", 168, 3835, 335.3, 846);
                yield return new Anscombe("RI", 180, 3549, 327.1, 871);
                yield return new Anscombe("CT", 193, 4256, 341, 774);
                yield return new Anscombe("NY", 261, 4151, 326.2, 856);
                yield return new Anscombe("NJ", 214, 3954, 333.5, 889);
                yield return new Anscombe("PA", 201, 3419, 326.2, 715);
                yield return new Anscombe("OH", 172, 3509, 354.5, 753);
                yield return new Anscombe("IN", 194, 3412, 359.3, 649);
                yield return new Anscombe("IL", 189, 3981, 348.9, 830);
                yield return new Anscombe("MI", 233, 3675, 369.2, 738);
                yield return new Anscombe("WI", 209, 3363, 360.7, 659);
                yield return new Anscombe("MN", 262, 3341, 365.4, 664);
                yield return new Anscombe("IO", 234, 3265, 343.8, 572);
                yield return new Anscombe("MO", 177, 3257, 336.1, 701);
                yield return new Anscombe("ND", 177, 2730, 369.1, 443);
                yield return new Anscombe("SD", 187, 2876, 368.7, 446);
                yield return new Anscombe("NE", 148, 3239, 349.9, 615);
                yield return new Anscombe("KA", 196, 3303, 339.9, 661);
                yield return new Anscombe("DE", 248, 3795, 375.9, 722);
                yield return new Anscombe("MD", 247, 3742, 364.1, 766);
                yield return new Anscombe("DC", 246, 4425, 352.1, 1000);
                yield return new Anscombe("VA", 180, 3068, 353, 631);
                yield return new Anscombe("WV", 149, 2470, 328.8, 390);
                yield return new Anscombe("NC", 155, 2664, 354.1, 450);
                yield return new Anscombe("SC", 149, 2380, 376.7, 476);
                yield return new Anscombe("GA", 156, 2781, 370.6, 603);
                yield return new Anscombe("FL", 191, 3191, 336, 805);
                yield return new Anscombe("KY", 140, 2645, 349.3, 523);
                yield return new Anscombe("TN", 137, 2579, 342.8, 588);
                yield return new Anscombe("AL", 112, 2337, 362.2, 584);
                yield return new Anscombe("MS", 130, 2081, 385.2, 445);
                yield return new Anscombe("AR", 134, 2322, 351.9, 500);
                yield return new Anscombe("LA", 162, 2634, 389.6, 661);
                yield return new Anscombe("OK", 135, 2880, 329.8, 680);
                yield return new Anscombe("TX", 155, 3029, 369.4, 797);
                yield return new Anscombe("MT", 238, 2942, 368.9, 534);
                yield return new Anscombe("ID", 170, 2668, 367.7, 541);
                yield return new Anscombe("WY", 238, 3190, 365.6, 605);
                yield return new Anscombe("CO", 192, 3340, 358.1, 785);
                yield return new Anscombe("NM", 227, 2651, 421.5, 698);
                yield return new Anscombe("AZ", 207, 3027, 387.5, 796);
                yield return new Anscombe("UT", 201, 2790, 412.4, 804);
                yield return new Anscombe("NV", 225, 3957, 385.1, 809);
                yield return new Anscombe("WA", 215, 3688, 341.3, 726);
                yield return new Anscombe("OR", 233, 3317, 332.7, 671);
                yield return new Anscombe("CA", 273, 3968, 348.4, 909);
                yield return new Anscombe("AK", 372, 4146, 439.7, 484);
                yield return new Anscombe("HI", 212, 3513, 382.9, 831);
            }
        }
    }
}
