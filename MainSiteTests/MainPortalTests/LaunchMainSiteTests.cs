using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.PageObjects;
using MainSiteTests.MainPortalBase;

namespace MainSiteTests.MainPortalTests
{
    [TestFixture]
    [AllureNUnit]

    // Amount order 3 next must be 4
    // Basic settings for autotests

    public class LaunchMainSiteTests : MainSiteBase
    {
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios general portal")]
        [AllureSubSuite("Demo")]
        public void Demo()
        {
            //Flow: Sign in via sidebar > Verify > full user name, user email > Verify full user name on sidebar , user email on My details page

            #region Test data



            #endregion

            #region Preconditions API



            #endregion

            #region Preconditions DB



            #endregion

            #region Preconditions GUI



            #endregion

            #region Test GUI



            #endregion

            #region Postconditions



            #endregion

            WaitUntil.WaitSomeInterval(100);
        }

        [Test]
        [Order(2)]
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

            #region Preconditions GUI

            PagesUsersPortals.WeUseCookiesMdlWnd
                .ClickButtonGotIt();
            PagesUsersPortals.Header
                .ClickButtonHamburger();
            PagesUsersPortals.BurgerMenu
                .ClickButtonLogIn();

            #endregion

            #region Test GUI

            PagesUsersPortals.SignIn
                .AuthorizeVerifyUserWithoutPhone();

            #endregion

            #region Postconditions



            #endregion

            WaitUntil.WaitSomeInterval(100);
        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios general portal")]
        [AllureSubSuite("Verify_Burger_Menu_If_User_Unauthorized")]
        public void VerifyBurgerMenuIfUserUnauthorized()
        {
            //Flow: User unauthorized > Verify header > Jump by all the items on the burger menu > Verify footer

            #region Preconditions GUI

            PagesUsersPortals.WeUseCookiesMdlWnd
                .ClickButtonGotIt();
            
            PagesUsersPortals.Home
                .VerifyTitleOnHeroVideo();
            PagesUsersPortals.Header
                .ClickButtonHamburger();

            #endregion

            #region Test GUI

            PagesUsersPortals.BurgerMenu
                .VerifyElementsInHeader()
                .TransitionsFromBurgerMenuToPages();

            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

    }
}
