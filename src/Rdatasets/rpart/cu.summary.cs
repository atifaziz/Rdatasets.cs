// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Automobile Data from 'Consumer Reports' 1990
    /// </summary>

    public class cu_summary
    {
        public readonly string κ;
        public readonly int Price;
        public readonly string Country;
        public readonly string Reliability;
        public readonly int? Mileage;
        public readonly string Type;

        public cu_summary(string κ, int Price, string Country, string Reliability, int? Mileage, string Type)
        {
            this.κ = κ;
            this.Price = Price;
            this.Country = Country;
            this.Reliability = Reliability;
            this.Mileage = Mileage;
            this.Type = Type;
        }

        public static IEnumerable<cu_summary> Data
        {
            get
            {
                yield return new cu_summary("Acura Integra 4", 11950, "Japan", "Much better", null, "Small");
                yield return new cu_summary("Dodge Colt 4", 6851, "Japan", null, null, "Small");
                yield return new cu_summary("Dodge Omni 4", 6995, "USA", "Much worse", null, "Small");
                yield return new cu_summary("Eagle Summit 4", 8895, "USA", "better", 33, "Small");
                yield return new cu_summary("Ford Escort   4", 7402, "USA", "worse", 33, "Small");
                yield return new cu_summary("Ford Festiva 4", 6319, "Korea", "better", 37, "Small");
                yield return new cu_summary("GEO Metro  3", 6695, "Japan", null, null, "Small");
                yield return new cu_summary("GEO Prizm  4", 10125, "Japan/USA", "Much better", null, "Small");
                yield return new cu_summary("Honda Civic 4", 6635, "Japan/USA", "Much better", 32, "Small");
                yield return new cu_summary("Hyundai Excel 4", 5899, "Korea", "worse", null, "Small");
                yield return new cu_summary("Mazda Protege 4", 6599, "Japan", "Much better", 32, "Small");
                yield return new cu_summary("Mercury Tracer 4", 8672, "Mexico", "better", 26, "Small");
                yield return new cu_summary("Mitsubishi Precis 4", 5899, "Korea", "worse", null, "Small");
                yield return new cu_summary("Nissan Sentra 4", 7399, "Japan/USA", "Much better", 33, "Small");
                yield return new cu_summary("Pontiac LeMans 4", 7254, "Korea", "Much worse", 28, "Small");
                yield return new cu_summary("Subaru Loyale 4", 9599, "Japan", "Much better", 25, "Small");
                yield return new cu_summary("Subaru Justy 3", 5866, "Japan", null, 34, "Small");
                yield return new cu_summary("Toyota Corolla 4", 8748, "Japan/USA", "Much better", 29, "Small");
                yield return new cu_summary("Toyota Tercel 4", 6488, "Japan", "Much better", 35, "Small");
                yield return new cu_summary("Volkswagen Fox 4", 7225, "Brazil", null, null, "Small");
                yield return new cu_summary("Volkswagen Golf 4", 8695, "Mexico", "average", null, "Small");
                yield return new cu_summary("Volkswagen Jetta 4", 9995, "Germany", "average", 26, "Small");
                yield return new cu_summary("Chevrolet Camaro V6", 10995, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary("Chevrolet Camaro V8", 11545, "USA", "Much worse", 20, "Sporty");
                yield return new cu_summary("Chevrolet Corvette V8", 31979, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary("Dodge Daytona", 9745, "USA", "Much worse", 27, "Sporty");
                yield return new cu_summary("Dodge Daytona Turbo 4", 12895, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary("Eagle Talon 4", 12995, "USA", null, null, "Sporty");
                yield return new cu_summary("Ford Mustang 4", 9456, "USA", "Much worse", null, "Sporty");
                yield return new cu_summary("Ford Mustang V8", 12164, "USA", "Much worse", 19, "Sporty");
                yield return new cu_summary("Ford Probe", 11470, "USA", "average", 30, "Sporty");
                yield return new cu_summary("Ford Probe GT 4", 14726, "USA", "average", null, "Sporty");
                yield return new cu_summary("GEO Storm 4", 10390, "Japan", null, null, "Sporty");
                yield return new cu_summary("Honda Civic CRX Si 4", 9410, "Japan", "Much better", 33, "Sporty");
                yield return new cu_summary("Honda Prelude Si 4WS 4", 13945, "Japan", "Much better", 27, "Sporty");
                yield return new cu_summary("Mazda MX-5 Miata", 13800, "Japan", null, null, "Sporty");
                yield return new cu_summary("Mazda MX-6 4", 12279, "Japan/USA", "Much better", null, "Sporty");
                yield return new cu_summary("Mazda RX-7", 17880, "Japan", "Much better", null, "Sporty");
                yield return new cu_summary("Nissan 240SX 4", 13249, "Japan", "average", 24, "Sporty");
                yield return new cu_summary("Nissan 300ZX V6", 27900, "Japan", null, null, "Sporty");
                yield return new cu_summary("Nissan Pulsar NX XE 4", 12249, "Japan", "average", null, "Sporty");
                yield return new cu_summary("Plymouth Laser", 10855, "USA", null, 26, "Sporty");
                yield return new cu_summary("Porsche 944", 41990, "Germany", null, null, "Sporty");
                yield return new cu_summary("Subaru XT 4", 13071, "Japan", null, 28, "Sporty");
                yield return new cu_summary("Toyota Celica GT-S 4", 12268, "Japan", null, null, "Sporty");
                yield return new cu_summary("Toyota Supra 6", 22860, "Japan", "better", null, "Sporty");
                yield return new cu_summary("Volkswagen Corrado 4", 17900, "Germany", null, null, "Sporty");
                yield return new cu_summary("Volkswagen GTI 4", 9995, "Mexico", null, null, "Sporty");
                yield return new cu_summary("Audi 80 4", 18900, "Germany", null, 27, "Compact");
                yield return new cu_summary("Audi 90 5", 23990, "Germany", null, null, "Compact");
                yield return new cu_summary("BMW 325i 6", 24650, "Germany", "better", null, "Compact");
                yield return new cu_summary("Buick Skylark 4", 10565, "USA", "worse", 23, "Compact");
                yield return new cu_summary("Chevrolet Beretta 4", 10320, "USA", "Much worse", 26, "Compact");
                yield return new cu_summary("Chevrolet Cavalier 4", 8620, "USA", "Much worse", null, "Compact");
                yield return new cu_summary("Chrysler Le Baron V6", 10945, "USA", "better", 25, "Compact");
                yield return new cu_summary("Dodge Shadow Turbo 4", 8845, "USA", "average", null, "Compact");
                yield return new cu_summary("Ford Tempo 4", 9483, "USA", "worse", 24, "Compact");
                yield return new cu_summary("Honda Accord 4", 12145, "Japan/USA", "Much better", 26, "Compact");
                yield return new cu_summary("Mazda 626 4", 12459, "Japan/USA", "better", 24, "Compact");
                yield return new cu_summary("Mercedes-Benz 190E 6", 31600, "Germany", "average", null, "Compact");
                yield return new cu_summary("Mitsubishi Galant 4", 10989, "Japan", "Much better", 25, "Compact");
                yield return new cu_summary("Mitsubishi Sigma V6", 17879, "Japan", "better", 21, "Compact");
                yield return new cu_summary("Nissan Stanza 4", 11650, "Japan", "Much better", 21, "Compact");
                yield return new cu_summary("Oldsmobile Calais 4", 9995, "USA", "worse", 23, "Compact");
                yield return new cu_summary("Peugeot 405 4", 15930, "France", null, 24, "Compact");
                yield return new cu_summary("Saab 900 4", 16995, "Sweden", "worse", null, "Compact");
                yield return new cu_summary("Saab 900 Turbo 4", 26945, "Sweden", "worse", null, "Compact");
                yield return new cu_summary("Subaru Legacy 4", 11499, "Japan/USA", "Much better", 23, "Compact");
                yield return new cu_summary("Toyota Camry 4", 11588, "Japan/USA", "Much better", 27, "Compact");
                yield return new cu_summary("Volvo 240 4", 18450, "Sweden", "average", 23, "Compact");
                yield return new cu_summary("Acura Legend V6", 24760, "Japan", "Much better", 20, "Medium");
                yield return new cu_summary("Audi 100 5", 26900, "Germany", null, null, "Medium");
                yield return new cu_summary("BMW 535i 6", 33200, "Germany", null, null, "Medium");
                yield return new cu_summary("Buick Century 4", 13150, "USA", "average", 21, "Medium");
                yield return new cu_summary("Buick Riviera V6", 23040, "USA", "average", null, "Medium");
                yield return new cu_summary("Cadillac Eldorado V8", 28855, "USA", "average", null, "Medium");
                yield return new cu_summary("Chevrolet Lumina 4", 12140, "USA", null, null, "Medium");
                yield return new cu_summary("Chrysler Imperial V6", 25495, "USA", "average", null, "Medium");
                yield return new cu_summary("Chrysler Le Baron Coupe", 12495, "USA", "worse", 22, "Medium");
                yield return new cu_summary("Chrysler New Yorker V6", 16342, "USA", "average", 22, "Medium");
                yield return new cu_summary("Dodge Dynasty 4", 12995, "USA", "average", null, "Medium");
                yield return new cu_summary("Eagle Premier V6", 15350, "USA", "worse", 22, "Medium");
                yield return new cu_summary("Ford Taurus 4", 12640, "USA", "Much worse", null, "Medium");
                yield return new cu_summary("Ford Taurus V6", 13195, "USA", "average", 22, "Medium");
                yield return new cu_summary("Ford Thunderbird V6", 14980, "USA", "Much worse", 23, "Medium");
                yield return new cu_summary("Hyundai Sonata 4", 9999, "Korea", null, 23, "Medium");
                yield return new cu_summary("Infiniti Q45 V8", 38000, "Japan", null, null, "Medium");
                yield return new cu_summary("Lexus LS 400 V8", 35000, "Japan", null, null, "Medium");
                yield return new cu_summary("Lincoln Continental V6", 29422, "USA", "worse", null, "Medium");
                yield return new cu_summary("Lincoln Mark VII V8", 29246, "USA", "Much worse", null, "Medium");
                yield return new cu_summary("Mazda 929 V6", 23300, "Japan", "Much better", 21, "Medium");
                yield return new cu_summary("Mercedes-Benz 300E 6", 39950, "Germany", "Much worse", null, "Medium");
                yield return new cu_summary("Nissan Maxima V6", 17899, "Japan", "Much better", 22, "Medium");
                yield return new cu_summary("Oldsmobile Cutlass Ciera 4", 13150, "USA", "worse", 21, "Medium");
                yield return new cu_summary("Oldsmobile Cutlass Supreme V6", 14495, "USA", null, 21, "Medium");
                yield return new cu_summary("Peugeot 505 4", 19945, "France", null, null, "Medium");
                yield return new cu_summary("Saab 9000S 4", 25995, "Sweden", null, null, "Medium");
                yield return new cu_summary("Sterling 827 V6", 23550, "England", null, null, "Medium");
                yield return new cu_summary("Toyota Cressida 6", 21498, "Japan", "average", 23, "Medium");
                yield return new cu_summary("Volvo 740 GL 4", 21700, "Sweden", "average", null, "Medium");
                yield return new cu_summary("Buick Electra V6", 20225, "USA", "average", null, "Large");
                yield return new cu_summary("Buick Le Sabre V6", 16145, "USA", "average", 23, "Large");
                yield return new cu_summary("Cadillac Brougham V8", 27400, "USA", "Much worse", null, "Large");
                yield return new cu_summary("Cadillac De Ville V8", 26960, "USA", "average", null, "Large");
                yield return new cu_summary("Chevrolet Caprice V8", 14525, "USA", "Much worse", 18, "Large");
                yield return new cu_summary("Ford LTD Crown Victoria V8", 17257, "USA", "average", 20, "Large");
                yield return new cu_summary("Lincoln Town Car V8", 27986, "USA", "average", null, "Large");
                yield return new cu_summary("Chevrolet Astro V6", 13790, "USA", "Much worse", null, "Van");
                yield return new cu_summary("Chevrolet Lumina APV V6", 13995, "USA", null, 18, "Van");
                yield return new cu_summary("Dodge Caravan 4", 11995, "USA", "average", null, "Van");
                yield return new cu_summary("Dodge Grand Caravan V6", 15395, "USA", "average", 18, "Van");
                yield return new cu_summary("Ford Aerostar V6", 12267, "USA", "average", 18, "Van");
                yield return new cu_summary("Mazda MPV V6", 14944, "Japan", "Much better", 19, "Van");
                yield return new cu_summary("Mitsubishi Wagon 4", 14929, "Japan", null, 20, "Van");
                yield return new cu_summary("Nissan Axxess 4", 13949, "Japan", null, 20, "Van");
                yield return new cu_summary("Nissan Van 4", 14799, "Japan", null, 19, "Van");
                yield return new cu_summary("Volkswagen Vanagon 4", 14080, "Germany", null, null, "Van");
            }
        }
    }
}
