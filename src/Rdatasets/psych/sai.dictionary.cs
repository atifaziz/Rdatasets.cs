// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// State Anxiety data from the PMC lab over multiple occasions.
    /// </summary>

    public class sai_dictionary
    {
        public readonly string κ;
        public readonly string content;
        public readonly string MSQ;

        public sai_dictionary(string κ, string content, string MSQ)
        {
            this.κ = κ;
            this.content = content;
            this.MSQ = MSQ;
        }

        public static IEnumerable<sai_dictionary> Data
        {
            get
            {
                yield return new sai_dictionary("id", "id", "");
                yield return new sai_dictionary("study", "study", "");
                yield return new sai_dictionary("time", "time", "");
                yield return new sai_dictionary("TOD", "TOD", "");
                yield return new sai_dictionary("drug", "drug", "");
                yield return new sai_dictionary("film", "film", "");
                yield return new sai_dictionary("anxious", "anxious", "msq");
                yield return new sai_dictionary("at.ease", "at.ease", "msq");
                yield return new sai_dictionary("calm", "calm", "msq");
                yield return new sai_dictionary("comfortable", "comfortable", "");
                yield return new sai_dictionary("confident", "confident", "msq");
                yield return new sai_dictionary("content", "content", "msq");
                yield return new sai_dictionary("high.strung", "high.strung", "");
                yield return new sai_dictionary("jittery", "jittery", "msq");
                yield return new sai_dictionary("joyful", "joyful", "");
                yield return new sai_dictionary("nervous", "nervous", "msq");
                yield return new sai_dictionary("pleasant", "pleasant", "");
                yield return new sai_dictionary("rattled", "rattled", "");
                yield return new sai_dictionary("regretful", "regretful", "");
                yield return new sai_dictionary("relaxed", "relaxed", "msq");
                yield return new sai_dictionary("rested", "rested", "");
                yield return new sai_dictionary("secure", "secure", "");
                yield return new sai_dictionary("tense", "tense", "msq");
                yield return new sai_dictionary("upset", "upset", "msq");
                yield return new sai_dictionary("worried", "worried", "");
                yield return new sai_dictionary("worrying", "worrying", "");
            }
        }
    }
}
