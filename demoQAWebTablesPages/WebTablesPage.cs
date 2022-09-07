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
    public class WebTablesPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "addNewRecordButton")]
        private IWebElement addNewRecordButton;

        [FindsBy(How = How.Id, Using = "searchBox")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[1]")]
        private IWebElement firstNameTable;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[2]")]
        private IWebElement lastNameTable;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[3]")]
        private IWebElement ageTable;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[4]")]
        private IWebElement emailTable;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[5]")]
        private IWebElement salaryTable;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[6]")]
        private IWebElement departamentTable;

        public WebTablesPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public NewRecordPage newRecordPage()
        {
            addNewRecordButton.Click();
            return new NewRecordPage();
        }

        public WebTablesPage serachRecord()
        {
            searchBox.SendKeys(TestDataDemoQA.EMAIL);
            return this;
        }

        public string getFirstName()
        {
            return firstNameTable.Text;
        }

        public string getLastName()
        {
            return lastNameTable.Text;
        }

        public string getAge()
        {
            return ageTable.Text;
        }

        public string getEmail()
        {
            return emailTable.Text;
        }

        public string getSalary()
        {
            return salaryTable.Text;
        }

        public string getDepartament()
        {
            return departamentTable.Text;
        }

    }
}
