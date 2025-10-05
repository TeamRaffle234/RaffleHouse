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
        [AllureSubSuite("Sign_In_Without_Phone_Success")]
        public void Sign_In_Without_Phone_Success()
        {
            //Flow: Sign in via sidebar > Verify > full user name, user email > Verify full user name on sidebar , user email on My details page
            #region Test data



            #endregion

            #region Preconditions API



            #endregion

            #region Preconditions DB



            #endregion

            #region Preconditions GUI

            PagesUsersPortals
                .WeUseCookiesMdlWnd.ClickButtonGotIt();
            PagesUsersPortals
                .Header.ClickButtonHamburger();

            #endregion

            #region Test GUI



            #endregion

            #region Postconditions



            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}