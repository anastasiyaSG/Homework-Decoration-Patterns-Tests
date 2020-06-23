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
    public partial class GooglePageTry: BasePage

    {
        
        
        public GooglePageTry (WebDriver driver2)
            :base(driver2)
        {
        }
       
        public void FillGoogleSearch(GoogleFromModel user)
        {
            SearchPanel2.SetText(user.SearchWord + Keys.Enter);

        }
    }

}
