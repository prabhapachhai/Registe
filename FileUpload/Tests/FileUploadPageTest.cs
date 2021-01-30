using FileUpload.Helpers;
using FileUpload.Views;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FileUpload.Tests
{
    class FileUploadPageTest : BasePageTest
    {
        [Test]
        
        public static void VerifyFileUpload()
        {
            FileUploadPageView fileUploadPageView = new FileUploadPageView();
            Thread.Sleep(4000);
            fileUploadPageView.ClickingOnSelectFileButton();
            Thread.Sleep(5000);
            FrameWorkHelpers.FileUploadNonStandardHtmlUsingAutoIt(@"C:\Users\12144\Downloads\FileUploadExample.exe", @"C: \Users\12144\Documents\9_Sept_2020_Static_Keyword.docx");
        }
            //fileUploadPageView.ClickingOnConvertingFile();
            //Thread.Sleep(4000);
            //// fileUploadPageView.GettingTheConvertedMessage();
            //Assert.AreEqual("Task finished. The download will be started immediately...", fileUploadPageView.GettingTheConvertedMessage());
        }
    }



