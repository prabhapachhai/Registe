using DropAndDrag.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DropAndDrag.Views
{
    class ResizableViewPage
    {
        private string sourceCss = ".ui-resizable-handle.ui-resizable-e";
       // private string sourceId = "resizable";
       // private string targetCSS = ".ui-widget-content.ui-resizable";

        internal void ResizeTheBox()
        {
            FrameWorkHelpers.Resizable(sourceCss, IdentifierType.CssSelector,447,292);

            


        }
    }
    
}

