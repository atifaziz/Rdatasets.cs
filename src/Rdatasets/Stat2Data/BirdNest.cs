// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// BirdNest
    /// </summary>

    public class BirdNest
    {
        public readonly string Species;
        public readonly string Common;
        public readonly int Page;
        public readonly double Length;
        public readonly string Nesttype;
        public readonly string Location;
        public readonly double No_eggs;
        public readonly int Color;
        public readonly double? Incubate;
        public readonly double Nestling;
        public readonly double? Totcare;
        public readonly int Closed_;

        public BirdNest(string Species, string Common, int Page, double Length, string Nesttype, string Location, double No_eggs, int Color, double? Incubate, double Nestling, double? Totcare, int Closed_)
        {
            this.Species = Species;
            this.Common = Common;
            this.Page = Page;
            this.Length = Length;
            this.Nesttype = Nesttype;
            this.Location = Location;
            this.No_eggs = No_eggs;
            this.Color = Color;
            this.Incubate = Incubate;
            this.Nestling = Nestling;
            this.Totcare = Totcare;
            this.Closed_ = Closed_;
        }

        public static IEnumerable<BirdNest> Data
        {
            get
            {
                yield return new BirdNest("Tyrannus tyrannus", "Eastern Kingbird", 360, 20, "cup", "decid", 3.5, 1, 17, 17, 34, 0);
                yield return new BirdNest("Myiodynastes luteiventris", "Sulphur-bellied Flycatcher", 368, 20, "cavity", "decid", 3.5, 1, 15.5, 17, 32.5, 1);
                yield return new BirdNest("Myiarchus cinerascens", "Ash-thoated Flycatcher", 372, 20, "cavity", "decid", 4.5, 1, 15, 15, 30, 1);
                yield return new BirdNest("Myiarchus tyrannulus", "Brown-crested Flycatcher", 372, 22.5, "cavity", "decid", 4.5, 1, 14, 16.5, 30.5, 1);
                yield return new BirdNest("Myarchus tuberculifer", "Dusky-capped Flycatcher", 374, 17, "cavity", "decid", 4.5, 1, 14, 14, 28, 1);
                yield return new BirdNest("Sayornis phoebe", "Eastern Phoebe", 378, 17, "cup", "bridge", 4.5, 0, 16, 15.5, 31.5, 0);
                yield return new BirdNest("Empidonax wrightii", "Gray Flycatcher", 382, 15, "cup", "shrub", 3.5, 0, 14, 16, 30, 0);
                yield return new BirdNest("Pyrocephalus rubinus", "Vermillion Flycatcher", 382, 15, "cup", "decid", 3, 1, 14.5, 15, 29.5, 0);
                yield return new BirdNest("Pachyramphus algaiae", "Rose-throated Becard", 394, 16, "spherical", "decid", 5, 1, null, 19, null, 1);
                yield return new BirdNest("Alauda arvensis", "Eurasion Skylark", 394, 18.5, "saucer", "ground", 3.5, 1, 11.5, 9.5, 21, 0);
                yield return new BirdNest("Eremophila alpestris", "Horned Lark", 396, 19, "saucer", "ground", 3.5, 1, 11.5, 10.5, 22, 0);
                yield return new BirdNest("Riparia riparia", "Bank Swallow", 400, 12.5, "burrow", "bank", 4.5, 0, 15, 21, 36, 1);
                yield return new BirdNest("Stelgidopteryx serripennis", "Northern Rough-winged Swallow", 400, 13.5, "burrow", "bank", 5.5, 0, 12, 20, 32, 1);
                yield return new BirdNest("Hirundo rustica", "Barn Swallow", 402, 17, "cup", "building", 4.5, 1, 15, 20.5, 35.5, 0);
                yield return new BirdNest("Aphelocoma coerulescens", "Scrub Jay", 404, 30.5, "cup", "decid", 4.5, 1, 16, 18.5, 34.5, 0);
                yield return new BirdNest("Gymnorhina cyanocephalus", "Pinyon Jay", 406, 26.5, "cup", "conif", 4.5, 1, 16.5, 21, 37.5, 0);
                yield return new BirdNest("Cyanocitta cristata", "Blue Jay", 408, 29.5, "cup", "conif", 4.5, 1, 17, 19, 36, 0);
                yield return new BirdNest("Nucifraga columbiana", "Clark's Nutcracker", 410, 31.5, "cup", "conif", 3, 1, 17, 19.5, 36.5, 0);
                yield return new BirdNest("Perisoreus canadensis", "Cray Jay", 410, 30.5, "cup", "decid", 3.5, 1, 17, 15, 32, 0);
                yield return new BirdNest("Parus bicolor", "Tufted Titmouse", 422, 14, "cavity", "decid", 6, 1, 13.5, 16.5, 30, 1);
                yield return new BirdNest("Parus atricapillus", "Black-capped Chickadee", 424, 13, "cavity", "decid", 7, 1, 12, 16, 28, 1);
                yield return new BirdNest("Auriparus flaviceps", "Verdin", 432, 10.5, "spherical", "shrub", 4.5, 1, 10, 21, 31, 1);
                yield return new BirdNest("Sitta carolinensis", "White-breasted Nuthatch", 434, 14, "cavity", "decid", 6.5, 1, 12, 14, 26, 1);
                yield return new BirdNest("Sitta canadensis", "Red-breasted Nuthatch", 436, 11, "cavity", "conif", 5.5, 1, 12, 17.5, 29.5, 1);
                yield return new BirdNest("Sitta pygmaea", "Pygmy Nuthatch", 436, 10, "cavity", "conif", 7, 1, 15.5, 21, 36.5, 1);
                yield return new BirdNest("Troglodytes aedon", "House Wren", 438, 12, "cavity", "decid", 7, 1, 13, 15, 28, 1);
                yield return new BirdNest("Thryothorus ludovicianus", "Carolina Wren", 440, 14, "cavity", "decid", 5, 1, 13, 13, 26, 1);
                yield return new BirdNest("Thryomanes bewickii", "Bewick's Wren", 442, 13, "cavity", "decid", 6, 1, 13, 14, 27, 1);
                yield return new BirdNest("Campylorhynchus brunneicapillus", "Cactus Wren", 446, 20, "spherical", "shrub", 3.5, 1, 16, 21, 37, 1);
                yield return new BirdNest("Regulus satrapa", "Golden-crowned Kinglet", 448, 9, "pendant", "conif", 8.5, 1, 14.5, 16.5, 31, 1);
                yield return new BirdNest("Regulus calendula", "Ruby-crowned Kinglet", 450, 10, "pendant", "conif", 8, 1, 12, 12, 24, 1);
                yield return new BirdNest("Sialia sialis", "Eastern Bluebird", 452, 18, "cavity", "snag", 4.5, 0, 13, 17.5, 30.5, 1);
                yield return new BirdNest("Polioptila melanura", "Black-tailed Gnatcatcher", 452, 11, "cup", "shrub", 4, 1, 14, 12, 26, 0);
                yield return new BirdNest("Sialia currucoides", "Mountain Bluebird", 454, 18, "cavity", "snag", 5.5, 0, 13.5, 22.5, 36, 1);
                yield return new BirdNest("Hylocichla mustelina", "Wood Thrush", 456, 20, "cup", "decid", 3.5, 0, 13.5, 12, 25.5, 0);
                yield return new BirdNest("Catharus ustulatus", "Swainson's Thrush", 458, 18, "cup", "shrub", 3.5, 1, 13, 11.5, 24.5, 0);
                yield return new BirdNest("Catharus guttatus", "Hermit Thrush", 460, 18, "cup", "ground", 4, 0, 12.5, 12, 24.5, 0);
                yield return new BirdNest("Turdus migratorius", "American Robin", 462, 25.5, "cup", "decid", 4, 0, 13, 15, 28, 0);
                yield return new BirdNest("Lanius excubitor", "Northern Shrike", 466, 24, "cup", "conif", 5, 1, 15.5, 20, 35.5, 0);
                yield return new BirdNest("Lanius ludovicianus", "Loggerhead Shrike", 466, 23, "cup", "decid", 5.5, 1, 16.5, 19, 35.5, 0);
                yield return new BirdNest("Dumetella carolinensis", "Gray Catbird", 468, 23, "cup", "shrub", 4, 0, 12.5, 10.5, 23, 0);
                yield return new BirdNest("Mimus polyglottos", "Northern Mockingbird", 468, 25.5, "cup", "shrub", 1, 1, 12.5, 12, 24.5, 0);
                yield return new BirdNest("Oreoscoptes montanus", "Sage Thrush", 470, 21.5, "cup", "shrub", 4, 1, 15, 12.5, 27.5, 0);
                yield return new BirdNest("Toxostoma rufum", "Brown Thrasher", 470, 29, "cup", "shrub", 4.5, 1, 12.5, 11, 23.5, 0);
                yield return new BirdNest("Toxostoma curvirostre", "Curve-billed Thrasher", 472, 26.5, "cup", "shrub", 3.5, 1, 13.5, 14.5, 28, 0);
                yield return new BirdNest("Toxostoma redivivum", "California Thrasher", 476, 30.5, "cup", "shrub", 3.5, 1, 14, 13, 27, 0);
                yield return new BirdNest("Anthus spinoletta", "Water Pipit", 478, 16.5, "cup", "ground", 4.5, 1, 14, 14, 28, 0);
                yield return new BirdNest("Motacilla alba", "White Wagtail", 480, 18, "crevice", "bank", 5.5, 1, 13, 14.5, 27.5, 1);
                yield return new BirdNest("Cinclus mexicanus", "American Dipper", 482, 19.5, "crevice", "cliff", 4.5, 0, 15, 21.5, 36.5, 1);
                yield return new BirdNest("Motacilla flava", "Yellow Wagtail", 482, 16, "cup", "ground", 5.5, 1, 11.5, 15.5, 27, 0);
                yield return new BirdNest("Bombycilla cedrorum", "Cedar Waxwing", 484, 18, "cup", "decid", 4, 1, 12, 16, 28, 0);
                yield return new BirdNest("Phainopepla nitens", "Phainopepla", 486, 18.5, "cup", "decid", 2.5, 1, 14, 19.5, 33.5, 0);
                yield return new BirdNest("Sturnus vulgaris", "European Starling", 488, 20, "cavity", "decid", 5, 1, 13, 19.5, 32.5, 1);
                yield return new BirdNest("Vireo solitarius", "Solitary Vireo", 494, 14, "cup", "conif", 4, 1, 14, 14, 28, 0);
                yield return new BirdNest("Vireo olivaceus", "Red-eyed Vireo", 496, 15, "cup", "shrub", 4, 1, 12.5, 11, 23.5, 0);
                yield return new BirdNest("Protonotaria citrea", "Prothonotary Warbler", 500, 14, "cavity", "snag", 5, 1, 13, 11, 24, 1);
                yield return new BirdNest("Vermivora pinus", "Blue-winged Warbler", 500, 12, "cup", "ground", 5, 1, 10.5, 9, 19.5, 0);
                yield return new BirdNest("Dendroica virens", "Black-throated Green Warbler", 522, 12, "cup", "conif", 4.5, 1, 12, 9, 21, 0);
                yield return new BirdNest("Dendroica striata", "Blackpoll Warbler", 530, 13, "cup", "conif", 4.5, 1, 12, 11.5, 23.5, 0);
                yield return new BirdNest("Helmitheros vermivorus", "Worm-eating Warbler", 540, 13.5, "cup", "ground", 4.5, 1, 13, 10, 23, 0);
                yield return new BirdNest("Icteria virens", "Yellow-breasted Chat", 548, 18, "cup", "shrub", 3.5, 1, 11, 8, 19, 0);
                yield return new BirdNest("Myioborus pictus", "Painted Redstart", 550, 14, "cup", "ground", 3.5, 1, 13.5, 11, 24.5, 0);
                yield return new BirdNest("Pheucticus ludovicianus", "Rose-breasted Grosbeak", 552, 19.5, "cup", "decid", 4, 1, 13.5, 10.5, 24, 0);
                yield return new BirdNest("Cardinalis cardinalis", "Northern Cardinal", 554, 21, "cup", "shrub", 3.5, 1, 12.5, 9.5, 22, 0);
                yield return new BirdNest("Pooecetes gramineus", "Vesper Sparrow", 572, 15, "cup", "ground", 3.5, 1, 12, 9, 21, 0);
                yield return new BirdNest("Chondestes grammacus", "Lark Sparrow", 574, 15, "cup", "ground", 4.5, 1, 11.5, 9.5, 21, 0);
                yield return new BirdNest("Melospiza melodia", "Song Sparrow", 576, 14.5, "cup", "ground", 3.5, 1, 13, 10.5, 23.5, 0);
                yield return new BirdNest("Spizella arborea", "American Tree Sparrow", 584, 15.5, "cup", "ground", 12.5, 1, 12.5, 9, 21.5, 0);
                yield return new BirdNest("Junco hyemalis", "Dark-eyed Junco", 590, 15.5, "cup", "ground", 4, 1, 12.5, 11, 23.5, 0);
                yield return new BirdNest("Melospiza lincolnii", "Lincoln's Sparrow", 598, 14, "cup", "ground", 4.5, 1, 13, 10.5, 23.5, 0);
                yield return new BirdNest("Melospiza georgiana", "Swamp Sparrow", 598, 13.5, "cup", "shrub", 4.5, 1, 13.5, 12, 25.5, 0);
                yield return new BirdNest("Calarius ornatus", "Chestnut-collared Longspur", 600, 15, "cup", "ground", 4, 1, 11.5, 11.5, 23, 0);
                yield return new BirdNest("Plectrophenax nivalis", "Snow Bunting", 604, 17, "crevice", "ground", 5.5, 1, 13, 13.5, 26.5, 1);
                yield return new BirdNest("Calamospiza melanocorys", "Lark Bunting", 606, 18, "cup", "ground", 4.5, 0, 11.5, 8.5, 20, 0);
                yield return new BirdNest("Dolichonyx oryzivorus", "Bobolink", 608, 17.5, "cup", "ground", 5.5, 1, 11.5, 12, 23.5, 0);
                yield return new BirdNest("Agelaius phoeniceus", "Red-winged Blackbird", 612, 21, "cup", "shrub", 3.5, 1, 11, 12.5, 23.5, 0);
                yield return new BirdNest("Piranga olivacea", "Scarlet Tanager", 628, 18, "saucer", "decid", 4, 1, 13.5, 10, 23.5, 0);
                yield return new BirdNest("Passer domesticus", "House Sparrow", 632, 15, "cavity", "building", 5, 1, 11.5, 15.5, 27, 1);
                yield return new BirdNest("Carduelis pinus", "Pine Siskin", 634, 12, "saucer", "conif", 3.5, 1, 13, 14.5, 27.5, 0);
                yield return new BirdNest("Carduelis tristis", "American Goldfinch", 636, 13, "cup", "shrub", 5, 0, 11, 14, 25, 0);
                yield return new BirdNest("Pinicola enucleator", "Pine Grosbeak", 640, 22.5, "cup", "conif", 4, 1, 14, 15.5, 29.5, 0);
                yield return new BirdNest("Leucosticte arctoa", "Rosy Finch", 642, 15.5, "cup", "ground", 4.5, 0, 13, 18, 31, 0);
                yield return new BirdNest("Carpodacus purpureus", "Purple Finch", 644, 14.5, "cup", "conif", 4.5, 1, 13, 14, 27, 0);
                yield return new BirdNest("Carpodacus mexicanus", "House Finch", 646, 13.5, "cup", "decid", 4.5, 1, 13, 15, 28, 0);
            }
        }
    }
}
