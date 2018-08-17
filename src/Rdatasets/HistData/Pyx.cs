// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Trial of the Pyx
    /// </summary>

    public class Pyx
    {
        public readonly string Bags;
        public readonly string Group;
        public readonly string Deviation;
        public readonly int count;

        public Pyx(string Bags, string Group, string Deviation, int count)
        {
            this.Bags = Bags;
            this.Group = Group;
            this.Deviation = Deviation;
            this.count = count;
        }

        public static IEnumerable<Pyx> Data
        {
            get
            {
                yield return new Pyx("1 and 2", "near std", "Below -R", 34);
                yield return new Pyx("3", "near std", "Below -R", 11);
                yield return new Pyx("4", "near std", "Below -R", 20);
                yield return new Pyx("5", "below std", "Below -R", 30);
                yield return new Pyx("6", "below std", "Below -R", 32);
                yield return new Pyx("7", "below std", "Below -R", 47);
                yield return new Pyx("8", "above std", "Below -R", 11);
                yield return new Pyx("9", "above std", "Below -R", 10);
                yield return new Pyx("10", "above std", "Below -R", 14);
                yield return new Pyx("1 and 2", "near std", "(-R to -.2)", 57);
                yield return new Pyx("3", "near std", "(-R to -.2)", 17);
                yield return new Pyx("4", "near std", "(-R to -.2)", 22);
                yield return new Pyx("5", "below std", "(-R to -.2)", 102);
                yield return new Pyx("6", "below std", "(-R to -.2)", 27);
                yield return new Pyx("7", "below std", "(-R to -.2)", 65);
                yield return new Pyx("8", "above std", "(-R to -.2)", 21);
                yield return new Pyx("9", "above std", "(-R to -.2)", 38);
                yield return new Pyx("10", "above std", "(-R to -.2)", 13);
                yield return new Pyx("1 and 2", "near std", "(-.2 to -.l)", 172);
                yield return new Pyx("3", "near std", "(-.2 to -.l)", 100);
                yield return new Pyx("4", "near std", "(-.2 to -.l)", 135);
                yield return new Pyx("5", "below std", "(-.2 to -.l)", 107);
                yield return new Pyx("6", "below std", "(-.2 to -.l)", 267);
                yield return new Pyx("7", "below std", "(-.2 to -.l)", 141);
                yield return new Pyx("8", "above std", "(-.2 to -.l)", 110);
                yield return new Pyx("9", "above std", "(-.2 to -.l)", 103);
                yield return new Pyx("10", "above std", "(-.2 to -.l)", 126);
                yield return new Pyx("1 and 2", "near std", "(-.1 to 0)", 630);
                yield return new Pyx("3", "near std", "(-.1 to 0)", 412);
                yield return new Pyx("4", "near std", "(-.1 to 0)", 350);
                yield return new Pyx("5", "below std", "(-.1 to 0)", 289);
                yield return new Pyx("6", "below std", "(-.1 to 0)", 210);
                yield return new Pyx("7", "below std", "(-.1 to 0)", 380);
                yield return new Pyx("8", "above std", "(-.1 to 0)", 215);
                yield return new Pyx("9", "above std", "(-.1 to 0)", 228);
                yield return new Pyx("10", "above std", "(-.1 to 0)", 309);
                yield return new Pyx("1 and 2", "near std", "(0 to .l)", 597);
                yield return new Pyx("3", "near std", "(0 to .l)", 172);
                yield return new Pyx("4", "near std", "(0 to .l)", 184);
                yield return new Pyx("5", "below std", "(0 to .l)", 209);
                yield return new Pyx("6", "below std", "(0 to .l)", 236);
                yield return new Pyx("7", "below std", "(0 to .l)", 157);
                yield return new Pyx("8", "above std", "(0 to .l)", 361);
                yield return new Pyx("9", "above std", "(0 to .l)", 425);
                yield return new Pyx("10", "above std", "(0 to .l)", 290);
                yield return new Pyx("1 and 2", "near std", "(.1 to .2)", 366);
                yield return new Pyx("3", "near std", "(.1 to .2)", 218);
                yield return new Pyx("4", "near std", "(.1 to .2)", 222);
                yield return new Pyx("5", "below std", "(.1 to .2)", 184);
                yield return new Pyx("6", "below std", "(.1 to .2)", 144);
                yield return new Pyx("7", "below std", "(.1 to .2)", 135);
                yield return new Pyx("8", "above std", "(.1 to .2)", 156);
                yield return new Pyx("9", "above std", "(.1 to .2)", 140);
                yield return new Pyx("10", "above std", "(.1 to .2)", 168);
                yield return new Pyx("1 and 2", "near std", "(.2 to R)", 116);
                yield return new Pyx("3", "near std", "(.2 to R)", 57);
                yield return new Pyx("4", "near std", "(.2 to R)", 50);
                yield return new Pyx("5", "below std", "(.2 to R)", 50);
                yield return new Pyx("6", "below std", "(.2 to R)", 56);
                yield return new Pyx("7", "below std", "(.2 to R)", 50);
                yield return new Pyx("8", "above std", "(.2 to R)", 71);
                yield return new Pyx("9", "above std", "(.2 to R)", 36);
                yield return new Pyx("10", "above std", "(.2 to R)", 50);
                yield return new Pyx("1 and 2", "near std", "Above R", 28);
                yield return new Pyx("3", "near std", "Above R", 13);
                yield return new Pyx("4", "near std", "Above R", 17);
                yield return new Pyx("5", "below std", "Above R", 29);
                yield return new Pyx("6", "below std", "Above R", 28);
                yield return new Pyx("7", "below std", "Above R", 25);
                yield return new Pyx("8", "above std", "Above R", 55);
                yield return new Pyx("9", "above std", "Above R", 20);
                yield return new Pyx("10", "above std", "Above R", 30);
            }
        }
    }
}
