using HomeworkPOM.Models;
using HomeworkPOM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class AutomationPractice : BasePage

    {


        public AutomationPractice(WebDriver driver2)
            : base(driver2)
        {
        }


        public void FillEmail(AutomationPracticeFromModel user)
        {
            EmailSectionOnCheateAccount.SetText(user.Email);

        }
        public void FillForm(AutomationPracticeFromModel user)
        {
            SignInButton.Click();
            WaitForLoad();
            EmailSectionOnCheateAccount.Click();
            FillEmail(user);
            WaitForLoad();
            CreateAccountButton.Click();
            WaitForLoad();
            LastNamePanel.SetText(user.LastNamePanel + Keys.Tab);
            FirstNamePanel.SetText(user.FirstNamePanel + Keys.Tab);
            PasswordPanel.SetText(user.PasswordPanel + Keys.Tab);
            AddressPanel.SetText(user.AddressPanel + Keys.Tab);
            CityPanel.SetText(user.CityPanel + Keys.Tab);
            IdStatePanel.SetText(user.IdStatePanel + Keys.Tab);
            PhoneMobile.SetText(user.PhoneMobile + Keys.Tab);
            PosteCodePanel.SetText(user.PosteCodePanel + Keys.Tab);

        }

    }
}


