using HomeworkPOM.Factories;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeworkPOM.Tests.GoogleSearch01
{
   public class AutomationPracticeRegistrationValidMail : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate("http://automationpractice.com/index.php");
        }
        [TearDown]
        public void TearDown()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var sceenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                sceenshot.SaveAsFile($"{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.WrappedDriver.Quit(); }

        [Test]

        public void AutomationPracticeValidEmail()
        {
            AutomationPractice automationPractice = new AutomationPractice(Driver);
            automationPractice.SignInButton.Click();

            var user = AutomationPracticeFactories.Create();
            automationPractice.WaitForLoad();
            automationPractice.EmailSectionOnCheateAccount.Click();
            automationPractice.FillEmail(user);
            automationPractice.CreateAccountButton.Click();

            Thread.Sleep(10000);
            automationPractice.WaitForLoad();
            automationPractice.AssertCorrectEmailDisplay(automationPractice.EmailBannerOnRegistrationForm);
  
        }

        
    }
}
