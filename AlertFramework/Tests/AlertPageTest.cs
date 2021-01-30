using AlertFramework.Helpers;
using AlertFramework.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AlertFramework.Tests
{
    class AlertPageTest : BasePageTest
    {
        [Test]
        public void VerifyAlertTest()
        {
            AlertPageView alertPageView = new AlertPageView();
            alertPageView.AllertAccept();
            Thread.Sleep(2000);
            Assert.AreEqual("I am an alert box!", FrameworkHelpers.GetAlertText());
            FrameworkHelpers.HandlePupUPAlert();
            Thread.Sleep(2000);
            alertPageView.confirmAllert();
            Thread.Sleep(2000);
            Assert.AreEqual("Press a button!", FrameworkHelpers.GetAlertText());
            FrameworkHelpers.HandlePupUPAlert();
            Thread.Sleep(2000);
            string actualMessage = alertPageView.GetErrorMessage();
            Assert.AreEqual("You pressed Cancel!", alertPageView.GetErrorMessage());
            //Console.WriteLine(alertPageView.GetErrorMessage());
            Thread.Sleep(2000);
            alertPageView.ClickPromptAllert();
            Thread.Sleep(2000);
            FrameworkHelpers.SetAllertText("prabha");
            Thread.Sleep(3000);
            Assert.AreEqual("You have entered 'prabha' !", alertPageView.GetPromptMessage());
            Thread.Sleep(2000);
            

        }
      
    }
}
