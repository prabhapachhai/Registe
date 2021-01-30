using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALT.Helpers
{
    public enum BrowserType
    {
        Chrome,
        FireFox,
        
    }
    public enum IdentifierType
    {
        Id,
        Name,
        ClassName,
        LinkText,
        PartialLinkText,
        TagName,
        CssSelector,
        XPath
    }
    public enum SelectByType
    {
        Index,
        Text,
        Value
    }
    class FrameWorkHelpers
    {
        private static IWebDriver _webDriver;
        internal static WebDriverWait wait;
        internal static IJavaScriptExecutor javaScriptExecutor;

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
                javaScriptExecutor = (IJavaScriptExecutor)value;
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
                case IdentifierType.LinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
                    element = WebDriver.FindElement(By.LinkText(locator));
                    break;
                case IdentifierType.PartialLinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
                    element = WebDriver.FindElement(By.PartialLinkText(locator));
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

        public static void HandlePupUPAlert(bool ok = false)
        {
            if (ok)
            {
                FrameWorkHelpers.WebDriver.SwitchTo().Alert().Accept();
            }
            FrameWorkHelpers.WebDriver.SwitchTo().Alert().Dismiss();
        }
        public static string GetAlertText()
        {
            string alertText = FrameWorkHelpers.WebDriver.SwitchTo().Alert().Text;
            return alertText;

        }
        public static void SetAllertText(string text)
        {
            var allert = FrameWorkHelpers.WebDriver.SwitchTo().Alert();
            allert.SendKeys(text);
            allert.Accept();

        }
        }
    }
