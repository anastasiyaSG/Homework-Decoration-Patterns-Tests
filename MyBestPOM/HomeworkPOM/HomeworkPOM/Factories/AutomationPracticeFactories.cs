using HomeworkPOM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Factories
{
    public static class AutomationPracticeFactories
    {
        public static AutomationPracticeFromModel Create()
        {
            return new AutomationPracticeFromModel
            {
                Email= "peshka@abv.bg",
                FirstNamePanel="Pesh",
                LastNamePanel ="Goshov",
                PasswordPanel = "heyhey",
                AddressPanel = "Main str",
                CityPanel = "Alabama",
                IdStatePanel = "Alabama",
                PhoneMobile = "2736726782637826",
                PosteCodePanel = "00000"


        };


        }
    }
}
