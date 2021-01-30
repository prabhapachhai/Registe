using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace Register
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver(@"C:\driver\New folder\chromedriver_win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60000);
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        }

        [Test]
        public void RegisterPage()
        {
            IWebElement firstName = driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
            firstName.SendKeys("pra");
            IWebElement lastName = driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
            lastName.SendKeys("karki");
            IWebElement address = driver.FindElement(By.TagName("textarea"));
            address.SendKeys("euless tx");
            IWebElement email = driver.FindElement(By.XPath("//input [@type='email']"));
            email.SendKeys("pra@gmail.com");

            IWebElement phone = driver.FindElement(By.XPath("//input[@type='tel']"));
            phone.SendKeys("4567898121");

            IWebElement radioButton = driver.FindElement(By.XPath("//input[@value='FeMale']"));
            radioButton.Click();
            ReadOnlyCollection<IWebElement> multipleCheckbox = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            foreach (var item in multipleCheckbox)
            {
                item.Click();
                Thread.Sleep(2000);
            }

            //  IWebElement languagedrop = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='msdd']")));
            //// IWebElement languagedrop = driver.FindElement(By.CssSelector(".ui-autocomplete-multiselect.ui-state-default.ui-widget"));
            //SelectElement select6 = new SelectElement(languagedrop);
            //select6.SelectByText("Catalan");
            //Thread.Sleep(2000);

            IWebElement dropdownBox = driver.FindElement(By.Id("Skills"));
            SelectElement select = new SelectElement(dropdownBox);
            select.SelectByIndex(4);

            IWebElement countrydropdownBox = driver.FindElement(By.Id("countries"));
            SelectElement select1 = new SelectElement(countrydropdownBox);
            select1.SelectByText("Nepal");

            IWebElement selectCountry = driver.FindElement(By.XPath("//select[@id='country']"));
            SelectElement select5 = new SelectElement(selectCountry);
            select5.SelectByIndex(2);
            IWebElement yearDrop = driver.FindElement(By.Id("yearbox"));
            SelectElement select3 = new SelectElement(yearDrop);
            select3.SelectByIndex(3);
            IWebElement monthDrop = driver.FindElement(By.XPath("//*[@placeholder='Month']"));
            SelectElement select4 = new SelectElement(monthDrop);
            Thread.Sleep(2000);
            select4.SelectByIndex(3);
            IWebElement dayDrop = driver.FindElement(By.Id("daybox"));
            SelectElement select8 = new SelectElement(dayDrop);
            select8.SelectByIndex(2);
            Thread.Sleep(2000);

            IWebElement password = driver.FindElement(By.Id("firstpassword"));
            password.SendKeys("Abc12345");
            IWebElement confirmPassword = driver.FindElement(By.Id("secondpassword"));
            confirmPassword.SendKeys("Abc12345");
            IWebElement submitButton = driver.FindElement(By.Id("submitbtn"));
            Thread.Sleep(2000);
            submitButton.Click();
            //IWebElement refreshButton = driver.FindElement(By.XPath("//button[@id='Button1']"));
            //Thread.Sleep(2000);
            //refreshButton.Click();




        }
    }
}