// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Paste strength by batch and cask
    /// </summary>

    public class Pastes
    {
        public readonly int κ;
        public readonly double strength;
        public readonly string batch;
        public readonly string cask;
        public readonly string sample;

        public Pastes(int κ, double strength, string batch, string cask, string sample)
        {
            this.κ = κ;
            this.strength = strength;
            this.batch = batch;
            this.cask = cask;
            this.sample = sample;
        }

        public static IEnumerable<Pastes> Data
        {
            get
            {
                yield return new Pastes(1, 62.8, "A", "a", "A:a");
                yield return new Pastes(2, 62.6, "A", "a", "A:a");
                yield return new Pastes(3, 60.1, "A", "b", "A:b");
                yield return new Pastes(4, 62.3, "A", "b", "A:b");
                yield return new Pastes(5, 62.7, "A", "c", "A:c");
                yield return new Pastes(6, 63.1, "A", "c", "A:c");
                yield return new Pastes(7, 60, "B", "a", "B:a");
                yield return new Pastes(8, 61.4, "B", "a", "B:a");
                yield return new Pastes(9, 57.5, "B", "b", "B:b");
                yield return new Pastes(10, 56.9, "B", "b", "B:b");
                yield return new Pastes(11, 61.1, "B", "c", "B:c");
                yield return new Pastes(12, 58.9, "B", "c", "B:c");
                yield return new Pastes(13, 58.7, "C", "a", "C:a");
                yield return new Pastes(14, 57.5, "C", "a", "C:a");
                yield return new Pastes(15, 63.9, "C", "b", "C:b");
                yield return new Pastes(16, 63.1, "C", "b", "C:b");
                yield return new Pastes(17, 65.4, "C", "c", "C:c");
                yield return new Pastes(18, 63.7, "C", "c", "C:c");
                yield return new Pastes(19, 57.1, "D", "a", "D:a");
                yield return new Pastes(20, 56.4, "D", "a", "D:a");
                yield return new Pastes(21, 56.9, "D", "b", "D:b");
                yield return new Pastes(22, 58.6, "D", "b", "D:b");
                yield return new Pastes(23, 64.7, "D", "c", "D:c");
                yield return new Pastes(24, 64.5, "D", "c", "D:c");
                yield return new Pastes(25, 55.1, "E", "a", "E:a");
                yield return new Pastes(26, 55.1, "E", "a", "E:a");
                yield return new Pastes(27, 54.7, "E", "b", "E:b");
                yield return new Pastes(28, 54.2, "E", "b", "E:b");
                yield return new Pastes(29, 58.8, "E", "c", "E:c");
                yield return new Pastes(30, 57.5, "E", "c", "E:c");
                yield return new Pastes(31, 63.4, "F", "a", "F:a");
                yield return new Pastes(32, 64.9, "F", "a", "F:a");
                yield return new Pastes(33, 59.3, "F", "b", "F:b");
                yield return new Pastes(34, 58.1, "F", "b", "F:b");
                yield return new Pastes(35, 60.5, "F", "c", "F:c");
                yield return new Pastes(36, 60, "F", "c", "F:c");
                yield return new Pastes(37, 62.5, "G", "a", "G:a");
                yield return new Pastes(38, 62.6, "G", "a", "G:a");
                yield return new Pastes(39, 61, "G", "b", "G:b");
                yield return new Pastes(40, 58.7, "G", "b", "G:b");
                yield return new Pastes(41, 56.9, "G", "c", "G:c");
                yield return new Pastes(42, 57.7, "G", "c", "G:c");
                yield return new Pastes(43, 59.2, "H", "a", "H:a");
                yield return new Pastes(44, 59.4, "H", "a", "H:a");
                yield return new Pastes(45, 65.2, "H", "b", "H:b");
                yield return new Pastes(46, 66, "H", "b", "H:b");
                yield return new Pastes(47, 64.8, "H", "c", "H:c");
                yield return new Pastes(48, 64.1, "H", "c", "H:c");
                yield return new Pastes(49, 54.8, "I", "a", "I:a");
                yield return new Pastes(50, 54.8, "I", "a", "I:a");
                yield return new Pastes(51, 64, "I", "b", "I:b");
                yield return new Pastes(52, 64, "I", "b", "I:b");
                yield return new Pastes(53, 57.7, "I", "c", "I:c");
                yield return new Pastes(54, 56.8, "I", "c", "I:c");
                yield return new Pastes(55, 58.3, "J", "a", "J:a");
                yield return new Pastes(56, 59.3, "J", "a", "J:a");
                yield return new Pastes(57, 59.2, "J", "b", "J:b");
                yield return new Pastes(58, 59.2, "J", "b", "J:b");
                yield return new Pastes(59, 58.9, "J", "c", "J:c");
                yield return new Pastes(60, 56.6, "J", "c", "J:c");
            }
        }
    }
}
