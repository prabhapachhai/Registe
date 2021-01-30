using AutoItFileUploadInDotNetFrameWork.Helpers;
using AutoItFileUploadInDotNetFrameWork.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoItFileUploadInDotNetFrameWork.Tests
{
    class AutoItFileUploadPageTest : BasePageTest
    {
        [Test]

        public static void VerifyFileUpload()
        {
            AutoItFileUploadPageView autoItFileUploadView = new AutoItFileUploadPageView();
            Thread.Sleep(4000);
            autoItFileUploadView.ClickingOnSelectFileButton();
            Thread.Sleep(5000);
            FrameWorkHelpers.FileUploadNonStandardHtmlUsingAutoIt();
            Thread.Sleep(2000);
            autoItFileUploadView.GetFileName();
            Assert.AreEqual("9_Sept_2020_Static_Keyword.docx", autoItFileUploadView.GetFileName());
            Thread.Sleep(2000);
            autoItFileUploadView.ClickingOnConvertingFile();
            autoItFileUploadView.GettingTheConvertedMessage();
            Assert.AreEqual("Task finished. The download will be started immediately...", autoItFileUploadView.GettingTheConvertedMessage());
        }
    }
}

    






