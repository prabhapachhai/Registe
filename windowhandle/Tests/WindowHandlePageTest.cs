using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using windowhandle.Views;

namespace windowhandle.Tests
{
    class WindowHandlePageTest : BasePageTest
    {
        // creating Constructor
        public WindowHandlePageTest() : base()
        {
        }
    
    [Test]
     public void VerifyWindowHandles()
    {
            WindowHandlePageView windowHandlePageView = new WindowHandlePageView();
            windowHandlePageView.MultipleWindowHandles();
    }


    }
}
