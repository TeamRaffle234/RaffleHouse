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
using RaffleHouseProject.PageObjects.EarlyBirdPage;
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

        public static UserBuyerObject UserBuyerObject => GetPage<UserBuyerObject>();
        public static EarlyBirdObject EarlyBirdObject => GetPage<EarlyBirdObject>();

        #endregion

        #region Pages

        public static HeaderMainSite HeaderMainSite => GetPage<HeaderMainSite>();
        public static BurgerMenuMainSite BurgerMenuMainSite => GetPage<BurgerMenuMainSite>();
        public static SignInPg SignInPg => GetPage<SignInPg>();
        public static SignUpForAnAccountPg SignUpForAnAccountPg => GetPage<SignUpForAnAccountPg>();
        public static HomeMainPg HomeMainPg => GetPage<HomeMainPg>();
        public static PaymentPg PaymentPg => GetPage<PaymentPg>();
        public static TicketSelectorMainPg TicketSelectorMainPg => GetPage<TicketSelectorMainPg>();
        public static EarlyBirdPg EarlyBirdPg => GetPage<EarlyBirdPg>();


        #endregion

        #region Modal Windows

        public static WeUseCookiesMdlWnd WeUseCookiesMdlWnd => GetPage<WeUseCookiesMdlWnd>();

        #endregion
    }
}
