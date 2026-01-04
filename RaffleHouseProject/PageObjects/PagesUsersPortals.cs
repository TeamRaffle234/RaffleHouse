using OpenQA.Selenium;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;
using RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu;
using RaffleHouseProject.PageObjects.MainPortalPages.Header;
using RaffleHouseProject.PageObjects.MainPortalPages.HomePage;
using RaffleHouseProject.PageObjects.MainPortalPages.SigInPage;
using RaffleHouseProject.PageObjects.UsersPortalPages.WeUseCookiesMdlWnds;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects
{
    public class PagesUsersPortals
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
        public static Home Home => GetPage<Home>();

        #endregion

        #region Modal Windows

        public static WeUseCookiesMdlWnd WeUseCookiesMdlWnd => GetPage<WeUseCookiesMdlWnd>();

        #endregion
    }
}
