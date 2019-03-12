// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Seasonally Unadjusted Quarterly Data on Disposable Income and Expenditure
    /// </summary>

    public class IncomeUK
    {
        public readonly int κ;
        public readonly int income;
        public readonly int consumption;

        public IncomeUK(int κ, int income, int consumption)
        {
            this.κ = κ;
            this.income = income;
            this.consumption = consumption;
        }

        public static IEnumerable<IncomeUK> Data
        {
            get
            {
                yield return new IncomeUK(1, 9014, 8016);
                yield return new IncomeUK(2, 9659, 8798);
                yield return new IncomeUK(3, 9848, 9184);
                yield return new IncomeUK(4, 10316, 9755);
                yield return new IncomeUK(5, 10254, 9113);
                yield return new IncomeUK(6, 11271, 9837);
                yield return new IncomeUK(7, 11298, 10337);
                yield return new IncomeUK(8, 12051, 11135);
                yield return new IncomeUK(9, 11955, 10632);
                yield return new IncomeUK(10, 12920, 11144);
                yield return new IncomeUK(11, 13228, 11650);
                yield return new IncomeUK(12, 13814, 12586);
                yield return new IncomeUK(13, 13777, 11643);
                yield return new IncomeUK(14, 14509, 12750);
                yield return new IncomeUK(15, 15662, 13608);
                yield return new IncomeUK(16, 16292, 15068);
                yield return new IncomeUK(17, 17474, 14369);
                yield return new IncomeUK(18, 18355, 15944);
                yield return new IncomeUK(19, 19312, 16758);
                yield return new IncomeUK(20, 19664, 18140);
                yield return new IncomeUK(21, 20364, 17212);
                yield return new IncomeUK(22, 20931, 18221);
                yield return new IncomeUK(23, 22374, 19217);
                yield return new IncomeUK(24, 22389, 21025);
                yield return new IncomeUK(25, 22887, 19812);
                yield return new IncomeUK(26, 23796, 20901);
                yield return new IncomeUK(27, 24997, 21984);
                yield return new IncomeUK(28, 26101, 23781);
                yield return new IncomeUK(29, 26362, 23068);
                yield return new IncomeUK(30, 28078, 24028);
                yield return new IncomeUK(31, 29289, 25496);
                yield return new IncomeUK(32, 30360, 27056);
                yield return new IncomeUK(33, 30737, 26244);
                yield return new IncomeUK(34, 32932, 28610);
                yield return new IncomeUK(35, 35000, 30593);
                yield return new IncomeUK(36, 37979, 32709);
                yield return new IncomeUK(37, 37929, 32130);
                yield return new IncomeUK(38, 39783, 33027);
                yield return new IncomeUK(39, 41438, 35077);
                yield return new IncomeUK(40, 42035, 36761);
                yield return new IncomeUK(41, 42509, 35314);
                yield return new IncomeUK(42, 43416, 36924);
                yield return new IncomeUK(43, 44458, 39002);
                yield return new IncomeUK(44, 45002, 41099);
                yield return new IncomeUK(45, 46349, 38815);
                yield return new IncomeUK(46, 47239, 40221);
                yield return new IncomeUK(47, 48303, 42486);
                yield return new IncomeUK(48, 48875, 45090);
                yield return new IncomeUK(49, 49134, 42795);
                yield return new IncomeUK(50, 50943, 43955);
                yield return new IncomeUK(51, 52201, 46665);
                yield return new IncomeUK(52, 53164, 48792);
                yield return new IncomeUK(53, 52941, 45938);
                yield return new IncomeUK(54, 54825, 47553);
                yield return new IncomeUK(55, 55175, 49119);
                yield return new IncomeUK(56, 57583, 52063);
                yield return new IncomeUK(57, 56727, 49095);
                yield return new IncomeUK(58, 59790, 50481);
            }
        }
    }
}
