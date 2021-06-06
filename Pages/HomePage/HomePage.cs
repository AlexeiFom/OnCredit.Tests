using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.HomePage
{
    public class HomePage
    {
        private IWebDriver _driver;

        public By registerButton = By.XPath("//button[@id='main-slider-registration-button']");
        public By registerConfirmButton = By.XPath("//button[@id='submit-main-slider-button']");

        public By fullNameField = By.XPath("//input[@id='sername']");
        public By phoneNumberField = By.XPath("//input[@id='phone']");
        public By emailField = By.XPath("//input[@id='email']");

        public string fullNameInfo = "Test Test Test";
        public string phoneNumberInfo = "838665230";
        public string emailInfo = "a.fomin@mycredit.ua";

        public Dictionary<By, string> registerDataStep0 = new Dictionary<By, string>();

        public HomePage(IWebDriver driver, string url)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(url);

            registerDataStep0.Add(fullNameField, fullNameInfo);
            registerDataStep0.Add(phoneNumberField, phoneNumberInfo);
            registerDataStep0.Add(emailField, emailInfo);
        }
    }
}
