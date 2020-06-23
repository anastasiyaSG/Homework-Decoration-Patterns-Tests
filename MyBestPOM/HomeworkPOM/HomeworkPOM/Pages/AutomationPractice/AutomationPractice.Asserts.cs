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

        public void AssertCorrectEmailDisplay(WebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("peshka@abv.bg", element.GetAttribute("value"));

        }
        public void AssertAlertMessage(string text, WebElement element)
        {

            this.WaitForLoad();
            StringAssert.Contains(text, element.Text);
        }   
    }

}
