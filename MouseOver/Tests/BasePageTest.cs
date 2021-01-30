using MouseOver.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MouseOver.Tests
{
    class BasePageTest
    {
        IWebDriver driver;
        [SetUp]
        public void BeforeTest()
        {
           // FrameWorkHelpers.WebDriver = new ChromeDriver(@"C:\driver\chromedriver_win32 (1)");
            string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Driver\");
            FrameWorkHelpers.WebDriver = new ChromeDriver(path);
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            NavigateToURL();
        }
        private  void NavigateToURL()
        {
            FrameWorkHelpers.WebDriver.Url = "https://www.amazon.com/";
        }
        [TearDown]
        public void AfterTest()
        {
            FrameWorkHelpers.WebDriver.Quit();
        }
    }
}
