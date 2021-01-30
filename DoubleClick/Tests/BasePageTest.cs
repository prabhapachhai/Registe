using DoubleClick.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DoubleClick.Tests
{
    class BasePageTest
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
        public void BeforeTest()
        {
            FrameWorkHelpers.WebDriver = new ChromeDriver(@"C:\driver\New folder\chromedriver_win32");
            string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Drivers\");
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            FrameWorkHelpers.wait = new WebDriverWait(FrameWorkHelpers.WebDriver, TimeSpan.FromSeconds(30));
            NavigateToURL();

        }
        public void NavigateToURL()
        {
            FrameWorkHelpers.WebDriver.Url = "https://api.jquery.com/dblclick";
        }
        [TearDown]
        public void AfterTest()
        {
            FrameWorkHelpers.WebDriver.Quit();
        }




    }
}
