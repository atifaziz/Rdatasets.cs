// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Film
    /// </summary>

    public class Film
    {
        public readonly int κ;
        public readonly string Title;
        public readonly int Year;
        public readonly int Time;
        public readonly int Cast;
        public readonly double Rating;
        public readonly int Description;
        public readonly int Origin;
        public readonly string Time_code;
        public readonly int Good;

        public Film(int κ, string Title, int Year, int Time, int Cast, double Rating, int Description, int Origin, string Time_code, int Good)
        {
            this.κ = κ;
            this.Title = Title;
            this.Year = Year;
            this.Time = Time;
            this.Cast = Cast;
            this.Rating = Rating;
            this.Description = Description;
            this.Origin = Origin;
            this.Time_code = Time_code;
            this.Good = Good;
        }

        public static IEnumerable<Film> Data
        {
            get
            {
                yield return new Film(1, "A_Ticklish_Affair", 1963, 89, 5, 2, 7, 0, "short", 0);
                yield return new Film(2, "Action_in_the_North_Atlantic", 1943, 127, 7, 3, 9, 0, "long", 1);
                yield return new Film(3, "And_the_Ship_Sails_On", 1984, 138, 7, 3, 15, 3, "long", 1);
                yield return new Film(4, "Autumn_Sonata", 1978, 97, 5, 3, 11, 5, "long", 1);
                yield return new Film(5, "Bachelor_Apartment", 1931, 77, 6, 2.5, 7, 0, "short", 0);
                yield return new Film(6, "Benson_Murder_Case", 1930, 69, 8, 2.5, 10, 0, "short", 0);
                yield return new Film(7, "Black_Hand", 1950, 93, 5, 3, 8, 0, "long", 1);
                yield return new Film(8, "Blaze", 1989, 119, 8, 2.5, 15, 0, "long", 0);
                yield return new Film(9, "Blondie_Has_Servant_Trouble", 1940, 70, 9, 2.5, 8, 0, "short", 0);
                yield return new Film(10, "Blondie_in_the_Dough", 1947, 69, 9, 2, 8, 0, "short", 0);
                yield return new Film(11, "Brewster_McCloud", 1970, 101, 9, 3, 11, 0, "long", 1);
                yield return new Film(12, "Calling_Philo_Vance", 1940, 62, 6, 2, 10, 0, "short", 0);
                yield return new Film(13, "Car_Wash", 1976, 97, 10, 2.5, 12, 0, "long", 0);
                yield return new Film(14, "City_Lights", 1985, 85, 10, 1, 13, 0, "short", 0);
                yield return new Film(15, "Come_Out_Fighting", 1945, 62, 9, 1.5, 9, 0, "short", 0);
                yield return new Film(16, "Conflict", 1945, 86, 6, 2.5, 7, 0, "short", 0);
                yield return new Film(17, "Conquest", 1937, 112, 10, 3, 10, 0, "long", 1);
                yield return new Film(18, "Dakota", 1988, 97, 6, 2, 11, 0, "long", 0);
                yield return new Film(19, "Deadhead_Miles", 1972, 93, 12, 2.5, 11, 0, "long", 0);
                yield return new Film(20, "Divided_Heart", 1954, 89, 7, 3, 8, 1, "short", 1);
                yield return new Film(21, "Evergreen", 1934, 90, 5, 3, 9, 1, "long", 1);
                yield return new Film(22, "Falcon_Strikes_Back", 1943, 66, 9, 2.5, 9, 0, "short", 0);
                yield return new Film(23, "Find_the_Lady", 1976, 79, 6, 1.5, 13, 1, "short", 0);
                yield return new Film(24, "Five_Golden_Hours", 1961, 90, 7, 2, 9, 1, "long", 0);
                yield return new Film(25, "Flash_and_the_Firecat", 1975, 84, 6, 1.5, 7, 0, "short", 0);
                yield return new Film(26, "Flight", 1929, 116, 6, 2.5, 7, 0, "long", 0);
                yield return new Film(27, "Four_Jills_in_a_Jeep", 1944, 89, 12, 2.5, 12, 0, "short", 0);
                yield return new Film(28, "Galileo", 1973, 145, 11, 3, 13, 1, "long", 1);
                yield return new Film(29, "Hambone_and_Hillie", 1984, 89, 8, 2.5, 8, 0, "short", 0);
                yield return new Film(30, "Hitler--Dead_or_Alive", 1943, 70, 7, 2, 6, 0, "short", 0);
                yield return new Film(31, "Hold_Back_Tomorrow", 1955, 75, 5, 1.5, 6, 0, "short", 0);
                yield return new Film(32, "House_Party_3", 1994, 94, 8, 1.5, 12, 0, "long", 0);
                yield return new Film(33, "It_Came_from_Outer_Space", 1953, 81, 6, 3, 12, 0, "short", 1);
                yield return new Film(34, "Jason's_Lyric", 1994, 119, 9, 2, 16, 0, "long", 0);
                yield return new Film(35, "Jessica", 1962, 112, 6, 2.5, 7, 0, "long", 0);
                yield return new Film(36, "Kit_Carson", 1940, 97, 7, 3, 8, 0, "long", 1);
                yield return new Film(37, "Kronos", 1957, 78, 5, 2.5, 11, 0, "short", 0);
                yield return new Film(38, "Lady_Dracula", 1973, 80, 4, 1, 8, 0, "short", 0);
                yield return new Film(39, "Last_Plane_Out", 1983, 92, 6, 1.5, 12, 0, "long", 0);
                yield return new Film(40, "Mad_Love", 1995, 95, 12, 1.5, 13, 0, "long", 0);
                yield return new Film(41, "Manhunter", 1986, 119, 7, 3, 21, 0, "long", 1);
                yield return new Film(42, "Memories_of_Me", 1988, 105, 8, 2, 13, 0, "long", 0);
                yield return new Film(43, "Murder_by_Television", 1935, 60, 5, 1.5, 8, 0, "short", 0);
                yield return new Film(44, "Night_of_the_Dark_Shadows", 1971, 97, 6, 1, 11, 0, "long", 0);
                yield return new Film(45, "Okinawa", 1952, 67, 6, 2, 6, 0, "short", 0);
                yield return new Film(46, "Once_a_Thief", 1965, 107, 7, 2, 7, 2, "long", 0);
                yield return new Film(47, "One_Crazy_Summer", 1986, 93, 8, 2, 12, 0, "long", 0);
                yield return new Film(48, "Our_Man_in_Havana", 1960, 107, 7, 2.5, 8, 1, "long", 0);
                yield return new Film(49, "Secret_World", 1969, 94, 5, 2, 7, 2, "long", 0);
                yield return new Film(50, "Secrets", 1971, 86, 6, 1.5, 10, 0, "short", 0);
                yield return new Film(51, "Seminole_Uprising", 1955, 74, 4, 1.5, 5, 0, "short", 0);
                yield return new Film(52, "She_Demons", 1958, 80, 5, 1, 9, 0, "short", 0);
                yield return new Film(53, "Sherlock_Jr.", 1924, 45, 6, 4, 13, 0, "short", 1);
                yield return new Film(54, "Shout_at_the_Devil", 1976, 119, 5, 2.5, 10, 1, "long", 0);
                yield return new Film(55, "Single_Room_Furnished", 1968, 93, 7, 1.5, 10, 0, "long", 0);
                yield return new Film(56, "Sleep_My_Love", 1948, 97, 8, 3, 9, 0, "long", 1);
                yield return new Film(57, "Smash_Up:_The_Story_of_a_Woman", 1947, 103, 6, 3, 14, 0, "long", 1);
                yield return new Film(58, "Spare_the_Rod", 1961, 93, 6, 2.5, 7, 1, "long", 0);
                yield return new Film(59, "Station_West", 1948, 92, 10, 3, 12, 0, "long", 1);
                yield return new Film(60, "Telefon", 1977, 102, 7, 3, 11, 0, "long", 1);
                yield return new Film(61, "The_Abominable_Dr._Phibes", 1971, 94, 5, 3, 9, 1, "long", 1);
                yield return new Film(62, "The_Amazing_Transparent_Man", 1960, 58, 4, 1, 10, 0, "short", 0);
                yield return new Film(63, "The_Boogens", 1981, 95, 6, 1, 8, 0, "long", 0);
                yield return new Film(64, "The_Boy_Who_Cried_Bitch", 1991, 101, 10, 3, 12, 0, "long", 1);
                yield return new Film(65, "The_Chocolate_War", 1988, 103, 7, 3, 13, 0, "long", 1);
                yield return new Film(66, "The_Cockeyed_Miracle", 1946, 81, 5, 2, 7, 0, "short", 0);
                yield return new Film(67, "The_Competition", 1980, 129, 8, 3, 10, 0, "long", 1);
                yield return new Film(68, "The_Curse_of_Bigfoot", 1972, 87, 3, 1, 5, 0, "short", 0);
                yield return new Film(69, "The_Great_Waldo_Pepper", 1975, 107, 8, 3, 11, 0, "long", 1);
                yield return new Film(70, "The_Hatter's_Ghost", 1982, 120, 4, 1.5, 9, 2, "long", 0);
                yield return new Film(71, "The_Judge_and_the_Assassin", 1975, 130, 5, 3.5, 9, 2, "long", 1);
                yield return new Film(72, "The_Last_Valley", 1970, 128, 6, 2, 9, 1, "long", 0);
                yield return new Film(73, "The_Marriage_of_a_Young_Stockbroker", 1971, 95, 6, 2.5, 14, 0, "long", 0);
                yield return new Film(74, "The_Miracle_Worker", 1962, 107, 7, 3.5, 14, 0, "long", 1);
                yield return new Film(75, "The_Mutineers", 1949, 60, 4, 1.5, 5, 0, "short", 0);
                yield return new Film(76, "The_Raven", 1963, 86, 6, 3, 9, 0, "short", 1);
                yield return new Film(77, "The_Ravine", 1969, 97, 6, 2, 7, 3, "long", 0);
                yield return new Film(78, "The_Revolt_of_Job", 1983, 97, 6, 3.5, 9, 6, "long", 1);
                yield return new Film(79, "The_Romantic_Age", 1949, 86, 6, 2, 7, 1, "short", 0);
                yield return new Film(80, "The_Siege_at_Red_River", 1954, 81, 5, 2.5, 5, 0, "short", 0);
                yield return new Film(81, "The_Stone_Boy", 1984, 93, 8, 3.5, 12, 0, "long", 1);
                yield return new Film(82, "The_Strip", 1951, 85, 4, 2, 9, 0, "short", 0);
                yield return new Film(83, "The_Surrogate", 1984, 95, 7, 2.5, 13, 4, "long", 0);
                yield return new Film(84, "The_Twinkle_in_God's_Eye", 1955, 73, 5, 2, 7, 0, "short", 0);
                yield return new Film(85, "The_Ultimate_Warrior", 1975, 94, 6, 2.5, 10, 0, "long", 0);
                yield return new Film(86, "The_Unholy_Three", 1930, 72, 6, 2.5, 9, 0, "short", 0);
                yield return new Film(87, "The_Well", 1951, 85, 7, 3, 8, 0, "short", 1);
                yield return new Film(88, "Tom_Dick_and_Harry", 1941, 86, 7, 3.5, 11, 0, "short", 1);
                yield return new Film(89, "Triumph_of_the_Spirit", 1989, 121, 7, 3, 12, 0, "long", 1);
                yield return new Film(90, "Uncle_Moses", 1932, 87, 7, 2.5, 16, 0, "short", 0);
                yield return new Film(91, "Unsane", 1982, 100, 6, 2, 12, 3, "long", 0);
                yield return new Film(92, "Valley_of_Gwangi", 1969, 95, 5, 2.5, 11, 0, "long", 0);
                yield return new Film(93, "Valley_of_the_Dragons", 1961, 79, 5, 1.5, 8, 0, "short", 0);
                yield return new Film(94, "Vicki", 1953, 85, 7, 2.5, 9, 0, "short", 0);
                yield return new Film(95, "Volere_Volare", 1991, 92, 7, 2.5, 17, 3, "long", 0);
                yield return new Film(96, "Warning_Shot", 1967, 100, 13, 3.5, 12, 0, "long", 1);
                yield return new Film(97, "Whispering_Smith_vs._Scot._Yard", 1951, 77, 5, 2, 9, 1, "short", 0);
                yield return new Film(98, "Windows", 1980, 96, 4, 1, 9, 0, "long", 0);
                yield return new Film(99, "Windwalker", 1980, 108, 5, 2.5, 11, 0, "long", 0);
                yield return new Film(100, "You_Only_Live_Twice", 1967, 116, 9, 2.5, 14, 1, "long", 0);
            }
        }
    }
}
