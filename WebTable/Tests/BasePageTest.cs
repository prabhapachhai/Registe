using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebTable.Helpers;

namespace WebTable.Tests
{
    class BasePageTest
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            FrameWorkHelpers.WebDriver = new ChromeDriver(@"C:\driver\chromedriver_win32");
            //string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Drivers\chromedriver_win32\");
            // FrameWorkHelpers.WebDriver = new ChromeDriver(path);
            FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.wait = new WebDriverWait(FrameWorkHelpers.WebDriver, TimeSpan.FromSeconds(60));
            NavigateToUrl();

        }
        private void NavigateToUrl()
        {
            FrameWorkHelpers.WebDriver.Url = "https://www.techlistic.com/p/demo-selenium-practice.html";

        }
    }
}

