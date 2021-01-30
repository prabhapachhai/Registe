using DoubleClick.Helpers;
using DoubleClick.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoubleClick.Tests
{
    class DoubleClickPageTest :BasePageTest
    {
        [Test]
        public void VerifyDoubleClickMethod()
        {
            
            DoubleClickPageView doubleClickPageView = new DoubleClickPageView();
            Thread.Sleep(3000);
            doubleClickPageView.BeforeDoubleClickMethod();
            Thread.Sleep(3000);
           




        }
    }
}
