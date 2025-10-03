﻿using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace RaffleHouseProject.GuiHelpers
{
    public class JScriptExecutor
    {
        [AllureStep("OpenNewTab")]
        public JScriptExecutor OpenNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.open();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            return this;
        }

        [AllureStep("CloseNewTab")]
        public JScriptExecutor CloseNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.close();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.First());

            return this;
        }

        [AllureStep("ScrollToElement")]
        public static IWebElement ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

            return element;
        }

        [AllureStep("ScrollToDownWebPage")]
        public static void ScrollToDownWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }

        [AllureStep("ScrollToUpWebPage")]
        public static void ScrollToUpWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, -1500)");
        }

        public static IWebElement ClickOnHiddenElement(IWebElement hiddenElement)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver.FindElement(By.Id("ID_OF_ELEMENT"));
            js.ExecuteScript("аргументы[0].click();", hiddenElement);

            return hiddenElement;
        }

        [AllureStep("WaitLoader")]
        public JScriptExecutor WaitLoader()
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            return this;
        }
    }
}
