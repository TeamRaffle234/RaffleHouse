using NUnit.Allure.Attributes;
using RaffleHouseProject.GuiHelpers;
using System;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.WeUseCookiesMdlWnds
{
    public partial class WeUseCookiesMdlWnd
    {
        [AllureStep("Click button Got it")]
        public WeUseCookiesMdlWnd ClickButtonGotIt()
        {
            Button.Click(ButtonGotIt);
            Console.WriteLine($"Got it button");

            return this;
        }
    }
}
