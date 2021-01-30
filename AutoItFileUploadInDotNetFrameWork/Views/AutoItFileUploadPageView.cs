using AutoItFileUploadInDotNetFrameWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoItFileUploadInDotNetFrameWork.Views
{
    class AutoItFileUploadPageView
    {
        private string selectFileXPath = "//button[@type='button' and text()='Select files']";

        // private string selectFileId = "input_file0";
        private string uploadedFileId = "file0_0_name";
        private string convertButtonClass = "convert_button";
        private string afterconvertedMessageXpath = "//*[@class='completed_window_text']/child::b";

        internal void ClickingOnSelectFileButton()
        {
            FrameWorkHelpers.ClickElement(selectFileXPath, IdentifierType.XPath);
            
        }
        internal string GetFileName()
        {
            string text = FrameWorkHelpers.GetText(uploadedFileId, IdentifierType.Id);
            return text;
        }
        
        internal void ClickingOnConvertingFile()
        {
            FrameWorkHelpers.ClickElement(convertButtonClass, IdentifierType.ClassName);
        }
        internal string GettingTheConvertedMessage()
        {
            string text = FrameWorkHelpers.GetText(afterconvertedMessageXpath, IdentifierType.XPath);
            return text;


        }
    }
}

