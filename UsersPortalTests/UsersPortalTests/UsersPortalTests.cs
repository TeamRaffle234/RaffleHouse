using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.PageObjects;
using System;
using System.IO;

namespace UsersPortalTests
{
    [TestFixture]
    [AllureNUnit]

    // Amaunt order 2 next must be 3
    // Basic settings for autotests

    public class TestsBaseGui : UsersPortalBase
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

            WaitUntil.WaitSomeInterval(2000);
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

            PagesUsersPortals
                .WeUseCookiesMdlWnd.ClickButtonGotIt();
            PagesUsersPortals
                .Header.ClickButtonHamburger();
            PagesUsersPortals
                .Sidebar.ClickButtonLogIn();

            #endregion

            #region Test GUI

            PagesUsersPortals.SignIn
                .AuthorizeVerifyUserWithoutPhone();

            #endregion

            #region Postconditions



            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}