using Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using Pages.HomePage;

namespace OnCredit.Tests
{
    public class Tests : PageObject
    {
        //private IWebDriver _driver;

        private Url _urls;
        private HomePage _homePage;
        public Tests()
        {
            _urls = new Url();
            //_homePage = new HomePage(Driver);
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var homePage = new HomePage(Driver);


            //Assert.Pass();
        }
    }
}