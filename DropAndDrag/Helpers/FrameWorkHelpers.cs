using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DropAndDrag.Helpers
{
    public enum IdentifierType
    {
        Id,
        Name,
        ClassName,
        TagName,
        CssSelector,
        XPath,
        LinkText,
        PartialLinkText
    }
    class FrameWorkHelpers
    {
        //class Member
        private static IWebDriver _webDriver;
        internal static WebDriverWait wait;
        private static string text;
        private static IdentifierType identifierType;
        private static string locator;

        //Property
        public static IWebDriver WebDriver
        {

            get
            {
                return _webDriver;
            }



            set
            {
                _webDriver = value;

            }
        }



        public static IWebElement GetElement(string locator, IdentifierType identifierType)
        {
            IWebElement element = null;
            switch (identifierType)
            {
                case IdentifierType.Id:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                    element = WebDriver.FindElement(By.Id(locator));
                    break;
                case IdentifierType.Name:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
                    element = WebDriver.FindElement(By.Name(locator));
                    break;
                case IdentifierType.ClassName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
                    element = WebDriver.FindElement(By.ClassName(locator));

                    break;
                case IdentifierType.TagName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
                    element = WebDriver.FindElement(By.TagName(locator));
                    break;
                case IdentifierType.CssSelector:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                    element = WebDriver.FindElement(By.CssSelector(locator));
                    break;
                case IdentifierType.XPath:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                    element = WebDriver.FindElement(By.XPath(locator));
                    break;
                case IdentifierType.LinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
                    element = WebDriver.FindElement(By.LinkText(locator));
                    break;
                case IdentifierType.PartialLinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
                    element = WebDriver.FindElement(By.PartialLinkText(locator));
                    break;
            }
            return element;
        }

        public static void SetText(string text, string locator, IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            element.SendKeys(text);
        }

        public static string GetText(string locator, IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            return element.Text;
        }
        public static void ClickElement(string locator, IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            element.Click();
        }
        public static void DragDrop(string locator, IdentifierType identifierType,string locator1, IdentifierType identifier)
        {
            IWebElement element = GetElement(locator, identifierType);
            IWebElement element1 = GetElement(locator1, identifier);
            Actions actions = new Actions(_webDriver);
            //Actual Drag and Drop Operation
            actions.DragAndDrop(element,element1).Perform();

        }
        public static void Resizable(string locator, IdentifierType identifierType, int xoffset, int yoffset)
        {
            IWebElement element = GetElement(locator, identifierType);
            Actions actions = new Actions(_webDriver);
            Thread.Sleep(2000);
            actions.ClickAndHold(element).MoveByOffset(xoffset, yoffset).Release().Perform();
        }

       

    }
}
