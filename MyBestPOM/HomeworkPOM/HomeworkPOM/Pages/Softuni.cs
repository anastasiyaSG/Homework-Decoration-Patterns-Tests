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
    public class SoftUni : BasePage

    {


        public SoftUni(WebDriver driver2)
            : base(driver2)
        {
        }
        public WebElement LearningsFromNavigationBar => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/a/span"));
        public WebElement HeadlineCourse => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));
        public WebElement QAAUtomationCourse => Driver.FindElement(By.CssSelector("body > div.content > div > section.container-holder.grey-container.no-padding.courses-in-module > div.text-center.center-block.col-md-12.no-float > div:nth-child(3) > div > a > div.box-content > h4"));
        public WebElement ActiveCourses => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[1]/i"));
        public WebElement QAModul => Driver.FindElement(By.XPath("/ html / body / div[1] / div[1] / header / nav / div[1] / ul / li[2] / div / div / div[2] / div[2] / div / div[1] / div[3] / div[2] / ul / li[1] / a"));


        public void AssertHeadlineCourse(WebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("QA Automation - май 2020", element.Text);
        }


    }

}
