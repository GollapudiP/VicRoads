using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICR.Registration.Pages
{
    public class VehicleDetailsPage : Base.BasePage
    {
        By _stepHeader = By.XPath("//div[@id='main']//p");      

        public bool IsVehicleDetailsPageDisplayed()
        {
            return Driver.FindElement(_stepHeader).Text.Contains("Step 3 of 7 : Enter vehicle details");
        }
    }
}
