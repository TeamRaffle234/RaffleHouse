using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.GuiHelpers.BasicTestsGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MainSiteTests.MainSiteTests
{
    public class MainSiteBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_USERS_PORTAL);
        }

    }
}
