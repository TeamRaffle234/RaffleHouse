﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace RaffleHouseProject.GuiHelpers
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }

        private static IWebDriver _webDriver;

        internal static void FindElement(object actualUserNameLog)
        {
            throw new NotImplementedException();
        }

        public Browser(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public static void Initialize()
        {
            AllureConfigFilesHelper.CreateJsonConfigFile();
            new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            //Для запуска в фоновом режиме
            //options.AddArgument("--headless=new");
            _webDriver = new ChromeDriver(options);
            _Driver.Manage().Cookies.DeleteAllCookies();
            _Driver.Manage().Window.Maximize();

            Assert.NotNull(_webDriver);
        }


        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }

        public static string RootPathReport() => Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        public static ISearchContext Driver { get { return _webDriver; } }
        public static IWebDriver _Driver { get { return _webDriver; } }
        public static string Title
        {
            get { return _webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return _webDriver.Url; }
        }

        public static void Close()
        {
            _webDriver.Close();
        }

        public static void Quit()
        {
            _webDriver.Quit();
        }
    }
}
