using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver(@"C:\driver\New folder\chromedriver_win32");
            driver.Url = "https://api.jquery.com/dblclick";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [Test]
        public void Method()
        {
            // switching to Iframe by index 
            driver.SwitchTo().Frame(0);

            IWebElement doubleclickBlock = driver.FindElement(By.XPath("//span[text()='Double click the block']/preceding::div"));

            // storing css properity to back ground color of WebElement
            string beforedoubleclickbackgroundColor = doubleclickBlock.GetCssValue("background-color");
            // printing the color in Consolewriteline
            Console.WriteLine("beforedoubleclickblockColoris:" + beforedoubleclickbackgroundColor);

            string expectedBlueColor = "rgba(0, 0, 255, 1)";

            Assert.AreEqual(expectedBlueColor, beforedoubleclickbackgroundColor);

            // creating drive object
            Actions actions = new Actions(driver);
            actions.DoubleClick(doubleclickBlock).Perform();

            // storing css property of background color of webelement
            string afterdoubleclickbackgroundColor = doubleclickBlock.GetCssValue("background-color");
            // printing the color console
            Console.WriteLine("afterdoubleclickblockColoris:" + afterdoubleclickbackgroundColor);
            string expectedYellowColor = "rgba(255, 255, 0, 1)";
            Assert.AreEqual(expectedYellowColor, afterdoubleclickbackgroundColor);

        }
        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}



        