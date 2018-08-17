// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Ability and Intelligence Tests
    /// </summary>

    public class ability_cov
    {
        public readonly double cov_general;
        public readonly double cov_picture;
        public readonly double cov_blocks;
        public readonly double cov_maze;
        public readonly double cov_reading;
        public readonly double cov_vocab;
        public readonly int center;
        public readonly int n_obs;

        public ability_cov(double cov_general, double cov_picture, double cov_blocks, double cov_maze, double cov_reading, double cov_vocab, int center, int n_obs)
        {
            this.cov_general = cov_general;
            this.cov_picture = cov_picture;
            this.cov_blocks = cov_blocks;
            this.cov_maze = cov_maze;
            this.cov_reading = cov_reading;
            this.cov_vocab = cov_vocab;
            this.center = center;
            this.n_obs = n_obs;
        }

        public static IEnumerable<ability_cov> Data
        {
            get
            {
                yield return new ability_cov(24.641, 5.991, 33.52, 6.023, 20.755, 29.701, 0, 112);
                yield return new ability_cov(5.991, 6.7, 18.137, 1.782, 4.936, 7.204, 0, 112);
                yield return new ability_cov(33.52, 18.137, 149.831, 19.424, 31.43, 50.753, 0, 112);
                yield return new ability_cov(6.023, 1.782, 19.424, 12.711, 4.757, 9.075, 0, 112);
                yield return new ability_cov(20.755, 4.936, 31.43, 4.757, 52.604, 66.762, 0, 112);
                yield return new ability_cov(29.701, 7.204, 50.753, 9.075, 66.762, 135.292, 0, 112);
            }
        }
    }
}
