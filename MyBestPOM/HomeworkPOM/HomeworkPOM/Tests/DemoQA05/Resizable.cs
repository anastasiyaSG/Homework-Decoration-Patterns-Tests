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
    public class Resizable : BaseTest
    {

        private DemoQA _demoQA;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.GoToUrl("http://demoqa.com/");
            _demoQA = new DemoQA(Driver);
            _demoQA.ScrollTo(_demoQA.InteractionsButton).Click();
            _demoQA.ScrollTo(_demoQA.Resizable).Click();

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
        public void ElementSizeIsMaximum()
        {
            Thread.Sleep(1000);
            _demoQA.ResizeOffset(_demoQA.ResizeArrow, 300, 150);

            
            int resizedX = _demoQA.ResizableBox.Size.Width;
            int resizedY = _demoQA.ResizableBox.Size.Height;
            _demoQA.CheckDimensionsOfResizing(500, resizedX, 300, resizedY);


        }


        [Test]
        public void ResizeUnlimited()
        {



            int expectedWidth = _demoQA.Box.Size.Width + 100;
            int expectedHeight = _demoQA.Box.Size.Height + 100;

            _demoQA.Scroll(Driver);
            _demoQA.ResizeOffset(_demoQA.ResizeUnlimitedArrow, 100, 100);

            int actualWidth = _demoQA.Box.Size.Width;
            int actualHeight = _demoQA.Box.Size.Height;
            _demoQA.CheckDimensionsOfResizing(expectedWidth, actualWidth, expectedHeight, actualHeight);



        }

    }
}

