using NUnit.Framework;
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
    internal class PickerTest : BaseSetup
    {
        /*[Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifyPickerCanPickStock(string email, string pass)
        {
            PickerAssignmentPage PickerAtFc = new PickerAssignmentPage();
            PickerAtFc.PicklistAssignmentPage(email, pass);
            Thread.Sleep(2000);

        }*/

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validPickerID"), getDataReader().GetTestData("validPickerPassword"));

        }

    }
}
