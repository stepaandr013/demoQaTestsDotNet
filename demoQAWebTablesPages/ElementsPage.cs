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
    public class ElementsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div")]
        private IWebElement title;

        [FindsBy(How = How.Id, Using = "item-3")]
        private IWebElement webTablesButton;

        public ElementsPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public WebTablesPage webTables()
        {
            Assert.AreEqual(title.Text, "Elements");
            webTablesButton.Click();
            return new WebTablesPage();
        }

    }
}
