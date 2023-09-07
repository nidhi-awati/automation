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
    public class FraudFilterPage : BaseSetup

    {
        By EmailField = By.XPath("/ html[1] / body[1] / div[1] / div[1] / div[2] / div[2] / div[3] / form[1] / div[1] / input[1]");
        By PasswordField = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By OrderMgmtBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[5]/a[1]/div[1]/span[1]");
        By OrderProssBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[5]/div[1]/a[18]");
        By FilterBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/button[1]/img[1]");
        By FilterDropDownBtn = By.XPath("//option[contains(@i18next-orgval-0,'Literal Duplicate')]");
    
        By ApplyBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[9]/div[2]/button[1]");


        public void FraudFilterFC(string email,string password)
        {
            BrowserActions.Type(EmailField, email);
            BrowserActions.Type(PasswordField, password);
            BrowserActions.Click(LoginBtn);
            Thread.Sleep(50000);
            BrowserActions.Click(OrderMgmtBtn);
            BrowserActions.Click(OrderProssBtn);
            BrowserActions.Click(FilterBtn);
            BrowserActions.Click(FilterDropDownBtn);
            BrowserActions.Click(ApplyBtn);

        }
        

        }
    }

