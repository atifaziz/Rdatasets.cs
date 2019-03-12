// ReSharper disable All

namespace Rdatasets.sandwich
{
    using System.Collections.Generic;

    /// <summary>
    /// US Expenditures for Public Schools
    /// </summary>

    public class PublicSchools
    {
        public readonly string κ;
        public readonly int? Expenditure;
        public readonly int Income;

        public PublicSchools(string κ, int? Expenditure, int Income)
        {
            this.κ = κ;
            this.Expenditure = Expenditure;
            this.Income = Income;
        }

        public static IEnumerable<PublicSchools> Data
        {
            get
            {
                yield return new PublicSchools("Alabama", 275, 6247);
                yield return new PublicSchools("Alaska", 821, 10851);
                yield return new PublicSchools("Arizona", 339, 7374);
                yield return new PublicSchools("Arkansas", 275, 6183);
                yield return new PublicSchools("California", 387, 8850);
                yield return new PublicSchools("Colorado", 452, 8001);
                yield return new PublicSchools("Connecticut", 531, 8914);
                yield return new PublicSchools("Delaware", 424, 8604);
                yield return new PublicSchools("Florida", 316, 7505);
                yield return new PublicSchools("Georgia", 265, 6700);
                yield return new PublicSchools("Hawaii", 403, 8380);
                yield return new PublicSchools("Idaho", 304, 6813);
                yield return new PublicSchools("Illinois", 437, 8745);
                yield return new PublicSchools("Indiana", 345, 7696);
                yield return new PublicSchools("Iowa", 431, 7873);
                yield return new PublicSchools("Kansas", 355, 8001);
                yield return new PublicSchools("Kentucky", 260, 6615);
                yield return new PublicSchools("Louisiana", 316, 6640);
                yield return new PublicSchools("Maine", 327, 6333);
                yield return new PublicSchools("Maryland", 427, 8306);
                yield return new PublicSchools("Massachusetts", 427, 8063);
                yield return new PublicSchools("Michigan", 466, 8442);
                yield return new PublicSchools("Minnesota", 477, 7847);
                yield return new PublicSchools("Mississippi", 259, 5736);
                yield return new PublicSchools("Missouri", 274, 7342);
                yield return new PublicSchools("Montana", 433, 7051);
                yield return new PublicSchools("Nebraska", 294, 7391);
                yield return new PublicSchools("Nevada", 359, 9032);
                yield return new PublicSchools("New Hampshire", 279, 7277);
                yield return new PublicSchools("New Jersey", 423, 8818);
                yield return new PublicSchools("New Mexico", 388, 6505);
                yield return new PublicSchools("New York", 447, 8267);
                yield return new PublicSchools("North Carolina", 335, 6607);
                yield return new PublicSchools("North Dakota", 311, 7478);
                yield return new PublicSchools("Ohio", 322, 7812);
                yield return new PublicSchools("Oklahoma", 320, 6951);
                yield return new PublicSchools("Oregon", 397, 7839);
                yield return new PublicSchools("Pennsylvania", 412, 7733);
                yield return new PublicSchools("Rhode Island", 342, 7526);
                yield return new PublicSchools("South Carolina", 315, 6242);
                yield return new PublicSchools("South Dakota", 321, 6841);
                yield return new PublicSchools("Tennessee", 268, 6489);
                yield return new PublicSchools("Texas", 315, 7697);
                yield return new PublicSchools("Utah", 417, 6622);
                yield return new PublicSchools("Vermont", 353, 6541);
                yield return new PublicSchools("Virginia", 356, 7624);
                yield return new PublicSchools("Washington", 415, 8450);
                yield return new PublicSchools("Washington DC", 428, 10022);
                yield return new PublicSchools("West Virginia", 320, 6456);
                yield return new PublicSchools("Wisconsin", null, 7597);
                yield return new PublicSchools("Wyoming", 500, 9096);
            }
        }
    }
}
