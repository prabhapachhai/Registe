using RegisterFramework.Helpers;
using RegisterFramework.TestDataObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RegisterFramework.Views
{

    class AutoPageView
    {
        private string firstNameXpath = "//input[@placeholder='First Name']";
        private string lastNameXpath = "//input[@placeholder='Last Name']";
        private string addressTagName = "textarea";
        private string emailXpath = "//input [@type='email']";
        private string phoneXpath = "//input[@type='tel']";
        private string radioButtonFemaleXpath = "//input[@value='FeMale']";
        private string radioButtonMaleXpath = "//input[@value='Male']";
        private string allHobbiesXpath = "//input[@type='checkbox']";
        // private string languageId = "msdd";
        private string SkillsId = "Skills";
        private string countrydropdownId = "countries";
        private string selectCountryXpath = "//select[@id='country']";
        // private string yeardropId = "//select[@id='country']";
        private string yeardropId = "yearbox";
        private string monthDropXpath = "//select[@placeholder='Month']";
        private string dayDropId = "daybox";
        private string passwordId = "firstpassword";
        private string confirmpasswordId = "secondpassword";
        private string submitButtonId = "submitbtn";

        internal void SetTextInFirstNameField(string firstName, bool clear = false)
        {
            if (clear)
            {
                FrameWorkHelpers.GetElement(firstNameXpath, IdentifierType.XPath).Clear();
            }
            FrameWorkHelpers.SetText(firstName, firstNameXpath, IdentifierType.XPath);

        }

        internal void SetTextInLastNameField(string lastName, bool clear = false)
        {
            if (clear)
                FrameWorkHelpers.GetElement(lastNameXpath, IdentifierType.XPath).Clear();
            FrameWorkHelpers.SetText(lastName, lastNameXpath, IdentifierType.XPath);

        }
        internal void SetTextInAddressField(string address, bool clear = false)
        {
            if (clear)
                FrameWorkHelpers.GetElement(addressTagName, IdentifierType.TagName).Clear();
            FrameWorkHelpers.SetText(address, addressTagName, IdentifierType.TagName);


        }
        internal void SetTextInEmailField(string email, bool clear = false)
        {
            if (clear)
            {
                FrameWorkHelpers.GetElement(emailXpath, IdentifierType.XPath).Clear();
            }
            FrameWorkHelpers.SetText(email, emailXpath, IdentifierType.XPath);

        }
        internal void SetTextInPhoneField(string phone, bool clear = false)
        {
            if (clear)
            {
                FrameWorkHelpers.GetElement(phoneXpath, IdentifierType.XPath).Clear();
            }
            FrameWorkHelpers.SetText(phone, phoneXpath, IdentifierType.XPath);
        }
        internal void verifyregisterpage(List<VerifyRegisterPageTdo> VerifyRegisterPageTdos, bool clear = false)
        {
            for (int i = 0; i < VerifyRegisterPageTdos.Count; i++)
            {
                if (clear)
                {
                    SetTextInFirstNameField(VerifyRegisterPageTdos[i].FirstName, clear);
                    SetTextInLastNameField(VerifyRegisterPageTdos[i].LastName, clear);
                    SetTextInAddressField(VerifyRegisterPageTdos[i].Address, clear);
                    SetTextInEmailField(VerifyRegisterPageTdos[i].Email, clear);
                    SetTextInPhoneField(VerifyRegisterPageTdos[i].PhoneNumber, clear);
                    ClickingonGenderRadioButton(VerifyRegisterPageTdos[i].Gender);
                    Thread.Sleep(2000);
                    

                }

              
                List<string> hobbies = new List<string>() { "Cricket", "Movies", "Hockey" };
                ClickOnHobbiesCheckBox(hobbies);
                Thread.Sleep(2000);
                SelectBySkill();
                //Thread.Sleep(2000);
                //ClickOnCountryDropDown();
                //Thread.Sleep(2000);
                ////ClickOnSelectCountryDropDown();
                //ClickOnYearDrop();
                //Thread.Sleep(3000);
                //ClickOnMonthDrop();
                //Thread.Sleep(3000);
                //ClickOnDayDrop();
                //Thread.Sleep(2000);
                //for (int a = 0; i < VerifyRegisterPageTdos.Count; i++)
                //{
                //    if (clear)
                //    {
                //        SetTextInPassword(VerifyRegisterPageTdos[i].Password, clear);
                //        Thread.Sleep(2000);
                //        SetTextInConfirmPassword(VerifyRegisterPageTdos[i].ConfirmPassword, clear);
                //        Thread.Sleep(2000);
                //    }
            }
            //SetTextInPassword("Xyz#123");
            //Thread.Sleep(2000);
            //SetTextInConfirmPassword("Xyz#123");
            //Thread.Sleep(2000);
            //ClickOnsubmitButton();
            //Thread.Sleep(2000);

        }

            internal void ClickingonGenderRadioButton(string Gender)
            {
                
                if (Gender.Equals("Male"))
                {
                    FrameWorkHelpers.ClickElement(radioButtonMaleXpath, IdentifierType.XPath);
                }
                else
                {
                    FrameWorkHelpers.ClickElement(radioButtonMaleXpath, IdentifierType.XPath);
                }
            }

        internal void ClickOnHobbiesCheckBox(List<string> hobbies, bool clear = true)
        {
            if (clear)
            {
                foreach (var item in hobbies)
                {
                    var allHobbies = FrameWorkHelpers.GetElements(allHobbiesXpath, IdentifierType.XPath);
                    foreach (var hobby in allHobbies)
                    {
                        if (hobby.GetAttribute("value").Equals(item))
                        {
                            hobby.Click();
                            break;
                        }
                    }
                }
            }
        }
        internal void SelectBySkill()
        {
            FrameWorkHelpers.ClickElement(SkillsId, IdentifierType.Id);
            FrameWorkHelpers.SelectByIndex(9, SkillsId, IdentifierType.Id);

        }
        internal void ClickOnCountryDropDown()
        {
            FrameWorkHelpers.ClickElement(countrydropdownId, IdentifierType.Id);
            FrameWorkHelpers.SelectByValue( "Nepal", countrydropdownId, IdentifierType.Id);


        }
        //internal void ClickOnSelectCountryDropDown()
        //{

        //    FrameWorkHelpers.ClickElement(selectCountryXpath, IdentifierType.XPath);
        //    FrameWorkHelpers.SelectByIndex(2, selectCountryXpath, IdentifierType.XPath);
        //}


        internal void ClickOnYearDrop()
        {

            FrameWorkHelpers.ClickElement(yeardropId, IdentifierType.Id);
            FrameWorkHelpers.SelectByValue("1916", yeardropId, IdentifierType.Id);
        }
        internal void ClickOnMonthDrop()
        {

            FrameWorkHelpers.ClickElement(monthDropXpath, IdentifierType.XPath);
            FrameWorkHelpers.SelectByValue("January", monthDropXpath, IdentifierType.XPath);
        }
        internal void ClickOnDayDrop()
        {

            FrameWorkHelpers.ClickElement(dayDropId, IdentifierType.Id);
            FrameWorkHelpers.SelectByValue("4", dayDropId, IdentifierType.Id);
        }
        internal void SetTextInPassword(string password, bool clear = false)
        {
            if (clear)
            {
                FrameWorkHelpers.GetElement(passwordId, IdentifierType.Id).Clear();
            }
            FrameWorkHelpers.SetText(password, passwordId, IdentifierType.Id);
        }
        internal void SetTextInConfirmPassword(string confirmpassword, bool clear = false)
        {
            if (clear)
            {
                FrameWorkHelpers.GetElement(confirmpassword, IdentifierType.Id).Clear();
            }
            FrameWorkHelpers.SetText(confirmpassword, confirmpasswordId, IdentifierType.Id);
        }
        internal void ClickOnsubmitButton()
        {

            FrameWorkHelpers.ClickElement(submitButtonId, IdentifierType.Id);
        }

    }
}
    





