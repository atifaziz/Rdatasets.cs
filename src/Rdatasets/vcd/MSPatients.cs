// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Diagnosis of Multiple Sclerosis
    /// </summary>

    public class MSPatients
    {
        public readonly string κ;
        public readonly int Certain_Winnipeg;
        public readonly int Probable_Winnipeg;
        public readonly int Possible_Winnipeg;
        public readonly int Doubtful_Winnipeg;
        public readonly int Certain_New_Orleans;
        public readonly int Probable_New_Orleans;
        public readonly int Possible_New_Orleans;
        public readonly int Doubtful_New_Orleans;

        public MSPatients(string κ, int Certain_Winnipeg, int Probable_Winnipeg, int Possible_Winnipeg, int Doubtful_Winnipeg, int Certain_New_Orleans, int Probable_New_Orleans, int Possible_New_Orleans, int Doubtful_New_Orleans)
        {
            this.κ = κ;
            this.Certain_Winnipeg = Certain_Winnipeg;
            this.Probable_Winnipeg = Probable_Winnipeg;
            this.Possible_Winnipeg = Possible_Winnipeg;
            this.Doubtful_Winnipeg = Doubtful_Winnipeg;
            this.Certain_New_Orleans = Certain_New_Orleans;
            this.Probable_New_Orleans = Probable_New_Orleans;
            this.Possible_New_Orleans = Possible_New_Orleans;
            this.Doubtful_New_Orleans = Doubtful_New_Orleans;
        }

        public static IEnumerable<MSPatients> Data
        {
            get
            {
                yield return new MSPatients("Certain", 38, 5, 0, 1, 5, 3, 0, 0);
                yield return new MSPatients("Probable", 33, 11, 3, 0, 3, 11, 4, 0);
                yield return new MSPatients("Possible", 10, 14, 5, 6, 2, 13, 3, 4);
                yield return new MSPatients("Doubtful", 3, 7, 3, 10, 1, 2, 4, 14);
            }
        }
    }
}
