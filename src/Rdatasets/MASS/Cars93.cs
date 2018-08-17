// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from 93 Cars on Sale in the USA in 1993
    /// </summary>

    public class Cars93
    {
        public readonly string Manufacturer;
        public readonly string Model;
        public readonly string Type;
        public readonly double Min_Price;
        public readonly double Price;
        public readonly double Max_Price;
        public readonly int MPG_city;
        public readonly int MPG_highway;
        public readonly string AirBags;
        public readonly string DriveTrain;
        public readonly string Cylinders;
        public readonly double EngineSize;
        public readonly int Horsepower;
        public readonly int RPM;
        public readonly int Rev_per_mile;
        public readonly string Man_trans_avail;
        public readonly double Fuel_tank_capacity;
        public readonly int Passengers;
        public readonly int Length;
        public readonly int Wheelbase;
        public readonly int Width;
        public readonly int Turn_circle;
        public readonly string Rear_seat_room;
        public readonly string Luggage_room;
        public readonly int Weight;
        public readonly string Origin;
        public readonly string Make;

        public Cars93(string Manufacturer, string Model, string Type, double Min_Price, double Price, double Max_Price, int MPG_city, int MPG_highway, string AirBags, string DriveTrain, string Cylinders, double EngineSize, int Horsepower, int RPM, int Rev_per_mile, string Man_trans_avail, double Fuel_tank_capacity, int Passengers, int Length, int Wheelbase, int Width, int Turn_circle, string Rear_seat_room, string Luggage_room, int Weight, string Origin, string Make)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Type = Type;
            this.Min_Price = Min_Price;
            this.Price = Price;
            this.Max_Price = Max_Price;
            this.MPG_city = MPG_city;
            this.MPG_highway = MPG_highway;
            this.AirBags = AirBags;
            this.DriveTrain = DriveTrain;
            this.Cylinders = Cylinders;
            this.EngineSize = EngineSize;
            this.Horsepower = Horsepower;
            this.RPM = RPM;
            this.Rev_per_mile = Rev_per_mile;
            this.Man_trans_avail = Man_trans_avail;
            this.Fuel_tank_capacity = Fuel_tank_capacity;
            this.Passengers = Passengers;
            this.Length = Length;
            this.Wheelbase = Wheelbase;
            this.Width = Width;
            this.Turn_circle = Turn_circle;
            this.Rear_seat_room = Rear_seat_room;
            this.Luggage_room = Luggage_room;
            this.Weight = Weight;
            this.Origin = Origin;
            this.Make = Make;
        }

        public static IEnumerable<Cars93> Data
        {
            get
            {
                yield return new Cars93("Acura", "Integra", "Small", 12.9, 15.9, 18.8, 25, 31, "None", "Front", "4", 1.8, 140, 6300, 2890, "Yes", 13.2, 5, 177, 102, 68, 37, "26.5", "11", 2705, "non-USA", "Acura Integra");
                yield return new Cars93("Acura", "Legend", "Midsize", 29.2, 33.9, 38.7, 18, 25, "Driver & Passenger", "Front", "6", 3.2, 200, 5500, 2335, "Yes", 18, 5, 195, 115, 71, 38, "30", "15", 3560, "non-USA", "Acura Legend");
                yield return new Cars93("Audi", "90", "Compact", 25.9, 29.1, 32.3, 20, 26, "Driver only", "Front", "6", 2.8, 172, 5500, 2280, "Yes", 16.9, 5, 180, 102, 67, 37, "28", "14", 3375, "non-USA", "Audi 90");
                yield return new Cars93("Audi", "100", "Midsize", 30.8, 37.7, 44.6, 19, 26, "Driver & Passenger", "Front", "6", 2.8, 172, 5500, 2535, "Yes", 21.1, 6, 193, 106, 70, 37, "31", "17", 3405, "non-USA", "Audi 100");
                yield return new Cars93("BMW", "535i", "Midsize", 23.7, 30, 36.2, 22, 30, "Driver only", "Rear", "4", 3.5, 208, 5700, 2545, "Yes", 21.1, 4, 186, 109, 69, 39, "27", "13", 3640, "non-USA", "BMW 535i");
                yield return new Cars93("Buick", "Century", "Midsize", 14.2, 15.7, 17.3, 22, 31, "Driver only", "Front", "4", 2.2, 110, 5200, 2565, "No", 16.4, 6, 189, 105, 69, 41, "28", "16", 2880, "USA", "Buick Century");
                yield return new Cars93("Buick", "LeSabre", "Large", 19.9, 20.8, 21.7, 19, 28, "Driver only", "Front", "6", 3.8, 170, 4800, 1570, "No", 18, 6, 200, 111, 74, 42, "30.5", "17", 3470, "USA", "Buick LeSabre");
                yield return new Cars93("Buick", "Roadmaster", "Large", 22.6, 23.7, 24.9, 16, 25, "Driver only", "Rear", "6", 5.7, 180, 4000, 1320, "No", 23, 6, 216, 116, 78, 45, "30.5", "21", 4105, "USA", "Buick Roadmaster");
                yield return new Cars93("Buick", "Riviera", "Midsize", 26.3, 26.3, 26.3, 19, 27, "Driver only", "Front", "6", 3.8, 170, 4800, 1690, "No", 18.8, 5, 198, 108, 73, 41, "26.5", "14", 3495, "USA", "Buick Riviera");
                yield return new Cars93("Cadillac", "DeVille", "Large", 33, 34.7, 36.3, 16, 25, "Driver only", "Front", "8", 4.9, 200, 4100, 1510, "No", 18, 6, 206, 114, 73, 43, "35", "18", 3620, "USA", "Cadillac DeVille");
                yield return new Cars93("Cadillac", "Seville", "Midsize", 37.5, 40.1, 42.7, 16, 25, "Driver & Passenger", "Front", "8", 4.6, 295, 6000, 1985, "No", 20, 5, 204, 111, 74, 44, "31", "14", 3935, "USA", "Cadillac Seville");
                yield return new Cars93("Chevrolet", "Cavalier", "Compact", 8.5, 13.4, 18.3, 25, 36, "None", "Front", "4", 2.2, 110, 5200, 2380, "Yes", 15.2, 5, 182, 101, 66, 38, "25", "13", 2490, "USA", "Chevrolet Cavalier");
                yield return new Cars93("Chevrolet", "Corsica", "Compact", 11.4, 11.4, 11.4, 25, 34, "Driver only", "Front", "4", 2.2, 110, 5200, 2665, "Yes", 15.6, 5, 184, 103, 68, 39, "26", "14", 2785, "USA", "Chevrolet Corsica");
                yield return new Cars93("Chevrolet", "Camaro", "Sporty", 13.4, 15.1, 16.8, 19, 28, "Driver & Passenger", "Rear", "6", 3.4, 160, 4600, 1805, "Yes", 15.5, 4, 193, 101, 74, 43, "25", "13", 3240, "USA", "Chevrolet Camaro");
                yield return new Cars93("Chevrolet", "Lumina", "Midsize", 13.4, 15.9, 18.4, 21, 29, "None", "Front", "4", 2.2, 110, 5200, 2595, "No", 16.5, 6, 198, 108, 71, 40, "28.5", "16", 3195, "USA", "Chevrolet Lumina");
                yield return new Cars93("Chevrolet", "Lumina_APV", "Van", 14.7, 16.3, 18, 18, 23, "None", "Front", "6", 3.8, 170, 4800, 1690, "No", 20, 7, 178, 110, 74, 44, "30.5", null, 3715, "USA", "Chevrolet Lumina_APV");
                yield return new Cars93("Chevrolet", "Astro", "Van", 14.7, 16.6, 18.6, 15, 20, "None", "4WD", "6", 4.3, 165, 4000, 1790, "No", 27, 8, 194, 111, 78, 42, "33.5", null, 4025, "USA", "Chevrolet Astro");
                yield return new Cars93("Chevrolet", "Caprice", "Large", 18, 18.8, 19.6, 17, 26, "Driver only", "Rear", "8", 5, 170, 4200, 1350, "No", 23, 6, 214, 116, 77, 42, "29.5", "20", 3910, "USA", "Chevrolet Caprice");
                yield return new Cars93("Chevrolet", "Corvette", "Sporty", 34.6, 38, 41.5, 17, 25, "Driver only", "Rear", "8", 5.7, 300, 5000, 1450, "Yes", 20, 2, 179, 96, 74, 43, null, null, 3380, "USA", "Chevrolet Corvette");
                yield return new Cars93("Chrylser", "Concorde", "Large", 18.4, 18.4, 18.4, 20, 28, "Driver & Passenger", "Front", "6", 3.3, 153, 5300, 1990, "No", 18, 6, 203, 113, 74, 40, "31", "15", 3515, "USA", "Chrylser Concorde");
                yield return new Cars93("Chrysler", "LeBaron", "Compact", 14.5, 15.8, 17.1, 23, 28, "Driver & Passenger", "Front", "4", 3, 141, 5000, 2090, "No", 16, 6, 183, 104, 68, 41, "30.5", "14", 3085, "USA", "Chrysler LeBaron");
                yield return new Cars93("Chrysler", "Imperial", "Large", 29.5, 29.5, 29.5, 20, 26, "Driver only", "Front", "6", 3.3, 147, 4800, 1785, "No", 16, 6, 203, 110, 69, 44, "36", "17", 3570, "USA", "Chrysler Imperial");
                yield return new Cars93("Dodge", "Colt", "Small", 7.9, 9.2, 10.6, 29, 33, "None", "Front", "4", 1.5, 92, 6000, 3285, "Yes", 13.2, 5, 174, 98, 66, 32, "26.5", "11", 2270, "USA", "Dodge Colt");
                yield return new Cars93("Dodge", "Shadow", "Small", 8.4, 11.3, 14.2, 23, 29, "Driver only", "Front", "4", 2.2, 93, 4800, 2595, "Yes", 14, 5, 172, 97, 67, 38, "26.5", "13", 2670, "USA", "Dodge Shadow");
                yield return new Cars93("Dodge", "Spirit", "Compact", 11.9, 13.3, 14.7, 22, 27, "Driver only", "Front", "4", 2.5, 100, 4800, 2535, "Yes", 16, 6, 181, 104, 68, 39, "30.5", "14", 2970, "USA", "Dodge Spirit");
                yield return new Cars93("Dodge", "Caravan", "Van", 13.6, 19, 24.4, 17, 21, "Driver only", "4WD", "6", 3, 142, 5000, 1970, "No", 20, 7, 175, 112, 72, 42, "26.5", null, 3705, "USA", "Dodge Caravan");
                yield return new Cars93("Dodge", "Dynasty", "Midsize", 14.8, 15.6, 16.4, 21, 27, "Driver only", "Front", "4", 2.5, 100, 4800, 2465, "No", 16, 6, 192, 105, 69, 42, "30.5", "16", 3080, "USA", "Dodge Dynasty");
                yield return new Cars93("Dodge", "Stealth", "Sporty", 18.5, 25.8, 33.1, 18, 24, "Driver only", "4WD", "6", 3, 300, 6000, 2120, "Yes", 19.8, 4, 180, 97, 72, 40, "20", "11", 3805, "USA", "Dodge Stealth");
                yield return new Cars93("Eagle", "Summit", "Small", 7.9, 12.2, 16.5, 29, 33, "None", "Front", "4", 1.5, 92, 6000, 2505, "Yes", 13.2, 5, 174, 98, 66, 36, "26.5", "11", 2295, "USA", "Eagle Summit");
                yield return new Cars93("Eagle", "Vision", "Large", 17.5, 19.3, 21.2, 20, 28, "Driver & Passenger", "Front", "6", 3.5, 214, 5800, 1980, "No", 18, 6, 202, 113, 74, 40, "30", "15", 3490, "USA", "Eagle Vision");
                yield return new Cars93("Ford", "Festiva", "Small", 6.9, 7.4, 7.9, 31, 33, "None", "Front", "4", 1.3, 63, 5000, 3150, "Yes", 10, 4, 141, 90, 63, 33, "26", "12", 1845, "USA", "Ford Festiva");
                yield return new Cars93("Ford", "Escort", "Small", 8.4, 10.1, 11.9, 23, 30, "None", "Front", "4", 1.8, 127, 6500, 2410, "Yes", 13.2, 5, 171, 98, 67, 36, "28", "12", 2530, "USA", "Ford Escort");
                yield return new Cars93("Ford", "Tempo", "Compact", 10.4, 11.3, 12.2, 22, 27, "None", "Front", "4", 2.3, 96, 4200, 2805, "Yes", 15.9, 5, 177, 100, 68, 39, "27.5", "13", 2690, "USA", "Ford Tempo");
                yield return new Cars93("Ford", "Mustang", "Sporty", 10.8, 15.9, 21, 22, 29, "Driver only", "Rear", "4", 2.3, 105, 4600, 2285, "Yes", 15.4, 4, 180, 101, 68, 40, "24", "12", 2850, "USA", "Ford Mustang");
                yield return new Cars93("Ford", "Probe", "Sporty", 12.8, 14, 15.2, 24, 30, "Driver only", "Front", "4", 2, 115, 5500, 2340, "Yes", 15.5, 4, 179, 103, 70, 38, "23", "18", 2710, "USA", "Ford Probe");
                yield return new Cars93("Ford", "Aerostar", "Van", 14.5, 19.9, 25.3, 15, 20, "Driver only", "4WD", "6", 3, 145, 4800, 2080, "Yes", 21, 7, 176, 119, 72, 45, "30", null, 3735, "USA", "Ford Aerostar");
                yield return new Cars93("Ford", "Taurus", "Midsize", 15.6, 20.2, 24.8, 21, 30, "Driver only", "Front", "6", 3, 140, 4800, 1885, "No", 16, 5, 192, 106, 71, 40, "27.5", "18", 3325, "USA", "Ford Taurus");
                yield return new Cars93("Ford", "Crown_Victoria", "Large", 20.1, 20.9, 21.7, 18, 26, "Driver only", "Rear", "8", 4.6, 190, 4200, 1415, "No", 20, 6, 212, 114, 78, 43, "30", "21", 3950, "USA", "Ford Crown_Victoria");
                yield return new Cars93("Geo", "Metro", "Small", 6.7, 8.4, 10, 46, 50, "None", "Front", "3", 1, 55, 5700, 3755, "Yes", 10.6, 4, 151, 93, 63, 34, "27.5", "10", 1695, "non-USA", "Geo Metro");
                yield return new Cars93("Geo", "Storm", "Sporty", 11.5, 12.5, 13.5, 30, 36, "Driver only", "Front", "4", 1.6, 90, 5400, 3250, "Yes", 12.4, 4, 164, 97, 67, 37, "24.5", "11", 2475, "non-USA", "Geo Storm");
                yield return new Cars93("Honda", "Prelude", "Sporty", 17, 19.8, 22.7, 24, 31, "Driver & Passenger", "Front", "4", 2.3, 160, 5800, 2855, "Yes", 15.9, 4, 175, 100, 70, 39, "23.5", "8", 2865, "non-USA", "Honda Prelude");
                yield return new Cars93("Honda", "Civic", "Small", 8.4, 12.1, 15.8, 42, 46, "Driver only", "Front", "4", 1.5, 102, 5900, 2650, "Yes", 11.9, 4, 173, 103, 67, 36, "28", "12", 2350, "non-USA", "Honda Civic");
                yield return new Cars93("Honda", "Accord", "Compact", 13.8, 17.5, 21.2, 24, 31, "Driver & Passenger", "Front", "4", 2.2, 140, 5600, 2610, "Yes", 17, 4, 185, 107, 67, 41, "28", "14", 3040, "non-USA", "Honda Accord");
                yield return new Cars93("Hyundai", "Excel", "Small", 6.8, 8, 9.2, 29, 33, "None", "Front", "4", 1.5, 81, 5500, 2710, "Yes", 11.9, 5, 168, 94, 63, 35, "26", "11", 2345, "non-USA", "Hyundai Excel");
                yield return new Cars93("Hyundai", "Elantra", "Small", 9, 10, 11, 22, 29, "None", "Front", "4", 1.8, 124, 6000, 2745, "Yes", 13.7, 5, 172, 98, 66, 36, "28", "12", 2620, "non-USA", "Hyundai Elantra");
                yield return new Cars93("Hyundai", "Scoupe", "Sporty", 9.1, 10, 11, 26, 34, "None", "Front", "4", 1.5, 92, 5550, 2540, "Yes", 11.9, 4, 166, 94, 64, 34, "23.5", "9", 2285, "non-USA", "Hyundai Scoupe");
                yield return new Cars93("Hyundai", "Sonata", "Midsize", 12.4, 13.9, 15.3, 20, 27, "None", "Front", "4", 2, 128, 6000, 2335, "Yes", 17.2, 5, 184, 104, 69, 41, "31", "14", 2885, "non-USA", "Hyundai Sonata");
                yield return new Cars93("Infiniti", "Q45", "Midsize", 45.4, 47.9, 50.4, 17, 22, "Driver only", "Rear", "8", 4.5, 278, 6000, 1955, "No", 22.5, 5, 200, 113, 72, 42, "29", "15", 4000, "non-USA", "Infiniti Q45");
                yield return new Cars93("Lexus", "ES300", "Midsize", 27.5, 28, 28.4, 18, 24, "Driver only", "Front", "6", 3, 185, 5200, 2325, "Yes", 18.5, 5, 188, 103, 70, 40, "27.5", "14", 3510, "non-USA", "Lexus ES300");
                yield return new Cars93("Lexus", "SC300", "Midsize", 34.7, 35.2, 35.6, 18, 23, "Driver & Passenger", "Rear", "6", 3, 225, 6000, 2510, "Yes", 20.6, 4, 191, 106, 71, 39, "25", "9", 3515, "non-USA", "Lexus SC300");
                yield return new Cars93("Lincoln", "Continental", "Midsize", 33.3, 34.3, 35.3, 17, 26, "Driver & Passenger", "Front", "6", 3.8, 160, 4400, 1835, "No", 18.4, 6, 205, 109, 73, 42, "30", "19", 3695, "USA", "Lincoln Continental");
                yield return new Cars93("Lincoln", "Town_Car", "Large", 34.4, 36.1, 37.8, 18, 26, "Driver & Passenger", "Rear", "8", 4.6, 210, 4600, 1840, "No", 20, 6, 219, 117, 77, 45, "31.5", "22", 4055, "USA", "Lincoln Town_Car");
                yield return new Cars93("Mazda", "323", "Small", 7.4, 8.3, 9.1, 29, 37, "None", "Front", "4", 1.6, 82, 5000, 2370, "Yes", 13.2, 4, 164, 97, 66, 34, "27", "16", 2325, "non-USA", "Mazda 323");
                yield return new Cars93("Mazda", "Protege", "Small", 10.9, 11.6, 12.3, 28, 36, "None", "Front", "4", 1.8, 103, 5500, 2220, "Yes", 14.5, 5, 172, 98, 66, 36, "26.5", "13", 2440, "non-USA", "Mazda Protege");
                yield return new Cars93("Mazda", "626", "Compact", 14.3, 16.5, 18.7, 26, 34, "Driver only", "Front", "4", 2.5, 164, 5600, 2505, "Yes", 15.5, 5, 184, 103, 69, 40, "29.5", "14", 2970, "non-USA", "Mazda 626");
                yield return new Cars93("Mazda", "MPV", "Van", 16.6, 19.1, 21.7, 18, 24, "None", "4WD", "6", 3, 155, 5000, 2240, "No", 19.6, 7, 190, 110, 72, 39, "27.5", null, 3735, "non-USA", "Mazda MPV");
                yield return new Cars93("Mazda", "RX-7", "Sporty", 32.5, 32.5, 32.5, 17, 25, "Driver only", "Rear", "rotary", 1.3, 255, 6500, 2325, "Yes", 20, 2, 169, 96, 69, 37, null, null, 2895, "non-USA", "Mazda RX-7");
                yield return new Cars93("Mercedes-Benz", "190E", "Compact", 29, 31.9, 34.9, 20, 29, "Driver only", "Rear", "4", 2.3, 130, 5100, 2425, "Yes", 14.5, 5, 175, 105, 67, 34, "26", "12", 2920, "non-USA", "Mercedes-Benz 190E");
                yield return new Cars93("Mercedes-Benz", "300E", "Midsize", 43.8, 61.9, 80, 19, 25, "Driver & Passenger", "Rear", "6", 3.2, 217, 5500, 2220, "No", 18.5, 5, 187, 110, 69, 37, "27", "15", 3525, "non-USA", "Mercedes-Benz 300E");
                yield return new Cars93("Mercury", "Capri", "Sporty", 13.3, 14.1, 15, 23, 26, "Driver only", "Front", "4", 1.6, 100, 5750, 2475, "Yes", 11.1, 4, 166, 95, 65, 36, "19", "6", 2450, "USA", "Mercury Capri");
                yield return new Cars93("Mercury", "Cougar", "Midsize", 14.9, 14.9, 14.9, 19, 26, "None", "Rear", "6", 3.8, 140, 3800, 1730, "No", 18, 5, 199, 113, 73, 38, "28", "15", 3610, "USA", "Mercury Cougar");
                yield return new Cars93("Mitsubishi", "Mirage", "Small", 7.7, 10.3, 12.9, 29, 33, "None", "Front", "4", 1.5, 92, 6000, 2505, "Yes", 13.2, 5, 172, 98, 67, 36, "26", "11", 2295, "non-USA", "Mitsubishi Mirage");
                yield return new Cars93("Mitsubishi", "Diamante", "Midsize", 22.4, 26.1, 29.9, 18, 24, "Driver only", "Front", "6", 3, 202, 6000, 2210, "No", 19, 5, 190, 107, 70, 43, "27.5", "14", 3730, "non-USA", "Mitsubishi Diamante");
                yield return new Cars93("Nissan", "Sentra", "Small", 8.7, 11.8, 14.9, 29, 33, "Driver only", "Front", "4", 1.6, 110, 6000, 2435, "Yes", 13.2, 5, 170, 96, 66, 33, "26", "12", 2545, "non-USA", "Nissan Sentra");
                yield return new Cars93("Nissan", "Altima", "Compact", 13, 15.7, 18.3, 24, 30, "Driver only", "Front", "4", 2.4, 150, 5600, 2130, "Yes", 15.9, 5, 181, 103, 67, 40, "28.5", "14", 3050, "non-USA", "Nissan Altima");
                yield return new Cars93("Nissan", "Quest", "Van", 16.7, 19.1, 21.5, 17, 23, "None", "Front", "6", 3, 151, 4800, 2065, "No", 20, 7, 190, 112, 74, 41, "27", null, 4100, "non-USA", "Nissan Quest");
                yield return new Cars93("Nissan", "Maxima", "Midsize", 21, 21.5, 22, 21, 26, "Driver only", "Front", "6", 3, 160, 5200, 2045, "No", 18.5, 5, 188, 104, 69, 41, "28.5", "14", 3200, "non-USA", "Nissan Maxima");
                yield return new Cars93("Oldsmobile", "Achieva", "Compact", 13, 13.5, 14, 24, 31, "None", "Front", "4", 2.3, 155, 6000, 2380, "No", 15.2, 5, 188, 103, 67, 39, "28", "14", 2910, "USA", "Oldsmobile Achieva");
                yield return new Cars93("Oldsmobile", "Cutlass_Ciera", "Midsize", 14.2, 16.3, 18.4, 23, 31, "Driver only", "Front", "4", 2.2, 110, 5200, 2565, "No", 16.5, 5, 190, 105, 70, 42, "28", "16", 2890, "USA", "Oldsmobile Cutlass_Ciera");
                yield return new Cars93("Oldsmobile", "Silhouette", "Van", 19.5, 19.5, 19.5, 18, 23, "None", "Front", "6", 3.8, 170, 4800, 1690, "No", 20, 7, 194, 110, 74, 44, "30.5", null, 3715, "USA", "Oldsmobile Silhouette");
                yield return new Cars93("Oldsmobile", "Eighty-Eight", "Large", 19.5, 20.7, 21.9, 19, 28, "Driver only", "Front", "6", 3.8, 170, 4800, 1570, "No", 18, 6, 201, 111, 74, 42, "31.5", "17", 3470, "USA", "Oldsmobile Eighty-Eight");
                yield return new Cars93("Plymouth", "Laser", "Sporty", 11.4, 14.4, 17.4, 23, 30, "None", "4WD", "4", 1.8, 92, 5000, 2360, "Yes", 15.9, 4, 173, 97, 67, 39, "24.5", "8", 2640, "USA", "Plymouth Laser");
                yield return new Cars93("Pontiac", "LeMans", "Small", 8.2, 9, 9.9, 31, 41, "None", "Front", "4", 1.6, 74, 5600, 3130, "Yes", 13.2, 4, 177, 99, 66, 35, "25.5", "17", 2350, "USA", "Pontiac LeMans");
                yield return new Cars93("Pontiac", "Sunbird", "Compact", 9.4, 11.1, 12.8, 23, 31, "None", "Front", "4", 2, 110, 5200, 2665, "Yes", 15.2, 5, 181, 101, 66, 39, "25", "13", 2575, "USA", "Pontiac Sunbird");
                yield return new Cars93("Pontiac", "Firebird", "Sporty", 14, 17.7, 21.4, 19, 28, "Driver & Passenger", "Rear", "6", 3.4, 160, 4600, 1805, "Yes", 15.5, 4, 196, 101, 75, 43, "25", "13", 3240, "USA", "Pontiac Firebird");
                yield return new Cars93("Pontiac", "Grand_Prix", "Midsize", 15.4, 18.5, 21.6, 19, 27, "None", "Front", "6", 3.4, 200, 5000, 1890, "Yes", 16.5, 5, 195, 108, 72, 41, "28.5", "16", 3450, "USA", "Pontiac Grand_Prix");
                yield return new Cars93("Pontiac", "Bonneville", "Large", 19.4, 24.4, 29.4, 19, 28, "Driver & Passenger", "Front", "6", 3.8, 170, 4800, 1565, "No", 18, 6, 177, 111, 74, 43, "30.5", "18", 3495, "USA", "Pontiac Bonneville");
                yield return new Cars93("Saab", "900", "Compact", 20.3, 28.7, 37.1, 20, 26, "Driver only", "Front", "4", 2.1, 140, 6000, 2910, "Yes", 18, 5, 184, 99, 67, 37, "26.5", "14", 2775, "non-USA", "Saab 900");
                yield return new Cars93("Saturn", "SL", "Small", 9.2, 11.1, 12.9, 28, 38, "Driver only", "Front", "4", 1.9, 85, 5000, 2145, "Yes", 12.8, 5, 176, 102, 68, 40, "26.5", "12", 2495, "USA", "Saturn SL");
                yield return new Cars93("Subaru", "Justy", "Small", 7.3, 8.4, 9.5, 33, 37, "None", "4WD", "3", 1.2, 73, 5600, 2875, "Yes", 9.2, 4, 146, 90, 60, 32, "23.5", "10", 2045, "non-USA", "Subaru Justy");
                yield return new Cars93("Subaru", "Loyale", "Small", 10.5, 10.9, 11.3, 25, 30, "None", "4WD", "4", 1.8, 90, 5200, 3375, "Yes", 15.9, 5, 175, 97, 65, 35, "27.5", "15", 2490, "non-USA", "Subaru Loyale");
                yield return new Cars93("Subaru", "Legacy", "Compact", 16.3, 19.5, 22.7, 23, 30, "Driver only", "4WD", "4", 2.2, 130, 5600, 2330, "Yes", 15.9, 5, 179, 102, 67, 37, "27", "14", 3085, "non-USA", "Subaru Legacy");
                yield return new Cars93("Suzuki", "Swift", "Small", 7.3, 8.6, 10, 39, 43, "None", "Front", "3", 1.3, 70, 6000, 3360, "Yes", 10.6, 4, 161, 93, 63, 34, "27.5", "10", 1965, "non-USA", "Suzuki Swift");
                yield return new Cars93("Toyota", "Tercel", "Small", 7.8, 9.8, 11.8, 32, 37, "Driver only", "Front", "4", 1.5, 82, 5200, 3505, "Yes", 11.9, 5, 162, 94, 65, 36, "24", "11", 2055, "non-USA", "Toyota Tercel");
                yield return new Cars93("Toyota", "Celica", "Sporty", 14.2, 18.4, 22.6, 25, 32, "Driver only", "Front", "4", 2.2, 135, 5400, 2405, "Yes", 15.9, 4, 174, 99, 69, 39, "23", "13", 2950, "non-USA", "Toyota Celica");
                yield return new Cars93("Toyota", "Camry", "Midsize", 15.2, 18.2, 21.2, 22, 29, "Driver only", "Front", "4", 2.2, 130, 5400, 2340, "Yes", 18.5, 5, 188, 103, 70, 38, "28.5", "15", 3030, "non-USA", "Toyota Camry");
                yield return new Cars93("Toyota", "Previa", "Van", 18.9, 22.7, 26.6, 18, 22, "Driver only", "4WD", "4", 2.4, 138, 5000, 2515, "Yes", 19.8, 7, 187, 113, 71, 41, "35", null, 3785, "non-USA", "Toyota Previa");
                yield return new Cars93("Volkswagen", "Fox", "Small", 8.7, 9.1, 9.5, 25, 33, "None", "Front", "4", 1.8, 81, 5500, 2550, "Yes", 12.4, 4, 163, 93, 63, 34, "26", "10", 2240, "non-USA", "Volkswagen Fox");
                yield return new Cars93("Volkswagen", "Eurovan", "Van", 16.6, 19.7, 22.7, 17, 21, "None", "Front", "5", 2.5, 109, 4500, 2915, "Yes", 21.1, 7, 187, 115, 72, 38, "34", null, 3960, "non-USA", "Volkswagen Eurovan");
                yield return new Cars93("Volkswagen", "Passat", "Compact", 17.6, 20, 22.4, 21, 30, "None", "Front", "4", 2, 134, 5800, 2685, "Yes", 18.5, 5, 180, 103, 67, 35, "31.5", "14", 2985, "non-USA", "Volkswagen Passat");
                yield return new Cars93("Volkswagen", "Corrado", "Sporty", 22.9, 23.3, 23.7, 18, 25, "None", "Front", "6", 2.8, 178, 5800, 2385, "Yes", 18.5, 4, 159, 97, 66, 36, "26", "15", 2810, "non-USA", "Volkswagen Corrado");
                yield return new Cars93("Volvo", "240", "Compact", 21.8, 22.7, 23.5, 21, 28, "Driver only", "Rear", "4", 2.3, 114, 5400, 2215, "Yes", 15.8, 5, 190, 104, 67, 37, "29.5", "14", 2985, "non-USA", "Volvo 240");
                yield return new Cars93("Volvo", "850", "Midsize", 24.8, 26.7, 28.5, 20, 28, "Driver & Passenger", "Front", "5", 2.4, 168, 6200, 2310, "Yes", 19.3, 5, 184, 105, 69, 38, "30", "15", 3245, "non-USA", "Volvo 850");
            }
        }
    }
}
