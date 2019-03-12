// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// House of Representatives Voting Data
    /// </summary>

    public class voting
    {
        public readonly string κ;
        public readonly int Hunt_R_;
        public readonly int Sandman_R_;
        public readonly int Howard_D_;
        public readonly int Thompson_D_;
        public readonly int Freylinghuysen_R_;
        public readonly int Forsythe_R_;
        public readonly int Widnall_R_;
        public readonly int Roe_D_;
        public readonly int Heltoski_D_;
        public readonly int Rodino_D_;
        public readonly int Minish_D_;
        public readonly int Rinaldo_R_;
        public readonly int Maraziti_R_;
        public readonly int Daniels_D_;
        public readonly int Patten_D_;

        public voting(string κ, int Hunt_R_, int Sandman_R_, int Howard_D_, int Thompson_D_, int Freylinghuysen_R_, int Forsythe_R_, int Widnall_R_, int Roe_D_, int Heltoski_D_, int Rodino_D_, int Minish_D_, int Rinaldo_R_, int Maraziti_R_, int Daniels_D_, int Patten_D_)
        {
            this.κ = κ;
            this.Hunt_R_ = Hunt_R_;
            this.Sandman_R_ = Sandman_R_;
            this.Howard_D_ = Howard_D_;
            this.Thompson_D_ = Thompson_D_;
            this.Freylinghuysen_R_ = Freylinghuysen_R_;
            this.Forsythe_R_ = Forsythe_R_;
            this.Widnall_R_ = Widnall_R_;
            this.Roe_D_ = Roe_D_;
            this.Heltoski_D_ = Heltoski_D_;
            this.Rodino_D_ = Rodino_D_;
            this.Minish_D_ = Minish_D_;
            this.Rinaldo_R_ = Rinaldo_R_;
            this.Maraziti_R_ = Maraziti_R_;
            this.Daniels_D_ = Daniels_D_;
            this.Patten_D_ = Patten_D_;
        }

        public static IEnumerable<voting> Data
        {
            get
            {
                yield return new voting("Hunt(R)", 0, 8, 15, 15, 10, 9, 7, 15, 16, 14, 15, 16, 7, 11, 13);
                yield return new voting("Sandman(R)", 8, 0, 17, 12, 13, 13, 12, 16, 17, 15, 16, 17, 13, 12, 16);
                yield return new voting("Howard(D)", 15, 17, 0, 9, 16, 12, 15, 5, 5, 6, 5, 4, 11, 10, 7);
                yield return new voting("Thompson(D)", 15, 12, 9, 0, 14, 12, 13, 10, 8, 8, 8, 6, 15, 10, 7);
                yield return new voting("Freylinghuysen(R)", 10, 13, 16, 14, 0, 8, 9, 13, 14, 12, 12, 12, 10, 11, 11);
                yield return new voting("Forsythe(R)", 9, 13, 12, 12, 8, 0, 7, 12, 11, 10, 9, 10, 6, 6, 10);
                yield return new voting("Widnall(R)", 7, 12, 15, 13, 9, 7, 0, 17, 16, 15, 14, 15, 10, 11, 13);
                yield return new voting("Roe(D)", 15, 16, 5, 10, 13, 12, 17, 0, 4, 5, 5, 3, 12, 7, 6);
                yield return new voting("Heltoski(D)", 16, 17, 5, 8, 14, 11, 16, 4, 0, 3, 2, 1, 13, 7, 5);
                yield return new voting("Rodino(D)", 14, 15, 6, 8, 12, 10, 15, 5, 3, 0, 1, 2, 11, 4, 6);
                yield return new voting("Minish(D)", 15, 16, 5, 8, 12, 9, 14, 5, 2, 1, 0, 1, 12, 5, 5);
                yield return new voting("Rinaldo(R)", 16, 17, 4, 6, 12, 10, 15, 3, 1, 2, 1, 0, 12, 6, 4);
                yield return new voting("Maraziti(R)", 7, 13, 11, 15, 10, 6, 10, 12, 13, 11, 12, 12, 0, 9, 13);
                yield return new voting("Daniels(D)", 11, 12, 10, 10, 11, 6, 11, 7, 7, 4, 5, 6, 9, 0, 9);
                yield return new voting("Patten(D)", 13, 16, 7, 7, 11, 10, 13, 6, 5, 6, 5, 4, 13, 9, 0);
            }
        }
    }
}
