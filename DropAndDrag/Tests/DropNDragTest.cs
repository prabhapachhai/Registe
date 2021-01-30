using DropAndDrag.Helpers;
using DropAndDrag.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DropAndDrag.Tests
{
    class DropNDragTest :BasePageTest
    {
        [Test]
        public void Test1()
        {
            DropNDragViewPage dropNDragViewPage = new DropNDragViewPage();
            dropNDragViewPage.Drag();

            Assert.AreEqual("You did great!", dropNDragViewPage.DragMessage());
           
        }
    }
}
