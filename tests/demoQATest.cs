using demoQATestsDotNet.core;
using demoQATestsDotNet.demoQAWebTablesPages;
using demoQATestsDotNet.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoQATestsDotNet.tests
{
    internal class DemoQATest : BaseTest
    {
        [Test]
        public void TestWebTable()
        {
            WebTablesPage webTablesPage = new MainPage()
                .goToElements()
                .webTables()
                .newRecordPage()
                .addNewRecord()
                .serachRecord();

            Assert.AreEqual(TestDataDemoQA.FIRST_NAME, webTablesPage.getFirstName());
            Assert.AreEqual(TestDataDemoQA.lAST_NAME, webTablesPage.getLastName());
            Assert.AreEqual(TestDataDemoQA.AGE, webTablesPage.getAge());
            Assert.AreEqual(TestDataDemoQA.EMAIL, webTablesPage.getEmail());
            Assert.AreEqual(TestDataDemoQA.SALARY, webTablesPage.getSalary());
            Assert.AreEqual(TestDataDemoQA.DEPARTAMENT, webTablesPage.getDepartament());

        }
    }
}
