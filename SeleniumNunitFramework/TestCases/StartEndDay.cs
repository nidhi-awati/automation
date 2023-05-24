using MongoDB.Bson.Serialization.Serializers;
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
    public class StartEndDay : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifyOmsUserStartAndEndDay(string email, string pass)
        {
            StartEndDayPage NewStartDay = new StartEndDayPage();
            NewStartDay.StartDayPage(email, pass);
            //Thread.Sleep(15000);
        }


       /* [Test]
        [TestCaseSource(nameof(GetTestData))] 
        public void VerifyOmsUserStopDay(string email, string pass)
        {
            StartEndDayPage NewStopDay = new StartEndDayPage();
            NewStopDay.StopDayPage(email, pass);
            Thread.Sleep(1000);
        }*/

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validPickerID"), getDataReader().GetTestData("validPickerPassword"));

        }
    }

}
