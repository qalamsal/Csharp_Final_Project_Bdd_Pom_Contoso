using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationBatch15_Framework.Pages
{
    class StudentPage
    {
        IWebDriver driver;
       
        [FindsBy(How = How.Id, Using = "search_query_top")]
        private IWebElement searchTxtBox;

        [FindsBy(How=How.XPath, Using="//a[text()='Students']")]
        private IWebElement studentsMenu;


        [FindsBy(How=How.XPath, Using= "/html/body/div/p/a")]
        private IWebElement lnkCreateNew;

        //Create Heading
        [FindsBy(How=How.XPath,Using="//h2[text()='Create']")]
        private IWebElement headingCreate;

        //Students Info
        [FindsBy(How = How.Id, Using="LastName")]
        private IWebElement lastName;

        [FindsBy(How=How.Id,Using="FirstMidName")]
        private IWebElement firstName;

       

        [FindsBy(How=How.Id,Using = "EnrollmentDate")]
        IWebElement enrollmentDate;

        [FindsBy(How=How.XPath,Using = "//input[@class='btn btn-default']")]
        IWebElement createButton;

        
        /*** ----------------- ***/

        public StudentPage(IWebDriver newdriver)
        {
            // Setting the driver of this class
           driver = newdriver;

            // Locates web elements with Finds By annotations
            PageFactory.InitElements(driver, this);
        }

        public void navigateStudentsmenu()
        {
            studentsMenu.Click();
        }

        public void clickCreateNew()
        {
            lnkCreateNew.Click();
        }

        public void enterLastName()
        {
            lastName.SendKeys("Lamsal");
        }

        public void enterFirstName()
        {
            firstName.SendKeys("Sandesh");
        }

        public bool isHeadingDisplayed()
        {
            return headingCreate.Displayed;
        }

        public void enterEnrollmentDate()
        {
            enrollmentDate.SendKeys("01-01-2001");
        }

        public void clickCreateButton()
        {
            createButton.Click();
        }


    }
}
