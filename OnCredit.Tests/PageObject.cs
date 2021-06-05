using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnCredit.Tests
{
    public class PageObject
    {
        public IWebDriver Driver { get; set; }

        public PageObject()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }
    }
}
