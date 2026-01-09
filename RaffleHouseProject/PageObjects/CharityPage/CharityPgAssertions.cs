using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.CharityPage
{
    public partial class CharityMainPgA
    {
        [AllureStep("Verify Title Discover the Raffle House Charit yRaffle")]
        public CharityMainPgA VerifyTitleDiscoverTheRaffleHouseCharityRaffle()
        {
            WaitUntil.StaticElementIsVisible(TitleDiscoverTheRaffleHouseCharityRaffle);
            Assert.IsTrue(Title.IsVisible(TitleDiscoverTheRaffleHouseCharityRaffle));

            return this;
        }
    }
}
