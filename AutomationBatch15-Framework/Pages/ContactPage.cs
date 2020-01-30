using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationBatch15_Framework.Pages
{
    class ContactPage
    {
        IWebDriver driver;

        public ContactPage(IWebDriver newdriver)
        {
            driver = newdriver;
        }

    }
}
