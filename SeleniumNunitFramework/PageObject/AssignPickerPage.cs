using OpenQA.Selenium;
using SeleniumNunitFramework.TestSetup;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.PageObject
{
    public class AssignPickerPage :BaseSetup
    {
        //Collecting web elements and storing local variables
        By EmailField = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]");
        By PasswordField=By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By OrderMgntbtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[5]/a[1]/div[1]");
        By PickerAssignbtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[5]/div[1]/a[11]");
        By EllipseBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[2]/div[1]/div[10]/span[1]/*[name()='svg'][1]");
        By AssignPickerbtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]");
        By AssignToDropdownbtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/img[1]");
        By AssignBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/ul[1]/li[1]");
        By AssignedBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[2]/div[3]/div[1]");
        By CloseBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/button[1]");
        By Shipments = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]");
        By PicklistSearch = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]");
        By PicklistFleet = By.XPath("//a[normalize-space()='PickList FleetType']");
        By GenerateBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/button[1]/span[1]/p[1]");
       // By FleettypeBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]");
        //By VanDropBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[2]/input[1]");
        //By VanField = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[2]/input[1]");
        //By GenerateagnBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[6]/div[2]/button[1]");
        By ProcessedBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]");
        By SearchProcessed = By.XPath("//span[normalize-space()='Search']");
        By SearchInput = By.XPath("//input[@placeholder='Search']");

        public void AssignPickerFc(string email,string password)
        {
            //browser actions  to login
            BrowserActions.Type(EmailField, email);
            BrowserActions.Type(PasswordField, password);
            BrowserActions.Click(LoginBtn);
            Thread.Sleep(70000);
            BrowserActions.Click(OrderMgntbtn);
            BrowserActions.Click(PickerAssignbtn);
            BrowserActions.Click(EllipseBtn);
            BrowserActions.Click(AssignPickerbtn);
            BrowserActions.Click(AssignToDropdownbtn);
            BrowserActions.Click(AssignBtn);
            BrowserActions.Click(AssignedBtn);
            BrowserActions.Click(CloseBtn);

        }
        
        public void PickerSearchPicklist(string email,string password, string picklistid)
        {
            //browser actions  to login

            BrowserActions.Type(EmailField, email);
            BrowserActions.Type(PasswordField, password);
            BrowserActions.Click(LoginBtn);
            Thread.Sleep(70000);
            BrowserActions.Click(OrderMgntbtn);
            BrowserActions.Click(PickerAssignbtn);
            BrowserActions.Click(Shipments);
            BrowserActions.Type(PicklistSearch, picklistid);

        }

         public void PicklistFleetType(string email, string password)
         {
            //browser actions  to login

            BrowserActions.Type(EmailField, email);
             BrowserActions.Type(PasswordField, password);
             BrowserActions.Click(LoginBtn);
             Thread.Sleep(70000);
             BrowserActions.Click(OrderMgntbtn);
             BrowserActions.Click(PicklistFleet);
             BrowserActions.Click(GenerateBtn);
            // BrowserActions.Click(FleettypeBtn);
            // BrowserActions.Click(VanDropBtn);
            // BrowserActions.Type(VanField, van);
            // BrowserActions.Click(GenerateagnBtn);


         }
        public void PickerSearchPicklistProcessed(string email, string password, string picklistidprocessed)
        {
            //browser actions  to login

            BrowserActions.Type(EmailField, email);
            BrowserActions.Type(PasswordField, password);
            BrowserActions.Click(LoginBtn);
            Thread.Sleep(70000);
            BrowserActions.Click(OrderMgntbtn);
            BrowserActions.Click(PickerAssignbtn);
            BrowserActions.Click(ProcessedBtn);
            BrowserActions.Click(SearchProcessed);
            BrowserActions.Click(SearchInput);
            BrowserActions.Type(SearchInput, picklistidprocessed);

        }



        }

    }
