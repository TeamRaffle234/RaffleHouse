using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.Header
{
    public partial class HeaderMainSite
    {
        [AllureStep("Click button hamburger")]
        public HeaderMainSite ClickButtonHamburger()
        {
            Button.Click(ButtonHamburger);
            Console.WriteLine($"Humburger button");

            return this;
        }

        [AllureStep("Click button logo Raffle House")]
        public HeaderMainSite ClickLogButtonoRaffleHouse()
        {
            Button.Click(LogButtonoRaffleHouse);
            Console.WriteLine($"Logo button Raffle House in header");

            return this;
        }
    }
}
