using OpenQA.Selenium;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.PageObject
{
    internal class ShipmentsPage
    {
        By Email = By.XPath("//input[@placeholder='hello@gmail.com']");
        By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginButton = By.XPath("//button[normalize-space()='Login']");
        By EyeIcon = By.XPath("//span[2]//*[name()='svg']");
        By ForgetPassword = By.XPath("");
        By DropDownBtn = By.XPath("");

        public void Login(string email, string pass)
        {

            BrowserActions.Type(Email, email);
            BrowserActions.Type(Password, pass);
            BrowserActions.Click(EyeIcon);
            BrowserActions.Click(LoginButton);

        }
    }
}
