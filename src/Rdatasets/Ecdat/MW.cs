// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth of Disposable Income and Treasury Bill Rate
    /// </summary>

    public class MW
    {
        public readonly double rdi;
        public readonly double trate;

        public MW(double rdi, double trate)
        {
            this.rdi = rdi;
            this.trate = trate;
        }

        public static IEnumerable<MW> Data
        {
            get
            {
                yield return new MW(0.71932, 0.599247);
                yield return new MW(0.953181, 0.639063);
                yield return new MW(1.307914, 0.646186);
                yield return new MW(1.864976, 0.635775);
                yield return new MW(0.815886, 0.639976);
                yield return new MW(0.761362, 0.673034);
                yield return new MW(0.652972, 0.712302);
                yield return new MW(0.876979, 0.708466);
                yield return new MW(1.741477, 0.704996);
                yield return new MW(1.190327, 0.759606);
                yield return new MW(0.517648, 0.845813);
                yield return new MW(0.235832, 0.839603);
                yield return new MW(0.767275, 0.921974);
                yield return new MW(0.637206, 0.958137);
                yield return new MW(0.911138, 0.828097);
                yield return new MW(0.602389, 0.66792);
                yield return new MW(0.499254, 0.793577);
                yield return new MW(0.524874, 0.874305);
                yield return new MW(0.857929, 0.925079);
                yield return new MW(1.112811, 1.006355);
                yield return new MW(0.158973, 0.954485);
                yield return new MW(0.429621, 1.019322);
                yield return new MW(0.185249, 1.121054);
                yield return new MW(0.569544, 1.139683);
                yield return new MW(1.19164, 1.287075);
                yield return new MW(0.269991, 1.336571);
                yield return new MW(0.412541, 1.326525);
                yield return new MW(1.345358, 1.233196);
                yield return new MW(0.663482, 1.16434);
                yield return new MW(-0.336996, 0.978593);
                yield return new MW(1.294119, 0.705544);
                yield return new MW(0.749538, 0.76819);
                yield return new MW(0.067662, 0.92234);
                yield return new MW(0.378382, 0.773304);
                yield return new MW(0.568887, 0.627374);
                yield return new MW(0.555748, 0.68454);
                yield return new MW(1.126606, 0.774583);
                yield return new MW(2.077816, 0.885994);
                yield return new MW(1.371635, 1.030098);
                yield return new MW(0.560347, 1.206895);
                yield return new MW(0.449329, 1.531997);
                yield return new MW(0.400717, 1.362871);
                yield return new MW(-0.969604, 1.388076);
                yield return new MW(-0.045984, 1.51008);
                yield return new MW(-0.038101, 1.513368);
                yield return new MW(-0.633921, 1.339858);
                yield return new MW(-0.462467, 1.072654);
                yield return new MW(3.603825, 0.986447);
                yield return new MW(-0.956465, 1.157399);
                yield return new MW(0.515677, 1.038134);
            }
        }
    }
}
