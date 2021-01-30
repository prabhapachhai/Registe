using NUnit.Framework;
using RightClick.Helpers;
using RightClick.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RightClick.Tests
{
    class RightClickTest :BasePageTest
    {
        [Test]
        public void VerifyRightClickTest()
        {
            RightClickPageView rightClickPageView = new RightClickPageView();
            Thread.Sleep(3000);
            rightClickPageView.RightClickButton();
            Thread.Sleep(2000);
            rightClickPageView.ClickOnEditButton();
            Thread.Sleep(4000);
            Assert.AreEqual("clicked: edit", rightClickPageView.GetAlertText());
            Thread.Sleep(2000);
            FrameWorkHelpers.AlertAccept();
            Thread.Sleep(2000);

        }
         
    }
}
