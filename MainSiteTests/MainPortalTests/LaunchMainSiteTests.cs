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


            WaitUntil.WaitSomeInterval(100);
            #endregion
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
            //Flow: Sign in via sidebar > Verify > full user name, user email > Verify full user name on sidebar, user email on My details page

            #region Preconditions GUI

            PagesMainSite.WeUseCookiesMdlWnd
                .ClickButtonGotIt();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            PagesMainSite.BurgerMenuMainSite
                .ClickButtonLogIn();

            #endregion

            #region Test GUI

            PagesMainSite.SignInPg
                .AuthorizeVerifyUserWithoutPhone();

            WaitUntil.WaitSomeInterval(100);
            #endregion
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
            //Flow: User unauthorized > Verify hamburger menu > Jump by all the items from the burger menu
            //Early Bird item can be OR cannot be (need to comment OR recommend in method: TransitionsFromBurgerMenuToPages)

            #region Preconditions GUI

            PagesMainSite.WeUseCookiesMdlWnd
                .ClickButtonGotIt();
            PagesMainSite.HomeMainPg
                .VerifyTitleOnHeroVideo();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();

            #endregion

            #region Test GUI

            PagesMainSite.BurgerMenuMainSite
                .TransitionsFromBurgerMenuToPages();

            WaitUntil.WaitSomeInterval(2000);
            #endregion
        }

    }
}
