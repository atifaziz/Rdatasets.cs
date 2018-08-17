// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// Voter turnout experiment, using Rock The Vote ads
    /// </summary>

    public class RockTheVote
    {
        public readonly int strata;
        public readonly int treated;
        public readonly int r;
        public readonly int n;
        public readonly double p;
        public readonly int treatedIndex;

        public RockTheVote(int strata, int treated, int r, int n, double p, int treatedIndex)
        {
            this.strata = strata;
            this.treated = treated;
            this.r = r;
            this.n = n;
            this.p = p;
            this.treatedIndex = treatedIndex;
        }

        public static IEnumerable<RockTheVote> Data
        {
            get
            {
                yield return new RockTheVote(1, 0, 220, 359, 0.612813370473538, 1);
                yield return new RockTheVote(1, 1, 718, 990, 0.725252525252525, 1);
                yield return new RockTheVote(2, 0, 121, 244, 0.495901639344262, 1);
                yield return new RockTheVote(2, 1, 95, 177, 0.536723163841808, 2);
                yield return new RockTheVote(3, 0, 107, 230, 0.465217391304348, 2);
                yield return new RockTheVote(3, 0, 194, 363, 0.534435261707989, 2);
                yield return new RockTheVote(3, 1, 75, 122, 0.614754098360656, 3);
                yield return new RockTheVote(4, 0, 90, 263, 0.342205323193916, 3);
                yield return new RockTheVote(4, 1, 71, 167, 0.425149700598802, 4);
                yield return new RockTheVote(5, 0, 107, 226, 0.473451327433628, 4);
                yield return new RockTheVote(5, 1, 52, 100, 0.52, 5);
                yield return new RockTheVote(6, 0, 280, 472, 0.593220338983051, 5);
                yield return new RockTheVote(6, 1, 212, 373, 0.568364611260054, 6);
                yield return new RockTheVote(6, 1, 215, 349, 0.616045845272206, 7);
                yield return new RockTheVote(7, 0, 262, 470, 0.557446808510638, 7);
                yield return new RockTheVote(7, 1, 154, 268, 0.574626865671642, 8);
                yield return new RockTheVote(8, 0, 229, 404, 0.566831683168317, 8);
                yield return new RockTheVote(8, 0, 318, 581, 0.547332185886403, 8);
                yield return new RockTheVote(8, 1, 90, 177, 0.508474576271186, 9);
                yield return new RockTheVote(9, 0, 144, 289, 0.498269896193772, 9);
                yield return new RockTheVote(9, 1, 220, 370, 0.594594594594595, 10);
                yield return new RockTheVote(10, 0, 120, 273, 0.43956043956044, 10);
                yield return new RockTheVote(10, 1, 287, 548, 0.523722627737226, 11);
                yield return new RockTheVote(11, 0, 89, 137, 0.64963503649635, 11);
                yield return new RockTheVote(11, 1, 109, 159, 0.685534591194969, 12);
                yield return new RockTheVote(12, 0, 156, 293, 0.532423208191126, 12);
                yield return new RockTheVote(12, 1, 37, 55, 0.672727272727273, 13);
                yield return new RockTheVote(13, 0, 80, 165, 0.484848484848485, 13);
                yield return new RockTheVote(13, 1, 109, 226, 0.482300884955752, 14);
                yield return new RockTheVote(14, 0, 57, 104, 0.548076923076923, 14);
                yield return new RockTheVote(14, 1, 53, 100, 0.53, 15);
                yield return new RockTheVote(15, 0, 149, 245, 0.608163265306122, 15);
                yield return new RockTheVote(15, 1, 359, 582, 0.616838487972509, 16);
                yield return new RockTheVote(16, 0, 321, 534, 0.601123595505618, 16);
                yield return new RockTheVote(16, 1, 95, 191, 0.49738219895288, 17);
                yield return new RockTheVote(17, 0, 129, 290, 0.444827586206897, 17);
                yield return new RockTheVote(17, 1, 436, 752, 0.579787234042553, 18);
                yield return new RockTheVote(18, 0, 60, 123, 0.48780487804878, 18);
                yield return new RockTheVote(18, 1, 237, 410, 0.578048780487805, 19);
                yield return new RockTheVote(19, 0, 31, 55, 0.563636363636364, 19);
                yield return new RockTheVote(19, 1, 92, 179, 0.513966480446927, 20);
                yield return new RockTheVote(20, 0, 85, 163, 0.521472392638037, 20);
                yield return new RockTheVote(20, 1, 67, 164, 0.408536585365854, 21);
                yield return new RockTheVote(20, 1, 125, 216, 0.578703703703704, 22);
                yield return new RockTheVote(21, 0, 78, 132, 0.590909090909091, 22);
                yield return new RockTheVote(21, 1, 21, 30, 0.7, 23);
                yield return new RockTheVote(22, 0, 159, 294, 0.540816326530612, 23);
                yield return new RockTheVote(22, 1, 110, 170, 0.647058823529412, 24);
                yield return new RockTheVote(23, 0, 84, 166, 0.506024096385542, 24);
                yield return new RockTheVote(23, 1, 97, 147, 0.659863945578231, 25);
                yield return new RockTheVote(24, 0, 185, 334, 0.553892215568862, 25);
                yield return new RockTheVote(24, 1, 52, 100, 0.52, 26);
                yield return new RockTheVote(25, 0, 337, 526, 0.640684410646388, 26);
                yield return new RockTheVote(25, 0, 207, 381, 0.543307086614173, 26);
                yield return new RockTheVote(25, 1, 80, 127, 0.62992125984252, 27);
                yield return new RockTheVote(26, 0, 88, 150, 0.586666666666667, 27);
                yield return new RockTheVote(26, 1, 100, 162, 0.617283950617284, 28);
                yield return new RockTheVote(27, 0, 167, 214, 0.780373831775701, 28);
                yield return new RockTheVote(27, 1, 120, 180, 0.666666666666667, 29);
                yield return new RockTheVote(28, 0, 24, 39, 0.615384615384615, 29);
                yield return new RockTheVote(28, 1, 82, 139, 0.589928057553957, 30);
                yield return new RockTheVote(29, 0, 109, 217, 0.502304147465438, 30);
                yield return new RockTheVote(29, 1, 309, 510, 0.605882352941176, 31);
                yield return new RockTheVote(30, 0, 605, 879, 0.688282138794084, 31);
                yield return new RockTheVote(30, 1, 84, 161, 0.521739130434783, 32);
                yield return new RockTheVote(31, 0, 228, 471, 0.484076433121019, 32);
                yield return new RockTheVote(31, 1, 124, 328, 0.378048780487805, 33);
                yield return new RockTheVote(32, 0, 315, 685, 0.45985401459854, 33);
                yield return new RockTheVote(32, 1, 154, 529, 0.291115311909263, 34);
                yield return new RockTheVote(33, 0, 50, 161, 0.31055900621118, 34);
                yield return new RockTheVote(33, 1, 156, 388, 0.402061855670103, 35);
                yield return new RockTheVote(34, 0, 95, 213, 0.446009389671362, 35);
                yield return new RockTheVote(34, 1, 257, 493, 0.521298174442191, 36);
                yield return new RockTheVote(35, 0, 83, 323, 0.256965944272446, 36);
                yield return new RockTheVote(35, 1, 112, 241, 0.464730290456432, 37);
                yield return new RockTheVote(36, 0, 119, 280, 0.425, 37);
                yield return new RockTheVote(36, 1, 147, 324, 0.453703703703704, 38);
                yield return new RockTheVote(37, 0, 96, 202, 0.475247524752475, 38);
                yield return new RockTheVote(37, 1, 90, 204, 0.441176470588235, 39);
                yield return new RockTheVote(38, 0, 190, 392, 0.48469387755102, 39);
                yield return new RockTheVote(38, 1, 42, 85, 0.494117647058824, 40);
                yield return new RockTheVote(39, 0, 46, 136, 0.338235294117647, 40);
                yield return new RockTheVote(39, 1, 33, 92, 0.358695652173913, 41);
                yield return new RockTheVote(40, 0, 62, 158, 0.392405063291139, 41);
                yield return new RockTheVote(40, 1, 86, 148, 0.581081081081081, 42);
            }
        }
    }
}
