using HomeworkPOM.Factories;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework.Interfaces;

namespace HomeworkPOM.Tests.DemoQA05
{
    public class Sortable : BaseTest
    {

        private DemoQA _demoQA;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/");
            _demoQA = new DemoQA(Driver);
            _demoQA.ScrollTo(_demoQA.InteractionsButton).Click();
            _demoQA.ScrollTo(_demoQA.Sortable).Click();

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
        public void sortableFirstGoToEnd()
        {
            _demoQA.DropOnTarget(_demoQA.FirstListElement, _demoQA.SortableBanner);
            string msg = "Two";

            _demoQA.WaitForLoad();
            _demoQA.DroppedOnTarget(_demoQA.FirstListElement, msg);

        }

        [Test]
        public void sortableFiveGoFirst()
        {
            _demoQA.Scroll(Driver);
            _demoQA.DropOnTarget(_demoQA.FiveListElement, _demoQA.SortableHeadline);
            _demoQA.WaitForLoad();

            string msg = "Five";
            _demoQA.DroppedOnTarget(_demoQA.FirstListElement, msg);


        }


    }
}

