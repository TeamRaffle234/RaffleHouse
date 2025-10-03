using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.GuiHelpers.BasicTestsGui;

namespace UsersPortalTests.UsersPortalTests
{
    public class UsersPortalBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_TENANT_MARKET_EVERGREEN);
        }
    }

}
