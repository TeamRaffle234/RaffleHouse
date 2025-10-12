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

    // Amaunt order 1 next must be 2
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

            PagesUsersPortals.SignIn
                .EnterEmail();

            #endregion

            #region Postconditions



            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}