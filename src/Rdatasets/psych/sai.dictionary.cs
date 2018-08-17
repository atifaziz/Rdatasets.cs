// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// State Anxiety data from the PMC lab over multiple occasions.
    /// </summary>

    public class sai_dictionary
    {
        public readonly string content;
        public readonly string MSQ;

        public sai_dictionary(string content, string MSQ)
        {
            this.content = content;
            this.MSQ = MSQ;
        }

        public static IEnumerable<sai_dictionary> Data
        {
            get
            {
                yield return new sai_dictionary("id", "");
                yield return new sai_dictionary("study", "");
                yield return new sai_dictionary("time", "");
                yield return new sai_dictionary("TOD", "");
                yield return new sai_dictionary("drug", "");
                yield return new sai_dictionary("film", "");
                yield return new sai_dictionary("anxious", "msq");
                yield return new sai_dictionary("at.ease", "msq");
                yield return new sai_dictionary("calm", "msq");
                yield return new sai_dictionary("comfortable", "");
                yield return new sai_dictionary("confident", "msq");
                yield return new sai_dictionary("content", "msq");
                yield return new sai_dictionary("high.strung", "");
                yield return new sai_dictionary("jittery", "msq");
                yield return new sai_dictionary("joyful", "");
                yield return new sai_dictionary("nervous", "msq");
                yield return new sai_dictionary("pleasant", "");
                yield return new sai_dictionary("rattled", "");
                yield return new sai_dictionary("regretful", "");
                yield return new sai_dictionary("relaxed", "msq");
                yield return new sai_dictionary("rested", "");
                yield return new sai_dictionary("secure", "");
                yield return new sai_dictionary("tense", "msq");
                yield return new sai_dictionary("upset", "msq");
                yield return new sai_dictionary("worried", "");
                yield return new sai_dictionary("worrying", "");
            }
        }
    }
}
