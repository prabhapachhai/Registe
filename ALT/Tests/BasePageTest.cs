using ALT.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALT.Tests
{
    class BasePageTest
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
     public void BeforeTest()
       {
            FrameWorkHelpers.WebDriver = new ChromeDriver(@"C:\driver\chromedriver_win32 (1)");
           // FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.wait = new WebDriverWait(FrameWorkHelpers.WebDriver, TimeSpan.FromSeconds(30));
            NavigateToUrl();

        }
        private void NavigateToUrl()
        {

            FrameWorkHelpers.WebDriver.Url = "https://www.seleniumeasy.com/test/javascript-alert-box-demo.html";
        }
        [TearDown]
        public void AfterTest()
        {
            FrameWorkHelpers.WebDriver.Quit();
        }
        }

    }

