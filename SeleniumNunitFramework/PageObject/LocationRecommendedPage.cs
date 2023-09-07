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
    public class LocationRecommendedPage :BaseSetup

    {
        By EmailField = By.XPath("/ html[1] / body[1] / div[1] / div[1] / div[2] / div[2] / div[3] / form[1] / div[1] / input[1]");
        By PasswordFeild=By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By ContactMgmtBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[3]/a[1]/div[1]");
        By ContactBtn = By.XPath("//a[@id='contacts']");
        By EllipseBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[1]/div[9]/span[1]/*[name()='svg'][1]");
        By StartMeetingBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]");
        By NewOrderBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[5]/div[1]/div[1]/div[1]/button[1]");
        By LoctionFilteredSku = By.XPath("//body/div/div/div/div/div/div/div/div/div/div[1]/div[1]");
       
        public void LocationRecommendedFC(string email, string password)
        {
            BrowserActions.Type(EmailField, email);
            BrowserActions.Type(PasswordFeild, password);
            BrowserActions.Click(LoginBtn);
            Thread.Sleep(50000);
            BrowserActions.Click(ContactMgmtBtn);
            BrowserActions.Click(ContactBtn);
            BrowserActions.Click(EllipseBtn);
            BrowserActions.Click(StartMeetingBtn);
            BrowserActions.Click(NewOrderBtn);
            BrowserActions.Click(LoctionFilteredSku);

          

        }
       
    }
}
