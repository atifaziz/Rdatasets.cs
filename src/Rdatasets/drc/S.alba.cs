// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Potency of two herbicides
    /// </summary>

    public class S_alba
    {
        public readonly int κ;
        public readonly int Dose;
        public readonly string Herbicide;
        public readonly double DryMatter;

        public S_alba(int κ, int Dose, string Herbicide, double DryMatter)
        {
            this.κ = κ;
            this.Dose = Dose;
            this.Herbicide = Herbicide;
            this.DryMatter = DryMatter;
        }

        public static IEnumerable<S_alba> Data
        {
            get
            {
                yield return new S_alba(1, 0, "Glyphosate", 4.7);
                yield return new S_alba(2, 0, "Glyphosate", 4.6);
                yield return new S_alba(3, 0, "Glyphosate", 4.1);
                yield return new S_alba(4, 0, "Glyphosate", 4.4);
                yield return new S_alba(5, 0, "Glyphosate", 3.2);
                yield return new S_alba(6, 0, "Glyphosate", 3);
                yield return new S_alba(7, 0, "Glyphosate", 3.8);
                yield return new S_alba(8, 0, "Glyphosate", 3.9);
                yield return new S_alba(9, 10, "Glyphosate", 3.8);
                yield return new S_alba(10, 10, "Glyphosate", 3.8);
                yield return new S_alba(11, 10, "Glyphosate", 3.8);
                yield return new S_alba(12, 10, "Glyphosate", 3.3);
                yield return new S_alba(13, 20, "Glyphosate", 4.1);
                yield return new S_alba(14, 20, "Glyphosate", 3.5);
                yield return new S_alba(15, 20, "Glyphosate", 4.1);
                yield return new S_alba(16, 20, "Glyphosate", 3.2);
                yield return new S_alba(17, 40, "Glyphosate", 2.8);
                yield return new S_alba(18, 40, "Glyphosate", 3);
                yield return new S_alba(19, 40, "Glyphosate", 3.7);
                yield return new S_alba(20, 40, "Glyphosate", 3.4);
                yield return new S_alba(21, 80, "Glyphosate", 1.8);
                yield return new S_alba(22, 80, "Glyphosate", 1.6);
                yield return new S_alba(23, 80, "Glyphosate", 2.3);
                yield return new S_alba(24, 80, "Glyphosate", 1.7);
                yield return new S_alba(25, 160, "Glyphosate", 1.1);
                yield return new S_alba(26, 160, "Glyphosate", 1.3);
                yield return new S_alba(27, 160, "Glyphosate", 1);
                yield return new S_alba(28, 160, "Glyphosate", 1.2);
                yield return new S_alba(29, 320, "Glyphosate", 0.9);
                yield return new S_alba(30, 320, "Glyphosate", 0.9);
                yield return new S_alba(31, 320, "Glyphosate", 0.9);
                yield return new S_alba(32, 320, "Glyphosate", 0.9);
                yield return new S_alba(33, 0, "Bentazone", 4.1);
                yield return new S_alba(34, 0, "Bentazone", 3.4);
                yield return new S_alba(35, 0, "Bentazone", 2.6);
                yield return new S_alba(36, 0, "Bentazone", 3.5);
                yield return new S_alba(37, 0, "Bentazone", 4.3);
                yield return new S_alba(38, 0, "Bentazone", 4.2);
                yield return new S_alba(39, 0, "Bentazone", 4.1);
                yield return new S_alba(40, 0, "Bentazone", 4.5);
                yield return new S_alba(41, 10, "Bentazone", 3.5);
                yield return new S_alba(42, 10, "Bentazone", 3.8);
                yield return new S_alba(43, 10, "Bentazone", 3.9);
                yield return new S_alba(44, 10, "Bentazone", 3.7);
                yield return new S_alba(45, 20, "Bentazone", 3.2);
                yield return new S_alba(46, 20, "Bentazone", 3.5);
                yield return new S_alba(47, 20, "Bentazone", 3);
                yield return new S_alba(48, 20, "Bentazone", 4);
                yield return new S_alba(49, 40, "Bentazone", 1.1);
                yield return new S_alba(50, 40, "Bentazone", 1.4);
                yield return new S_alba(51, 40, "Bentazone", 1.4);
                yield return new S_alba(52, 40, "Bentazone", 0.9);
                yield return new S_alba(53, 80, "Bentazone", 0.9);
                yield return new S_alba(54, 80, "Bentazone", 0.6);
                yield return new S_alba(55, 80, "Bentazone", 0.7);
                yield return new S_alba(56, 80, "Bentazone", 0.8);
                yield return new S_alba(57, 160, "Bentazone", 0.7);
                yield return new S_alba(58, 160, "Bentazone", 0.7);
                yield return new S_alba(59, 160, "Bentazone", 0.5);
                yield return new S_alba(60, 160, "Bentazone", 0.6);
                yield return new S_alba(61, 320, "Bentazone", 0.8);
                yield return new S_alba(62, 320, "Bentazone", 0.5);
                yield return new S_alba(63, 320, "Bentazone", 0.7);
                yield return new S_alba(64, 320, "Bentazone", 0.8);
                yield return new S_alba(65, 640, "Bentazone", 0.6);
                yield return new S_alba(66, 640, "Bentazone", 0.7);
                yield return new S_alba(67, 640, "Bentazone", 0.6);
                yield return new S_alba(68, 640, "Bentazone", 0.8);
            }
        }
    }
}
