// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth of Disposable Income and Treasury Bill Rate
    /// </summary>

    public class MW
    {
        public readonly int κ;
        public readonly double rdi;
        public readonly double trate;

        public MW(int κ, double rdi, double trate)
        {
            this.κ = κ;
            this.rdi = rdi;
            this.trate = trate;
        }

        public static IEnumerable<MW> Data
        {
            get
            {
                yield return new MW(1, 0.71932, 0.599247);
                yield return new MW(2, 0.953181, 0.639063);
                yield return new MW(3, 1.307914, 0.646186);
                yield return new MW(4, 1.864976, 0.635775);
                yield return new MW(5, 0.815886, 0.639976);
                yield return new MW(6, 0.761362, 0.673034);
                yield return new MW(7, 0.652972, 0.712302);
                yield return new MW(8, 0.876979, 0.708466);
                yield return new MW(9, 1.741477, 0.704996);
                yield return new MW(10, 1.190327, 0.759606);
                yield return new MW(11, 0.517648, 0.845813);
                yield return new MW(12, 0.235832, 0.839603);
                yield return new MW(13, 0.767275, 0.921974);
                yield return new MW(14, 0.637206, 0.958137);
                yield return new MW(15, 0.911138, 0.828097);
                yield return new MW(16, 0.602389, 0.66792);
                yield return new MW(17, 0.499254, 0.793577);
                yield return new MW(18, 0.524874, 0.874305);
                yield return new MW(19, 0.857929, 0.925079);
                yield return new MW(20, 1.112811, 1.006355);
                yield return new MW(21, 0.158973, 0.954485);
                yield return new MW(22, 0.429621, 1.019322);
                yield return new MW(23, 0.185249, 1.121054);
                yield return new MW(24, 0.569544, 1.139683);
                yield return new MW(25, 1.19164, 1.287075);
                yield return new MW(26, 0.269991, 1.336571);
                yield return new MW(27, 0.412541, 1.326525);
                yield return new MW(28, 1.345358, 1.233196);
                yield return new MW(29, 0.663482, 1.16434);
                yield return new MW(30, -0.336996, 0.978593);
                yield return new MW(31, 1.294119, 0.705544);
                yield return new MW(32, 0.749538, 0.76819);
                yield return new MW(33, 0.067662, 0.92234);
                yield return new MW(34, 0.378382, 0.773304);
                yield return new MW(35, 0.568887, 0.627374);
                yield return new MW(36, 0.555748, 0.68454);
                yield return new MW(37, 1.126606, 0.774583);
                yield return new MW(38, 2.077816, 0.885994);
                yield return new MW(39, 1.371635, 1.030098);
                yield return new MW(40, 0.560347, 1.206895);
                yield return new MW(41, 0.449329, 1.531997);
                yield return new MW(42, 0.400717, 1.362871);
                yield return new MW(43, -0.969604, 1.388076);
                yield return new MW(44, -0.045984, 1.51008);
                yield return new MW(45, -0.038101, 1.513368);
                yield return new MW(46, -0.633921, 1.339858);
                yield return new MW(47, -0.462467, 1.072654);
                yield return new MW(48, 3.603825, 0.986447);
                yield return new MW(49, -0.956465, 1.157399);
                yield return new MW(50, 0.515677, 1.038134);
            }
        }
    }
}
