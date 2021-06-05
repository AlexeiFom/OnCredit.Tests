using OpenQA.Selenium;
using System;

namespace CommonMethods
{
    public class Methods
    {
        private IWebDriver _driver;

        public Methods(IWebDriver driver)
        {
            _driver = driver;
        }

        //public bool IsCurrectPage()
        //{
        //    return true;
        //}
    }
}
