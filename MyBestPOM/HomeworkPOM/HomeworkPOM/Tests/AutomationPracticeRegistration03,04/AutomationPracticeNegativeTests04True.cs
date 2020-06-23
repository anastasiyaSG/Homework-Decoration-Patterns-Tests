using HomeworkPOM.Factories;
using HomeworkPOM.Models;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeworkPOM.Tests.GoogleSearch01
{
    public class AutomationPracticeNegativeTests04True : BaseTest
    {

        private AutomationPractice _practiceFormPage;
        private AutomationPracticeFromModel _user;
        [SetUp]
        public void Setup()
        {


            Initialize();
            Driver.Navigate("http://automationpractice.com/index.php/");
            _practiceFormPage = new AutomationPractice(Driver);
            _user = AutomationPracticeFactories.Create();



        }
        [TearDown]
        public void TearDown()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var sceenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                sceenshot.SaveAsFile($"{TestContext.CurrentContext.Test.FullName}", ScreenshotImageFormat.Png);
            }


            Driver.WrappedDriver.Quit();
        }

        [Test]
        public void RegisterWithoutFirstName()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();


            automationPractice.FillForm(user);
            automationPractice.FirstNamePanel.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "firstname is required.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }

        [Test]
        public void RegisterWithNoPasword()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PasswordPanel.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "passwd is required.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }
        [Test]
        public void RegisterNumberLetterZipcode()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PosteCodePanel.Clear();
            automationPractice.PosteCodePanel.SetText("981AB");
            automationPractice.RegisterButton.Click();

            string msg = "The Zip/Postal code you've entered is invalid. It must follow this format: 00000";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }

        [Test]
        public void RegisterWithoutPhoneNumber()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.PhoneMobile.Clear();
            automationPractice.RegisterButton.Click();

            string msg = "You must register at least one phone number.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }
        [Test]
        public void RegisterWithFirstNameStartWithSpace()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            var user = AutomationPracticeFactories.Create();

            automationPractice.FillForm(user);
            automationPractice.FirstNamePanel.Clear();
            automationPractice.FirstNamePanel.SetText(" Sulyo" + Keys.Tab);
            automationPractice.RegisterButton.Click();

            string msg = "firstname is required.";
            automationPractice.AssertAlertMessage(msg, automationPractice.AlertMessage);

        }

    }

       



}


