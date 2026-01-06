using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.TicketSelectorPage
{
    public partial class TicketSelector
    {
        [AllureStep("Verify Title Your Dream Home is up for grabs. A ticket today enters you into this month’s draw. Someone’s got to win! ticket selector page")]
        public TicketSelector VerifyTitleYourDreamHomeIsUpForGrabs()
        {
            WaitUntil.StaticElementIsVisible(TitleYourDreamHomeIsUpForGrabs);
            Assert.IsTrue(Title.IsVisible(TitleYourDreamHomeIsUpForGrabs));

            return this;
        }
    }
}
