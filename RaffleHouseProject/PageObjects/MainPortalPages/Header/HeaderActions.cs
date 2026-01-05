using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.Header
{
    public partial class Header
    {
        [AllureStep("Click button hamburger")]
        public Header ClickButtonHamburger()
        {
            Button.Click(ButtonHamburger);
            Console.WriteLine($"Humburger button");

            return this;
        }
    }
}
