using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;

namespace RaffleHouseProject.PageObjects.EarlyBirdPage
{
    public partial class EarlyBirdPg
    {
        EarlyBirdObject earlyBirdObject = EarlyBirdObject.Generate();

        public string GetTitleValueFromHeroVideoActualResult()
        {
            WaitUntil.StaticElementIsVisible(TitleFromHeroVideoActualResult);
            return TitleFromHeroVideoActualResult.Text;
        }
    }
}
