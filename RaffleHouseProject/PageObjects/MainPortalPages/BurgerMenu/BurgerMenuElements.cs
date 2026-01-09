using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenuMainSite
    {
        #region Header

        [FindsBy(How = How.XPath, Using = "//button[@class = 'sidebar__close-btn']")]
        public IWebElement ButtonIconCloseFormCross;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'sidebar__logo']")]
        public IWebElement ButtonLogoRaffleHouse;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'sidebar__cart']")]
        public IWebElement ButtonIconCart;

        #endregion

        #region Items - Button

        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//div[@class = 'sidebar__user-block']//button[text() = 'Login']")]
        public IWebElement ButtonLogIn;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//div[@class = 'sidebar__user-block']//button[text() = 'Sign up']")]
        public IWebElement ButtonSignUp;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//nav[@class = 'sidebar__menu']//a[text() = 'Buy a ticket']")]
        public IWebElement ButtonBuyATicket;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//nav[@class = 'sidebar__menu']//a[normalize-space() = 'Porsche Early Bird']")]
        public IWebElement ButtonEarlyBird;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'sidebar__wrapper active']//nav[@class = 'sidebar__menu']//a[normalize-space() = 'Our charity partners']")]
        public IWebElement ButtonOurCharityPartners;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonOurWinners;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonRaffleHouseSubscriptions;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonSeniorStudentKeyWorkerDiscounts;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonRaffleHouseRewards;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonReferAFriendGiveTwentyFreeTickets;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonAboutUs;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonContactUs;

        #endregion
    }
}
