using NUnit.Framework;
using SeleniumNunitFramework.PageObject;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestCases
{
    public class FraudFilterTest: BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]

        public void VerifyFraudFilterTest(string email, string password)
        {
            FraudFilterPage fraudPage = new FraudFilterPage();
            fraudPage.FraudFilterFC(email, password);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {

            yield return new TestCaseData(getDataReader().GetTestData("validAdminEmail"), getDataReader().GetTestData("validAdminPassword"));

        }
    }
}
