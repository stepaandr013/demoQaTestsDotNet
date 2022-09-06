using demoQATestsDotNet.core;
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

        public WebTablesPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public NewRecordPage newRecordPage()
        {
            addNewRecordButton.Click();
            return new NewRecordPage();
        }
    }
}
