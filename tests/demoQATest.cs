﻿using demoQATestsDotNet.core;
using demoQATestsDotNet.demoQAWebTablesPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoQATestsDotNet.tests
{
    internal class demoQATest : BaseTest
    {
        [Test]
        public void TestWebTable()
        {
            new MainPage()
                .goToElements();
        }
    }
}