using NUnit.Framework;

namespace RaffleHouseProject.GuiHelpers.BasicTestsGui
{
    public class TestsBaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_TENANT_MARKET_EVERGREEN);
        }
    }

}
