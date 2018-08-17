// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 13.1, p418
    /// </summary>

    public class allograft
    {
        public readonly int patient;
        public readonly int time;
        public readonly int rejection;
        public readonly int match;

        public allograft(int patient, int time, int rejection, int match)
        {
            this.patient = patient;
            this.time = time;
            this.rejection = rejection;
            this.match = match;
        }

        public static IEnumerable<allograft> Data
        {
            get
            {
                yield return new allograft(1, 29, 1, 0);
                yield return new allograft(1, 37, 1, 1);
                yield return new allograft(2, 3, 1, 0);
                yield return new allograft(2, 19, 1, 1);
                yield return new allograft(3, 15, 1, 0);
                yield return new allograft(3, 57, 0, 1);
                yield return new allograft(3, 57, 0, 1);
                yield return new allograft(4, 26, 1, 0);
                yield return new allograft(4, 93, 1, 1);
                yield return new allograft(5, 11, 1, 0);
                yield return new allograft(5, 16, 1, 1);
                yield return new allograft(6, 15, 1, 0);
                yield return new allograft(6, 21, 1, 1);
                yield return new allograft(7, 20, 1, 1);
                yield return new allograft(7, 26, 1, 0);
                yield return new allograft(8, 18, 1, 1);
                yield return new allograft(8, 19, 1, 0);
                yield return new allograft(9, 29, 1, 0);
                yield return new allograft(9, 43, 1, 0);
                yield return new allograft(9, 63, 1, 1);
                yield return new allograft(9, 77, 1, 1);
                yield return new allograft(10, 15, 1, 0);
                yield return new allograft(10, 18, 1, 0);
                yield return new allograft(10, 29, 1, 1);
                yield return new allograft(11, 38, 1, 0);
                yield return new allograft(11, 60, 0, 1);
                yield return new allograft(12, 19, 1, 0);
                yield return new allograft(13, 24, 1, 1);
                yield return new allograft(14, 18, 1, 0);
                yield return new allograft(14, 18, 1, 0);
                yield return new allograft(15, 19, 1, 0);
                yield return new allograft(15, 19, 1, 0);
                yield return new allograft(16, 28, 0, 0);
                yield return new allograft(16, 28, 0, 0);
            }
        }
    }
}
