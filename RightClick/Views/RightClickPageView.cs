using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RightClick.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RightClick.Views
{
    class RightClickPageView
    {
        private string rightclickButtonCSS = ".context-menu-one.btn.btn-neutral";
        private string rightclickEditMenuOptionXPath = "//span[text()='Edit']";


        internal void RightClickButton()
        {

            FrameWorkHelpers.RightClickMethod(rightclickButtonCSS, IdentifierType.CssSelector);

        }
        internal void ClickOnEditButton()
        {
            FrameWorkHelpers.ClickElement(rightclickEditMenuOptionXPath, IdentifierType.XPath);

        }

        internal string GetAlertText()
        {
            string alertText = FrameWorkHelpers.WebDriver.SwitchTo().Alert().Text;
            return alertText;
            Console.WriteLine(alertText);
   
    }



    }

}
