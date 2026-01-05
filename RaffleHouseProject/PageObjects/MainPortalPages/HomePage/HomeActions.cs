using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class Home
    {
        public string GetTitleValueFromHeroVideoActualResult()
        {
            WaitUntil.StaticElementIsVisible(TitleFromHeroVideoActualResult);
            return TitleFromHeroVideoActualResult.Text;
        }
    }
}
