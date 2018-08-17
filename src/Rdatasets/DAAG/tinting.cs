// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Car Window Tinting Experiment Data
    /// </summary>

    public class tinting
    {
        public readonly int @case;
        public readonly int id;
        public readonly double age;
        public readonly string sex;
        public readonly string tint;
        public readonly string target;
        public readonly double it;
        public readonly double csoa;
        public readonly string agegp;

        public tinting(int @case, int id, double age, string sex, string tint, string target, double it, double csoa, string agegp)
        {
            this.@case = @case;
            this.id = id;
            this.age = age;
            this.sex = sex;
            this.tint = tint;
            this.target = target;
            this.it = it;
            this.csoa = csoa;
            this.agegp = agegp;
        }

        public static IEnumerable<tinting> Data
        {
            get
            {
                yield return new tinting(1, 1, 22.4, "f", "no", "hicon", 26, 46.8, "younger");
                yield return new tinting(1, 1, 22.4, "f", "lo", "hicon", 32.24, 37.44, "younger");
                yield return new tinting(1, 1, 22.4, "f", "hi", "hicon", 27.04, 42.64, "younger");
                yield return new tinting(1, 1, 22.4, "f", "no", "locon", 17.68, 41.6, "younger");
                yield return new tinting(1, 1, 22.4, "f", "lo", "locon", 20.8, 37.44, "younger");
                yield return new tinting(1, 1, 22.4, "f", "hi", "locon", 26, 40.56, "younger");
                yield return new tinting(1, 1, 22.4, "f", "no", "hicon", 24.96, 38.48, "younger");
                yield return new tinting(2, 2, 26.8, "f", "no", "hicon", 21.79, 44.61, "younger");
                yield return new tinting(2, 2, 26.8, "f", "lo", "hicon", 21.79, 50.84, "younger");
                yield return new tinting(2, 2, 26.8, "f", "hi", "hicon", 23.86, 51.88, "younger");
                yield return new tinting(2, 2, 26.8, "f", "no", "locon", 24.9, 47.73, "younger");
                yield return new tinting(2, 2, 26.8, "f", "lo", "locon", 32.16, 48.76, "younger");
                yield return new tinting(2, 2, 26.8, "f", "hi", "locon", 22.83, 57.06, "younger");
                yield return new tinting(2, 2, 26.8, "f", "no", "hicon", 24.9, 42.54, "younger");
                yield return new tinting(3, 3, 22.2, "f", "no", "hicon", 27.04, 38.48, "younger");
                yield return new tinting(3, 3, 22.2, "f", "lo", "hicon", 24.96, 32.24, "younger");
                yield return new tinting(3, 3, 22.2, "f", "hi", "hicon", 39.52, 30.16, "younger");
                yield return new tinting(3, 3, 22.2, "f", "no", "locon", 40.56, 44.72, "younger");
                yield return new tinting(3, 3, 22.2, "f", "lo", "locon", 27.04, 36.4, "younger");
                yield return new tinting(3, 3, 22.2, "f", "hi", "locon", 30.16, 33.28, "younger");
                yield return new tinting(3, 3, 22.2, "f", "no", "hicon", 21.84, 30.16, "younger");
                yield return new tinting(4, 5, 22.6, "m", "no", "hicon", 38.48, 38.48, "younger");
                yield return new tinting(4, 5, 22.6, "m", "lo", "hicon", 38.48, 35.36, "younger");
                yield return new tinting(4, 5, 22.6, "m", "hi", "hicon", 29.12, 38.48, "younger");
                yield return new tinting(4, 5, 22.6, "m", "no", "locon", 34.32, 38.48, "younger");
                yield return new tinting(4, 5, 22.6, "m", "lo", "locon", 32.24, 33.28, "younger");
                yield return new tinting(4, 5, 22.6, "m", "hi", "locon", 40.56, 32.24, "younger");
                yield return new tinting(4, 5, 22.6, "m", "no", "hicon", 35.36, 32.24, "younger");
                yield return new tinting(5, 11, 23.1, "f", "no", "hicon", 47.725, 63.2875, "younger");
                yield return new tinting(5, 11, 23.1, "f", "lo", "hicon", 29.05, 60.175, "younger");
                yield return new tinting(5, 11, 23.1, "f", "hi", "hicon", 38.3875, 60.175, "younger");
                yield return new tinting(5, 11, 23.1, "f", "no", "locon", 46.6875, 41.5, "younger");
                yield return new tinting(5, 11, 23.1, "f", "lo", "locon", 37.35, 43.575, "younger");
                yield return new tinting(5, 11, 23.1, "f", "hi", "locon", 38.3875, 54.9875, "younger");
                yield return new tinting(5, 11, 23.1, "f", "no", "hicon", 33.2, 47.725, "younger");
                yield return new tinting(6, 13, 27.3, "f", "no", "hicon", 29.05, 57.0625, "younger");
                yield return new tinting(6, 13, 27.3, "f", "lo", "hicon", 25.9375, 66.4, "younger");
                yield return new tinting(6, 13, 27.3, "f", "hi", "hicon", 28.0125, 50.8375, "younger");
                yield return new tinting(6, 13, 27.3, "f", "no", "locon", 30.0875, 49.8, "younger");
                yield return new tinting(6, 13, 27.3, "f", "lo", "locon", 31.125, 45.65, "younger");
                yield return new tinting(6, 13, 27.3, "f", "hi", "locon", 40.4625, 47.725, "younger");
                yield return new tinting(6, 13, 27.3, "f", "no", "hicon", 32.1625, 49.8, "younger");
                yield return new tinting(7, 15, 22.2, "f", "no", "hicon", 51.88, 46.6875, "younger");
                yield return new tinting(7, 15, 22.2, "f", "lo", "hicon", 79.89, 46.6875, "younger");
                yield return new tinting(7, 15, 22.2, "f", "hi", "hicon", 61.21, 50.8375, "younger");
                yield return new tinting(7, 15, 22.2, "f", "no", "locon", 45.65, 56.025, "younger");
                yield return new tinting(7, 15, 22.2, "f", "lo", "locon", 57.06, 54.9875, "younger");
                yield return new tinting(7, 15, 22.2, "f", "hi", "locon", 74.7, 51.875, "younger");
                yield return new tinting(7, 15, 22.2, "f", "no", "hicon", 43.58, 44.6125, "younger");
                yield return new tinting(8, 16, 27.8, "m", "no", "hicon", 25.9375, 35.275, "younger");
                yield return new tinting(8, 16, 27.8, "m", "lo", "hicon", 23.8625, 50.8375, "younger");
                yield return new tinting(8, 16, 27.8, "m", "hi", "hicon", 23.8625, 42.5375, "younger");
                yield return new tinting(8, 16, 27.8, "m", "no", "locon", 26.975, 41.5, "younger");
                yield return new tinting(8, 16, 27.8, "m", "lo", "locon", 37.35, 41.5, "younger");
                yield return new tinting(8, 16, 27.8, "m", "hi", "locon", 35.275, 41.5, "younger");
                yield return new tinting(8, 16, 27.8, "m", "no", "hicon", 20.75, 29.05, "younger");
                yield return new tinting(9, 17, 22.2, "f", "no", "hicon", 34.2375, 25.9375, "younger");
                yield return new tinting(9, 17, 22.2, "f", "lo", "hicon", 30.0875, 25.9375, "younger");
                yield return new tinting(9, 17, 22.2, "f", "hi", "hicon", 31.125, 30.0875, "younger");
                yield return new tinting(9, 17, 22.2, "f", "no", "locon", 35.275, 38.3875, "younger");
                yield return new tinting(9, 17, 22.2, "f", "lo", "locon", 31.125, 37.35, "younger");
                yield return new tinting(9, 17, 22.2, "f", "hi", "locon", 51.875, 36.3125, "younger");
                yield return new tinting(9, 17, 22.2, "f", "no", "hicon", 23.8625, 26.975, "younger");
                yield return new tinting(10, 18, 21.7, "f", "no", "hicon", 32.1625, 39.425, "younger");
                yield return new tinting(10, 18, 21.7, "f", "lo", "hicon", 31.125, 42.5375, "younger");
                yield return new tinting(10, 18, 21.7, "f", "hi", "hicon", 40.4625, 43.575, "younger");
                yield return new tinting(10, 18, 21.7, "f", "no", "locon", 42.5375, 48.7625, "younger");
                yield return new tinting(10, 18, 21.7, "f", "lo", "locon", 57.0625, 52.9125, "younger");
                yield return new tinting(10, 18, 21.7, "f", "hi", "locon", 43.575, 44.6125, "younger");
                yield return new tinting(10, 18, 21.7, "f", "no", "hicon", 34.2375, 41.5, "younger");
                yield return new tinting(11, 6, 70.3, "m", "no", "hicon", 46.8, 43.68, "older");
                yield return new tinting(11, 6, 70.3, "m", "lo", "hicon", 36.4, 54.08, "older");
                yield return new tinting(11, 6, 70.3, "m", "hi", "hicon", 46.8, 41.6, "older");
                yield return new tinting(11, 6, 70.3, "m", "no", "locon", 43.68, 49.92, "older");
                yield return new tinting(11, 6, 70.3, "m", "lo", "locon", 56.16, 42.64, "older");
                yield return new tinting(11, 6, 70.3, "m", "hi", "locon", 61.36, 46.8, "older");
                yield return new tinting(11, 6, 70.3, "m", "no", "hicon", 48.88, 37.44, "older");
                yield return new tinting(12, 7, 74.1, "m", "no", "hicon", 75.92, 63.44, "older");
                yield return new tinting(12, 7, 74.1, "m", "lo", "hicon", 70.72, 61.36, "older");
                yield return new tinting(12, 7, 74.1, "m", "hi", "hicon", 101.92, 62.4, "older");
                yield return new tinting(12, 7, 74.1, "m", "no", "locon", 81.12, 57.2, "older");
                yield return new tinting(12, 7, 74.1, "m", "lo", "locon", 80.08, 63.44, "older");
                yield return new tinting(12, 7, 74.1, "m", "hi", "locon", 92.56, 65.52, "older");
                yield return new tinting(12, 7, 74.1, "m", "no", "hicon", 75.92, 58.24, "older");
                yield return new tinting(13, 8, 72.1, "f", "no", "hicon", 44.72, 50.96, "older");
                yield return new tinting(13, 8, 72.1, "f", "lo", "hicon", 38.48, 37.44, "older");
                yield return new tinting(13, 8, 72.1, "f", "hi", "hicon", 75.92, 43.68, "older");
                yield return new tinting(13, 8, 72.1, "f", "no", "locon", 30.16, 42.64, "older");
                yield return new tinting(13, 8, 72.1, "f", "lo", "locon", 49.92, 39.52, "older");
                yield return new tinting(13, 8, 72.1, "f", "hi", "locon", 67.6, 45.76, "older");
                yield return new tinting(13, 8, 72.1, "f", "no", "hicon", 33.28, 38.48, "older");
                yield return new tinting(14, 9, 75.3, "m", "no", "hicon", 30.16, 46.8, "older");
                yield return new tinting(14, 9, 75.3, "m", "lo", "hicon", 35.36, 47.84, "older");
                yield return new tinting(14, 9, 75.3, "m", "hi", "hicon", 34.32, 47.84, "older");
                yield return new tinting(14, 9, 75.3, "m", "no", "locon", 42.64, 50.96, "older");
                yield return new tinting(14, 9, 75.3, "m", "lo", "locon", 47.84, 48.88, "older");
                yield return new tinting(14, 9, 75.3, "m", "hi", "locon", 42.64, 54.08, "older");
                yield return new tinting(14, 9, 75.3, "m", "no", "hicon", 27.04, 44.72, "older");
                yield return new tinting(15, 10, 74.7, "f", "no", "hicon", 50.96, 64.48, "older");
                yield return new tinting(15, 10, 74.7, "f", "lo", "hicon", 48.88, 54.08, "older");
                yield return new tinting(15, 10, 74.7, "f", "hi", "hicon", 56.16, 62.4, "older");
                yield return new tinting(15, 10, 74.7, "f", "no", "locon", 47.84, 60.32, "older");
                yield return new tinting(15, 10, 74.7, "f", "lo", "locon", 53.04, 63.44, "older");
                yield return new tinting(15, 10, 74.7, "f", "hi", "locon", 141.44, 60.32, "older");
                yield return new tinting(15, 10, 74.7, "f", "no", "hicon", 78, 52, "older");
                yield return new tinting(16, 21, 74.3, "m", "no", "hicon", 78.85, 76.775, "older");
                yield return new tinting(16, 21, 74.3, "m", "lo", "hicon", 61.2125, 73.6625, "older");
                yield return new tinting(16, 21, 74.3, "m", "hi", "hicon", 74.7, 84.0375, "older");
                yield return new tinting(16, 21, 74.3, "m", "no", "locon", 57.0625, 109.975, "older");
                yield return new tinting(16, 21, 74.3, "m", "lo", "locon", 57.0625, 89.225, "older");
                yield return new tinting(16, 21, 74.3, "m", "hi", "locon", 91.3, 96.4875, "older");
                yield return new tinting(16, 21, 74.3, "m", "no", "hicon", 47.725, 80.925, "older");
                yield return new tinting(17, 22, 76.9, "m", "no", "hicon", 47.725, 77.8125, "older");
                yield return new tinting(17, 22, 76.9, "m", "lo", "hicon", 47.725, 65.3625, "older");
                yield return new tinting(17, 22, 76.9, "m", "hi", "hicon", 51.875, 59.1375, "older");
                yield return new tinting(17, 22, 76.9, "m", "no", "locon", 50.8375, 52.9125, "older");
                yield return new tinting(17, 22, 76.9, "m", "lo", "locon", 59.1375, 51.875, "older");
                yield return new tinting(17, 22, 76.9, "m", "hi", "locon", 67.4375, 62.25, "older");
                yield return new tinting(17, 22, 76.9, "m", "no", "hicon", 60.175, 44.6125, "older");
                yield return new tinting(18, 23, 74.4, "f", "no", "hicon", 38.3875, 38.3875, "older");
                yield return new tinting(18, 23, 74.4, "f", "lo", "hicon", 48.7625, 40.4625, "older");
                yield return new tinting(18, 23, 74.4, "f", "hi", "hicon", 44.6125, 41.5, "older");
                yield return new tinting(18, 23, 74.4, "f", "no", "locon", 59.1375, 53.95, "older");
                yield return new tinting(18, 23, 74.4, "f", "lo", "locon", 73.6625, 44.6125, "older");
                yield return new tinting(18, 23, 74.4, "f", "hi", "locon", 57.0625, 46.6875, "older");
                yield return new tinting(18, 23, 74.4, "f", "no", "hicon", 35.275, 39.425, "older");
                yield return new tinting(19, 26, 75.5, "m", "no", "hicon", 89.225, 60.175, "older");
                yield return new tinting(19, 26, 75.5, "m", "lo", "hicon", 99.6, 40.4625, "older");
                yield return new tinting(19, 26, 75.5, "m", "hi", "hicon", 120.35, 58.1, "older");
                yield return new tinting(19, 26, 75.5, "m", "no", "locon", 118.275, 47.725, "older");
                yield return new tinting(19, 26, 75.5, "m", "lo", "locon", 87.15, 47.725, "older");
                yield return new tinting(19, 26, 75.5, "m", "hi", "locon", 135.9125, 59.1375, "older");
                yield return new tinting(19, 26, 75.5, "m", "no", "hicon", 113.0875, 53.95, "older");
                yield return new tinting(20, 27, 73.4, "f", "no", "hicon", 34.2375, 42.5375, "older");
                yield return new tinting(20, 27, 73.4, "f", "lo", "hicon", 37.35, 38.3875, "older");
                yield return new tinting(20, 27, 73.4, "f", "hi", "hicon", 47.725, 38.3875, "older");
                yield return new tinting(20, 27, 73.4, "f", "no", "locon", 58.1, 48.7625, "older");
                yield return new tinting(20, 27, 73.4, "f", "lo", "locon", 58.1, 42.5375, "older");
                yield return new tinting(20, 27, 73.4, "f", "hi", "locon", 79.8875, 43.575, "older");
                yield return new tinting(20, 27, 73.4, "f", "no", "hicon", 28.0125, 44.6125, "older");
                yield return new tinting(21, 19, 24.5, "m", "no", "hicon", 38.39, 39.43, "younger");
                yield return new tinting(21, 19, 24.5, "m", "lo", "hicon", 42.54, 32.16, "younger");
                yield return new tinting(21, 19, 24.5, "m", "hi", "hicon", 40.46, 37.35, "younger");
                yield return new tinting(21, 19, 24.5, "m", "no", "locon", 39.43, 30.09, "younger");
                yield return new tinting(21, 19, 24.5, "m", "lo", "locon", 39.43, 30.09, "younger");
                yield return new tinting(21, 19, 24.5, "m", "hi", "locon", 48.76, 33.2, "younger");
                yield return new tinting(21, 19, 24.5, "m", "no", "hicon", 36.31, 25.94, "younger");
                yield return new tinting(22, 25, 78.2, "m", "no", "hicon", 140.06, 74.7, "older");
                yield return new tinting(22, 25, 78.2, "m", "lo", "hicon", 123.46, 68.48, "older");
                yield return new tinting(22, 25, 78.2, "m", "hi", "hicon", 139.03, 77.81, "older");
                yield return new tinting(22, 25, 78.2, "m", "no", "locon", 159.78, 77.81, "older");
                yield return new tinting(22, 25, 78.2, "m", "lo", "locon", 146.29, 87.15, "older");
                yield return new tinting(22, 25, 78.2, "m", "hi", "locon", 199.2, 128.65, "older");
                yield return new tinting(22, 25, 78.2, "m", "no", "hicon", 121.39, 61.21, "older");
                yield return new tinting(23, 28, 71, "m", "no", "hicon", 135.91, 77.81, "older");
                yield return new tinting(23, 28, 71, "m", "lo", "hicon", 98.56, 68.48, "older");
                yield return new tinting(23, 28, 71, "m", "hi", "hicon", 122.43, 65.36, "older");
                yield return new tinting(23, 28, 71, "m", "no", "locon", 113.09, 68.48, "older");
                yield return new tinting(23, 28, 71, "m", "lo", "locon", 120.35, 69.51, "older");
                yield return new tinting(23, 28, 71, "m", "hi", "locon", 197.12, 105.83, "older");
                yield return new tinting(23, 28, 71, "m", "no", "hicon", 91.3, 53.95, "older");
                yield return new tinting(24, 12, 26.1, "m", "no", "hicon", 78.85, 53.95, "younger");
                yield return new tinting(24, 12, 26.1, "m", "lo", "hicon", 60.18, 37.35, "younger");
                yield return new tinting(24, 12, 26.1, "m", "hi", "hicon", 72.63, 41.5, "younger");
                yield return new tinting(24, 12, 26.1, "m", "no", "locon", 51.88, 38.39, "younger");
                yield return new tinting(24, 12, 26.1, "m", "lo", "locon", 56.03, 43.58, "younger");
                yield return new tinting(24, 12, 26.1, "m", "hi", "locon", 65.36, 44.61, "younger");
                yield return new tinting(24, 12, 26.1, "m", "no", "hicon", 67.44, 46.69, "younger");
                yield return new tinting(25, 24, 70.4, "m", "no", "hicon", 174.3, 60.18, "older");
                yield return new tinting(25, 24, 70.4, "m", "lo", "hicon", 104.58, 60.18, "older");
                yield return new tinting(25, 24, 70.4, "m", "hi", "hicon", 151.48, 68.48, "older");
                yield return new tinting(25, 24, 70.4, "m", "no", "locon", 169.11, 70.55, "older");
                yield return new tinting(25, 24, 70.4, "m", "lo", "locon", 187.58, 74.7, "older");
                yield return new tinting(25, 24, 70.4, "m", "hi", "locon", 209.58, 84.04, "older");
                yield return new tinting(25, 24, 70.4, "m", "no", "hicon", 124.5, 51.88, "older");
                yield return new tinting(26, 14, 23.2, "f", "no", "hicon", 41.5, 39.43, "younger");
                yield return new tinting(26, 14, 23.2, "f", "lo", "hicon", 50.84, 25.94, "younger");
                yield return new tinting(26, 14, 23.2, "f", "hi", "hicon", 43.58, 36.31, "younger");
                yield return new tinting(26, 14, 23.2, "f", "no", "locon", 53.95, 29.05, "younger");
                yield return new tinting(26, 14, 23.2, "f", "lo", "locon", 41.5, 31.13, "younger");
                yield return new tinting(26, 14, 23.2, "f", "hi", "locon", 60.18, 26.98, "younger");
                yield return new tinting(26, 14, 23.2, "f", "no", "hicon", 36.31, 28.01, "younger");
            }
        }
    }
}
