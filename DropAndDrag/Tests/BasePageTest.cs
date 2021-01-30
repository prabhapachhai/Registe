using DropAndDrag.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DropAndDrag.Tests
{
    class BasePageTest
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            FrameWorkHelpers.WebDriver = new ChromeDriver(@"C:\driver\New folder\chromedriver_win32");
          //  string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Drivers\chromedriver_win32 (1)\");
           // FrameWorkHelpers.WebDriver = new ChromeDriver(path);
            FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.wait = new WebDriverWait(FrameWorkHelpers.WebDriver, TimeSpan.FromSeconds(60));
            NavigateToUrl();

        }
        private void NavigateToUrl()
        {
          // FrameWorkHelpers.WebDriver.Url = "https://demos.telerik.com/kendo-ui/dragdrop/index";
            FrameWorkHelpers.WebDriver.Url = "http://demo.automationtesting.in/Resizable.html";
        }
        [TearDown]
        public void AfterTest()
        {
            FrameWorkHelpers.WebDriver.Quit();

        }

    }
}
