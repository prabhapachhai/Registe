using FileUpload.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.Views
{
    class FileUploadPageView
    {
        private string selectFileXPath = "//button[@type='button' and text()='Select files']";

       // private string selectFileId = "input_file0";
        private string uploadedFileId = "file0_0_name";
        private string convertButtonClass = "convert_button";
        private string afterconvertedMessageXpath= "//*[@class='completed_window_text']/child::b";

        public void ClickingOnSelectFileButton()
        {
            FrameWorkHelpers.ClickElement(selectFileXPath, IdentifierType.XPath);
            //FrameWorkHelpers.ClickElement(selectFileId, IdentifierType.Id);
          //  FrameWorkHelpers.FileUploadNonStandardHtmlUsingAutoIt();
        }
        public void SettingTheFilePath(string uploadedFile)
        {
            // FrameWorkHelpers.SetText(uploadedFile, uploadedFileId, IdentifierType.Id);
            FrameWorkHelpers.ActionSendKey(uploadedFileId, IdentifierType.Id);
        }
        public void ClickingOnConvertingFile()
        {
            FrameWorkHelpers.ClickElement(convertButtonClass, IdentifierType.Id);
        }
        public string GettingTheConvertedMessage()
        {
            string text = FrameWorkHelpers.GetText(afterconvertedMessageXpath, IdentifierType.XPath);
            return text;
            
        }
    }
    
    }
