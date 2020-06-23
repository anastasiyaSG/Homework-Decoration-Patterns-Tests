using HomeworkPOM.Factories;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Tests.GoogleSearch01
{
   public class NameOfCourse : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate("https://softuni.bg/");
        }
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var sceenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                sceenshot.SaveAsFile($"{TestContext.CurrentContext.Test.FullName}", ScreenshotImageFormat.Png);
            }

            Driver.WrappedDriver.Quit(); }

        [Test]

        public void CheckHeadlingOfCourse()
        { SoftUni softUni = new SoftUni(Driver);


            softUni.LearningsFromNavigationBar.Click();
            softUni.WaitForLoad();
            softUni.ActiveCourses.Click();
            softUni.QAModul.Click();
            softUni.ScrollTo(softUni.QAAUtomationCourse);
            softUni.QAAUtomationCourse.Click();

            softUni.AssertHeadlineCourse(softUni.HeadlineCourse);

            
        }

        
    }
}
