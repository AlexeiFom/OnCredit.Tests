using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnCredit.Tests
{
    public class PageObject
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PageObject()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            Driver.Manage().Window.Maximize();
        }
    }
}
