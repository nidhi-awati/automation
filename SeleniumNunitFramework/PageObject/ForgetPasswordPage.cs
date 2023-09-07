using OpenQA.Selenium;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SeleniumNunitFramework.PageObject

{
    public class ForgetPasswordPage
    {
        By ForgetPassword = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[4]/span[1]");
        By ForgetPasswordEmail = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]");
        By ForgetPasswordSubmitButton = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/form[1]/div[2]/button[1]");
        By BackToLoginButton = By.XPath("//div[@i18next-orgval-0=' Back to Login']");
        
        public void ClickForgetPassword(string email)

        {

            BrowserActions.Click(ForgetPassword);
            BrowserActions.Type(ForgetPasswordEmail, email);
           // BrowserActions.Click(ForgetPasswordSubmitButton);
            BrowserActions.Click(BackToLoginButton);
        }

    }
}


