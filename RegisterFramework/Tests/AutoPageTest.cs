using NUnit.Framework;
using RegisterFramework.Helpers;
using RegisterFramework.TestDataObject;
using RegisterFramework.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RegisterFramework.Tests
{
    class AutoPageTest : BasePageTest
    {
        [Test]
        public void AutoPageverifyTest()
        {
            var allData = ExcelHelpers.GetTestData<VerifyRegisterPageTdo>("NewMicrosoftWorksheet", "verifyregisterpage");
            AutoPageView autoPageView = new AutoPageView();
            autoPageView.verifyregisterpage(allData, true);
            //autoPageView.SetTextInFirstNameField("pra");
            //autoPageView.SetTextInLastNameField("karki");
            //autoPageView.SetTextInAddressField("euless tx");
            //autoPageView.SetTextInEmailField("pra@gmail.com");
            //autoPageView.SetTextInPhoneField("7894561235");
            //autoPageView.ClickOnRadioButton();
            //List<string> checkBox = new List<string>() { " cricket" };
            ////List<string> checkBox = new List<string>() { " cricket", "movies" };
            //List<string> hobbies = new List<string>() { "Cricket", "Movies", "Hockey" };
            //Thread.Sleep(2000);
            //autoPageView.ClickOnHobbiesCheckBox(hobbies);
            //Thread.Sleep(2000);

            // //autoPageView.ClickOnLanguageBox("english");
            // autoPageView.SelectBySkill();
            // Thread.Sleep(2000);
            // autoPageView.ClickOnCountryDropDown();
            // Thread.Sleep(2000);
            ////autoPageView.ClickOnSelectCountryDropDown();
            // autoPageView.ClickOnYearDrop();
            // Thread.Sleep(3000);

            //autoPageView.ClickOnMonthDrop();
            // Thread.Sleep(2000);
            //// Thread.Sleep(3000);
            // autoPageView.ClickOnDayDrop();
            // Thread.Sleep(2000);
            // autoPageView.SetTextInPassword("Xyz#123");
            // Thread.Sleep(2000);
            // autoPageView.SetTextInConfirmPassword("Xyz#123");
            // Thread.Sleep(2000);
            // autoPageView.ClickOnsubmitButton();
            // Thread.Sleep(2000);

        }
    }
}
