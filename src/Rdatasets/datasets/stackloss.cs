// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Brownlee's Stack Loss Plant Data
    /// </summary>

    public class stackloss
    {
        public readonly int Air_Flow;
        public readonly int Water_Temp;
        public readonly int Acid_Conc_;
        public readonly int stack_loss;

        public stackloss(int Air_Flow, int Water_Temp, int Acid_Conc_, int stack_loss)
        {
            this.Air_Flow = Air_Flow;
            this.Water_Temp = Water_Temp;
            this.Acid_Conc_ = Acid_Conc_;
            this.stack_loss = stack_loss;
        }

        public static IEnumerable<stackloss> Data
        {
            get
            {
                yield return new stackloss(80, 27, 89, 42);
                yield return new stackloss(80, 27, 88, 37);
                yield return new stackloss(75, 25, 90, 37);
                yield return new stackloss(62, 24, 87, 28);
                yield return new stackloss(62, 22, 87, 18);
                yield return new stackloss(62, 23, 87, 18);
                yield return new stackloss(62, 24, 93, 19);
                yield return new stackloss(62, 24, 93, 20);
                yield return new stackloss(58, 23, 87, 15);
                yield return new stackloss(58, 18, 80, 14);
                yield return new stackloss(58, 18, 89, 14);
                yield return new stackloss(58, 17, 88, 13);
                yield return new stackloss(58, 18, 82, 11);
                yield return new stackloss(58, 19, 93, 12);
                yield return new stackloss(50, 18, 89, 8);
                yield return new stackloss(50, 18, 86, 7);
                yield return new stackloss(50, 19, 72, 8);
                yield return new stackloss(50, 19, 79, 8);
                yield return new stackloss(50, 20, 80, 9);
                yield return new stackloss(56, 20, 82, 15);
                yield return new stackloss(70, 20, 91, 15);
            }
        }
    }
}
