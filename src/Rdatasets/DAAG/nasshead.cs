// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Documentation of names of columns in nass9702cor
    /// </summary>

    public class nasshead
    {
        public readonly string shortname;
        public readonly string SASname;
        public readonly string longname;

        public nasshead(string shortname, string SASname, string longname)
        {
            this.shortname = shortname;
            this.SASname = SASname;
            this.longname = longname;
        }

        public static IEnumerable<nasshead> Data
        {
            get
            {
                yield return new nasshead("yearVeh", "vehicle.", "VEHICLE.MODEL.YEAR");
                yield return new nasshead("psu", "primary.", "PRIMARY SAMPLING UNIT NUMBER");
                yield return new nasshead("case", "case.seq", "CASE SEQUENCE NUMBER");
                yield return new nasshead("bSpeed", "barrier.", "BARRIER EQUIVALENT SPEED");
                yield return new nasshead("vBT", "vehicleb", "VEHICLE BODY TYPE");
                yield return new nasshead("delVhi", "estimate", "ESTIMATED HIGHEST DELTA V");
                yield return new nasshead("basisdelV", "basis.fo", "BASIS FOR TOTAL DELTA V (HIGHEST)");
                yield return new nasshead("totdelV", "total.de", "TOTAL DELTA V");
                yield return new nasshead("vmake", "vehiclem", "VEHICLE MAKE");
                yield return new nasshead("vehDispos", "police.r", "POLICE REPORTED VEHICLE DISPOSITION");
                yield return new nasshead("vnum", "vehiclen", "VEHICLE NUMBER");
                yield return new nasshead("yearacc", "yearacc", "yearacc");
                yield return new nasshead("dvcat", "dvcat", "dvcat");
                yield return new nasshead("car", "car", "car");
                yield return new nasshead("minivan", "minivan", "minivan");
                yield return new nasshead("stwagon", "stwagon", "stwagon");
                yield return new nasshead("suv", "suv", "suv");
                yield return new nasshead("pickup", "pickup", "pickup");
                yield return new nasshead("van", "van", "van");
                yield return new nasshead("largecar", "largecar", "largecar");
                yield return new nasshead("smallcar", "smallcar", "smallcar");
                yield return new nasshead("nif", "national", "NATIONAL INFLATION FACTOR");
                yield return new nasshead("autobelt", "proper.u", "PROPER USE OF AUTO (PASSIVE) BELT SYSTEM");
                yield return new nasshead("ageOFocc", "age.of.o", "AGE OF OCCUPANT");
                yield return new nasshead("abAvail", "air.bag.", "AIR BAG SYSTEM AVAILABILITY");
                yield return new nasshead("abDeployCat", "airbagsy", "AIR BAG SYSTEM DEPLOYED");
                yield return new nasshead("abfail", "airbags0", "AIR BAG SYSTEM FAILURE");
                yield return new nasshead("csafe", "type.of.", "TYPE OF CHILD SAFETY SEAT");
                yield return new nasshead("timeTOdeath", "time.to.", "TIME TO DEATH");
                yield return new nasshead("htOcc", "height.o", "HEIGHT OF OCCUPANT");
                yield return new nasshead("hospstay", "hospital", "HOSPITAL STAY");
                yield return new nasshead("injSeverity", "injury.s", "INJURY SEVERITY (POLICE RATING)");
                yield return new nasshead("manubelt", "properus", "PROPER USE OF MANUAL BELTS");
                yield return new nasshead("occupant", "occupant", "OCCUPANT NUMBER");
                yield return new nasshead("occRole", "occupan0", "OCCUPANT'S ROLE");
                yield return new nasshead("occSpos", "occupan1", "OCCUPANT'S SEAT POSITION");
                yield return new nasshead("sex", "occupan2", "OCCUPANT'S SEX");
                yield return new nasshead("treatmort", "treatmen", "TREATMENT - MORTALITY");
                yield return new nasshead("occWt", "occupan3", "OCCUPANT'S WEIGHT");
                yield return new nasshead("dead", "dead", "dead");
                yield return new nasshead("airbag", "airbag", "airbag");
                yield return new nasshead("seatbelt", "seatbelt", "seatbelt");
                yield return new nasshead("male", "male", "male");
                yield return new nasshead("driver", "driver", "driver");
                yield return new nasshead("dirforce", "directio", "DIRECTION OF FORCE (HIGHEST)");
                yield return new nasshead("defloc", "deformat", "DEFORMATION LOCATION (HIGHEST)");
                yield return new nasshead("old", "old", "old");
                yield return new nasshead("lowsp", "lowsp", "lowsp");
                yield return new nasshead("frontal", "frontal", "frontal");
                yield return new nasshead("occside", "occside", "occside");
                yield return new nasshead("othside", "othside", "othside");
                yield return new nasshead("back", "back", "back");
                yield return new nasshead("nobelt", "nobelt", "nobelt");
                yield return new nasshead("highsp", "highsp", "highsp");
                yield return new nasshead("deploy", "deploy", "deploy");
                yield return new nasshead("abcat", "abcat", "abcat");
            }
        }
    }
}
