using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.PageObjects;

namespace UsersPortalTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : UsersPortalBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios general portal")]
        [AllureSubSuite("Sign_In_Log_Out_Success")]
        public void Sign_In_Log_Out_Success()
        {
            PagesUsersPortals
                .WeUseCookiesMdlWnd.ClickButtonGotIt();
            PagesUsersPortals
                .Header.ClickButtonHamburger();

            WaitUntil.WaitSomeInterval(2000);
        }
    }

}
