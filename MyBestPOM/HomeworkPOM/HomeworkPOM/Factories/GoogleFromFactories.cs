using HomeworkPOM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Factories
{
    public static class GoogleFromFactories
    {
        public static GoogleFromModel Create()
        {
            return new GoogleFromModel
            {
                SearchWord = "Selenium"
            };


        }
    }
}
