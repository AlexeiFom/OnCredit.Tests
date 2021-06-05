using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.HomePage
{
    public class HomePage
    {
        private IWebDriver _driver;





        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
