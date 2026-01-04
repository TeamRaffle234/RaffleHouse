using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;

namespace RaffleHouseProject.GuiHelpers.BasicTestsGui
{
    public class BaseGui
    {
        [OneTimeSetUp]
        public void DobeforeAllTheTests()
        {
            // Инициализация, которая выполняется один раз перед всеми тестами
        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {
            // Закрытие браузера после всех тестов
            try
            {
                if (Browser._Driver != null)
                {
                    Browser.Quit();
                }
            }
            catch (Exception)
            {
                // Игнорируем ошибки при закрытии
            }

            ForceCloseDriver.ForceClose();
        }

        [TearDown]
        public void DoAfterEach()
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    ScreenShot.MakeScreenShot();
                }

                // НЕ закрываем браузер здесь - только в OneTimeTearDown
                // Вместо этого можно очистить cookies или перейти на стартовую страницу
                if (Browser._Driver != null)
                {
                    try
                    {
                        // Очистка cookies и localStorage между тестами
                        Browser._Driver.Manage().Cookies.DeleteAllCookies();
                        ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.localStorage.clear();");
                        ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.sessionStorage.clear();");

                        // Переход на стартовую страницу для следующего теста
                        Browser._Driver.Navigate().GoToUrl("about:blank");
                    }
                    catch (Exception)
                    {
                        // Игнорируем ошибки очистки
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning in TearDown: {ex.Message}");
            }
        }
    }
}
