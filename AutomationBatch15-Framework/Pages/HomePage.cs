using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationBatch15_Framework.Pages
{
    class HomePage
    {
        IWebDriver driver;

        /*** Locating elements ***/

        [FindsBy(How = How.Id, Using = "search_query_top")]
        private IWebElement searchTxtBox;

        [FindsBy(How = How.Name, Using = "submit_search")]
        private IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"contact - link\"]/a")]
        private IWebElement contactBtn;

        /*** ----------------- ***/

        public HomePage(IWebDriver newdriver)
        {
            // Setting the driver of this class
            driver = newdriver;

            // Locates web elements with Finds By annotations
            PageFactory.InitElements(driver, this);
        }

        public SearchPage Search(string searchText)
        {
            searchTxtBox.SendKeys(searchText);
            searchBtn.Click();

            // Since we reach to a new page we initialized that page
            SearchPage searchPage = new SearchPage(driver);
            return searchPage;
        }

        public ContactPage GoToContactPage()
        {
            contactBtn.Click();

            // Since we reach to a new page we initialized that page
            var contactPage = new ContactPage(driver);
            return contactPage;
        }

    }
}
