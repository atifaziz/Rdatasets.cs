// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Intercountry Life-Cycle Savings Data
    /// </summary>

    public class LifeCycleSavings
    {
        public readonly string κ;
        public readonly double sr;
        public readonly double pop15;
        public readonly double pop75;
        public readonly double dpi;
        public readonly double ddpi;

        public LifeCycleSavings(string κ, double sr, double pop15, double pop75, double dpi, double ddpi)
        {
            this.κ = κ;
            this.sr = sr;
            this.pop15 = pop15;
            this.pop75 = pop75;
            this.dpi = dpi;
            this.ddpi = ddpi;
        }

        public static IEnumerable<LifeCycleSavings> Data
        {
            get
            {
                yield return new LifeCycleSavings("Australia", 11.43, 29.35, 2.87, 2329.68, 2.87);
                yield return new LifeCycleSavings("Austria", 12.07, 23.32, 4.41, 1507.99, 3.93);
                yield return new LifeCycleSavings("Belgium", 13.17, 23.8, 4.43, 2108.47, 3.82);
                yield return new LifeCycleSavings("Bolivia", 5.75, 41.89, 1.67, 189.13, 0.22);
                yield return new LifeCycleSavings("Brazil", 12.88, 42.19, 0.83, 728.47, 4.56);
                yield return new LifeCycleSavings("Canada", 8.79, 31.72, 2.85, 2982.88, 2.43);
                yield return new LifeCycleSavings("Chile", 0.6, 39.74, 1.34, 662.86, 2.67);
                yield return new LifeCycleSavings("China", 11.9, 44.75, 0.67, 289.52, 6.51);
                yield return new LifeCycleSavings("Colombia", 4.98, 46.64, 1.06, 276.65, 3.08);
                yield return new LifeCycleSavings("Costa Rica", 10.78, 47.64, 1.14, 471.24, 2.8);
                yield return new LifeCycleSavings("Denmark", 16.85, 24.42, 3.93, 2496.53, 3.99);
                yield return new LifeCycleSavings("Ecuador", 3.59, 46.31, 1.19, 287.77, 2.19);
                yield return new LifeCycleSavings("Finland", 11.24, 27.84, 2.37, 1681.25, 4.32);
                yield return new LifeCycleSavings("France", 12.64, 25.06, 4.7, 2213.82, 4.52);
                yield return new LifeCycleSavings("Germany", 12.55, 23.31, 3.35, 2457.12, 3.44);
                yield return new LifeCycleSavings("Greece", 10.67, 25.62, 3.1, 870.85, 6.28);
                yield return new LifeCycleSavings("Guatamala", 3.01, 46.05, 0.87, 289.71, 1.48);
                yield return new LifeCycleSavings("Honduras", 7.7, 47.32, 0.58, 232.44, 3.19);
                yield return new LifeCycleSavings("Iceland", 1.27, 34.03, 3.08, 1900.1, 1.12);
                yield return new LifeCycleSavings("India", 9, 41.31, 0.96, 88.94, 1.54);
                yield return new LifeCycleSavings("Ireland", 11.34, 31.16, 4.19, 1139.95, 2.99);
                yield return new LifeCycleSavings("Italy", 14.28, 24.52, 3.48, 1390, 3.54);
                yield return new LifeCycleSavings("Japan", 21.1, 27.01, 1.91, 1257.28, 8.21);
                yield return new LifeCycleSavings("Korea", 3.98, 41.74, 0.91, 207.68, 5.81);
                yield return new LifeCycleSavings("Luxembourg", 10.35, 21.8, 3.73, 2449.39, 1.57);
                yield return new LifeCycleSavings("Malta", 15.48, 32.54, 2.47, 601.05, 8.12);
                yield return new LifeCycleSavings("Norway", 10.25, 25.95, 3.67, 2231.03, 3.62);
                yield return new LifeCycleSavings("Netherlands", 14.65, 24.71, 3.25, 1740.7, 7.66);
                yield return new LifeCycleSavings("New Zealand", 10.67, 32.61, 3.17, 1487.52, 1.76);
                yield return new LifeCycleSavings("Nicaragua", 7.3, 45.04, 1.21, 325.54, 2.48);
                yield return new LifeCycleSavings("Panama", 4.44, 43.56, 1.2, 568.56, 3.61);
                yield return new LifeCycleSavings("Paraguay", 2.02, 41.18, 1.05, 220.56, 1.03);
                yield return new LifeCycleSavings("Peru", 12.7, 44.19, 1.28, 400.06, 0.67);
                yield return new LifeCycleSavings("Philippines", 12.78, 46.26, 1.12, 152.01, 2);
                yield return new LifeCycleSavings("Portugal", 12.49, 28.96, 2.85, 579.51, 7.48);
                yield return new LifeCycleSavings("South Africa", 11.14, 31.94, 2.28, 651.11, 2.19);
                yield return new LifeCycleSavings("South Rhodesia", 13.3, 31.92, 1.52, 250.96, 2);
                yield return new LifeCycleSavings("Spain", 11.77, 27.74, 2.87, 768.79, 4.35);
                yield return new LifeCycleSavings("Sweden", 6.86, 21.44, 4.54, 3299.49, 3.01);
                yield return new LifeCycleSavings("Switzerland", 14.13, 23.49, 3.73, 2630.96, 2.7);
                yield return new LifeCycleSavings("Turkey", 5.13, 43.42, 1.08, 389.66, 2.96);
                yield return new LifeCycleSavings("Tunisia", 2.81, 46.12, 1.21, 249.87, 1.13);
                yield return new LifeCycleSavings("United Kingdom", 7.81, 23.27, 4.46, 1813.93, 2.01);
                yield return new LifeCycleSavings("United States", 7.56, 29.81, 3.43, 4001.89, 2.45);
                yield return new LifeCycleSavings("Venezuela", 9.22, 46.4, 0.9, 813.39, 0.53);
                yield return new LifeCycleSavings("Zambia", 18.56, 45.25, 0.56, 138.33, 5.14);
                yield return new LifeCycleSavings("Jamaica", 7.72, 41.12, 1.73, 380.47, 10.23);
                yield return new LifeCycleSavings("Uruguay", 9.24, 28.13, 2.72, 766.54, 1.88);
                yield return new LifeCycleSavings("Libya", 8.89, 43.69, 2.07, 123.58, 16.71);
                yield return new LifeCycleSavings("Malaysia", 4.71, 47.2, 0.66, 242.69, 5.08);
            }
        }
    }
}
