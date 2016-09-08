using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VICR.Registration.Framework;

namespace VICR.Registration.Pages
{
    public class PageFactory
    {
        private static RemoteWebDriver _Driver;
        static PageFactory()
        {
            _Driver = WebDriverLocater.CreateDriver();
        }

        public static T Create<T>() where T : Base.BasePage, new()
        {
            T t1 = new T();
            t1.InitDriver(_Driver);

            return t1;
        }
    }
}
