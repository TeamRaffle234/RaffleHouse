using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//div[@class = 'sidebar__user-block']//button[text() = 'Login']")]
        public IWebElement ButtonLogIn;
    }
}
