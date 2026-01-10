using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.CharityPage
{
    public partial class CharityMainPg
    {
        [AllureStep("Verify Title Discover the Raffle House Charit yRaffle")]
        public CharityMainPg VerifyTitleDiscoverTheRaffleHouseCharityRaffle()
        {
            WaitUntil.StaticElementIsVisible(TitleDiscoverTheRaffleHouseCharityRaffle);
            Assert.IsTrue(Title.IsVisible(TitleDiscoverTheRaffleHouseCharityRaffle));

            return this;
        }
    }
}
