using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationBatch15_Framework.Pages
{
    class SearchPage
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/h1/span")]
        IWebElement resultTxt;

        public SearchPage(IWebDriver newdriver)
        {
            driver = newdriver;
            PageFactory.InitElements(driver, this);
        }

        public string GetResultText()
        {
            return resultTxt.Text;
        }

    }
}
