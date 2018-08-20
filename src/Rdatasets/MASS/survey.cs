// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Student Survey Data
    /// </summary>

    public class survey
    {
        public readonly string Sex;
        public readonly double? Wr_Hnd;
        public readonly double? NW_Hnd;
        public readonly string W_Hnd;
        public readonly string Fold;
        public readonly int? Pulse;
        public readonly string Clap;
        public readonly string Exer;
        public readonly string Smoke;
        public readonly double? Height;
        public readonly string M_I;
        public readonly double Age;

        public survey(string Sex, double? Wr_Hnd, double? NW_Hnd, string W_Hnd, string Fold, int? Pulse, string Clap, string Exer, string Smoke, double? Height, string M_I, double Age)
        {
            this.Sex = Sex;
            this.Wr_Hnd = Wr_Hnd;
            this.NW_Hnd = NW_Hnd;
            this.W_Hnd = W_Hnd;
            this.Fold = Fold;
            this.Pulse = Pulse;
            this.Clap = Clap;
            this.Exer = Exer;
            this.Smoke = Smoke;
            this.Height = Height;
            this.M_I = M_I;
            this.Age = Age;
        }

        public static IEnumerable<survey> Data
        {
            get
            {
                yield return new survey("Female", 18.5, 18, "Right", "R on L", 92, "Left", "Some", "Never", 173, "Metric", 18.25);
                yield return new survey("Male", 19.5, 20.5, "Left", "R on L", 104, "Left", "None", "Regul", 177.8, "Imperial", 17.583);
                yield return new survey("Male", 18, 13.3, "Right", "L on R", 87, "Neither", "None", "Occas", null, null, 16.917);
                yield return new survey("Male", 18.8, 18.9, "Right", "R on L", null, "Neither", "None", "Never", 160, "Metric", 20.333);
                yield return new survey("Male", 20, 20, "Right", "Neither", 35, "Right", "Some", "Never", 165, "Metric", 23.667);
                yield return new survey("Female", 18, 17.7, "Right", "L on R", 64, "Right", "Some", "Never", 172.72, "Imperial", 21);
                yield return new survey("Male", 17.7, 17.7, "Right", "L on R", 83, "Right", "Freq", "Never", 182.88, "Imperial", 18.833);
                yield return new survey("Female", 17, 17.3, "Right", "R on L", 74, "Right", "Freq", "Never", 157, "Metric", 35.833);
                yield return new survey("Male", 20, 19.5, "Right", "R on L", 72, "Right", "Some", "Never", 175, "Metric", 19);
                yield return new survey("Male", 18.5, 18.5, "Right", "R on L", 90, "Right", "Some", "Never", 167, "Metric", 22.333);
                yield return new survey("Female", 17, 17.2, "Right", "L on R", 80, "Right", "Freq", "Never", 156.2, "Imperial", 28.5);
                yield return new survey("Male", 21, 21, "Right", "R on L", 68, "Left", "Freq", "Never", null, null, 18.25);
                yield return new survey("Female", 16, 16, "Right", "L on R", null, "Right", "Some", "Never", 155, "Metric", 18.75);
                yield return new survey("Female", 19.5, 20.2, "Right", "L on R", 66, "Neither", "Some", "Never", 155, "Metric", 17.5);
                yield return new survey("Male", 16, 15.5, "Right", "R on L", 60, "Right", "Some", "Never", null, null, 17.167);
                yield return new survey("Female", 17.5, 17, "Right", "R on L", null, "Right", "Freq", "Never", 156, "Metric", 17.167);
                yield return new survey("Female", 18, 18, "Right", "L on R", 89, "Neither", "Freq", "Never", 157, "Metric", 19.333);
                yield return new survey("Male", 19.4, 19.2, "Left", "R on L", 74, "Right", "Some", "Never", 182.88, "Imperial", 18.333);
                yield return new survey("Male", 20.5, 20.5, "Right", "L on R", null, "Left", "Some", "Never", 190.5, "Imperial", 19.75);
                yield return new survey("Male", 21, 20.9, "Right", "R on L", 78, "Right", "Freq", "Never", 177, "Metric", 17.917);
                yield return new survey("Male", 21.5, 22, "Right", "R on L", 72, "Left", "Freq", "Never", 190.5, "Imperial", 17.917);
                yield return new survey("Male", 20.1, 20.7, "Right", "L on R", 72, "Right", "Freq", "Never", 180.34, "Imperial", 18.167);
                yield return new survey("Male", 18.5, 18, "Right", "L on R", 64, "Right", "Freq", "Never", 180.34, "Imperial", 17.833);
                yield return new survey("Male", 21.5, 21.2, "Right", "R on L", 62, "Right", "Some", "Never", 184, "Metric", 18.25);
                yield return new survey("Female", 17, 17.5, "Right", "R on L", 64, "Left", "Some", "Never", null, null, 19.167);
                yield return new survey("Male", 18.5, 18.5, "Right", "Neither", 90, "Neither", "Some", "Never", null, null, 17.583);
                yield return new survey("Male", 21, 20.7, "Right", "R on L", 90, "Right", "Some", "Never", 172.72, "Imperial", 17.5);
                yield return new survey("Male", 20.8, 21.4, "Right", "R on L", 62, "Neither", "Freq", "Never", 175.26, "Imperial", 18.083);
                yield return new survey("Male", 17.8, 17.8, "Right", "L on R", 76, "Neither", "Freq", "Never", null, null, 21.917);
                yield return new survey("Male", 19.5, 19.5, "Right", "L on R", 79, "Right", "Some", "Never", 167, "Metric", 19.25);
                yield return new survey("Female", 18.5, 18, "Right", "R on L", 76, "Right", "None", "Occas", null, null, 41.583);
                yield return new survey("Male", 18.8, 18.2, "Right", "L on R", 78, "Right", "Freq", "Never", 180, "Metric", 17.5);
                yield return new survey("Female", 17.1, 17.5, "Right", "R on L", 72, "Right", "Freq", "Heavy", 166.4, "Imperial", 39.75);
                yield return new survey("Male", 20.1, 20, "Right", "R on L", 70, "Right", "Some", "Never", 180, "Metric", 17.167);
                yield return new survey("Male", 18, 19, "Right", "L on R", 54, "Neither", "Some", "Regul", null, null, 17.75);
                yield return new survey("Male", 22.2, 21, "Right", "L on R", 66, "Right", "Freq", "Occas", 190, "Metric", 18);
                yield return new survey("Female", 16, 16.5, "Right", "L on R", null, "Right", "Some", "Never", 168, "Metric", 19);
                yield return new survey("Male", 19.4, 18.5, "Right", "R on L", 72, "Neither", "Freq", "Never", 182.5, "Metric", 17.917);
                yield return new survey("Male", 22, 22, "Right", "R on L", 80, "Right", "Some", "Never", 185, "Metric", 35.5);
                yield return new survey("Male", 19, 19, "Right", "R on L", null, "Neither", "Freq", "Occas", 171, "Metric", 19.917);
                yield return new survey("Female", 17.5, 16, "Right", "L on R", null, "Right", "Some", "Never", 169, "Metric", 17.5);
                yield return new survey("Female", 17.8, 18, "Right", "R on L", 72, "Right", "Some", "Never", 154.94, "Imperial", 17.083);
                yield return new survey("Male", null, null, "Right", "R on L", 60, null, "Some", "Never", 172, "Metric", 28.583);
                yield return new survey("Female", 20.1, 20.2, "Right", "L on R", 80, "Right", "Some", "Never", 176.5, "Imperial", 17.5);
                yield return new survey("Female", 13, 13, null, "L on R", 70, "Left", "Freq", "Never", 180.34, "Imperial", 17.417);
                yield return new survey("Male", 17, 17.5, "Right", "R on L", null, "Neither", "Freq", "Never", 180.34, "Imperial", 18.5);
                yield return new survey("Male", 23.2, 22.7, "Right", "L on R", 84, "Left", "Freq", "Regul", 180, "Metric", 18.917);
                yield return new survey("Male", 22.5, 23, "Right", "R on L", 96, "Right", "None", "Never", 170, "Metric", 19.417);
                yield return new survey("Female", 18, 17.6, "Right", "R on L", 60, "Right", "Some", "Occas", 168, "Metric", 18.417);
                yield return new survey("Female", 18, 17.9, "Right", "R on L", 50, "Left", "None", "Never", 165, "Metric", 30.75);
                yield return new survey("Male", 22, 21.5, "Left", "R on L", 55, "Left", "Freq", "Never", 200, "Metric", 18.5);
                yield return new survey("Male", 20.5, 20, "Right", "L on R", 68, "Right", "Freq", "Never", 190, "Metric", 17.5);
                yield return new survey("Male", 17, 18, "Right", "L on R", 78, "Left", "Some", "Never", 170.18, "Imperial", 18.333);
                yield return new survey("Male", 20.5, 19.5, "Right", "L on R", 56, "Right", "Freq", "Never", 179, "Metric", 17.417);
                yield return new survey("Male", 22.5, 22.5, "Right", "R on L", 65, "Right", "Freq", "Regul", 182, "Metric", 20);
                yield return new survey("Male", 18.5, 18.5, "Right", "L on R", null, "Neither", "Freq", "Never", 171, "Metric", 18.333);
                yield return new survey("Female", 15.5, 15.4, "Right", "R on L", 70, "Neither", "None", "Never", 157.48, "Imperial", 17.167);
                yield return new survey("Male", 19.5, 19.7, "Right", "R on L", 72, "Right", "Freq", "Never", null, null, 17.417);
                yield return new survey("Male", 19.5, 19, "Right", "L on R", 62, "Right", "Freq", "Never", 177.8, "Imperial", 17.667);
                yield return new survey("Male", 20.6, 21, "Left", "L on R", null, "Left", "Freq", "Occas", 175.26, "Imperial", 18.417);
                yield return new survey("Male", 22.8, 23.2, "Right", "R on L", 66, "Neither", "Freq", "Never", 187, "Metric", 20.333);
                yield return new survey("Female", 18.5, 18.2, "Right", "R on L", 72, "Neither", "Freq", "Never", 167.64, "Imperial", 17.333);
                yield return new survey("Female", 19.6, 19.7, "Right", "L on R", 70, "Right", "Freq", "Never", 178, "Metric", 17.5);
                yield return new survey("Female", 18.7, 18, "Left", "L on R", null, "Left", "None", "Never", 170, "Metric", 19.833);
                yield return new survey("Female", 17.3, 18, "Right", "L on R", 64, "Neither", "Freq", "Never", 164, "Metric", 18.583);
                yield return new survey("Male", 19.5, 19.8, "Right", "Neither", null, "Right", "Freq", "Never", 183, "Metric", 18);
                yield return new survey("Female", 19, 19.1, "Right", "L on R", null, "Neither", "Freq", "Never", 172, "Metric", 30.667);
                yield return new survey("Female", 18.5, 18, "Right", "R on L", 64, "Right", "Freq", "Never", null, null, 16.917);
                yield return new survey("Male", 19, 19, "Right", "L on R", null, "Right", "Some", "Never", 180, "Metric", 19.917);
                yield return new survey("Male", 21, 19.5, "Right", "L on R", 80, "Left", "None", null, null, null, 18.333);
                yield return new survey("Female", 18, 17.5, "Right", "L on R", 64, "Left", "Freq", "Never", 170, "Metric", 17.583);
                yield return new survey("Male", 19.4, 19.5, "Right", "R on L", null, "Right", "Freq", "Heavy", 176, "Metric", 17.833);
                yield return new survey("Female", 17, 16.6, "Right", "R on L", 68, "Right", "Some", "Never", 171, "Metric", 17.667);
                yield return new survey("Female", 16.5, 17, "Right", "L on R", 40, "Left", "Freq", "Never", 167.64, "Imperial", 17.417);
                yield return new survey("Female", 15.6, 15.8, "Right", "R on L", 88, "Left", "Some", "Never", 165, "Metric", 17.75);
                yield return new survey("Female", 17.5, 17.5, "Right", "Neither", 68, "Right", "Freq", "Heavy", 170, "Metric", 20.667);
                yield return new survey("Female", 17, 17.6, "Right", "L on R", 76, "Right", "Some", "Never", 165, "Metric", 23.583);
                yield return new survey("Female", 18.6, 18, "Right", "L on R", null, "Neither", "Freq", "Heavy", 165.1, "Imperial", 17.167);
                yield return new survey("Female", 18.3, 18.5, "Right", "R on L", 68, "Neither", "Some", "Never", 165.1, "Imperial", 17.083);
                yield return new survey("Male", 20, 20.5, "Right", "L on R", null, "Right", "Freq", "Never", 185.42, "Imperial", 18.75);
                yield return new survey("Male", 19.5, 19.5, "Left", "R on L", 66, "Left", "Some", "Never", null, null, 16.75);
                yield return new survey("Male", 19.2, 18.9, "Right", "R on L", 76, "Right", "Freq", "Never", 176.5, "Imperial", 20.167);
                yield return new survey("Female", 17.5, 17.5, "Right", "R on L", 98, "Left", "Freq", "Never", null, null, 17.667);
                yield return new survey("Female", 17, 17.4, "Right", "R on L", null, "Neither", "Some", "Never", null, null, 17.167);
                yield return new survey("Male", 23, 23.5, "Right", "L on R", 90, "Right", "Freq", "Never", 167.64, "Imperial", 17.167);
                yield return new survey("Female", 17.7, 17, "Right", "R on L", 76, "Right", "Some", "Never", 167, "Metric", 17.25);
                yield return new survey("Female", 18.2, 18, "Right", "L on R", 70, "Right", "Some", "Never", 162.56, "Imperial", 18);
                yield return new survey("Female", 18.3, 18.5, "Right", "R on L", 75, "Left", "Freq", "Never", 170, "Metric", 18.75);
                yield return new survey("Male", 18, 18, "Right", "Neither", 60, "Right", "Freq", "Never", 179, "Metric", 21.583);
                yield return new survey("Female", 18, 17.7, "Left", "R on L", 92, "Left", "Some", "Never", null, null, 17.583);
                yield return new survey("Male", 20.5, 20, "Right", "R on L", 75, "Left", "Some", "Never", 183, "Metric", 19.667);
                yield return new survey("Female", 17.5, 18, "Right", "Neither", null, "Right", "Some", "Never", null, null, 18);
                yield return new survey("Female", 18.2, 17.5, "Right", "L on R", 70, "Right", "Some", "Never", 165, "Metric", 19.667);
                yield return new survey("Female", 18.2, 18.5, "Right", "R on L", null, "Right", "Some", "Never", 168, "Metric", 17.083);
                yield return new survey("Male", 21.3, 20.8, "Right", "R on L", 65, "Right", "Freq", "Heavy", 179, "Metric", 22.833);
                yield return new survey("Female", 19, 18.8, "Right", "L on R", null, "Right", "Some", "Never", null, null, 17.083);
                yield return new survey("Male", 20, 19.5, "Right", "R on L", 68, "Neither", "Freq", "Regul", 190, "Metric", 19.417);
                yield return new survey("Female", 17.5, 17.5, "Right", "R on L", 60, "Right", "Freq", "Never", 166.5, "Metric", 23.25);
                yield return new survey("Male", 19.5, 19.4, "Right", "Neither", null, "Right", "Freq", "Never", 165, "Metric", 18.083);
                yield return new survey("Female", 19.4, 19.6, "Right", "R on L", 68, "Neither", "Freq", "Never", 175.26, "Imperial", 19.083);
                yield return new survey("Male", 21.9, 22.2, "Right", "R on L", null, "Right", "Some", "Never", 187, "Metric", 18.917);
                yield return new survey("Male", 18.9, 19.1, "Right", "L on R", 60, "Neither", "None", "Never", 170, "Metric", 17.75);
                yield return new survey("Female", 16, 16, "Right", "Neither", null, "Right", "Some", "Never", 159, "Metric", 20.833);
                yield return new survey("Female", 17.5, 17.3, "Right", "R on L", 72, "Right", "Freq", "Never", 175, "Metric", 20.167);
                yield return new survey("Female", 17.5, 17, "Right", "R on L", 80, "Left", "Some", "Heavy", 163, "Metric", 17.667);
                yield return new survey("Female", 19.5, 18.5, "Right", "R on L", 80, "Right", "Some", "Never", 170, "Metric", 18.25);
                yield return new survey("Female", 16.2, 16.4, "Right", "R on L", null, "Right", "Freq", "Occas", 172, "Metric", 17);
                yield return new survey("Female", 17, 15.9, "Right", "R on L", 85, "Right", "Freq", "Never", null, null, 18.5);
                yield return new survey("Male", 17.5, 17.5, "Right", "L on R", 64, "Neither", "Freq", "Never", 180, "Metric", 18.583);
                yield return new survey("Male", 19.7, 20.1, "Right", "R on L", 67, "Left", "Some", "Regul", 180.34, "Imperial", 17.75);
                yield return new survey("Female", 18.5, 18.5, "Right", "R on L", 76, "Left", "Freq", "Never", 175, "Metric", 24.167);
                yield return new survey("Male", 19.2, 19.6, "Right", "L on R", 80, "Right", "None", "Never", 190.5, "Imperial", 18.167);
                yield return new survey("Female", 17.2, 16.7, "Right", "R on L", 75, "Right", "Freq", "Never", 170.18, "Imperial", 21.167);
                yield return new survey("Male", 20.5, 21, "Right", "R on L", 60, "Right", "Freq", "Never", 185, "Metric", 17.917);
                yield return new survey("Female", 16, 15.5, "Right", "L on R", 60, "Left", "Freq", "Never", 162.56, "Imperial", 17.417);
                yield return new survey("Female", 16.9, 16, "Right", "L on R", 70, "Right", "None", "Never", 158, "Metric", 20.5);
                yield return new survey("Female", 17, 16.7, "Right", "R on L", 70, "Right", "Some", "Never", 159, "Metric", 22.917);
                yield return new survey("Male", 23, 22, "Left", "L on R", 83, "Left", "Some", "Heavy", 193.04, "Imperial", 18.917);
                yield return new survey("Female", 18.5, 18, "Left", "L on R", 100, "Neither", "Some", "Never", 171, "Metric", 18.917);
                yield return new survey("Male", 21, 20.4, "Right", "L on R", 100, "Right", "Freq", "Heavy", 184, "Metric", 20.083);
                yield return new survey("Male", 20, 20, "Right", "R on L", 80, "Neither", "Freq", "Occas", null, null, 17.5);
                yield return new survey("Male", 22.5, 22.5, "Right", "L on R", 76, "Right", "Freq", "Occas", 177, "Metric", 18.25);
                yield return new survey("Female", 18.5, 18, "Right", "R on L", 92, "Right", "Freq", "Never", 172, "Metric", 17.5);
                yield return new survey("Male", 19.8, 20, "Left", "L on R", 59, "Right", "Freq", "Never", 180, "Metric", 17.417);
                yield return new survey("Male", 18.5, 18.1, "Right", "L on R", 66, "Left", "Freq", "Never", 175.26, "Imperial", 21);
                yield return new survey("Male", 19.3, 19.4, "Right", "R on L", null, "Right", "Freq", "Never", 180.34, "Imperial", 19.833);
                yield return new survey("Female", 16, 16, "Right", "R on L", 68, "Right", "Freq", "Never", 172.72, "Imperial", 17.667);
                yield return new survey("Male", 18.8, 19.1, "Right", "L on R", 66, "Neither", "Freq", "Regul", 178.5, "Metric", 18.083);
                yield return new survey("Female", 17.5, 17, "Right", "R on L", 74, "Right", "Freq", "Never", 157, "Metric", 18);
                yield return new survey("Female", 16.4, 16.5, "Right", "L on R", 90, "Right", "Some", "Never", 152, "Metric", 18.333);
                yield return new survey("Male", 22, 21.5, "Right", "R on L", 86, "Right", "Freq", "Never", 187.96, "Imperial", 20);
                yield return new survey("Male", 19, 19.5, "Right", "L on R", 60, "Right", "Some", "Never", 178, "Metric", 18.75);
                yield return new survey("Female", 18.9, 20, "Right", "R on L", 86, "Right", "Some", "Never", null, null, 19.083);
                yield return new survey("Female", 15.4, 16.4, "Left", "L on R", 80, "Left", "Freq", "Occas", 160.02, "Imperial", 18.5);
                yield return new survey("Male", 17.9, 17.8, "Right", "R on L", 85, "Left", "Some", "Never", 175.26, "Imperial", 18.417);
                yield return new survey("Male", 23.1, 22.5, "Right", "L on R", 90, "Right", "Some", "Regul", 189, "Metric", 19.167);
                yield return new survey(null, 19.8, 19, "Left", "L on R", 73, "Neither", "Freq", "Never", 172, "Metric", 21.5);
                yield return new survey("Male", 22, 22, "Right", "L on R", 72, "Right", "Freq", "Never", 182.88, "Imperial", 19.333);
                yield return new survey("Male", 20, 19.5, "Right", "L on R", null, "Right", "Freq", "Never", 170, "Metric", 21.417);
                yield return new survey("Female", 19.5, 18.5, "Right", "L on R", 68, "Right", "None", "Never", 167, "Metric", 18.667);
                yield return new survey("Female", 18, 18.6, "Right", "R on L", 84, "Right", "Some", "Never", 175, "Metric", 17.5);
                yield return new survey("Female", 18.3, 19, "Right", "R on L", null, "Right", "None", "Never", 165, "Metric", 21.083);
                yield return new survey("Female", 19, 18.8, "Right", "R on L", 65, "Right", "Freq", "Never", 172.72, "Imperial", 17.25);
                yield return new survey("Male", 21.4, 21, "Right", "L on R", 96, "Neither", "Some", "Never", 180, "Metric", 19);
                yield return new survey("Female", 20, 19.5, "Left", "R on L", 68, "Neither", "Freq", "Never", 172, "Metric", 19.167);
                yield return new survey("Male", 18.5, 18.5, "Right", "R on L", 75, "Neither", "Some", "Never", 185, "Metric", 19);
                yield return new survey("Male", 22.5, 22.6, "Right", "L on R", 64, "Right", "Freq", "Regul", 187.96, "Imperial", 23);
                yield return new survey("Male", 19.5, 20.2, "Right", "R on L", 60, "Neither", "Freq", "Never", 185.42, "Imperial", 32.667);
                yield return new survey("Female", 18, 18, "Right", "L on R", 92, "Neither", "Freq", "Never", 165, "Metric", 20);
                yield return new survey("Female", 18, 18.5, "Right", "R on L", 64, "Neither", "Freq", "Never", 164, "Metric", 20.167);
                yield return new survey("Male", 21.8, 22.3, "Right", "R on L", 76, "Left", "Freq", "Never", 195, "Metric", 25.5);
                yield return new survey("Female", 13, 12.5, "Right", "L on R", 80, "Right", "Freq", "Never", 165, "Metric", 18.167);
                yield return new survey("Female", 16.3, 16.2, "Right", "L on R", 92, "Right", "Some", "Regul", 152.4, "Imperial", 23.5);
                yield return new survey("Male", 21.5, 21.6, "Right", "R on L", 69, "Right", "Freq", "Never", 172.72, "Imperial", 70.417);
                yield return new survey("Male", 18.9, 19.1, "Right", "L on R", 68, "Right", "None", "Never", 180.34, "Imperial", 43.833);
                yield return new survey("Male", 20.5, 20, "Right", "R on L", 76, "Right", "Freq", "Never", 173, "Metric", 23.583);
                yield return new survey("Male", 14, 15.5, "Right", "L on R", null, "Neither", "Freq", "Heavy", null, null, 21.083);
                yield return new survey("Female", 18.9, 19.2, "Right", "L on R", 74, "Right", "Some", "Never", 167.64, "Imperial", 44.25);
                yield return new survey("Male", 20, 20.5, "Right", "R on L", null, "Right", "None", "Never", 187.96, "Imperial", 19.667);
                yield return new survey("Male", 18.5, 19, "Right", "L on R", 84, "Right", "Freq", "Regul", 187, "Metric", 17.917);
                yield return new survey("Female", 17.5, 17.1, "Right", "R on L", 80, "Left", "None", "Never", 167, "Metric", 18.417);
                yield return new survey("Male", 18.1, 18.2, "Left", "Neither", null, "Right", "Some", "Never", 168, "Metric", 21.167);
                yield return new survey("Male", 20.2, 20.3, "Right", "L on R", 72, "Neither", "Some", "Never", 191.8, "Imperial", 17.5);
                yield return new survey("Female", 16.5, 16.9, "Right", "R on L", 60, "Neither", "Freq", "Occas", 169.2, "Metric", 29.083);
                yield return new survey("Male", 19.1, 19.1, "Right", "Neither", null, "Right", "Some", "Never", 177, "Metric", 19.917);
                yield return new survey("Female", 17.6, 17.2, "Right", "R on L", 81, "Left", "Some", "Never", 168, "Metric", 18.5);
                yield return new survey("Female", 19.5, 19.2, "Right", "R on L", 70, "Right", "Some", "Never", 170, "Metric", 18.167);
                yield return new survey("Female", 16.5, 15, "Right", "L on R", 65, "Right", "Some", "Regul", 160.02, "Imperial", 32.75);
                yield return new survey("Male", 19, 18.5, "Right", "L on R", null, "Neither", "Freq", "Never", 189, "Metric", 17.417);
                yield return new survey("Male", 19, 18.5, "Right", "R on L", 72, "Right", "Freq", "Never", 180.34, "Imperial", 17.333);
                yield return new survey("Female", 16.5, 17, "Right", "L on R", null, "Right", "Some", "Never", 168, "Metric", 73);
                yield return new survey("Male", 20.5, 19.5, "Left", "L on R", 80, "Right", "Some", "Occas", 182.88, "Imperial", 18.667);
                yield return new survey("Female", 15.5, 15.5, "Right", "Neither", 50, "Right", "Some", "Regul", null, null, 18.5);
                yield return new survey("Female", 18, 17.5, "Right", "R on L", 48, "Neither", "Freq", "Never", 165, "Metric", 18.667);
                yield return new survey("Female", 17.5, 18, "Right", "R on L", 68, "Neither", "Freq", "Never", 157.48, "Imperial", 17.75);
                yield return new survey("Female", 19, 18.5, "Left", "L on R", 104, "Left", "Freq", "Never", 170, "Metric", 17.25);
                yield return new survey("Male", 20.5, 20.5, "Right", "Neither", 76, "Right", "Freq", "Regul", 172.72, "Imperial", 36.583);
                yield return new survey("Female", 16.7, 17, "Right", "L on R", 84, "Left", "Freq", "Never", 164, "Metric", 23.083);
                yield return new survey("Female", 20.5, 20.5, "Right", "R on L", null, "Left", "Freq", "Regul", null, null, 19.25);
                yield return new survey("Female", 17, 16.5, "Right", "R on L", 70, "Right", "Some", "Never", 162.56, "Imperial", 17.167);
                yield return new survey("Male", 19, 19.5, "Right", "R on L", 68, "Right", "Freq", "Occas", 172, "Metric", 23.417);
                yield return new survey("Female", 14, 13.5, "Right", "R on L", 87, "Neither", "Freq", "Occas", 165.1, "Imperial", 17.083);
                yield return new survey("Female", 17.5, 17.6, "Right", "L on R", 79, "Right", "Some", "Never", 162.5, "Metric", 17.25);
                yield return new survey("Male", 18.5, 19, "Right", "L on R", 70, "Left", "Freq", "Never", 170, "Metric", 23.833);
                yield return new survey("Male", 18, 18.5, "Right", "Neither", 90, "Right", "Some", "Never", 175, "Metric", 18.75);
                yield return new survey("Male", 20.5, 20.7, "Right", "R on L", 72, "Right", "Some", "Never", 168, "Metric", 21.167);
                yield return new survey("Female", 17, 17, "Right", "L on R", 79, "Right", "Some", "Never", 163, "Metric", 24.667);
                yield return new survey("Male", 18.5, 18.5, "Right", "R on L", 65, "Right", "None", "Never", 165, "Metric", 18.5);
                yield return new survey("Male", 18, 18.5, "Right", "R on L", 62, "Right", "Freq", "Never", 173, "Metric", 20.333);
                yield return new survey("Male", 18.5, 18, "Right", "Neither", 63, "Neither", "Freq", "Never", 196, "Metric", 20.083);
                yield return new survey("Male", 20, 19.5, "Right", "R on L", 92, "Right", "Some", "Never", 179.1, "Imperial", 18.917);
                yield return new survey("Male", 22, 22.5, "Right", "L on R", 60, "Right", "Some", "Never", 180, "Metric", 27.333);
                yield return new survey("Male", 17.9, 18.4, "Right", "R on L", 68, "Left", "None", "Occas", 176, "Metric", 18.917);
                yield return new survey("Female", 17.6, 17.8, "Right", "L on R", 72, "Left", "Some", "Never", 160.02, "Imperial", 17.25);
                yield return new survey("Female", 16.7, 15.1, "Right", "Neither", null, "Right", "None", "Never", 157.48, "Imperial", 18.167);
                yield return new survey("Female", 17, 17.6, "Right", "L on R", 76, "Right", "Some", "Never", 165, "Metric", 26.5);
                yield return new survey("Female", 15, 13, "Right", "R on L", 80, "Neither", "Freq", "Never", 170.18, "Imperial", 17);
                yield return new survey("Male", 16, 15.5, "Right", "Neither", 71, "Right", "Freq", "Never", 154.94, "Imperial", 17.167);
                yield return new survey("Female", 19.1, 19, "Right", "R on L", 80, "Right", "Some", "Occas", 170, "Metric", 19.167);
                yield return new survey("Female", 17.5, 16.5, "Right", "R on L", 80, "Neither", "Some", "Never", 164, "Metric", 17.5);
                yield return new survey("Female", 16.2, 15.8, "Right", "R on L", 61, "Right", "Some", "Occas", 167, "Metric", 19.25);
                yield return new survey("Male", 21, 21, "Right", "L on R", 48, "Neither", "Freq", "Never", 174, "Metric", 21.333);
                yield return new survey("Female", 18.8, 17.8, "Right", "R on L", 76, "Right", "Some", "Never", null, null, 18.583);
                yield return new survey("Female", 18.5, 18, "Right", "Neither", 86, "Right", "None", "Never", 160, "Metric", 20.167);
                yield return new survey("Male", 17, 17.5, "Right", "R on L", 80, "Right", "Some", "Regul", 179.1, "Metric", 18.667);
                yield return new survey("Female", 17.5, 17, "Right", "R on L", 83, "Neither", "Freq", "Occas", 168, "Metric", 17.083);
                yield return new survey("Female", 17.5, 17.6, "Right", "L on R", 76, "Right", "Some", "Never", 153.5, "Metric", 17.417);
                yield return new survey("Male", 17.5, 17.6, "Right", "R on L", 84, "Right", "Some", "Never", 160, "Metric", 18.583);
                yield return new survey("Male", 17.5, 17, "Left", "L on R", 97, "Neither", "None", "Never", 165, "Metric", 19.5);
                yield return new survey("Female", 20.8, 20.7, "Right", "R on L", null, "Neither", "Freq", "Never", 171.5, "Metric", 18.5);
                yield return new survey("Female", 18.6, 18.6, "Right", "L on R", 74, "Right", "Some", "Never", 160, "Metric", 17.167);
                yield return new survey("Female", 17.5, 17.5, "Left", "R on L", 83, "Neither", "Some", "Never", 163, "Metric", 17.25);
                yield return new survey("Male", 18, 18.5, "Right", "R on L", 78, "Right", "Freq", "Never", null, null, 17.5);
                yield return new survey("Male", 17, 17.5, "Right", "R on L", 65, "Right", "Some", "Never", 165, "Metric", 20.417);
                yield return new survey("Female", 18, 17.8, "Right", "L on R", 68, "Right", "Some", "Never", 168.9, "Imperial", 17.083);
                yield return new survey("Male", 19.5, 20, "Right", "Neither", null, "Right", "Some", "Never", 170, "Metric", 21.25);
                yield return new survey("Female", 16.3, 16.2, "Right", "L on R", null, "Right", "None", "Never", null, null, 19.25);
                yield return new survey("Male", 18.2, 19.8, "Right", "R on L", 88, "Right", "Freq", "Never", 185, "Metric", 19.333);
                yield return new survey("Female", 17, 17.3, "Right", "L on R", null, "Neither", "Freq", "Never", 173, "Metric", 19.167);
                yield return new survey("Male", 23.2, 23.2, "Right", "L on R", 75, "Right", "Freq", "Never", 188, "Metric", 18.917);
                yield return new survey("Male", 23.2, 23.3, "Right", "L on R", null, "Right", "None", "Heavy", 171, "Metric", 20.917);
                yield return new survey("Female", 15.9, 16.5, "Right", "R on L", 70, "Right", "Freq", "Never", 167.64, "Imperial", 17.333);
                yield return new survey("Female", 17.5, 18.4, "Right", "R on L", 88, "Right", "Some", "Never", 162.56, "Imperial", 18.167);
                yield return new survey("Female", 17.5, 17.6, "Right", "L on R", null, "Right", "Freq", "Never", 150, "Metric", 20.75);
                yield return new survey("Female", 17.6, 17.2, "Right", "L on R", null, "Right", "Some", "Never", null, null, 19.917);
                yield return new survey("Female", 17.5, 17.8, "Right", "R on L", 96, "Right", "Some", "Never", null, null, 18.667);
                yield return new survey("Female", 18.8, 18.3, "Right", "R on L", 80, "Right", "Some", "Heavy", 170.18, "Imperial", 18.417);
                yield return new survey("Male", 20, 19.8, "Right", "L on R", 68, "Right", "Freq", "Never", 185, "Metric", 17.417);
                yield return new survey("Female", 18.6, 18.8, "Right", "L on R", 70, "Right", "Freq", "Regul", 167, "Metric", 20.333);
                yield return new survey("Male", 18.6, 19.6, "Right", "L on R", 71, "Right", "Freq", "Occas", 185, "Metric", 19.333);
                yield return new survey("Female", 18.8, 18.5, "Right", "R on L", 80, "Right", "Some", "Never", 169, "Metric", 18.167);
                yield return new survey("Male", 18, 16, "Right", "R on L", null, "Right", "Some", "Never", 180.34, "Imperial", 20.75);
                yield return new survey("Female", 18, 18, "Right", "L on R", 85, "Right", "Some", "Never", 165.1, "Imperial", 17.667);
                yield return new survey("Female", 18.5, 18, "Right", "L on R", 88, "Right", "Some", "Never", 160, "Metric", 16.917);
                yield return new survey("Female", 17.5, 16.5, "Right", "R on L", null, "Right", "Some", "Never", 170, "Metric", 18.583);
                yield return new survey("Male", 21, 21.5, "Right", "R on L", 90, "Right", "Some", "Never", 183, "Metric", 17.167);
                yield return new survey("Female", 17.6, 17.3, "Right", "R on L", 85, "Right", "Freq", "Never", 168.5, "Metric", 17.75);
            }
        }
    }
}
