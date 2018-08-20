// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// 25 Personality items representing 5 factors
    /// </summary>

    public class bfi_dictionary
    {
        public readonly string ItemLabel;
        public readonly string Item;
        public readonly string Giant3;
        public readonly string Big6;
        public readonly string Little12;
        public readonly int? Keying;
        public readonly string IPIP100;

        public bfi_dictionary(string ItemLabel, string Item, string Giant3, string Big6, string Little12, int? Keying, string IPIP100)
        {
            this.ItemLabel = ItemLabel;
            this.Item = Item;
            this.Giant3 = Giant3;
            this.Big6 = Big6;
            this.Little12 = Little12;
            this.Keying = Keying;
            this.IPIP100 = IPIP100;
        }

        public static IEnumerable<bfi_dictionary> Data
        {
            get
            {
                yield return new bfi_dictionary("q_146", "Am indifferent to the feelings of others.", "Cohesion", "Agreeableness", "Compassion", -1, "B5:A");
                yield return new bfi_dictionary("q_1162", "Inquire about others' well-being.", "Cohesion", "Agreeableness", "Compassion", 1, "B5:A");
                yield return new bfi_dictionary("q_1206", "Know how to comfort others.", "Cohesion", "Agreeableness", "Compassion", 1, "B5:A");
                yield return new bfi_dictionary("q_1364", "Love children.", "Cohesion", "Agreeableness", "Compassion", 1, "B5:A");
                yield return new bfi_dictionary("q_1419", "Make people feel at ease.", "Cohesion", "Agreeableness", "Compassion", 1, "B5:A");
                yield return new bfi_dictionary("q_124", "Am exacting in my work.", "Stability", "Conscientiousness", "Orderliness", 1, "B5:C");
                yield return new bfi_dictionary("q_530", "Continue until everything is perfect.", "Stability", "Conscientiousness", "Orderliness", 1, "B5:C");
                yield return new bfi_dictionary("q_619", "Do things according to a plan.", "Stability", "Conscientiousness", "Orderliness", 1, "B5:C");
                yield return new bfi_dictionary("q_626", "Do things in a half-way manner.", "Stability", "Conscientiousness", "Industriousness", -1, "B5:C");
                yield return new bfi_dictionary("q_1949", "Waste my time.", "Stability", "Conscientiousness", "Industriousness", -1, "B5:C");
                yield return new bfi_dictionary("q_712", "Don't talk a lot.", "Plasticity", "Extraversion", "Sociability", -1, "B5:E");
                yield return new bfi_dictionary("q_901", "Find it difficult to approach others.", "Plasticity", "Extraversion", "Sociability", -1, "B5:E");
                yield return new bfi_dictionary("q_1205", "Know how to captivate people.", "Plasticity", "Extraversion", "Assertiveness", 1, "B5:E");
                yield return new bfi_dictionary("q_1410", "Make friends easily.", "Plasticity", "Extraversion", "Sociability", 1, "B5:E");
                yield return new bfi_dictionary("q_1768", "Take charge.", "Plasticity", "Extraversion", "Assertiveness", 1, "B5:E");
                yield return new bfi_dictionary("q_952", "Get angry easily.", "Stability", "Emotional Stability", "Balance", -1, "B5:N");
                yield return new bfi_dictionary("q_974", "Get irritated easily.", "Stability", "Emotional Stability", "Balance", -1, "B5:N");
                yield return new bfi_dictionary("q_1099", "Have frequent mood swings.", "Stability", "Emotional Stability", "Balance", -1, "B5:N");
                yield return new bfi_dictionary("q_1479", "Often feel blue.", "Stability", "Emotional Stability", "Balance", -1, "B5:N");
                yield return new bfi_dictionary("q_1505", "Panic easily.", "Stability", "Emotional Stability", "Balance", -1, "B5:N");
                yield return new bfi_dictionary("q_128", "Am full of ideas.", "Plasticity", "Openness", "Intellect", 1, "B5:O");
                yield return new bfi_dictionary("q_316", "Avoid difficult reading material.", "Plasticity", "Openness", "Intellect", -1, "B5:O");
                yield return new bfi_dictionary("q_492", "Carry the conversation to a higher level.", "Plasticity", "Openness", "Intellect", 1, "B5:O");
                yield return new bfi_dictionary("q_1738", "Spend time reflecting on things.", "Plasticity", "Openness", "Openness", 1, "B5:O");
                yield return new bfi_dictionary("q_1964", "Will not probe deeply into a subject.", "Plasticity", "Openness", "Openness", -1, "B5:O");
                yield return new bfi_dictionary("gender", "males=1, females=2", null, null, null, null, null);
                yield return new bfi_dictionary("education", "in HS, fin HS, coll,  coll grad , grad deg", null, null, null, null, null);
                yield return new bfi_dictionary("age", "age in years", null, null, null, null, null);
            }
        }
    }
}
