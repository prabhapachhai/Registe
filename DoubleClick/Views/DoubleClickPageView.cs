using DoubleClick.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleClick.Views
{
    class DoubleClickPageView
    {
        private string doubleclickBlockXPath = "//span[text()='Double click the block']/preceding::div";


        //internal void ScrollToView()
        //{
          
        
        internal void BeforeDoubleClickMethod()
        {
            FrameWorkHelpers.SwitchToMethod(0);
           FrameWorkHelpers.Value(doubleclickBlockXPath, IdentifierType.XPath);

            FrameWorkHelpers.PerformDoubleClick(doubleclickBlockXPath, IdentifierType.XPath);
          
        }
         

        }



    }


    

