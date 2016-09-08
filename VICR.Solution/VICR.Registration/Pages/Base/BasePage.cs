using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VICR.Registration.Framework;

namespace VICR.Registration.Pages.Base
{
    public abstract class BasePage
    {
        protected RemoteWebDriver Driver;

        public void InitDriver(RemoteWebDriver d)
        {
            Driver = d;
        }

        protected bool IsElementPresent(By element)
        {
            bool elementExists = false;
            try
            {
                Driver.FindElement(element);
                elementExists = Driver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {

            }
            return elementExists;
        }

        protected bool WaitForElement(By element, int secondsToWait)
        {
            int count = 0;
            bool isElementAvailable = IsElementPresent(element);
            if (isElementAvailable.Equals(false))
            {
                do
                {
                    Thread.Sleep(1000);
                    count++;
                    isElementAvailable = IsElementPresent(element);
                    if (isElementAvailable.Equals(true) || count == secondsToWait)
                    {
                        break;
                    }
                } while (true);
            }
            return isElementAvailable;
        }

        protected void SelectValueFromDropDown(By element, string valueToBeSelected, bool setByValue = false)
        {
            var select = new SelectElement(Driver.FindElement(element));
            if (setByValue)
                select.SelectByValue(valueToBeSelected);
            else
                select.SelectByText(valueToBeSelected);
        }

        public void Dispose()
        {
            if (Driver != null) { 
                Driver.Dispose();
            }
        }
    }
}
