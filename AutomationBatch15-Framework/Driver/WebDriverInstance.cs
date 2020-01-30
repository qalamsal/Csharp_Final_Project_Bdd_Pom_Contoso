using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationBatch15_Framework.Driver
{
    public static class WebDriverInstance
    {

        private static IWebDriver driver;

        public static IWebDriver GetInstanceOfDriver()
        {
            // Checks whether browser is open or not
            if(driver == null)
            {
                // Opens the browser
                driver = new ChromeDriver();
                // Navigates to the homepage
                driver.Navigate().GoToUrl("http://automationpractice.com");
            }

            return driver;
        }

        // Closes the webdriver
        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }

    }
}
