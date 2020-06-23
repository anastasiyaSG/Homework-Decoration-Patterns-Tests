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
    public class Selectable : BaseTest
    {

        private DemoQA _demoQA;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/");
            _demoQA = new DemoQA(Driver);
            _demoQA.ScrollTo(_demoQA.InteractionsButton).Click();
            _demoQA.ScrollTo(_demoQA.Selectable).Click();

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
        public void selectableClickOnList()
        {

            var colorBefore = _demoQA.FirstBox.GetCssValue("color");

            _demoQA.FirstBox.Click();
            var colorAfter = _demoQA.FirstBox.GetCssValue("color");

            _demoQA.DroppedOnTargetColorCheck(colorBefore, colorAfter);
        }

        [Test]
        public void selectableDoubleClickOnList()
        {
            var colorBefore = _demoQA.FirstBox.GetAttribute("color");

            Builder.DoubleClick().Perform();
            var colorAfter = _demoQA.FirstBox.GetAttribute("color");

            _demoQA.DragBoxBackgroundColorIsSame(colorBefore, colorAfter);
        }



    }
}

