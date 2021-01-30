using ALT.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALT.Views
{
    class AlertPageView
    {
        #region
        private string javascriptAllertCSS = ".btn.btn-default";
        private string confirmBoxId = "confirm-demo";
        private string ErrorMessageId = "confirm-demo";


        #endregion
        internal void JavaScriptAllert()
        {
            FrameWorkHelpers.ClickElement(javascriptAllertCSS, IdentifierType.CssSelector);
        }
        internal void ConfirmAlert()
        {
            FrameWorkHelpers.ClickElement(confirmBoxId, IdentifierType.Id);
        }
        public string  GetErrorMessage()
        {
            var actualMessage = FrameWorkHelpers.GetText(ErrorMessageId, IdentifierType.Id);
            return actualMessage;
        }

    }
}
