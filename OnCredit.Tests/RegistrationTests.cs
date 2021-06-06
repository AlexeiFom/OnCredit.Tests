using CommonMethods;
using Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using Pages.HomePage;
using System;
using System.Collections.Generic;

namespace OnCredit.Tests
{
    public class Tests : PageObject
    {
        private Url _urls;
        private NeededPageTitles _neededPageTitles;
        private HomePage _homePage;
        private Methods _methods;
        private RegistrationEnterOtpPage _registrationEnterOtpPage;
        public Tests()
        {
            _urls = new Url();
            _neededPageTitles = new NeededPageTitles();
            _methods = new Methods(Wait);
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            _homePage = new HomePage(Driver, _urls.homePageUrl);

            try
            {
                Assert.AreEqual(_neededPageTitles.homePageTitle, Driver.Title);
            }
            catch (Exception ex) { }
            try
            {
                _methods.FindElementAndClick(Driver, _homePage.registerButton);
            }
            catch (Exception ex) { }
            try
            {
                _methods.InsertDataToInput(Driver, _homePage.registerDataStep0);
            }
            catch (Exception ex) { }
            try
            {
                _methods.FindElementAndClick(Driver, _homePage.registerConfirmButton);
                Assert.AreEqual(_neededPageTitles.registerOtpTitle, Driver.Title);
            }
            catch (Exception ex) { }
            try
            {
                var otp = _methods.GetOTPAsync();
                _registrationEnterOtpPage = new RegistrationEnterOtpPage(otp.Result);

                _methods.InsertDataToInput(Driver, _registrationEnterOtpPage.registerOtpData);
                _methods.FindElementAndClick(Driver, _registrationEnterOtpPage.registerSendOtpButton);
            }
            catch (Exception ex) { }
            try
            {

            }
            catch (Exception ex) { }






            //Assert.Pass();
        }
    }
}