using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'header-sidebar-container-wrapper active']//div[@class = 'sidebar-auth-btn-group']//button[@class = 'header-login-button']")]
        public IWebElement ButtonLogIn;
    }
}
