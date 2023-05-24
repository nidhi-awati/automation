using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNunitFramework.PageObject;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SeleniumNunitFramework.TestCases
{
    public class OmsLogin : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestDatas))]
        public void VerifyFcPackgingManagerLogin(string email, string pass)
        {
            OmsLoginPage LandingPage = new OmsLoginPage();
            LandingPage.Login(email, pass);
            Thread.Sleep(10000);

        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifyFcPackgingManagerInvalidLogin(string email, string pass)
        {
            OmsLoginPage LandingPage = new OmsLoginPage();
            LandingPage.Login(email, pass);
            Thread.Sleep(10000);

        }



        public static IEnumerable<TestCaseData> GetTestData()
        {
         
                yield return new TestCaseData(getDataReader().GetTestData("invalidPackmanID"), getDataReader().GetTestData("invalidPackmanPassword"));

        }

        public static IEnumerable<TestCaseData> GetTestDatas()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validPackmanID"), getDataReader().GetTestData("validPackmanPassword"));


        }


    }

}
