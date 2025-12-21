using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.WeUseCookiesMdlWnds
{
    public partial class WeUseCookiesMdlWnd
    {
        [FindsBy(How = How.XPath, Using = "//button[text() = 'Got it']")]
        public IWebElement ButtonGotIt;
    }
}