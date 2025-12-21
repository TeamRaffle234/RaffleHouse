using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        [AllureStep("Click button login in sidebar")]
        public BurgerMenu ClickButtonLogIn()
        {
            WaitUntil.CustomElementIsVisible(ButtonLogIn);
            Button.Click(ButtonLogIn);

            return this;
        }
    }
}
