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
    public class SwitchBusineTest : BaseSetup
    {

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifySwitchBusinePage(string email, string pass, string businessname)
        {
            SwitchBusinePage SwitchPage = new SwitchBusinePage();
            SwitchPage.SwitchBusin(email, pass, businessname);
            Thread.Sleep(10000);

        }


            public static IEnumerable<TestCaseData> GetTestData()
            {

                yield return new TestCaseData(getDataReader().GetTestData("collogin"), getDataReader().GetTestData("colpassword"), getDataReader().GetTestData("buziname"));

            }

       


    }
}