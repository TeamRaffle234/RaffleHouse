using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.EarlyBirdPage
{
    public partial class EarlyBirdMainPg
    {
        EarlyBirdObject earlyBirdObject = EarlyBirdObject.Generate();

        public string GetTitleValueFromHeroVideoActualResult()
        {
            WaitUntil.StaticElementIsVisible(TitleFromHeroVideoActualResult);
            return TitleFromHeroVideoActualResult.Text;
        }
    }
}
