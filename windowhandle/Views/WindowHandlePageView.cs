using System;
using System.Collections.Generic;
using System.Text;
using windowhandle.Helpers;

namespace windowhandle.Views
{
    class WindowHandlePageView
    {
        #region locator
        private string SwitchToTabXPath = "//a[@href='SwitchTo.html']";
        private string WindowXpath = "//a[@href='Windows.html']";
        private string OpenSepareteWindowXPath = "//a[@href='#Multiple']";
        private string ClickButtonXPath = "//button[@onclick='multiwindow()']";
        private string SignUpBoxId = "email";
        private string SignInButtonId = "btn1";
        #endregion

        internal void MultipleWindowHandles()
        {
            FrameWorkHelpers.MouseOver(SwitchToTabXPath, IdentifierType.XPath);
            FrameWorkHelpers.ClickElement(WindowXpath, IdentifierType.XPath);
            FrameWorkHelpers.ClickElement(OpenSepareteWindowXPath, IdentifierType.XPath);
            FrameWorkHelpers.ClickElement(ClickButtonXPath, IdentifierType.XPath);
            FrameWorkHelpers.MultipleWindowHandle(WindowIndex.Third);
            FrameWorkHelpers.ClickElement(SignInButtonId, IdentifierType.Id);
            FrameWorkHelpers.MultipleWindowHandle(WindowIndex.first);
            FrameWorkHelpers.MultipleWindowHandle(WindowIndex.second);
        }
    }
}
