// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Volume of Users of a Massachusetts Rail Trail
    /// </summary>

    public class Riders
    {
        public readonly string date;
        public readonly string day;
        public readonly int highT;
        public readonly int lowT;
        public readonly int hi;
        public readonly int lo;
        public readonly double precip;
        public readonly double clouds;
        public readonly int riders;
        public readonly int ct;
        public readonly string weekday;
        public readonly string wday;

        public Riders(string date, string day, int highT, int lowT, int hi, int lo, double precip, double clouds, int riders, int ct, string weekday, string wday)
        {
            this.date = date;
            this.day = day;
            this.highT = highT;
            this.lowT = lowT;
            this.hi = hi;
            this.lo = lo;
            this.precip = precip;
            this.clouds = clouds;
            this.riders = riders;
            this.ct = ct;
            this.weekday = weekday;
            this.wday = wday;
        }

        public static IEnumerable<Riders> Data
        {
            get
            {
                yield return new Riders("2005-04-05", "Tuesday", 62, 39, 62, 39, 0, 0.8, 236, 236, "Y", "Y");
                yield return new Riders("2005-04-06", "Wednesday", 75, 43, 75, 43, 0, 6.3, 156, 156, "Y", "Y");
                yield return new Riders("2005-04-07", "Thursday", 70, 47, 70, 47, 0, 9.9, 328, 328, "Y", "Y");
                yield return new Riders("2005-04-08", "Friday", 65, 48, 65, 48, 0, 7.2, 418, 418, "Y", "Y");
                yield return new Riders("2005-04-09", "Saturday", 66, 38, 66, 38, 0, 0, 629, 629, "N", "N");
                yield return new Riders("2005-04-10", "Sunday", 74, 33, 74, 33, 0, 2.5, 635, 635, "N", "N");
                yield return new Riders("2005-04-11", "Monday", 56, 38, 56, 38, 0, 0, 335, 335, "Y", "Y");
                yield return new Riders("2005-04-12", "Tuesday", 54, 32, 54, 32, 0, 3.6, 304, 304, "Y", "Y");
                yield return new Riders("2005-04-13", "Wednesday", 59, 34, 59, 34, 0, 2.4, 344, 344, "Y", "Y");
                yield return new Riders("2005-04-14", "Thursday", 64, 41, 64, 41, 0, 3.4, 349, 349, "Y", "Y");
                yield return new Riders("2005-04-15", "Friday", 62, 36, 62, 36, 0, 0, 259, 259, "Y", "Y");
                yield return new Riders("2005-04-16", "Saturday", 70, 30, 70, 30, 0, 0, 461, 461, "N", "N");
                yield return new Riders("2005-04-17", "Sunday", 80, 33, 80, 33, 0, 0.7, 617, 617, "N", "N");
                yield return new Riders("2005-04-18", "Monday", 76, 44, 76, 44, 0, 1.8, 650, 650, "N", "N");
                yield return new Riders("2005-04-19", "Tuesday", 81, 39, 81, 39, 0, 0, 540, 540, "Y", "Y");
                yield return new Riders("2005-04-20", "Wednesday", 86, 50, 86, 50, 0, 6.2, 484, 484, "Y", "Y");
                yield return new Riders("2005-04-21", "Thursday", 67, 43, 67, 43, 0, 0.4, 445, 445, "Y", "Y");
                yield return new Riders("2005-04-22", "Friday", 63, 35, 63, 35, 0, 8.6, 365, 365, "Y", "Y");
                yield return new Riders("2005-04-24", "Sunday", 63, 46, 63, 46, 0.17, 6.9, 400, 400, "N", "N");
                yield return new Riders("2005-04-25", "Monday", 52, 43, 52, 43, 0.01, 5.8, 186, 186, "Y", "Y");
                yield return new Riders("2005-04-26", "Tuesday", 70, 41, 70, 41, 0, 5.1, 422, 422, "Y", "Y");
                yield return new Riders("2005-04-27", "Wednesday", 58, 51, 58, 51, 0.15, 10, 156, 156, "Y", "Y");
                yield return new Riders("2005-04-28", "Thursday", 61, 42, 61, 42, 0.01, 6.4, 322, 322, "Y", "Y");
                yield return new Riders("2005-04-29", "Friday", 66, 38, 66, 38, 0, 3.9, 186, 186, "Y", "Y");
                yield return new Riders("2005-05-03", "Tuesday", 57, 36, 57, 36, 0.01, 6.5, 174, 174, "Y", "Y");
                yield return new Riders("2005-05-04", "Wednesday", 57, 48, 57, 48, 0, 6.8, 259, 259, "Y", "Y");
                yield return new Riders("2005-05-05", "Thursday", 65, 30, 65, 30, 0, 4.3, 393, 393, "Y", "Y");
                yield return new Riders("2005-05-06", "Friday", 60, 34, 60, 34, 0, 10, 293, 293, "Y", "Y");
                yield return new Riders("2005-05-07", "Saturday", 49, 43, 49, 43, 0.12, 9.7, 129, 129, "N", "N");
                yield return new Riders("2005-05-08", "Sunday", 55, 43, 55, 43, 0, 9, 264, 264, "N", "N");
                yield return new Riders("2005-05-09", "Monday", 72, 47, 72, 47, 0, 4.1, 517, 517, "Y", "Y");
                yield return new Riders("2005-05-10", "Tuesday", 77, 43, 77, 43, 0, 0.4, 429, 429, "Y", "Y");
                yield return new Riders("2005-05-11", "Wednesday", 75, 47, 75, 47, 0, 6.8, 421, 421, "Y", "Y");
                yield return new Riders("2005-05-12", "Thursday", 61, 35, 61, 35, 0, 4.4, 362, 362, "Y", "Y");
                yield return new Riders("2005-05-13", "Friday", 66, 39, 66, 39, 0, 2.4, 417, 417, "Y", "Y");
                yield return new Riders("2005-05-14", "Saturday", 70, 49, 70, 49, 0, 7.9, 514, 514, "N", "N");
                yield return new Riders("2005-05-15", "Sunday", 65, 20, 65, 20, 0.22, 9.4, 314, 314, "N", "N");
                yield return new Riders("2005-05-16", "Monday", 69, 54, 69, 54, 0.02, 6.6, 375, 375, "Y", "Y");
                yield return new Riders("2005-05-17", "Tuesday", 70, 62, 70, 62, 0, 3, 460, 460, "Y", "Y");
                yield return new Riders("2005-05-18", "Wednesday", 67, 43, 67, 43, 0, 6.7, 371, 371, "Y", "Y");
                yield return new Riders("2005-05-19", "Thursday", 71, 39, 71, 39, 0, 5.2, 452, 452, "Y", "Y");
                yield return new Riders("2005-05-20", "Friday", 56, 41, 56, 41, 0, 7, 362, 362, "Y", "Y");
                yield return new Riders("2005-05-21", "Saturday", 67, 39, 67, 39, 0.02, 6.8, 407, 407, "N", "N");
                yield return new Riders("2005-05-22", "Sunday", 55, 45, 55, 45, 0.2, 9.6, 316, 316, "N", "N");
                yield return new Riders("2005-05-23", "Monday", 59, 40, 59, 40, 0.34, 9.4, 311, 311, "Y", "Y");
                yield return new Riders("2005-05-24", "Tuesday", 51, 39, 51, 39, 0.16, 10, 150, 150, "Y", "Y");
                yield return new Riders("2005-05-25", "Wednesday", 51, 49, 51, 49, 0.03, 10, 193, 193, "Y", "Y");
                yield return new Riders("2005-05-26", "Thursday", 55, 52, 55, 52, 0.14, 10, 200, 200, "Y", "Y");
                yield return new Riders("2005-05-27", "Friday", 74, 50, 74, 50, 0.12, 8, 409, 409, "Y", "Y");
                yield return new Riders("2005-05-28", "Saturday", 79, 47, 79, 47, 0.01, 7, 507, 507, "N", "N");
                yield return new Riders("2005-05-29", "Sunday", 74, 55, 74, 55, 0, 7.8, 339, 339, "N", "N");
                yield return new Riders("2005-05-30", "Monday", 77, 52, 77, 52, 0, 5, 736, 736, "N", "N");
                yield return new Riders("2005-05-31", "Tuesday", 74, 52, 74, 52, 0.32, 7.5, 397, 397, "Y", "Y");
                yield return new Riders("2005-06-01", "Wednesday", 72, 53, 72, 53, 0, 7.9, 376, 376, "Y", "Y");
                yield return new Riders("2005-06-02", "Thursday", 74, 55, 74, 55, 0, 4.6, 461, 461, "Y", "Y");
                yield return new Riders("2005-06-03", "Friday", 78, 55, 78, 55, 0, 8.5, 432, 432, "Y", "Y");
                yield return new Riders("2005-06-05", "Sunday", 89, 57, 89, 57, 0, 1.9, 356, 356, "N", "N");
                yield return new Riders("2005-06-22", "Wednesday", 73, 49, 73, 49, 0.29, 6.3, 419, 419, "Y", "Y");
                yield return new Riders("2005-06-23", "Thursday", 79, 45, 79, 45, 0, 4.1, 547, 547, "Y", "Y");
                yield return new Riders("2005-06-24", "Friday", 88, 54, 88, 54, 0, 6.2, 531, 531, "Y", "Y");
                yield return new Riders("2005-06-25", "Saturday", 95, 61, 95, 61, 0, 2.6, 385, 385, "N", "N");
                yield return new Riders("2005-06-26", "Sunday", 95, 66, 95, 66, 0, 4.1, 449, 449, "N", "N");
                yield return new Riders("2005-06-27", "Monday", 90, 66, 90, 66, 0, 6.6, 453, 453, "Y", "Y");
                yield return new Riders("2005-06-28", "Tuesday", 76, 72, 76, 72, 0.35, 9.7, 298, 298, "Y", "Y");
                yield return new Riders("2005-06-29", "Wednesday", 84, 70, 84, 70, 1.49, 9.9, 388, 388, "Y", "Y");
                yield return new Riders("2005-06-30", "Thursday", 84, 69, 84, 69, 0.01, 8.9, 505, 505, "Y", "Y");
                yield return new Riders("2005-07-01", "Friday", 83, 60, 83, 60, 0.14, 8.2, 405, 405, "Y", "Y");
                yield return new Riders("2005-07-02", "Saturday", 80, 55, 80, 55, 0, 3.8, 533, 533, "N", "N");
                yield return new Riders("2005-07-03", "Sunday", 80, 53, 80, 53, 0, 3.8, 564, 564, "N", "N");
                yield return new Riders("2005-07-04", "Monday", 83, 54, 83, 54, 0, 1.2, 535, 535, "N", "N");
                yield return new Riders("2005-07-05", "Tuesday", 83, 50, 83, 50, 0, 7.6, 501, 501, "Y", "Y");
                yield return new Riders("2005-07-06", "Wednesday", 81, 65, 81, 65, 1.44, 10, 256, 256, "Y", "Y");
                yield return new Riders("2005-07-07", "Thursday", 70, 63, 70, 63, 0, 9.9, 554, 554, "Y", "Y");
                yield return new Riders("2005-07-08", "Friday", 64, 58, 64, 58, 1.15, 10, 155, 155, "Y", "Y");
                yield return new Riders("2005-08-11", "Thursday", 92, 66, 92, 66, 0, 7.9, 395, 395, "Y", "Y");
                yield return new Riders("2005-08-12", "Friday", 90, 65, 90, 65, 0, 8.4, 411, 411, "Y", "Y");
                yield return new Riders("2005-08-13", "Saturday", 97, 71, 97, 71, 0.68, 6.1, 352, 352, "N", "N");
                yield return new Riders("2005-08-14", "Sunday", 89, 69, 89, 69, 0.36, 9, 286, 286, "N", "N");
                yield return new Riders("2005-11-04", "Friday", 69, 41, 69, 41, 0, 6.4, 339, 339, "Y", "Y");
                yield return new Riders("2005-11-05", "Saturday", 71, 42, 71, 42, 0, 4, 415, 415, "N", "N");
                yield return new Riders("2005-11-06", "Sunday", 59, 46, 59, 46, 0, 10, 261, 261, "N", "N");
                yield return new Riders("2005-11-07", "Monday", 59, 35, 59, 35, 0, 1.7, 252, 252, "Y", "Y");
                yield return new Riders("2005-11-08", "Tuesday", 59, 35, 59, 35, 0, 7.7, 331, 331, "Y", "Y");
                yield return new Riders("2005-11-09", "Wednesday", 46, 30, 46, 30, 0.2, 9.7, 189, 189, "Y", "Y");
                yield return new Riders("2005-11-10", "Thursday", 50, 35, 50, 35, 0, 5.8, 280, 280, "Y", "Y");
                yield return new Riders("2005-11-11", "Friday", 41, 25, 41, 25, 0, 0, 287, 287, "Y", "Y");
                yield return new Riders("2005-11-12", "Saturday", 51, 19, 51, 19, 0, 0, 291, 291, "N", "N");
                yield return new Riders("2005-11-13", "Sunday", 62, 28, 62, 28, 0.02, 5.7, 367, 367, "N", "N");
                yield return new Riders("2005-11-14", "Monday", 60, 32, 60, 32, 0, 1.2, 348, 348, "N", "N");
                yield return new Riders("2005-11-15", "Tuesday", 42, 37, 42, 37, 0.15, 10, 181, 181, "Y", "Y");
            }
        }
    }
}
