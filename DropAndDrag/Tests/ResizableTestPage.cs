using DropAndDrag.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DropAndDrag.Tests
{
    class ResizableTestPage : BasePageTest
    {
       [Test]
       public void VerifyResizaPage()
        {
            ResizableViewPage resizableViewPage = new ResizableViewPage();
            Thread.Sleep(2000);
            resizableViewPage.ResizeTheBox();
            Thread.Sleep(2000);


        }
    }
}
