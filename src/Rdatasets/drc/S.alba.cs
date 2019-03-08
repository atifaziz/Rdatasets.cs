// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Potency of two herbicides
    /// </summary>

    public class S_alba
    {
        public readonly int Dose;
        public readonly string Herbicide;
        public readonly double DryMatter;

        public S_alba(int Dose, string Herbicide, double DryMatter)
        {
            this.Dose = Dose;
            this.Herbicide = Herbicide;
            this.DryMatter = DryMatter;
        }

        public static IEnumerable<S_alba> Data
        {
            get
            {
                yield return new S_alba(0, "Glyphosate", 4.7);
                yield return new S_alba(0, "Glyphosate", 4.6);
                yield return new S_alba(0, "Glyphosate", 4.1);
                yield return new S_alba(0, "Glyphosate", 4.4);
                yield return new S_alba(0, "Glyphosate", 3.2);
                yield return new S_alba(0, "Glyphosate", 3);
                yield return new S_alba(0, "Glyphosate", 3.8);
                yield return new S_alba(0, "Glyphosate", 3.9);
                yield return new S_alba(10, "Glyphosate", 3.8);
                yield return new S_alba(10, "Glyphosate", 3.8);
                yield return new S_alba(10, "Glyphosate", 3.8);
                yield return new S_alba(10, "Glyphosate", 3.3);
                yield return new S_alba(20, "Glyphosate", 4.1);
                yield return new S_alba(20, "Glyphosate", 3.5);
                yield return new S_alba(20, "Glyphosate", 4.1);
                yield return new S_alba(20, "Glyphosate", 3.2);
                yield return new S_alba(40, "Glyphosate", 2.8);
                yield return new S_alba(40, "Glyphosate", 3);
                yield return new S_alba(40, "Glyphosate", 3.7);
                yield return new S_alba(40, "Glyphosate", 3.4);
                yield return new S_alba(80, "Glyphosate", 1.8);
                yield return new S_alba(80, "Glyphosate", 1.6);
                yield return new S_alba(80, "Glyphosate", 2.3);
                yield return new S_alba(80, "Glyphosate", 1.7);
                yield return new S_alba(160, "Glyphosate", 1.1);
                yield return new S_alba(160, "Glyphosate", 1.3);
                yield return new S_alba(160, "Glyphosate", 1);
                yield return new S_alba(160, "Glyphosate", 1.2);
                yield return new S_alba(320, "Glyphosate", 0.9);
                yield return new S_alba(320, "Glyphosate", 0.9);
                yield return new S_alba(320, "Glyphosate", 0.9);
                yield return new S_alba(320, "Glyphosate", 0.9);
                yield return new S_alba(0, "Bentazone", 4.1);
                yield return new S_alba(0, "Bentazone", 3.4);
                yield return new S_alba(0, "Bentazone", 2.6);
                yield return new S_alba(0, "Bentazone", 3.5);
                yield return new S_alba(0, "Bentazone", 4.3);
                yield return new S_alba(0, "Bentazone", 4.2);
                yield return new S_alba(0, "Bentazone", 4.1);
                yield return new S_alba(0, "Bentazone", 4.5);
                yield return new S_alba(10, "Bentazone", 3.5);
                yield return new S_alba(10, "Bentazone", 3.8);
                yield return new S_alba(10, "Bentazone", 3.9);
                yield return new S_alba(10, "Bentazone", 3.7);
                yield return new S_alba(20, "Bentazone", 3.2);
                yield return new S_alba(20, "Bentazone", 3.5);
                yield return new S_alba(20, "Bentazone", 3);
                yield return new S_alba(20, "Bentazone", 4);
                yield return new S_alba(40, "Bentazone", 1.1);
                yield return new S_alba(40, "Bentazone", 1.4);
                yield return new S_alba(40, "Bentazone", 1.4);
                yield return new S_alba(40, "Bentazone", 0.9);
                yield return new S_alba(80, "Bentazone", 0.9);
                yield return new S_alba(80, "Bentazone", 0.6);
                yield return new S_alba(80, "Bentazone", 0.7);
                yield return new S_alba(80, "Bentazone", 0.8);
                yield return new S_alba(160, "Bentazone", 0.7);
                yield return new S_alba(160, "Bentazone", 0.7);
                yield return new S_alba(160, "Bentazone", 0.5);
                yield return new S_alba(160, "Bentazone", 0.6);
                yield return new S_alba(320, "Bentazone", 0.8);
                yield return new S_alba(320, "Bentazone", 0.5);
                yield return new S_alba(320, "Bentazone", 0.7);
                yield return new S_alba(320, "Bentazone", 0.8);
                yield return new S_alba(640, "Bentazone", 0.6);
                yield return new S_alba(640, "Bentazone", 0.7);
                yield return new S_alba(640, "Bentazone", 0.6);
                yield return new S_alba(640, "Bentazone", 0.8);
            }
        }
    }
}
