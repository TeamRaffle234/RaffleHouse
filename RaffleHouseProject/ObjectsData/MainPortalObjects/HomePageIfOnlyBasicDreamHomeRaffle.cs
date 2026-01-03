using System;

namespace RaffleHouseProject.ObjectsData.MainPortalObjects
{
    public class HomePageIfOnlyBasicDreamHomeRaffle
    {
        public SectionHeroVideoInfo SectionHeroVideo { get; set; }

        public static HomePageIfOnlyBasicDreamHomeRaffle Generate()
        {
            return new HomePageIfOnlyBasicDreamHomeRaffle
            {
                SectionHeroVideo = CreateSectionHeroVideoInfo(),
            };
        }

        public class SectionHeroVideoInfo
        {
            public string Title { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        private static SectionHeroVideoInfo CreateSectionHeroVideoInfo()
        {
            return new SectionHeroVideoInfo
            {
                Title = "Win this £3m Buckinghamshire Home",
                Address = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = "11213",
                Neighborhood = "Crown Heights",
                BuildingName = "Building Name",
                LlcName = "LLC Name",
            };
        }
    }
}
