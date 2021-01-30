using FileUploadInWindowsForm.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUploadInWindowsForm.Tests
{
    class WindowFormFileUploadPageTest:BasePageTest
    {
      //nonstandardfileupload in windows form dll
        [Test]
        public static void VerifyFileUpload()
        {
            WindowFormFileUploadPageView windowFormFileUploadPageView= new WindowFormFileUploadPageView();
            windowFormFileUploadPageView.ClickingOnSelectFileButton();
            Thread.Sleep(2000);
            SendKeys.SendWait(@"C:\Users\12144\Documents\New folder\9_Sept_2020_Static_Keyword.docx");
            Thread.Sleep(3000);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(2000);
            Assert.AreEqual("9_Sept_2020_Static_Keyword.docx", windowFormFileUploadPageView.GetFileName());
            Thread.Sleep(2000);
            windowFormFileUploadPageView.ClickingOnConvertingFile();
            Thread.Sleep(2000);
            Assert.AreEqual("Task finished. The download will be started immediately...", windowFormFileUploadPageView.GettingTheConvertedMessage());
        }


    }
}


   
