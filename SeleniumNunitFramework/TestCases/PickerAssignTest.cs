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
    [Parallelizable(ParallelScope.Children)]
    public class PickerAssignTest:BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestDatas))]     //To read test data
        public void VerifyPickerAssign(string email,string password)
        {
            //Execute TestCases
            AssignPickerPage pickerPage = new AssignPickerPage();
            pickerPage.AssignPickerFc(email, password);

        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]   //To read test data
        public void VerifySearchFunctionality(string email,string password,string picklistid)
        {
            //Execute TestCases
            AssignPickerPage searchPickidPage = new AssignPickerPage();
            searchPickidPage.PickerSearchPicklist(email, password, picklistid);
        }

        [Test]
        [TestCaseSource(nameof(GetTestDatass))]   //To read test data

        public void VerifyPicklisttype(string email,string password)
        {
            //Execute TestCases
            AssignPickerPage fleetTypePage = new AssignPickerPage();
            fleetTypePage.PicklistFleetType(email, password);

        }

        [Test]
        [TestCaseSource(nameof(GetTestDatas))]    ////To read test data

        public void VerifySearchFunctionalityProcessed(string email,string password,string SearchProcessed)
        {
            //Execute TestCases
            AssignPickerPage searchPickidProcessedPage = new AssignPickerPage();
            searchPickidProcessedPage.PickerSearchPicklistProcessed(email, password, SearchProcessed);

        }



        public static IEnumerable<TestCaseData> GetTestDatas()  //To fetch data from TestDatajson
        {
            yield return new TestCaseData(getDataReader().GetTestData("validPackmanID"), getDataReader().GetTestData("validPackmanPassword"));

        }



        public static IEnumerable<TestCaseData> GetTestData()  //To fetch data from TestDatajson
        {

            yield return new TestCaseData(getDataReader().GetTestData("validPackmanID"), getDataReader().GetTestData("validPackmanPassword"), getDataReader().GetTestData("pickid"));

        }


        public static IEnumerable<TestCaseData> GetTestDatass()    //To fetch data from TestDatajson
        {

             yield return new TestCaseData(getDataReader().GetTestData("validPackmanID"), getDataReader().GetTestData("validPackmanPassword"));

         }
        
        public static IEnumerable<TestCaseData> GetTestDatasss()  //To fetch data from TestDatajson
        {

            yield return new TestCaseData(getDataReader().GetTestData("validPackmanID"), getDataReader().GetTestData("validPackmanPassword"), getDataReader().GetTestData("picklistidprocessed"));

        }

    }
    }
