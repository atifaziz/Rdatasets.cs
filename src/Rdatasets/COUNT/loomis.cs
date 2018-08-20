// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// loomis
    /// </summary>

    public class loomis
    {
        public readonly int? anvisits;
        public readonly int? gender;
        public readonly int? income;
        public readonly int? income1;
        public readonly int? income2;
        public readonly int? income3;
        public readonly int? income4;
        public readonly int? travel;
        public readonly int? travel1;
        public readonly int? travel2;
        public readonly int? travel3;

        public loomis(int? anvisits, int? gender, int? income, int? income1, int? income2, int? income3, int? income4, int? travel, int? travel1, int? travel2, int? travel3)
        {
            this.anvisits = anvisits;
            this.gender = gender;
            this.income = income;
            this.income1 = income1;
            this.income2 = income2;
            this.income3 = income3;
            this.income4 = income4;
            this.travel = travel;
            this.travel1 = travel1;
            this.travel2 = travel2;
            this.travel3 = travel3;
        }

        public static IEnumerable<loomis> Data
        {
            get
            {
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, 1, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(null, 2, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, 2, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, null, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, 1, null, null, null, null, null, null, null, null, null);
                yield return new loomis(null, 2, 1, 1, 0, 0, 0, null, null, null, null);
                yield return new loomis(12, 2, 3, 0, 0, 1, 0, null, null, null, null);
                yield return new loomis(100, 2, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(35, 1, 1, 1, 0, 0, 0, null, null, null, null);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, null, null, null, null);
                yield return new loomis(6, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(2, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(1, 2, 1, 1, 0, 0, 0, null, null, null, null);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(100, 1, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(80, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(104, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(55, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(350, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(20, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(60, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(250, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(100, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(50, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(40, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(9, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(200, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(200, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(100, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(8, 1, null, null, null, null, null, 1, 1, 0, 0);
                yield return new loomis(6, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(2, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(15, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(12, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(120, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(52, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(35, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(75, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(10, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(250, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(15, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(4, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(25, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(50, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(114, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(100, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(15, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(30, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(120, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(null, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(160, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(12, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(25, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(15, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(14, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(15, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(8, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(125, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(96, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(260, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(25, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(30, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(50, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(6, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(12, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(72, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(20, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(25, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(50, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(30, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(5, 2, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(6, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(50, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(10, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(9, 1, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(4, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(12, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(15, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(7, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(100, 2, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(10, 1, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(50, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(100, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(30, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(2, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(4, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(2, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(10, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(4, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(5, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(6, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, null, null, null, null);
                yield return new loomis(1, 1, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(1, null, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(200, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(13, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(150, 2, null, null, null, null, null, 1, 1, 0, 0);
                yield return new loomis(25, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(10, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(40, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(10, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(6, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(35, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(24, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(100, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(17, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(20, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(40, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(52, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(15, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(60, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(30, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(20, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(6, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(70, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(35, null, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(30, 2, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(24, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(300, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(100, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(30, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(26, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(17, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(6, 2, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(100, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(20, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(150, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(20, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(70, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(20, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(100, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(20, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(100, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(50, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(null, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(10, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(60, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(10, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(2, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(7, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(24, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(6, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(null, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(4, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(90, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(20, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(75, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(12, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(70, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(22, null, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(2, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(20, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(3, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(52, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(5, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(25, 2, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(25, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(30, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(12, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(20, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(20, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(25, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(3, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, null, null, null, null, null, null, null, null, null);
                yield return new loomis(7, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, null, null, null, null);
                yield return new loomis(null, 1, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(3, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(15, 2, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(3, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, null, null, null, null);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(1, 2, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(150, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(5, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(150, 2, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(40, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(5, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(50, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(6, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(6, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(6, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(25, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(6, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(25, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(50, 2, null, null, null, null, null, 1, 1, 0, 0);
                yield return new loomis(3, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(150, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(60, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(3, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(4, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(50, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(14, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(4, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(60, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(30, 2, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(3, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(2, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(10, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(2, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(2, 2, 2, 0, 1, 0, 0, null, null, null, null);
                yield return new loomis(1, 2, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(2, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(2, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, null, null, null, null);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(8, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(2, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 2, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 1, 1, 0, 0, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, null, null, null, null, null, 3, 0, 0, 1);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(null, 1, 4, 0, 0, 0, 1, null, null, null, null);
                yield return new loomis(1, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(50, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(40, 1, 4, 0, 0, 0, 1, 1, 1, 0, 0);
                yield return new loomis(208, 2, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(50, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(20, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(150, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(50, 1, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(80, 2, null, null, null, null, null, 1, 1, 0, 0);
                yield return new loomis(75, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(6, 1, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(10, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(6, 2, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(26, 1, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(60, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(30, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(30, 2, 3, 0, 0, 1, 0, 1, 1, 0, 0);
                yield return new loomis(15, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(12, 2, 2, 0, 1, 0, 0, 1, 1, 0, 0);
                yield return new loomis(30, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(20, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(20, 2, 1, 1, 0, 0, 0, 1, 1, 0, 0);
                yield return new loomis(120, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(15, 2, 2, 0, 1, 0, 0, 2, 0, 1, 0);
                yield return new loomis(75, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(4, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(35, 1, 3, 0, 0, 1, 0, 2, 0, 1, 0);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 2, 0, 1, 0);
                yield return new loomis(30, 2, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(76, 1, 1, 1, 0, 0, 0, 2, 0, 1, 0);
                yield return new loomis(2, 2, null, null, null, null, null, 2, 0, 1, 0);
                yield return new loomis(1, 1, 3, 0, 0, 1, 0, 3, 0, 0, 1);
                yield return new loomis(3, 2, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(1, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
                yield return new loomis(3, 2, 2, 0, 1, 0, 0, 3, 0, 0, 1);
                yield return new loomis(2, 1, 4, 0, 0, 0, 1, 3, 0, 0, 1);
            }
        }
    }
}
