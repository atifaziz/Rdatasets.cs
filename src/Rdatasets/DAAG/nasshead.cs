// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Documentation of names of columns in nass9702cor
    /// </summary>

    public class nasshead
    {
        public readonly int κ;
        public readonly string shortname;
        public readonly string SASname;
        public readonly string longname;

        public nasshead(int κ, string shortname, string SASname, string longname)
        {
            this.κ = κ;
            this.shortname = shortname;
            this.SASname = SASname;
            this.longname = longname;
        }

        public static IEnumerable<nasshead> Data
        {
            get
            {
                yield return new nasshead(1, "yearVeh", "vehicle.", "VEHICLE.MODEL.YEAR");
                yield return new nasshead(2, "psu", "primary.", "PRIMARY SAMPLING UNIT NUMBER");
                yield return new nasshead(3, "case", "case.seq", "CASE SEQUENCE NUMBER");
                yield return new nasshead(4, "bSpeed", "barrier.", "BARRIER EQUIVALENT SPEED");
                yield return new nasshead(5, "vBT", "vehicleb", "VEHICLE BODY TYPE");
                yield return new nasshead(6, "delVhi", "estimate", "ESTIMATED HIGHEST DELTA V");
                yield return new nasshead(7, "basisdelV", "basis.fo", "BASIS FOR TOTAL DELTA V (HIGHEST)");
                yield return new nasshead(8, "totdelV", "total.de", "TOTAL DELTA V");
                yield return new nasshead(9, "vmake", "vehiclem", "VEHICLE MAKE");
                yield return new nasshead(10, "vehDispos", "police.r", "POLICE REPORTED VEHICLE DISPOSITION");
                yield return new nasshead(11, "vnum", "vehiclen", "VEHICLE NUMBER");
                yield return new nasshead(12, "yearacc", "yearacc", "yearacc");
                yield return new nasshead(13, "dvcat", "dvcat", "dvcat");
                yield return new nasshead(14, "car", "car", "car");
                yield return new nasshead(15, "minivan", "minivan", "minivan");
                yield return new nasshead(16, "stwagon", "stwagon", "stwagon");
                yield return new nasshead(17, "suv", "suv", "suv");
                yield return new nasshead(18, "pickup", "pickup", "pickup");
                yield return new nasshead(19, "van", "van", "van");
                yield return new nasshead(20, "largecar", "largecar", "largecar");
                yield return new nasshead(21, "smallcar", "smallcar", "smallcar");
                yield return new nasshead(22, "nif", "national", "NATIONAL INFLATION FACTOR");
                yield return new nasshead(23, "autobelt", "proper.u", "PROPER USE OF AUTO (PASSIVE) BELT SYSTEM");
                yield return new nasshead(24, "ageOFocc", "age.of.o", "AGE OF OCCUPANT");
                yield return new nasshead(25, "abAvail", "air.bag.", "AIR BAG SYSTEM AVAILABILITY");
                yield return new nasshead(26, "abDeployCat", "airbagsy", "AIR BAG SYSTEM DEPLOYED");
                yield return new nasshead(27, "abfail", "airbags0", "AIR BAG SYSTEM FAILURE");
                yield return new nasshead(28, "csafe", "type.of.", "TYPE OF CHILD SAFETY SEAT");
                yield return new nasshead(29, "timeTOdeath", "time.to.", "TIME TO DEATH");
                yield return new nasshead(30, "htOcc", "height.o", "HEIGHT OF OCCUPANT");
                yield return new nasshead(31, "hospstay", "hospital", "HOSPITAL STAY");
                yield return new nasshead(32, "injSeverity", "injury.s", "INJURY SEVERITY (POLICE RATING)");
                yield return new nasshead(33, "manubelt", "properus", "PROPER USE OF MANUAL BELTS");
                yield return new nasshead(34, "occupant", "occupant", "OCCUPANT NUMBER");
                yield return new nasshead(35, "occRole", "occupan0", "OCCUPANT'S ROLE");
                yield return new nasshead(36, "occSpos", "occupan1", "OCCUPANT'S SEAT POSITION");
                yield return new nasshead(37, "sex", "occupan2", "OCCUPANT'S SEX");
                yield return new nasshead(38, "treatmort", "treatmen", "TREATMENT - MORTALITY");
                yield return new nasshead(39, "occWt", "occupan3", "OCCUPANT'S WEIGHT");
                yield return new nasshead(40, "dead", "dead", "dead");
                yield return new nasshead(41, "airbag", "airbag", "airbag");
                yield return new nasshead(42, "seatbelt", "seatbelt", "seatbelt");
                yield return new nasshead(43, "male", "male", "male");
                yield return new nasshead(44, "driver", "driver", "driver");
                yield return new nasshead(45, "dirforce", "directio", "DIRECTION OF FORCE (HIGHEST)");
                yield return new nasshead(46, "defloc", "deformat", "DEFORMATION LOCATION (HIGHEST)");
                yield return new nasshead(47, "old", "old", "old");
                yield return new nasshead(48, "lowsp", "lowsp", "lowsp");
                yield return new nasshead(49, "frontal", "frontal", "frontal");
                yield return new nasshead(50, "occside", "occside", "occside");
                yield return new nasshead(51, "othside", "othside", "othside");
                yield return new nasshead(52, "back", "back", "back");
                yield return new nasshead(53, "nobelt", "nobelt", "nobelt");
                yield return new nasshead(54, "highsp", "highsp", "highsp");
                yield return new nasshead(55, "deploy", "deploy", "deploy");
                yield return new nasshead(56, "abcat", "abcat", "abcat");
            }
        }
    }
}
