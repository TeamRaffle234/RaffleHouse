using OpenQA.Selenium;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.UsersPortalObjects;
using RaffleHouseProject.PageObjects.UsersPortalPages.BurgerMenu;
using RaffleHouseProject.PageObjects.UsersPortalPages.Header;
using RaffleHouseProject.PageObjects.UsersPortalPages.Sidebar;
using RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage;
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

        #endregion

        #region Modal Windows

        public static WeUseCookiesMdlWnd WeUseCookiesMdlWnd => GetPage<WeUseCookiesMdlWnd>();

        #endregion
    }
}
