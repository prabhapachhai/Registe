using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterFramework.Helpers
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


    public enum Identifiertype
    {
        index,
        text,
        value
    }

    
    public static class FrameWorkHelpers
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
        public static IReadOnlyCollection<IWebElement> GetElements(string locator, IdentifierType identifierType)
        {
            IReadOnlyCollection<IWebElement> elements = null;
            switch (identifierType)
            {
                case IdentifierType.Id:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));
                    break;
                case IdentifierType.Name:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
                    elements = WebDriver.FindElements(By.Name(locator));
                    break;
                case IdentifierType.ClassName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
                    elements = WebDriver.FindElements(By.ClassName(locator));
                    break;
                case IdentifierType.LinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
                    elements = WebDriver.FindElements(By.LinkText(locator));
                    break;
                case IdentifierType.PartialLinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
                    elements = WebDriver.FindElements(By.PartialLinkText(locator));
                    break;
                case IdentifierType.TagName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
                    elements = WebDriver.FindElements(By.TagName(locator));
                    break;
                case IdentifierType.CssSelector:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                    elements = WebDriver.FindElements(By.CssSelector(locator));
                    break;
                case IdentifierType.XPath:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                    elements = WebDriver.FindElements(By.XPath(locator));

                    break;
            }
            return elements;
        }
        public static void SelectByIndex(int index, string locator, IdentifierType IdentifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public static void SelectByText(string text, string locator, IdentifierType IdentifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
        public static void SelectByValue(string value, string locator, IdentifierType IdentifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }
    }

}



















