using FileUpload.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileUpload.Tests
{
    class BasePageTest
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
        public void BeforeTest()
        {
           FrameWorkHelpers.WebDriver  = new ChromeDriver(@"C:\driver\chromedriver_win32");
            //string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Driver\");
            //FrameWorkHelpers.WebDriver = new ChromeDriver(path);
             FrameWorkHelpers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            FrameWorkHelpers.WebDriver.Manage().Window.Maximize();
            FrameWorkHelpers.wait = new WebDriverWait(FrameWorkHelpers.WebDriver, TimeSpan.FromSeconds(70));
            NavigateToUrl();

        }
        private void NavigateToUrl()
        {
            FrameWorkHelpers.WebDriver.Url = "https://online2pdf.com/";
        }
    }


}
 
