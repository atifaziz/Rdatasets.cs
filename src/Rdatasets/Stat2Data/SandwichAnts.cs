// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Sandwich Ants
    /// </summary>

    public class SandwichAnts
    {
        public readonly int κ;
        public readonly int Trial;
        public readonly string Bread;
        public readonly string Filling;
        public readonly string Butter;
        public readonly int Ants;

        public SandwichAnts(int κ, int Trial, string Bread, string Filling, string Butter, int Ants)
        {
            this.κ = κ;
            this.Trial = Trial;
            this.Bread = Bread;
            this.Filling = Filling;
            this.Butter = Butter;
            this.Ants = Ants;
        }

        public static IEnumerable<SandwichAnts> Data
        {
            get
            {
                yield return new SandwichAnts(1, 1, "WholeWheat", "HamPickles", "no", 34);
                yield return new SandwichAnts(2, 2, "MultiGrain", "PeanutButter", "yes", 47);
                yield return new SandwichAnts(3, 3, "Rye", "HamPickles", "yes", 67);
                yield return new SandwichAnts(4, 4, "MultiGrain", "HamPickles", "yes", 63);
                yield return new SandwichAnts(5, 5, "WholeWheat", "HamPickles", "no", 65);
                yield return new SandwichAnts(6, 6, "WholeWheat", "HamPickles", "yes", 58);
                yield return new SandwichAnts(7, 7, "White", "PeanutButter", "yes", 51);
                yield return new SandwichAnts(8, 8, "MultiGrain", "HamPickles", "no", 59);
                yield return new SandwichAnts(9, 9, "Rye", "HamPickles", "yes", 65);
                yield return new SandwichAnts(10, 10, "Rye", "Vegemite", "no", 18);
                yield return new SandwichAnts(11, 11, "White", "PeanutButter", "yes", 57);
                yield return new SandwichAnts(12, 12, "MultiGrain", "HamPickles", "yes", 76);
                yield return new SandwichAnts(13, 13, "White", "HamPickles", "no", 48);
                yield return new SandwichAnts(14, 14, "Rye", "Vegemite", "no", 31);
                yield return new SandwichAnts(15, 15, "MultiGrain", "Vegemite", "yes", 26);
                yield return new SandwichAnts(16, 16, "White", "PeanutButter", "no", 21);
                yield return new SandwichAnts(17, 17, "WholeWheat", "Vegemite", "yes", 57);
                yield return new SandwichAnts(18, 18, "MultiGrain", "Vegemite", "yes", 28);
                yield return new SandwichAnts(19, 19, "WholeWheat", "Vegemite", "no", 21);
                yield return new SandwichAnts(20, 20, "Rye", "HamPickles", "no", 54);
                yield return new SandwichAnts(21, 21, "MultiGrain", "Vegemite", "no", 38);
                yield return new SandwichAnts(22, 22, "MultiGrain", "PeanutButter", "no", 19);
                yield return new SandwichAnts(23, 23, "White", "HamPickles", "no", 53);
                yield return new SandwichAnts(24, 24, "MultiGrain", "PeanutButter", "yes", 60);
                yield return new SandwichAnts(25, 25, "WholeWheat", "Vegemite", "no", 29);
                yield return new SandwichAnts(26, 26, "Rye", "PeanutButter", "no", 48);
                yield return new SandwichAnts(27, 27, "Rye", "Vegemite", "yes", 22);
                yield return new SandwichAnts(28, 28, "WholeWheat", "PeanutButter", "yes", 36);
                yield return new SandwichAnts(29, 29, "Rye", "PeanutButter", "yes", 50);
                yield return new SandwichAnts(30, 30, "Rye", "Vegemite", "yes", 45);
                yield return new SandwichAnts(31, 31, "Rye", "PeanutButter", "no", 36);
                yield return new SandwichAnts(32, 32, "MultiGrain", "HamPickles", "no", 36);
                yield return new SandwichAnts(33, 33, "White", "Vegemite", "no", 42);
                yield return new SandwichAnts(34, 34, "White", "PeanutButter", "no", 24);
                yield return new SandwichAnts(35, 35, "WholeWheat", "PeanutButter", "no", 59);
                yield return new SandwichAnts(36, 36, "MultiGrain", "PeanutButter", "no", 22);
                yield return new SandwichAnts(37, 37, "White", "HamPickles", "yes", 66);
                yield return new SandwichAnts(38, 38, "WholeWheat", "PeanutButter", "no", 47);
                yield return new SandwichAnts(39, 39, "Rye", "HamPickles", "no", 44);
                yield return new SandwichAnts(40, 40, "WholeWheat", "Vegemite", "yes", 42);
                yield return new SandwichAnts(41, 41, "White", "Vegemite", "no", 25);
                yield return new SandwichAnts(42, 42, "White", "Vegemite", "yes", 48);
                yield return new SandwichAnts(43, 43, "WholeWheat", "HamPickles", "yes", 41);
                yield return new SandwichAnts(44, 44, "MultiGrain", "Vegemite", "no", 42);
                yield return new SandwichAnts(45, 45, "Rye", "PeanutButter", "yes", 27);
                yield return new SandwichAnts(46, 46, "White", "Vegemite", "yes", 40);
                yield return new SandwichAnts(47, 47, "White", "HamPickles", "yes", 59);
                yield return new SandwichAnts(48, 48, "WholeWheat", "PeanutButter", "yes", 42);
            }
        }
    }
}
