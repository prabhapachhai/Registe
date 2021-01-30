using AlertFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlertFramework.Views
{
    class AlertPageView
    {
        #region
       
        //private string clickMeXPath = "//button[@class='btn btn-default']";
       private string clickMeXPath = "//button[@onclick='myAlertFunction()']";
       private  string clickmeXpath = "//button[@onclick='myConfirmFunction()'] "; 
       private string errorMessageId = "confirm-demo";
       private string promptAlertXpath = " //button[@ onclick='myPromptFunction()']";
       private string alertSetTextId = "prompt-demo";

        #endregion

        internal void AllertAccept()
        {
            FrameworkHelpers.ClickElement(clickMeXPath, IdentifierType.XPath);

        }
        internal void confirmAllert()
        {
            FrameworkHelpers.ClickElement(clickmeXpath, IdentifierType.XPath);
               
        }
        internal string GetErrorMessage()
        {
            var actualMessage = FrameworkHelpers.GetText(errorMessageId, IdentifierType.Id);
            return actualMessage;
        }
        internal void ClickPromptAllert()
        {
            FrameworkHelpers.ClickElement(promptAlertXpath, IdentifierType.XPath);

        }
        internal string GetPromptMessage()
        {
            string text = FrameworkHelpers.GetText(alertSetTextId, IdentifierType.Id);
            return text;
        }

    }
}
