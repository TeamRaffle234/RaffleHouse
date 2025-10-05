using NUnit.Allure.Attributes;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.WeUseCookiesMdlWnds
{
    public partial class WeUseCookiesMdlWnd
    {
        [AllureStep("Click button Got it")]
        public WeUseCookiesMdlWnd ClickButtonGotIt()
        {
            WaitUntil.CustomElementIsVisible(ButtonGotIt);
            Button.Click(ButtonGotIt);

            return this;
        }
    }
}
