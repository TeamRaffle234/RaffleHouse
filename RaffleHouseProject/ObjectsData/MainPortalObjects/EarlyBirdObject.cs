using System;

namespace RaffleHouseProject.ObjectsData.MainPortalObjects
{
    public class EarlyBirdObject
    {
        public SectionHeroVideoInfo SectionHeroVideo { get; set; }

        public static EarlyBirdObject Generate()
        {
            return new EarlyBirdObject
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
                Title = "Win this Porsche worth £60,000",
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
