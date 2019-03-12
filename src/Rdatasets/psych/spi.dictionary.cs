// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// A sample from the SAPA Personality Inventory including an item dictionary and scoring keys.
    /// </summary>

    public class spi_dictionary
    {
        public readonly string κ;
        public readonly string item_id;
        public readonly string item;
        public readonly string item_scale;
        public readonly string resp_type;

        public spi_dictionary(string κ, string item_id, string item, string item_scale, string resp_type)
        {
            this.κ = κ;
            this.item_id = item_id;
            this.item = item;
            this.item_scale = item_scale;
            this.resp_type = resp_type;
        }

        public static IEnumerable<spi_dictionary> Data
        {
            get
            {
                yield return new spi_dictionary("age", "age", "age in years", null, null);
                yield return new spi_dictionary("sex", "sex", "sex (X chromosomes)", null, "1-2");
                yield return new spi_dictionary("health", "health", "self rated health (poor ... excellent) ", null, null);
                yield return new spi_dictionary("p1edu", "p1edu", "Parent 1 education", null, null);
                yield return new spi_dictionary("p2edu", "p2edu", "Parent 2 education", null, null);
                yield return new spi_dictionary("education", "education", "education (<12, ... grad/prof degree)", null, null);
                yield return new spi_dictionary("wellness", "wellness", "wellness", null, null);
                yield return new spi_dictionary("exer", "exer", "exercise (very rarely ... > 5x/wk)", null, null);
                yield return new spi_dictionary("smoke", "smoke", "smoking (never ... > 20/day)", null, null);
                yield return new spi_dictionary("ER", "ER", "ER", null, null);
                yield return new spi_dictionary("q_253", "q_253", "Am sensitive to the needs of others.", "IPIP", "reg");
                yield return new spi_dictionary("q_952", "q_952", "Get angry easily.", "IPIP", "reg");
                yield return new spi_dictionary("q_1904", "q_1904", "Usually like to spend my free time with people.", "IPIP", "reg");
                yield return new spi_dictionary("q_578", "q_578", "Dislike myself.", "IPIP", "reg");
                yield return new spi_dictionary("q_1367", "q_1367", "Love dangerous situations.", "IPIP", "reg");
                yield return new spi_dictionary("q_4252", "q_4252", "Am a worrier.", "EPQ:N", "reg");
                yield return new spi_dictionary("q_4296", "q_4296", "Tell a lot of lies.", "EPQ:P", "reg");
                yield return new spi_dictionary("q_904", "q_904", "Find it difficult to get down to work.", "IPIP", "reg");
                yield return new spi_dictionary("q_240", "q_240", "Am quick to understand things.", "IPIP", "reg");
                yield return new spi_dictionary("q_2745", "q_2745", "Am able to come up with new and different ideas.", "IPIP", "reg");
                yield return new spi_dictionary("q_35", "q_35", "Act without thinking.", "IPIP", "reg");
                yield return new spi_dictionary("q_565", "q_565", "Dislike being the center of attention.", "IPIP", "reg");
                yield return new spi_dictionary("q_1201", "q_1201", "Keep things tidy.", "IPIP", "reg");
                yield return new spi_dictionary("q_1624", "q_1624", "Respect authority.", "IPIP", "reg");
                yield return new spi_dictionary("q_1045", "q_1045", "Have a natural talent for influencing people.", "IPIP", "reg");
                yield return new spi_dictionary("q_1855", "q_1855", "Trust what people say.", "IPIP", "reg");
                yield return new spi_dictionary("q_1243", "q_1243", "Laugh a lot.", "IPIP", "reg");
                yield return new spi_dictionary("q_219", "q_219", "Am open about my feelings.", "IPIP", "reg");
                yield return new spi_dictionary("q_610", "q_610", "Do not like art.", "IPIP", "reg");
                yield return new spi_dictionary("q_1389", "q_1389", "Love to reflect on things.", "IPIP", "reg");
                yield return new spi_dictionary("q_530", "q_530", "Continue until everything is perfect.", "IPIP", "reg");
                yield return new spi_dictionary("q_56", "q_56", "Am able to control my cravings.", "IPIP", "reg");
                yield return new spi_dictionary("q_152", "q_152", "Am just an ordinary person.", "IPIP", "reg");
                yield return new spi_dictionary("q_566", "q_566", "Dislike changes.", "IPIP", "reg");
                yield return new spi_dictionary("q_1329", "q_1329", "Like to take it easy.", "IPIP", "reg");
                yield return new spi_dictionary("q_979", "q_979", "Get overwhelmed by emotions.", "IPIP", "reg");
                yield return new spi_dictionary("q_345", "q_345", "Believe in one true religion.", "IPIP", "reg");
                yield return new spi_dictionary("q_90", "q_90", "Am concerned about others.", "IPIP", "reg");
                yield return new spi_dictionary("q_1357", "q_1357", "Lose my temper.", "IPIP", "reg");
                yield return new spi_dictionary("q_312", "q_312", "Avoid company.", "IPIP", "reg");
                yield return new spi_dictionary("q_811", "q_811", "Feel a sense of worthlessness or hopelessness.", "IPIP", "reg");
                yield return new spi_dictionary("q_1664", "q_1664", "Seek danger.", "IPIP", "reg");
                yield return new spi_dictionary("q_1989", "q_1989", "Worry about things.", "IPIP", "reg");
                yield return new spi_dictionary("q_1812", "q_1812", "Tell the truth.", "IPIP", "reg");
                yield return new spi_dictionary("q_1744", "q_1744", "Start tasks right away.", "IPIP", "reg");
                yield return new spi_dictionary("q_1253", "q_1253", "Learn things slowly.", "IPIP", "reg");
                yield return new spi_dictionary("q_128", "q_128", "Am full of ideas.", "IPIP", "reg");
                yield return new spi_dictionary("q_1173", "q_1173", "Jump into things without thinking.", "IPIP", "reg");
                yield return new spi_dictionary("q_1027", "q_1027", "Hate being the center of attention.", "IPIP", "reg");
                yield return new spi_dictionary("q_1254", "q_1254", "Leave a mess in my room.", "IPIP", "reg");
                yield return new spi_dictionary("q_1867", "q_1867", "Try to follow the rules.", "IPIP", "reg");
                yield return new spi_dictionary("q_254", "q_254", "Am skilled in handling social situations.", "IPIP", "reg");
                yield return new spi_dictionary("q_4289", "q_4289", "Trust people to mainly tell the truth.", "EPQ:P", "reg");
                yield return new spi_dictionary("q_1244", "q_1244", "Laugh aloud.", "IPIP", "reg");
                yield return new spi_dictionary("q_1081", "q_1081", "Have difficulty expressing my feelings.", "IPIP", "reg");
                yield return new spi_dictionary("q_348", "q_348", "Believe in the importance of art.", "IPIP", "reg");
                yield return new spi_dictionary("q_1738", "q_1738", "Spend time reflecting on things.", "IPIP", "reg");
                yield return new spi_dictionary("q_1915", "q_1915", "Want every detail taken care of.", "IPIP", "reg");
                yield return new spi_dictionary("q_736", "q_736", "Easily resist temptations.", "IPIP", "reg");
                yield return new spi_dictionary("q_1300", "q_1300", "Like to be thought of as a normal kind of person.", "IPIP", "reg");
                yield return new spi_dictionary("q_689", "q_689", "Dont like the idea of change.", "IPIP", "reg");
                yield return new spi_dictionary("q_1281", "q_1281", "Like a leisurely lifestyle.", "IPIP", "reg");
                yield return new spi_dictionary("q_174", "q_174", "Am not easily affected by my emotions.", "IPIP", "reg");
                yield return new spi_dictionary("q_660", "q_660", "Dont consider myself religious.", "IPIP", "reg");
                yield return new spi_dictionary("q_1763", "q_1763", "Sympathize with others feelings.", "IPIP", "reg");
                yield return new spi_dictionary("q_1683", "q_1683", "Seldom get mad.", "IPIP", "reg");
                yield return new spi_dictionary("q_1923", "q_1923", "Want to be left alone.", "IPIP", "reg");
                yield return new spi_dictionary("q_2765", "q_2765", "Am happy with my life.", "IPIP", "reg");
                yield return new spi_dictionary("q_1781", "q_1781", "Take risks.", "IPIP", "reg");
                yield return new spi_dictionary("q_4249", "q_4249", "Would call myself a nervous person.", "EPQ:N", "reg");
                yield return new spi_dictionary("q_501", "q_501", "Cheat to get ahead.", "IPIP", "reg");
                yield return new spi_dictionary("q_1444", "q_1444", "Need a push to get started.", "IPIP", "reg");
                yield return new spi_dictionary("q_493", "q_493", "Catch on to things quickly.", "IPIP", "reg");
                yield return new spi_dictionary("q_2754", "q_2754", "Am an original thinker.", "IPIP", "reg");
                yield return new spi_dictionary("q_1424", "q_1424", "Make rash decisions.", "IPIP", "reg");
                yield return new spi_dictionary("q_1416", "q_1416", "Make myself the center of attention.", "IPIP", "reg");
                yield return new spi_dictionary("q_1483", "q_1483", "Often forget to put things back in their proper place.", "IPIP", "reg");
                yield return new spi_dictionary("q_1609", "q_1609", "Rebel against authority.", "IPIP", "reg");
                yield return new spi_dictionary("q_1242", "q_1242", "Lack the talent for influencing people.", "IPIP", "reg");
                yield return new spi_dictionary("q_377", "q_377", "Believe that others have good intentions.", "IPIP", "reg");
                yield return new spi_dictionary("q_1248", "q_1248", "Laugh my way through life.", "IPIP", "reg");
                yield return new spi_dictionary("q_803", "q_803", "Express myself easily.", "IPIP", "reg");
                yield return new spi_dictionary("q_607", "q_607", "Do not enjoy going to art museums.", "IPIP", "reg");
                yield return new spi_dictionary("q_755", "q_755", "Enjoy examining myself and my life.", "IPIP", "reg");
                yield return new spi_dictionary("q_571", "q_571", "Dislike imperfect work.", "IPIP", "reg");
                yield return new spi_dictionary("q_1590", "q_1590", "Rarely overindulge.", "IPIP", "reg");
                yield return new spi_dictionary("q_1653", "q_1653", "See myself as an average person.", "IPIP", "reg");
                yield return new spi_dictionary("q_39", "q_39", "Adjust easily.", "IPIP", "reg");
                yield return new spi_dictionary("q_1052", "q_1052", "Have a slow pace to my life.", "IPIP", "reg");
                yield return new spi_dictionary("q_793", "q_793", "Experience my emotions intensely.", "IPIP", "reg");
                yield return new spi_dictionary("q_1824", "q_1824", "Tend to vote for conservative political candidates.", "IPIP", "reg");
                yield return new spi_dictionary("q_851", "q_851", "Feel sympathy for those who are worse off than myself.", "IPIP", "reg");
                yield return new spi_dictionary("q_1585", "q_1585", "Rarely get irritated.", "IPIP", "reg");
                yield return new spi_dictionary("q_4243", "q_4243", "Like going out a lot.", "EPQ:E", "reg");
                yield return new spi_dictionary("q_820", "q_820", "Feel comfortable with myself.", "IPIP", "reg");
                yield return new spi_dictionary("q_598", "q_598", "Do crazy things.", "IPIP", "reg");
                yield return new spi_dictionary("q_1505", "q_1505", "Panic easily.", "IPIP", "reg");
                yield return new spi_dictionary("q_2853", "q_2853", "Cannot imagine lying or cheating.", "IPIP", "reg");
                yield return new spi_dictionary("q_1452", "q_1452", "Neglect my duties.", "IPIP", "reg");
                yield return new spi_dictionary("q_422", "q_422", "Can handle a lot of information.", "IPIP", "reg");
                yield return new spi_dictionary("q_1392", "q_1392", "Love to think up new ways of doing things.", "IPIP", "reg");
                yield return new spi_dictionary("q_4276", "q_4276", "Often make decisions on the spur of the moment.", "EPQ:E", "reg");
                yield return new spi_dictionary("q_1296", "q_1296", "Like to attract attention.", "IPIP", "reg");
                yield return new spi_dictionary("q_1290", "q_1290", "Like order.", "IPIP", "reg");
                yield return new spi_dictionary("q_369", "q_369", "Believe that laws should be strictly enforced.", "IPIP", "reg");
                yield return new spi_dictionary("q_901", "q_901", "Find it difficult to approach others.", "IPIP", "reg");
                yield return new spi_dictionary("q_379", "q_379", "Believe that people are basically moral.", "IPIP", "reg");
                yield return new spi_dictionary("q_296", "q_296", "Amuse my friends.", "IPIP", "reg");
                yield return new spi_dictionary("q_1635", "q_1635", "Reveal little about myself.", "IPIP", "reg");
                yield return new spi_dictionary("q_612", "q_612", "Do not like poetry.", "IPIP", "reg");
                yield return new spi_dictionary("q_1880", "q_1880", "Try to understand myself.", "IPIP", "reg");
                yield return new spi_dictionary("q_1694", "q_1694", "Set high standards for myself and others.", "IPIP", "reg");
                yield return new spi_dictionary("q_1462", "q_1462", "Never splurge.", "IPIP", "reg");
                yield return new spi_dictionary("q_747", "q_747", "Enjoy being thought of as a normal mainstream person.", "IPIP", "reg");
                yield return new spi_dictionary("q_1542", "q_1542", "Prefer variety to routine.", "IPIP", "reg");
                yield return new spi_dictionary("q_1024", "q_1024", "Hang around doing nothing.", "IPIP", "reg");
                yield return new spi_dictionary("q_797", "q_797", "Experience very few emotional highs and lows.", "IPIP", "reg");
                yield return new spi_dictionary("q_1825", "q_1825", "Tend to vote for liberal political candidates.", "IPIP", "reg");
                yield return new spi_dictionary("q_1832", "q_1832", "Think of others first.", "IPIP", "reg");
                yield return new spi_dictionary("q_176", "q_176", "Am not easily annoyed.", "IPIP", "reg");
                yield return new spi_dictionary("q_684", "q_684", "Dont like crowded events.", "IPIP", "reg");
                yield return new spi_dictionary("q_1371", "q_1371", "Love life.", "IPIP", "reg");
                yield return new spi_dictionary("q_1662", "q_1662", "Seek adventure.", "IPIP", "reg");
                yield return new spi_dictionary("q_808", "q_808", "Fear for the worst.", "IPIP", "reg");
                yield return new spi_dictionary("q_1896", "q_1896", "Use others for my own ends.", "IPIP", "reg");
                yield return new spi_dictionary("q_1979", "q_1979", "Work hard.", "IPIP", "reg");
                yield return new spi_dictionary("q_1834", "q_1834", "Think quickly.", "IPIP", "reg");
                yield return new spi_dictionary("q_1058", "q_1058", "Have a vivid imagination.", "IPIP", "reg");
                yield return new spi_dictionary("q_4223", "q_4223", "Stop to think things over before doing anything.", "EPQ:P", "reg");
                yield return new spi_dictionary("q_1555", "q_1555", "Put on a show to impress people.", "IPIP", "reg");
                yield return new spi_dictionary("q_169", "q_169", "Am not bothered by disorder.", "IPIP", "reg");
                yield return new spi_dictionary("q_398", "q_398", "Believe that we should be tough on crime.", "IPIP", "reg");
                yield return new spi_dictionary("q_131", "q_131", "Am good at making impromptu speeches.", "IPIP", "reg");
                yield return new spi_dictionary("q_871", "q_871", "Feel that most people cant be trusted.", "IPIP", "reg");
                yield return new spi_dictionary("q_1685", "q_1685", "Seldom joke around.", "IPIP", "reg");
                yield return new spi_dictionary("q_1706", "q_1706", "Show my sadness.", "IPIP", "reg");
                yield return new spi_dictionary("q_1132", "q_1132", "Have read the great literary classics.", "IPIP", "reg");
                yield return new spi_dictionary("q_1310", "q_1310", "Like to get lost in thought.", "IPIP", "reg");
                yield return new spi_dictionary("q_142", "q_142", "Am hard to satisfy.", "IPIP", "reg");
                yield return new spi_dictionary("q_1461", "q_1461", "Never spend more than I can afford.", "IPIP", "reg");
                yield return new spi_dictionary("q_2005", "q_2005", "Would hate to be considered odd or strange.", "IPIP", "reg");
                yield return new spi_dictionary("q_1303", "q_1303", "Like to begin new things.", "IPIP", "reg");
                yield return new spi_dictionary("q_1280", "q_1280", "Let things proceed at their own pace.", "IPIP", "reg");
                yield return new spi_dictionary("q_1840", "q_1840", "Think that my moods dont change more than most peoples do.", "IPIP", "reg");
                yield return new spi_dictionary("q_1328", "q_1328", "Like to stand during the national anthem.", "IPIP", "reg");
            }
        }
    }
}
