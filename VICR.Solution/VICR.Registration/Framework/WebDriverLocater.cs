using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICR.Registration.Framework
{
    public class WebDriverLocater
    {
        public static RemoteWebDriver CreateDriver()
        {
            RemoteWebDriver driver = null;

            var browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

                case "Edge":
                    driver = new EdgeDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            
            return driver;
        }
    }
}
