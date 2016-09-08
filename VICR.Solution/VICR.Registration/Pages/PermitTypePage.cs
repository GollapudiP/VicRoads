using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICR.Registration.Pages
{
    public class PermitTypePage : Base.BasePage
    {      
        string _xpathPermitType = "//label[contains(text(),'{0}')]";
        By _nextButton = By.XPath("//input[contains(@id,'btnNext')]");  
        
        public void EnterPermitType(string permitType)
        {
            Driver.FindElement(By.XPath(string.Format(_xpathPermitType, permitType))).Click();
        }

        public void SubmitAndGoToNextPage()
        {
            Driver.FindElement(_nextButton).Click();
        }
    }
}
