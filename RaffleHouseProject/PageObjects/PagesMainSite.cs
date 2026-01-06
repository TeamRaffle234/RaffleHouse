using OpenQA.Selenium;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;
using RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu;
using RaffleHouseProject.PageObjects.MainPortalPages.Header;
using RaffleHouseProject.PageObjects.MainPortalPages.HomePage;
using RaffleHouseProject.PageObjects.MainPortalPages.PaymentPage;
using RaffleHouseProject.PageObjects.MainPortalPages.SigInPage;
using RaffleHouseProject.PageObjects.MainPortalPages.SignUpForAnAccountPage;
using RaffleHouseProject.PageObjects.MainPortalPages.TicketSelectorPage;
using RaffleHouseProject.PageObjects.UsersPortalPages.WeUseCookiesMdlWnds;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects
{
    public class PagesMainSite
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static EmailHelper EmailHelper => GetPage<EmailHelper>();
        public static JScriptExecutor JScriptExecutor => GetPage<JScriptExecutor>();

        #region Objects

        public static UserBuyer UserBuyer => GetPage<UserBuyer>();

        #endregion

        #region Pages

        public static Header Header => GetPage<Header>();
        public static BurgerMenu BurgerMenu => GetPage<BurgerMenu>();
        public static SignIn SignIn => GetPage<SignIn>();
        public static SignUpForAnAccount SignUpForAnAccount => GetPage<SignUpForAnAccount>();
        public static Home Home => GetPage<Home>();
        public static Payment Payment => GetPage<Payment>();
        public static TicketSelector TicketSelector => GetPage<TicketSelector>();

        #endregion

        #region Modal Windows

        public static WeUseCookiesMdlWnd WeUseCookiesMdlWnd => GetPage<WeUseCookiesMdlWnd>();

        #endregion
    }
}
