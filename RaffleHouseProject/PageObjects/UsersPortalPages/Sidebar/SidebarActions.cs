using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.Sidebar
{
    public partial class Sidebar
    {
        [AllureStep("Click button login in sidebar")]
        public Sidebar ClickButtonLogIn()
        {
            WaitUntil.CustomElementIsVisible(ButtonLogIn);
            Button.Click(ButtonLogIn);

            return this;
        }
    }
}
