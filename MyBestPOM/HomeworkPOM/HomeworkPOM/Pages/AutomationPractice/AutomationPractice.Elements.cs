using HomeworkPOM.Models;
using HomeworkPOM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using StabilizeTestsDemos.ThirdVersion;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
    public partial class AutomationPractice : BasePage

    {
        public WebElement SignInButton => Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));

        public WebElement EmailSectionOnCheateAccount => Driver.FindElement(By.Id("email_create"));

        public WebElement CreateAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate"));

        public WebElement EmailBannerOnRegistrationForm => Driver.FindElement(By.CssSelector("#email"));

        public WebElement LastNamePanel => Driver.FindElement(By.Id("customer_lastname"));

        public WebElement FirstNamePanel => Driver.FindElement(By.Id("firstname"));

        public WebElement PasswordPanel => Driver.FindElement(By.Id("passwd"));

        public WebElement AddressPanel => Driver.FindElement(By.Id("address1"));

        public WebElement CityPanel => Driver.FindElement(By.Id("city"));

        public WebElement IdStatePanel => Driver.FindElement((By.Id("id_state")));

        public WebElement PhoneMobile => Driver.FindElement(By.Id("phone_mobile"));

        public WebElement PosteCodePanel => Driver.FindElement(By.Id("postcode"));

        public WebElement RegisterButton => Driver.FindElement(By.XPath("//*[@id='submitAccount']/span/i"));

        public WebElement AlertMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div"));





    }

}
