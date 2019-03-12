// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// SampleFG
    /// </summary>

    public class SampleFG
    {
        public readonly int κ;
        public readonly int ID;
        public readonly string PlayerID;
        public readonly string LastName;
        public readonly string FirstName;
        public readonly int Year;
        public readonly string Team;
        public readonly int Date;
        public readonly int FGAttempts;
        public readonly int FGMade;
        public readonly int Attempt;
        public readonly int Result;
        public readonly int Yards;
        public readonly int Block;

        public SampleFG(int κ, int ID, string PlayerID, string LastName, string FirstName, int Year, string Team, int Date, int FGAttempts, int FGMade, int Attempt, int Result, int Yards, int Block)
        {
            this.κ = κ;
            this.ID = ID;
            this.PlayerID = PlayerID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Year = Year;
            this.Team = Team;
            this.Date = Date;
            this.FGAttempts = FGAttempts;
            this.FGMade = FGMade;
            this.Attempt = Attempt;
            this.Result = Result;
            this.Yards = Yards;
            this.Block = Block;
        }

        public static IEnumerable<SampleFG> Data
        {
            get
            {
                yield return new SampleFG(1, 5255, "ellia001", "Elling", "Aaron", 2003, "Min", 120703, 3, 2, 3, 1, 35, 0);
                yield return new SampleFG(2, 1802, "browj014", "Brown", "Josh", 2007, "Sea", 123007, 2, 2, 2, 1, 51, 0);
                yield return new SampleFG(3, 7941, "longr003", "Longwell", "Ryan", 2000, "GB", 100100, 1, 1, 1, 1, 42, 0);
                yield return new SampleFG(4, 5836, "grahs002", "Graham", "Shayne", 2002, "Car", 120102, 4, 2, 4, 1, 44, 0);
                yield return new SampleFG(5, 7168, "vinaa001", "Vinatieri", "Adam", 2001, "NE", 120201, 1, 1, 1, 1, 28, 0);
                yield return new SampleFG(6, 3763, "wilkj002", "Wilkins", "Jeff", 2005, "SL", 91105, 4, 4, 2, 1, 41, 0);
                yield return new SampleFG(7, 5256, "ellia001", "Elling", "Aaron", 2003, "Min", 121403, 1, 1, 1, 1, 22, 0);
                yield return new SampleFG(8, 7445, "lindr001", "Lindell", "Rian", 2001, "Sea", 120201, 4, 2, 3, 0, 48, 0);
                yield return new SampleFG(9, 2992, "stovm001", "Stover", "Matt", 2005, "Bal", 103105, 5, 4, 2, 0, 43, 0);
                yield return new SampleFG(10, 6523, "chanj001", "Chandler", "Jeff", 2002, "SF", 123002, 2, 2, 1, 1, 19, 0);
                yield return new SampleFG(11, 8285, "akerd001", "Akers", "David", 2000, "Phi", 112600, 3, 3, 2, 1, 33, 0);
                yield return new SampleFG(12, 7612, "blanc001", "Blanchard", "Cary", 2000, "Arz", 100100, 3, 2, 3, 1, 27, 0);
                yield return new SampleFG(13, 6659, "gramb001", "Gramatica", "Bill", 2001, "Arz", 120201, 5, 4, 4, 0, 48, 0);
                yield return new SampleFG(14, 1505, "feelj001", "Feely", "Jay", 2007, "Mia", 100707, 4, 4, 2, 1, 40, 0);
                yield return new SampleFG(15, 2190, "dawsp001", "Dawson", "Phil", 2006, "Cle", 102906, 3, 2, 2, 0, 26, 0);
                yield return new SampleFG(16, 5372, "bried001", "Brien", "Doug", 2003, "NYJ", 112303, 2, 2, 1, 1, 36, 0);
                yield return new SampleFG(17, 226, "dawsp001", "Dawson", "Phil", 2008, "Cle", 101308, 3, 2, 2, 0, 51, 0);
                yield return new SampleFG(18, 4332, "mareo001", "Mare", "Olindo", 2004, "Mia", 122604, 1, 1, 1, 1, 51, 0);
                yield return new SampleFG(19, 2196, "dawsp001", "Dawson", "Phil", 2006, "Cle", 110506, 6, 6, 5, 1, 36, 0);
                yield return new SampleFG(20, 2387, "vinaa001", "Vinatieri", "Adam", 2006, "Ind", 122406, 1, 1, 1, 1, 33, 0);
                yield return new SampleFG(21, 5319, "carnj001", "Carney", "John", 2003, "NO", 121403, 2, 1, 2, 0, 49, 0);
                yield return new SampleFG(22, 5133, "vandm003", "Vanderjagt", "Mike", 2003, "Ind", 102603, 3, 3, 3, 1, 22, 0);
                yield return new SampleFG(23, 5919, "cundb001", "Cundiff", "Billy", 2002, "Dal", 100602, 2, 1, 1, 0, 45, 0);
                yield return new SampleFG(24, 4486, "janis001", "Janikowski", "Sebastian", 2004, "Oak", 102404, 4, 4, 3, 1, 44, 0);
                yield return new SampleFG(25, 5402, "janis001", "Janikowski", "Sebastian", 2003, "Oak", 111603, 1, 0, 1, 0, 52, 0);
                yield return new SampleFG(26, 4134, "elamj001", "Elam", "Jason", 2004, "Den", 112104, 2, 2, 1, 1, 48, 0);
                yield return new SampleFG(27, 1198, "grahs002", "Graham", "Shayne", 2007, "Cin", 102107, 1, 1, 1, 1, 20, 0);
                yield return new SampleFG(28, 1212, "grahs002", "Graham", "Shayne", 2007, "Cin", 120207, 2, 1, 2, 1, 24, 0);
                yield return new SampleFG(29, 8484, "delga001", "Del Greco", "Al", 2000, "Ten", 120300, 5, 5, 1, 1, 26, 0);
                yield return new SampleFG(30, 6127, "andem001", "Andersen", "Morten", 2002, "KC", 102002, 3, 2, 3, 0, 43, 0);
            }
        }
    }
}
