using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class Home
    {
        HomePageIfOnlyBasicDreamHomeRaffle homePageIfOnlyBasicDreamHomeRaffle = HomePageIfOnlyBasicDreamHomeRaffle.Generate();

        public string GetTitleValueFromHeroVideoActualResult()
        {
            WaitUntil.StaticElementIsVisible(TitleFromHeroVideoActualResult);
            return TitleFromHeroVideoActualResult.GetAttribute("value");
        }
    }
}
