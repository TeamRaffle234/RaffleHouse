using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.OurWinnersPage
{
    public partial class OurWinnersMainsPg
    {
        [AllureStep("Verify Title Meet our winners")]
        public OurWinnersMainsPg VerifyTitleMeetOurWinners()
        {
            WaitUntil.StaticElementIsVisible(TitleMeetOurWinners);
            Assert.IsTrue(Title.IsVisible(TitleMeetOurWinners));

            return this;
        }
    }
}
