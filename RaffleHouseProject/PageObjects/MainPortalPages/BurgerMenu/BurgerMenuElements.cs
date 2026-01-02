using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        #region Header

        [FindsBy(How = How.XPath, Using = "//button[@class = 'sidebar__close-btn']")]
        public IWebElement ButtonIconCloseFormCross;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'sidebar__logo']")]
        public IWebElement ButtonLogoRaffleHouse;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'sidebar__cart']")]
        public IWebElement ButtonIconCart;

        #endregion

        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//div[@class = 'sidebar__user-block']//button[text() = 'Login']")]
        public IWebElement ButtonLogIn;
    }
}
