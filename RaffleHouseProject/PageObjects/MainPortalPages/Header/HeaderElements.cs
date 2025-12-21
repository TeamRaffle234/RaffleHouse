using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.Header
{
    public partial class Header
    {
        [FindsBy(How = How.XPath, Using = "//button[@class = 'headerMenuButton']//img")]
        public IWebElement ButtonHamburger;
    }
}
