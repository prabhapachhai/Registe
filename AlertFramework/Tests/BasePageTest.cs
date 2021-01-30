using AlertFramework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlertFramework.Tests
{
    class BasePageTest
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            FrameworkHelpers.WebDriver = new ChromeDriver(@"C:\driver\New folder\chromedriver_win32");
            //string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Drivers\");
           // FrameworkHelpers.WebDriver = new ChromeDriver(path);
          FrameworkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          FrameworkHelpers.WebDriver.Manage().Window.Maximize();
            FrameworkHelpers.wait = new WebDriverWait(FrameworkHelpers.WebDriver, TimeSpan.FromSeconds(30));
            NavigateToUrl();
        }
            private void NavigateToUrl()
        {
            FrameworkHelpers.WebDriver.Url = "https://www.seleniumeasy.com/test/javascript-alert-box-demo.html";

        }
        [TearDown]
        public void AfterTest()
        {
            FrameworkHelpers.WebDriver.Quit();
        }

    }
}

   