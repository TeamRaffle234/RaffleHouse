using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.Header
{
    public partial class Header
    {
        [AllureStep("Click button hamburger")]
        public Header ClickButtonHamburger()
        {
            WaitUntil.CustomElementIsVisible(ButtonHamburger);
            Button.Click(ButtonHamburger);

            return this;
        }
    }
}
