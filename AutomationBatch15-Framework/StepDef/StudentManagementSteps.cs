using AutomationBatch15_Framework.Driver;
using AutomationBatch15_Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationBatch15_Framework
{
    [Binding]
    public class StudentManagementSteps
    {
       IWebDriver driver;
        StudentPage studentPage;
        
        [Before]
        public void BaseSetup()
        {
            // Opening the browser and navigating to the homepage
            driver = WebDriverInstance.GetInstanceOfDriver();
            studentPage= new StudentPage(driver);

        }

        [Given(@"User is in student menu")]
        public void GivenUserIsInStudentMenu()
        {
            
            studentPage.navigateStudentsmenu();
        }
        
        [When(@"User clicks on new student link")]
        public void WhenUserClicksOnNewStudentLink()
        {
            studentPage.clickCreateNew();
            
        }
        
        [When(@"User enters last name")]
        public void UserEntersLastName() {
            studentPage.enterLastName();
        }

        [When(@"User enters first name")]
        public void WhenUserEntersFirstName()
        {
            studentPage.enterFirstName();
        }
        
        [When(@"User enters enrollment date")]
        public void WhenUserEntersEnrollmentDate()
        {
            studentPage.enterEnrollmentDate();
        }
        
        [When(@"User click on create button")]
        public void WhenUserClickOnCreateButton()
        {
            studentPage.clickCreateButton();
        }
        
        [Then(@"User verifies create heading")]
        public void ThenUserVerifiesCreateHeading()
        {
            Assert.IsTrue(studentPage.isHeadingDisplayed());
        }

        [After]
        public void close()
        {
            // Opening the browser and navigating to the homepage
            driver.Quit();
        }

    }
}
