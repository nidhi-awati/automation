using NUnit.Framework;
using SeleniumNunitFramework.PageObject;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestCases
{
    public class LocationRecommendedTest:BaseSetup

    {
        [Test]
        [TestCaseSource(nameof(GetTestDatas))]
        public void VerifyLocationRecommendedTest(string email, string password)
        {
            LocationRecommendedPage locationPage = new LocationRecommendedPage();
            locationPage.LocationRecommendedFC(email, password);
            Thread.Sleep(10000);

        }
        public static IEnumerable<TestCaseData> GetTestDatas()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validAdminEmail"), getDataReader().GetTestData("validAdminPassword"));


        }
    }
}
