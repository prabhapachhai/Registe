using DropAndDrag.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DropAndDrag.Views
{
    class DropNDragViewPage
    {
        #region
        private string cookiesButtonId = "onetrust-accept-btn-handler";
        private string smallCircleId = "draggable";
        private string targetCircleid = "droptarget";
        private string AfterDragNDropMessageId = "droptarget";
        #endregion


        internal void Drag( )
        {
            
            FrameWorkHelpers.ClickElement(cookiesButtonId, IdentifierType.Id);
            Thread.Sleep(2000);
            FrameWorkHelpers.DragDrop(smallCircleId, IdentifierType.Id,targetCircleid,IdentifierType.Id);
            Thread.Sleep(2000);
           // FrameWorkHelpers.GetElement(smallCircleId, IdentifierType.Id);
           // Thread.Sleep(2000);
            //FrameWorkHelpers.GetElement(targetCircleid, IdentifierType.Id);
            //Thread.Sleep(2000);
            FrameWorkHelpers.GetText(AfterDragNDropMessageId, IdentifierType.Id);
            Thread.Sleep(2000);

        }
        internal string DragMessage()
        {
            
         var actualMessage =  FrameWorkHelpers.GetText(AfterDragNDropMessageId, IdentifierType.Id);

            return actualMessage;
            Console.WriteLine(actualMessage);
        }
    }
}
