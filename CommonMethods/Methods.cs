using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Net.Http;

//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;
////using SeleniumExtras.WaitHelpers;
//using System;

namespace CommonMethods
{
    public class Methods
    {
        public WebDriverWait _wait;

        public Methods(WebDriverWait wait)
        {
            _wait = wait;
        }
        public void FindElementAndClick(IWebDriver driver, By elem)
        {
            try
            {
                var rrr = driver.FindElement(elem);

                driver.FindElement(elem).Click();
            }
            catch (Exception ex) { }
        }

        public void InsertDataToInput(IWebDriver driver, Dictionary<By, string> elements)
        {
            try
            {
                foreach (var item in elements)
                {
                   //var res = _wait.Until(ExpectedConditions.ElementExists);

                        var input = driver.FindElement(item.Key);
                    input.SendKeys(item.Value);
                }
            }
            catch (Exception ex) { }
        }

        public async System.Threading.Tasks.Task<string> GetOTPAsync()
        {
            var resultToParse = string.Empty;

            using (var client = new HttpClient())
            {
                var response = client.GetAsync("http://192.168.3.102:8181/Development/GetOtp?phone=+84838665230").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    resultToParse = responseContent.ReadAsStringAsync().Result;
                }
            }
            var otp = resultToParse.Trim(new Char[] { ' ', '"' });

            return otp;
        }

    }
}
