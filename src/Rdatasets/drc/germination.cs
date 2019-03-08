// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Germination of three crops
    /// </summary>

    public class germination
    {
        public readonly int temp;
        public readonly string species;
        public readonly int start;
        public readonly string end;
        public readonly int germinated;

        public germination(int temp, string species, int start, string end, int germinated)
        {
            this.temp = temp;
            this.species = species;
            this.start = start;
            this.end = end;
            this.germinated = germinated;
        }

        public static IEnumerable<germination> Data
        {
            get
            {
                yield return new germination(10, "wheat", 0, "1", 0);
                yield return new germination(10, "wheat", 1, "2", 0);
                yield return new germination(10, "wheat", 2, "3", 0);
                yield return new germination(10, "wheat", 3, "4", 0);
                yield return new germination(10, "wheat", 4, "5", 0);
                yield return new germination(10, "wheat", 5, "6", 4);
                yield return new germination(10, "wheat", 6, "7", 6);
                yield return new germination(10, "wheat", 7, "9", 8);
                yield return new germination(10, "wheat", 9, "10", 0);
                yield return new germination(10, "wheat", 10, "11", 0);
                yield return new germination(10, "wheat", 11, "12", 0);
                yield return new germination(10, "wheat", 12, "13", 0);
                yield return new germination(10, "wheat", 13, "14", 0);
                yield return new germination(10, "wheat", 14, "16", 0);
                yield return new germination(10, "wheat", 16, "17", 0);
                yield return new germination(10, "wheat", 17, "18", 0);
                yield return new germination(10, "wheat", 18, "Inf", 2);
                yield return new germination(10, "mungbean", 0, "2", 0);
                yield return new germination(10, "mungbean", 2, "3", 4);
                yield return new germination(10, "mungbean", 3, "4", 0);
                yield return new germination(10, "mungbean", 4, "5", 0);
                yield return new germination(10, "mungbean", 5, "6", 9);
                yield return new germination(10, "mungbean", 6, "7", 7);
                yield return new germination(10, "mungbean", 7, "Inf", 0);
                yield return new germination(16, "wheat", 0, "2", 0);
                yield return new germination(16, "wheat", 2, "3", 0);
                yield return new germination(16, "wheat", 3, "4", 11);
                yield return new germination(16, "wheat", 4, "5", 7);
                yield return new germination(16, "wheat", 5, "6", 0);
                yield return new germination(16, "wheat", 6, "7", 1);
                yield return new germination(16, "wheat", 7, "9", 0);
                yield return new germination(16, "wheat", 9, "10", 0);
                yield return new germination(16, "wheat", 10, "11", 0);
                yield return new germination(16, "wheat", 11, "12", 0);
                yield return new germination(16, "wheat", 12, "13", 0);
                yield return new germination(16, "wheat", 13, "14", 0);
                yield return new germination(16, "wheat", 14, "16", 0);
                yield return new germination(16, "wheat", 16, "17", 0);
                yield return new germination(16, "wheat", 17, "18", 0);
                yield return new germination(16, "wheat", 18, "Inf", 1);
                yield return new germination(16, "rice", 0, "2", 0);
                yield return new germination(16, "rice", 2, "3", 0);
                yield return new germination(16, "rice", 3, "4", 0);
                yield return new germination(16, "rice", 4, "5", 0);
                yield return new germination(16, "rice", 5, "6", 0);
                yield return new germination(16, "rice", 6, "7", 4);
                yield return new germination(16, "rice", 7, "9", 4);
                yield return new germination(16, "rice", 9, "10", 2);
                yield return new germination(16, "rice", 10, "11", 0);
                yield return new germination(16, "rice", 11, "12", 0);
                yield return new germination(16, "rice", 12, "13", 0);
                yield return new germination(16, "rice", 13, "16", 0);
                yield return new germination(16, "rice", 16, "17", 0);
                yield return new germination(16, "rice", 17, "18", 0);
                yield return new germination(16, "rice", 18, "Inf", 10);
                yield return new germination(16, "mungbean", 0, "1", 0);
                yield return new germination(16, "mungbean", 1, "2", 1);
                yield return new germination(16, "mungbean", 2, "3", 7);
                yield return new germination(16, "mungbean", 3, "4", 12);
                yield return new germination(16, "mungbean", 4, "5", 0);
                yield return new germination(16, "mungbean", 5, "6", 0);
                yield return new germination(16, "mungbean", 5, "Inf", 0);
                yield return new germination(22, "wheat", 0, "2", 0);
                yield return new germination(22, "wheat", 2, "3", 1);
                yield return new germination(22, "wheat", 3, "4", 12);
                yield return new germination(22, "wheat", 4, "5", 3);
                yield return new germination(22, "wheat", 5, "6", 0);
                yield return new germination(22, "wheat", 6, "7", 3);
                yield return new germination(22, "wheat", 7, "9", 0);
                yield return new germination(22, "wheat", 9, "10", 0);
                yield return new germination(22, "wheat", 10, "11", 0);
                yield return new germination(22, "wheat", 11, "12", 0);
                yield return new germination(22, "wheat", 12, "13", 0);
                yield return new germination(22, "wheat", 13, "14", 0);
                yield return new germination(22, "wheat", 14, "16", 0);
                yield return new germination(22, "wheat", 16, "17", 0);
                yield return new germination(22, "wheat", 17, "18", 0);
                yield return new germination(22, "wheat", 18, "Inf", 1);
                yield return new germination(22, "rice", 0, "2", 0);
                yield return new germination(22, "rice", 2, "3", 0);
                yield return new germination(22, "rice", 3, "4", 5);
                yield return new germination(22, "rice", 4, "5", 2);
                yield return new germination(22, "rice", 5, "6", 0);
                yield return new germination(22, "rice", 6, "7", 2);
                yield return new germination(22, "rice", 7, "9", 0);
                yield return new germination(22, "rice", 9, "10", 2);
                yield return new germination(22, "rice", 10, "11", 0);
                yield return new germination(22, "rice", 11, "12", 0);
                yield return new germination(22, "rice", 12, "13", 0);
                yield return new germination(22, "rice", 13, "15", 0);
                yield return new germination(22, "rice", 15, "16", 0);
                yield return new germination(22, "rice", 16, "17", 0);
                yield return new germination(22, "rice", 17, "18", 0);
                yield return new germination(22, "rice", 18, "Inf", 9);
                yield return new germination(28, "wheat", 0, "1", 0);
                yield return new germination(28, "wheat", 1, "2", 0);
                yield return new germination(28, "wheat", 2, "3", 0);
                yield return new germination(28, "wheat", 3, "4", 8);
                yield return new germination(28, "wheat", 4, "5", 0);
                yield return new germination(28, "wheat", 5, "6", 8);
                yield return new germination(28, "wheat", 6, "7", 3);
                yield return new germination(28, "wheat", 7, "9", 0);
                yield return new germination(28, "wheat", 9, "10", 0);
                yield return new germination(28, "wheat", 10, "11", 0);
                yield return new germination(28, "wheat", 11, "12", 0);
                yield return new germination(28, "wheat", 12, "13", 0);
                yield return new germination(28, "wheat", 13, "14", 0);
                yield return new germination(28, "wheat", 14, "16", 0);
                yield return new germination(28, "wheat", 16, "17", 0);
                yield return new germination(28, "wheat", 17, "18", 0);
                yield return new germination(28, "wheat", 18, "Inf", 1);
                yield return new germination(28, "rice", 0, "2", 0);
                yield return new germination(28, "rice", 2, "3", 0);
                yield return new germination(28, "rice", 3, "5", 17);
                yield return new germination(28, "rice", 5, "6", 0);
                yield return new germination(28, "rice", 6, "7", 0);
                yield return new germination(28, "rice", 7, "9", 0);
                yield return new germination(28, "rice", 9, "10", 1);
                yield return new germination(28, "rice", 10, "11", 0);
                yield return new germination(28, "rice", 11, "12", 0);
                yield return new germination(28, "rice", 12, "13", 0);
                yield return new germination(28, "rice", 13, "14", 0);
                yield return new germination(28, "rice", 14, "16", 0);
                yield return new germination(28, "rice", 16, "17", 0);
                yield return new germination(28, "rice", 17, "18", 0);
                yield return new germination(28, "rice", 18, "Inf", 2);
                yield return new germination(34, "wheat", 0, "2", 0);
                yield return new germination(34, "wheat", 2, "3", 5);
                yield return new germination(34, "wheat", 3, "4", 11);
                yield return new germination(34, "wheat", 4, "5", 1);
                yield return new germination(34, "wheat", 5, "6", 1);
                yield return new germination(34, "wheat", 6, "7", 0);
                yield return new germination(34, "wheat", 7, "9", 0);
                yield return new germination(34, "wheat", 9, "10", 0);
                yield return new germination(34, "wheat", 10, "11", 0);
                yield return new germination(34, "wheat", 11, "12", 1);
                yield return new germination(34, "wheat", 12, "13", 0);
                yield return new germination(34, "wheat", 13, "14", 0);
                yield return new germination(34, "wheat", 14, "16", 0);
                yield return new germination(34, "wheat", 16, "17", 0);
                yield return new germination(34, "wheat", 17, "18", 0);
                yield return new germination(34, "wheat", 18, "Inf", 1);
                yield return new germination(34, "rice", 0, "2", 0);
                yield return new germination(34, "rice", 2, "3", 1);
                yield return new germination(34, "rice", 3, "4", 13);
                yield return new germination(34, "rice", 4, "5", 1);
                yield return new germination(34, "rice", 5, "6", 1);
                yield return new germination(34, "rice", 6, "8", 0);
                yield return new germination(34, "rice", 8, "9", 0);
                yield return new germination(34, "rice", 9, "10", 1);
                yield return new germination(34, "rice", 10, "11", 0);
                yield return new germination(34, "rice", 11, "12", 0);
                yield return new germination(34, "rice", 12, "13", 0);
                yield return new germination(34, "rice", 13, "14", 0);
                yield return new germination(34, "rice", 14, "16", 0);
                yield return new germination(34, "rice", 16, "17", 0);
                yield return new germination(34, "rice", 17, "18", 0);
                yield return new germination(34, "rice", 18, "Inf", 3);
                yield return new germination(40, "wheat", 0, "1", 0);
                yield return new germination(40, "wheat", 1, "2", 0);
                yield return new germination(40, "wheat", 2, "3", 0);
                yield return new germination(40, "wheat", 3, "4", 0);
                yield return new germination(40, "wheat", 4, "5", 0);
                yield return new germination(40, "wheat", 5, "6", 0);
                yield return new germination(40, "wheat", 6, "7", 0);
                yield return new germination(40, "wheat", 7, "9", 0);
                yield return new germination(40, "wheat", 9, "10", 1);
                yield return new germination(40, "wheat", 10, "11", 2);
                yield return new germination(40, "wheat", 11, "12", 0);
                yield return new germination(40, "wheat", 12, "13", 0);
                yield return new germination(40, "wheat", 13, "14", 0);
                yield return new germination(40, "wheat", 14, "16", 0);
                yield return new germination(40, "wheat", 16, "17", 0);
                yield return new germination(40, "wheat", 17, "18", 0);
                yield return new germination(40, "wheat", 18, "Inf", 17);
                yield return new germination(40, "rice", 0, "1", 0);
                yield return new germination(40, "rice", 1, "2", 0);
                yield return new germination(40, "rice", 2, "3", 1);
                yield return new germination(40, "rice", 3, "4", 6);
                yield return new germination(40, "rice", 4, "5", 1);
                yield return new germination(40, "rice", 5, "6", 0);
                yield return new germination(40, "rice", 6, "7", 0);
                yield return new germination(40, "rice", 7, "9", 0);
                yield return new germination(40, "rice", 9, "10", 0);
                yield return new germination(40, "rice", 10, "11", 0);
                yield return new germination(40, "rice", 11, "12", 0);
                yield return new germination(40, "rice", 12, "13", 0);
                yield return new germination(40, "rice", 13, "14", 0);
                yield return new germination(40, "rice", 14, "16", 0);
                yield return new germination(40, "rice", 16, "17", 0);
                yield return new germination(40, "rice", 17, "18", 0);
                yield return new germination(40, "rice", 18, "Inf", 12);
            }
        }
    }
}
