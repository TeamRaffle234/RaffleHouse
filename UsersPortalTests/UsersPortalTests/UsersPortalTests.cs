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



            #endregion

            #region Postconditions



            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        public void CheckAllureEnvironment()
        {
            // Проверка 1: Allure lifecycle
            var lifecycle = AllureLifecycle.Instance;
            Assert.IsNotNull(lifecycle, "AllureLifecycle should be initialized");

            // Проверка 2: Results directory
            string resultsDir = Path.Combine(Browser.RootPath(), "allure-results");
            Assert.IsTrue(Directory.Exists(resultsDir), "Allure results directory should exist");

            // Проверка 3: JSON config
            string configPath = Path.Combine(AppContext.BaseDirectory, "allureConfig.json");
            Assert.IsTrue(File.Exists(configPath), "Allure config file should exist");

            Console.WriteLine("Allure environment: OK");
        }
    }
}