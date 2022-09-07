using demoQATestsDotNet.core;
using demoQATestsDotNet.settings;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoQATestsDotNet.demoQAWebTablesPages
{
    public class NewRecordPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstNameInput;

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastNameInput;

        [FindsBy(How = How.Id, Using = "userEmail")]
        private IWebElement userEmailInput;

        [FindsBy(How = How.Id, Using = "age")]
        private IWebElement ageInput;

        [FindsBy(How = How.Id, Using = "salary")]
        private IWebElement salaryInput;

        [FindsBy(How = How.Id, Using = "department")]
        private IWebElement departmentInput;

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement submitButton;

        public NewRecordPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public WebTablesPage addNewRecord()
        {
            firstNameInput.SendKeys(TestDataDemoQA.FIRST_NAME);
            lastNameInput.SendKeys(TestDataDemoQA.lAST_NAME);
            userEmailInput.SendKeys(TestDataDemoQA.EMAIL);
            ageInput.SendKeys(TestDataDemoQA.AGE);
            salaryInput.SendKeys(TestDataDemoQA.SALARY);
            departmentInput.SendKeys(TestDataDemoQA.DEPARTAMENT);

            submitButton.Click();

            return new WebTablesPage();
        }
    }
}
