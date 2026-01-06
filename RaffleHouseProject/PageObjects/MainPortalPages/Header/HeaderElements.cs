using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.Header
{
    public partial class HeaderMainSite
    {
        [FindsBy(How = How.XPath, Using = "//button[@class = 'headerMenuButton']//img")]
        public IWebElement ButtonHamburger;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'headerLogo']")]
        public IWebElement LogButtonoRaffleHouse;
    }
}
