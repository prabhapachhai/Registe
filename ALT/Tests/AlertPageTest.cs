using ALT.Helpers;
using ALT.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ALT.Tests
{
    class AlertPageTest:BasePageTest
    {
     [Test]
     public void VerifyAllertPage()
      {
            AlertPageView alertPageView = new AlertPageView();
            alertPageView.JavaScriptAllert();
            Thread.Sleep(3000);
            Assert.AreEqual("I am an alert box!", FrameWorkHelpers.GetAlertText());
            Thread.Sleep(3000);
            FrameWorkHelpers.HandlePupUPAlert();
            Thread.Sleep(3000);
            alertPageView.ConfirmAlert();
            Thread.Sleep(3000);
            Assert.AreEqual("Press a button!", FrameWorkHelpers.GetAlertText());
            Thread.Sleep(2000);
            FrameWorkHelpers.HandlePupUPAlert();
            Thread.Sleep(2000);
            string actualMessage = alertPageView.GetErrorMessage();
            Assert.AreEqual("You pressed Cancel!", alertPageView.GetErrorMessage());
            Console.WriteLine(alertPageView.GetErrorMessage());







        }



    }
}
