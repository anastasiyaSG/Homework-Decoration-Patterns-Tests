using HomeworkPOM.Factories;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeworkPOM.Tests.DemoQA05
{
   public class Droppable : BaseTest
    {
        
        private DemoQA _demoQA;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/");
            _demoQA = new DemoQA(Driver);
            _demoQA.ScrollTo(_demoQA.InteractionsButton).Click();
            _demoQA.ScrollTo(_demoQA.Dropable).Click();

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
        public void DropElementWriteCorrectMsgOfTarget_When_DragAndDropDragMe()
        {
            
           _demoQA.DropOnTarget(_demoQA.DragMe, _demoQA.DropHere);
           

            string msg = "Dropped!";
            _demoQA.DroppedOnTarget(_demoQA.DropHere,msg);

          
        }

        [Test]
        public void DropHereElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            var colorBefore = _demoQA.DropHere.GetCssValue("background-color");

            _demoQA.DropOnTarget(_demoQA.DragMe, _demoQA.DropHere);
            _demoQA.WaitForLoad();
            var colorAfter = _demoQA.DropHere.GetCssValue("background-color");
            
            _demoQA.DroppedOnTargetColorCheck(colorBefore, colorAfter);

        }

        [Test]
        public void DropedElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
            var colorBefore = _demoQA.DragMe.GetAttribute("background-color");

            _demoQA.DropOnTarget(_demoQA.DragMe, _demoQA.DropHere);
            _demoQA.WaitForLoad();
            var colorAfter = _demoQA.DragMe.GetAttribute("background-color");
            
            _demoQA.DragBoxBackgroundColorIsSame(colorBefore, colorAfter);

        }

    }
}

