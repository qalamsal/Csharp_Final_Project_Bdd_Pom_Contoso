using AutomationBatch15_Framework.Driver;
using AutomationBatch15_Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationBatch15_Framework.Test
{
    class AutomationPractice
    {
        IWebDriver driver;
        
        // Gets executed before every tests
        [SetUp]
        public void BaseSetup()
        {
            // Opening the browser and navigating to the homepage
            driver = WebDriverInstance.GetInstanceOfDriver();
        }

        // Test Method
        [Test]
        public void ValidateTshirtSearch()
        {
            // Initializing the homepage
            var homePage = new HomePage(driver);

            // Search method returns a search page
            SearchPage searchPage = homePage.Search("tshirt");

            // Getting the result text from the search page
            string result = searchPage.GetResultText();

            //Validating the result text
            Assert.AreEqual("0 results have been found.", result);
        }

        [Test]
        public void ValidateContactLink()
        {
            var homePage = new HomePage(driver);

        }

        [TearDown]
        public void BaseTeardown()
        {
            // Closing the browser
            WebDriverInstance.CloseDriver();
        }



    }
}
