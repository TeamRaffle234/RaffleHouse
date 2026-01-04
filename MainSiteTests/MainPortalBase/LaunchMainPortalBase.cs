using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.GuiHelpers.BasicTestsGui;

namespace MainSiteTests.MainPortalBase
{
    public class MainSiteBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            if (Browser._Driver == null)
            {
                Browser.Initialize();
            }
            if (Browser._Driver != null)
            {
                if (StartPoints.URL_HOME_PAGE_USERS_PORTAL != null)
                {
                    Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_USERS_PORTAL);
                }
                else
                {
                    throw new Exception("URL_HOME_PAGE_USERS_PORTAL is null");
                }
            }
            else
            {
                throw new Exception("Browser._Driver is null");
            }
        }
    }
}
