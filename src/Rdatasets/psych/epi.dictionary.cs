// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Eysenck Personality Inventory (EPI) data for 3570 participants
    /// </summary>

    public class epi_dictionary
    {
        public readonly string κ;
        public readonly string Content;

        public epi_dictionary(string κ, string Content)
        {
            this.κ = κ;
            this.Content = Content;
        }

        public static IEnumerable<epi_dictionary> Data
        {
            get
            {
                yield return new epi_dictionary("V1", "Do you often long for excitement?");
                yield return new epi_dictionary("V2", "Do you often need understanding friends to cheer you up?");
                yield return new epi_dictionary("V3", "Are you usually carefree?");
                yield return new epi_dictionary("V4", "Do you find it very hard to take no for an answer?");
                yield return new epi_dictionary("V5", "Do you stop and think things over before doing anything?");
                yield return new epi_dictionary("V6", "If you say you will do something do you always keep your promise,no matter how inconvenient it might be to do so?");
                yield return new epi_dictionary("V7", "Do your moods go up and down?");
                yield return new epi_dictionary("V8", "Do you generally do and say things quickly without stopping to think?");
                yield return new epi_dictionary("V9", "Do you ever feel just miserable for no good reason?");
                yield return new epi_dictionary("V10", "Would you do almost anything for a dare?");
                yield return new epi_dictionary("V11", "Do you suddenly feel shy when you want to talk to an attractive stranger?");
                yield return new epi_dictionary("V12", "Once in a while do you lose your temper and get angry?");
                yield return new epi_dictionary("V13", "Do you often do things on the spur of the moment?");
                yield return new epi_dictionary("V14", "Do you often worry about things you should have done or said?");
                yield return new epi_dictionary("V15", "Generally do you prefer reading to meeting people?");
                yield return new epi_dictionary("V16", "Are your feelings rather easily hurt?");
                yield return new epi_dictionary("V17", "Do you like going out a lot?");
                yield return new epi_dictionary("V18", "Do you occasionally have thoughts and ideas that you would not like otherpeople to know about?");
                yield return new epi_dictionary("V19", "Are you sometimes bubbling over with energy and sometimes very sluggish?");
                yield return new epi_dictionary("V20", "Do you prefer to have few but special friends?");
                yield return new epi_dictionary("V21", "Do you daydream a lot?");
                yield return new epi_dictionary("V22", "When people shout at you do you shout back?");
                yield return new epi_dictionary("V23", "Are you often troubled about feelings of guilt?");
                yield return new epi_dictionary("V24", "Are all your habits good and desirable ones?");
                yield return new epi_dictionary("V25", "Can you usually let yourself go and enjoy yourself a lot at a lively party?");
                yield return new epi_dictionary("V26", "Would you call yourself tense or highly strung?");
                yield return new epi_dictionary("V27", "Do other people think of you as being very lively?");
                yield return new epi_dictionary("V28", "After you have done something important, do you come away feelingyou could have done better?");
                yield return new epi_dictionary("V29", "Are you mostly quiet when you are with other people?");
                yield return new epi_dictionary("V30", "Do you sometimes gossip?");
                yield return new epi_dictionary("V31", "Do ideas run through your head so that you cannot sleep?");
                yield return new epi_dictionary("V32", "If there is something you want to know about, would you rather look it upin a book than talk to someone about it?");
                yield return new epi_dictionary("V33", "Do you get palpitations or thumping in your hear?");
                yield return new epi_dictionary("V34", "Do you like the kind of work that you need to pay close attention to?");
                yield return new epi_dictionary("V35", "Do you get attacks of shaking or trembling?");
                yield return new epi_dictionary("V36", "Would you always declare everything at customs, even if you knewyou could never be found out?");
                yield return new epi_dictionary("V37", "Do you hate being with a crowd who play jokes on one another?");
                yield return new epi_dictionary("V38", "Are you an irritable person?");
                yield return new epi_dictionary("V39", "Do you like doing things in which you have to act quickly?");
                yield return new epi_dictionary("V40", "Do you worry about awful things that might happen?");
                yield return new epi_dictionary("V41", "Are you slow and unhurried in the way you move?");
                yield return new epi_dictionary("V42", "Have you ever been late for an appointment or work?");
                yield return new epi_dictionary("V43", "Do you have many nightmares?");
                yield return new epi_dictionary("V44", "Do you like talking to people so much that you never miss a chance of talking to a stranger?");
                yield return new epi_dictionary("V45", "Are you troubled by aches and pains?");
                yield return new epi_dictionary("V46", "Would you be very unhappy if you could not see lots of people most of the time?");
                yield return new epi_dictionary("V47", "Would you call yourself a nervous person?");
                yield return new epi_dictionary("V48", "Of all the people you know, are there some whom you definitely do not like?");
                yield return new epi_dictionary("V49", "Would you say that you were fairly self-confident?");
                yield return new epi_dictionary("V50", "Are you easily hurt when people find fault with you or your work?");
                yield return new epi_dictionary("V51", "Do you find it hard to really enjoy yourself at a lively party?");
                yield return new epi_dictionary("V52", "Are you troubled by feelings of inferiority?");
                yield return new epi_dictionary("V53", "Can you easily get some life into a dull party?");
                yield return new epi_dictionary("V54", "Do you sometimes talk about things you know nothing about?");
                yield return new epi_dictionary("V55", "Do you worry about your health?");
                yield return new epi_dictionary("V56", "Do you like playing pranks on others?");
                yield return new epi_dictionary("V57", "Do you suffer from sleeplessness?");
            }
        }
    }
}
