using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.HomePage
{
   public class RegistrationEnterOtpPage
    {
        public By registerOtpInput = By.XPath("//input[@id='sms-code']");
        public By registerSendOtpButton = By.XPath("//div[@id='div_code']/button[text='GỬI MÃ']");


        public Dictionary<By, string> registerOtpData = new Dictionary<By, string>();

        public RegistrationEnterOtpPage(string  otp)
        {
            registerOtpData.Add(registerOtpInput, otp);
        }
    }
}
