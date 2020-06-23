using HomeworkPOM.Factories;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Interfaces;

namespace HomeworkPOM.Tests.DemoQA05
{
   public class Draggable : BaseTest
    {
        private DemoQA _demoQA;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate("http://demoqa.com/");
            _demoQA = new DemoQA(Driver);
            _demoQA.ScrollTo(_demoQA.InteractionsButton).Click();
            _demoQA.ScrollTo(_demoQA.Draggable).Click();

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
        public void ElementYIsSame_When_DragAndDropOnlyXDiagonally()
        {
          _demoQA.AxisRestrictedTab.Click();
            int yBefore = _demoQA.OnlyXBox.Location.Y;

           _demoQA.DraggableDragAndDrop(_demoQA.OnlyXBox);
            int yAfter =  _demoQA.OnlyXBox.Location.Y;

            _demoQA.ElementYIsSame(yBefore, yAfter);

        }
        [Test]
        public void ElementXIsSame_When_DragAndDropOnlyYDiagonally()
        {

            
            _demoQA.AxisRestrictedTab.Click();
            int yBefore = _demoQA.OnlyYBox.Location.X;

            _demoQA.DraggableDragAndDrop(_demoQA.OnlyYBox);
            int yAfter = _demoQA.OnlyYBox.Location.X;

            _demoQA.ElementYIsSame(yBefore, yAfter);
           
        }

        [Test]
        public void dragToCenterLogo()
        {
            int dragBoxXbefore = _demoQA.DragBox.Location.X;

            _demoQA.DraggableDragAndDropToTarget(_demoQA.DragBox, _demoQA.CenterTarget);
            int dragBoxXAfter = _demoQA.DragBox.Location.X;

            _demoQA.ElementIsNotOnSamePlace(dragBoxXbefore, dragBoxXAfter);

        }

    }
}

