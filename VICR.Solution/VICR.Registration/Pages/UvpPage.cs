using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VICR.Registration.Pages
{
    public class UvpPage : Base.BasePage
    {
        By _stepHeader = By.XPath("//div[@id='main']//p");
        By _vehicleType = By.XPath("//select[contains(@id,'VehicleType_DDList')]");
        By _passengerVehicleType = By.XPath("//select[contains(@id,'PassengerVehicleType_DDList')]");
        By _address = By.XPath("//div[@id='divAddressLine']//input");
        By _permitStartDate = By.XPath("//input[contains(@id,'PermitStartDate_Date')]");
        By _permitDuration = By.XPath("//select[contains(@id,'PermitDuration_DDList')]");
        By _nextButton = By.XPath("//input[contains(@id,'btnNext')]");

        public bool Show()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["AppUrl"]);
            return Driver.FindElement(_stepHeader).Text.Contains("Step 1 of 7 : Calculate fee");
        }

        public void EnterVehicleType(string valueToBeSelected)
        {
            SelectValueFromDropDown(_vehicleType, valueToBeSelected);
        }

        public void EnterPassengerVehicleType(string valueToBeSelected)
        {
            SelectValueFromDropDown(_passengerVehicleType, valueToBeSelected);
        }

        public void EnterAddress(string address)
        {
            Driver.FindElement(_address).SendKeys(address);
        }

        public void EnterPermitStartDate(DateTime date)
        {
            Driver.FindElement(_permitStartDate).SendKeys(date.ToString("dd/MM/yyyy"));
        }

        public void EnterPermitDuration(string valueToBeSelected)
        {
            SelectValueFromDropDown(_permitDuration, valueToBeSelected,true);
        }

        public void SubmitAndGoToNextPage()
        {
            if (WaitForElement(_nextButton, 5000))
            {
                Driver.FindElement(_nextButton).Click();
            }
        }

    }
}
