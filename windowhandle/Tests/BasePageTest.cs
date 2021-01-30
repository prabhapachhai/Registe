using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using windowhandle.Helpers;

namespace windowhandle.Tests
{
    class BasePageTest
    {

        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
             FrameWorkHelpers.WebDriver = new ChromeDriver(@"C:\driver\New folder\chromedriver_win32");
            //string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Drivers\chromedriver_win32 (1)\");
           // FrameWorkHelpers.WebDriver = new ChromeDriver(path);
            FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.wait = new WebDriverWait(FrameWorkHelpers.WebDriver, TimeSpan.FromSeconds(60));
            NavigateToUrl();

        }
        private void NavigateToUrl()
        {
            FrameWorkHelpers.WebDriver.Url = "http://demo.automationtesting.in/Register.html";
        }
        [TearDown]
        public void AfterTest()
        {
            //string result = TestContext.CurrentContext.Result.Outcome.ToString();

            //if (result.Contains("Failed"))
            //{
            //    //convert webDriver object to takesScreenShot
            //    ITakesScreenshot screenshotDriver = (ITakesScreenshot)FrameWorkHelpers.WebDriver;
            //    //call GetScreenshot as method to create image file
            //    Screenshot screenshot = screenshotDriver.GetScreenshot();
            //    string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\..");
            //    string testName = TestContext.CurrentContext.Test.Name;
            //    //copy file at destination
            //    screenshot.SaveAsFile(path + testName + ".png", ScreenshotImageFormat.Png);
            //}
              FrameWorkHelpers.WebDriver.Quit();



        }
    }
}

